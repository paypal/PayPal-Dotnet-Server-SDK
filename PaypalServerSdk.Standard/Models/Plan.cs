// <copyright file="Plan.cs" company="APIMatic">
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
    /// Plan.
    /// </summary>
    public class Plan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Plan"/> class.
        /// </summary>
        public Plan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plan"/> class.
        /// </summary>
        /// <param name="billingCycles">billing_cycles.</param>
        /// <param name="oneTimeCharges">one_time_charges.</param>
        /// <param name="product">product.</param>
        /// <param name="name">name.</param>
        public Plan(
            List<Models.BillingCycle> billingCycles,
            Models.OneTimeCharge oneTimeCharges,
            JsonValue product = null,
            string name = null)
        {
            this.BillingCycles = billingCycles;
            this.Product = product;
            this.OneTimeCharges = oneTimeCharges;
            this.Name = name;
        }

        /// <summary>
        /// An array of billing cycles for trial billing and regular billing. A plan can have at most two trial cycles and only one regular cycle.
        /// </summary>
        [JsonProperty("billing_cycles")]
        public List<Models.BillingCycle> BillingCycles { get; set; }

        /// <summary>
        /// Product details associated with any one-time product purchase.
        /// </summary>
        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public JsonValue Product { get; set; }

        /// <summary>
        /// The one-time charge info at the time of checkout.
        /// </summary>
        [JsonProperty("one_time_charges")]
        public Models.OneTimeCharge OneTimeCharges { get; set; }

        /// <summary>
        /// Name of the recurring plan.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Plan : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Plan other &&
                (this.BillingCycles == null && other.BillingCycles == null ||
                 this.BillingCycles?.Equals(other.BillingCycles) == true) &&
                (this.Product == null && other.Product == null ||
                 this.Product?.Equals(other.Product) == true) &&
                (this.OneTimeCharges == null && other.OneTimeCharges == null ||
                 this.OneTimeCharges?.Equals(other.OneTimeCharges) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"BillingCycles = {(this.BillingCycles == null ? "null" : $"[{string.Join(", ", this.BillingCycles)} ]")}");
            toStringOutput.Add($"Product = {(this.Product == null ? "null" : this.Product.ToString())}");
            toStringOutput.Add($"OneTimeCharges = {(this.OneTimeCharges == null ? "null" : this.OneTimeCharges.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
        }
    }
}