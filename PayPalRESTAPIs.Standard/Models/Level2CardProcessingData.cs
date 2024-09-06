// <copyright file="Level2CardProcessingData.cs" company="APIMatic">
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
    /// Level2CardProcessingData.
    /// </summary>
    public class Level2CardProcessingData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Level2CardProcessingData"/> class.
        /// </summary>
        public Level2CardProcessingData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Level2CardProcessingData"/> class.
        /// </summary>
        /// <param name="invoiceId">invoice_id.</param>
        /// <param name="taxTotal">tax_total.</param>
        public Level2CardProcessingData(
            string invoiceId = null,
            Models.Money taxTotal = null)
        {
            this.InvoiceId = invoiceId;
            this.TaxTotal = taxTotal;
        }

        /// <summary>
        /// Use this field to pass a purchase identification value of up to 12 ASCII characters for AIB and 17 ASCII characters for all other processors.
        /// </summary>
        [JsonProperty("invoice_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("tax_total", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money TaxTotal { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Level2CardProcessingData : ({string.Join(", ", toStringOutput)})";
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
            return obj is Level2CardProcessingData other &&                ((this.InvoiceId == null && other.InvoiceId == null) || (this.InvoiceId?.Equals(other.InvoiceId) == true)) &&
                ((this.TaxTotal == null && other.TaxTotal == null) || (this.TaxTotal?.Equals(other.TaxTotal) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InvoiceId = {(this.InvoiceId == null ? "null" : this.InvoiceId)}");
            toStringOutput.Add($"this.TaxTotal = {(this.TaxTotal == null ? "null" : this.TaxTotal.ToString())}");
        }
    }
}