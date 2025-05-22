// <copyright file="ClientCredentialsAuthManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PaypalServerSdk.Standard.Controllers;
using PaypalServerSdk.Standard.Http.Response;using PaypalServerSdk.Standard.Models;
using PaypalServerSdk.Standard.Utilities;
using PaypalServerSdk.Standard.Exceptions;
using APIMatic.Core.Authentication;
using APIMatic.Core.Request;
using APIMatic.Core;

namespace PaypalServerSdk.Standard.Authentication
{
    /// <summary>
    /// ClientCredentialsAuthManager Class.
    /// </summary>
    public class ClientCredentialsAuthManager : AuthManager, IClientCredentialsAuth
    {
        private readonly Func<OAuthAuthorizationController> getOAuthController;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCredentialsAuthManager"/> class.
        /// </summary>
        /// <param name="clientCredentialsAuth"> OAuth 2 Client Cridentials Model.</param>
        /// <param name="getOAuthController">A function that provides an instance of <see cref="OAuthAuthorizationController"/>.</param>
        internal ClientCredentialsAuthManager(ClientCredentialsAuthModel clientCredentialsAuth,
            Func<OAuthAuthorizationController> getOAuthController)
        {
            OAuthClientId = clientCredentialsAuth?.OAuthClientId;
            OAuthClientSecret = clientCredentialsAuth?.OAuthClientSecret;
            OAuthToken = clientCredentialsAuth?.OAuthToken;
            this.getOAuthController = getOAuthController;
            OAuthClockSkew = clientCredentialsAuth?.OAuthClockSkew;
            OAuthTokenProvider = clientCredentialsAuth?.OAuthTokenProvider;
            OAuthOnTokenUpdate = clientCredentialsAuth?.OAuthOnTokenUpdate;
            OAuthTokenAutoRefresh = clientCredentialsAuth?.OAuthToken;
        }

        /// <summary>
        /// Gets string value for oAuthClientId.
        /// </summary>
        public string OAuthClientId { get; }

        /// <summary>
        /// Gets string value for oAuthClientSecret.
        /// </summary>
        public string OAuthClientSecret { get; }

        /// <summary>
        /// Gets Models.OAuthToken value for oAuthToken.
        /// </summary>
        public Models.OAuthToken OAuthToken { get; }

        /// <summary>
        /// Gets TimeSpan? value for oAuthClockSkew.
        /// </summary>
        public TimeSpan? OAuthClockSkew { get; }

        /// <summary>
        /// Gets Func of OAuthToken value for oAuthTokenProvider.
        /// </summary>
        public Func<ClientCredentialsAuthManager, OAuthToken, Task<OAuthToken>> OAuthTokenProvider { get; }

        /// <summary>
        /// Gets Action of OAuthToken value for oAuthOnTokenUpdate.
        /// </summary>
        public Action<OAuthToken> OAuthOnTokenUpdate { get; }

        /// <summary>
        /// Gets OAuthToken value for oAuthTokenAutoRefresh.
        /// </summary>
        private OAuthToken OAuthTokenAutoRefresh { get; set; }

        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1);


        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="oAuthClientId"> The string value for credentials.</param>
        /// <param name="oAuthClientSecret"> The string value for credentials.</param>
        /// <param name="oAuthToken"> The Models.OAuthToken value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string oAuthClientId, string oAuthClientSecret, Models.OAuthToken oAuthToken)
        {
            return oAuthClientId.Equals(this.OAuthClientId)
                    && oAuthClientSecret.Equals(this.OAuthClientSecret)
                    && ((oAuthToken == null && this.OAuthToken == null) || (oAuthToken != null && this.OAuthToken != null && oAuthToken.Equals(this.OAuthToken)));
        }

        /// <summary>
        /// Fetch the OAuth token.
        /// </summary>
        /// <param name="additionalParameters">Dictionary of additional parameters.</param>
        /// <returns>Models.OAuthToken.</returns>
        public Models.OAuthToken FetchToken(Dictionary<string, object> additionalParameters = null)
            => ApiHelper.RunTask(FetchTokenAsync(additionalParameters));
       

        /// <summary>
        /// Fetch the OAuth token asynchronously.
        /// </summary>
        /// <param name="additionalParameters">Dictionary of additional parameters.</param>
        /// <returns>Models.OAuthToken.</returns>
        public async Task<Models.OAuthToken> FetchTokenAsync(Dictionary<string, object> additionalParameters = null)
        {
            var token = await getOAuthController().RequestTokenAsync(new RequestTokenInput()
            {
                Authorization = BuildBasicAuthHeader(),
            }, additionalParameters).ConfigureAwait(false);

            if (token.Data.ExpiresIn != null && token.Data.ExpiresIn != 0)
            {
                token.Data.Expiry = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds + token.Data.ExpiresIn;
            }

            return token.Data;
        }
 
        /// <summary>
        /// Checks if token is expired.
        /// </summary>
        /// <returns> Returns true if token is expired.</returns>
        public bool IsTokenExpired()
        {
           if (this.OAuthToken == null)
           {
               throw new InvalidOperationException("OAuth token is missing.");
           }
        
           return this.OAuthToken.Expiry != null
               && this.OAuthToken.Expiry < (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        /// <inheritdoc />
        public override async Task Apply(RequestBuilder requestBuilder)
        {
            var token = await FetchOrReturnToken().ConfigureAwait(false);
            Parameters(authParameter => authParameter
                .Header(headerParameter => headerParameter
                    .Setup("Authorization",
                        token?.AccessToken == null ? null : $"Bearer {token.AccessToken}"
                    ).Required()));
            await base.Apply(requestBuilder).ConfigureAwait(false);
        }

        private async Task<OAuthToken> FetchOrReturnToken()
        {
            if (OAuthTokenAutoRefresh != null && !OAuthTokenAutoRefresh.IsTokenExpired(OAuthClockSkew))
                return OAuthTokenAutoRefresh;

            await semaphoreSlim.WaitAsync().ConfigureAwait(false);
            try
            {
                if (OAuthTokenAutoRefresh != null && !OAuthTokenAutoRefresh.IsTokenExpired(OAuthClockSkew))
                    return OAuthTokenAutoRefresh;
                OAuthTokenAutoRefresh = OAuthTokenProvider != null
                    ? await OAuthTokenProvider(this, OAuthTokenAutoRefresh).ConfigureAwait(false)
                    : await FetchTokenAsync().ConfigureAwait(false);
            }
            finally
            {
                semaphoreSlim.Release();
            }

            OAuthOnTokenUpdate?.Invoke(OAuthTokenAutoRefresh);

            if (OAuthTokenAutoRefresh == null)
                throw new ApiException(
                    "Client is not authorized.An OAuth token is needed to make API calls.");

            if (OAuthTokenAutoRefresh.IsTokenExpired(TimeSpan.Zero))
                throw new ApiException("OAuth token is expired. A valid token is needed to make API calls.");

            return OAuthTokenAutoRefresh;
        }


        /// <summary>
        /// Build basic auth header.
        /// </summary>
        /// <returns> string. </returns>
        private string BuildBasicAuthHeader()
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(this.OAuthClientId + ':' + this.OAuthClientSecret);
            return "Basic " + Convert.ToBase64String(plainTextBytes);
        }
    }

    public sealed class ClientCredentialsAuthModel
    {
        internal ClientCredentialsAuthModel()
        {
        }

        internal string OAuthClientId { get; set; }

        internal string OAuthClientSecret { get; set; }

        internal Models.OAuthToken OAuthToken { get; set; }

        internal TimeSpan? OAuthClockSkew { get; set; }

        internal Func<ClientCredentialsAuthManager, OAuthToken, Task<OAuthToken>> OAuthTokenProvider { get; set; }

        internal Action<OAuthToken> OAuthOnTokenUpdate { get; set; }

        /// <summary>
        /// Creates an object of the ClientCredentialsAuthModel using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(OAuthClientId, OAuthClientSecret)
                .OAuthToken(OAuthToken)
                .OAuthClockSkew(OAuthClockSkew)
                .OAuthTokenProvider(OAuthTokenProvider)
                .OAuthOnTokenUpdate(OAuthOnTokenUpdate);
        }

        /// <summary>
        /// Builder class for ClientCredentialsAuthModel.
        /// </summary>
        public class Builder
        {
            private string oAuthClientId;
            private string oAuthClientSecret;
            private Models.OAuthToken oAuthToken;
            private TimeSpan? oAuthClockSkew;
            private Func<ClientCredentialsAuthManager, OAuthToken, Task<OAuthToken>> oAuthTokenProvider;
            private Action<OAuthToken> oAuthOnTokenUpdate;

            public Builder(string oAuthClientId, string oAuthClientSecret)
            {
                this.oAuthClientId = oAuthClientId ?? throw new ArgumentNullException(nameof(oAuthClientId));
                this.oAuthClientSecret = oAuthClientSecret ?? throw new ArgumentNullException(nameof(oAuthClientSecret));
            }

            /// <summary>
            /// Sets OAuthClientId.
            /// </summary>
            /// <param name="oAuthClientId">OAuthClientId.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthClientId(string oAuthClientId)
            {
                this.oAuthClientId = oAuthClientId ?? throw new ArgumentNullException(nameof(oAuthClientId));
                return this;
            }

            /// <summary>
            /// Sets OAuthClientSecret.
            /// </summary>
            /// <param name="oAuthClientSecret">OAuthClientSecret.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthClientSecret(string oAuthClientSecret)
            {
                this.oAuthClientSecret = oAuthClientSecret ?? throw new ArgumentNullException(nameof(oAuthClientSecret));
                return this;
            }

            /// <summary>
            /// Sets OAuthToken.
            /// </summary>
            /// <param name="oAuthToken">OAuthToken.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthToken(Models.OAuthToken oAuthToken)
            {
                this.oAuthToken = oAuthToken;
                return this;
            }

            /// <summary>
            /// Sets OAuthClockSkew.
            /// </summary>
            /// <param name="oAuthClockSkew">oAuthClockSkew.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthClockSkew(TimeSpan? oAuthClockSkew)
            {
                this.oAuthClockSkew = oAuthClockSkew;
                return this;
            }

            /// <summary>
            /// Sets OAuthTokenProvider.
            /// </summary>
            /// <param name="oAuthTokenProvider">oAuthTokenProvider.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthTokenProvider(Func<ClientCredentialsAuthManager, OAuthToken, Task<OAuthToken>> oAuthTokenProvider)
            {
                this.oAuthTokenProvider = oAuthTokenProvider;
                return this;
            }

            /// <summary>
            /// Sets OAuthOnTokenUpdate.
            /// </summary>
            /// <param name="oAuthOnTokenUpdate">oAuthOnTokenUpdate.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthOnTokenUpdate(Action<OAuthToken> oAuthOnTokenUpdate)
            {
                this.oAuthOnTokenUpdate = oAuthOnTokenUpdate;
                return this;
            }

            /// <summary>
            /// Creates an object of the ClientCredentialsAuthModel using the values provided for the builder.
            /// </summary>
            /// <returns>ClientCredentialsAuthModel.</returns>
            public ClientCredentialsAuthModel Build()
            {
                return new ClientCredentialsAuthModel()
                {
                    OAuthClientId = this.oAuthClientId,
                    OAuthClientSecret = this.oAuthClientSecret,
                    OAuthToken = this.oAuthToken,
                    OAuthClockSkew = this.oAuthClockSkew,
                    OAuthTokenProvider = this.oAuthTokenProvider,
                    OAuthOnTokenUpdate = this.oAuthOnTokenUpdate
                };
            }
        }
    }
}