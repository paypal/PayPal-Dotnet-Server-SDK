// <copyright file="ExchangeRate.cs" company="APIMatic">
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
using PayPalRESTAPIs.Standard;
using PayPalRESTAPIs.Standard.Utilities;

namespace PayPalRESTAPIs.Standard.Models
{
    /// <summary>
    /// ExchangeRate.
    /// </summary>
    public class ExchangeRate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRate"/> class.
        /// </summary>
        public ExchangeRate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRate"/> class.
        /// </summary>
        /// <param name="sourceCurrency">source_currency.</param>
        /// <param name="targetCurrency">target_currency.</param>
        /// <param name="mValue">value.</param>
        public ExchangeRate(
            string sourceCurrency = null,
            string targetCurrency = null,
            string mValue = null)
        {
            this.SourceCurrency = sourceCurrency;
            this.TargetCurrency = targetCurrency;
            this.MValue = mValue;
        }

        /// <summary>
        /// The [three-character ISO-4217 currency code](/api/rest/reference/currency-codes/) that identifies the currency.
        /// </summary>
        [JsonProperty("source_currency", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// The [three-character ISO-4217 currency code](/api/rest/reference/currency-codes/) that identifies the currency.
        /// </summary>
        [JsonProperty("target_currency", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetCurrency { get; set; }

        /// <summary>
        /// The target currency amount. Equivalent to one unit of the source currency. Formatted as integer or decimal value with one to 15 digits to the right of the decimal point.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExchangeRate : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExchangeRate other &&                ((this.SourceCurrency == null && other.SourceCurrency == null) || (this.SourceCurrency?.Equals(other.SourceCurrency) == true)) &&
                ((this.TargetCurrency == null && other.TargetCurrency == null) || (this.TargetCurrency?.Equals(other.TargetCurrency) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SourceCurrency = {(this.SourceCurrency == null ? "null" : this.SourceCurrency)}");
            toStringOutput.Add($"this.TargetCurrency = {(this.TargetCurrency == null ? "null" : this.TargetCurrency)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue)}");
        }
    }
}