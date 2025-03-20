// <copyright file="OrderAuthorizeRequestPaymentSource.cs" company="APIMatic">
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
    /// OrderAuthorizeRequestPaymentSource.
    /// </summary>
    public class OrderAuthorizeRequestPaymentSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAuthorizeRequestPaymentSource"/> class.
        /// </summary>
        public OrderAuthorizeRequestPaymentSource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAuthorizeRequestPaymentSource"/> class.
        /// </summary>
        /// <param name="card">card.</param>
        /// <param name="token">token.</param>
        /// <param name="paypal">paypal.</param>
        /// <param name="applePay">apple_pay.</param>
        /// <param name="googlePay">google_pay.</param>
        /// <param name="venmo">venmo.</param>
        public OrderAuthorizeRequestPaymentSource(
            Models.CardRequest card = null,
            Models.Token token = null,
            Models.PaypalWallet paypal = null,
            Models.ApplePayRequest applePay = null,
            Models.GooglePayRequest googlePay = null,
            Models.VenmoWalletRequest venmo = null)
        {
            this.Card = card;
            this.Token = token;
            this.Paypal = paypal;
            this.ApplePay = applePay;
            this.GooglePay = googlePay;
            this.Venmo = venmo;
        }

        /// <summary>
        /// The payment card to use to fund a payment. Can be a credit or debit card. Note: Passing card number, cvv and expiry directly via the API requires PCI SAQ D compliance. *PayPal offers a mechanism by which you do not have to take on the PCI SAQ D burden by using hosted fields - refer to this Integration Guide*.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardRequest Card { get; set; }

        /// <summary>
        /// The tokenized payment source to fund a payment.
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Token Token { get; set; }

        /// <summary>
        /// A resource that identifies a PayPal Wallet is used for payment.
        /// </summary>
        [JsonProperty("paypal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalWallet Paypal { get; set; }

        /// <summary>
        /// Information needed to pay using ApplePay.
        /// </summary>
        [JsonProperty("apple_pay", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplePayRequest ApplePay { get; set; }

        /// <summary>
        /// Information needed to pay using Google Pay.
        /// </summary>
        [JsonProperty("google_pay", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GooglePayRequest GooglePay { get; set; }

        /// <summary>
        /// Information needed to pay using Venmo.
        /// </summary>
        [JsonProperty("venmo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VenmoWalletRequest Venmo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderAuthorizeRequestPaymentSource : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderAuthorizeRequestPaymentSource other &&
                (this.Card == null && other.Card == null ||
                 this.Card?.Equals(other.Card) == true) &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.Paypal == null && other.Paypal == null ||
                 this.Paypal?.Equals(other.Paypal) == true) &&
                (this.ApplePay == null && other.ApplePay == null ||
                 this.ApplePay?.Equals(other.ApplePay) == true) &&
                (this.GooglePay == null && other.GooglePay == null ||
                 this.GooglePay?.Equals(other.GooglePay) == true) &&
                (this.Venmo == null && other.Venmo == null ||
                 this.Venmo?.Equals(other.Venmo) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"Token = {(this.Token == null ? "null" : this.Token.ToString())}");
            toStringOutput.Add($"Paypal = {(this.Paypal == null ? "null" : this.Paypal.ToString())}");
            toStringOutput.Add($"ApplePay = {(this.ApplePay == null ? "null" : this.ApplePay.ToString())}");
            toStringOutput.Add($"GooglePay = {(this.GooglePay == null ? "null" : this.GooglePay.ToString())}");
            toStringOutput.Add($"Venmo = {(this.Venmo == null ? "null" : this.Venmo.ToString())}");
        }
    }
}