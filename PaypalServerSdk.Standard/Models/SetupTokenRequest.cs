// <copyright file="SetupTokenRequest.cs" company="APIMatic">
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
    /// SetupTokenRequest.
    /// </summary>
    public class SetupTokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetupTokenRequest"/> class.
        /// </summary>
        public SetupTokenRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetupTokenRequest"/> class.
        /// </summary>
        /// <param name="paymentSource">payment_source.</param>
        /// <param name="customer">customer.</param>
        public SetupTokenRequest(
            Models.SetupTokenRequestPaymentSource paymentSource,
            Models.Customer customer = null)
        {
            this.Customer = customer;
            this.PaymentSource = paymentSource;
        }

        /// <summary>
        /// This object defines a customer in your system. Use it to manage customer profiles, save payment methods and contact details.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Customer Customer { get; set; }

        /// <summary>
        /// The payment method to vault with the instrument details.
        /// </summary>
        [JsonProperty("payment_source")]
        public Models.SetupTokenRequestPaymentSource PaymentSource { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SetupTokenRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SetupTokenRequest other &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                (this.PaymentSource == null && other.PaymentSource == null ||
                 this.PaymentSource?.Equals(other.PaymentSource) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"PaymentSource = {(this.PaymentSource == null ? "null" : this.PaymentSource.ToString())}");
        }
    }
}