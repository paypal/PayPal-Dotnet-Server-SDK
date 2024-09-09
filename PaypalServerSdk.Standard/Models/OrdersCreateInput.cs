// <copyright file="OrdersCreateInput.cs" company="APIMatic">
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
    /// OrdersCreateInput.
    /// </summary>
    public class OrdersCreateInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersCreateInput"/> class.
        /// </summary>
        public OrdersCreateInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersCreateInput"/> class.
        /// </summary>
        /// <param name="contentType">Content-Type.</param>
        /// <param name="body">body.</param>
        /// <param name="payPalRequestId">PayPal-Request-Id.</param>
        /// <param name="payPalPartnerAttributionId">PayPal-Partner-Attribution-Id.</param>
        /// <param name="payPalClientMetadataId">PayPal-Client-Metadata-Id.</param>
        /// <param name="prefer">Prefer.</param>
        public OrdersCreateInput(
            string contentType,
            Models.OrderRequest body,
            string payPalRequestId = null,
            string payPalPartnerAttributionId = null,
            string payPalClientMetadataId = null,
            string prefer = "return=minimal")
        {
            this.ContentType = contentType;
            this.Body = body;
            this.PayPalRequestId = payPalRequestId;
            this.PayPalPartnerAttributionId = payPalPartnerAttributionId;
            this.PayPalClientMetadataId = payPalClientMetadataId;
            this.Prefer = prefer;
        }

        /// <summary>
        /// Gets or sets ContentType.
        /// </summary>
        [JsonProperty("Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets Body.
        /// </summary>
        [JsonProperty("body")]
        public Models.OrderRequest Body { get; set; }

        /// <summary>
        /// The server stores keys for 6 hours. The API callers can request the times to up to 72 hours by speaking to their Account Manager.
        /// </summary>
        [JsonProperty("PayPal-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalRequestId { get; set; }

        /// <summary>
        /// Gets or sets PayPalPartnerAttributionId.
        /// </summary>
        [JsonProperty("PayPal-Partner-Attribution-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalPartnerAttributionId { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrdersCreateInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is OrdersCreateInput other &&                ((this.ContentType == null && other.ContentType == null) || (this.ContentType?.Equals(other.ContentType) == true)) &&
                ((this.Body == null && other.Body == null) || (this.Body?.Equals(other.Body) == true)) &&
                ((this.PayPalRequestId == null && other.PayPalRequestId == null) || (this.PayPalRequestId?.Equals(other.PayPalRequestId) == true)) &&
                ((this.PayPalPartnerAttributionId == null && other.PayPalPartnerAttributionId == null) || (this.PayPalPartnerAttributionId?.Equals(other.PayPalPartnerAttributionId) == true)) &&
                ((this.PayPalClientMetadataId == null && other.PayPalClientMetadataId == null) || (this.PayPalClientMetadataId?.Equals(other.PayPalClientMetadataId) == true)) &&
                ((this.Prefer == null && other.Prefer == null) || (this.Prefer?.Equals(other.Prefer) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ContentType = {(this.ContentType == null ? "null" : this.ContentType)}");
            toStringOutput.Add($"this.Body = {(this.Body == null ? "null" : this.Body.ToString())}");
            toStringOutput.Add($"this.PayPalRequestId = {(this.PayPalRequestId == null ? "null" : this.PayPalRequestId)}");
            toStringOutput.Add($"this.PayPalPartnerAttributionId = {(this.PayPalPartnerAttributionId == null ? "null" : this.PayPalPartnerAttributionId)}");
            toStringOutput.Add($"this.PayPalClientMetadataId = {(this.PayPalClientMetadataId == null ? "null" : this.PayPalClientMetadataId)}");
            toStringOutput.Add($"this.Prefer = {(this.Prefer == null ? "null" : this.Prefer)}");
        }
    }
}