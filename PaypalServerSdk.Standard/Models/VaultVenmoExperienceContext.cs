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
using PaypalServerSdk.Standard;
using PaypalServerSdk.Standard.Utilities;

namespace PaypalServerSdk.Standard.Models
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
            Models.OrderApplicationContextShippingPreference? shippingPreference = Models.OrderApplicationContextShippingPreference.GetFromFile,
            Models.VaultInstructionAction? vaultInstruction = Models.VaultInstructionAction.OnCreatePaymentTokens)
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
        public Models.OrderApplicationContextShippingPreference? ShippingPreference { get; set; }

        /// <summary>
        /// Vault Instruction on action to be performed after a successful payer approval.
        /// </summary>
        [JsonProperty("vault_instruction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VaultInstructionAction? VaultInstruction { get; set; }

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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is VaultVenmoExperienceContext other &&
                (this.BrandName == null && other.BrandName == null ||
                 this.BrandName?.Equals(other.BrandName) == true) &&
                (this.ShippingPreference == null && other.ShippingPreference == null ||
                 this.ShippingPreference?.Equals(other.ShippingPreference) == true) &&
                (this.VaultInstruction == null && other.VaultInstruction == null ||
                 this.VaultInstruction?.Equals(other.VaultInstruction) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"BrandName = {this.BrandName ?? "null"}");
            toStringOutput.Add($"ShippingPreference = {(this.ShippingPreference == null ? "null" : this.ShippingPreference.ToString())}");
            toStringOutput.Add($"VaultInstruction = {(this.VaultInstruction == null ? "null" : this.VaultInstruction.ToString())}");
        }
    }
}