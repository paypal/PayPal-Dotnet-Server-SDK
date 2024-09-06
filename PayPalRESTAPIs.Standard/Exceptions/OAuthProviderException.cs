// <copyright file="OAuthProviderException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PayPalRESTAPIs.Standard;
using PayPalRESTAPIs.Standard.Http.Client;
using PayPalRESTAPIs.Standard.Models;
using PayPalRESTAPIs.Standard.Utilities;

namespace PayPalRESTAPIs.Standard.Exceptions
{
    /// <summary>
    /// OAuthProviderException.
    /// </summary>
    public class OAuthProviderException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthProviderException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public OAuthProviderException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets error code.
        /// </summary>
        [JsonProperty("error")]
        public Models.OAuthProviderError Error { get; set; }

        /// <summary>
        /// Gets or sets human-readable text providing additional information on error.
        /// Used to assist the client developer in understanding the error that occurred.
        /// </summary>
        [JsonProperty("error_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Gets or sets a URI identifying a human-readable web page with information about the error, used to provide the client developer with additional information about the error.
        /// </summary>
        [JsonProperty("error_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorUri { get; set; }
    }
}