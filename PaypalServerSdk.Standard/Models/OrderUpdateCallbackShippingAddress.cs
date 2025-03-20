// <copyright file="OrderUpdateCallbackShippingAddress.cs" company="APIMatic">
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
    /// OrderUpdateCallbackShippingAddress.
    /// </summary>
    public class OrderUpdateCallbackShippingAddress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateCallbackShippingAddress"/> class.
        /// </summary>
        public OrderUpdateCallbackShippingAddress()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateCallbackShippingAddress"/> class.
        /// </summary>
        /// <param name="countryCode">country_code.</param>
        /// <param name="adminArea2">admin_area_2.</param>
        /// <param name="adminArea1">admin_area_1.</param>
        /// <param name="postalCode">postal_code.</param>
        public OrderUpdateCallbackShippingAddress(
            string countryCode,
            string adminArea2 = null,
            string adminArea1 = null,
            string postalCode = null)
        {
            this.AdminArea2 = adminArea2;
            this.AdminArea1 = adminArea1;
            this.PostalCode = postalCode;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// A city, town, or village. Smaller than `admin_area_level_1`.
        /// </summary>
        [JsonProperty("admin_area_2", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminArea2 { get; set; }

        /// <summary>
        /// The highest-level sub-division in a country, which is usually a province, state, or ISO-3166-2 subdivision. This data is formatted for postal delivery, for example, `CA` and not `California`. Value, by country, is: UK. A county. US. A state. Canada. A province. Japan. A prefecture. Switzerland. A *kanton*.
        /// </summary>
        [JsonProperty("admin_area_1", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminArea1 { get; set; }

        /// <summary>
        /// The postal code, which is the ZIP code or equivalent. Typically required for countries with a postal code or an equivalent. See [postal code](https://en.wikipedia.org/wiki/Postal_code).
        /// </summary>
        [JsonProperty("postal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The [2-character ISO 3166-1 code](/api/rest/reference/country-codes/) that identifies the country or region. Note: The country code for Great Britain is GB and not UK as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderUpdateCallbackShippingAddress : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderUpdateCallbackShippingAddress other &&
                (this.AdminArea2 == null && other.AdminArea2 == null ||
                 this.AdminArea2?.Equals(other.AdminArea2) == true) &&
                (this.AdminArea1 == null && other.AdminArea1 == null ||
                 this.AdminArea1?.Equals(other.AdminArea1) == true) &&
                (this.PostalCode == null && other.PostalCode == null ||
                 this.PostalCode?.Equals(other.PostalCode) == true) &&
                (this.CountryCode == null && other.CountryCode == null ||
                 this.CountryCode?.Equals(other.CountryCode) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdminArea2 = {this.AdminArea2 ?? "null"}");
            toStringOutput.Add($"AdminArea1 = {this.AdminArea1 ?? "null"}");
            toStringOutput.Add($"PostalCode = {this.PostalCode ?? "null"}");
            toStringOutput.Add($"CountryCode = {this.CountryCode ?? "null"}");
        }
    }
}