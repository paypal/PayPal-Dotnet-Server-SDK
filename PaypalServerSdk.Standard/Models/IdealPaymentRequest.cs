// <copyright file="IdealPaymentRequest.cs" company="APIMatic">
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
    /// IdealPaymentRequest.
    /// </summary>
    public class IdealPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdealPaymentRequest"/> class.
        /// </summary>
        public IdealPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdealPaymentRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="countryCode">country_code.</param>
        /// <param name="bic">bic.</param>
        /// <param name="experienceContext">experience_context.</param>
        public IdealPaymentRequest(
            string name,
            string countryCode,
            string bic = null,
            Models.ExperienceContext experienceContext = null)
        {
            this.Name = name;
            this.CountryCode = countryCode;
            this.Bic = bic;
            this.ExperienceContext = experienceContext;
        }

        /// <summary>
        /// The full name representation like Mr J Smith.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The [two-character ISO 3166-1 code](/api/rest/reference/country-codes/) that identifies the country or region. Note: The country code for Great Britain is GB and not UK as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The business identification code (BIC). In payments systems, a BIC is used to identify a specific business, most commonly a bank.
        /// </summary>
        [JsonProperty("bic", NullValueHandling = NullValueHandling.Ignore)]
        public string Bic { get; set; }

        /// <summary>
        /// Customizes the payer experience during the approval process for the payment.
        /// </summary>
        [JsonProperty("experience_context", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExperienceContext ExperienceContext { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"IdealPaymentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is IdealPaymentRequest other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.CountryCode == null && other.CountryCode == null ||
                 this.CountryCode?.Equals(other.CountryCode) == true) &&
                (this.Bic == null && other.Bic == null ||
                 this.Bic?.Equals(other.Bic) == true) &&
                (this.ExperienceContext == null && other.ExperienceContext == null ||
                 this.ExperienceContext?.Equals(other.ExperienceContext) == true);
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
            toStringOutput.Add($"ExperienceContext = {(this.ExperienceContext == null ? "null" : this.ExperienceContext.ToString())}");
        }
    }
}