// <copyright file="SetupTokenRequestCard.cs" company="APIMatic">
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
using PaypalServerSDK.Standard;
using PaypalServerSDK.Standard.Utilities;

namespace PaypalServerSDK.Standard.Models
{
    /// <summary>
    /// SetupTokenRequestCard.
    /// </summary>
    public class SetupTokenRequestCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetupTokenRequestCard"/> class.
        /// </summary>
        public SetupTokenRequestCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetupTokenRequestCard"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="number">number.</param>
        /// <param name="expiry">expiry.</param>
        /// <param name="securityCode">security_code.</param>
        /// <param name="brand">brand.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="verificationMethod">verification_method.</param>
        /// <param name="experienceContext">experience_context.</param>
        /// <param name="networkTransactionReference">network_transaction_reference.</param>
        public SetupTokenRequestCard(
            string name = null,
            string number = null,
            string expiry = null,
            string securityCode = null,
            Models.CardBrand? brand = null,
            Models.Address billingAddress = null,
            string verificationMethod = null,
            Models.SetupTokenCardExperienceContext experienceContext = null,
            JsonValue networkTransactionReference = null)
        {
            this.Name = name;
            this.Number = number;
            this.Expiry = expiry;
            this.SecurityCode = securityCode;
            this.Brand = brand;
            this.BillingAddress = billingAddress;
            this.VerificationMethod = verificationMethod;
            this.ExperienceContext = experienceContext;
            this.NetworkTransactionReference = networkTransactionReference;
        }

        /// <summary>
        /// The card holder's name as it appears on the card.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The primary account number (PAN) for the payment card.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// The year and month, in ISO-8601 `YYYY-MM` date format. See [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty("expiry", NullValueHandling = NullValueHandling.Ignore)]
        public string Expiry { get; set; }

        /// <summary>
        /// The three- or four-digit security code of the card. Also known as the CVV, CVC, CVN, CVE, or CID. This parameter cannot be present in the request when `payment_initiator=MERCHANT`.
        /// </summary>
        [JsonProperty("security_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// The card network or brand. Applies to credit, debit, gift, and payment cards.
        /// </summary>
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardBrand? Brand { get; set; }

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; set; }

        /// <summary>
        /// The verification method of the card.
        /// </summary>
        [JsonProperty("verification_method", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationMethod { get; set; }

        /// <summary>
        /// Customizes the Vault creation flow experience for your customers.
        /// </summary>
        [JsonProperty("experience_context", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SetupTokenCardExperienceContext ExperienceContext { get; set; }

        /// <summary>
        /// Gets or sets NetworkTransactionReference.
        /// </summary>
        [JsonProperty("network_transaction_reference", NullValueHandling = NullValueHandling.Ignore)]
        public JsonValue NetworkTransactionReference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SetupTokenRequestCard : ({string.Join(", ", toStringOutput)})";
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
            return obj is SetupTokenRequestCard other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.Expiry == null && other.Expiry == null) || (this.Expiry?.Equals(other.Expiry) == true)) &&
                ((this.SecurityCode == null && other.SecurityCode == null) || (this.SecurityCode?.Equals(other.SecurityCode) == true)) &&
                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.VerificationMethod == null && other.VerificationMethod == null) || (this.VerificationMethod?.Equals(other.VerificationMethod) == true)) &&
                ((this.ExperienceContext == null && other.ExperienceContext == null) || (this.ExperienceContext?.Equals(other.ExperienceContext) == true)) &&
                ((this.NetworkTransactionReference == null && other.NetworkTransactionReference == null) || (this.NetworkTransactionReference?.Equals(other.NetworkTransactionReference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number)}");
            toStringOutput.Add($"this.Expiry = {(this.Expiry == null ? "null" : this.Expiry)}");
            toStringOutput.Add($"this.SecurityCode = {(this.SecurityCode == null ? "null" : this.SecurityCode)}");
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.VerificationMethod = {(this.VerificationMethod == null ? "null" : this.VerificationMethod)}");
            toStringOutput.Add($"this.ExperienceContext = {(this.ExperienceContext == null ? "null" : this.ExperienceContext.ToString())}");
            toStringOutput.Add($"NetworkTransactionReference = {(this.NetworkTransactionReference == null ? "null" : this.NetworkTransactionReference.ToString())}");
        }
    }
}