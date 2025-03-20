// <copyright file="NetworkTransactionReference.cs" company="APIMatic">
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
    /// NetworkTransactionReference.
    /// </summary>
    public class NetworkTransactionReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkTransactionReference"/> class.
        /// </summary>
        public NetworkTransactionReference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkTransactionReference"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="date">date.</param>
        /// <param name="network">network.</param>
        /// <param name="acquirerReferenceNumber">acquirer_reference_number.</param>
        public NetworkTransactionReference(
            string id,
            string date = null,
            Models.CardBrand? network = null,
            string acquirerReferenceNumber = null)
        {
            this.Id = id;
            this.Date = date;
            this.Network = network;
            this.AcquirerReferenceNumber = acquirerReferenceNumber;
        }

        /// <summary>
        /// Transaction reference id returned by the scheme. For Visa and Amex, this is the "Tran id" field in response. For MasterCard, this is the "BankNet reference id" field in response. For Discover, this is the "NRID" field in response. The pattern we expect for this field from Visa/Amex/CB/Discover is numeric, Mastercard/BNPP is alphanumeric and Paysecure is alphanumeric with special character -.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The date that the transaction was authorized by the scheme. This field may not be returned for all networks. MasterCard refers to this field as "BankNet reference date.
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// The card network or brand. Applies to credit, debit, gift, and payment cards.
        /// </summary>
        [JsonProperty("network", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardBrand? Network { get; set; }

        /// <summary>
        /// Reference ID issued for the card transaction. This ID can be used to track the transaction across processors, card brands and issuing banks.
        /// </summary>
        [JsonProperty("acquirer_reference_number", NullValueHandling = NullValueHandling.Ignore)]
        public string AcquirerReferenceNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NetworkTransactionReference : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NetworkTransactionReference other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Date == null && other.Date == null ||
                 this.Date?.Equals(other.Date) == true) &&
                (this.Network == null && other.Network == null ||
                 this.Network?.Equals(other.Network) == true) &&
                (this.AcquirerReferenceNumber == null && other.AcquirerReferenceNumber == null ||
                 this.AcquirerReferenceNumber?.Equals(other.AcquirerReferenceNumber) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Date = {this.Date ?? "null"}");
            toStringOutput.Add($"Network = {(this.Network == null ? "null" : this.Network.ToString())}");
            toStringOutput.Add($"AcquirerReferenceNumber = {this.AcquirerReferenceNumber ?? "null"}");
        }
    }
}