// <copyright file="VaultVenmoExperienceContext.cs" company="APIMatic">
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
    /// VaultVenmoExperienceContext.
    /// </summary>
    public class VaultVenmoExperienceContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultVenmoExperienceContext"/> class.
        /// </summary>
        public VaultVenmoExperienceContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultVenmoExperienceContext"/> class.
        /// </summary>
        /// <param name="brandName">brand_name.</param>
        /// <param name="shippingPreference">shipping_preference.</param>
        /// <param name="vaultInstruction">vault_instruction.</param>
        public VaultVenmoExperienceContext(
            string brandName = null,
            string shippingPreference = "GET_FROM_FILE",
            string vaultInstruction = "ON_CREATE_PAYMENT_TOKENS")
        {
            this.BrandName = brandName;
            this.ShippingPreference = shippingPreference;
            this.VaultInstruction = vaultInstruction;
        }

        /// <summary>
        /// The label that overrides the business name in the PayPal account on the PayPal site. The pattern is defined by an external party and supports Unicode.
        /// </summary>
        [JsonProperty("brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandName { get; set; }

        /// <summary>
        /// The shipping preference. This only applies to PayPal payment source.
        /// </summary>
        [JsonProperty("shipping_preference", NullValueHandling = NullValueHandling.Ignore)]
        public string ShippingPreference { get; set; }

        /// <summary>
        /// Vault Instruction on action to be performed after a successful payer approval.
        /// </summary>
        [JsonProperty("vault_instruction", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultInstruction { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VaultVenmoExperienceContext : ({string.Join(", ", toStringOutput)})";
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
            return obj is VaultVenmoExperienceContext other &&                ((this.BrandName == null && other.BrandName == null) || (this.BrandName?.Equals(other.BrandName) == true)) &&
                ((this.ShippingPreference == null && other.ShippingPreference == null) || (this.ShippingPreference?.Equals(other.ShippingPreference) == true)) &&
                ((this.VaultInstruction == null && other.VaultInstruction == null) || (this.VaultInstruction?.Equals(other.VaultInstruction) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BrandName = {(this.BrandName == null ? "null" : this.BrandName)}");
            toStringOutput.Add($"this.ShippingPreference = {(this.ShippingPreference == null ? "null" : this.ShippingPreference)}");
            toStringOutput.Add($"this.VaultInstruction = {(this.VaultInstruction == null ? "null" : this.VaultInstruction)}");
        }
    }
}