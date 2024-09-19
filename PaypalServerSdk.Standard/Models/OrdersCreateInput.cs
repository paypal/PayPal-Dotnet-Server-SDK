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
using PaypalServerSDK.Standard;
using PaypalServerSDK.Standard.Utilities;

namespace PaypalServerSDK.Standard.Models
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
        /// <param name="paypalRequestId">PayPal-Request-Id.</param>
        /// <param name="paypalPartnerAttributionId">PayPal-Partner-Attribution-Id.</param>
        /// <param name="paypalClientMetadataId">PayPal-Client-Metadata-Id.</param>
        /// <param name="prefer">Prefer.</param>
        public OrdersCreateInput(
            string contentType,
            Models.OrderRequest body,
            string paypalRequestId = null,
            string paypalPartnerAttributionId = null,
            string paypalClientMetadataId = null,
            string prefer = "return=minimal")
        {
            this.ContentType = contentType;
            this.Body = body;
            this.PaypalRequestId = paypalRequestId;
            this.PaypalPartnerAttributionId = paypalPartnerAttributionId;
            this.PaypalClientMetadataId = paypalClientMetadataId;
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
        public string PaypalRequestId { get; set; }

        /// <summary>
        /// Gets or sets PaypalPartnerAttributionId.
        /// </summary>
        [JsonProperty("PayPal-Partner-Attribution-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalPartnerAttributionId { get; set; }

        /// <summary>
        /// Gets or sets PaypalClientMetadataId.
        /// </summary>
        [JsonProperty("PayPal-Client-Metadata-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalClientMetadataId { get; set; }

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
                ((this.PaypalRequestId == null && other.PaypalRequestId == null) || (this.PaypalRequestId?.Equals(other.PaypalRequestId) == true)) &&
                ((this.PaypalPartnerAttributionId == null && other.PaypalPartnerAttributionId == null) || (this.PaypalPartnerAttributionId?.Equals(other.PaypalPartnerAttributionId) == true)) &&
                ((this.PaypalClientMetadataId == null && other.PaypalClientMetadataId == null) || (this.PaypalClientMetadataId?.Equals(other.PaypalClientMetadataId) == true)) &&
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
            toStringOutput.Add($"this.PaypalRequestId = {(this.PaypalRequestId == null ? "null" : this.PaypalRequestId)}");
            toStringOutput.Add($"this.PaypalPartnerAttributionId = {(this.PaypalPartnerAttributionId == null ? "null" : this.PaypalPartnerAttributionId)}");
            toStringOutput.Add($"this.PaypalClientMetadataId = {(this.PaypalClientMetadataId == null ? "null" : this.PaypalClientMetadataId)}");
            toStringOutput.Add($"this.Prefer = {(this.Prefer == null ? "null" : this.Prefer)}");
        }
    }
}