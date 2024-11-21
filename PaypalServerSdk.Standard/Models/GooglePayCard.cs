// <copyright file="GooglePayCard.cs" company="APIMatic">
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
    /// GooglePayCard.
    /// </summary>
    public class GooglePayCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePayCard"/> class.
        /// </summary>
        public GooglePayCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePayCard"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="number">number.</param>
        /// <param name="expiry">expiry.</param>
        /// <param name="lastDigits">last_digits.</param>
        /// <param name="type">type.</param>
        /// <param name="brand">brand.</param>
        /// <param name="billingAddress">billing_address.</param>
        public GooglePayCard(
            string name = null,
            string number = null,
            string expiry = null,
            string lastDigits = null,
            Models.CardType? type = null,
            Models.CardBrand? brand = null,
            Models.PortablePostalAddressMediumGrained billingAddress = null)
        {
            this.Name = name;
            this.Number = number;
            this.Expiry = expiry;
            this.LastDigits = lastDigits;
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
        public Models.PortablePostalAddressMediumGrained BillingAddress { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GooglePayCard : ({string.Join(", ", toStringOutput)})";
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
            return obj is GooglePayCard other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.Expiry == null && other.Expiry == null) || (this.Expiry?.Equals(other.Expiry) == true)) &&
                ((this.LastDigits == null && other.LastDigits == null) || (this.LastDigits?.Equals(other.LastDigits) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true));
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
            toStringOutput.Add($"this.LastDigits = {(this.LastDigits == null ? "null" : this.LastDigits)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
        }
    }
}