// <copyright file="GooglePayRequest.cs" company="APIMatic">
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
    /// GooglePayRequest.
    /// </summary>
    public class GooglePayRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePayRequest"/> class.
        /// </summary>
        public GooglePayRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePayRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="emailAddress">email_address.</param>
        /// <param name="phoneNumber">phone_number.</param>
        /// <param name="card">card.</param>
        /// <param name="decryptedToken">decrypted_token.</param>
        /// <param name="assuranceDetails">assurance_details.</param>
        /// <param name="attributes">attributes.</param>
        public GooglePayRequest(
            string name = null,
            string emailAddress = null,
            Models.PhoneNumberWithCountryCode phoneNumber = null,
            Models.GooglePayRequestCard card = null,
            Models.GooglePayDecryptedTokenData decryptedToken = null,
            Models.AssuranceDetails assuranceDetails = null,
            Models.GooglePayCardAttributes attributes = null)
        {
            this.Name = name;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = phoneNumber;
            this.Card = card;
            this.DecryptedToken = decryptedToken;
            this.AssuranceDetails = assuranceDetails;
            this.Attributes = attributes;
        }

        /// <summary>
        /// The full name representation like Mr J Smith.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [JsonProperty("email_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The phone number in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PhoneNumberWithCountryCode PhoneNumber { get; set; }

        /// <summary>
        /// The payment card used to fund a Google Pay payment. Can be a credit or debit card.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GooglePayRequestCard Card { get; set; }

        /// <summary>
        /// Details shared by Google for the merchant to be shared with PayPal. This is required to process the transaction using the Google Pay payment method.
        /// </summary>
        [JsonProperty("decrypted_token", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GooglePayDecryptedTokenData DecryptedToken { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Information about cardholder possession validation and cardholder identification and verifications (ID&V).
        /// ]]>
        /// </summary>
        [JsonProperty("assurance_details", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AssuranceDetails AssuranceDetails { get; set; }

        /// <summary>
        /// Additional attributes associated with the use of this card.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GooglePayCardAttributes Attributes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GooglePayRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is GooglePayRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.EmailAddress == null && other.EmailAddress == null) || (this.EmailAddress?.Equals(other.EmailAddress) == true)) &&
                ((this.PhoneNumber == null && other.PhoneNumber == null) || (this.PhoneNumber?.Equals(other.PhoneNumber) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.DecryptedToken == null && other.DecryptedToken == null) || (this.DecryptedToken?.Equals(other.DecryptedToken) == true)) &&
                ((this.AssuranceDetails == null && other.AssuranceDetails == null) || (this.AssuranceDetails?.Equals(other.AssuranceDetails) == true)) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.EmailAddress = {(this.EmailAddress == null ? "null" : this.EmailAddress)}");
            toStringOutput.Add($"this.PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber.ToString())}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.DecryptedToken = {(this.DecryptedToken == null ? "null" : this.DecryptedToken.ToString())}");
            toStringOutput.Add($"this.AssuranceDetails = {(this.AssuranceDetails == null ? "null" : this.AssuranceDetails.ToString())}");
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
        }
    }
}