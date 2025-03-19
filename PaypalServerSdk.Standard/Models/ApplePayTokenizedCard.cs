// <copyright file="ApplePayTokenizedCard.cs" company="APIMatic">
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
    /// ApplePayTokenizedCard.
    /// </summary>
    public class ApplePayTokenizedCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayTokenizedCard"/> class.
        /// </summary>
        public ApplePayTokenizedCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayTokenizedCard"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="number">number.</param>
        /// <param name="expiry">expiry.</param>
        /// <param name="cardType">card_type.</param>
        /// <param name="type">type.</param>
        /// <param name="brand">brand.</param>
        /// <param name="billingAddress">billing_address.</param>
        public ApplePayTokenizedCard(
            string name = null,
            string number = null,
            string expiry = null,
            Models.CardBrand? cardType = null,
            Models.CardType? type = null,
            Models.CardBrand? brand = null,
            Models.Address billingAddress = null)
        {
            this.Name = name;
            this.Number = number;
            this.Expiry = expiry;
            this.CardType = cardType;
            this.Type = type;
            this.Brand = brand;
            this.BillingAddress = billingAddress;
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
        /// The card network or brand. Applies to credit, debit, gift, and payment cards.
        /// </summary>
        [JsonProperty("card_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardBrand? CardType { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ApplePayTokenizedCard : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ApplePayTokenizedCard other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Number == null && other.Number == null ||
                 this.Number?.Equals(other.Number) == true) &&
                (this.Expiry == null && other.Expiry == null ||
                 this.Expiry?.Equals(other.Expiry) == true) &&
                (this.CardType == null && other.CardType == null ||
                 this.CardType?.Equals(other.CardType) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Brand == null && other.Brand == null ||
                 this.Brand?.Equals(other.Brand) == true) &&
                (this.BillingAddress == null && other.BillingAddress == null ||
                 this.BillingAddress?.Equals(other.BillingAddress) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Number = {this.Number ?? "null"}");
            toStringOutput.Add($"Expiry = {this.Expiry ?? "null"}");
            toStringOutput.Add($"CardType = {(this.CardType == null ? "null" : this.CardType.ToString())}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"Brand = {(this.Brand == null ? "null" : this.Brand.ToString())}");
            toStringOutput.Add($"BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
        }
    }
}