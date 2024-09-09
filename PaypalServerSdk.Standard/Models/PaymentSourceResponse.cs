// <copyright file="PaymentSourceResponse.cs" company="APIMatic">
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
    /// PaymentSourceResponse.
    /// </summary>
    public class PaymentSourceResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSourceResponse"/> class.
        /// </summary>
        public PaymentSourceResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSourceResponse"/> class.
        /// </summary>
        /// <param name="card">card.</param>
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
        public PaymentSourceResponse(
            Models.CardResponse card = null,
            Models.PayPalWalletResponse paypal = null,
            Models.BancontactPaymentObject bancontact = null,
            Models.BLIKPaymentObject blik = null,
            Models.EPSPaymentObject eps = null,
            Models.GiropayPaymentObject giropay = null,
            Models.IDEALPaymentObject ideal = null,
            Models.MyBankPaymentObject mybank = null,
            Models.P24PaymentObject p24 = null,
            Models.SofortPaymentObject sofort = null,
            Models.TrustlyPaymentObject trustly = null,
            Models.ApplePayPaymentObject applePay = null,
            Models.GooglePayWalletResponse googlePay = null,
            Models.VenmoWalletResponse venmo = null)
        {
            this.Card = card;
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
        /// The payment card to use to fund a payment. Card can be a credit or debit card.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardResponse Card { get; set; }

        /// <summary>
        /// The PayPal Wallet response.
        /// </summary>
        [JsonProperty("paypal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayPalWalletResponse Paypal { get; set; }

        /// <summary>
        /// Information used to pay Bancontact.
        /// </summary>
        [JsonProperty("bancontact", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BancontactPaymentObject Bancontact { get; set; }

        /// <summary>
        /// Information used to pay using BLIK.
        /// </summary>
        [JsonProperty("blik", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BLIKPaymentObject Blik { get; set; }

        /// <summary>
        /// Information used to pay using eps.
        /// </summary>
        [JsonProperty("eps", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EPSPaymentObject Eps { get; set; }

        /// <summary>
        /// Information needed to pay using giropay.
        /// </summary>
        [JsonProperty("giropay", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GiropayPaymentObject Giropay { get; set; }

        /// <summary>
        /// Information used to pay using iDEAL.
        /// </summary>
        [JsonProperty("ideal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IDEALPaymentObject Ideal { get; set; }

        /// <summary>
        /// Information used to pay using MyBank.
        /// </summary>
        [JsonProperty("mybank", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MyBankPaymentObject Mybank { get; set; }

        /// <summary>
        /// Information used to pay using P24(Przelewy24).
        /// </summary>
        [JsonProperty("p24", NullValueHandling = NullValueHandling.Ignore)]
        public Models.P24PaymentObject P24 { get; set; }

        /// <summary>
        /// Information used to pay using Sofort.
        /// </summary>
        [JsonProperty("sofort", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SofortPaymentObject Sofort { get; set; }

        /// <summary>
        /// Information needed to pay using Trustly.
        /// </summary>
        [JsonProperty("trustly", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TrustlyPaymentObject Trustly { get; set; }

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

            return $"PaymentSourceResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentSourceResponse other &&                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.Paypal == null && other.Paypal == null) || (this.Paypal?.Equals(other.Paypal) == true)) &&
                ((this.Bancontact == null && other.Bancontact == null) || (this.Bancontact?.Equals(other.Bancontact) == true)) &&
                ((this.Blik == null && other.Blik == null) || (this.Blik?.Equals(other.Blik) == true)) &&
                ((this.Eps == null && other.Eps == null) || (this.Eps?.Equals(other.Eps) == true)) &&
                ((this.Giropay == null && other.Giropay == null) || (this.Giropay?.Equals(other.Giropay) == true)) &&
                ((this.Ideal == null && other.Ideal == null) || (this.Ideal?.Equals(other.Ideal) == true)) &&
                ((this.Mybank == null && other.Mybank == null) || (this.Mybank?.Equals(other.Mybank) == true)) &&
                ((this.P24 == null && other.P24 == null) || (this.P24?.Equals(other.P24) == true)) &&
                ((this.Sofort == null && other.Sofort == null) || (this.Sofort?.Equals(other.Sofort) == true)) &&
                ((this.Trustly == null && other.Trustly == null) || (this.Trustly?.Equals(other.Trustly) == true)) &&
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
            toStringOutput.Add($"this.Bancontact = {(this.Bancontact == null ? "null" : this.Bancontact.ToString())}");
            toStringOutput.Add($"this.Blik = {(this.Blik == null ? "null" : this.Blik.ToString())}");
            toStringOutput.Add($"this.Eps = {(this.Eps == null ? "null" : this.Eps.ToString())}");
            toStringOutput.Add($"this.Giropay = {(this.Giropay == null ? "null" : this.Giropay.ToString())}");
            toStringOutput.Add($"this.Ideal = {(this.Ideal == null ? "null" : this.Ideal.ToString())}");
            toStringOutput.Add($"this.Mybank = {(this.Mybank == null ? "null" : this.Mybank.ToString())}");
            toStringOutput.Add($"this.P24 = {(this.P24 == null ? "null" : this.P24.ToString())}");
            toStringOutput.Add($"this.Sofort = {(this.Sofort == null ? "null" : this.Sofort.ToString())}");
            toStringOutput.Add($"this.Trustly = {(this.Trustly == null ? "null" : this.Trustly.ToString())}");
            toStringOutput.Add($"this.ApplePay = {(this.ApplePay == null ? "null" : this.ApplePay.ToString())}");
            toStringOutput.Add($"this.GooglePay = {(this.GooglePay == null ? "null" : this.GooglePay.ToString())}");
            toStringOutput.Add($"this.Venmo = {(this.Venmo == null ? "null" : this.Venmo.ToString())}");
        }
    }
}