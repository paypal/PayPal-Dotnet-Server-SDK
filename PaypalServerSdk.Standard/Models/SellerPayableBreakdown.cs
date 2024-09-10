// <copyright file="SellerPayableBreakdown.cs" company="APIMatic">
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
    /// SellerPayableBreakdown.
    /// </summary>
    public class SellerPayableBreakdown
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SellerPayableBreakdown"/> class.
        /// </summary>
        public SellerPayableBreakdown()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SellerPayableBreakdown"/> class.
        /// </summary>
        /// <param name="grossAmount">gross_amount.</param>
        /// <param name="paypalFee">paypal_fee.</param>
        /// <param name="paypalFeeInReceivableCurrency">paypal_fee_in_receivable_currency.</param>
        /// <param name="netAmount">net_amount.</param>
        /// <param name="netAmountInReceivableCurrency">net_amount_in_receivable_currency.</param>
        /// <param name="platformFees">platform_fees.</param>
        /// <param name="netAmountBreakdown">net_amount_breakdown.</param>
        /// <param name="totalRefundedAmount">total_refunded_amount.</param>
        public SellerPayableBreakdown(
            Models.Money grossAmount = null,
            Models.Money paypalFee = null,
            Models.Money paypalFeeInReceivableCurrency = null,
            Models.Money netAmount = null,
            Models.Money netAmountInReceivableCurrency = null,
            List<Models.PlatformFee> platformFees = null,
            List<Models.NetAmountBreakdownItem> netAmountBreakdown = null,
            Models.Money totalRefundedAmount = null)
        {
            this.GrossAmount = grossAmount;
            this.PaypalFee = paypalFee;
            this.PaypalFeeInReceivableCurrency = paypalFeeInReceivableCurrency;
            this.NetAmount = netAmount;
            this.NetAmountInReceivableCurrency = netAmountInReceivableCurrency;
            this.PlatformFees = platformFees;
            this.NetAmountBreakdown = netAmountBreakdown;
            this.TotalRefundedAmount = totalRefundedAmount;
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("gross_amount", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("net_amount_in_receivable_currency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money NetAmountInReceivableCurrency { get; set; }

        /// <summary>
        /// An array of platform or partner fees, commissions, or brokerage fees for the refund.
        /// </summary>
        [JsonProperty("platform_fees", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PlatformFee> PlatformFees { get; set; }

        /// <summary>
        /// An array of breakdown values for the net amount. Returned when the currency of the refund is different from the currency of the PayPal account where the payee holds their funds.
        /// </summary>
        [JsonProperty("net_amount_breakdown", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.NetAmountBreakdownItem> NetAmountBreakdown { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("total_refunded_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money TotalRefundedAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SellerPayableBreakdown : ({string.Join(", ", toStringOutput)})";
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
            return obj is SellerPayableBreakdown other &&                ((this.GrossAmount == null && other.GrossAmount == null) || (this.GrossAmount?.Equals(other.GrossAmount) == true)) &&
                ((this.PaypalFee == null && other.PaypalFee == null) || (this.PaypalFee?.Equals(other.PaypalFee) == true)) &&
                ((this.PaypalFeeInReceivableCurrency == null && other.PaypalFeeInReceivableCurrency == null) || (this.PaypalFeeInReceivableCurrency?.Equals(other.PaypalFeeInReceivableCurrency) == true)) &&
                ((this.NetAmount == null && other.NetAmount == null) || (this.NetAmount?.Equals(other.NetAmount) == true)) &&
                ((this.NetAmountInReceivableCurrency == null && other.NetAmountInReceivableCurrency == null) || (this.NetAmountInReceivableCurrency?.Equals(other.NetAmountInReceivableCurrency) == true)) &&
                ((this.PlatformFees == null && other.PlatformFees == null) || (this.PlatformFees?.Equals(other.PlatformFees) == true)) &&
                ((this.NetAmountBreakdown == null && other.NetAmountBreakdown == null) || (this.NetAmountBreakdown?.Equals(other.NetAmountBreakdown) == true)) &&
                ((this.TotalRefundedAmount == null && other.TotalRefundedAmount == null) || (this.TotalRefundedAmount?.Equals(other.TotalRefundedAmount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GrossAmount = {(this.GrossAmount == null ? "null" : this.GrossAmount.ToString())}");
            toStringOutput.Add($"this.PaypalFee = {(this.PaypalFee == null ? "null" : this.PaypalFee.ToString())}");
            toStringOutput.Add($"this.PaypalFeeInReceivableCurrency = {(this.PaypalFeeInReceivableCurrency == null ? "null" : this.PaypalFeeInReceivableCurrency.ToString())}");
            toStringOutput.Add($"this.NetAmount = {(this.NetAmount == null ? "null" : this.NetAmount.ToString())}");
            toStringOutput.Add($"this.NetAmountInReceivableCurrency = {(this.NetAmountInReceivableCurrency == null ? "null" : this.NetAmountInReceivableCurrency.ToString())}");
            toStringOutput.Add($"this.PlatformFees = {(this.PlatformFees == null ? "null" : $"[{string.Join(", ", this.PlatformFees)} ]")}");
            toStringOutput.Add($"this.NetAmountBreakdown = {(this.NetAmountBreakdown == null ? "null" : $"[{string.Join(", ", this.NetAmountBreakdown)} ]")}");
            toStringOutput.Add($"this.TotalRefundedAmount = {(this.TotalRefundedAmount == null ? "null" : this.TotalRefundedAmount.ToString())}");
        }
    }
}