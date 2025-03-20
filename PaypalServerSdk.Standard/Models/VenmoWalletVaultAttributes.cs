// <copyright file="VenmoWalletVaultAttributes.cs" company="APIMatic">
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
    /// VenmoWalletVaultAttributes.
    /// </summary>
    public class VenmoWalletVaultAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VenmoWalletVaultAttributes"/> class.
        /// </summary>
        public VenmoWalletVaultAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VenmoWalletVaultAttributes"/> class.
        /// </summary>
        /// <param name="storeInVault">store_in_vault.</param>
        /// <param name="usageType">usage_type.</param>
        /// <param name="description">description.</param>
        /// <param name="usagePattern">usage_pattern.</param>
        /// <param name="customerType">customer_type.</param>
        /// <param name="permitMultiplePaymentTokens">permit_multiple_payment_tokens.</param>
        public VenmoWalletVaultAttributes(
            Models.StoreInVaultInstruction storeInVault,
            Models.VenmoPaymentTokenUsageType usageType,
            string description = null,
            Models.VenmoPaymentTokenUsagePattern? usagePattern = null,
            Models.VenmoPaymentTokenCustomerType? customerType = Models.VenmoPaymentTokenCustomerType.Consumer,
            bool? permitMultiplePaymentTokens = false)
        {
            this.StoreInVault = storeInVault;
            this.Description = description;
            this.UsagePattern = usagePattern;
            this.UsageType = usageType;
            this.CustomerType = customerType;
            this.PermitMultiplePaymentTokens = permitMultiplePaymentTokens;
        }

        /// <summary>
        /// Defines how and when the payment source gets vaulted.
        /// </summary>
        [JsonProperty("store_in_vault")]
        public Models.StoreInVaultInstruction StoreInVault { get; set; }

        /// <summary>
        /// The description displayed to Venmo consumer on the approval flow for Venmo, as well as on the Venmo payment token management experience on Venmo.com.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Expected business/pricing model for the billing agreement.
        /// </summary>
        [JsonProperty("usage_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VenmoPaymentTokenUsagePattern? UsagePattern { get; set; }

        /// <summary>
        /// The usage type associated with the Venmo payment token.
        /// </summary>
        [JsonProperty("usage_type")]
        public Models.VenmoPaymentTokenUsageType UsageType { get; set; }

        /// <summary>
        /// The customer type associated with the Venmo payment token. This is to indicate whether the customer acting on the merchant / platform is either a business or a consumer.
        /// </summary>
        [JsonProperty("customer_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VenmoPaymentTokenCustomerType? CustomerType { get; set; }

        /// <summary>
        /// Create multiple payment tokens for the same payer, merchant/platform combination. Use this when the customer has not logged in at merchant/platform. The payment token thus generated, can then also be used to create the customer account at merchant/platform. Use this also when multiple payment tokens are required for the same payer, different customer at merchant/platform. This helps to identify customers distinctly even though they may share the same Venmo account.
        /// </summary>
        [JsonProperty("permit_multiple_payment_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PermitMultiplePaymentTokens { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"VenmoWalletVaultAttributes : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is VenmoWalletVaultAttributes other &&
                (this.StoreInVault.Equals(other.StoreInVault)) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.UsagePattern == null && other.UsagePattern == null ||
                 this.UsagePattern?.Equals(other.UsagePattern) == true) &&
                (this.UsageType.Equals(other.UsageType)) &&
                (this.CustomerType == null && other.CustomerType == null ||
                 this.CustomerType?.Equals(other.CustomerType) == true) &&
                (this.PermitMultiplePaymentTokens == null && other.PermitMultiplePaymentTokens == null ||
                 this.PermitMultiplePaymentTokens?.Equals(other.PermitMultiplePaymentTokens) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StoreInVault = {this.StoreInVault}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"UsagePattern = {(this.UsagePattern == null ? "null" : this.UsagePattern.ToString())}");
            toStringOutput.Add($"UsageType = {this.UsageType}");
            toStringOutput.Add($"CustomerType = {(this.CustomerType == null ? "null" : this.CustomerType.ToString())}");
            toStringOutput.Add($"PermitMultiplePaymentTokens = {(this.PermitMultiplePaymentTokens == null ? "null" : this.PermitMultiplePaymentTokens.ToString())}");
        }
    }
}