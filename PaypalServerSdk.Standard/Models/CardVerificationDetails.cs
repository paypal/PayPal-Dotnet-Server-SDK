// <copyright file="CardVerificationDetails.cs" company="APIMatic">
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
    /// CardVerificationDetails.
    /// </summary>
    public class CardVerificationDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardVerificationDetails"/> class.
        /// </summary>
        public CardVerificationDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardVerificationDetails"/> class.
        /// </summary>
        /// <param name="networkTransactionId">network_transaction_id.</param>
        /// <param name="date">date.</param>
        /// <param name="network">network.</param>
        /// <param name="time">time.</param>
        /// <param name="amount">amount.</param>
        /// <param name="processorResponse">processor_response.</param>
        public CardVerificationDetails(
            string networkTransactionId = null,
            string date = null,
            Models.CardBrand? network = null,
            string time = null,
            Models.Money amount = null,
            Models.CardVerificationProcessorResponse processorResponse = null)
        {
            this.NetworkTransactionId = networkTransactionId;
            this.Date = date;
            this.Network = network;
            this.Time = time;
            this.Amount = amount;
            this.ProcessorResponse = processorResponse;
        }

        /// <summary>
        /// Transaction Identifier as given by the network to indicate a previously executed CIT authorization. Only present when authorization is successful for a verification.
        /// </summary>
        [JsonProperty("network_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkTransactionId { get; set; }

        /// <summary>
        /// The date that the transaction was authorized by the scheme. This field may not be returned for all networks. MasterCard refers to this field as "BankNet reference date".
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// The card network or brand. Applies to credit, debit, gift, and payment cards.
        /// </summary>
        [JsonProperty("network", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardBrand? Network { get; set; }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Amount { get; set; }

        /// <summary>
        /// The processor response information for payment requests, such as direct credit card transactions.
        /// </summary>
        [JsonProperty("processor_response", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardVerificationProcessorResponse ProcessorResponse { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardVerificationDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardVerificationDetails other &&                ((this.NetworkTransactionId == null && other.NetworkTransactionId == null) || (this.NetworkTransactionId?.Equals(other.NetworkTransactionId) == true)) &&
                ((this.Date == null && other.Date == null) || (this.Date?.Equals(other.Date) == true)) &&
                ((this.Network == null && other.Network == null) || (this.Network?.Equals(other.Network) == true)) &&
                ((this.Time == null && other.Time == null) || (this.Time?.Equals(other.Time) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.ProcessorResponse == null && other.ProcessorResponse == null) || (this.ProcessorResponse?.Equals(other.ProcessorResponse) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NetworkTransactionId = {(this.NetworkTransactionId == null ? "null" : this.NetworkTransactionId)}");
            toStringOutput.Add($"this.Date = {(this.Date == null ? "null" : this.Date)}");
            toStringOutput.Add($"this.Network = {(this.Network == null ? "null" : this.Network.ToString())}");
            toStringOutput.Add($"this.Time = {(this.Time == null ? "null" : this.Time)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.ProcessorResponse = {(this.ProcessorResponse == null ? "null" : this.ProcessorResponse.ToString())}");
        }
    }
}