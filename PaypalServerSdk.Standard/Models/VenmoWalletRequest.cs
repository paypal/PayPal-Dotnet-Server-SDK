// <copyright file="VenmoWalletRequest.cs" company="APIMatic">
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
    /// VenmoWalletRequest.
    /// </summary>
    public class VenmoWalletRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VenmoWalletRequest"/> class.
        /// </summary>
        public VenmoWalletRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VenmoWalletRequest"/> class.
        /// </summary>
        /// <param name="vaultId">vault_id.</param>
        /// <param name="emailAddress">email_address.</param>
        /// <param name="experienceContext">experience_context.</param>
        /// <param name="attributes">attributes.</param>
        public VenmoWalletRequest(
            string vaultId = null,
            string emailAddress = null,
            Models.VenmoWalletExperienceContext experienceContext = null,
            Models.VenmoWalletAdditionalAttributes attributes = null)
        {
            this.VaultId = vaultId;
            this.EmailAddress = emailAddress;
            this.ExperienceContext = experienceContext;
            this.Attributes = attributes;
        }

        /// <summary>
        /// The PayPal-generated ID for the vaulted payment source. This ID should be stored on the merchant's server so the saved payment source can be used for future transactions.
        /// </summary>
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }

        /// <summary>
        /// The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.
        /// </summary>
        [JsonProperty("email_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Customizes the buyer experience during the approval process for payment with Venmo. Note: Partners and Marketplaces might configure shipping_preference during partner account setup, which overrides the request values.
        /// </summary>
        [JsonProperty("experience_context", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VenmoWalletExperienceContext ExperienceContext { get; set; }

        /// <summary>
        /// Additional attributes associated with the use of this Venmo Wallet.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VenmoWalletAdditionalAttributes Attributes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"VenmoWalletRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is VenmoWalletRequest other &&
                (this.VaultId == null && other.VaultId == null ||
                 this.VaultId?.Equals(other.VaultId) == true) &&
                (this.EmailAddress == null && other.EmailAddress == null ||
                 this.EmailAddress?.Equals(other.EmailAddress) == true) &&
                (this.ExperienceContext == null && other.ExperienceContext == null ||
                 this.ExperienceContext?.Equals(other.ExperienceContext) == true) &&
                (this.Attributes == null && other.Attributes == null ||
                 this.Attributes?.Equals(other.Attributes) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"VaultId = {this.VaultId ?? "null"}");
            toStringOutput.Add($"EmailAddress = {this.EmailAddress ?? "null"}");
            toStringOutput.Add($"ExperienceContext = {(this.ExperienceContext == null ? "null" : this.ExperienceContext.ToString())}");
            toStringOutput.Add($"Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
        }
    }
}