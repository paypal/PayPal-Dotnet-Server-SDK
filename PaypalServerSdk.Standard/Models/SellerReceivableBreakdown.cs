// <copyright file="SellerReceivableBreakdown.cs" company="APIMatic">
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
    /// SellerReceivableBreakdown.
    /// </summary>
    public class SellerReceivableBreakdown
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SellerReceivableBreakdown"/> class.
        /// </summary>
        public SellerReceivableBreakdown()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SellerReceivableBreakdown"/> class.
        /// </summary>
        /// <param name="grossAmount">gross_amount.</param>
        /// <param name="paypalFee">paypal_fee.</param>
        /// <param name="paypalFeeInReceivableCurrency">paypal_fee_in_receivable_currency.</param>
        /// <param name="netAmount">net_amount.</param>
        /// <param name="receivableAmount">receivable_amount.</param>
        /// <param name="exchangeRate">exchange_rate.</param>
        /// <param name="platformFees">platform_fees.</param>
        public SellerReceivableBreakdown(
            Models.Money grossAmount,
            Models.Money paypalFee = null,
            Models.Money paypalFeeInReceivableCurrency = null,
            Models.Money netAmount = null,
            Models.Money receivableAmount = null,
            Models.ExchangeRate exchangeRate = null,
            List<Models.PlatformFee> platformFees = null)
        {
            this.GrossAmount = grossAmount;
            this.PaypalFee = paypalFee;
            this.PaypalFeeInReceivableCurrency = paypalFeeInReceivableCurrency;
            this.NetAmount = netAmount;
            this.ReceivableAmount = receivableAmount;
            this.ExchangeRate = exchangeRate;
            this.PlatformFees = platformFees;
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("gross_amount")]
        public Models.Money GrossAmount { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("paypal_fee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money PaypalFee { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("paypal_fee_in_receivable_currency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money PaypalFeeInReceivableCurrency { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("net_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money NetAmount { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("receivable_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money ReceivableAmount { get; set; }

        /// <summary>
        /// The exchange rate that determines the amount to convert from one currency to another currency.
        /// </summary>
        [JsonProperty("exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExchangeRate ExchangeRate { get; set; }

        /// <summary>
        /// An array of platform or partner fees, commissions, or brokerage fees that associated with the captured payment.
        /// </summary>
        [JsonProperty("platform_fees", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PlatformFee> PlatformFees { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SellerReceivableBreakdown : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SellerReceivableBreakdown other &&
                (this.GrossAmount == null && other.GrossAmount == null ||
                 this.GrossAmount?.Equals(other.GrossAmount) == true) &&
                (this.PaypalFee == null && other.PaypalFee == null ||
                 this.PaypalFee?.Equals(other.PaypalFee) == true) &&
                (this.PaypalFeeInReceivableCurrency == null && other.PaypalFeeInReceivableCurrency == null ||
                 this.PaypalFeeInReceivableCurrency?.Equals(other.PaypalFeeInReceivableCurrency) == true) &&
                (this.NetAmount == null && other.NetAmount == null ||
                 this.NetAmount?.Equals(other.NetAmount) == true) &&
                (this.ReceivableAmount == null && other.ReceivableAmount == null ||
                 this.ReceivableAmount?.Equals(other.ReceivableAmount) == true) &&
                (this.ExchangeRate == null && other.ExchangeRate == null ||
                 this.ExchangeRate?.Equals(other.ExchangeRate) == true) &&
                (this.PlatformFees == null && other.PlatformFees == null ||
                 this.PlatformFees?.Equals(other.PlatformFees) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"GrossAmount = {(this.GrossAmount == null ? "null" : this.GrossAmount.ToString())}");
            toStringOutput.Add($"PaypalFee = {(this.PaypalFee == null ? "null" : this.PaypalFee.ToString())}");
            toStringOutput.Add($"PaypalFeeInReceivableCurrency = {(this.PaypalFeeInReceivableCurrency == null ? "null" : this.PaypalFeeInReceivableCurrency.ToString())}");
            toStringOutput.Add($"NetAmount = {(this.NetAmount == null ? "null" : this.NetAmount.ToString())}");
            toStringOutput.Add($"ReceivableAmount = {(this.ReceivableAmount == null ? "null" : this.ReceivableAmount.ToString())}");
            toStringOutput.Add($"ExchangeRate = {(this.ExchangeRate == null ? "null" : this.ExchangeRate.ToString())}");
            toStringOutput.Add($"PlatformFees = {(this.PlatformFees == null ? "null" : $"[{string.Join(", ", this.PlatformFees)} ]")}");
        }
    }
}