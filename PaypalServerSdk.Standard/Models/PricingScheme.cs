// <copyright file="PricingScheme.cs" company="APIMatic">
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
    /// PricingScheme.
    /// </summary>
    public class PricingScheme
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricingScheme"/> class.
        /// </summary>
        public PricingScheme()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingScheme"/> class.
        /// </summary>
        /// <param name="pricingModel">pricing_model.</param>
        /// <param name="price">price.</param>
        /// <param name="reloadThresholdAmount">reload_threshold_amount.</param>
        public PricingScheme(
            Models.PricingModel pricingModel,
            Models.Money price = null,
            Models.Money reloadThresholdAmount = null)
        {
            this.Price = price;
            this.PricingModel = pricingModel;
            this.ReloadThresholdAmount = reloadThresholdAmount;
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Price { get; set; }

        /// <summary>
        /// The pricing model for the billing cycle.
        /// </summary>
        [JsonProperty("pricing_model")]
        public Models.PricingModel PricingModel { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("reload_threshold_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money ReloadThresholdAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PricingScheme : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PricingScheme other &&
                (this.Price == null && other.Price == null ||
                 this.Price?.Equals(other.Price) == true) &&
                (this.PricingModel.Equals(other.PricingModel)) &&
                (this.ReloadThresholdAmount == null && other.ReloadThresholdAmount == null ||
                 this.ReloadThresholdAmount?.Equals(other.ReloadThresholdAmount) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"PricingModel = {this.PricingModel}");
            toStringOutput.Add($"ReloadThresholdAmount = {(this.ReloadThresholdAmount == null ? "null" : this.ReloadThresholdAmount.ToString())}");
        }
    }
}