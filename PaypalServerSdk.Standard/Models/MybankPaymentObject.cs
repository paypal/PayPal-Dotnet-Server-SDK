// <copyright file="MybankPaymentObject.cs" company="APIMatic">
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
    /// MybankPaymentObject.
    /// </summary>
    public class MybankPaymentObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MybankPaymentObject"/> class.
        /// </summary>
        public MybankPaymentObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MybankPaymentObject"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="countryCode">country_code.</param>
        /// <param name="bic">bic.</param>
        /// <param name="ibanLastChars">iban_last_chars.</param>
        public MybankPaymentObject(
            string name = null,
            string countryCode = null,
            string bic = null,
            string ibanLastChars = null)
        {
            this.Name = name;
            this.CountryCode = countryCode;
            this.Bic = bic;
            this.IbanLastChars = ibanLastChars;
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
        /// The business identification code (BIC). In payments systems, a BIC is used to identify a specific business, most commonly a bank.
        /// </summary>
        [JsonProperty("bic", NullValueHandling = NullValueHandling.Ignore)]
        public string Bic { get; set; }

        /// <summary>
        /// The last characters of the IBAN used to pay.
        /// </summary>
        [JsonProperty("iban_last_chars", NullValueHandling = NullValueHandling.Ignore)]
        public string IbanLastChars { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MybankPaymentObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is MybankPaymentObject other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.CountryCode == null && other.CountryCode == null ||
                 this.CountryCode?.Equals(other.CountryCode) == true) &&
                (this.Bic == null && other.Bic == null ||
                 this.Bic?.Equals(other.Bic) == true) &&
                (this.IbanLastChars == null && other.IbanLastChars == null ||
                 this.IbanLastChars?.Equals(other.IbanLastChars) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"CountryCode = {this.CountryCode ?? "null"}");
            toStringOutput.Add($"Bic = {this.Bic ?? "null"}");
            toStringOutput.Add($"IbanLastChars = {this.IbanLastChars ?? "null"}");
        }
    }
}