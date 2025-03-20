// <copyright file="GooglePayCardResponse.cs" company="APIMatic">
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
    /// GooglePayCardResponse.
    /// </summary>
    public class GooglePayCardResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePayCardResponse"/> class.
        /// </summary>
        public GooglePayCardResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePayCardResponse"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="lastDigits">last_digits.</param>
        /// <param name="type">type.</param>
        /// <param name="brand">brand.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="authenticationResult">authentication_result.</param>
        public GooglePayCardResponse(
            string name = null,
            string lastDigits = null,
            Models.CardType? type = null,
            Models.CardBrand? brand = null,
            Models.Address billingAddress = null,
            Models.AuthenticationResponse authenticationResult = null)
        {
            this.Name = name;
            this.LastDigits = lastDigits;
            this.Type = type;
            this.Brand = brand;
            this.BillingAddress = billingAddress;
            this.AuthenticationResult = authenticationResult;
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
        /// Type of card. i.e Credit, Debit and so on.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardType? Type { get; set; }

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
        /// Results of Authentication such as 3D Secure.
        /// </summary>
        [JsonProperty("authentication_result", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AuthenticationResponse AuthenticationResult { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GooglePayCardResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GooglePayCardResponse other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.LastDigits == null && other.LastDigits == null ||
                 this.LastDigits?.Equals(other.LastDigits) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Brand == null && other.Brand == null ||
                 this.Brand?.Equals(other.Brand) == true) &&
                (this.BillingAddress == null && other.BillingAddress == null ||
                 this.BillingAddress?.Equals(other.BillingAddress) == true) &&
                (this.AuthenticationResult == null && other.AuthenticationResult == null ||
                 this.AuthenticationResult?.Equals(other.AuthenticationResult) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"LastDigits = {this.LastDigits ?? "null"}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"Brand = {(this.Brand == null ? "null" : this.Brand.ToString())}");
            toStringOutput.Add($"BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"AuthenticationResult = {(this.AuthenticationResult == null ? "null" : this.AuthenticationResult.ToString())}");
        }
    }
}