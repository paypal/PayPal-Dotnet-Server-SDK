// <copyright file="AuthorizeOrderInput.cs" company="APIMatic">
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
    /// AuthorizeOrderInput.
    /// </summary>
    public class AuthorizeOrderInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeOrderInput"/> class.
        /// </summary>
        public AuthorizeOrderInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeOrderInput"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contentType">Content-Type.</param>
        /// <param name="paypalMockResponse">PayPal-Mock-Response.</param>
        /// <param name="paypalRequestId">PayPal-Request-Id.</param>
        /// <param name="prefer">Prefer.</param>
        /// <param name="paypalClientMetadataId">PayPal-Client-Metadata-Id.</param>
        /// <param name="paypalAuthAssertion">PayPal-Auth-Assertion.</param>
        /// <param name="body">body.</param>
        public AuthorizeOrderInput(
            string id,
            string contentType,
            string paypalMockResponse = null,
            string paypalRequestId = null,
            string prefer = "return=minimal",
            string paypalClientMetadataId = null,
            string paypalAuthAssertion = null,
            Models.OrderAuthorizeRequest body = null)
        {
            this.Id = id;
            this.ContentType = contentType;
            this.PaypalMockResponse = paypalMockResponse;
            this.PaypalRequestId = paypalRequestId;
            this.Prefer = prefer;
            this.PaypalClientMetadataId = paypalClientMetadataId;
            this.PaypalAuthAssertion = paypalAuthAssertion;
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
        /// The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.
        /// </summary>
        [JsonProperty("Prefer", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefer { get; set; }

        /// <summary>
        /// Gets or sets PaypalClientMetadataId.
        /// </summary>
        [JsonProperty("PayPal-Client-Metadata-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalClientMetadataId { get; set; }

        /// <summary>
        /// An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see PayPal-Auth-Assertion.
        /// </summary>
        [JsonProperty("PayPal-Auth-Assertion", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalAuthAssertion { get; set; }

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
            return $"AuthorizeOrderInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AuthorizeOrderInput other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.ContentType == null && other.ContentType == null ||
                 this.ContentType?.Equals(other.ContentType) == true) &&
                (this.PaypalMockResponse == null && other.PaypalMockResponse == null ||
                 this.PaypalMockResponse?.Equals(other.PaypalMockResponse) == true) &&
                (this.PaypalRequestId == null && other.PaypalRequestId == null ||
                 this.PaypalRequestId?.Equals(other.PaypalRequestId) == true) &&
                (this.Prefer == null && other.Prefer == null ||
                 this.Prefer?.Equals(other.Prefer) == true) &&
                (this.PaypalClientMetadataId == null && other.PaypalClientMetadataId == null ||
                 this.PaypalClientMetadataId?.Equals(other.PaypalClientMetadataId) == true) &&
                (this.PaypalAuthAssertion == null && other.PaypalAuthAssertion == null ||
                 this.PaypalAuthAssertion?.Equals(other.PaypalAuthAssertion) == true) &&
                (this.Body == null && other.Body == null ||
                 this.Body?.Equals(other.Body) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"ContentType = {this.ContentType ?? "null"}");
            toStringOutput.Add($"PaypalMockResponse = {this.PaypalMockResponse ?? "null"}");
            toStringOutput.Add($"PaypalRequestId = {this.PaypalRequestId ?? "null"}");
            toStringOutput.Add($"Prefer = {this.Prefer ?? "null"}");
            toStringOutput.Add($"PaypalClientMetadataId = {this.PaypalClientMetadataId ?? "null"}");
            toStringOutput.Add($"PaypalAuthAssertion = {this.PaypalAuthAssertion ?? "null"}");
            toStringOutput.Add($"Body = {(this.Body == null ? "null" : this.Body.ToString())}");
        }
    }
}