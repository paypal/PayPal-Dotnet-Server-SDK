// <copyright file="PaypalWalletStoredCredential.cs" company="APIMatic">
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
    /// PaypalWalletStoredCredential.
    /// </summary>
    public class PaypalWalletStoredCredential
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalWalletStoredCredential"/> class.
        /// </summary>
        public PaypalWalletStoredCredential()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalWalletStoredCredential"/> class.
        /// </summary>
        /// <param name="paymentInitiator">payment_initiator.</param>
        /// <param name="chargePattern">charge_pattern.</param>
        /// <param name="usagePattern">usage_pattern.</param>
        /// <param name="usage">usage.</param>
        public PaypalWalletStoredCredential(
            Models.PaymentInitiator paymentInitiator,
            Models.UsagePattern? chargePattern = null,
            Models.UsagePattern? usagePattern = null,
            Models.StoredPaymentSourceUsageType? usage = Models.StoredPaymentSourceUsageType.Derived)
        {
            this.PaymentInitiator = paymentInitiator;
            this.ChargePattern = chargePattern;
            this.UsagePattern = usagePattern;
            this.Usage = usage;
        }

        /// <summary>
        /// The person or party who initiated or triggered the payment.
        /// </summary>
        [JsonProperty("payment_initiator")]
        public Models.PaymentInitiator PaymentInitiator { get; set; }

        /// <summary>
        /// Expected business/pricing model for the billing agreement.
        /// </summary>
        [JsonProperty("charge_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UsagePattern? ChargePattern { get; set; }

        /// <summary>
        /// Expected business/pricing model for the billing agreement.
        /// </summary>
        [JsonProperty("usage_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UsagePattern? UsagePattern { get; set; }

        /// <summary>
        /// Indicates if this is a `first` or `subsequent` payment using a stored payment source (also referred to as stored credential or card on file).
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StoredPaymentSourceUsageType? Usage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaypalWalletStoredCredential : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaypalWalletStoredCredential other &&
                (this.PaymentInitiator.Equals(other.PaymentInitiator)) &&
                (this.ChargePattern == null && other.ChargePattern == null ||
                 this.ChargePattern?.Equals(other.ChargePattern) == true) &&
                (this.UsagePattern == null && other.UsagePattern == null ||
                 this.UsagePattern?.Equals(other.UsagePattern) == true) &&
                (this.Usage == null && other.Usage == null ||
                 this.Usage?.Equals(other.Usage) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PaymentInitiator = {this.PaymentInitiator}");
            toStringOutput.Add($"ChargePattern = {(this.ChargePattern == null ? "null" : this.ChargePattern.ToString())}");
            toStringOutput.Add($"UsagePattern = {(this.UsagePattern == null ? "null" : this.UsagePattern.ToString())}");
            toStringOutput.Add($"Usage = {(this.Usage == null ? "null" : this.Usage.ToString())}");
        }
    }
}