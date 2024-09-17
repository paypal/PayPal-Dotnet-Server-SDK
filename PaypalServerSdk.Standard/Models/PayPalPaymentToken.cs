// <copyright file="PaypalPaymentToken.cs" company="APIMatic">
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
using PaypalServerSDK.Standard;
using PaypalServerSDK.Standard.Utilities;

namespace PaypalServerSDK.Standard.Models
{
    /// <summary>
    /// PaypalPaymentToken.
    /// </summary>
    public class PaypalPaymentToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalPaymentToken"/> class.
        /// </summary>
        public PaypalPaymentToken()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalPaymentToken"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="permitMultiplePaymentTokens">permit_multiple_payment_tokens.</param>
        /// <param name="usageType">usage_type.</param>
        /// <param name="customerType">customer_type.</param>
        /// <param name="emailAddress">email_address.</param>
        /// <param name="payerId">payer_id.</param>
        /// <param name="name">name.</param>
        /// <param name="phone">phone.</param>
        /// <param name="address">address.</param>
        /// <param name="accountId">account_id.</param>
        /// <param name="phoneNumber">phone_number.</param>
        public PaypalPaymentToken(
            string description = null,
            Models.VaultedDigitalWalletShippingDetails shipping = null,
            bool? permitMultiplePaymentTokens = false,
            string usageType = null,
            string customerType = null,
            string emailAddress = null,
            string payerId = null,
            Models.Name name = null,
            Models.PhoneWithType phone = null,
            Models.Address address = null,
            string accountId = null,
            Models.Phone phoneNumber = null)
        {
            this.Description = description;
            this.Shipping = shipping;
            this.PermitMultiplePaymentTokens = permitMultiplePaymentTokens;
            this.UsageType = usageType;
            this.CustomerType = customerType;
            this.EmailAddress = emailAddress;
            this.PayerId = payerId;
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
            this.AccountId = accountId;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// The description displayed to the consumer on the approval flow for a digital wallet, as well as on the merchant view of the payment token management experience. exp: PayPal.com.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The shipping details.
        /// </summary>
        [JsonProperty("shipping", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VaultedDigitalWalletShippingDetails Shipping { get; set; }

        /// <summary>
        /// Create multiple payment tokens for the same payer, merchant/platform combination. Use this when the customer has not logged in at merchant/platform. The payment token thus generated, can then also be used to create the customer account at merchant/platform. Use this also when multiple payment tokens are required for the same payer, different customer at merchant/platform. This helps to identify customers distinctly even though they may share the same PayPal account. This only applies to PayPal payment source.
        /// </summary>
        [JsonProperty("permit_multiple_payment_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PermitMultiplePaymentTokens { get; set; }

        /// <summary>
        /// The usage type associated with a digital wallet payment token.
        /// </summary>
        [JsonProperty("usage_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageType { get; set; }

        /// <summary>
        /// The customer type associated with a digital wallet payment token. This is to indicate whether the customer acting on the merchant / platform is either a business or a consumer.
        /// </summary>
        [JsonProperty("customer_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerType { get; set; }

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [JsonProperty("email_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The account identifier for a PayPal account.
        /// </summary>
        [JsonProperty("payer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerId { get; set; }

        /// <summary>
        /// The name of the party.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Name Name { get; set; }

        /// <summary>
        /// The phone information.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PhoneWithType Phone { get; set; }

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address Address { get; set; }

        /// <summary>
        /// The account identifier for a PayPal account.
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Phone PhoneNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaypalPaymentToken : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaypalPaymentToken other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Shipping == null && other.Shipping == null) || (this.Shipping?.Equals(other.Shipping) == true)) &&
                ((this.PermitMultiplePaymentTokens == null && other.PermitMultiplePaymentTokens == null) || (this.PermitMultiplePaymentTokens?.Equals(other.PermitMultiplePaymentTokens) == true)) &&
                ((this.UsageType == null && other.UsageType == null) || (this.UsageType?.Equals(other.UsageType) == true)) &&
                ((this.CustomerType == null && other.CustomerType == null) || (this.CustomerType?.Equals(other.CustomerType) == true)) &&
                ((this.EmailAddress == null && other.EmailAddress == null) || (this.EmailAddress?.Equals(other.EmailAddress) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.PhoneNumber == null && other.PhoneNumber == null) || (this.PhoneNumber?.Equals(other.PhoneNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"this.PermitMultiplePaymentTokens = {(this.PermitMultiplePaymentTokens == null ? "null" : this.PermitMultiplePaymentTokens.ToString())}");
            toStringOutput.Add($"this.UsageType = {(this.UsageType == null ? "null" : this.UsageType)}");
            toStringOutput.Add($"this.CustomerType = {(this.CustomerType == null ? "null" : this.CustomerType)}");
            toStringOutput.Add($"this.EmailAddress = {(this.EmailAddress == null ? "null" : this.EmailAddress)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone.ToString())}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId)}");
            toStringOutput.Add($"this.PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber.ToString())}");
        }
    }
}