// <copyright file="OrderBillingPlan.cs" company="APIMatic">
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
    /// OrderBillingPlan.
    /// </summary>
    public class OrderBillingPlan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBillingPlan"/> class.
        /// </summary>
        public OrderBillingPlan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBillingPlan"/> class.
        /// </summary>
        /// <param name="billingCycles">billing_cycles.</param>
        /// <param name="setupFee">setup_fee.</param>
        /// <param name="name">name.</param>
        public OrderBillingPlan(
            List<Models.BillingCycle> billingCycles,
            Models.Money setupFee = null,
            string name = null)
        {
            this.BillingCycles = billingCycles;
            this.SetupFee = setupFee;
            this.Name = name;
        }

        /// <summary>
        /// An array of billing cycles for trial billing and regular billing. A plan can have at most two trial cycles and only one regular cycle.
        /// </summary>
        [JsonProperty("billing_cycles")]
        public List<Models.BillingCycle> BillingCycles { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("setup_fee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money SetupFee { get; set; }

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
            return $"OrderBillingPlan : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderBillingPlan other &&
                (this.BillingCycles == null && other.BillingCycles == null ||
                 this.BillingCycles?.Equals(other.BillingCycles) == true) &&
                (this.SetupFee == null && other.SetupFee == null ||
                 this.SetupFee?.Equals(other.SetupFee) == true) &&
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
            toStringOutput.Add($"SetupFee = {(this.SetupFee == null ? "null" : this.SetupFee.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
        }
    }
}