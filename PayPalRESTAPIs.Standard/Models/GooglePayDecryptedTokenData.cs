// <copyright file="GooglePayDecryptedTokenData.cs" company="APIMatic">
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
    /// GooglePayDecryptedTokenData.
    /// </summary>
    public class GooglePayDecryptedTokenData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePayDecryptedTokenData"/> class.
        /// </summary>
        public GooglePayDecryptedTokenData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePayDecryptedTokenData"/> class.
        /// </summary>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="authenticationMethod">authentication_method.</param>
        /// <param name="messageId">message_id.</param>
        /// <param name="messageExpiration">message_expiration.</param>
        /// <param name="cryptogram">cryptogram.</param>
        /// <param name="eciIndicator">eci_indicator.</param>
        public GooglePayDecryptedTokenData(
            Models.GooglePayPaymentMethod paymentMethod,
            Models.GooglePayAuthenticationMethod authenticationMethod,
            string messageId = null,
            string messageExpiration = null,
            string cryptogram = null,
            string eciIndicator = null)
        {
            this.MessageId = messageId;
            this.MessageExpiration = messageExpiration;
            this.PaymentMethod = paymentMethod;
            this.AuthenticationMethod = authenticationMethod;
            this.Cryptogram = cryptogram;
            this.EciIndicator = eciIndicator;
        }

        /// <summary>
        /// A unique ID that identifies the message in case it needs to be revoked or located at a later time.
        /// </summary>
        [JsonProperty("message_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageId { get; set; }

        /// <summary>
        /// Date and time at which the message expires as UTC milliseconds since epoch. Integrators should reject any message that's expired.
        /// </summary>
        [JsonProperty("message_expiration", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageExpiration { get; set; }

        /// <summary>
        /// The type of the payment credential. Currently, only CARD is supported.
        /// </summary>
        [JsonProperty("payment_method")]
        public Models.GooglePayPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Authentication Method which is used for the card transaction.
        /// </summary>
        [JsonProperty("authentication_method")]
        public Models.GooglePayAuthenticationMethod AuthenticationMethod { get; set; }

        /// <summary>
        /// Base-64 cryptographic identifier used by card schemes to validate the token verification result. This is a conditionally required field if authentication_method is CRYPTOGRAM_3DS.
        /// </summary>
        [JsonProperty("cryptogram", NullValueHandling = NullValueHandling.Ignore)]
        public string Cryptogram { get; set; }

        /// <summary>
        /// Electronic Commerce Indicator may not always be present. It is only returned for tokens on the Visa card network. This value is passed through in the payment authorization request.
        /// </summary>
        [JsonProperty("eci_indicator", NullValueHandling = NullValueHandling.Ignore)]
        public string EciIndicator { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GooglePayDecryptedTokenData : ({string.Join(", ", toStringOutput)})";
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
            return obj is GooglePayDecryptedTokenData other &&                ((this.MessageId == null && other.MessageId == null) || (this.MessageId?.Equals(other.MessageId) == true)) &&
                ((this.MessageExpiration == null && other.MessageExpiration == null) || (this.MessageExpiration?.Equals(other.MessageExpiration) == true)) &&
                this.PaymentMethod.Equals(other.PaymentMethod) &&
                this.AuthenticationMethod.Equals(other.AuthenticationMethod) &&
                ((this.Cryptogram == null && other.Cryptogram == null) || (this.Cryptogram?.Equals(other.Cryptogram) == true)) &&
                ((this.EciIndicator == null && other.EciIndicator == null) || (this.EciIndicator?.Equals(other.EciIndicator) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MessageId = {(this.MessageId == null ? "null" : this.MessageId)}");
            toStringOutput.Add($"this.MessageExpiration = {(this.MessageExpiration == null ? "null" : this.MessageExpiration)}");
            toStringOutput.Add($"this.PaymentMethod = {this.PaymentMethod}");
            toStringOutput.Add($"this.AuthenticationMethod = {this.AuthenticationMethod}");
            toStringOutput.Add($"this.Cryptogram = {(this.Cryptogram == null ? "null" : this.Cryptogram)}");
            toStringOutput.Add($"this.EciIndicator = {(this.EciIndicator == null ? "null" : this.EciIndicator)}");
        }
    }
}