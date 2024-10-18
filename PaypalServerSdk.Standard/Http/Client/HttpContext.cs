// <copyright file="HttpContext.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Types.Sdk;
using PaypalServerSdk.Standard.Http.Request;
using PaypalServerSdk.Standard.Http.Response;

namespace PaypalServerSdk.Standard.Http.Client
{
    /// <summary>
    /// Represents the contextual information of HTTP request and response.
    /// </summary>
    public sealed class HttpContext : CoreContext<HttpRequest, HttpResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpContext"/> class.
        /// </summary>
        /// <param name="request">The http request in the current context.</param>
        /// <param name="response">The http response in the current context.</param>
        public HttpContext(HttpRequest request, HttpResponse response)
            : base(request, response) { }
    }

}
