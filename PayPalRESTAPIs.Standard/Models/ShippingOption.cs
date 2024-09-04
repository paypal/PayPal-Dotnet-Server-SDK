// <copyright file="ShippingOption.cs" company="APIMatic">
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
    /// ShippingOption.
    /// </summary>
    public class ShippingOption
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingOption"/> class.
        /// </summary>
        public ShippingOption()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingOption"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="label">label.</param>
        /// <param name="selected">selected.</param>
        /// <param name="type">type.</param>
        /// <param name="amount">amount.</param>
        public ShippingOption(
            string id,
            string label,
            bool selected,
            Models.ShippingType? type = null,
            Models.Money amount = null)
        {
            this.Id = id;
            this.Label = label;
            this.Type = type;
            this.Amount = amount;
            this.Selected = selected;
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

        /// <summary>
        /// If the API request sets `selected = true`, it represents the shipping option that the payee or merchant expects to be pre-selected for the payer when they first view the `shipping.options` in the PayPal Checkout experience. As part of the response if a `shipping.option` contains `selected=true`, it represents the shipping option that the payer selected during the course of checkout with PayPal. Only one `shipping.option` can be set to `selected=true`.
        /// </summary>
        [JsonProperty("selected")]
        public bool Selected { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ShippingOption : ({string.Join(", ", toStringOutput)})";
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
            return obj is ShippingOption other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Label == null && other.Label == null) || (this.Label?.Equals(other.Label) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                this.Selected.Equals(other.Selected);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Label = {(this.Label == null ? "null" : this.Label)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Selected = {this.Selected}");
        }
    }
}