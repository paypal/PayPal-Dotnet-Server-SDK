// <copyright file="CardAttributes.cs" company="APIMatic">
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
    /// CardAttributes.
    /// </summary>
    public class CardAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardAttributes"/> class.
        /// </summary>
        public CardAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardAttributes"/> class.
        /// </summary>
        /// <param name="customer">customer.</param>
        /// <param name="vault">vault.</param>
        /// <param name="verification">verification.</param>
        public CardAttributes(
            Models.CardCustomerInformation customer = null,
            Models.VaultInstructionBase vault = null,
            Models.CardVerification verification = null)
        {
            this.Customer = customer;
            this.Vault = vault;
            this.Verification = verification;
        }

        /// <summary>
        /// The details about a customer in PayPal's system of record.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardCustomerInformation Customer { get; set; }

        /// <summary>
        /// Basic vault instruction specification that can be extended by specific payment sources that supports vaulting.
        /// </summary>
        [JsonProperty("vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VaultInstructionBase Vault { get; set; }

        /// <summary>
        /// The API caller can opt in to verify the card through PayPal offered verification services (e.g. Smart Dollar Auth, 3DS).
        /// </summary>
        [JsonProperty("verification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardVerification Verification { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardAttributes other &&                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Vault == null && other.Vault == null) || (this.Vault?.Equals(other.Vault) == true)) &&
                ((this.Verification == null && other.Verification == null) || (this.Verification?.Equals(other.Verification) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Vault = {(this.Vault == null ? "null" : this.Vault.ToString())}");
            toStringOutput.Add($"this.Verification = {(this.Verification == null ? "null" : this.Verification.ToString())}");
        }
    }
}