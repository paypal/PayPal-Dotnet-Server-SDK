// <copyright file="PaymentTokenResponsePaymentSource.cs" company="APIMatic">
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
    /// PaymentTokenResponsePaymentSource.
    /// </summary>
    public class PaymentTokenResponsePaymentSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenResponsePaymentSource"/> class.
        /// </summary>
        public PaymentTokenResponsePaymentSource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenResponsePaymentSource"/> class.
        /// </summary>
        /// <param name="card">card.</param>
        /// <param name="paypal">paypal.</param>
        /// <param name="venmo">venmo.</param>
        /// <param name="applePay">apple_pay.</param>
        public PaymentTokenResponsePaymentSource(
            Models.CardPaymentTokenEntity card = null,
            Models.PaypalPaymentToken paypal = null,
            Models.VenmoPaymentToken venmo = null,
            Models.ApplePayPaymentToken applePay = null)
        {
            this.Card = card;
            this.Paypal = paypal;
            this.Venmo = venmo;
            this.ApplePay = applePay;
        }

        /// <summary>
        /// Full representation of a Card Payment Token including network token.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardPaymentTokenEntity Card { get; set; }

        /// <summary>
        /// Gets or sets Paypal.
        /// </summary>
        [JsonProperty("paypal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalPaymentToken Paypal { get; set; }

        /// <summary>
        /// Gets or sets Venmo.
        /// </summary>
        [JsonProperty("venmo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VenmoPaymentToken Venmo { get; set; }

        /// <summary>
        /// A resource representing a response for Apple Pay.
        /// </summary>
        [JsonProperty("apple_pay", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplePayPaymentToken ApplePay { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaymentTokenResponsePaymentSource : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaymentTokenResponsePaymentSource other &&
                (this.Card == null && other.Card == null ||
                 this.Card?.Equals(other.Card) == true) &&
                (this.Paypal == null && other.Paypal == null ||
                 this.Paypal?.Equals(other.Paypal) == true) &&
                (this.Venmo == null && other.Venmo == null ||
                 this.Venmo?.Equals(other.Venmo) == true) &&
                (this.ApplePay == null && other.ApplePay == null ||
                 this.ApplePay?.Equals(other.ApplePay) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"Paypal = {(this.Paypal == null ? "null" : this.Paypal.ToString())}");
            toStringOutput.Add($"Venmo = {(this.Venmo == null ? "null" : this.Venmo.ToString())}");
            toStringOutput.Add($"ApplePay = {(this.ApplePay == null ? "null" : this.ApplePay.ToString())}");
        }
    }
}