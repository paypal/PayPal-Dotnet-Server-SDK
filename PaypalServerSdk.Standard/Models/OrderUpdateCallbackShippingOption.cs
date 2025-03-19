// <copyright file="OrderUpdateCallbackShippingOption.cs" company="APIMatic">
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
    /// OrderUpdateCallbackShippingOption.
    /// </summary>
    public class OrderUpdateCallbackShippingOption
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateCallbackShippingOption"/> class.
        /// </summary>
        public OrderUpdateCallbackShippingOption()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateCallbackShippingOption"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="label">label.</param>
        /// <param name="type">type.</param>
        /// <param name="amount">amount.</param>
        public OrderUpdateCallbackShippingOption(
            string id,
            string label,
            Models.ShippingType? type = null,
            Models.Money amount = null)
        {
            this.Id = id;
            this.Label = label;
            this.Type = type;
            this.Amount = amount;
        }

        /// <summary>
        /// A unique ID that identifies a payer-selected shipping option.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A description that the payer sees, which helps them choose an appropriate shipping option. For example, `Free Shipping`, `USPS Priority Shipping`, `Expédition prioritaire USPS`, or `USPS yōuxiān fā huò`. Localize this description to the payer's locale.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// A classification for the method of purchase fulfillment.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShippingType? Type { get; set; }

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
            return $"OrderUpdateCallbackShippingOption : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderUpdateCallbackShippingOption other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Label == null && other.Label == null ||
                 this.Label?.Equals(other.Label) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Label = {this.Label ?? "null"}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
        }
    }
}