// <copyright file="NetAmountBreakdownItem.cs" company="APIMatic">
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
    /// NetAmountBreakdownItem.
    /// </summary>
    public class NetAmountBreakdownItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetAmountBreakdownItem"/> class.
        /// </summary>
        public NetAmountBreakdownItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetAmountBreakdownItem"/> class.
        /// </summary>
        /// <param name="payableAmount">payable_amount.</param>
        /// <param name="convertedAmount">converted_amount.</param>
        /// <param name="exchangeRate">exchange_rate.</param>
        public NetAmountBreakdownItem(
            Models.Money payableAmount = null,
            Models.Money convertedAmount = null,
            Models.ExchangeRate exchangeRate = null)
        {
            this.PayableAmount = payableAmount;
            this.ConvertedAmount = convertedAmount;
            this.ExchangeRate = exchangeRate;
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("payable_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money PayableAmount { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("converted_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money ConvertedAmount { get; set; }

        /// <summary>
        /// The exchange rate that determines the amount to convert from one currency to another currency.
        /// </summary>
        [JsonProperty("exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExchangeRate ExchangeRate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NetAmountBreakdownItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NetAmountBreakdownItem other &&
                (this.PayableAmount == null && other.PayableAmount == null ||
                 this.PayableAmount?.Equals(other.PayableAmount) == true) &&
                (this.ConvertedAmount == null && other.ConvertedAmount == null ||
                 this.ConvertedAmount?.Equals(other.ConvertedAmount) == true) &&
                (this.ExchangeRate == null && other.ExchangeRate == null ||
                 this.ExchangeRate?.Equals(other.ExchangeRate) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PayableAmount = {(this.PayableAmount == null ? "null" : this.PayableAmount.ToString())}");
            toStringOutput.Add($"ConvertedAmount = {(this.ConvertedAmount == null ? "null" : this.ConvertedAmount.ToString())}");
            toStringOutput.Add($"ExchangeRate = {(this.ExchangeRate == null ? "null" : this.ExchangeRate.ToString())}");
        }
    }
}