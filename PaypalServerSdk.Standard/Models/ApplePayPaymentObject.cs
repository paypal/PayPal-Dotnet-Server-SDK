// <copyright file="ApplePayPaymentObject.cs" company="APIMatic">
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
    /// ApplePayPaymentObject.
    /// </summary>
    public class ApplePayPaymentObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayPaymentObject"/> class.
        /// </summary>
        public ApplePayPaymentObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayPaymentObject"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="token">token.</param>
        /// <param name="name">name.</param>
        /// <param name="emailAddress">email_address.</param>
        /// <param name="phoneNumber">phone_number.</param>
        /// <param name="card">card.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="storedCredential">stored_credential.</param>
        public ApplePayPaymentObject(
            string id = null,
            string token = null,
            string name = null,
            string emailAddress = null,
            Models.PhoneNumber phoneNumber = null,
            Models.ApplePayCardResponse card = null,
            Models.ApplePayAttributesResponse attributes = null,
            Models.CardStoredCredential storedCredential = null)
        {
            this.Id = id;
            this.Token = token;
            this.Name = name;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = phoneNumber;
            this.Card = card;
            this.Attributes = attributes;
            this.StoredCredential = storedCredential;
        }

        /// <summary>
        /// ApplePay transaction identifier, this will be the unique identifier for this transaction provided by Apple. The pattern is defined by an external party and supports Unicode.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Encrypted ApplePay token, containing card information. This token would be base64encoded. The pattern is defined by an external party and supports Unicode.
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// The full name representation like Mr J Smith.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.
        /// </summary>
        [JsonProperty("email_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The phone number in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PhoneNumber PhoneNumber { get; set; }

        /// <summary>
        /// The Card from Apple Pay Wallet used to fund the payment.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplePayCardResponse Card { get; set; }

        /// <summary>
        /// Additional attributes associated with the use of Apple Pay.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplePayAttributesResponse Attributes { get; set; }

        /// <summary>
        /// Provides additional details to process a payment using a `card` that has been stored or is intended to be stored (also referred to as stored_credential or card-on-file). Parameter compatibility: `payment_type=ONE_TIME` is compatible only with `payment_initiator=CUSTOMER`. `usage=FIRST` is compatible only with `payment_initiator=CUSTOMER`. `previous_transaction_reference` or `previous_network_transaction_reference` is compatible only with `payment_initiator=MERCHANT`. Only one of the parameters - `previous_transaction_reference` and `previous_network_transaction_reference` - can be present in the request.
        /// </summary>
        [JsonProperty("stored_credential", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardStoredCredential StoredCredential { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ApplePayPaymentObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ApplePayPaymentObject other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.EmailAddress == null && other.EmailAddress == null ||
                 this.EmailAddress?.Equals(other.EmailAddress) == true) &&
                (this.PhoneNumber == null && other.PhoneNumber == null ||
                 this.PhoneNumber?.Equals(other.PhoneNumber) == true) &&
                (this.Card == null && other.Card == null ||
                 this.Card?.Equals(other.Card) == true) &&
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
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"EmailAddress = {this.EmailAddress ?? "null"}");
            toStringOutput.Add($"PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber.ToString())}");
            toStringOutput.Add($"Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
            toStringOutput.Add($"StoredCredential = {(this.StoredCredential == null ? "null" : this.StoredCredential.ToString())}");
        }
    }
}