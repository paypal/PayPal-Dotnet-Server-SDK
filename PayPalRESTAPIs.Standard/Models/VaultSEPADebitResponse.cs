// <copyright file="VaultSEPADebitResponse.cs" company="APIMatic">
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
    /// VaultSEPADebitResponse.
    /// </summary>
    public class VaultSEPADebitResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultSEPADebitResponse"/> class.
        /// </summary>
        public VaultSEPADebitResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultSEPADebitResponse"/> class.
        /// </summary>
        /// <param name="ibanLastChars">iban_last_chars.</param>
        /// <param name="accountHolderName">account_holder_name.</param>
        /// <param name="billingAddress">billing_address.</param>
        public VaultSEPADebitResponse(
            string ibanLastChars = null,
            JsonValue accountHolderName = null,
            Models.Address billingAddress = null)
        {
            this.IbanLastChars = ibanLastChars;
            this.AccountHolderName = accountHolderName;
            this.BillingAddress = billingAddress;
        }

        /// <summary>
        /// The last characters of the IBAN used to pay.
        /// </summary>
        [JsonProperty("iban_last_chars", NullValueHandling = NullValueHandling.Ignore)]
        public string IbanLastChars { get; set; }

        /// <summary>
        /// Gets or sets AccountHolderName.
        /// </summary>
        [JsonProperty("account_holder_name", NullValueHandling = NullValueHandling.Ignore)]
        public JsonValue AccountHolderName { get; set; }

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

            return $"VaultSEPADebitResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is VaultSEPADebitResponse other &&                ((this.IbanLastChars == null && other.IbanLastChars == null) || (this.IbanLastChars?.Equals(other.IbanLastChars) == true)) &&
                ((this.AccountHolderName == null && other.AccountHolderName == null) || (this.AccountHolderName?.Equals(other.AccountHolderName) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IbanLastChars = {(this.IbanLastChars == null ? "null" : this.IbanLastChars)}");
            toStringOutput.Add($"AccountHolderName = {(this.AccountHolderName == null ? "null" : this.AccountHolderName.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
        }
    }
}