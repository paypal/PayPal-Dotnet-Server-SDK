// <copyright file="ApplePayAttributes.cs" company="APIMatic">
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
using PayPalRESTAPIs.Standard;
using PayPalRESTAPIs.Standard.Utilities;

namespace PayPalRESTAPIs.Standard.Models
{
    /// <summary>
    /// ApplePayAttributes.
    /// </summary>
    public class ApplePayAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayAttributes"/> class.
        /// </summary>
        public ApplePayAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayAttributes"/> class.
        /// </summary>
        /// <param name="customer">customer.</param>
        /// <param name="vault">vault.</param>
        public ApplePayAttributes(
            Models.CustomerInformation customer = null,
            Models.VaultInstruction vault = null)
        {
            this.Customer = customer;
            this.Vault = vault;
        }

        /// <summary>
        /// The details about a customer in PayPal's system of record.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerInformation Customer { get; set; }

        /// <summary>
        /// Base vaulting specification. The object can be extended for specific use cases within each payment_source that supports vaulting.
        /// </summary>
        [JsonProperty("vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VaultInstruction Vault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApplePayAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is ApplePayAttributes other &&                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Vault == null && other.Vault == null) || (this.Vault?.Equals(other.Vault) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Vault = {(this.Vault == null ? "null" : this.Vault.ToString())}");
        }
    }
}