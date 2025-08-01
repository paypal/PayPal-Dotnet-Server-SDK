// <copyright file="VaultedDigitalWallet.cs" company="APIMatic">
// PaypalServerSdk.Standard
//
// This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// VaultedDigitalWallet.
    /// </summary>
    public class VaultedDigitalWallet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultedDigitalWallet"/> class.
        /// </summary>
        public VaultedDigitalWallet()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultedDigitalWallet"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="usagePattern">usage_pattern.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="permitMultiplePaymentTokens">permit_multiple_payment_tokens.</param>
        /// <param name="usageType">usage_type.</param>
        /// <param name="customerType">customer_type.</param>
        public VaultedDigitalWallet(
            string description = null,
            Models.UsagePattern? usagePattern = null,
            Models.VaultedDigitalWalletShippingDetails shipping = null,
            bool? permitMultiplePaymentTokens = false,
            Models.PaypalPaymentTokenUsageType? usageType = null,
            Models.PaypalPaymentTokenCustomerType? customerType = null)
        {
            this.Description = description;
            this.UsagePattern = usagePattern;
            this.Shipping = shipping;
            this.PermitMultiplePaymentTokens = permitMultiplePaymentTokens;
            this.UsageType = usageType;
            this.CustomerType = customerType;
        }

        /// <summary>
        /// The description displayed to the consumer on the approval flow for a digital wallet, as well as on the merchant view of the payment token management experience. exp: PayPal.com.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Expected business/charge model for the billing agreement.
        /// </summary>
        [JsonProperty("usage_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UsagePattern? UsagePattern { get; set; }

        /// <summary>
        /// The shipping details.
        /// </summary>
        [JsonProperty("shipping", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VaultedDigitalWalletShippingDetails Shipping { get; set; }

        /// <summary>
        /// Create multiple payment tokens for the same payer, merchant/platform combination. Use this when the customer has not logged in at merchant/platform. The payment token thus generated, can then also be used to create the customer account at merchant/platform. Use this also when multiple payment tokens are required for the same payer, different customer at merchant/platform. This helps to identify customers distinctly even though they may share the same PayPal account. This only applies to PayPal payment source.
        /// </summary>
        [JsonProperty("permit_multiple_payment_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PermitMultiplePaymentTokens { get; set; }

        /// <summary>
        /// The usage type associated with a digital wallet payment token.
        /// </summary>
        [JsonProperty("usage_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalPaymentTokenUsageType? UsageType { get; set; }

        /// <summary>
        /// The customer type associated with a digital wallet payment token. This is to indicate whether the customer acting on the merchant / platform is either a business or a consumer.
        /// </summary>
        [JsonProperty("customer_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalPaymentTokenCustomerType? CustomerType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"VaultedDigitalWallet : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is VaultedDigitalWallet other &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.UsagePattern == null && other.UsagePattern == null ||
                 this.UsagePattern?.Equals(other.UsagePattern) == true) &&
                (this.Shipping == null && other.Shipping == null ||
                 this.Shipping?.Equals(other.Shipping) == true) &&
                (this.PermitMultiplePaymentTokens == null && other.PermitMultiplePaymentTokens == null ||
                 this.PermitMultiplePaymentTokens?.Equals(other.PermitMultiplePaymentTokens) == true) &&
                (this.UsageType == null && other.UsageType == null ||
                 this.UsageType?.Equals(other.UsageType) == true) &&
                (this.CustomerType == null && other.CustomerType == null ||
                 this.CustomerType?.Equals(other.CustomerType) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"UsagePattern = {(this.UsagePattern == null ? "null" : this.UsagePattern.ToString())}");
            toStringOutput.Add($"Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"PermitMultiplePaymentTokens = {(this.PermitMultiplePaymentTokens == null ? "null" : this.PermitMultiplePaymentTokens.ToString())}");
            toStringOutput.Add($"UsageType = {(this.UsageType == null ? "null" : this.UsageType.ToString())}");
            toStringOutput.Add($"CustomerType = {(this.CustomerType == null ? "null" : this.CustomerType.ToString())}");
        }
    }
}