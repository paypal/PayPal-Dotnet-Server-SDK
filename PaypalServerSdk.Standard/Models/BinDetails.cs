// <copyright file="BinDetails.cs" company="APIMatic">
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
    /// BinDetails.
    /// </summary>
    public class BinDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinDetails"/> class.
        /// </summary>
        public BinDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinDetails"/> class.
        /// </summary>
        /// <param name="bin">bin.</param>
        /// <param name="issuingBank">issuing_bank.</param>
        /// <param name="binCountryCode">bin_country_code.</param>
        /// <param name="products">products.</param>
        public BinDetails(
            string bin = null,
            string issuingBank = null,
            string binCountryCode = null,
            List<string> products = null)
        {
            this.Bin = bin;
            this.IssuingBank = issuingBank;
            this.BinCountryCode = binCountryCode;
            this.Products = products;
        }

        /// <summary>
        /// The Bank Identification Number (BIN) signifies the number that is being used to identify the granular level details (except the PII information) of the card.
        /// </summary>
        [JsonProperty("bin", NullValueHandling = NullValueHandling.Ignore)]
        public string Bin { get; set; }

        /// <summary>
        /// The issuer of the card instrument.
        /// </summary>
        [JsonProperty("issuing_bank", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuingBank { get; set; }

        /// <summary>
        /// The [two-character ISO 3166-1 code](/api/rest/reference/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote>
        /// </summary>
        [JsonProperty("bin_country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BinCountryCode { get; set; }

        /// <summary>
        /// The type of card product assigned to the BIN by the issuer. These values are defined by the issuer and may change over time. Some examples include: PREPAID_GIFT, CONSUMER, CORPORATE.
        /// </summary>
        [JsonProperty("products", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Products { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BinDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is BinDetails other &&                ((this.Bin == null && other.Bin == null) || (this.Bin?.Equals(other.Bin) == true)) &&
                ((this.IssuingBank == null && other.IssuingBank == null) || (this.IssuingBank?.Equals(other.IssuingBank) == true)) &&
                ((this.BinCountryCode == null && other.BinCountryCode == null) || (this.BinCountryCode?.Equals(other.BinCountryCode) == true)) &&
                ((this.Products == null && other.Products == null) || (this.Products?.Equals(other.Products) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Bin = {(this.Bin == null ? "null" : this.Bin)}");
            toStringOutput.Add($"this.IssuingBank = {(this.IssuingBank == null ? "null" : this.IssuingBank)}");
            toStringOutput.Add($"this.BinCountryCode = {(this.BinCountryCode == null ? "null" : this.BinCountryCode)}");
            toStringOutput.Add($"this.Products = {(this.Products == null ? "null" : $"[{string.Join(", ", this.Products)} ]")}");
        }
    }
}