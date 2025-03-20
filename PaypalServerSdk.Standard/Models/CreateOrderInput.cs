// <copyright file="CreateOrderInput.cs" company="APIMatic">
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
    /// CreateOrderInput.
    /// </summary>
    public class CreateOrderInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderInput"/> class.
        /// </summary>
        public CreateOrderInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderInput"/> class.
        /// </summary>
        /// <param name="contentType">Content-Type.</param>
        /// <param name="body">body.</param>
        /// <param name="paypalMockResponse">PayPal-Mock-Response.</param>
        /// <param name="paypalRequestId">PayPal-Request-Id.</param>
        /// <param name="paypalPartnerAttributionId">PayPal-Partner-Attribution-Id.</param>
        /// <param name="paypalClientMetadataId">PayPal-Client-Metadata-Id.</param>
        /// <param name="prefer">Prefer.</param>
        /// <param name="paypalAuthAssertion">PayPal-Auth-Assertion.</param>
        public CreateOrderInput(
            string contentType,
            Models.OrderRequest body,
            string paypalMockResponse = null,
            string paypalRequestId = null,
            string paypalPartnerAttributionId = null,
            string paypalClientMetadataId = null,
            string prefer = "return=minimal",
            string paypalAuthAssertion = null)
        {
            this.ContentType = contentType;
            this.Body = body;
            this.PaypalMockResponse = paypalMockResponse;
            this.PaypalRequestId = paypalRequestId;
            this.PaypalPartnerAttributionId = paypalPartnerAttributionId;
            this.PaypalClientMetadataId = paypalClientMetadataId;
            this.Prefer = prefer;
            this.PaypalAuthAssertion = paypalAuthAssertion;
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
        /// PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant.
        /// </summary>
        [JsonProperty("PayPal-Mock-Response", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalMockResponse { get; set; }

        /// <summary>
        /// The server stores keys for 6 hours. The API callers can request the times to up to 72 hours by speaking to their Account Manager. It is mandatory for all single-step create order calls (E.g. Create Order Request with payment source information like Card, PayPal.vault_id, PayPal.billing_agreement_id, etc).
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
        /// The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.
        /// </summary>
        [JsonProperty("Prefer", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefer { get; set; }

        /// <summary>
        /// An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see PayPal-Auth-Assertion.
        /// </summary>
        [JsonProperty("PayPal-Auth-Assertion", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalAuthAssertion { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateOrderInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateOrderInput other &&
                (this.ContentType == null && other.ContentType == null ||
                 this.ContentType?.Equals(other.ContentType) == true) &&
                (this.Body == null && other.Body == null ||
                 this.Body?.Equals(other.Body) == true) &&
                (this.PaypalMockResponse == null && other.PaypalMockResponse == null ||
                 this.PaypalMockResponse?.Equals(other.PaypalMockResponse) == true) &&
                (this.PaypalRequestId == null && other.PaypalRequestId == null ||
                 this.PaypalRequestId?.Equals(other.PaypalRequestId) == true) &&
                (this.PaypalPartnerAttributionId == null && other.PaypalPartnerAttributionId == null ||
                 this.PaypalPartnerAttributionId?.Equals(other.PaypalPartnerAttributionId) == true) &&
                (this.PaypalClientMetadataId == null && other.PaypalClientMetadataId == null ||
                 this.PaypalClientMetadataId?.Equals(other.PaypalClientMetadataId) == true) &&
                (this.Prefer == null && other.Prefer == null ||
                 this.Prefer?.Equals(other.Prefer) == true) &&
                (this.PaypalAuthAssertion == null && other.PaypalAuthAssertion == null ||
                 this.PaypalAuthAssertion?.Equals(other.PaypalAuthAssertion) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ContentType = {this.ContentType ?? "null"}");
            toStringOutput.Add($"Body = {(this.Body == null ? "null" : this.Body.ToString())}");
            toStringOutput.Add($"PaypalMockResponse = {this.PaypalMockResponse ?? "null"}");
            toStringOutput.Add($"PaypalRequestId = {this.PaypalRequestId ?? "null"}");
            toStringOutput.Add($"PaypalPartnerAttributionId = {this.PaypalPartnerAttributionId ?? "null"}");
            toStringOutput.Add($"PaypalClientMetadataId = {this.PaypalClientMetadataId ?? "null"}");
            toStringOutput.Add($"Prefer = {this.Prefer ?? "null"}");
            toStringOutput.Add($"PaypalAuthAssertion = {this.PaypalAuthAssertion ?? "null"}");
        }
    }
}