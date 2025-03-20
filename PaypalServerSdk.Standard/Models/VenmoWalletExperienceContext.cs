// <copyright file="VenmoWalletExperienceContext.cs" company="APIMatic">
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
    /// VenmoWalletExperienceContext.
    /// </summary>
    public class VenmoWalletExperienceContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VenmoWalletExperienceContext"/> class.
        /// </summary>
        public VenmoWalletExperienceContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VenmoWalletExperienceContext"/> class.
        /// </summary>
        /// <param name="brandName">brand_name.</param>
        /// <param name="shippingPreference">shipping_preference.</param>
        /// <param name="orderUpdateCallbackConfig">order_update_callback_config.</param>
        public VenmoWalletExperienceContext(
            string brandName = null,
            Models.ShippingPreference? shippingPreference = Models.ShippingPreference.GetFromFile,
            Models.CallbackConfiguration orderUpdateCallbackConfig = null)
        {
            this.BrandName = brandName;
            this.ShippingPreference = shippingPreference;
            this.OrderUpdateCallbackConfig = orderUpdateCallbackConfig;
        }

        /// <summary>
        /// The business name of the merchant. The pattern is defined by an external party and supports Unicode.
        /// </summary>
        [JsonProperty("brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandName { get; set; }

        /// <summary>
        /// The location from which the shipping address is derived.
        /// </summary>
        [JsonProperty("shipping_preference", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShippingPreference? ShippingPreference { get; set; }

        /// <summary>
        /// CallBack Configuration that the merchant can provide to PayPal/Venmo.
        /// </summary>
        [JsonProperty("order_update_callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CallbackConfiguration OrderUpdateCallbackConfig { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"VenmoWalletExperienceContext : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is VenmoWalletExperienceContext other &&
                (this.BrandName == null && other.BrandName == null ||
                 this.BrandName?.Equals(other.BrandName) == true) &&
                (this.ShippingPreference == null && other.ShippingPreference == null ||
                 this.ShippingPreference?.Equals(other.ShippingPreference) == true) &&
                (this.OrderUpdateCallbackConfig == null && other.OrderUpdateCallbackConfig == null ||
                 this.OrderUpdateCallbackConfig?.Equals(other.OrderUpdateCallbackConfig) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"BrandName = {this.BrandName ?? "null"}");
            toStringOutput.Add($"ShippingPreference = {(this.ShippingPreference == null ? "null" : this.ShippingPreference.ToString())}");
            toStringOutput.Add($"OrderUpdateCallbackConfig = {(this.OrderUpdateCallbackConfig == null ? "null" : this.OrderUpdateCallbackConfig.ToString())}");
        }
    }
}