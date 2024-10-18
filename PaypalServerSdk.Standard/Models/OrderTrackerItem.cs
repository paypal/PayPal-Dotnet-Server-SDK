// <copyright file="OrderTrackerItem.cs" company="APIMatic">
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
    /// OrderTrackerItem.
    /// </summary>
    public class OrderTrackerItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTrackerItem"/> class.
        /// </summary>
        public OrderTrackerItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTrackerItem"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="sku">sku.</param>
        /// <param name="url">url.</param>
        /// <param name="imageUrl">image_url.</param>
        /// <param name="upc">upc.</param>
        public OrderTrackerItem(
            string name = null,
            string quantity = null,
            string sku = null,
            string url = null,
            string imageUrl = null,
            Models.UniversalProductCode upc = null)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Sku = sku;
            this.Url = url;
            this.ImageUrl = imageUrl;
            this.Upc = upc;
        }

        /// <summary>
        /// The item name or title.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The item quantity. Must be a whole number.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string Quantity { get; set; }

        /// <summary>
        /// The stock keeping unit (SKU) for the item. This can contain unicode characters.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderTrackerItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is OrderTrackerItem other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.Sku == null && other.Sku == null) || (this.Sku?.Equals(other.Sku) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
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
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity)}");
            toStringOutput.Add($"this.Sku = {(this.Sku == null ? "null" : this.Sku)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.ImageUrl = {(this.ImageUrl == null ? "null" : this.ImageUrl)}");
            toStringOutput.Add($"this.Upc = {(this.Upc == null ? "null" : this.Upc.ToString())}");
        }
    }
}