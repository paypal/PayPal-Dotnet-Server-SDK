// <copyright file="VaultExperienceContext.cs" company="APIMatic">
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
    /// VaultExperienceContext.
    /// </summary>
    public class VaultExperienceContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultExperienceContext"/> class.
        /// </summary>
        public VaultExperienceContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultExperienceContext"/> class.
        /// </summary>
        /// <param name="brandName">brand_name.</param>
        /// <param name="locale">locale.</param>
        /// <param name="returnUrl">return_url.</param>
        /// <param name="cancelUrl">cancel_url.</param>
        /// <param name="shippingPreference">shipping_preference.</param>
        /// <param name="vaultInstruction">vault_instruction.</param>
        public VaultExperienceContext(
            string brandName = null,
            string locale = null,
            string returnUrl = null,
            string cancelUrl = null,
            string shippingPreference = "GET_FROM_FILE",
            string vaultInstruction = "ON_CREATE_PAYMENT_TOKENS")
        {
            this.BrandName = brandName;
            this.Locale = locale;
            this.ReturnUrl = returnUrl;
            this.CancelUrl = cancelUrl;
            this.ShippingPreference = shippingPreference;
            this.VaultInstruction = vaultInstruction;
        }

        /// <summary>
        /// The label that overrides the business name in the PayPal account on the PayPal site. The pattern is defined by an external party and supports Unicode.
        /// </summary>
        [JsonProperty("brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandName { get; set; }

        /// <summary>
        /// The [language tag](https://tools.ietf.org/html/bcp47#section-2) for the language in which to localize the error-related strings, such as messages, issues, and suggested actions. The tag is made up of the [ISO 639-2 language code](https://www.loc.gov/standards/iso639-2/php/code_list.php), the optional [ISO-15924 script tag](https://www.unicode.org/iso15924/codelists.html), and the [ISO-3166 alpha-2 country code](/api/rest/reference/country-codes/) or [M49 region code](https://unstats.un.org/unsd/methodology/m49/).
        /// </summary>
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        public string Locale { get; set; }

        /// <summary>
        /// The URL where the customer is redirected after customer approves leaves the flow. It is a required field for contingency flows like PayPal wallet, 3DS.
        /// </summary>
        [JsonProperty("return_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The URL where the customer is redirected after customer cancels or leaves the flow. It is a required field for contingency flows like PayPal wallet, 3DS.
        /// </summary>
        [JsonProperty("cancel_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CancelUrl { get; set; }

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

            return $"VaultExperienceContext : ({string.Join(", ", toStringOutput)})";
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
            return obj is VaultExperienceContext other &&                ((this.BrandName == null && other.BrandName == null) || (this.BrandName?.Equals(other.BrandName) == true)) &&
                ((this.Locale == null && other.Locale == null) || (this.Locale?.Equals(other.Locale) == true)) &&
                ((this.ReturnUrl == null && other.ReturnUrl == null) || (this.ReturnUrl?.Equals(other.ReturnUrl) == true)) &&
                ((this.CancelUrl == null && other.CancelUrl == null) || (this.CancelUrl?.Equals(other.CancelUrl) == true)) &&
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
            toStringOutput.Add($"this.Locale = {(this.Locale == null ? "null" : this.Locale)}");
            toStringOutput.Add($"this.ReturnUrl = {(this.ReturnUrl == null ? "null" : this.ReturnUrl)}");
            toStringOutput.Add($"this.CancelUrl = {(this.CancelUrl == null ? "null" : this.CancelUrl)}");
            toStringOutput.Add($"this.ShippingPreference = {(this.ShippingPreference == null ? "null" : this.ShippingPreference)}");
            toStringOutput.Add($"this.VaultInstruction = {(this.VaultInstruction == null ? "null" : this.VaultInstruction)}");
        }
    }
}