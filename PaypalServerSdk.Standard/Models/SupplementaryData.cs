// <copyright file="SupplementaryData.cs" company="APIMatic">
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
    /// SupplementaryData.
    /// </summary>
    public class SupplementaryData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupplementaryData"/> class.
        /// </summary>
        public SupplementaryData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupplementaryData"/> class.
        /// </summary>
        /// <param name="card">card.</param>
        /// <param name="risk">risk.</param>
        public SupplementaryData(
            Models.CardSupplementaryData card = null,
            Models.RiskSupplementaryData risk = null)
        {
            this.Card = card;
            this.Risk = risk;
        }

        /// <summary>
        /// Merchants and partners can add Level 2 and 3 data to payments to reduce risk and payment processing costs. For more information about processing payments, see checkout or multiparty checkout.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardSupplementaryData Card { get; set; }

        /// <summary>
        /// Additional information necessary to evaluate the risk profile of a transaction.
        /// </summary>
        [JsonProperty("risk", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RiskSupplementaryData Risk { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SupplementaryData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SupplementaryData other &&
                (this.Card == null && other.Card == null ||
                 this.Card?.Equals(other.Card) == true) &&
                (this.Risk == null && other.Risk == null ||
                 this.Risk?.Equals(other.Risk) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"Risk = {(this.Risk == null ? "null" : this.Risk.ToString())}");
        }
    }
}