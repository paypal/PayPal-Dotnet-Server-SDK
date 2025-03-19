// <copyright file="CardStoredCredential.cs" company="APIMatic">
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
    /// CardStoredCredential.
    /// </summary>
    public class CardStoredCredential
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardStoredCredential"/> class.
        /// </summary>
        public CardStoredCredential()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardStoredCredential"/> class.
        /// </summary>
        /// <param name="paymentInitiator">payment_initiator.</param>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="usage">usage.</param>
        /// <param name="previousNetworkTransactionReference">previous_network_transaction_reference.</param>
        public CardStoredCredential(
            Models.PaymentInitiator paymentInitiator,
            Models.StoredPaymentSourcePaymentType paymentType,
            Models.StoredPaymentSourceUsageType? usage = Models.StoredPaymentSourceUsageType.Derived,
            Models.NetworkTransactionReference previousNetworkTransactionReference = null)
        {
            this.PaymentInitiator = paymentInitiator;
            this.PaymentType = paymentType;
            this.Usage = usage;
            this.PreviousNetworkTransactionReference = previousNetworkTransactionReference;
        }

        /// <summary>
        /// The person or party who initiated or triggered the payment.
        /// </summary>
        [JsonProperty("payment_initiator")]
        public Models.PaymentInitiator PaymentInitiator { get; set; }

        /// <summary>
        /// Indicates the type of the stored payment_source payment.
        /// </summary>
        [JsonProperty("payment_type")]
        public Models.StoredPaymentSourcePaymentType PaymentType { get; set; }

        /// <summary>
        /// Indicates if this is a `first` or `subsequent` payment using a stored payment source (also referred to as stored credential or card on file).
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StoredPaymentSourceUsageType? Usage { get; set; }

        /// <summary>
        /// Reference values used by the card network to identify a transaction.
        /// </summary>
        [JsonProperty("previous_network_transaction_reference", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NetworkTransactionReference PreviousNetworkTransactionReference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardStoredCredential : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardStoredCredential other &&
                (this.PaymentInitiator.Equals(other.PaymentInitiator)) &&
                (this.PaymentType.Equals(other.PaymentType)) &&
                (this.Usage == null && other.Usage == null ||
                 this.Usage?.Equals(other.Usage) == true) &&
                (this.PreviousNetworkTransactionReference == null && other.PreviousNetworkTransactionReference == null ||
                 this.PreviousNetworkTransactionReference?.Equals(other.PreviousNetworkTransactionReference) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PaymentInitiator = {this.PaymentInitiator}");
            toStringOutput.Add($"PaymentType = {this.PaymentType}");
            toStringOutput.Add($"Usage = {(this.Usage == null ? "null" : this.Usage.ToString())}");
            toStringOutput.Add($"PreviousNetworkTransactionReference = {(this.PreviousNetworkTransactionReference == null ? "null" : this.PreviousNetworkTransactionReference.ToString())}");
        }
    }
}