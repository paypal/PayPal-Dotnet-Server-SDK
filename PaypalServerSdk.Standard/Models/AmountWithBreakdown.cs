// <copyright file="AmountWithBreakdown.cs" company="APIMatic">
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
using PaypalServerSDK.Standard;
using PaypalServerSDK.Standard.Utilities;

namespace PaypalServerSDK.Standard.Models
{
    /// <summary>
    /// AmountWithBreakdown.
    /// </summary>
    public class AmountWithBreakdown
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmountWithBreakdown"/> class.
        /// </summary>
        public AmountWithBreakdown()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmountWithBreakdown"/> class.
        /// </summary>
        /// <param name="currencyCode">currency_code.</param>
        /// <param name="mValue">value.</param>
        /// <param name="breakdown">breakdown.</param>
        public AmountWithBreakdown(
            string currencyCode,
            string mValue,
            Models.AmountBreakdown breakdown = null)
        {
            this.CurrencyCode = currencyCode;
            this.MValue = mValue;
            this.Breakdown = breakdown;
        }

        /// <summary>
        /// The [three-character ISO-4217 currency code](/api/rest/reference/currency-codes/) that identifies the currency.
        /// </summary>
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The value, which might be:<ul><li>An integer for currencies like `JPY` that are not typically fractional.</li><li>A decimal fraction for currencies like `TND` that are subdivided into thousandths.</li></ul>For the required number of decimal places for a currency code, see [Currency Codes](/api/rest/reference/currency-codes/).
        /// </summary>
        [JsonProperty("value")]
        public string MValue { get; set; }

        /// <summary>
        /// The breakdown of the amount. Breakdown provides details such as total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.
        /// </summary>
        [JsonProperty("breakdown", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AmountBreakdown Breakdown { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AmountWithBreakdown : ({string.Join(", ", toStringOutput)})";
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
            return obj is AmountWithBreakdown other &&                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.Breakdown == null && other.Breakdown == null) || (this.Breakdown?.Equals(other.Breakdown) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue)}");
            toStringOutput.Add($"this.Breakdown = {(this.Breakdown == null ? "null" : this.Breakdown.ToString())}");
        }
    }
}