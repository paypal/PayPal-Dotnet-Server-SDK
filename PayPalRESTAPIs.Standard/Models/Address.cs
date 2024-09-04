// <copyright file="Address.cs" company="APIMatic">
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
    /// Address.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="countryCode">country_code.</param>
        /// <param name="addressLine1">address_line_1.</param>
        /// <param name="addressLine2">address_line_2.</param>
        /// <param name="adminArea2">admin_area_2.</param>
        /// <param name="adminArea1">admin_area_1.</param>
        /// <param name="postalCode">postal_code.</param>
        public Address(
            string countryCode,
            string addressLine1 = null,
            string addressLine2 = null,
            string adminArea2 = null,
            string adminArea1 = null,
            string postalCode = null)
        {
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AdminArea2 = adminArea2;
            this.AdminArea1 = adminArea1;
            this.PostalCode = postalCode;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// The first line of the address, such as number and street, for example, `173 Drury Lane`. Needed for data entry, and Compliance and Risk checks. This field needs to pass the full address.
        /// </summary>
        [JsonProperty("address_line_1", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The second line of the address, for example, a suite or apartment number.
        /// </summary>
        [JsonProperty("address_line_2", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// A city, town, or village. Smaller than `admin_area_level_1`.
        /// </summary>
        [JsonProperty("admin_area_2", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminArea2 { get; set; }

        /// <summary>
        /// The highest-level sub-division in a country, which is usually a province, state, or ISO-3166-2 subdivision. This data is formatted for postal delivery, for example, `CA` and not `California`. Value, by country, is:<ul><li>UK. A county.</li><li>US. A state.</li><li>Canada. A province.</li><li>Japan. A prefecture.</li><li>Switzerland. A *kanton*.</li></ul>
        /// </summary>
        [JsonProperty("admin_area_1", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminArea1 { get; set; }

        /// <summary>
        /// The postal code, which is the ZIP code or equivalent. Typically required for countries with a postal code or an equivalent. See [postal code](https://en.wikipedia.org/wiki/Postal_code).
        /// </summary>
        [JsonProperty("postal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The [2-character ISO 3166-1 code](/api/rest/reference/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote>
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Address : ({string.Join(", ", toStringOutput)})";
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
            return obj is Address other &&                ((this.AddressLine1 == null && other.AddressLine1 == null) || (this.AddressLine1?.Equals(other.AddressLine1) == true)) &&
                ((this.AddressLine2 == null && other.AddressLine2 == null) || (this.AddressLine2?.Equals(other.AddressLine2) == true)) &&
                ((this.AdminArea2 == null && other.AdminArea2 == null) || (this.AdminArea2?.Equals(other.AdminArea2) == true)) &&
                ((this.AdminArea1 == null && other.AdminArea1 == null) || (this.AdminArea1?.Equals(other.AdminArea1) == true)) &&
                ((this.PostalCode == null && other.PostalCode == null) || (this.PostalCode?.Equals(other.PostalCode) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AddressLine1 = {(this.AddressLine1 == null ? "null" : this.AddressLine1)}");
            toStringOutput.Add($"this.AddressLine2 = {(this.AddressLine2 == null ? "null" : this.AddressLine2)}");
            toStringOutput.Add($"this.AdminArea2 = {(this.AdminArea2 == null ? "null" : this.AdminArea2)}");
            toStringOutput.Add($"this.AdminArea1 = {(this.AdminArea1 == null ? "null" : this.AdminArea1)}");
            toStringOutput.Add($"this.PostalCode = {(this.PostalCode == null ? "null" : this.PostalCode)}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
        }
    }
}