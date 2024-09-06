// <copyright file="EPSPaymentRequest.cs" company="APIMatic">
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
using PayPalRESTAPIs.Standard;
using PayPalRESTAPIs.Standard.Utilities;

namespace PayPalRESTAPIs.Standard.Models
{
    /// <summary>
    /// EPSPaymentRequest.
    /// </summary>
    public class EPSPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EPSPaymentRequest"/> class.
        /// </summary>
        public EPSPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EPSPaymentRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="countryCode">country_code.</param>
        /// <param name="experienceContext">experience_context.</param>
        public EPSPaymentRequest(
            string name,
            string countryCode,
            Models.ExperienceContext experienceContext = null)
        {
            this.Name = name;
            this.CountryCode = countryCode;
            this.ExperienceContext = experienceContext;
        }

        /// <summary>
        /// The full name representation like Mr J Smith.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The [two-character ISO 3166-1 code](/api/rest/reference/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote>
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

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

            return $"EPSPaymentRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is EPSPaymentRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.ExperienceContext == null && other.ExperienceContext == null) || (this.ExperienceContext?.Equals(other.ExperienceContext) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.ExperienceContext = {(this.ExperienceContext == null ? "null" : this.ExperienceContext.ToString())}");
        }
    }
}