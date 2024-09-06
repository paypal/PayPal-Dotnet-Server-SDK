// <copyright file="PaymentTokenRequest.cs" company="APIMatic">
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
    /// PaymentTokenRequest.
    /// </summary>
    public class PaymentTokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenRequest"/> class.
        /// </summary>
        public PaymentTokenRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenRequest"/> class.
        /// </summary>
        /// <param name="paymentSource">payment_source.</param>
        /// <param name="customer">customer.</param>
        public PaymentTokenRequest(
            Models.PaymentTokenRequestPaymentSource paymentSource,
            Models.CustomerRequest customer = null)
        {
            this.Customer = customer;
            this.PaymentSource = paymentSource;
        }

        /// <summary>
        /// Customer in merchant's or partner's system of records.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerRequest Customer { get; set; }

        /// <summary>
        /// The payment method to vault with the instrument details.
        /// </summary>
        [JsonProperty("payment_source")]
        public Models.PaymentTokenRequestPaymentSource PaymentSource { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentTokenRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentTokenRequest other &&                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.PaymentSource == null && other.PaymentSource == null) || (this.PaymentSource?.Equals(other.PaymentSource) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.PaymentSource = {(this.PaymentSource == null ? "null" : this.PaymentSource.ToString())}");
        }
    }
}