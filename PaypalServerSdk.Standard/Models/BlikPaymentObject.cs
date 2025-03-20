// <copyright file="BlikPaymentObject.cs" company="APIMatic">
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
    /// BlikPaymentObject.
    /// </summary>
    public class BlikPaymentObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlikPaymentObject"/> class.
        /// </summary>
        public BlikPaymentObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlikPaymentObject"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="countryCode">country_code.</param>
        /// <param name="email">email.</param>
        /// <param name="oneClick">one_click.</param>
        public BlikPaymentObject(
            string name = null,
            string countryCode = null,
            string email = null,
            Models.BlikOneClickPaymentObject oneClick = null)
        {
            this.Name = name;
            this.CountryCode = countryCode;
            this.Email = email;
            this.OneClick = oneClick;
        }

        /// <summary>
        /// The full name representation like Mr J Smith.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The [two-character ISO 3166-1 code](/api/rest/reference/country-codes/) that identifies the country or region. Note: The country code for Great Britain is GB and not UK as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.
        /// </summary>
        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// Information used to pay using BLIK one-click flow.
        /// </summary>
        [JsonProperty("one_click", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BlikOneClickPaymentObject OneClick { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BlikPaymentObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BlikPaymentObject other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.CountryCode == null && other.CountryCode == null ||
                 this.CountryCode?.Equals(other.CountryCode) == true) &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.OneClick == null && other.OneClick == null ||
                 this.OneClick?.Equals(other.OneClick) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"CountryCode = {this.CountryCode ?? "null"}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"OneClick = {(this.OneClick == null ? "null" : this.OneClick.ToString())}");
        }
    }
}