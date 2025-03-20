// <copyright file="ApplePayDecryptedTokenData.cs" company="APIMatic">
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
    /// ApplePayDecryptedTokenData.
    /// </summary>
    public class ApplePayDecryptedTokenData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayDecryptedTokenData"/> class.
        /// </summary>
        public ApplePayDecryptedTokenData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayDecryptedTokenData"/> class.
        /// </summary>
        /// <param name="tokenizedCard">tokenized_card.</param>
        /// <param name="transactionAmount">transaction_amount.</param>
        /// <param name="deviceManufacturerId">device_manufacturer_id.</param>
        /// <param name="paymentDataType">payment_data_type.</param>
        /// <param name="paymentData">payment_data.</param>
        public ApplePayDecryptedTokenData(
            Models.ApplePayTokenizedCard tokenizedCard,
            Models.Money transactionAmount = null,
            string deviceManufacturerId = null,
            Models.ApplePayPaymentDataType? paymentDataType = null,
            Models.ApplePayPaymentData paymentData = null)
        {
            this.TransactionAmount = transactionAmount;
            this.TokenizedCard = tokenizedCard;
            this.DeviceManufacturerId = deviceManufacturerId;
            this.PaymentDataType = paymentDataType;
            this.PaymentData = paymentData;
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("transaction_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money TransactionAmount { get; set; }

        /// <summary>
        /// The payment card to use to fund a payment. Can be a credit or debit card.
        /// </summary>
        [JsonProperty("tokenized_card")]
        public Models.ApplePayTokenizedCard TokenizedCard { get; set; }

        /// <summary>
        /// Apple Pay Hex-encoded device manufacturer identifier. The pattern is defined by an external party and supports Unicode.
        /// </summary>
        [JsonProperty("device_manufacturer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceManufacturerId { get; set; }

        /// <summary>
        /// Indicates the type of payment data passed, in case of Non China the payment data is 3DSECURE and for China it is EMV.
        /// </summary>
        [JsonProperty("payment_data_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplePayPaymentDataType? PaymentDataType { get; set; }

        /// <summary>
        /// Information about the decrypted apple pay payment data for the token like cryptogram, eci indicator.
        /// </summary>
        [JsonProperty("payment_data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplePayPaymentData PaymentData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ApplePayDecryptedTokenData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ApplePayDecryptedTokenData other &&
                (this.TransactionAmount == null && other.TransactionAmount == null ||
                 this.TransactionAmount?.Equals(other.TransactionAmount) == true) &&
                (this.TokenizedCard == null && other.TokenizedCard == null ||
                 this.TokenizedCard?.Equals(other.TokenizedCard) == true) &&
                (this.DeviceManufacturerId == null && other.DeviceManufacturerId == null ||
                 this.DeviceManufacturerId?.Equals(other.DeviceManufacturerId) == true) &&
                (this.PaymentDataType == null && other.PaymentDataType == null ||
                 this.PaymentDataType?.Equals(other.PaymentDataType) == true) &&
                (this.PaymentData == null && other.PaymentData == null ||
                 this.PaymentData?.Equals(other.PaymentData) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TransactionAmount = {(this.TransactionAmount == null ? "null" : this.TransactionAmount.ToString())}");
            toStringOutput.Add($"TokenizedCard = {(this.TokenizedCard == null ? "null" : this.TokenizedCard.ToString())}");
            toStringOutput.Add($"DeviceManufacturerId = {this.DeviceManufacturerId ?? "null"}");
            toStringOutput.Add($"PaymentDataType = {(this.PaymentDataType == null ? "null" : this.PaymentDataType.ToString())}");
            toStringOutput.Add($"PaymentData = {(this.PaymentData == null ? "null" : this.PaymentData.ToString())}");
        }
    }
}