// <copyright file="OrdersConfirmInput.cs" company="APIMatic">
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
    /// OrdersConfirmInput.
    /// </summary>
    public class OrdersConfirmInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersConfirmInput"/> class.
        /// </summary>
        public OrdersConfirmInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersConfirmInput"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contentType">Content-Type.</param>
        /// <param name="payPalClientMetadataId">PayPal-Client-Metadata-Id.</param>
        /// <param name="prefer">Prefer.</param>
        /// <param name="body">body.</param>
        public OrdersConfirmInput(
            string id,
            string contentType,
            string payPalClientMetadataId = null,
            string prefer = "return=minimal",
            Models.ConfirmOrderRequest body = null)
        {
            this.Id = id;
            this.ContentType = contentType;
            this.PayPalClientMetadataId = payPalClientMetadataId;
            this.Prefer = prefer;
            this.Body = body;
        }

        /// <summary>
        /// The ID of the order for which the payer confirms their intent to pay.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets ContentType.
        /// </summary>
        [JsonProperty("Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets PayPalClientMetadataId.
        /// </summary>
        [JsonProperty("PayPal-Client-Metadata-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalClientMetadataId { get; set; }

        /// <summary>
        /// The preferred server response upon successful completion of the request. Value is:<ul><li><code>return=minimal</code>. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the <code>id</code>, <code>status</code> and HATEOAS links.</li><li><code>return=representation</code>. The server returns a complete resource representation, including the current state of the resource.</li></ul>
        /// </summary>
        [JsonProperty("Prefer", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefer { get; set; }

        /// <summary>
        /// Gets or sets Body.
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ConfirmOrderRequest Body { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrdersConfirmInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is OrdersConfirmInput other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.ContentType == null && other.ContentType == null) || (this.ContentType?.Equals(other.ContentType) == true)) &&
                ((this.PayPalClientMetadataId == null && other.PayPalClientMetadataId == null) || (this.PayPalClientMetadataId?.Equals(other.PayPalClientMetadataId) == true)) &&
                ((this.Prefer == null && other.Prefer == null) || (this.Prefer?.Equals(other.Prefer) == true)) &&
                ((this.Body == null && other.Body == null) || (this.Body?.Equals(other.Body) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.ContentType = {(this.ContentType == null ? "null" : this.ContentType)}");
            toStringOutput.Add($"this.PayPalClientMetadataId = {(this.PayPalClientMetadataId == null ? "null" : this.PayPalClientMetadataId)}");
            toStringOutput.Add($"this.Prefer = {(this.Prefer == null ? "null" : this.Prefer)}");
            toStringOutput.Add($"this.Body = {(this.Body == null ? "null" : this.Body.ToString())}");
        }
    }
}