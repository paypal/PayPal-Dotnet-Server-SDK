// <copyright file="AddressDetails.cs" company="APIMatic">
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
    /// AddressDetails.
    /// </summary>
    public class AddressDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressDetails"/> class.
        /// </summary>
        public AddressDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressDetails"/> class.
        /// </summary>
        /// <param name="countryCode">country_code.</param>
        /// <param name="addressLine1">address_line_1.</param>
        /// <param name="addressLine2">address_line_2.</param>
        /// <param name="adminArea2">admin_area_2.</param>
        /// <param name="adminArea1">admin_area_1.</param>
        /// <param name="postalCode">postal_code.</param>
        /// <param name="name">name.</param>
        /// <param name="id">id.</param>
        /// <param name="company">company.</param>
        /// <param name="phone">phone.</param>
        /// <param name="phoneNumber">phone_number.</param>
        public AddressDetails(
            string countryCode,
            string addressLine1 = null,
            string addressLine2 = null,
            string adminArea2 = null,
            string adminArea1 = null,
            string postalCode = null,
            Models.Name name = null,
            string id = null,
            string company = null,
            string phone = null,
            Models.Phone phoneNumber = null)
        {
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AdminArea2 = adminArea2;
            this.AdminArea1 = adminArea1;
            this.PostalCode = postalCode;
            this.CountryCode = countryCode;
            this.Name = name;
            this.Id = id;
            this.Company = company;
            this.Phone = phone;
            this.PhoneNumber = phoneNumber;
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

        /// <summary>
        /// The name of the party.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Name Name { get; set; }

        /// <summary>
        /// The resource ID of the address.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the company or business associated to the address.
        /// </summary>
        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; set; }

        /// <summary>
        /// The phone number that can go on the mailing label with the address to track the shipping. Phone number is in E.164 format.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Phone PhoneNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AddressDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is AddressDetails other &&                ((this.AddressLine1 == null && other.AddressLine1 == null) || (this.AddressLine1?.Equals(other.AddressLine1) == true)) &&
                ((this.AddressLine2 == null && other.AddressLine2 == null) || (this.AddressLine2?.Equals(other.AddressLine2) == true)) &&
                ((this.AdminArea2 == null && other.AdminArea2 == null) || (this.AdminArea2?.Equals(other.AdminArea2) == true)) &&
                ((this.AdminArea1 == null && other.AdminArea1 == null) || (this.AdminArea1?.Equals(other.AdminArea1) == true)) &&
                ((this.PostalCode == null && other.PostalCode == null) || (this.PostalCode?.Equals(other.PostalCode) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Company == null && other.Company == null) || (this.Company?.Equals(other.Company) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.PhoneNumber == null && other.PhoneNumber == null) || (this.PhoneNumber?.Equals(other.PhoneNumber) == true));
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
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Company = {(this.Company == null ? "null" : this.Company)}");
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone)}");
            toStringOutput.Add($"this.PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber.ToString())}");
        }
    }
}