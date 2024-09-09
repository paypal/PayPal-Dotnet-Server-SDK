// <copyright file="PaypalServerSDKClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using APIMatic.Core;
using APIMatic.Core.Authentication;
using APIMatic.Core.Utilities.Logger.Configuration;
using PaypalServerSDK.Standard.Authentication;
using PaypalServerSDK.Standard.Controllers;
using PaypalServerSDK.Standard.Http.Client;
using PaypalServerSDK.Standard.Logging;
using PaypalServerSDK.Standard.Utilities;

namespace PaypalServerSDK.Standard
{
    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class PaypalServerSDKClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://api-m.paypal.com" },
                }
            },
            {
                Environment.Sandbox, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://api-m.sandbox.paypal.com" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private SdkLoggingConfiguration sdkLoggingConfiguration;
        private const string userAgent = "PayPal REST API DotNet SDK, Version: 0.5.1, on OS {os-info}";
        private readonly HttpCallback httpCallback;
        private readonly Lazy<OrdersController> orders;
        private readonly Lazy<PaymentsController> payments;
        private readonly Lazy<VaultController> vault;
        private readonly Lazy<OAuthAuthorizationController> oAuthAuthorization;

        private PaypalServerSDKClient(
            Environment environment,
            ClientCredentialsAuthModel clientCredentialsAuthModel,
            HttpCallback httpCallback,
            IHttpClientConfiguration httpClientConfiguration,
            SdkLoggingConfiguration sdkLoggingConfiguration)
        {
            this.Environment = environment;
            this.httpCallback = httpCallback;
            this.HttpClientConfiguration = httpClientConfiguration;
            this.sdkLoggingConfiguration = sdkLoggingConfiguration;
            ClientCredentialsAuthModel = clientCredentialsAuthModel;
            var clientCredentialsAuthManager = new ClientCredentialsAuthManager(clientCredentialsAuthModel);
            clientCredentialsAuthManager.ApplyGlobalConfiguration(() => OAuthAuthorizationController);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"Oauth2", clientCredentialsAuthManager},
                })
                .ApiCallback(httpCallback)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .LoggingConfig(sdkLoggingConfiguration)
                .UserAgent(userAgent)
                .Build();

            ClientCredentialsAuth = clientCredentialsAuthManager;

            this.orders = new Lazy<OrdersController>(
                () => new OrdersController(globalConfiguration));
            this.payments = new Lazy<PaymentsController>(
                () => new PaymentsController(globalConfiguration));
            this.vault = new Lazy<VaultController>(
                () => new VaultController(globalConfiguration));
            this.oAuthAuthorization = new Lazy<OAuthAuthorizationController>(
                () => new OAuthAuthorizationController(globalConfiguration));
        }

        /// <summary>
        /// Gets OrdersController controller.
        /// </summary>
        public OrdersController OrdersController => this.orders.Value;

        /// <summary>
        /// Gets PaymentsController controller.
        /// </summary>
        public PaymentsController PaymentsController => this.payments.Value;

        /// <summary>
        /// Gets VaultController controller.
        /// </summary>
        public VaultController VaultController => this.vault.Value;

        /// <summary>
        /// Gets OAuthAuthorizationController controller.
        /// </summary>
        public OAuthAuthorizationController OAuthAuthorizationController => this.oAuthAuthorization.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        public HttpCallback HttpCallback => this.httpCallback;

        /// <summary>
        /// Gets the credentials to use with ClientCredentialsAuth.
        /// </summary>
        public IClientCredentialsAuth ClientCredentialsAuth { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with ClientCredentialsAuth.
        /// </summary>
        public ClientCredentialsAuthModel ClientCredentialsAuthModel { get; private set; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the PaypalServerSDKClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .HttpCallback(httpCallback)
                .LoggingConfig(sdkLoggingConfiguration)
                .HttpClientConfig(config => config.Build());

            if (ClientCredentialsAuthModel != null)
            {
                builder.ClientCredentialsAuth(ClientCredentialsAuthModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> PaypalServerSDKClient.</returns>
        internal static PaypalServerSDKClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("PAYPAL_SERVER_SDK_STANDARD_ENVIRONMENT");
            string oAuthClientId = System.Environment.GetEnvironmentVariable("PAYPAL_SERVER_SDK_STANDARD_O_AUTH_CLIENT_ID");
            string oAuthClientSecret = System.Environment.GetEnvironmentVariable("PAYPAL_SERVER_SDK_STANDARD_O_AUTH_CLIENT_SECRET");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (oAuthClientId != null && oAuthClientSecret != null)
            {
                builder.ClientCredentialsAuth(new ClientCredentialsAuthModel
                .Builder(oAuthClientId, oAuthClientSecret)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = PaypalServerSDK.Standard.Environment.Sandbox;
            private ClientCredentialsAuthModel clientCredentialsAuthModel = new ClientCredentialsAuthModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallback httpCallback;
            private SdkLoggingConfiguration sdkLoggingConfiguration;

            /// <summary>
            /// Sets credentials for ClientCredentialsAuth.
            /// </summary>
            /// <param name="clientCredentialsAuthModel">ClientCredentialsAuthModel.</param>
            /// <returns>Builder.</returns>
            public Builder ClientCredentialsAuth(ClientCredentialsAuthModel clientCredentialsAuthModel)
            {
                if (clientCredentialsAuthModel is null)
                {
                    throw new ArgumentNullException(nameof(clientCredentialsAuthModel));
                }

                this.clientCredentialsAuthModel = clientCredentialsAuthModel;
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

            /// <summary>
            /// Sets the default logging configuration, using the Console logger.
            /// </summary>
            /// <returns>Builder.</returns>
            public Builder LoggingConfig()
            {
                this.sdkLoggingConfiguration = SdkLoggingConfiguration.Console();
                return this;
            }

            /// <summary>
            /// Sets the logging configuration using the provided <paramref name="action"/>.
            /// </summary>
            /// <param name="action">The action to perform on the logging configuration builder.</param>
            /// <returns>Builder.</returns>
            /// <exception cref="ArgumentNullException">Thrown when <paramref name="action"/> is null.</exception>
            public Builder LoggingConfig(Action<LogBuilder> action)
            {
                if (action is null) throw new ArgumentNullException(nameof(action));
                var logBuilder =
                    LogBuilder.CreateFromConfig(sdkLoggingConfiguration ?? SdkLoggingConfiguration.Console());
                action(logBuilder);
                this.sdkLoggingConfiguration = logBuilder.Build();
                return this;
            }

            internal Builder LoggingConfig(SdkLoggingConfiguration configuration)
            {
                sdkLoggingConfiguration = configuration;
                return this;
            }



            /// <summary>
            /// Sets the HttpCallback for the Builder.
            /// </summary>
            /// <param name="httpCallback"> http callback. </param>
            /// <returns>Builder.</returns>
            public Builder HttpCallback(HttpCallback httpCallback)
            {
                this.httpCallback = httpCallback;
                return this;
            }

            /// <summary>
            /// Creates an object of the PaypalServerSDKClient using the values provided for the builder.
            /// </summary>
            /// <returns>PaypalServerSDKClient.</returns>
            public PaypalServerSDKClient Build()
            {
                if (clientCredentialsAuthModel.OAuthClientId == null || clientCredentialsAuthModel.OAuthClientSecret == null)
                {
                    clientCredentialsAuthModel = null;
                }
                return new PaypalServerSDKClient(
                    environment,
                    clientCredentialsAuthModel,
                    httpCallback,
                    httpClientConfig.Build(),
                    sdkLoggingConfiguration);
            }
        }
    }
}
