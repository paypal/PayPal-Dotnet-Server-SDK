// <copyright file="PayerBase.cs" company="APIMatic">
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
    /// PayerBase.
    /// </summary>
    public class PayerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayerBase"/> class.
        /// </summary>
        public PayerBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayerBase"/> class.
        /// </summary>
        /// <param name="emailAddress">email_address.</param>
        /// <param name="payerId">payer_id.</param>
        public PayerBase(
            string emailAddress = null,
            string payerId = null)
        {
            this.EmailAddress = emailAddress;
            this.PayerId = payerId;
        }

        /// <summary>
        /// The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.
        /// </summary>
        [JsonProperty("email_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The account identifier for a PayPal account.
        /// </summary>
        [JsonProperty("payer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PayerBase : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PayerBase other &&
                (this.EmailAddress == null && other.EmailAddress == null ||
                 this.EmailAddress?.Equals(other.EmailAddress) == true) &&
                (this.PayerId == null && other.PayerId == null ||
                 this.PayerId?.Equals(other.PayerId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"EmailAddress = {this.EmailAddress ?? "null"}");
            toStringOutput.Add($"PayerId = {this.PayerId ?? "null"}");
        }
    }
}