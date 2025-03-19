// <copyright file="RiskSupplementaryData.cs" company="APIMatic">
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
    /// RiskSupplementaryData.
    /// </summary>
    public class RiskSupplementaryData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskSupplementaryData"/> class.
        /// </summary>
        public RiskSupplementaryData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RiskSupplementaryData"/> class.
        /// </summary>
        /// <param name="customer">customer.</param>
        public RiskSupplementaryData(
            Models.ParticipantMetadata customer = null)
        {
            this.Customer = customer;
        }

        /// <summary>
        /// Profile information of the sender or receiver.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ParticipantMetadata Customer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RiskSupplementaryData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RiskSupplementaryData other &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
        }
    }
}