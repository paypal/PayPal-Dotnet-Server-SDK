// <copyright file="P24PaymentObject.cs" company="APIMatic">
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
    /// P24PaymentObject.
    /// </summary>
    public class P24PaymentObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="P24PaymentObject"/> class.
        /// </summary>
        public P24PaymentObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="P24PaymentObject"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="countryCode">country_code.</param>
        /// <param name="paymentDescriptor">payment_descriptor.</param>
        /// <param name="methodId">method_id.</param>
        /// <param name="methodDescription">method_description.</param>
        public P24PaymentObject(
            string name = null,
            string email = null,
            string countryCode = null,
            string paymentDescriptor = null,
            string methodId = null,
            string methodDescription = null)
        {
            this.Name = name;
            this.Email = email;
            this.CountryCode = countryCode;
            this.PaymentDescriptor = paymentDescriptor;
            this.MethodId = methodId;
            this.MethodDescription = methodDescription;
        }

        /// <summary>
        /// The full name representation like Mr J Smith.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// The [two-character ISO 3166-1 code](/api/rest/reference/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote>
        /// </summary>
        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        /// <summary>
        /// P24 generated payment description.
        /// </summary>
        [JsonProperty("payment_descriptor", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentDescriptor { get; set; }

        /// <summary>
        /// Numeric identifier of the payment scheme or bank used for the payment.
        /// </summary>
        [JsonProperty("method_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MethodId { get; set; }

        /// <summary>
        /// Friendly name of the payment scheme or bank used for the payment.
        /// </summary>
        [JsonProperty("method_description", NullValueHandling = NullValueHandling.Ignore)]
        public string MethodDescription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"P24PaymentObject : ({string.Join(", ", toStringOutput)})";
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
            return obj is P24PaymentObject other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.PaymentDescriptor == null && other.PaymentDescriptor == null) || (this.PaymentDescriptor?.Equals(other.PaymentDescriptor) == true)) &&
                ((this.MethodId == null && other.MethodId == null) || (this.MethodId?.Equals(other.MethodId) == true)) &&
                ((this.MethodDescription == null && other.MethodDescription == null) || (this.MethodDescription?.Equals(other.MethodDescription) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.PaymentDescriptor = {(this.PaymentDescriptor == null ? "null" : this.PaymentDescriptor)}");
            toStringOutput.Add($"this.MethodId = {(this.MethodId == null ? "null" : this.MethodId)}");
            toStringOutput.Add($"this.MethodDescription = {(this.MethodDescription == null ? "null" : this.MethodDescription)}");
        }
    }
}