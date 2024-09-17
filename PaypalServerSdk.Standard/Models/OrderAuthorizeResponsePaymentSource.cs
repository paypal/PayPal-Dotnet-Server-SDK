// <copyright file="OrderAuthorizeResponsePaymentSource.cs" company="APIMatic">
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
using PaypalServerSDK.Standard;
using PaypalServerSDK.Standard.Utilities;

namespace PaypalServerSDK.Standard.Models
{
    /// <summary>
    /// OrderAuthorizeResponsePaymentSource.
    /// </summary>
    public class OrderAuthorizeResponsePaymentSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAuthorizeResponsePaymentSource"/> class.
        /// </summary>
        public OrderAuthorizeResponsePaymentSource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAuthorizeResponsePaymentSource"/> class.
        /// </summary>
        /// <param name="card">card.</param>
        /// <param name="paypal">paypal.</param>
        /// <param name="applePay">apple_pay.</param>
        /// <param name="googlePay">google_pay.</param>
        /// <param name="venmo">venmo.</param>
        public OrderAuthorizeResponsePaymentSource(
            Models.CardResponse card = null,
            Models.PaypalWalletResponse paypal = null,
            Models.ApplePayPaymentObject applePay = null,
            Models.GooglePayWalletResponse googlePay = null,
            Models.VenmoWalletResponse venmo = null)
        {
            this.Card = card;
            this.Paypal = paypal;
            this.ApplePay = applePay;
            this.GooglePay = googlePay;
            this.Venmo = venmo;
        }

        /// <summary>
        /// The payment card to use to fund a payment. Card can be a credit or debit card.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardResponse Card { get; set; }

        /// <summary>
        /// The PayPal Wallet response.
        /// </summary>
        [JsonProperty("paypal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalWalletResponse Paypal { get; set; }

        /// <summary>
        /// Information needed to pay using ApplePay.
        /// </summary>
        [JsonProperty("apple_pay", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplePayPaymentObject ApplePay { get; set; }

        /// <summary>
        /// Google Pay Wallet payment data.
        /// </summary>
        [JsonProperty("google_pay", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GooglePayWalletResponse GooglePay { get; set; }

        /// <summary>
        /// Venmo wallet response.
        /// </summary>
        [JsonProperty("venmo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VenmoWalletResponse Venmo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderAuthorizeResponsePaymentSource : ({string.Join(", ", toStringOutput)})";
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
            return obj is OrderAuthorizeResponsePaymentSource other &&                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.Paypal == null && other.Paypal == null) || (this.Paypal?.Equals(other.Paypal) == true)) &&
                ((this.ApplePay == null && other.ApplePay == null) || (this.ApplePay?.Equals(other.ApplePay) == true)) &&
                ((this.GooglePay == null && other.GooglePay == null) || (this.GooglePay?.Equals(other.GooglePay) == true)) &&
                ((this.Venmo == null && other.Venmo == null) || (this.Venmo?.Equals(other.Venmo) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.Paypal = {(this.Paypal == null ? "null" : this.Paypal.ToString())}");
            toStringOutput.Add($"this.ApplePay = {(this.ApplePay == null ? "null" : this.ApplePay.ToString())}");
            toStringOutput.Add($"this.GooglePay = {(this.GooglePay == null ? "null" : this.GooglePay.ToString())}");
            toStringOutput.Add($"this.Venmo = {(this.Venmo == null ? "null" : this.Venmo.ToString())}");
        }
    }
}