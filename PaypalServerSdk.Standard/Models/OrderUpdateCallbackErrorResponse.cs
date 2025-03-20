// <copyright file="OrderUpdateCallbackErrorResponse.cs" company="APIMatic">
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
using PaypalServerSdk.Standard.Utilities;

namespace PaypalServerSdk.Standard.Models
{
    /// <summary>
    /// OrderUpdateCallbackErrorResponse.
    /// </summary>
    public class OrderUpdateCallbackErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateCallbackErrorResponse"/> class.
        /// </summary>
        public OrderUpdateCallbackErrorResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateCallbackErrorResponse"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="message">message.</param>
        /// <param name="details">details.</param>
        public OrderUpdateCallbackErrorResponse(
            string name,
            string message = null,
            List<Models.OrderUpdateCallbackErrorResponseDetails> details = null)
        {
            this.Name = name;
            this.Message = message;
            this.Details = details;
        }

        /// <summary>
        /// The human-readable, unique name of the error.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The message that describes the error.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// An array of additional details about the error.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.OrderUpdateCallbackErrorResponseDetails> Details { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderUpdateCallbackErrorResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderUpdateCallbackErrorResponse other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Message == null && other.Message == null ||
                 this.Message?.Equals(other.Message) == true) &&
                (this.Details == null && other.Details == null ||
                 this.Details?.Equals(other.Details) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Message = {this.Message ?? "null"}");
            toStringOutput.Add($"Details = {(this.Details == null ? "null" : $"[{string.Join(", ", this.Details)} ]")}");
        }
    }
}