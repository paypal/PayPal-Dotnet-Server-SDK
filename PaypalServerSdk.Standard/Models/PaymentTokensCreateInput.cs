// <copyright file="PaymentTokensCreateInput.cs" company="APIMatic">
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
using PaypalServerSDK.Standard;
using PaypalServerSDK.Standard.Utilities;

namespace PaypalServerSDK.Standard.Models
{
    /// <summary>
    /// PaymentTokensCreateInput.
    /// </summary>
    public class PaymentTokensCreateInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokensCreateInput"/> class.
        /// </summary>
        public PaymentTokensCreateInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokensCreateInput"/> class.
        /// </summary>
        /// <param name="paypalRequestId">PayPal-Request-Id.</param>
        /// <param name="contentType">Content-Type.</param>
        /// <param name="body">body.</param>
        public PaymentTokensCreateInput(
            string paypalRequestId,
            string contentType,
            Models.PaymentTokenRequest body)
        {
            this.PaypalRequestId = paypalRequestId;
            this.ContentType = contentType;
            this.Body = body;
        }

        /// <summary>
        /// The server stores keys for 3 hours.
        /// </summary>
        [JsonProperty("PayPal-Request-Id")]
        public string PaypalRequestId { get; set; }

        /// <summary>
        /// Gets or sets ContentType.
        /// </summary>
        [JsonProperty("Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Payment Token creation with a financial instrument and an optional customer_id.
        /// </summary>
        [JsonProperty("body")]
        public Models.PaymentTokenRequest Body { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentTokensCreateInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is PaymentTokensCreateInput other &&                ((this.PaypalRequestId == null && other.PaypalRequestId == null) || (this.PaypalRequestId?.Equals(other.PaypalRequestId) == true)) &&
                ((this.ContentType == null && other.ContentType == null) || (this.ContentType?.Equals(other.ContentType) == true)) &&
                ((this.Body == null && other.Body == null) || (this.Body?.Equals(other.Body) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PaypalRequestId = {(this.PaypalRequestId == null ? "null" : this.PaypalRequestId)}");
            toStringOutput.Add($"this.ContentType = {(this.ContentType == null ? "null" : this.ContentType)}");
            toStringOutput.Add($"this.Body = {(this.Body == null ? "null" : this.Body.ToString())}");
        }
    }
}