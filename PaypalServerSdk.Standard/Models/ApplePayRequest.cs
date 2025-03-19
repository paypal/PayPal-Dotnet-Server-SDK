// <copyright file="ApplePayRequest.cs" company="APIMatic">
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
    /// ApplePayRequest.
    /// </summary>
    public class ApplePayRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayRequest"/> class.
        /// </summary>
        public ApplePayRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayRequest"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="emailAddress">email_address.</param>
        /// <param name="phoneNumber">phone_number.</param>
        /// <param name="decryptedToken">decrypted_token.</param>
        /// <param name="storedCredential">stored_credential.</param>
        /// <param name="vaultId">vault_id.</param>
        /// <param name="attributes">attributes.</param>
        public ApplePayRequest(
            string id = null,
            string name = null,
            string emailAddress = null,
            Models.PhoneNumber phoneNumber = null,
            Models.ApplePayDecryptedTokenData decryptedToken = null,
            Models.CardStoredCredential storedCredential = null,
            string vaultId = null,
            Models.ApplePayAttributes attributes = null)
        {
            this.Id = id;
            this.Name = name;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = phoneNumber;
            this.DecryptedToken = decryptedToken;
            this.StoredCredential = storedCredential;
            this.VaultId = vaultId;
            this.Attributes = attributes;
        }

        /// <summary>
        /// ApplePay transaction identifier, this will be the unique identifier for this transaction provided by Apple. The pattern is defined by an external party and supports Unicode.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

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
        /// Information about the Payment data obtained by decrypting Apple Pay token.
        /// </summary>
        [JsonProperty("decrypted_token", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplePayDecryptedTokenData DecryptedToken { get; set; }

        /// <summary>
        /// Provides additional details to process a payment using a `card` that has been stored or is intended to be stored (also referred to as stored_credential or card-on-file). Parameter compatibility: `payment_type=ONE_TIME` is compatible only with `payment_initiator=CUSTOMER`. `usage=FIRST` is compatible only with `payment_initiator=CUSTOMER`. `previous_transaction_reference` or `previous_network_transaction_reference` is compatible only with `payment_initiator=MERCHANT`. Only one of the parameters - `previous_transaction_reference` and `previous_network_transaction_reference` - can be present in the request.
        /// </summary>
        [JsonProperty("stored_credential", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardStoredCredential StoredCredential { get; set; }

        /// <summary>
        /// The PayPal-generated ID for the vaulted payment source. This ID should be stored on the merchant's server so the saved payment source can be used for future transactions.
        /// </summary>
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }

        /// <summary>
        /// Additional attributes associated with apple pay.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplePayAttributes Attributes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ApplePayRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ApplePayRequest other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.EmailAddress == null && other.EmailAddress == null ||
                 this.EmailAddress?.Equals(other.EmailAddress) == true) &&
                (this.PhoneNumber == null && other.PhoneNumber == null ||
                 this.PhoneNumber?.Equals(other.PhoneNumber) == true) &&
                (this.DecryptedToken == null && other.DecryptedToken == null ||
                 this.DecryptedToken?.Equals(other.DecryptedToken) == true) &&
                (this.StoredCredential == null && other.StoredCredential == null ||
                 this.StoredCredential?.Equals(other.StoredCredential) == true) &&
                (this.VaultId == null && other.VaultId == null ||
                 this.VaultId?.Equals(other.VaultId) == true) &&
                (this.Attributes == null && other.Attributes == null ||
                 this.Attributes?.Equals(other.Attributes) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"EmailAddress = {this.EmailAddress ?? "null"}");
            toStringOutput.Add($"PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber.ToString())}");
            toStringOutput.Add($"DecryptedToken = {(this.DecryptedToken == null ? "null" : this.DecryptedToken.ToString())}");
            toStringOutput.Add($"StoredCredential = {(this.StoredCredential == null ? "null" : this.StoredCredential.ToString())}");
            toStringOutput.Add($"VaultId = {this.VaultId ?? "null"}");
            toStringOutput.Add($"Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
        }
    }
}