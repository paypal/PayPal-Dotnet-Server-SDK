// <copyright file="PaypalWalletVaultInstruction.cs" company="APIMatic">
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
    /// PaypalWalletVaultInstruction.
    /// </summary>
    public class PaypalWalletVaultInstruction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalWalletVaultInstruction"/> class.
        /// </summary>
        public PaypalWalletVaultInstruction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalWalletVaultInstruction"/> class.
        /// </summary>
        /// <param name="usageType">usage_type.</param>
        /// <param name="storeInVault">store_in_vault.</param>
        /// <param name="description">description.</param>
        /// <param name="usagePattern">usage_pattern.</param>
        /// <param name="customerType">customer_type.</param>
        /// <param name="permitMultiplePaymentTokens">permit_multiple_payment_tokens.</param>
        public PaypalWalletVaultInstruction(
            Models.PaypalPaymentTokenUsageType usageType,
            Models.StoreInVaultInstruction? storeInVault = null,
            string description = null,
            Models.PaypalPaymentTokenUsagePattern? usagePattern = null,
            Models.PaypalPaymentTokenCustomerType? customerType = Models.PaypalPaymentTokenCustomerType.Consumer,
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
        [JsonProperty("store_in_vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StoreInVaultInstruction? StoreInVault { get; set; }

        /// <summary>
        /// The description displayed to PayPal consumer on the approval flow for PayPal, as well as on the PayPal payment token management experience on PayPal.com.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Expected business/pricing model for the billing agreement.
        /// </summary>
        [JsonProperty("usage_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalPaymentTokenUsagePattern? UsagePattern { get; set; }

        /// <summary>
        /// The usage type associated with the PayPal payment token.
        /// </summary>
        [JsonProperty("usage_type")]
        public Models.PaypalPaymentTokenUsageType UsageType { get; set; }

        /// <summary>
        /// The customer type associated with the PayPal payment token. This is to indicate whether the customer acting on the merchant / platform is either a business or a consumer.
        /// </summary>
        [JsonProperty("customer_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalPaymentTokenCustomerType? CustomerType { get; set; }

        /// <summary>
        /// Create multiple payment tokens for the same payer, merchant/platform combination. Use this when the customer has not logged in at merchant/platform. The payment token thus generated, can then also be used to create the customer account at merchant/platform. Use this also when multiple payment tokens are required for the same payer, different customer at merchant/platform. This helps to identify customers distinctly even though they may share the same PayPal account. This only applies to PayPal payment source.
        /// </summary>
        [JsonProperty("permit_multiple_payment_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PermitMultiplePaymentTokens { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaypalWalletVaultInstruction : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaypalWalletVaultInstruction other &&                ((this.StoreInVault == null && other.StoreInVault == null) || (this.StoreInVault?.Equals(other.StoreInVault) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.UsagePattern == null && other.UsagePattern == null) || (this.UsagePattern?.Equals(other.UsagePattern) == true)) &&
                this.UsageType.Equals(other.UsageType) &&
                ((this.CustomerType == null && other.CustomerType == null) || (this.CustomerType?.Equals(other.CustomerType) == true)) &&
                ((this.PermitMultiplePaymentTokens == null && other.PermitMultiplePaymentTokens == null) || (this.PermitMultiplePaymentTokens?.Equals(other.PermitMultiplePaymentTokens) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StoreInVault = {(this.StoreInVault == null ? "null" : this.StoreInVault.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.UsagePattern = {(this.UsagePattern == null ? "null" : this.UsagePattern.ToString())}");
            toStringOutput.Add($"this.UsageType = {this.UsageType}");
            toStringOutput.Add($"this.CustomerType = {(this.CustomerType == null ? "null" : this.CustomerType.ToString())}");
            toStringOutput.Add($"this.PermitMultiplePaymentTokens = {(this.PermitMultiplePaymentTokens == null ? "null" : this.PermitMultiplePaymentTokens.ToString())}");
        }
    }
}