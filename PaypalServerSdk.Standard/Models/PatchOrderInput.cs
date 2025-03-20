// <copyright file="PatchOrderInput.cs" company="APIMatic">
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
    /// PatchOrderInput.
    /// </summary>
    public class PatchOrderInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrderInput"/> class.
        /// </summary>
        public PatchOrderInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrderInput"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contentType">Content-Type.</param>
        /// <param name="paypalMockResponse">PayPal-Mock-Response.</param>
        /// <param name="paypalAuthAssertion">PayPal-Auth-Assertion.</param>
        /// <param name="body">body.</param>
        public PatchOrderInput(
            string id,
            string contentType,
            string paypalMockResponse = null,
            string paypalAuthAssertion = null,
            List<Models.Patch> body = null)
        {
            this.Id = id;
            this.ContentType = contentType;
            this.PaypalMockResponse = paypalMockResponse;
            this.PaypalAuthAssertion = paypalAuthAssertion;
            this.Body = body;
        }

        /// <summary>
        /// The ID of the order to update.
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
        /// An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see PayPal-Auth-Assertion.
        /// </summary>
        [JsonProperty("PayPal-Auth-Assertion", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalAuthAssertion { get; set; }

        /// <summary>
        /// Gets or sets Body.
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Patch> Body { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PatchOrderInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PatchOrderInput other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.ContentType == null && other.ContentType == null ||
                 this.ContentType?.Equals(other.ContentType) == true) &&
                (this.PaypalMockResponse == null && other.PaypalMockResponse == null ||
                 this.PaypalMockResponse?.Equals(other.PaypalMockResponse) == true) &&
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
            toStringOutput.Add($"PaypalAuthAssertion = {this.PaypalAuthAssertion ?? "null"}");
            toStringOutput.Add($"Body = {(this.Body == null ? "null" : $"[{string.Join(", ", this.Body)} ]")}");
        }
    }
}