// <copyright file="BlikOneClickPaymentRequest.cs" company="APIMatic">
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
    /// BlikOneClickPaymentRequest.
    /// </summary>
    public class BlikOneClickPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlikOneClickPaymentRequest"/> class.
        /// </summary>
        public BlikOneClickPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlikOneClickPaymentRequest"/> class.
        /// </summary>
        /// <param name="consumerReference">consumer_reference.</param>
        /// <param name="authCode">auth_code.</param>
        /// <param name="aliasLabel">alias_label.</param>
        /// <param name="aliasKey">alias_key.</param>
        public BlikOneClickPaymentRequest(
            string consumerReference,
            string authCode = null,
            string aliasLabel = null,
            string aliasKey = null)
        {
            this.AuthCode = authCode;
            this.ConsumerReference = consumerReference;
            this.AliasLabel = aliasLabel;
            this.AliasKey = aliasKey;
        }

        /// <summary>
        /// The 6-digit code used to authenticate a consumer within BLIK.
        /// </summary>
        [JsonProperty("auth_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthCode { get; set; }

        /// <summary>
        /// The merchant generated, unique reference serving as a primary identifier for accounts connected between Blik and a merchant.
        /// </summary>
        [JsonProperty("consumer_reference")]
        public string ConsumerReference { get; set; }

        /// <summary>
        /// A bank defined identifier used as a display name to allow the payer to differentiate between multiple registered bank accounts.
        /// </summary>
        [JsonProperty("alias_label", NullValueHandling = NullValueHandling.Ignore)]
        public string AliasLabel { get; set; }

        /// <summary>
        /// A Blik-defined identifier for a specific Blik-enabled bank account that is associated with a given merchant. Used only in conjunction with a Consumer Reference.
        /// </summary>
        [JsonProperty("alias_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AliasKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BlikOneClickPaymentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BlikOneClickPaymentRequest other &&
                (this.AuthCode == null && other.AuthCode == null ||
                 this.AuthCode?.Equals(other.AuthCode) == true) &&
                (this.ConsumerReference == null && other.ConsumerReference == null ||
                 this.ConsumerReference?.Equals(other.ConsumerReference) == true) &&
                (this.AliasLabel == null && other.AliasLabel == null ||
                 this.AliasLabel?.Equals(other.AliasLabel) == true) &&
                (this.AliasKey == null && other.AliasKey == null ||
                 this.AliasKey?.Equals(other.AliasKey) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AuthCode = {this.AuthCode ?? "null"}");
            toStringOutput.Add($"ConsumerReference = {this.ConsumerReference ?? "null"}");
            toStringOutput.Add($"AliasLabel = {this.AliasLabel ?? "null"}");
            toStringOutput.Add($"AliasKey = {this.AliasKey ?? "null"}");
        }
    }
}