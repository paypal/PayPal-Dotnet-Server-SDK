// <copyright file="GetCapturedPaymentInput.cs" company="APIMatic">
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
    /// GetCapturedPaymentInput.
    /// </summary>
    public class GetCapturedPaymentInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCapturedPaymentInput"/> class.
        /// </summary>
        public GetCapturedPaymentInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCapturedPaymentInput"/> class.
        /// </summary>
        /// <param name="captureId">capture_id.</param>
        /// <param name="paypalMockResponse">PayPal-Mock-Response.</param>
        public GetCapturedPaymentInput(
            string captureId,
            string paypalMockResponse = null)
        {
            this.CaptureId = captureId;
            this.PaypalMockResponse = paypalMockResponse;
        }

        /// <summary>
        /// The PayPal-generated ID for the captured payment for which to show details.
        /// </summary>
        [JsonProperty("capture_id")]
        public string CaptureId { get; set; }

        /// <summary>
        /// PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant.
        /// </summary>
        [JsonProperty("PayPal-Mock-Response", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalMockResponse { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetCapturedPaymentInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetCapturedPaymentInput other &&
                (this.CaptureId == null && other.CaptureId == null ||
                 this.CaptureId?.Equals(other.CaptureId) == true) &&
                (this.PaypalMockResponse == null && other.PaypalMockResponse == null ||
                 this.PaypalMockResponse?.Equals(other.PaypalMockResponse) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CaptureId = {this.CaptureId ?? "null"}");
            toStringOutput.Add($"PaypalMockResponse = {this.PaypalMockResponse ?? "null"}");
        }
    }
}