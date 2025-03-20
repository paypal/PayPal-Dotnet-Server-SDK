// <copyright file="CreateOrderTrackingInput.cs" company="APIMatic">
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
    /// CreateOrderTrackingInput.
    /// </summary>
    public class CreateOrderTrackingInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderTrackingInput"/> class.
        /// </summary>
        public CreateOrderTrackingInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderTrackingInput"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contentType">Content-Type.</param>
        /// <param name="body">body.</param>
        /// <param name="paypalAuthAssertion">PayPal-Auth-Assertion.</param>
        public CreateOrderTrackingInput(
            string id,
            string contentType,
            Models.OrderTrackerRequest body,
            string paypalAuthAssertion = null)
        {
            this.Id = id;
            this.ContentType = contentType;
            this.Body = body;
            this.PaypalAuthAssertion = paypalAuthAssertion;
        }

        /// <summary>
        /// The ID of the order that the tracking information is associated with.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets ContentType.
        /// </summary>
        [JsonProperty("Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets Body.
        /// </summary>
        [JsonProperty("body")]
        public Models.OrderTrackerRequest Body { get; set; }

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
            return $"CreateOrderTrackingInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateOrderTrackingInput other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.ContentType == null && other.ContentType == null ||
                 this.ContentType?.Equals(other.ContentType) == true) &&
                (this.Body == null && other.Body == null ||
                 this.Body?.Equals(other.Body) == true) &&
                (this.PaypalAuthAssertion == null && other.PaypalAuthAssertion == null ||
                 this.PaypalAuthAssertion?.Equals(other.PaypalAuthAssertion) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"ContentType = {this.ContentType ?? "null"}");
            toStringOutput.Add($"Body = {(this.Body == null ? "null" : this.Body.ToString())}");
            toStringOutput.Add($"PaypalAuthAssertion = {this.PaypalAuthAssertion ?? "null"}");
        }
    }
}