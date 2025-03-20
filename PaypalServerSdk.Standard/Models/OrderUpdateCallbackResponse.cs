// <copyright file="OrderUpdateCallbackResponse.cs" company="APIMatic">
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
    /// OrderUpdateCallbackResponse.
    /// </summary>
    public class OrderUpdateCallbackResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateCallbackResponse"/> class.
        /// </summary>
        public OrderUpdateCallbackResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateCallbackResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="purchaseUnits">purchase_units.</param>
        public OrderUpdateCallbackResponse(
            string id = null,
            Models.ShippingOptionsPurchaseUnit purchaseUnits = null)
        {
            this.Id = id;
            this.PurchaseUnits = purchaseUnits;
        }

        /// <summary>
        /// The ID of the order.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// This would contain shipping option and amount data at purchase unit level.
        /// </summary>
        [JsonProperty("purchase_units", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShippingOptionsPurchaseUnit PurchaseUnits { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderUpdateCallbackResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderUpdateCallbackResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.PurchaseUnits == null && other.PurchaseUnits == null ||
                 this.PurchaseUnits?.Equals(other.PurchaseUnits) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"PurchaseUnits = {(this.PurchaseUnits == null ? "null" : this.PurchaseUnits.ToString())}");
        }
    }
}