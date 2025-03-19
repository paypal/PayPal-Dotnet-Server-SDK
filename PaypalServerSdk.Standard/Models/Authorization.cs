// <copyright file="Authorization.cs" company="APIMatic">
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
    /// Authorization.
    /// </summary>
    public class Authorization
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Authorization"/> class.
        /// </summary>
        public Authorization()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Authorization"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="statusDetails">status_details.</param>
        /// <param name="id">id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="invoiceId">invoice_id.</param>
        /// <param name="customId">custom_id.</param>
        /// <param name="networkTransactionReference">network_transaction_reference.</param>
        /// <param name="sellerProtection">seller_protection.</param>
        /// <param name="expirationTime">expiration_time.</param>
        /// <param name="links">links.</param>
        /// <param name="createTime">create_time.</param>
        /// <param name="updateTime">update_time.</param>
        public Authorization(
            Models.AuthorizationStatus? status = null,
            Models.AuthorizationStatusDetails statusDetails = null,
            string id = null,
            Models.Money amount = null,
            string invoiceId = null,
            string customId = null,
            Models.NetworkTransactionReference networkTransactionReference = null,
            Models.SellerProtection sellerProtection = null,
            string expirationTime = null,
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
            this.NetworkTransactionReference = networkTransactionReference;
            this.SellerProtection = sellerProtection;
            this.ExpirationTime = expirationTime;
            this.Links = links;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// The status for the authorized payment.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AuthorizationStatus? Status { get; set; }

        /// <summary>
        /// The details of the authorized payment status.
        /// </summary>
        [JsonProperty("status_details", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AuthorizationStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// The PayPal-generated ID for the authorized payment.
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
        /// Reference values used by the card network to identify a transaction.
        /// </summary>
        [JsonProperty("network_transaction_reference", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NetworkTransactionReference NetworkTransactionReference { get; set; }

        /// <summary>
        /// The level of protection offered as defined by [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
        /// </summary>
        [JsonProperty("seller_protection", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SellerProtection SellerProtection { get; set; }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.
        /// </summary>
        [JsonProperty("expiration_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationTime { get; set; }

        /// <summary>
        /// An array of related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links).
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LinkDescription> Links { get; set; }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Authorization : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Authorization other &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.StatusDetails == null && other.StatusDetails == null ||
                 this.StatusDetails?.Equals(other.StatusDetails) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.InvoiceId == null && other.InvoiceId == null ||
                 this.InvoiceId?.Equals(other.InvoiceId) == true) &&
                (this.CustomId == null && other.CustomId == null ||
                 this.CustomId?.Equals(other.CustomId) == true) &&
                (this.NetworkTransactionReference == null && other.NetworkTransactionReference == null ||
                 this.NetworkTransactionReference?.Equals(other.NetworkTransactionReference) == true) &&
                (this.SellerProtection == null && other.SellerProtection == null ||
                 this.SellerProtection?.Equals(other.SellerProtection) == true) &&
                (this.ExpirationTime == null && other.ExpirationTime == null ||
                 this.ExpirationTime?.Equals(other.ExpirationTime) == true) &&
                (this.Links == null && other.Links == null ||
                 this.Links?.Equals(other.Links) == true) &&
                (this.CreateTime == null && other.CreateTime == null ||
                 this.CreateTime?.Equals(other.CreateTime) == true) &&
                (this.UpdateTime == null && other.UpdateTime == null ||
                 this.UpdateTime?.Equals(other.UpdateTime) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"StatusDetails = {(this.StatusDetails == null ? "null" : this.StatusDetails.ToString())}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"InvoiceId = {this.InvoiceId ?? "null"}");
            toStringOutput.Add($"CustomId = {this.CustomId ?? "null"}");
            toStringOutput.Add($"NetworkTransactionReference = {(this.NetworkTransactionReference == null ? "null" : this.NetworkTransactionReference.ToString())}");
            toStringOutput.Add($"SellerProtection = {(this.SellerProtection == null ? "null" : this.SellerProtection.ToString())}");
            toStringOutput.Add($"ExpirationTime = {this.ExpirationTime ?? "null"}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"CreateTime = {this.CreateTime ?? "null"}");
            toStringOutput.Add($"UpdateTime = {this.UpdateTime ?? "null"}");
        }
    }
}