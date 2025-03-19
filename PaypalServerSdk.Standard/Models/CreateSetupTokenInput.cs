// <copyright file="CreateSetupTokenInput.cs" company="APIMatic">
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
    /// CreateSetupTokenInput.
    /// </summary>
    public class CreateSetupTokenInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSetupTokenInput"/> class.
        /// </summary>
        public CreateSetupTokenInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSetupTokenInput"/> class.
        /// </summary>
        /// <param name="contentType">Content-Type.</param>
        /// <param name="body">body.</param>
        /// <param name="paypalRequestId">PayPal-Request-Id.</param>
        public CreateSetupTokenInput(
            string contentType,
            Models.SetupTokenRequest body,
            string paypalRequestId = null)
        {
            this.ContentType = contentType;
            this.Body = body;
            this.PaypalRequestId = paypalRequestId;
        }

        /// <summary>
        /// Gets or sets ContentType.
        /// </summary>
        [JsonProperty("Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Setup Token creation with a instrument type optional financial instrument details and customer_id.
        /// </summary>
        [JsonProperty("body")]
        public Models.SetupTokenRequest Body { get; set; }

        /// <summary>
        /// The server stores keys for 3 hours.
        /// </summary>
        [JsonProperty("PayPal-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalRequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateSetupTokenInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateSetupTokenInput other &&
                (this.ContentType == null && other.ContentType == null ||
                 this.ContentType?.Equals(other.ContentType) == true) &&
                (this.Body == null && other.Body == null ||
                 this.Body?.Equals(other.Body) == true) &&
                (this.PaypalRequestId == null && other.PaypalRequestId == null ||
                 this.PaypalRequestId?.Equals(other.PaypalRequestId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ContentType = {this.ContentType ?? "null"}");
            toStringOutput.Add($"Body = {(this.Body == null ? "null" : this.Body.ToString())}");
            toStringOutput.Add($"PaypalRequestId = {this.PaypalRequestId ?? "null"}");
        }
    }
}