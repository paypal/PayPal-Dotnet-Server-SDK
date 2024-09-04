// <copyright file="ApplePayCardResponse.cs" company="APIMatic">
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
    /// ApplePayCardResponse.
    /// </summary>
    public class ApplePayCardResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayCardResponse"/> class.
        /// </summary>
        public ApplePayCardResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayCardResponse"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="lastDigits">last_digits.</param>
        /// <param name="brand">brand.</param>
        /// <param name="availableNetworks">available_networks.</param>
        /// <param name="type">type.</param>
        /// <param name="authenticationResult">authentication_result.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="fromRequest">from_request.</param>
        /// <param name="expiry">expiry.</param>
        /// <param name="binDetails">bin_details.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="countryCode">country_code.</param>
        public ApplePayCardResponse(
            string name = null,
            string lastDigits = null,
            Models.CardBrand? brand = null,
            List<Models.CardBrand> availableNetworks = null,
            Models.CardType? type = null,
            Models.AuthenticationResponse authenticationResult = null,
            Models.CardAttributesResponse attributes = null,
            Models.CardFromRequest fromRequest = null,
            string expiry = null,
            Models.BinDetails binDetails = null,
            Models.Address billingAddress = null,
            string countryCode = null)
        {
            this.Name = name;
            this.LastDigits = lastDigits;
            this.Brand = brand;
            this.AvailableNetworks = availableNetworks;
            this.Type = type;
            this.AuthenticationResult = authenticationResult;
            this.Attributes = attributes;
            this.FromRequest = fromRequest;
            this.Expiry = expiry;
            this.BinDetails = binDetails;
            this.BillingAddress = billingAddress;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// The card holder's name as it appears on the card.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The last digits of the payment card.
        /// </summary>
        [JsonProperty("last_digits", NullValueHandling = NullValueHandling.Ignore)]
        public string LastDigits { get; set; }

        /// <summary>
        /// The card network or brand. Applies to credit, debit, gift, and payment cards.
        /// </summary>
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardBrand? Brand { get; set; }

        /// <summary>
        /// Array of brands or networks associated with the card.
        /// </summary>
        [JsonProperty("available_networks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CardBrand> AvailableNetworks { get; set; }

        /// <summary>
        /// Type of card. i.e Credit, Debit and so on.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardType? Type { get; set; }

        /// <summary>
        /// Results of Authentication such as 3D Secure.
        /// </summary>
        [JsonProperty("authentication_result", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AuthenticationResponse AuthenticationResult { get; set; }

        /// <summary>
        /// Additional attributes associated with the use of this card.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardAttributesResponse Attributes { get; set; }

        /// <summary>
        /// Representation of card details as received in the request.
        /// </summary>
        [JsonProperty("from_request", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardFromRequest FromRequest { get; set; }

        /// <summary>
        /// The year and month, in ISO-8601 `YYYY-MM` date format. See [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty("expiry", NullValueHandling = NullValueHandling.Ignore)]
        public string Expiry { get; set; }

        /// <summary>
        /// Bank Identification Number (BIN) details used to fund a payment.
        /// </summary>
        [JsonProperty("bin_details", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BinDetails BinDetails { get; set; }

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; set; }

        /// <summary>
        /// The [two-character ISO 3166-1 code](/api/rest/reference/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote>
        /// </summary>
        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApplePayCardResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ApplePayCardResponse other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.LastDigits == null && other.LastDigits == null) || (this.LastDigits?.Equals(other.LastDigits) == true)) &&
                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.AvailableNetworks == null && other.AvailableNetworks == null) || (this.AvailableNetworks?.Equals(other.AvailableNetworks) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.AuthenticationResult == null && other.AuthenticationResult == null) || (this.AuthenticationResult?.Equals(other.AuthenticationResult) == true)) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true)) &&
                ((this.FromRequest == null && other.FromRequest == null) || (this.FromRequest?.Equals(other.FromRequest) == true)) &&
                ((this.Expiry == null && other.Expiry == null) || (this.Expiry?.Equals(other.Expiry) == true)) &&
                ((this.BinDetails == null && other.BinDetails == null) || (this.BinDetails?.Equals(other.BinDetails) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.LastDigits = {(this.LastDigits == null ? "null" : this.LastDigits)}");
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand.ToString())}");
            toStringOutput.Add($"this.AvailableNetworks = {(this.AvailableNetworks == null ? "null" : $"[{string.Join(", ", this.AvailableNetworks)} ]")}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.AuthenticationResult = {(this.AuthenticationResult == null ? "null" : this.AuthenticationResult.ToString())}");
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
            toStringOutput.Add($"this.FromRequest = {(this.FromRequest == null ? "null" : this.FromRequest.ToString())}");
            toStringOutput.Add($"this.Expiry = {(this.Expiry == null ? "null" : this.Expiry)}");
            toStringOutput.Add($"this.BinDetails = {(this.BinDetails == null ? "null" : this.BinDetails.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
        }
    }
}