// <copyright file="AmountBreakdown.cs" company="APIMatic">
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
    /// AmountBreakdown.
    /// </summary>
    public class AmountBreakdown
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmountBreakdown"/> class.
        /// </summary>
        public AmountBreakdown()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmountBreakdown"/> class.
        /// </summary>
        /// <param name="itemTotal">item_total.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="handling">handling.</param>
        /// <param name="taxTotal">tax_total.</param>
        /// <param name="insurance">insurance.</param>
        /// <param name="shippingDiscount">shipping_discount.</param>
        /// <param name="discount">discount.</param>
        public AmountBreakdown(
            Models.Money itemTotal = null,
            Models.Money shipping = null,
            Models.Money handling = null,
            Models.Money taxTotal = null,
            Models.Money insurance = null,
            Models.Money shippingDiscount = null,
            Models.Money discount = null)
        {
            this.ItemTotal = itemTotal;
            this.Shipping = shipping;
            this.Handling = handling;
            this.TaxTotal = taxTotal;
            this.Insurance = insurance;
            this.ShippingDiscount = shippingDiscount;
            this.Discount = discount;
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("item_total", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money ItemTotal { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("shipping", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Shipping { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("handling", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Handling { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("tax_total", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money TaxTotal { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("insurance", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Insurance { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("shipping_discount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money ShippingDiscount { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("discount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Discount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AmountBreakdown : ({string.Join(", ", toStringOutput)})";
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
            return obj is AmountBreakdown other &&                ((this.ItemTotal == null && other.ItemTotal == null) || (this.ItemTotal?.Equals(other.ItemTotal) == true)) &&
                ((this.Shipping == null && other.Shipping == null) || (this.Shipping?.Equals(other.Shipping) == true)) &&
                ((this.Handling == null && other.Handling == null) || (this.Handling?.Equals(other.Handling) == true)) &&
                ((this.TaxTotal == null && other.TaxTotal == null) || (this.TaxTotal?.Equals(other.TaxTotal) == true)) &&
                ((this.Insurance == null && other.Insurance == null) || (this.Insurance?.Equals(other.Insurance) == true)) &&
                ((this.ShippingDiscount == null && other.ShippingDiscount == null) || (this.ShippingDiscount?.Equals(other.ShippingDiscount) == true)) &&
                ((this.Discount == null && other.Discount == null) || (this.Discount?.Equals(other.Discount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ItemTotal = {(this.ItemTotal == null ? "null" : this.ItemTotal.ToString())}");
            toStringOutput.Add($"this.Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"this.Handling = {(this.Handling == null ? "null" : this.Handling.ToString())}");
            toStringOutput.Add($"this.TaxTotal = {(this.TaxTotal == null ? "null" : this.TaxTotal.ToString())}");
            toStringOutput.Add($"this.Insurance = {(this.Insurance == null ? "null" : this.Insurance.ToString())}");
            toStringOutput.Add($"this.ShippingDiscount = {(this.ShippingDiscount == null ? "null" : this.ShippingDiscount.ToString())}");
            toStringOutput.Add($"this.Discount = {(this.Discount == null ? "null" : this.Discount.ToString())}");
        }
    }
}