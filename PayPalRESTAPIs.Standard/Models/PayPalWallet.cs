// <copyright file="PayPalWallet.cs" company="APIMatic">
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
    /// PayPalWallet.
    /// </summary>
    public class PayPalWallet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalWallet"/> class.
        /// </summary>
        public PayPalWallet()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalWallet"/> class.
        /// </summary>
        /// <param name="vaultId">vault_id.</param>
        /// <param name="emailAddress">email_address.</param>
        /// <param name="name">name.</param>
        /// <param name="phone">phone.</param>
        /// <param name="birthDate">birth_date.</param>
        /// <param name="taxInfo">tax_info.</param>
        /// <param name="address">address.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="experienceContext">experience_context.</param>
        /// <param name="billingAgreementId">billing_agreement_id.</param>
        public PayPalWallet(
            string vaultId = null,
            string emailAddress = null,
            Models.Name name = null,
            Models.PhoneWithType phone = null,
            string birthDate = null,
            Models.TaxInfo taxInfo = null,
            Models.Address address = null,
            Models.PayPalWalletAttributes attributes = null,
            Models.PayPalWalletExperienceContext experienceContext = null,
            string billingAgreementId = null)
        {
            this.VaultId = vaultId;
            this.EmailAddress = emailAddress;
            this.Name = name;
            this.Phone = phone;
            this.BirthDate = birthDate;
            this.TaxInfo = taxInfo;
            this.Address = address;
            this.Attributes = attributes;
            this.ExperienceContext = experienceContext;
            this.BillingAgreementId = billingAgreementId;
        }

        /// <summary>
        /// The PayPal-generated ID for the vaulted payment source. This ID should be stored on the merchant's server so the saved payment source can be used for future transactions.
        /// </summary>
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [JsonProperty("email_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

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

        /// <summary>
        /// Additional attributes associated with the use of this PayPal Wallet.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayPalWalletAttributes Attributes { get; set; }

        /// <summary>
        /// Customizes the payer experience during the approval process for payment with PayPal.<blockquote><strong>Note:</strong> Partners and Marketplaces might configure <code>brand_name</code> and <code>shipping_preference</code> during partner account setup, which overrides the request values.</blockquote>
        /// </summary>
        [JsonProperty("experience_context", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayPalWalletExperienceContext ExperienceContext { get; set; }

        /// <summary>
        /// The PayPal billing agreement ID. References an approved recurring payment for goods or services.
        /// </summary>
        [JsonProperty("billing_agreement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAgreementId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PayPalWallet : ({string.Join(", ", toStringOutput)})";
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
            return obj is PayPalWallet other &&                ((this.VaultId == null && other.VaultId == null) || (this.VaultId?.Equals(other.VaultId) == true)) &&
                ((this.EmailAddress == null && other.EmailAddress == null) || (this.EmailAddress?.Equals(other.EmailAddress) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.BirthDate == null && other.BirthDate == null) || (this.BirthDate?.Equals(other.BirthDate) == true)) &&
                ((this.TaxInfo == null && other.TaxInfo == null) || (this.TaxInfo?.Equals(other.TaxInfo) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true)) &&
                ((this.ExperienceContext == null && other.ExperienceContext == null) || (this.ExperienceContext?.Equals(other.ExperienceContext) == true)) &&
                ((this.BillingAgreementId == null && other.BillingAgreementId == null) || (this.BillingAgreementId?.Equals(other.BillingAgreementId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.VaultId = {(this.VaultId == null ? "null" : this.VaultId)}");
            toStringOutput.Add($"this.EmailAddress = {(this.EmailAddress == null ? "null" : this.EmailAddress)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone.ToString())}");
            toStringOutput.Add($"this.BirthDate = {(this.BirthDate == null ? "null" : this.BirthDate)}");
            toStringOutput.Add($"this.TaxInfo = {(this.TaxInfo == null ? "null" : this.TaxInfo.ToString())}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
            toStringOutput.Add($"this.ExperienceContext = {(this.ExperienceContext == null ? "null" : this.ExperienceContext.ToString())}");
            toStringOutput.Add($"this.BillingAgreementId = {(this.BillingAgreementId == null ? "null" : this.BillingAgreementId)}");
        }
    }
}