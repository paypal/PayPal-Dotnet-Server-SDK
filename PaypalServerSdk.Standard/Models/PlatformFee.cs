// <copyright file="PlatformFee.cs" company="APIMatic">
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
    /// PlatformFee.
    /// </summary>
    public class PlatformFee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformFee"/> class.
        /// </summary>
        public PlatformFee()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformFee"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="payee">payee.</param>
        public PlatformFee(
            Models.Money amount,
            Models.PayeeBase payee = null)
        {
            this.Amount = amount;
            this.Payee = payee;
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("amount")]
        public Models.Money Amount { get; set; }

        /// <summary>
        /// The details for the merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
        /// </summary>
        [JsonProperty("payee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayeeBase Payee { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PlatformFee : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PlatformFee other &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Payee == null && other.Payee == null ||
                 this.Payee?.Equals(other.Payee) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Payee = {(this.Payee == null ? "null" : this.Payee.ToString())}");
        }
    }
}