// <copyright file="OrdersAuthorizeInput.cs" company="APIMatic">
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
    /// OrdersAuthorizeInput.
    /// </summary>
    public class OrdersAuthorizeInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersAuthorizeInput"/> class.
        /// </summary>
        public OrdersAuthorizeInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersAuthorizeInput"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contentType">Content-Type.</param>
        /// <param name="payPalRequestId">PayPal-Request-Id.</param>
        /// <param name="prefer">Prefer.</param>
        /// <param name="payPalClientMetadataId">PayPal-Client-Metadata-Id.</param>
        /// <param name="payPalAuthAssertion">PayPal-Auth-Assertion.</param>
        /// <param name="body">body.</param>
        public OrdersAuthorizeInput(
            string id,
            string contentType,
            string payPalRequestId = null,
            string prefer = "return=minimal",
            string payPalClientMetadataId = null,
            string payPalAuthAssertion = null,
            Models.OrderAuthorizeRequest body = null)
        {
            this.Id = id;
            this.ContentType = contentType;
            this.PayPalRequestId = payPalRequestId;
            this.Prefer = prefer;
            this.PayPalClientMetadataId = payPalClientMetadataId;
            this.PayPalAuthAssertion = payPalAuthAssertion;
            this.Body = body;
        }

        /// <summary>
        /// The ID of the order for which to authorize.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets ContentType.
        /// </summary>
        [JsonProperty("Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// The server stores keys for 6 hours. The API callers can request the times to up to 72 hours by speaking to their Account Manager.
        /// </summary>
        [JsonProperty("PayPal-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalRequestId { get; set; }

        /// <summary>
        /// The preferred server response upon successful completion of the request. Value is:<ul><li><code>return=minimal</code>. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the <code>id</code>, <code>status</code> and HATEOAS links.</li><li><code>return=representation</code>. The server returns a complete resource representation, including the current state of the resource.</li></ul>
        /// </summary>
        [JsonProperty("Prefer", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefer { get; set; }

        /// <summary>
        /// Gets or sets PayPalClientMetadataId.
        /// </summary>
        [JsonProperty("PayPal-Client-Metadata-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalClientMetadataId { get; set; }

        /// <summary>
        /// An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see <a href="https://developer.paypal.com/api/rest/requests/#paypal-auth-assertion">PayPal-Auth-Assertion</a>.
        /// </summary>
        [JsonProperty("PayPal-Auth-Assertion", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalAuthAssertion { get; set; }

        /// <summary>
        /// Gets or sets Body.
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderAuthorizeRequest Body { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrdersAuthorizeInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is OrdersAuthorizeInput other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.ContentType == null && other.ContentType == null) || (this.ContentType?.Equals(other.ContentType) == true)) &&
                ((this.PayPalRequestId == null && other.PayPalRequestId == null) || (this.PayPalRequestId?.Equals(other.PayPalRequestId) == true)) &&
                ((this.Prefer == null && other.Prefer == null) || (this.Prefer?.Equals(other.Prefer) == true)) &&
                ((this.PayPalClientMetadataId == null && other.PayPalClientMetadataId == null) || (this.PayPalClientMetadataId?.Equals(other.PayPalClientMetadataId) == true)) &&
                ((this.PayPalAuthAssertion == null && other.PayPalAuthAssertion == null) || (this.PayPalAuthAssertion?.Equals(other.PayPalAuthAssertion) == true)) &&
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
            toStringOutput.Add($"this.PayPalRequestId = {(this.PayPalRequestId == null ? "null" : this.PayPalRequestId)}");
            toStringOutput.Add($"this.Prefer = {(this.Prefer == null ? "null" : this.Prefer)}");
            toStringOutput.Add($"this.PayPalClientMetadataId = {(this.PayPalClientMetadataId == null ? "null" : this.PayPalClientMetadataId)}");
            toStringOutput.Add($"this.PayPalAuthAssertion = {(this.PayPalAuthAssertion == null ? "null" : this.PayPalAuthAssertion)}");
            toStringOutput.Add($"this.Body = {(this.Body == null ? "null" : this.Body.ToString())}");
        }
    }
}