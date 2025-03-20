// <copyright file="ErrorException.cs" company="APIMatic">
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
using PaypalServerSdk.Standard;
using PaypalServerSdk.Standard.Http.Client;
using PaypalServerSdk.Standard.Models;
using PaypalServerSdk.Standard.Utilities;

namespace PaypalServerSdk.Standard.Exceptions
{
    /// <summary>
    /// ErrorException.
    /// </summary>
    public class ErrorException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// The human-readable, unique name of the error.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The message that describes the error.
        /// </summary>
        [JsonProperty("message")]
        public new string Message { get; set; }

        /// <summary>
        /// The PayPal internal ID. Used for correlation purposes.
        /// </summary>
        [JsonProperty("debug_id")]
        public string DebugId { get; set; }

        /// <summary>
        /// An array of additional details about the error.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ErrorDetails> Details { get; set; }

        /// <summary>
        /// An array of request-related [HATEOAS links](/api/rest/responses/#hateoas-links).
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LinkDescription> Links { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ErrorException : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            base.ToString(toStringOutput);
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Message = {this.Message ?? "null"}");
            toStringOutput.Add($"DebugId = {this.DebugId ?? "null"}");
            toStringOutput.Add($"Details = {(this.Details == null ? "null" : $"[{string.Join(", ", this.Details)} ]")}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
        }
    }
}