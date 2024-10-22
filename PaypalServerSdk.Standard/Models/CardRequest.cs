// <copyright file="CardRequest.cs" company="APIMatic">
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
    /// CardRequest.
    /// </summary>
    public class CardRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardRequest"/> class.
        /// </summary>
        public CardRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="number">number.</param>
        /// <param name="expiry">expiry.</param>
        /// <param name="securityCode">security_code.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="vaultId">vault_id.</param>
        /// <param name="singleUseToken">single_use_token.</param>
        /// <param name="storedCredential">stored_credential.</param>
        /// <param name="networkToken">network_token.</param>
        /// <param name="experienceContext">experience_context.</param>
        public CardRequest(
            string name = null,
            string number = null,
            string expiry = null,
            string securityCode = null,
            Models.Address billingAddress = null,
            Models.CardAttributes attributes = null,
            string vaultId = null,
            string singleUseToken = null,
            Models.CardStoredCredential storedCredential = null,
            Models.NetworkToken networkToken = null,
            Models.CardExperienceContext experienceContext = null)
        {
            this.Name = name;
            this.Number = number;
            this.Expiry = expiry;
            this.SecurityCode = securityCode;
            this.BillingAddress = billingAddress;
            this.Attributes = attributes;
            this.VaultId = vaultId;
            this.SingleUseToken = singleUseToken;
            this.StoredCredential = storedCredential;
            this.NetworkToken = networkToken;
            this.ExperienceContext = experienceContext;
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
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; set; }

        /// <summary>
        /// Additional attributes associated with the use of this card.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardAttributes Attributes { get; set; }

        /// <summary>
        /// The PayPal-generated ID for the vaulted payment source. This ID should be stored on the merchant's server so the saved payment source can be used for future transactions.
        /// </summary>
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }

        /// <summary>
        /// The PayPal-generated, short-lived, one-time-use token, used to communicate payment information to PayPal for transaction processing.
        /// </summary>
        [JsonProperty("single_use_token", NullValueHandling = NullValueHandling.Ignore)]
        public string SingleUseToken { get; set; }

        /// <summary>
        /// Provides additional details to process a payment using a `card` that has been stored or is intended to be stored (also referred to as stored_credential or card-on-file).<br/>Parameter compatibility:<br/><ul><li>`payment_type=ONE_TIME` is compatible only with `payment_initiator=CUSTOMER`.</li><li>`usage=FIRST` is compatible only with `payment_initiator=CUSTOMER`.</li><li>`previous_transaction_reference` or `previous_network_transaction_reference` is compatible only with `payment_initiator=MERCHANT`.</li><li>Only one of the parameters - `previous_transaction_reference` and `previous_network_transaction_reference` - can be present in the request.</li></ul>
        /// </summary>
        [JsonProperty("stored_credential", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardStoredCredential StoredCredential { get; set; }

        /// <summary>
        /// The Third Party Network token used to fund a payment.
        /// </summary>
        [JsonProperty("network_token", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NetworkToken NetworkToken { get; set; }

        /// <summary>
        /// Customizes the payer experience during the 3DS Approval for payment.
        /// </summary>
        [JsonProperty("experience_context", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardExperienceContext ExperienceContext { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.Expiry == null && other.Expiry == null) || (this.Expiry?.Equals(other.Expiry) == true)) &&
                ((this.SecurityCode == null && other.SecurityCode == null) || (this.SecurityCode?.Equals(other.SecurityCode) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true)) &&
                ((this.VaultId == null && other.VaultId == null) || (this.VaultId?.Equals(other.VaultId) == true)) &&
                ((this.SingleUseToken == null && other.SingleUseToken == null) || (this.SingleUseToken?.Equals(other.SingleUseToken) == true)) &&
                ((this.StoredCredential == null && other.StoredCredential == null) || (this.StoredCredential?.Equals(other.StoredCredential) == true)) &&
                ((this.NetworkToken == null && other.NetworkToken == null) || (this.NetworkToken?.Equals(other.NetworkToken) == true)) &&
                ((this.ExperienceContext == null && other.ExperienceContext == null) || (this.ExperienceContext?.Equals(other.ExperienceContext) == true));
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
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
            toStringOutput.Add($"this.VaultId = {(this.VaultId == null ? "null" : this.VaultId)}");
            toStringOutput.Add($"this.SingleUseToken = {(this.SingleUseToken == null ? "null" : this.SingleUseToken)}");
            toStringOutput.Add($"this.StoredCredential = {(this.StoredCredential == null ? "null" : this.StoredCredential.ToString())}");
            toStringOutput.Add($"this.NetworkToken = {(this.NetworkToken == null ? "null" : this.NetworkToken.ToString())}");
            toStringOutput.Add($"this.ExperienceContext = {(this.ExperienceContext == null ? "null" : this.ExperienceContext.ToString())}");
        }
    }
}