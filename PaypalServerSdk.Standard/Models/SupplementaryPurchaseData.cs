// <copyright file="SupplementaryPurchaseData.cs" company="APIMatic">
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
    /// SupplementaryPurchaseData.
    /// </summary>
    public class SupplementaryPurchaseData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupplementaryPurchaseData"/> class.
        /// </summary>
        public SupplementaryPurchaseData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupplementaryPurchaseData"/> class.
        /// </summary>
        /// <param name="invoiceId">invoice_id.</param>
        /// <param name="noteToPayer">note_to_payer.</param>
        public SupplementaryPurchaseData(
            string invoiceId = null,
            string noteToPayer = null)
        {
            this.InvoiceId = invoiceId;
            this.NoteToPayer = noteToPayer;
        }

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [JsonProperty("invoice_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// An informational note about this settlement. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [JsonProperty("note_to_payer", NullValueHandling = NullValueHandling.Ignore)]
        public string NoteToPayer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SupplementaryPurchaseData : ({string.Join(", ", toStringOutput)})";
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
            return obj is SupplementaryPurchaseData other &&                ((this.InvoiceId == null && other.InvoiceId == null) || (this.InvoiceId?.Equals(other.InvoiceId) == true)) &&
                ((this.NoteToPayer == null && other.NoteToPayer == null) || (this.NoteToPayer?.Equals(other.NoteToPayer) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InvoiceId = {(this.InvoiceId == null ? "null" : this.InvoiceId)}");
            toStringOutput.Add($"this.NoteToPayer = {(this.NoteToPayer == null ? "null" : this.NoteToPayer)}");
        }
    }
}