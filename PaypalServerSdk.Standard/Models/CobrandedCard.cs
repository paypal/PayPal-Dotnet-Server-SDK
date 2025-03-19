// <copyright file="CobrandedCard.cs" company="APIMatic">
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
    /// CobrandedCard.
    /// </summary>
    public class CobrandedCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CobrandedCard"/> class.
        /// </summary>
        public CobrandedCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CobrandedCard"/> class.
        /// </summary>
        /// <param name="labels">labels.</param>
        /// <param name="payee">payee.</param>
        /// <param name="amount">amount.</param>
        public CobrandedCard(
            List<string> labels = null,
            Models.PayeeBase payee = null,
            Models.Money amount = null)
        {
            this.Labels = labels;
            this.Payee = payee;
            this.Amount = amount;
        }

        /// <summary>
        /// Array of labels for the cobranded card.
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// The details for the merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
        /// </summary>
        [JsonProperty("payee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayeeBase Payee { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Amount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CobrandedCard : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CobrandedCard other &&
                (this.Labels == null && other.Labels == null ||
                 this.Labels?.Equals(other.Labels) == true) &&
                (this.Payee == null && other.Payee == null ||
                 this.Payee?.Equals(other.Payee) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Labels = {(this.Labels == null ? "null" : $"[{string.Join(", ", this.Labels)} ]")}");
            toStringOutput.Add($"Payee = {(this.Payee == null ? "null" : this.Payee.ToString())}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
        }
    }
}