// <copyright file="PaypalWalletExperienceContext.cs" company="APIMatic">
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
using PaypalServerSDK.Standard;
using PaypalServerSDK.Standard.Utilities;

namespace PaypalServerSDK.Standard.Models
{
    /// <summary>
    /// PaypalWalletExperienceContext.
    /// </summary>
    public class PaypalWalletExperienceContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalWalletExperienceContext"/> class.
        /// </summary>
        public PaypalWalletExperienceContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalWalletExperienceContext"/> class.
        /// </summary>
        /// <param name="brandName">brand_name.</param>
        /// <param name="locale">locale.</param>
        /// <param name="shippingPreference">shipping_preference.</param>
        /// <param name="returnUrl">return_url.</param>
        /// <param name="cancelUrl">cancel_url.</param>
        /// <param name="landingPage">landing_page.</param>
        /// <param name="userAction">user_action.</param>
        /// <param name="paymentMethodPreference">payment_method_preference.</param>
        public PaypalWalletExperienceContext(
            string brandName = null,
            string locale = null,
            Models.ShippingPreference? shippingPreference = Models.ShippingPreference.GETFROMFILE,
            string returnUrl = null,
            string cancelUrl = null,
            Models.PaypalExperienceLandingPage? landingPage = Models.PaypalExperienceLandingPage.NOPREFERENCE,
            Models.PaypalExperienceUserAction? userAction = Models.PaypalExperienceUserAction.CONTINUE,
            Models.PayeePaymentMethodPreference? paymentMethodPreference = Models.PayeePaymentMethodPreference.UNRESTRICTED)
        {
            this.BrandName = brandName;
            this.Locale = locale;
            this.ShippingPreference = shippingPreference;
            this.ReturnUrl = returnUrl;
            this.CancelUrl = cancelUrl;
            this.LandingPage = landingPage;
            this.UserAction = userAction;
            this.PaymentMethodPreference = paymentMethodPreference;
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
        /// The location from which the shipping address is derived.
        /// </summary>
        [JsonProperty("shipping_preference", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShippingPreference? ShippingPreference { get; set; }

        /// <summary>
        /// Describes the URL.
        /// </summary>
        [JsonProperty("return_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Describes the URL.
        /// </summary>
        [JsonProperty("cancel_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CancelUrl { get; set; }

        /// <summary>
        /// The type of landing page to show on the PayPal site for customer checkout.
        /// </summary>
        [JsonProperty("landing_page", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalExperienceLandingPage? LandingPage { get; set; }

        /// <summary>
        /// Configures a <strong>Continue</strong> or <strong>Pay Now</strong> checkout flow.
        /// </summary>
        [JsonProperty("user_action", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalExperienceUserAction? UserAction { get; set; }

        /// <summary>
        /// The merchant-preferred payment methods.
        /// </summary>
        [JsonProperty("payment_method_preference", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayeePaymentMethodPreference? PaymentMethodPreference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaypalWalletExperienceContext : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaypalWalletExperienceContext other &&                ((this.BrandName == null && other.BrandName == null) || (this.BrandName?.Equals(other.BrandName) == true)) &&
                ((this.Locale == null && other.Locale == null) || (this.Locale?.Equals(other.Locale) == true)) &&
                ((this.ShippingPreference == null && other.ShippingPreference == null) || (this.ShippingPreference?.Equals(other.ShippingPreference) == true)) &&
                ((this.ReturnUrl == null && other.ReturnUrl == null) || (this.ReturnUrl?.Equals(other.ReturnUrl) == true)) &&
                ((this.CancelUrl == null && other.CancelUrl == null) || (this.CancelUrl?.Equals(other.CancelUrl) == true)) &&
                ((this.LandingPage == null && other.LandingPage == null) || (this.LandingPage?.Equals(other.LandingPage) == true)) &&
                ((this.UserAction == null && other.UserAction == null) || (this.UserAction?.Equals(other.UserAction) == true)) &&
                ((this.PaymentMethodPreference == null && other.PaymentMethodPreference == null) || (this.PaymentMethodPreference?.Equals(other.PaymentMethodPreference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BrandName = {(this.BrandName == null ? "null" : this.BrandName)}");
            toStringOutput.Add($"this.Locale = {(this.Locale == null ? "null" : this.Locale)}");
            toStringOutput.Add($"this.ShippingPreference = {(this.ShippingPreference == null ? "null" : this.ShippingPreference.ToString())}");
            toStringOutput.Add($"this.ReturnUrl = {(this.ReturnUrl == null ? "null" : this.ReturnUrl)}");
            toStringOutput.Add($"this.CancelUrl = {(this.CancelUrl == null ? "null" : this.CancelUrl)}");
            toStringOutput.Add($"this.LandingPage = {(this.LandingPage == null ? "null" : this.LandingPage.ToString())}");
            toStringOutput.Add($"this.UserAction = {(this.UserAction == null ? "null" : this.UserAction.ToString())}");
            toStringOutput.Add($"this.PaymentMethodPreference = {(this.PaymentMethodPreference == null ? "null" : this.PaymentMethodPreference.ToString())}");
        }
    }
}