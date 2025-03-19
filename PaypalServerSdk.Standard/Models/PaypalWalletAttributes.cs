// <copyright file="PaypalWalletAttributes.cs" company="APIMatic">
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
    /// PaypalWalletAttributes.
    /// </summary>
    public class PaypalWalletAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalWalletAttributes"/> class.
        /// </summary>
        public PaypalWalletAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalWalletAttributes"/> class.
        /// </summary>
        /// <param name="customer">customer.</param>
        /// <param name="vault">vault.</param>
        public PaypalWalletAttributes(
            Models.PaypalWalletCustomerRequest customer = null,
            Models.PaypalWalletVaultInstruction vault = null)
        {
            this.Customer = customer;
            this.Vault = vault;
        }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalWalletCustomerRequest Customer { get; set; }

        /// <summary>
        /// Gets or sets Vault.
        /// </summary>
        [JsonProperty("vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalWalletVaultInstruction Vault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaypalWalletAttributes : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaypalWalletAttributes other &&
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