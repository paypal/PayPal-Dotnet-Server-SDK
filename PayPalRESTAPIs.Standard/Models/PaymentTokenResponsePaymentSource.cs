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
using PayPalRESTAPIs.Standard;
using PayPalRESTAPIs.Standard.Utilities;

namespace PayPalRESTAPIs.Standard.Models
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
        /// <param name="bank">bank.</param>
        public PaymentTokenResponsePaymentSource(
            Models.CardPaymentToken card = null,
            Models.PayPalPaymentToken paypal = null,
            Models.VenmoPaymentToken venmo = null,
            Models.ApplePayPaymentToken applePay = null,
            Models.BankPaymentToken bank = null)
        {
            this.Card = card;
            this.Paypal = paypal;
            this.Venmo = venmo;
            this.ApplePay = applePay;
            this.Bank = bank;
        }

        /// <summary>
        /// Full representation of a Card Payment Token including network token.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardPaymentToken Card { get; set; }

        /// <summary>
        /// Gets or sets Paypal.
        /// </summary>
        [JsonProperty("paypal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayPalPaymentToken Paypal { get; set; }

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

        /// <summary>
        /// Full representation of a Bank Payment Token.
        /// </summary>
        [JsonProperty("bank", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankPaymentToken Bank { get; set; }

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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is PaymentTokenResponsePaymentSource other &&                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.Paypal == null && other.Paypal == null) || (this.Paypal?.Equals(other.Paypal) == true)) &&
                ((this.Venmo == null && other.Venmo == null) || (this.Venmo?.Equals(other.Venmo) == true)) &&
                ((this.ApplePay == null && other.ApplePay == null) || (this.ApplePay?.Equals(other.ApplePay) == true)) &&
                ((this.Bank == null && other.Bank == null) || (this.Bank?.Equals(other.Bank) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.Paypal = {(this.Paypal == null ? "null" : this.Paypal.ToString())}");
            toStringOutput.Add($"this.Venmo = {(this.Venmo == null ? "null" : this.Venmo.ToString())}");
            toStringOutput.Add($"this.ApplePay = {(this.ApplePay == null ? "null" : this.ApplePay.ToString())}");
            toStringOutput.Add($"this.Bank = {(this.Bank == null ? "null" : this.Bank.ToString())}");
        }
    }
}