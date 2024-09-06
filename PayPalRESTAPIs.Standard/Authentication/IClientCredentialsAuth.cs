// <copyright file="IClientCredentialsAuth.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PayPalRESTAPIs.Standard.Authentication
{
    public interface IClientCredentialsAuth
    {
        /// <summary>
        /// Gets string value for oAuthClientId.
        /// </summary>
        string OAuthClientId { get; }

        /// <summary>
        /// Gets string value for oAuthClientSecret.
        /// </summary>
        string OAuthClientSecret { get; }

        /// <summary>
        /// Gets Models.OAuthToken value for oAuthToken.
        /// </summary>
        Models.OAuthToken OAuthToken { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="oAuthClientId"> The string value for credentials.</param>
        /// <param name="oAuthClientSecret"> The string value for credentials.</param>
        /// <param name="oAuthToken"> The Models.OAuthToken value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string oAuthClientId, string oAuthClientSecret, Models.OAuthToken oAuthToken);

        /// <summary>
        /// Fetch the OAuth token asynchronously.
        /// </summary>
        /// <param name="additionalParameters">Dictionary of additional parameters.</param>
        /// <returns>OAuthToken.</returns>
        Task<Models.OAuthToken> FetchTokenAsync(Dictionary<string, object> additionalParameters = null);

        /// <summary>
        /// Fetch the OAuth token.
        /// </summary>
        /// <param name="additionalParameters">Dictionary of additional parameters.</param>
        /// <returns>OAuthToken.</returns>
        Models.OAuthToken FetchToken(Dictionary<string, object> additionalParameters = null);

        /// <summary>
        /// Checks if token is expired.
        /// </summary>
        /// <returns> Returns true if token is expired.</returns>
        bool IsTokenExpired();
    }
}