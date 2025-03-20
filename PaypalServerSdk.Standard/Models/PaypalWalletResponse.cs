// <copyright file="PaypalWalletResponse.cs" company="APIMatic">
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
    /// PaypalWalletResponse.
    /// </summary>
    public class PaypalWalletResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalWalletResponse"/> class.
        /// </summary>
        public PaypalWalletResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalWalletResponse"/> class.
        /// </summary>
        /// <param name="emailAddress">email_address.</param>
        /// <param name="accountId">account_id.</param>
        /// <param name="accountStatus">account_status.</param>
        /// <param name="name">name.</param>
        /// <param name="phoneType">phone_type.</param>
        /// <param name="phoneNumber">phone_number.</param>
        /// <param name="birthDate">birth_date.</param>
        /// <param name="businessName">business_name.</param>
        /// <param name="taxInfo">tax_info.</param>
        /// <param name="address">address.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="storedCredential">stored_credential.</param>
        public PaypalWalletResponse(
            string emailAddress = null,
            string accountId = null,
            Models.PaypalWalletAccountVerificationStatus? accountStatus = null,
            Models.Name name = null,
            Models.PhoneType? phoneType = null,
            Models.PhoneNumber phoneNumber = null,
            string birthDate = null,
            string businessName = null,
            Models.TaxInfo taxInfo = null,
            Models.Address address = null,
            Models.PaypalWalletAttributesResponse attributes = null,
            Models.PaypalWalletStoredCredential storedCredential = null)
        {
            this.EmailAddress = emailAddress;
            this.AccountId = accountId;
            this.AccountStatus = accountStatus;
            this.Name = name;
            this.PhoneType = phoneType;
            this.PhoneNumber = phoneNumber;
            this.BirthDate = birthDate;
            this.BusinessName = businessName;
            this.TaxInfo = taxInfo;
            this.Address = address;
            this.Attributes = attributes;
            this.StoredCredential = storedCredential;
        }

        /// <summary>
        /// The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.
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
        public Models.PaypalWalletAccountVerificationStatus? AccountStatus { get; set; }

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
        /// The business name of the PayPal account holder (populated for business accounts only)
        /// </summary>
        [JsonProperty("business_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessName { get; set; }

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
        public Models.PaypalWalletAttributesResponse Attributes { get; set; }

        /// <summary>
        /// Provides additional details to process a payment using the PayPal wallet billing agreement or a vaulted payment method that has been stored or is intended to be stored.
        /// </summary>
        [JsonProperty("stored_credential", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalWalletStoredCredential StoredCredential { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaypalWalletResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaypalWalletResponse other &&
                (this.EmailAddress == null && other.EmailAddress == null ||
                 this.EmailAddress?.Equals(other.EmailAddress) == true) &&
                (this.AccountId == null && other.AccountId == null ||
                 this.AccountId?.Equals(other.AccountId) == true) &&
                (this.AccountStatus == null && other.AccountStatus == null ||
                 this.AccountStatus?.Equals(other.AccountStatus) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.PhoneType == null && other.PhoneType == null ||
                 this.PhoneType?.Equals(other.PhoneType) == true) &&
                (this.PhoneNumber == null && other.PhoneNumber == null ||
                 this.PhoneNumber?.Equals(other.PhoneNumber) == true) &&
                (this.BirthDate == null && other.BirthDate == null ||
                 this.BirthDate?.Equals(other.BirthDate) == true) &&
                (this.BusinessName == null && other.BusinessName == null ||
                 this.BusinessName?.Equals(other.BusinessName) == true) &&
                (this.TaxInfo == null && other.TaxInfo == null ||
                 this.TaxInfo?.Equals(other.TaxInfo) == true) &&
                (this.Address == null && other.Address == null ||
                 this.Address?.Equals(other.Address) == true) &&
                (this.Attributes == null && other.Attributes == null ||
                 this.Attributes?.Equals(other.Attributes) == true) &&
                (this.StoredCredential == null && other.StoredCredential == null ||
                 this.StoredCredential?.Equals(other.StoredCredential) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"EmailAddress = {this.EmailAddress ?? "null"}");
            toStringOutput.Add($"AccountId = {this.AccountId ?? "null"}");
            toStringOutput.Add($"AccountStatus = {(this.AccountStatus == null ? "null" : this.AccountStatus.ToString())}");
            toStringOutput.Add($"Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"PhoneType = {(this.PhoneType == null ? "null" : this.PhoneType.ToString())}");
            toStringOutput.Add($"PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber.ToString())}");
            toStringOutput.Add($"BirthDate = {this.BirthDate ?? "null"}");
            toStringOutput.Add($"BusinessName = {this.BusinessName ?? "null"}");
            toStringOutput.Add($"TaxInfo = {(this.TaxInfo == null ? "null" : this.TaxInfo.ToString())}");
            toStringOutput.Add($"Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
            toStringOutput.Add($"StoredCredential = {(this.StoredCredential == null ? "null" : this.StoredCredential.ToString())}");
        }
    }
}