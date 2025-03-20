// <copyright file="OneTimeCharge.cs" company="APIMatic">
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
    /// OneTimeCharge.
    /// </summary>
    public class OneTimeCharge
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneTimeCharge"/> class.
        /// </summary>
        public OneTimeCharge()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneTimeCharge"/> class.
        /// </summary>
        /// <param name="totalAmount">total_amount.</param>
        /// <param name="setupFee">setup_fee.</param>
        /// <param name="shippingAmount">shipping_amount.</param>
        /// <param name="taxes">taxes.</param>
        /// <param name="productPrice">product_price.</param>
        /// <param name="subtotal">subtotal.</param>
        public OneTimeCharge(
            Models.Money totalAmount,
            Models.Money setupFee = null,
            Models.Money shippingAmount = null,
            Models.Money taxes = null,
            Models.Money productPrice = null,
            Models.Money subtotal = null)
        {
            this.SetupFee = setupFee;
            this.ShippingAmount = shippingAmount;
            this.Taxes = taxes;
            this.ProductPrice = productPrice;
            this.Subtotal = subtotal;
            this.TotalAmount = totalAmount;
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("setup_fee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money SetupFee { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("shipping_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money ShippingAmount { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("taxes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Taxes { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("product_price", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money ProductPrice { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("subtotal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Subtotal { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("total_amount")]
        public Models.Money TotalAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OneTimeCharge : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OneTimeCharge other &&
                (this.SetupFee == null && other.SetupFee == null ||
                 this.SetupFee?.Equals(other.SetupFee) == true) &&
                (this.ShippingAmount == null && other.ShippingAmount == null ||
                 this.ShippingAmount?.Equals(other.ShippingAmount) == true) &&
                (this.Taxes == null && other.Taxes == null ||
                 this.Taxes?.Equals(other.Taxes) == true) &&
                (this.ProductPrice == null && other.ProductPrice == null ||
                 this.ProductPrice?.Equals(other.ProductPrice) == true) &&
                (this.Subtotal == null && other.Subtotal == null ||
                 this.Subtotal?.Equals(other.Subtotal) == true) &&
                (this.TotalAmount == null && other.TotalAmount == null ||
                 this.TotalAmount?.Equals(other.TotalAmount) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SetupFee = {(this.SetupFee == null ? "null" : this.SetupFee.ToString())}");
            toStringOutput.Add($"ShippingAmount = {(this.ShippingAmount == null ? "null" : this.ShippingAmount.ToString())}");
            toStringOutput.Add($"Taxes = {(this.Taxes == null ? "null" : this.Taxes.ToString())}");
            toStringOutput.Add($"ProductPrice = {(this.ProductPrice == null ? "null" : this.ProductPrice.ToString())}");
            toStringOutput.Add($"Subtotal = {(this.Subtotal == null ? "null" : this.Subtotal.ToString())}");
            toStringOutput.Add($"TotalAmount = {(this.TotalAmount == null ? "null" : this.TotalAmount.ToString())}");
        }
    }
}