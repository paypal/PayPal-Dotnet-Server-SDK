// <copyright file="OrderUpdateCallbackRequest.cs" company="APIMatic">
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
    /// OrderUpdateCallbackRequest.
    /// </summary>
    public class OrderUpdateCallbackRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateCallbackRequest"/> class.
        /// </summary>
        public OrderUpdateCallbackRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateCallbackRequest"/> class.
        /// </summary>
        /// <param name="shippingAddress">shipping_address.</param>
        /// <param name="purchaseUnits">purchase_units.</param>
        /// <param name="id">id.</param>
        /// <param name="shippingOption">shipping_option.</param>
        public OrderUpdateCallbackRequest(
            Models.OrderUpdateCallbackShippingAddress shippingAddress,
            List<Models.PurchaseUnitRequest> purchaseUnits,
            string id = null,
            Models.OrderUpdateCallbackShippingOption shippingOption = null)
        {
            this.Id = id;
            this.ShippingAddress = shippingAddress;
            this.ShippingOption = shippingOption;
            this.PurchaseUnits = purchaseUnits;
        }

        /// <summary>
        /// The ID of the order.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [JsonProperty("shipping_address")]
        public Models.OrderUpdateCallbackShippingAddress ShippingAddress { get; set; }

        /// <summary>
        /// The options that the payee or merchant offers to the payer to ship or pick up their items.
        /// </summary>
        [JsonProperty("shipping_option", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderUpdateCallbackShippingOption ShippingOption { get; set; }

        /// <summary>
        /// An array of purchase units. At present only 1 purchase_unit is supported. Each purchase unit establishes a contract between a payer and the payee. Each purchase unit represents either a full or partial order that the payer intends to purchase from the payee.
        /// </summary>
        [JsonProperty("purchase_units")]
        public List<Models.PurchaseUnitRequest> PurchaseUnits { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderUpdateCallbackRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderUpdateCallbackRequest other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.ShippingAddress == null && other.ShippingAddress == null ||
                 this.ShippingAddress?.Equals(other.ShippingAddress) == true) &&
                (this.ShippingOption == null && other.ShippingOption == null ||
                 this.ShippingOption?.Equals(other.ShippingOption) == true) &&
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
            toStringOutput.Add($"ShippingAddress = {(this.ShippingAddress == null ? "null" : this.ShippingAddress.ToString())}");
            toStringOutput.Add($"ShippingOption = {(this.ShippingOption == null ? "null" : this.ShippingOption.ToString())}");
            toStringOutput.Add($"PurchaseUnits = {(this.PurchaseUnits == null ? "null" : $"[{string.Join(", ", this.PurchaseUnits)} ]")}");
        }
    }
}