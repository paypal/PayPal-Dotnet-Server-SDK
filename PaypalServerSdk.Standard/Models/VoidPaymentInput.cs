// <copyright file="VoidPaymentInput.cs" company="APIMatic">
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
    /// VoidPaymentInput.
    /// </summary>
    public class VoidPaymentInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoidPaymentInput"/> class.
        /// </summary>
        public VoidPaymentInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidPaymentInput"/> class.
        /// </summary>
        /// <param name="authorizationId">authorization_id.</param>
        /// <param name="paypalMockResponse">PayPal-Mock-Response.</param>
        /// <param name="paypalAuthAssertion">PayPal-Auth-Assertion.</param>
        /// <param name="paypalRequestId">PayPal-Request-Id.</param>
        /// <param name="prefer">Prefer.</param>
        public VoidPaymentInput(
            string authorizationId,
            string paypalMockResponse = null,
            string paypalAuthAssertion = null,
            string paypalRequestId = null,
            string prefer = "return=minimal")
        {
            this.AuthorizationId = authorizationId;
            this.PaypalMockResponse = paypalMockResponse;
            this.PaypalAuthAssertion = paypalAuthAssertion;
            this.PaypalRequestId = paypalRequestId;
            this.Prefer = prefer;
        }

        /// <summary>
        /// The PayPal-generated ID for the authorized payment to void.
        /// </summary>
        [JsonProperty("authorization_id")]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant.
        /// </summary>
        [JsonProperty("PayPal-Mock-Response", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalMockResponse { get; set; }

        /// <summary>
        /// An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion). Note:For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject.
        /// </summary>
        [JsonProperty("PayPal-Auth-Assertion", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalAuthAssertion { get; set; }

        /// <summary>
        /// The server stores keys for 45 days.
        /// </summary>
        [JsonProperty("PayPal-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalRequestId { get; set; }

        /// <summary>
        /// The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.
        /// </summary>
        [JsonProperty("Prefer", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"VoidPaymentInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is VoidPaymentInput other &&
                (this.AuthorizationId == null && other.AuthorizationId == null ||
                 this.AuthorizationId?.Equals(other.AuthorizationId) == true) &&
                (this.PaypalMockResponse == null && other.PaypalMockResponse == null ||
                 this.PaypalMockResponse?.Equals(other.PaypalMockResponse) == true) &&
                (this.PaypalAuthAssertion == null && other.PaypalAuthAssertion == null ||
                 this.PaypalAuthAssertion?.Equals(other.PaypalAuthAssertion) == true) &&
                (this.PaypalRequestId == null && other.PaypalRequestId == null ||
                 this.PaypalRequestId?.Equals(other.PaypalRequestId) == true) &&
                (this.Prefer == null && other.Prefer == null ||
                 this.Prefer?.Equals(other.Prefer) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AuthorizationId = {this.AuthorizationId ?? "null"}");
            toStringOutput.Add($"PaypalMockResponse = {this.PaypalMockResponse ?? "null"}");
            toStringOutput.Add($"PaypalAuthAssertion = {this.PaypalAuthAssertion ?? "null"}");
            toStringOutput.Add($"PaypalRequestId = {this.PaypalRequestId ?? "null"}");
            toStringOutput.Add($"Prefer = {this.Prefer ?? "null"}");
        }
    }
}