// <copyright file="PayeeBase.cs" company="APIMatic">
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
    /// PayeeBase.
    /// </summary>
    public class PayeeBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayeeBase"/> class.
        /// </summary>
        public PayeeBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayeeBase"/> class.
        /// </summary>
        /// <param name="emailAddress">email_address.</param>
        /// <param name="merchantId">merchant_id.</param>
        public PayeeBase(
            string emailAddress = null,
            string merchantId = null)
        {
            this.EmailAddress = emailAddress;
            this.MerchantId = merchantId;
        }

        /// <summary>
        /// The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.
        /// </summary>
        [JsonProperty("email_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The account identifier for a PayPal account.
        /// </summary>
        [JsonProperty("merchant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PayeeBase : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PayeeBase other &&
                (this.EmailAddress == null && other.EmailAddress == null ||
                 this.EmailAddress?.Equals(other.EmailAddress) == true) &&
                (this.MerchantId == null && other.MerchantId == null ||
                 this.MerchantId?.Equals(other.MerchantId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"EmailAddress = {this.EmailAddress ?? "null"}");
            toStringOutput.Add($"MerchantId = {this.MerchantId ?? "null"}");
        }
    }
}