// <copyright file="VenmoWalletAdditionalAttributes.cs" company="APIMatic">
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
    /// VenmoWalletAdditionalAttributes.
    /// </summary>
    public class VenmoWalletAdditionalAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VenmoWalletAdditionalAttributes"/> class.
        /// </summary>
        public VenmoWalletAdditionalAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VenmoWalletAdditionalAttributes"/> class.
        /// </summary>
        /// <param name="customer">customer.</param>
        /// <param name="vault">vault.</param>
        public VenmoWalletAdditionalAttributes(
            Models.VenmoWalletCustomerInformation customer = null,
            Models.VenmoWalletVaultAttributes vault = null)
        {
            this.Customer = customer;
            this.Vault = vault;
        }

        /// <summary>
        /// The details about a customer in PayPal's system of record.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VenmoWalletCustomerInformation Customer { get; set; }

        /// <summary>
        /// Resource consolidating common request and response attirbutes for vaulting Venmo Wallet.
        /// </summary>
        [JsonProperty("vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VenmoWalletVaultAttributes Vault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"VenmoWalletAdditionalAttributes : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is VenmoWalletAdditionalAttributes other &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                (this.Vault == null && other.Vault == null ||
                 this.Vault?.Equals(other.Vault) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Vault = {(this.Vault == null ? "null" : this.Vault.ToString())}");
        }
    }
}