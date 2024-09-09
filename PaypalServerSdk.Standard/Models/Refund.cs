// <copyright file="Refund.cs" company="APIMatic">
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
    /// Refund.
    /// </summary>
    public class Refund
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Refund"/> class.
        /// </summary>
        public Refund()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Refund"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="statusDetails">status_details.</param>
        /// <param name="id">id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="invoiceId">invoice_id.</param>
        /// <param name="customId">custom_id.</param>
        /// <param name="acquirerReferenceNumber">acquirer_reference_number.</param>
        /// <param name="noteToPayer">note_to_payer.</param>
        /// <param name="sellerPayableBreakdown">seller_payable_breakdown.</param>
        /// <param name="payer">payer.</param>
        /// <param name="links">links.</param>
        /// <param name="createTime">create_time.</param>
        /// <param name="updateTime">update_time.</param>
        public Refund(
            Models.RefundStatus? status = null,
            Models.RefundStatusDetails statusDetails = null,
            string id = null,
            Models.Money amount = null,
            string invoiceId = null,
            string customId = null,
            string acquirerReferenceNumber = null,
            string noteToPayer = null,
            Models.SellerPayableBreakdown sellerPayableBreakdown = null,
            Models.PayeeBase payer = null,
            List<Models.LinkDescription> links = null,
            string createTime = null,
            string updateTime = null)
        {
            this.Status = status;
            this.StatusDetails = statusDetails;
            this.Id = id;
            this.Amount = amount;
            this.InvoiceId = invoiceId;
            this.CustomId = customId;
            this.AcquirerReferenceNumber = acquirerReferenceNumber;
            this.NoteToPayer = noteToPayer;
            this.SellerPayableBreakdown = sellerPayableBreakdown;
            this.Payer = payer;
            this.Links = links;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// The status of the refund.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RefundStatus? Status { get; set; }

        /// <summary>
        /// The details of the refund status.
        /// </summary>
        [JsonProperty("status_details", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RefundStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// The PayPal-generated ID for the refund.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Amount { get; set; }

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [JsonProperty("invoice_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// The API caller-provided external ID. Used to reconcile API caller-initiated transactions with PayPal transactions. Appears in transaction and settlement reports.
        /// </summary>
        [JsonProperty("custom_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomId { get; set; }

        /// <summary>
        /// Reference ID issued for the card transaction. This ID can be used to track the transaction across processors, card brands and issuing banks.
        /// </summary>
        [JsonProperty("acquirer_reference_number", NullValueHandling = NullValueHandling.Ignore)]
        public string AcquirerReferenceNumber { get; set; }

        /// <summary>
        /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [JsonProperty("note_to_payer", NullValueHandling = NullValueHandling.Ignore)]
        public string NoteToPayer { get; set; }

        /// <summary>
        /// The breakdown of the refund.
        /// </summary>
        [JsonProperty("seller_payable_breakdown", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SellerPayableBreakdown SellerPayableBreakdown { get; set; }

        /// <summary>
        /// The details for the merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
        /// </summary>
        [JsonProperty("payer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayeeBase Payer { get; set; }

        /// <summary>
        /// An array of related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links).
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LinkDescription> Links { get; set; }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Refund : ({string.Join(", ", toStringOutput)})";
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
            return obj is Refund other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.StatusDetails == null && other.StatusDetails == null) || (this.StatusDetails?.Equals(other.StatusDetails) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.InvoiceId == null && other.InvoiceId == null) || (this.InvoiceId?.Equals(other.InvoiceId) == true)) &&
                ((this.CustomId == null && other.CustomId == null) || (this.CustomId?.Equals(other.CustomId) == true)) &&
                ((this.AcquirerReferenceNumber == null && other.AcquirerReferenceNumber == null) || (this.AcquirerReferenceNumber?.Equals(other.AcquirerReferenceNumber) == true)) &&
                ((this.NoteToPayer == null && other.NoteToPayer == null) || (this.NoteToPayer?.Equals(other.NoteToPayer) == true)) &&
                ((this.SellerPayableBreakdown == null && other.SellerPayableBreakdown == null) || (this.SellerPayableBreakdown?.Equals(other.SellerPayableBreakdown) == true)) &&
                ((this.Payer == null && other.Payer == null) || (this.Payer?.Equals(other.Payer) == true)) &&
                ((this.Links == null && other.Links == null) || (this.Links?.Equals(other.Links) == true)) &&
                ((this.CreateTime == null && other.CreateTime == null) || (this.CreateTime?.Equals(other.CreateTime) == true)) &&
                ((this.UpdateTime == null && other.UpdateTime == null) || (this.UpdateTime?.Equals(other.UpdateTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusDetails = {(this.StatusDetails == null ? "null" : this.StatusDetails.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.InvoiceId = {(this.InvoiceId == null ? "null" : this.InvoiceId)}");
            toStringOutput.Add($"this.CustomId = {(this.CustomId == null ? "null" : this.CustomId)}");
            toStringOutput.Add($"this.AcquirerReferenceNumber = {(this.AcquirerReferenceNumber == null ? "null" : this.AcquirerReferenceNumber)}");
            toStringOutput.Add($"this.NoteToPayer = {(this.NoteToPayer == null ? "null" : this.NoteToPayer)}");
            toStringOutput.Add($"this.SellerPayableBreakdown = {(this.SellerPayableBreakdown == null ? "null" : this.SellerPayableBreakdown.ToString())}");
            toStringOutput.Add($"this.Payer = {(this.Payer == null ? "null" : this.Payer.ToString())}");
            toStringOutput.Add($"this.Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"this.CreateTime = {(this.CreateTime == null ? "null" : this.CreateTime)}");
            toStringOutput.Add($"this.UpdateTime = {(this.UpdateTime == null ? "null" : this.UpdateTime)}");
        }
    }
}