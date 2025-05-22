// <copyright file="LineItem.cs" company="APIMatic">
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
    /// LineItem.
    /// </summary>
    public class LineItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItem"/> class.
        /// </summary>
        public LineItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LineItem"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="description">description.</param>
        /// <param name="sku">sku.</param>
        /// <param name="url">url.</param>
        /// <param name="imageUrl">image_url.</param>
        /// <param name="upc">upc.</param>
        /// <param name="billingPlan">billing_plan.</param>
        /// <param name="unitAmount">unit_amount.</param>
        /// <param name="tax">tax.</param>
        /// <param name="commodityCode">commodity_code.</param>
        /// <param name="discountAmount">discount_amount.</param>
        /// <param name="totalAmount">total_amount.</param>
        /// <param name="unitOfMeasure">unit_of_measure.</param>
        public LineItem(
            string name,
            string quantity,
            string description = null,
            string sku = null,
            string url = null,
            string imageUrl = null,
            Models.UniversalProductCode upc = null,
            Models.OrderBillingPlan billingPlan = null,
            Models.Money unitAmount = null,
            Models.Money tax = null,
            string commodityCode = null,
            Models.Money discountAmount = null,
            Models.Money totalAmount = null,
            string unitOfMeasure = null)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Description = description;
            this.Sku = sku;
            this.Url = url;
            this.ImageUrl = imageUrl;
            this.Upc = upc;
            this.BillingPlan = billingPlan;
            this.UnitAmount = unitAmount;
            this.Tax = tax;
            this.CommodityCode = commodityCode;
            this.DiscountAmount = discountAmount;
            this.TotalAmount = totalAmount;
            this.UnitOfMeasure = unitOfMeasure;
        }

        /// <summary>
        /// The item name or title.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The item quantity. Must be a whole number.
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// The detailed item description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The stock keeping unit (SKU) for the item.
        /// </summary>
        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        public string Sku { get; set; }

        /// <summary>
        /// The URL to the item being purchased. Visible to buyer and used in buyer experiences.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// The URL of the item's image. File type and size restrictions apply. An image that violates these restrictions will not be honored.
        /// </summary>
        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The Universal Product Code of the item.
        /// </summary>
        [JsonProperty("upc", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UniversalProductCode Upc { get; set; }

        /// <summary>
        /// Metadata for merchant-managed recurring billing plans. Valid only during the saved payment method token or billing agreement creation.
        /// </summary>
        [JsonProperty("billing_plan", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderBillingPlan BillingPlan { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("unit_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money UnitAmount { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("tax", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Tax { get; set; }

        /// <summary>
        /// Code used to classify items purchased and track the total amount spent across various categories of products and services. Different corporate purchasing organizations may use different standards, but the United Nations Standard Products and Services Code (UNSPSC) is frequently used.
        /// </summary>
        [JsonProperty("commodity_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money DiscountAmount { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money TotalAmount { get; set; }

        /// <summary>
        /// Unit of measure is a standard used to express the magnitude of a quantity in international trade. Most commonly used (but not limited to) examples are: Acre (ACR), Ampere (AMP), Centigram (CGM), Centimetre (CMT), Cubic inch (INQ), Cubic metre (MTQ), Fluid ounce (OZA), Foot (FOT), Hour (HUR), Item (ITM), Kilogram (KGM), Kilometre (KMT), Kilowatt (KWT), Liquid gallon (GLL), Liter (LTR), Pounds (LBS), Square foot (FTK).
        /// </summary>
        [JsonProperty("unit_of_measure", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitOfMeasure { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"LineItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is LineItem other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Sku == null && other.Sku == null ||
                 this.Sku?.Equals(other.Sku) == true) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
                (this.ImageUrl == null && other.ImageUrl == null ||
                 this.ImageUrl?.Equals(other.ImageUrl) == true) &&
                (this.Upc == null && other.Upc == null ||
                 this.Upc?.Equals(other.Upc) == true) &&
                (this.BillingPlan == null && other.BillingPlan == null ||
                 this.BillingPlan?.Equals(other.BillingPlan) == true) &&
                (this.UnitAmount == null && other.UnitAmount == null ||
                 this.UnitAmount?.Equals(other.UnitAmount) == true) &&
                (this.Tax == null && other.Tax == null ||
                 this.Tax?.Equals(other.Tax) == true) &&
                (this.CommodityCode == null && other.CommodityCode == null ||
                 this.CommodityCode?.Equals(other.CommodityCode) == true) &&
                (this.DiscountAmount == null && other.DiscountAmount == null ||
                 this.DiscountAmount?.Equals(other.DiscountAmount) == true) &&
                (this.TotalAmount == null && other.TotalAmount == null ||
                 this.TotalAmount?.Equals(other.TotalAmount) == true) &&
                (this.UnitOfMeasure == null && other.UnitOfMeasure == null ||
                 this.UnitOfMeasure?.Equals(other.UnitOfMeasure) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Quantity = {this.Quantity ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Sku = {this.Sku ?? "null"}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"ImageUrl = {this.ImageUrl ?? "null"}");
            toStringOutput.Add($"Upc = {(this.Upc == null ? "null" : this.Upc.ToString())}");
            toStringOutput.Add($"BillingPlan = {(this.BillingPlan == null ? "null" : this.BillingPlan.ToString())}");
            toStringOutput.Add($"UnitAmount = {(this.UnitAmount == null ? "null" : this.UnitAmount.ToString())}");
            toStringOutput.Add($"Tax = {(this.Tax == null ? "null" : this.Tax.ToString())}");
            toStringOutput.Add($"CommodityCode = {this.CommodityCode ?? "null"}");
            toStringOutput.Add($"DiscountAmount = {(this.DiscountAmount == null ? "null" : this.DiscountAmount.ToString())}");
            toStringOutput.Add($"TotalAmount = {(this.TotalAmount == null ? "null" : this.TotalAmount.ToString())}");
            toStringOutput.Add($"UnitOfMeasure = {this.UnitOfMeasure ?? "null"}");
        }
    }
}