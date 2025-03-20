// <copyright file="OrderApplicationContext.cs" company="APIMatic">
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
    /// OrderApplicationContext.
    /// </summary>
    public class OrderApplicationContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApplicationContext"/> class.
        /// </summary>
        public OrderApplicationContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApplicationContext"/> class.
        /// </summary>
        /// <param name="brandName">brand_name.</param>
        /// <param name="locale">locale.</param>
        /// <param name="landingPage">landing_page.</param>
        /// <param name="shippingPreference">shipping_preference.</param>
        /// <param name="userAction">user_action.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="returnUrl">return_url.</param>
        /// <param name="cancelUrl">cancel_url.</param>
        /// <param name="storedPaymentSource">stored_payment_source.</param>
        public OrderApplicationContext(
            string brandName = null,
            string locale = null,
            Models.OrderApplicationContextLandingPage? landingPage = Models.OrderApplicationContextLandingPage.NoPreference,
            Models.OrderApplicationContextShippingPreference? shippingPreference = Models.OrderApplicationContextShippingPreference.GetFromFile,
            Models.OrderApplicationContextUserAction? userAction = Models.OrderApplicationContextUserAction.Continue,
            Models.PaymentMethodPreference paymentMethod = null,
            string returnUrl = null,
            string cancelUrl = null,
            Models.StoredPaymentSource storedPaymentSource = null)
        {
            this.BrandName = brandName;
            this.Locale = locale;
            this.LandingPage = landingPage;
            this.ShippingPreference = shippingPreference;
            this.UserAction = userAction;
            this.PaymentMethod = paymentMethod;
            this.ReturnUrl = returnUrl;
            this.CancelUrl = cancelUrl;
            this.StoredPaymentSource = storedPaymentSource;
        }

        /// <summary>
        /// DEPRECATED. The label that overrides the business name in the PayPal account on the PayPal site. The fields in `application_context` are now available in the `experience_context` object under the `payment_source` which supports them (eg. `payment_source.paypal.experience_context.brand_name`). Please specify this field in the `experience_context` object instead of the `application_context` object.
        /// </summary>
        [JsonProperty("brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandName { get; set; }

        /// <summary>
        /// The [language tag](https://tools.ietf.org/html/bcp47#section-2) for the language in which to localize the error-related strings, such as messages, issues, and suggested actions. The tag is made up of the [ISO 639-2 language code](https://www.loc.gov/standards/iso639-2/php/code_list.php), the optional [ISO-15924 script tag](https://www.unicode.org/iso15924/codelists.html), and the [ISO-3166 alpha-2 country code](/api/rest/reference/country-codes/) or [M49 region code](https://unstats.un.org/unsd/methodology/m49/).
        /// </summary>
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        public string Locale { get; set; }

        /// <summary>
        /// DEPRECATED. DEPRECATED. The type of landing page to show on the PayPal site for customer checkout.  The fields in `application_context` are now available in the `experience_context` object under the `payment_source` which supports them (eg. `payment_source.paypal.experience_context.landing_page`). Please specify this field in the `experience_context` object instead of the `application_context` object.
        /// </summary>
        [JsonProperty("landing_page", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderApplicationContextLandingPage? LandingPage { get; set; }

        /// <summary>
        /// DEPRECATED. DEPRECATED. The shipping preference: Displays the shipping address to the customer. Enables the customer to choose an address on the PayPal site. Restricts the customer from changing the address during the payment-approval process. .  The fields in `application_context` are now available in the `experience_context` object under the `payment_source` which supports them (eg. `payment_source.paypal.experience_context.shipping_preference`). Please specify this field in the `experience_context` object instead of the `application_context` object.
        /// </summary>
        [JsonProperty("shipping_preference", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderApplicationContextShippingPreference? ShippingPreference { get; set; }

        /// <summary>
        /// DEPRECATED. Configures a Continue or Pay Now checkout flow.  The fields in `application_context` are now available in the `experience_context` object under the `payment_source` which supports them (eg. `payment_source.paypal.experience_context.user_action`). Please specify this field in the `experience_context` object instead of the `application_context` object.
        /// </summary>
        [JsonProperty("user_action", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderApplicationContextUserAction? UserAction { get; set; }

        /// <summary>
        /// The customer and merchant payment preferences.
        /// </summary>
        [JsonProperty("payment_method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentMethodPreference PaymentMethod { get; set; }

        /// <summary>
        /// DEPRECATED. The URL where the customer is redirected after the customer approves the payment. The fields in `application_context` are now available in the `experience_context` object under the `payment_source` which supports them (eg. `payment_source.paypal.experience_context.return_url`). Please specify this field in the `experience_context` object instead of the `application_context` object.
        /// </summary>
        [JsonProperty("return_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// DEPRECATED. The URL where the customer is redirected after the customer cancels the payment. The fields in `application_context` are now available in the `experience_context` object under the `payment_source` which supports them (eg. `payment_source.paypal.experience_context.cancel_url`). Please specify this field in the `experience_context` object instead of the `application_context` object.
        /// </summary>
        [JsonProperty("cancel_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CancelUrl { get; set; }

        /// <summary>
        /// Provides additional details to process a payment using a `payment_source` that has been stored or is intended to be stored (also referred to as stored_credential or card-on-file). Parameter compatibility: `payment_type=ONE_TIME` is compatible only with `payment_initiator=CUSTOMER`. `usage=FIRST` is compatible only with `payment_initiator=CUSTOMER`. `previous_transaction_reference` or `previous_network_transaction_reference` is compatible only with `payment_initiator=MERCHANT`. Only one of the parameters - `previous_transaction_reference` and `previous_network_transaction_reference` - can be present in the request.
        /// </summary>
        [JsonProperty("stored_payment_source", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StoredPaymentSource StoredPaymentSource { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderApplicationContext : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderApplicationContext other &&
                (this.BrandName == null && other.BrandName == null ||
                 this.BrandName?.Equals(other.BrandName) == true) &&
                (this.Locale == null && other.Locale == null ||
                 this.Locale?.Equals(other.Locale) == true) &&
                (this.LandingPage == null && other.LandingPage == null ||
                 this.LandingPage?.Equals(other.LandingPage) == true) &&
                (this.ShippingPreference == null && other.ShippingPreference == null ||
                 this.ShippingPreference?.Equals(other.ShippingPreference) == true) &&
                (this.UserAction == null && other.UserAction == null ||
                 this.UserAction?.Equals(other.UserAction) == true) &&
                (this.PaymentMethod == null && other.PaymentMethod == null ||
                 this.PaymentMethod?.Equals(other.PaymentMethod) == true) &&
                (this.ReturnUrl == null && other.ReturnUrl == null ||
                 this.ReturnUrl?.Equals(other.ReturnUrl) == true) &&
                (this.CancelUrl == null && other.CancelUrl == null ||
                 this.CancelUrl?.Equals(other.CancelUrl) == true) &&
                (this.StoredPaymentSource == null && other.StoredPaymentSource == null ||
                 this.StoredPaymentSource?.Equals(other.StoredPaymentSource) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"BrandName = {this.BrandName ?? "null"}");
            toStringOutput.Add($"Locale = {this.Locale ?? "null"}");
            toStringOutput.Add($"LandingPage = {(this.LandingPage == null ? "null" : this.LandingPage.ToString())}");
            toStringOutput.Add($"ShippingPreference = {(this.ShippingPreference == null ? "null" : this.ShippingPreference.ToString())}");
            toStringOutput.Add($"UserAction = {(this.UserAction == null ? "null" : this.UserAction.ToString())}");
            toStringOutput.Add($"PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod.ToString())}");
            toStringOutput.Add($"ReturnUrl = {this.ReturnUrl ?? "null"}");
            toStringOutput.Add($"CancelUrl = {this.CancelUrl ?? "null"}");
            toStringOutput.Add($"StoredPaymentSource = {(this.StoredPaymentSource == null ? "null" : this.StoredPaymentSource.ToString())}");
        }
    }
}