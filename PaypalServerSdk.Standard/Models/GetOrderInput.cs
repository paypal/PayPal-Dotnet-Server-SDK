// <copyright file="GetOrderInput.cs" company="APIMatic">
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
    /// GetOrderInput.
    /// </summary>
    public class GetOrderInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderInput"/> class.
        /// </summary>
        public GetOrderInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderInput"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="paypalMockResponse">PayPal-Mock-Response.</param>
        /// <param name="paypalAuthAssertion">PayPal-Auth-Assertion.</param>
        /// <param name="fields">fields.</param>
        public GetOrderInput(
            string id,
            string paypalMockResponse = null,
            string paypalAuthAssertion = null,
            string fields = null)
        {
            this.Id = id;
            this.PaypalMockResponse = paypalMockResponse;
            this.PaypalAuthAssertion = paypalAuthAssertion;
            this.Fields = fields;
        }

        /// <summary>
        /// The ID of the order for which to show details.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant.
        /// </summary>
        [JsonProperty("PayPal-Mock-Response", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalMockResponse { get; set; }

        /// <summary>
        /// An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see PayPal-Auth-Assertion.
        /// </summary>
        [JsonProperty("PayPal-Auth-Assertion", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalAuthAssertion { get; set; }

        /// <summary>
        /// A comma-separated list of fields that should be returned for the order. Valid filter field is `payment_source`.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public string Fields { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetOrderInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetOrderInput other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.PaypalMockResponse == null && other.PaypalMockResponse == null ||
                 this.PaypalMockResponse?.Equals(other.PaypalMockResponse) == true) &&
                (this.PaypalAuthAssertion == null && other.PaypalAuthAssertion == null ||
                 this.PaypalAuthAssertion?.Equals(other.PaypalAuthAssertion) == true) &&
                (this.Fields == null && other.Fields == null ||
                 this.Fields?.Equals(other.Fields) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"PaypalMockResponse = {this.PaypalMockResponse ?? "null"}");
            toStringOutput.Add($"PaypalAuthAssertion = {this.PaypalAuthAssertion ?? "null"}");
            toStringOutput.Add($"Fields = {this.Fields ?? "null"}");
        }
    }
}