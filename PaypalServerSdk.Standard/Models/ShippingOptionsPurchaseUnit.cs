// <copyright file="ShippingOptionsPurchaseUnit.cs" company="APIMatic">
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
    /// ShippingOptionsPurchaseUnit.
    /// </summary>
    public class ShippingOptionsPurchaseUnit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingOptionsPurchaseUnit"/> class.
        /// </summary>
        public ShippingOptionsPurchaseUnit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingOptionsPurchaseUnit"/> class.
        /// </summary>
        /// <param name="referenceId">reference_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="shippingOptions">shipping_options.</param>
        public ShippingOptionsPurchaseUnit(
            string referenceId = null,
            Models.AmountWithBreakdown amount = null,
            List<Models.ShippingOption> shippingOptions = null)
        {
            this.ReferenceId = referenceId;
            this.Amount = amount;
            this.ShippingOptions = shippingOptions;
        }

        /// <summary>
        /// The API caller-provided external ID for the purchase unit. Required for multiple purchase units when you must update the order through `PATCH`. If you omit this value and the order contains only one purchase unit, PayPal sets this value to `default`. Note: If there are multiple purchase units, reference_id is required for each purchase unit.
        /// </summary>
        [JsonProperty("reference_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping, handling, insurance, and discounts, if any. If you specify `amount.breakdown`, the amount equals `item_total` plus `tax_total` plus `shipping` plus `handling` plus `insurance` minus `shipping_discount` minus discount. The amount must be a positive number. For listed of supported currencies and decimal precision, see the PayPal REST APIs Currency Codes.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AmountWithBreakdown Amount { get; set; }

        /// <summary>
        /// An array of shipping options that the payee or merchant offers to the payer to ship or pick up their items.
        /// </summary>
        [JsonProperty("shipping_options", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ShippingOption> ShippingOptions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ShippingOptionsPurchaseUnit : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ShippingOptionsPurchaseUnit other &&
                (this.ReferenceId == null && other.ReferenceId == null ||
                 this.ReferenceId?.Equals(other.ReferenceId) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.ShippingOptions == null && other.ShippingOptions == null ||
                 this.ShippingOptions?.Equals(other.ShippingOptions) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ReferenceId = {this.ReferenceId ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"ShippingOptions = {(this.ShippingOptions == null ? "null" : $"[{string.Join(", ", this.ShippingOptions)} ]")}");
        }
    }
}