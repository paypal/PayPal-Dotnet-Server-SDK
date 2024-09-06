// <copyright file="PayPalWalletResponse.cs" company="APIMatic">
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
    /// PayPalWalletResponse.
    /// </summary>
    public class PayPalWalletResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalWalletResponse"/> class.
        /// </summary>
        public PayPalWalletResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalWalletResponse"/> class.
        /// </summary>
        /// <param name="emailAddress">email_address.</param>
        /// <param name="accountId">account_id.</param>
        /// <param name="accountStatus">account_status.</param>
        /// <param name="name">name.</param>
        /// <param name="phoneType">phone_type.</param>
        /// <param name="phoneNumber">phone_number.</param>
        /// <param name="birthDate">birth_date.</param>
        /// <param name="taxInfo">tax_info.</param>
        /// <param name="address">address.</param>
        /// <param name="attributes">attributes.</param>
        public PayPalWalletResponse(
            string emailAddress = null,
            string accountId = null,
            Models.PayPalWalletAccountVerificationStatus? accountStatus = null,
            Models.Name name = null,
            Models.PhoneType? phoneType = null,
            Models.PhoneNumber phoneNumber = null,
            string birthDate = null,
            Models.TaxInfo taxInfo = null,
            Models.Address address = null,
            Models.PayPalWalletAttributesResponse attributes = null)
        {
            this.EmailAddress = emailAddress;
            this.AccountId = accountId;
            this.AccountStatus = accountStatus;
            this.Name = name;
            this.PhoneType = phoneType;
            this.PhoneNumber = phoneNumber;
            this.BirthDate = birthDate;
            this.TaxInfo = taxInfo;
            this.Address = address;
            this.Attributes = attributes;
        }

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [JsonProperty("email_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The PayPal payer ID, which is a masked version of the PayPal account number intended for use with third parties. The account number is reversibly encrypted and a proprietary variant of Base32 is used to encode the result.
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// The account status indicates whether the buyer has verified the financial details associated with their PayPal account.
        /// </summary>
        [JsonProperty("account_status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayPalWalletAccountVerificationStatus? AccountStatus { get; set; }

        /// <summary>
        /// The name of the party.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Name Name { get; set; }

        /// <summary>
        /// The phone type.
        /// </summary>
        [JsonProperty("phone_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PhoneType? PhoneType { get; set; }

        /// <summary>
        /// The phone number in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PhoneNumber PhoneNumber { get; set; }

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

        /// <summary>
        /// Additional attributes associated with the use of a PayPal Wallet.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayPalWalletAttributesResponse Attributes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PayPalWalletResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is PayPalWalletResponse other &&                ((this.EmailAddress == null && other.EmailAddress == null) || (this.EmailAddress?.Equals(other.EmailAddress) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountStatus == null && other.AccountStatus == null) || (this.AccountStatus?.Equals(other.AccountStatus) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.PhoneType == null && other.PhoneType == null) || (this.PhoneType?.Equals(other.PhoneType) == true)) &&
                ((this.PhoneNumber == null && other.PhoneNumber == null) || (this.PhoneNumber?.Equals(other.PhoneNumber) == true)) &&
                ((this.BirthDate == null && other.BirthDate == null) || (this.BirthDate?.Equals(other.BirthDate) == true)) &&
                ((this.TaxInfo == null && other.TaxInfo == null) || (this.TaxInfo?.Equals(other.TaxInfo) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EmailAddress = {(this.EmailAddress == null ? "null" : this.EmailAddress)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId)}");
            toStringOutput.Add($"this.AccountStatus = {(this.AccountStatus == null ? "null" : this.AccountStatus.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"this.PhoneType = {(this.PhoneType == null ? "null" : this.PhoneType.ToString())}");
            toStringOutput.Add($"this.PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber.ToString())}");
            toStringOutput.Add($"this.BirthDate = {(this.BirthDate == null ? "null" : this.BirthDate)}");
            toStringOutput.Add($"this.TaxInfo = {(this.TaxInfo == null ? "null" : this.TaxInfo.ToString())}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
        }
    }
}