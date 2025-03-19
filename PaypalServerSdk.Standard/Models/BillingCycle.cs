// <copyright file="BillingCycle.cs" company="APIMatic">
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
    /// BillingCycle.
    /// </summary>
    public class BillingCycle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCycle"/> class.
        /// </summary>
        public BillingCycle()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCycle"/> class.
        /// </summary>
        /// <param name="tenureType">tenure_type.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="frequency">frequency.</param>
        /// <param name="totalCycles">total_cycles.</param>
        /// <param name="sequence">sequence.</param>
        /// <param name="startDate">start_date.</param>
        public BillingCycle(
            Models.TenureType tenureType,
            Models.PricingScheme pricingScheme = null,
            JsonValue frequency = null,
            int? totalCycles = 1,
            int? sequence = 1,
            string startDate = null)
        {
            this.TenureType = tenureType;
            this.PricingScheme = pricingScheme;
            this.Frequency = frequency;
            this.TotalCycles = totalCycles;
            this.Sequence = sequence;
            this.StartDate = startDate;
        }

        /// <summary>
        /// The tenure type of the billing cycle identifies if the billing cycle is a trial(free or discounted) or regular billing cycle.
        /// </summary>
        [JsonProperty("tenure_type")]
        public Models.TenureType TenureType { get; set; }

        /// <summary>
        /// The pricing scheme details.
        /// </summary>
        [JsonProperty("pricing_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricingScheme PricingScheme { get; set; }

        /// <summary>
        /// The frequency details for this billing cycle.
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public JsonValue Frequency { get; set; }

        /// <summary>
        /// The number of times this billing cycle gets executed. Trial billing cycles can only be executed a finite number of times (value between 1 and 999 for total_cycles). Regular billing cycles can be executed infinite times (value of 0 for total_cycles) or a finite number of times (value between 1 and 999 for total_cycles).
        /// </summary>
        [JsonProperty("total_cycles", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCycles { get; set; }

        /// <summary>
        /// The order in which this cycle is to run among other billing cycles. For example, a trial billing cycle has a `sequence` of `1` while a regular billing cycle has a `sequence` of `2`, so that trial cycle runs before the regular cycle.
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; }

        /// <summary>
        /// The stand-alone date, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). To represent special legal values, such as a date of birth, you should use dates with no associated time or time-zone data. Whenever possible, use the standard `date_time` type. This regular expression does not validate all dates. For example, February 31 is valid and nothing is known about leap years.
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BillingCycle : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BillingCycle other &&
                (this.TenureType.Equals(other.TenureType)) &&
                (this.PricingScheme == null && other.PricingScheme == null ||
                 this.PricingScheme?.Equals(other.PricingScheme) == true) &&
                (this.Frequency == null && other.Frequency == null ||
                 this.Frequency?.Equals(other.Frequency) == true) &&
                (this.TotalCycles == null && other.TotalCycles == null ||
                 this.TotalCycles?.Equals(other.TotalCycles) == true) &&
                (this.Sequence == null && other.Sequence == null ||
                 this.Sequence?.Equals(other.Sequence) == true) &&
                (this.StartDate == null && other.StartDate == null ||
                 this.StartDate?.Equals(other.StartDate) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TenureType = {this.TenureType}");
            toStringOutput.Add($"PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"Frequency = {(this.Frequency == null ? "null" : this.Frequency.ToString())}");
            toStringOutput.Add($"TotalCycles = {(this.TotalCycles == null ? "null" : this.TotalCycles.ToString())}");
            toStringOutput.Add($"Sequence = {(this.Sequence == null ? "null" : this.Sequence.ToString())}");
            toStringOutput.Add($"StartDate = {this.StartDate ?? "null"}");
        }
    }
}