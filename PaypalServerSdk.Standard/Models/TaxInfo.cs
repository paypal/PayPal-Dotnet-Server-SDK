// <copyright file="TaxInfo.cs" company="APIMatic">
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
    /// TaxInfo.
    /// </summary>
    public class TaxInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxInfo"/> class.
        /// </summary>
        public TaxInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxInfo"/> class.
        /// </summary>
        /// <param name="taxId">tax_id.</param>
        /// <param name="taxIdType">tax_id_type.</param>
        public TaxInfo(
            string taxId,
            Models.TaxIdType taxIdType)
        {
            this.TaxId = taxId;
            this.TaxIdType = taxIdType;
        }

        /// <summary>
        /// The customer's tax ID value.
        /// </summary>
        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        /// <summary>
        /// The customer's tax ID type.
        /// </summary>
        [JsonProperty("tax_id_type")]
        public Models.TaxIdType TaxIdType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TaxInfo : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is TaxInfo other &&
                (this.TaxId == null && other.TaxId == null ||
                 this.TaxId?.Equals(other.TaxId) == true) &&
                (this.TaxIdType.Equals(other.TaxIdType));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TaxId = {this.TaxId ?? "null"}");
            toStringOutput.Add($"TaxIdType = {this.TaxIdType}");
        }
    }
}