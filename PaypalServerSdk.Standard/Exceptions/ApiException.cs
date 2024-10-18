// <copyright file="ApiException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Types.Sdk;
using PaypalServerSdk.Standard.Http.Client;
using PaypalServerSdk.Standard.Http.Request;
using PaypalServerSdk.Standard.Http.Response;

namespace PaypalServerSdk.Standard.Exceptions
{
    /// <summary>
    /// This is the base class for all exceptions that represent an error response
    /// from the server.
    /// </summary>
    public class ApiException : CoreApiException<HttpRequest, HttpResponse, HttpContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ApiException(string reason, HttpContext context = null) : base(reason, context) { }
    }
}