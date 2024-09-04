// <copyright file="OrderCaptureRequest.cs" company="APIMatic">
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
using PayPalRESTAPIs.Standard;
using PayPalRESTAPIs.Standard.Utilities;

namespace PayPalRESTAPIs.Standard.Models
{
    /// <summary>
    /// OrderCaptureRequest.
    /// </summary>
    public class OrderCaptureRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCaptureRequest"/> class.
        /// </summary>
        public OrderCaptureRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCaptureRequest"/> class.
        /// </summary>
        /// <param name="paymentSource">payment_source.</param>
        public OrderCaptureRequest(
            Models.OrderCaptureRequestPaymentSource paymentSource = null)
        {
            this.PaymentSource = paymentSource;
        }

        /// <summary>
        /// The payment source definition.
        /// </summary>
        [JsonProperty("payment_source", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderCaptureRequestPaymentSource PaymentSource { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderCaptureRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is OrderCaptureRequest other &&                ((this.PaymentSource == null && other.PaymentSource == null) || (this.PaymentSource?.Equals(other.PaymentSource) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PaymentSource = {(this.PaymentSource == null ? "null" : this.PaymentSource.ToString())}");
        }
    }
}