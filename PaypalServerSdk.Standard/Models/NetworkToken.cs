// <copyright file="NetworkToken.cs" company="APIMatic">
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
    /// NetworkToken.
    /// </summary>
    public class NetworkToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkToken"/> class.
        /// </summary>
        public NetworkToken()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkToken"/> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="expiry">expiry.</param>
        /// <param name="cryptogram">cryptogram.</param>
        /// <param name="eciFlag">eci_flag.</param>
        /// <param name="tokenRequestorId">token_requestor_id.</param>
        public NetworkToken(
            string number,
            string expiry,
            string cryptogram = null,
            Models.EciFlag? eciFlag = null,
            string tokenRequestorId = null)
        {
            this.Number = number;
            this.Expiry = expiry;
            this.Cryptogram = cryptogram;
            this.EciFlag = eciFlag;
            this.TokenRequestorId = tokenRequestorId;
        }

        /// <summary>
        /// Third party network token number.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// The year and month, in ISO-8601 `YYYY-MM` date format. See [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        /// <summary>
        /// An Encrypted one-time use value that's sent along with Network Token. This field is not required to be present for recurring transactions.
        /// </summary>
        [JsonProperty("cryptogram", NullValueHandling = NullValueHandling.Ignore)]
        public string Cryptogram { get; set; }

        /// <summary>
        /// Electronic Commerce Indicator (ECI). The ECI value is part of the 2 data elements that indicate the transaction was processed electronically. This should be passed on the authorization transaction to the Gateway/Processor.
        /// </summary>
        [JsonProperty("eci_flag", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EciFlag? EciFlag { get; set; }

        /// <summary>
        /// A TRID, or a Token Requestor ID, is an identifier used by merchants to request network tokens from card networks. A TRID is a precursor to obtaining a network token for a credit card primary account number (PAN), and will aid in enabling secure card on file (COF) payments and reducing fraud.
        /// </summary>
        [JsonProperty("token_requestor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenRequestorId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NetworkToken : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NetworkToken other &&
                (this.Number == null && other.Number == null ||
                 this.Number?.Equals(other.Number) == true) &&
                (this.Expiry == null && other.Expiry == null ||
                 this.Expiry?.Equals(other.Expiry) == true) &&
                (this.Cryptogram == null && other.Cryptogram == null ||
                 this.Cryptogram?.Equals(other.Cryptogram) == true) &&
                (this.EciFlag == null && other.EciFlag == null ||
                 this.EciFlag?.Equals(other.EciFlag) == true) &&
                (this.TokenRequestorId == null && other.TokenRequestorId == null ||
                 this.TokenRequestorId?.Equals(other.TokenRequestorId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Number = {this.Number ?? "null"}");
            toStringOutput.Add($"Expiry = {this.Expiry ?? "null"}");
            toStringOutput.Add($"Cryptogram = {this.Cryptogram ?? "null"}");
            toStringOutput.Add($"EciFlag = {(this.EciFlag == null ? "null" : this.EciFlag.ToString())}");
            toStringOutput.Add($"TokenRequestorId = {this.TokenRequestorId ?? "null"}");
        }
    }
}