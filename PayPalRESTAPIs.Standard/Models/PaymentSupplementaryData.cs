// <copyright file="PaymentSupplementaryData.cs" company="APIMatic">
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
    /// PaymentSupplementaryData.
    /// </summary>
    public class PaymentSupplementaryData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSupplementaryData"/> class.
        /// </summary>
        public PaymentSupplementaryData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSupplementaryData"/> class.
        /// </summary>
        /// <param name="relatedIds">related_ids.</param>
        public PaymentSupplementaryData(
            Models.RelatedIdentifiers relatedIds = null)
        {
            this.RelatedIds = relatedIds;
        }

        /// <summary>
        /// Identifiers related to a specific resource.
        /// </summary>
        [JsonProperty("related_ids", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelatedIdentifiers RelatedIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentSupplementaryData : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentSupplementaryData other &&                ((this.RelatedIds == null && other.RelatedIds == null) || (this.RelatedIds?.Equals(other.RelatedIds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RelatedIds = {(this.RelatedIds == null ? "null" : this.RelatedIds.ToString())}");
        }
    }
}