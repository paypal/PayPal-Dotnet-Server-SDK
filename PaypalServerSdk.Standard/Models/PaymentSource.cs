// <copyright file="PaymentSource.cs" company="APIMatic">
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
    /// PaymentSource.
    /// </summary>
    public class PaymentSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSource"/> class.
        /// </summary>
        public PaymentSource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSource"/> class.
        /// </summary>
        /// <param name="card">card.</param>
        /// <param name="token">token.</param>
        /// <param name="paypal">paypal.</param>
        /// <param name="bancontact">bancontact.</param>
        /// <param name="blik">blik.</param>
        /// <param name="eps">eps.</param>
        /// <param name="giropay">giropay.</param>
        /// <param name="ideal">ideal.</param>
        /// <param name="mybank">mybank.</param>
        /// <param name="p24">p24.</param>
        /// <param name="sofort">sofort.</param>
        /// <param name="trustly">trustly.</param>
        /// <param name="applePay">apple_pay.</param>
        /// <param name="googlePay">google_pay.</param>
        /// <param name="venmo">venmo.</param>
        public PaymentSource(
            Models.CardRequest card = null,
            Models.Token token = null,
            Models.PaypalWallet paypal = null,
            Models.BancontactPaymentRequest bancontact = null,
            Models.BlikPaymentRequest blik = null,
            Models.EpsPaymentRequest eps = null,
            Models.GiropayPaymentRequest giropay = null,
            Models.IdealPaymentRequest ideal = null,
            Models.MybankPaymentRequest mybank = null,
            Models.P24PaymentRequest p24 = null,
            Models.SofortPaymentRequest sofort = null,
            Models.TrustlyPaymentRequest trustly = null,
            Models.ApplePayRequest applePay = null,
            Models.GooglePayRequest googlePay = null,
            Models.VenmoWalletRequest venmo = null)
        {
            this.Card = card;
            this.Token = token;
            this.Paypal = paypal;
            this.Bancontact = bancontact;
            this.Blik = blik;
            this.Eps = eps;
            this.Giropay = giropay;
            this.Ideal = ideal;
            this.Mybank = mybank;
            this.P24 = p24;
            this.Sofort = sofort;
            this.Trustly = trustly;
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
        /// Information needed to pay using Bancontact.
        /// </summary>
        [JsonProperty("bancontact", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BancontactPaymentRequest Bancontact { get; set; }

        /// <summary>
        /// Information needed to pay using BLIK.
        /// </summary>
        [JsonProperty("blik", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BlikPaymentRequest Blik { get; set; }

        /// <summary>
        /// Information needed to pay using eps.
        /// </summary>
        [JsonProperty("eps", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EpsPaymentRequest Eps { get; set; }

        /// <summary>
        /// Information needed to pay using giropay.
        /// </summary>
        [JsonProperty("giropay", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GiropayPaymentRequest Giropay { get; set; }

        /// <summary>
        /// Information needed to pay using iDEAL.
        /// </summary>
        [JsonProperty("ideal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IdealPaymentRequest Ideal { get; set; }

        /// <summary>
        /// Information needed to pay using MyBank.
        /// </summary>
        [JsonProperty("mybank", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MybankPaymentRequest Mybank { get; set; }

        /// <summary>
        /// Information needed to pay using P24 (Przelewy24).
        /// </summary>
        [JsonProperty("p24", NullValueHandling = NullValueHandling.Ignore)]
        public Models.P24PaymentRequest P24 { get; set; }

        /// <summary>
        /// Information needed to pay using Sofort.
        /// </summary>
        [JsonProperty("sofort", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SofortPaymentRequest Sofort { get; set; }

        /// <summary>
        /// Information needed to pay using Trustly.
        /// </summary>
        [JsonProperty("trustly", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TrustlyPaymentRequest Trustly { get; set; }

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
            return $"PaymentSource : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaymentSource other &&
                (this.Card == null && other.Card == null ||
                 this.Card?.Equals(other.Card) == true) &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.Paypal == null && other.Paypal == null ||
                 this.Paypal?.Equals(other.Paypal) == true) &&
                (this.Bancontact == null && other.Bancontact == null ||
                 this.Bancontact?.Equals(other.Bancontact) == true) &&
                (this.Blik == null && other.Blik == null ||
                 this.Blik?.Equals(other.Blik) == true) &&
                (this.Eps == null && other.Eps == null ||
                 this.Eps?.Equals(other.Eps) == true) &&
                (this.Giropay == null && other.Giropay == null ||
                 this.Giropay?.Equals(other.Giropay) == true) &&
                (this.Ideal == null && other.Ideal == null ||
                 this.Ideal?.Equals(other.Ideal) == true) &&
                (this.Mybank == null && other.Mybank == null ||
                 this.Mybank?.Equals(other.Mybank) == true) &&
                (this.P24 == null && other.P24 == null ||
                 this.P24?.Equals(other.P24) == true) &&
                (this.Sofort == null && other.Sofort == null ||
                 this.Sofort?.Equals(other.Sofort) == true) &&
                (this.Trustly == null && other.Trustly == null ||
                 this.Trustly?.Equals(other.Trustly) == true) &&
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
            toStringOutput.Add($"Bancontact = {(this.Bancontact == null ? "null" : this.Bancontact.ToString())}");
            toStringOutput.Add($"Blik = {(this.Blik == null ? "null" : this.Blik.ToString())}");
            toStringOutput.Add($"Eps = {(this.Eps == null ? "null" : this.Eps.ToString())}");
            toStringOutput.Add($"Giropay = {(this.Giropay == null ? "null" : this.Giropay.ToString())}");
            toStringOutput.Add($"Ideal = {(this.Ideal == null ? "null" : this.Ideal.ToString())}");
            toStringOutput.Add($"Mybank = {(this.Mybank == null ? "null" : this.Mybank.ToString())}");
            toStringOutput.Add($"P24 = {(this.P24 == null ? "null" : this.P24.ToString())}");
            toStringOutput.Add($"Sofort = {(this.Sofort == null ? "null" : this.Sofort.ToString())}");
            toStringOutput.Add($"Trustly = {(this.Trustly == null ? "null" : this.Trustly.ToString())}");
            toStringOutput.Add($"ApplePay = {(this.ApplePay == null ? "null" : this.ApplePay.ToString())}");
            toStringOutput.Add($"GooglePay = {(this.GooglePay == null ? "null" : this.GooglePay.ToString())}");
            toStringOutput.Add($"Venmo = {(this.Venmo == null ? "null" : this.Venmo.ToString())}");
        }
    }
}