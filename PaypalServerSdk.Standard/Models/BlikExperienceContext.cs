// <copyright file="BlikExperienceContext.cs" company="APIMatic">
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
    /// BlikExperienceContext.
    /// </summary>
    public class BlikExperienceContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlikExperienceContext"/> class.
        /// </summary>
        public BlikExperienceContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlikExperienceContext"/> class.
        /// </summary>
        /// <param name="brandName">brand_name.</param>
        /// <param name="locale">locale.</param>
        /// <param name="shippingPreference">shipping_preference.</param>
        /// <param name="returnUrl">return_url.</param>
        /// <param name="cancelUrl">cancel_url.</param>
        /// <param name="consumerIp">consumer_ip.</param>
        /// <param name="consumerUserAgent">consumer_user_agent.</param>
        public BlikExperienceContext(
            string brandName = null,
            string locale = null,
            Models.ShippingPreference? shippingPreference = Models.ShippingPreference.GetFromFile,
            string returnUrl = null,
            string cancelUrl = null,
            string consumerIp = null,
            string consumerUserAgent = null)
        {
            this.BrandName = brandName;
            this.Locale = locale;
            this.ShippingPreference = shippingPreference;
            this.ReturnUrl = returnUrl;
            this.CancelUrl = cancelUrl;
            this.ConsumerIp = consumerIp;
            this.ConsumerUserAgent = consumerUserAgent;
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
        /// An Internet Protocol address (IP address). This address assigns a numerical label to each device that is connected to a computer network through the Internet Protocol. Supports IPv4 and IPv6 addresses.
        /// </summary>
        [JsonProperty("consumer_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerIp { get; set; }

        /// <summary>
        /// The payer's User Agent. For example, Mozilla/5.0 (Macintosh; Intel Mac OS X x.y; rv:42.0).
        /// </summary>
        [JsonProperty("consumer_user_agent", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerUserAgent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BlikExperienceContext : ({string.Join(", ", toStringOutput)})";
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
            return obj is BlikExperienceContext other &&                ((this.BrandName == null && other.BrandName == null) || (this.BrandName?.Equals(other.BrandName) == true)) &&
                ((this.Locale == null && other.Locale == null) || (this.Locale?.Equals(other.Locale) == true)) &&
                ((this.ShippingPreference == null && other.ShippingPreference == null) || (this.ShippingPreference?.Equals(other.ShippingPreference) == true)) &&
                ((this.ReturnUrl == null && other.ReturnUrl == null) || (this.ReturnUrl?.Equals(other.ReturnUrl) == true)) &&
                ((this.CancelUrl == null && other.CancelUrl == null) || (this.CancelUrl?.Equals(other.CancelUrl) == true)) &&
                ((this.ConsumerIp == null && other.ConsumerIp == null) || (this.ConsumerIp?.Equals(other.ConsumerIp) == true)) &&
                ((this.ConsumerUserAgent == null && other.ConsumerUserAgent == null) || (this.ConsumerUserAgent?.Equals(other.ConsumerUserAgent) == true));
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
            toStringOutput.Add($"this.ConsumerIp = {(this.ConsumerIp == null ? "null" : this.ConsumerIp)}");
            toStringOutput.Add($"this.ConsumerUserAgent = {(this.ConsumerUserAgent == null ? "null" : this.ConsumerUserAgent)}");
        }
    }
}