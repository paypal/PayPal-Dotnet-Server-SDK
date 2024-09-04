// <copyright file="Payer.cs" company="APIMatic">
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
    /// Payer.
    /// </summary>
    public class Payer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payer"/> class.
        /// </summary>
        public Payer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Payer"/> class.
        /// </summary>
        /// <param name="emailAddress">email_address.</param>
        /// <param name="payerId">payer_id.</param>
        /// <param name="name">name.</param>
        /// <param name="phone">phone.</param>
        /// <param name="birthDate">birth_date.</param>
        /// <param name="taxInfo">tax_info.</param>
        /// <param name="address">address.</param>
        public Payer(
            string emailAddress = null,
            string payerId = null,
            Models.Name name = null,
            Models.PhoneWithType phone = null,
            string birthDate = null,
            Models.TaxInfo taxInfo = null,
            Models.Address address = null)
        {
            this.EmailAddress = emailAddress;
            this.PayerId = payerId;
            this.Name = name;
            this.Phone = phone;
            this.BirthDate = birthDate;
            this.TaxInfo = taxInfo;
            this.Address = address;
        }

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [JsonProperty("email_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The account identifier for a PayPal account.
        /// </summary>
        [JsonProperty("payer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerId { get; set; }

        /// <summary>
        /// The name of the party.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Name Name { get; set; }

        /// <summary>
        /// The phone information.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PhoneWithType Phone { get; set; }

        /// <summary>
        /// The stand-alone date, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). To represent special legal values, such as a date of birth, you should use dates with no associated time or time-zone data. Whenever possible, use the standard `date_time` type. This regular expression does not validate all dates. For example, February 31 is valid and nothing is known about leap years.
        /// </summary>
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthDate { get; set; }

        /// <summary>
        /// The tax ID of the customer. The customer is also known as the payer. Both `tax_id` and `tax_id_type` are required.
        /// </summary>
        [JsonProperty("tax_info", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TaxInfo TaxInfo { get; set; }

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address Address { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Payer : ({string.Join(", ", toStringOutput)})";
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
            return obj is Payer other &&                ((this.EmailAddress == null && other.EmailAddress == null) || (this.EmailAddress?.Equals(other.EmailAddress) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.BirthDate == null && other.BirthDate == null) || (this.BirthDate?.Equals(other.BirthDate) == true)) &&
                ((this.TaxInfo == null && other.TaxInfo == null) || (this.TaxInfo?.Equals(other.TaxInfo) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EmailAddress = {(this.EmailAddress == null ? "null" : this.EmailAddress)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone.ToString())}");
            toStringOutput.Add($"this.BirthDate = {(this.BirthDate == null ? "null" : this.BirthDate)}");
            toStringOutput.Add($"this.TaxInfo = {(this.TaxInfo == null ? "null" : this.TaxInfo.ToString())}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
        }
    }
}