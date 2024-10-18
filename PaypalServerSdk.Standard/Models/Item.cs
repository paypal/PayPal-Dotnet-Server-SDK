// <copyright file="Item.cs" company="APIMatic">
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
    /// Item.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        public Item()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="unitAmount">unit_amount.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="tax">tax.</param>
        /// <param name="description">description.</param>
        /// <param name="sku">sku.</param>
        /// <param name="url">url.</param>
        /// <param name="category">category.</param>
        /// <param name="imageUrl">image_url.</param>
        /// <param name="upc">upc.</param>
        public Item(
            string name,
            Models.Money unitAmount,
            string quantity,
            Models.Money tax = null,
            string description = null,
            string sku = null,
            string url = null,
            Models.ItemCategory? category = null,
            string imageUrl = null,
            Models.UniversalProductCode upc = null)
        {
            this.Name = name;
            this.UnitAmount = unitAmount;
            this.Tax = tax;
            this.Quantity = quantity;
            this.Description = description;
            this.Sku = sku;
            this.Url = url;
            this.Category = category;
            this.ImageUrl = imageUrl;
            this.Upc = upc;
        }

        /// <summary>
        /// The item name or title.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("unit_amount")]
        public Models.Money UnitAmount { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("tax", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Tax { get; set; }

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
        /// The item category type.
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ItemCategory? Category { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Item : ({string.Join(", ", toStringOutput)})";
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
            return obj is Item other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.UnitAmount == null && other.UnitAmount == null) || (this.UnitAmount?.Equals(other.UnitAmount) == true)) &&
                ((this.Tax == null && other.Tax == null) || (this.Tax?.Equals(other.Tax) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Sku == null && other.Sku == null) || (this.Sku?.Equals(other.Sku) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Category == null && other.Category == null) || (this.Category?.Equals(other.Category) == true)) &&
                ((this.ImageUrl == null && other.ImageUrl == null) || (this.ImageUrl?.Equals(other.ImageUrl) == true)) &&
                ((this.Upc == null && other.Upc == null) || (this.Upc?.Equals(other.Upc) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.UnitAmount = {(this.UnitAmount == null ? "null" : this.UnitAmount.ToString())}");
            toStringOutput.Add($"this.Tax = {(this.Tax == null ? "null" : this.Tax.ToString())}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Sku = {(this.Sku == null ? "null" : this.Sku)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.Category = {(this.Category == null ? "null" : this.Category.ToString())}");
            toStringOutput.Add($"this.ImageUrl = {(this.ImageUrl == null ? "null" : this.ImageUrl)}");
            toStringOutput.Add($"this.Upc = {(this.Upc == null ? "null" : this.Upc.ToString())}");
        }
    }
}