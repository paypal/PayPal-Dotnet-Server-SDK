// <copyright file="LogBuilder.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using APIMatic.Core.Utilities.Logger;
using APIMatic.Core.Utilities.Logger.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace PayPalRESTAPIs.Standard.Logging
{
    /// <summary>
    /// Builder class for logging configuration"/>.
    /// </summary>
    public class LogBuilder
    {
        private ILogger _logger;
        private LogLevel? _logLevel;
        private bool _maskSensitiveHeaders;
        private RequestLoggingConfiguration _requestLoggingConfiguration;
        private ResponseLoggingConfiguration _responseLoggingConfiguration;

        private LogBuilder(ILogger logger, LogLevel? logLevel, bool maskSensitiveHeaders,
            RequestLoggingConfiguration requestLoggingConfiguration,
            ResponseLoggingConfiguration responseLoggingConfiguration)
        {
            _logger = logger;
            _logLevel = logLevel;
            _maskSensitiveHeaders = maskSensitiveHeaders;
            _requestLoggingConfiguration = requestLoggingConfiguration;
            _responseLoggingConfiguration = responseLoggingConfiguration;
        }

        /// <summary>
        /// Creates a <see cref="LogBuilder"/> instance from the provided logging configuration.
        /// </summary>
        /// <param name="loggingConfiguration">The logging configuration.</param>
        /// <returns>A new <see cref="LogBuilder"/> instance.</returns>
        public static LogBuilder CreateFromConfig(SdkLoggingConfiguration loggingConfiguration)
        {
            return new LogBuilder(
                loggingConfiguration.Logger,
                loggingConfiguration.LogLevel,
                loggingConfiguration.MaskSensitiveHeaders,
                loggingConfiguration.RequestLoggingConfiguration,
                loggingConfiguration.ResponseLoggingConfiguration);
        }
        
        /// <summary>
        /// Sets the logger for the logging configuration.
        /// </summary>
        /// <param name="logger">The logger to set.</param>
        /// <returns>The builder instance.</returns>
        public LogBuilder Logger(ILogger logger)
        {
            _logger = logger;
            return this;
        }

        /// <summary>
        /// Sets the log level for the logging configuration.
        /// </summary>
        /// <param name="logLevel">The log level to set.</param>
        /// <returns>The builder instance.</returns>
        public LogBuilder LogLevel(LogLevel? logLevel)
        {
            _logLevel = logLevel;
            return this;
        }

        /// <summary>
        /// Sets whether to mask sensitive headers in the logging configuration.
        /// </summary>
        /// <param name="maskSensitiveHeaders">A boolean indicating whether to mask sensitive headers.</param>
        /// <returns>The builder instance.</returns>
        public LogBuilder MaskSensitiveHeaders(bool maskSensitiveHeaders)
        {
            _maskSensitiveHeaders = maskSensitiveHeaders;
            return this;
        }
        
        /// <summary>
        /// Configures request logging.
        /// </summary>
        /// <param name="action">An action to configure request logging.</param>
        /// <returns>The builder instance.</returns>
        public LogBuilder RequestConfig(Action<LogRequestBuilder> action)
        {
            var logRequestBuilder = LogRequestBuilder.FromRequestConfig(_requestLoggingConfiguration);
            action(logRequestBuilder);
            _requestLoggingConfiguration = logRequestBuilder.Build();
            return this;
        }

        /// <summary>
        /// Configures response logging.
        /// </summary>
        /// <param name="action">An action to configure response logging.</param>
        /// <returns>The builder instance.</returns>
        public LogBuilder ResponseConfig(Action<LogResponseBuilder> action)
        {
            var logResponseBuilder = LogResponseBuilder.FromRequestConfig(_responseLoggingConfiguration);
            action(logResponseBuilder);
            _responseLoggingConfiguration = logResponseBuilder.Build();
            return this;
        }

        /// <summary>
        /// Builds the <see cref="SdkLoggingConfiguration"/>.
        /// </summary>
        /// <returns>The configured instance of <see cref="SdkLoggingConfiguration"/>.</returns>
        internal SdkLoggingConfiguration Build() =>
            SdkLoggingConfiguration.Builder(_logger,
                _logLevel,
                _maskSensitiveHeaders,
                _requestLoggingConfiguration,
                _responseLoggingConfiguration);
    }

    /// <summary>
    /// Builder class for request logging configuration"/>.
    /// </summary>
    public class LogRequestBuilder
    {
        private bool _logBody;
        private bool _logHeaders;
        private bool _includeQueryInPath;
        private IReadOnlyCollection<string> _headersToInclude;
        private IReadOnlyCollection<string> _headersToExclude;
        private IReadOnlyCollection<string> _headersToUnmask;

        private LogRequestBuilder(bool logBody, bool logHeaders, bool includeQueryInPath,
            IReadOnlyCollection<string> headersToInclude, IReadOnlyCollection<string> headersToExclude,
            IReadOnlyCollection<string> headersToUnmask)
        {
            _logBody = logBody;
            _logHeaders = logHeaders;
            _includeQueryInPath = includeQueryInPath;
            _headersToInclude = headersToInclude;
            _headersToExclude = headersToExclude;
            _headersToUnmask = headersToUnmask;
        }

        internal static LogRequestBuilder FromRequestConfig(RequestLoggingConfiguration requestLoggingConfiguration) =>
            new LogRequestBuilder(
                requestLoggingConfiguration.Body,
                requestLoggingConfiguration.Headers,
                requestLoggingConfiguration.IncludeQueryInPath,
                requestLoggingConfiguration.HeadersToInclude,
                requestLoggingConfiguration.HeadersToExclude,
                requestLoggingConfiguration.HeadersToUnmask);

        /// <summary>
        /// Sets whether to include the request body in the logging configuration.
        /// </summary>
        /// <param name="includeBody">A boolean indicating whether to include the body.</param>
        /// <returns>The builder instance.</returns>
        public LogRequestBuilder Body(bool includeBody)
        {
            _logBody = includeBody;
            return this;
        }

        /// <summary>
        /// Sets whether to include the request headers in the logging configuration.
        /// </summary>
        /// <param name="includeHeaders">A boolean indicating whether to include the headers.</param>
        /// <returns>The builder instance.</returns>
        public LogRequestBuilder Headers(bool includeHeaders)
        {
            _logHeaders = includeHeaders;
            return this;
        }

        /// <summary>
        /// Sets whether to include the query string in the request path in the logging configuration.
        /// </summary>
        /// <param name="includeQueryInPath">A boolean indicating whether to include the query in path.</param>
        /// <returns>The builder instance.</returns>
        public LogRequestBuilder IncludeQueryInPath(bool includeQueryInPath)
        {
            _includeQueryInPath = includeQueryInPath;
            return this;
        }

        /// <summary>
        /// Sets the headers to include in the request logging configuration.
        /// </summary>
        /// <param name="headersToInclude">The headers to include.</param>
        /// <returns>The builder instance.</returns>
        public LogRequestBuilder IncludeHeaders(params string[] headersToInclude)
        {
            _headersToInclude = headersToInclude;
            return this;
        }

        /// <summary>
        /// Sets the headers to exclude from the request logging configuration.
        /// </summary>
        /// <param name="headersToExclude">The headers to exclude.</param>
        /// <returns>The builder instance.</returns>
        public LogRequestBuilder ExcludeHeaders(params string[] headersToExclude)
        {
            _headersToExclude = headersToExclude;
            return this;
        }

        /// <summary>
        /// Sets the headers to unmask in the request logging configuration.
        /// </summary>
        /// <param name="headersToUnmask">The headers to unmask.</param>
        /// <returns>The builder instance.</returns>
        public LogRequestBuilder UnmaskHeaders(params string[] headersToUnmask)
        {
            _headersToUnmask = headersToUnmask;
            return this;
        }

        /// <summary>
        /// Builds the <see cref="RequestLoggingConfiguration"/>.
        /// </summary>
        /// <returns>The configured instance of <see cref="RequestLoggingConfiguration"/>.</returns>
        internal RequestLoggingConfiguration Build() =>
            RequestLoggingConfiguration.Builder(_logBody, _logHeaders, _includeQueryInPath,
                _headersToInclude, _headersToExclude, _headersToUnmask);
    }

    /// <summary>
    /// Builder for response logging configuration."/>.
    /// </summary>
    public class LogResponseBuilder
    {
        private bool _logBody;
        private bool _logHeaders;
        private IReadOnlyCollection<string> _headersToInclude;
        private IReadOnlyCollection<string> _headersToExclude;
        private IReadOnlyCollection<string> _headersToUnmask;

        private LogResponseBuilder(bool logBody, bool logHeaders, IReadOnlyCollection<string> headersToInclude,
            IReadOnlyCollection<string> headersToExclude, IReadOnlyCollection<string> headersToUnmask)
        {
            _logBody = logBody;
            _logHeaders = logHeaders;
            _headersToInclude = headersToInclude;
            _headersToExclude = headersToExclude;
            _headersToUnmask = headersToUnmask;
        }

        internal static LogResponseBuilder FromRequestConfig(ResponseLoggingConfiguration responseLoggingConfiguration) =>
            new LogResponseBuilder(
                responseLoggingConfiguration.Body,
                responseLoggingConfiguration.Headers,
                responseLoggingConfiguration.HeadersToInclude,
                responseLoggingConfiguration.HeadersToExclude,
                responseLoggingConfiguration.HeadersToUnmask);

        /// <summary>
        /// Sets whether to include the response body in the logging configuration.
        /// </summary>
        /// <param name="includeBody">A boolean indicating whether to include the body.</param>
        /// <returns>The builder instance.</returns>
        public LogResponseBuilder Body(bool includeBody)
        {
            _logBody = includeBody;
            return this;
        }

        /// <summary>
        /// Sets whether to include the response headers in the logging configuration.
        /// </summary>
        /// <param name="includeHeaders">A boolean indicating whether to include the headers.</param>
        /// <returns>The builder instance.</returns>
        public LogResponseBuilder Headers(bool includeHeaders)
        {
            _logHeaders = includeHeaders;
            return this;
        }

        /// <summary>
        /// Sets the headers to include in the response logging configuration.
        /// </summary>
        /// <param name="headersToInclude">The headers to include.</param>
        /// <returns>The builder instance.</returns>
        public LogResponseBuilder IncludeHeaders(params string[] headersToInclude)
        {
            _headersToInclude = headersToInclude;
            return this;
        }

        /// <summary>
        /// Sets the headers to exclude from the response logging configuration.
        /// </summary>
        /// <param name="headersToExclude">The headers to exclude.</param>
        /// <returns>The builder instance.</returns>
        public LogResponseBuilder ExcludeHeaders(params string[] headersToExclude)
        {
            _headersToExclude = headersToExclude;
            return this;
        }

        /// <summary>
        /// Sets the headers to unmask in the response logging configuration.
        /// </summary>
        /// <param name="headersToUnmask">The headers to unmask.</param>
        /// <returns>The builder instance.</returns>
        public LogResponseBuilder UnmaskHeaders(params string[] headersToUnmask)
        {
            _headersToUnmask = headersToUnmask;
            return this;
        }

        /// <summary>
        /// Builds the <see cref="ResponseLoggingConfiguration"/>.
        /// </summary>
        /// <returns>The configured instance of <see cref="ResponseLoggingConfiguration"/>.</returns>
        internal ResponseLoggingConfiguration Build() =>
            ResponseLoggingConfiguration.Builder(_logBody, _logHeaders,
                _headersToInclude, _headersToExclude, _headersToUnmask);
    }
}
