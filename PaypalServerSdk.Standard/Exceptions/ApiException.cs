// <copyright file="ApiException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Types.Sdk;
using PaypalServerSdk.Standard.Http.Client;
using PaypalServerSdk.Standard.Http.Request;
using PaypalServerSdk.Standard.Http.Response;
using System.Collections.Generic;

namespace PaypalServerSdk.Standard.Exceptions
{
    /// <summary>
    /// This is the base class for all exceptions that represent an error response
    /// from the server. It inherits from [`System.Exception`](https://learn.microsoft.com/en-us/dotnet/api/system.exception).
    /// </summary>
    public class ApiException : CoreApiException<HttpRequest, HttpResponse, HttpContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ApiException(string reason, HttpContext context = null) : base(reason, context) { }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            ToString(toStringOutput);
            return $"ApiException : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StatusCode = {HttpContext?.Response?.StatusCode}");
            toStringOutput.Add($"Message = {Message}");
        }
    }
}