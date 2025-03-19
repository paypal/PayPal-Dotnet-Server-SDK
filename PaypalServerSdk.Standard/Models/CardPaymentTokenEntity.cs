// <copyright file="CardPaymentTokenEntity.cs" company="APIMatic">
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
    /// CardPaymentTokenEntity.
    /// </summary>
    public class CardPaymentTokenEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardPaymentTokenEntity"/> class.
        /// </summary>
        public CardPaymentTokenEntity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardPaymentTokenEntity"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="lastDigits">last_digits.</param>
        /// <param name="brand">brand.</param>
        /// <param name="expiry">expiry.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="verificationStatus">verification_status.</param>
        /// <param name="verification">verification.</param>
        /// <param name="networkTransactionReference">network_transaction_reference.</param>
        /// <param name="authenticationResult">authentication_result.</param>
        /// <param name="binDetails">bin_details.</param>
        /// <param name="type">type.</param>
        public CardPaymentTokenEntity(
            string name = null,
            string lastDigits = null,
            Models.CardBrand? brand = null,
            string expiry = null,
            Models.CardResponseAddress billingAddress = null,
            Models.CardVerificationStatus? verificationStatus = null,
            Models.CardVerificationDetails verification = null,
            Models.NetworkTransactionReferenceEntity networkTransactionReference = null,
            Models.CardAuthenticationResponse authenticationResult = null,
            Models.BinDetails binDetails = null,
            Models.CardType? type = null)
        {
            this.Name = name;
            this.LastDigits = lastDigits;
            this.Brand = brand;
            this.Expiry = expiry;
            this.BillingAddress = billingAddress;
            this.VerificationStatus = verificationStatus;
            this.Verification = verification;
            this.NetworkTransactionReference = networkTransactionReference;
            this.AuthenticationResult = authenticationResult;
            this.BinDetails = binDetails;
            this.Type = type;
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
        /// The year and month, in ISO-8601 `YYYY-MM` date format. See [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty("expiry", NullValueHandling = NullValueHandling.Ignore)]
        public string Expiry { get; set; }

        /// <summary>
        /// Address request details.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardResponseAddress BillingAddress { get; set; }

        /// <summary>
        /// Verification status of Card.
        /// </summary>
        [JsonProperty("verification_status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardVerificationStatus? VerificationStatus { get; set; }

        /// <summary>
        /// Card Verification details including the authorization details and 3D SECURE details.
        /// </summary>
        [JsonProperty("verification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardVerificationDetails Verification { get; set; }

        /// <summary>
        /// Previous network transaction reference including id in response.
        /// </summary>
        [JsonProperty("network_transaction_reference", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NetworkTransactionReferenceEntity NetworkTransactionReference { get; set; }

        /// <summary>
        /// Results of Authentication such as 3D Secure.
        /// </summary>
        [JsonProperty("authentication_result", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardAuthenticationResponse AuthenticationResult { get; set; }

        /// <summary>
        /// Bank Identification Number (BIN) details used to fund a payment.
        /// </summary>
        [JsonProperty("bin_details", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BinDetails BinDetails { get; set; }

        /// <summary>
        /// Type of card. i.e Credit, Debit and so on.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardType? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardPaymentTokenEntity : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardPaymentTokenEntity other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.LastDigits == null && other.LastDigits == null ||
                 this.LastDigits?.Equals(other.LastDigits) == true) &&
                (this.Brand == null && other.Brand == null ||
                 this.Brand?.Equals(other.Brand) == true) &&
                (this.Expiry == null && other.Expiry == null ||
                 this.Expiry?.Equals(other.Expiry) == true) &&
                (this.BillingAddress == null && other.BillingAddress == null ||
                 this.BillingAddress?.Equals(other.BillingAddress) == true) &&
                (this.VerificationStatus == null && other.VerificationStatus == null ||
                 this.VerificationStatus?.Equals(other.VerificationStatus) == true) &&
                (this.Verification == null && other.Verification == null ||
                 this.Verification?.Equals(other.Verification) == true) &&
                (this.NetworkTransactionReference == null && other.NetworkTransactionReference == null ||
                 this.NetworkTransactionReference?.Equals(other.NetworkTransactionReference) == true) &&
                (this.AuthenticationResult == null && other.AuthenticationResult == null ||
                 this.AuthenticationResult?.Equals(other.AuthenticationResult) == true) &&
                (this.BinDetails == null && other.BinDetails == null ||
                 this.BinDetails?.Equals(other.BinDetails) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"LastDigits = {this.LastDigits ?? "null"}");
            toStringOutput.Add($"Brand = {(this.Brand == null ? "null" : this.Brand.ToString())}");
            toStringOutput.Add($"Expiry = {this.Expiry ?? "null"}");
            toStringOutput.Add($"BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"VerificationStatus = {(this.VerificationStatus == null ? "null" : this.VerificationStatus.ToString())}");
            toStringOutput.Add($"Verification = {(this.Verification == null ? "null" : this.Verification.ToString())}");
            toStringOutput.Add($"NetworkTransactionReference = {(this.NetworkTransactionReference == null ? "null" : this.NetworkTransactionReference.ToString())}");
            toStringOutput.Add($"AuthenticationResult = {(this.AuthenticationResult == null ? "null" : this.AuthenticationResult.ToString())}");
            toStringOutput.Add($"BinDetails = {(this.BinDetails == null ? "null" : this.BinDetails.ToString())}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}