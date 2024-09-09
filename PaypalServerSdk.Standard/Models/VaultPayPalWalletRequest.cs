// <copyright file="VaultPayPalWalletRequest.cs" company="APIMatic">
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
    /// VaultPayPalWalletRequest.
    /// </summary>
    public class VaultPayPalWalletRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultPayPalWalletRequest"/> class.
        /// </summary>
        public VaultPayPalWalletRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultPayPalWalletRequest"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="permitMultiplePaymentTokens">permit_multiple_payment_tokens.</param>
        /// <param name="usageType">usage_type.</param>
        /// <param name="customerType">customer_type.</param>
        /// <param name="experienceContext">experience_context.</param>
        public VaultPayPalWalletRequest(
            string description = null,
            Models.VaultedDigitalWalletShippingDetails shipping = null,
            bool? permitMultiplePaymentTokens = false,
            string usageType = null,
            string customerType = null,
            Models.VaultExperienceContext experienceContext = null)
        {
            this.Description = description;
            this.Shipping = shipping;
            this.PermitMultiplePaymentTokens = permitMultiplePaymentTokens;
            this.UsageType = usageType;
            this.CustomerType = customerType;
            this.ExperienceContext = experienceContext;
        }

        /// <summary>
        /// The description displayed to the consumer on the approval flow for a digital wallet, as well as on the merchant view of the payment token management experience. exp: PayPal.com.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

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
        public string UsageType { get; set; }

        /// <summary>
        /// The customer type associated with a digital wallet payment token. This is to indicate whether the customer acting on the merchant / platform is either a business or a consumer.
        /// </summary>
        [JsonProperty("customer_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerType { get; set; }

        /// <summary>
        /// Customizes the Vault creation flow experience for your customers.
        /// </summary>
        [JsonProperty("experience_context", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VaultExperienceContext ExperienceContext { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VaultPayPalWalletRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is VaultPayPalWalletRequest other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Shipping == null && other.Shipping == null) || (this.Shipping?.Equals(other.Shipping) == true)) &&
                ((this.PermitMultiplePaymentTokens == null && other.PermitMultiplePaymentTokens == null) || (this.PermitMultiplePaymentTokens?.Equals(other.PermitMultiplePaymentTokens) == true)) &&
                ((this.UsageType == null && other.UsageType == null) || (this.UsageType?.Equals(other.UsageType) == true)) &&
                ((this.CustomerType == null && other.CustomerType == null) || (this.CustomerType?.Equals(other.CustomerType) == true)) &&
                ((this.ExperienceContext == null && other.ExperienceContext == null) || (this.ExperienceContext?.Equals(other.ExperienceContext) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"this.PermitMultiplePaymentTokens = {(this.PermitMultiplePaymentTokens == null ? "null" : this.PermitMultiplePaymentTokens.ToString())}");
            toStringOutput.Add($"this.UsageType = {(this.UsageType == null ? "null" : this.UsageType)}");
            toStringOutput.Add($"this.CustomerType = {(this.CustomerType == null ? "null" : this.CustomerType)}");
            toStringOutput.Add($"this.ExperienceContext = {(this.ExperienceContext == null ? "null" : this.ExperienceContext.ToString())}");
        }
    }
}