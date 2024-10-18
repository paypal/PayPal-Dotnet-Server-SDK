// <copyright file="CustomerVaultPaymentTokensResponse.cs" company="APIMatic">
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
    /// CustomerVaultPaymentTokensResponse.
    /// </summary>
    public class CustomerVaultPaymentTokensResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerVaultPaymentTokensResponse"/> class.
        /// </summary>
        public CustomerVaultPaymentTokensResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerVaultPaymentTokensResponse"/> class.
        /// </summary>
        /// <param name="totalItems">total_items.</param>
        /// <param name="totalPages">total_pages.</param>
        /// <param name="customer">customer.</param>
        /// <param name="paymentTokens">payment_tokens.</param>
        /// <param name="links">links.</param>
        public CustomerVaultPaymentTokensResponse(
            int? totalItems = null,
            int? totalPages = null,
            Models.CustomerRequest customer = null,
            List<Models.PaymentTokenResponse> paymentTokens = null,
            List<Models.LinkDescription> links = null)
        {
            this.TotalItems = totalItems;
            this.TotalPages = totalPages;
            this.Customer = customer;
            this.PaymentTokens = paymentTokens;
            this.Links = links;
        }

        /// <summary>
        /// Total number of items.
        /// </summary>
        [JsonProperty("total_items", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// Total number of pages.
        /// </summary>
        [JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Customer in merchant's or partner's system of records.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerRequest Customer { get; set; }

        /// <summary>
        /// Gets or sets PaymentTokens.
        /// </summary>
        [JsonProperty("payment_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PaymentTokenResponse> PaymentTokens { get; set; }

        /// <summary>
        /// An array of related [HATEOAS links](/api/rest/responses/#hateoas).
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LinkDescription> Links { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomerVaultPaymentTokensResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CustomerVaultPaymentTokensResponse other &&                ((this.TotalItems == null && other.TotalItems == null) || (this.TotalItems?.Equals(other.TotalItems) == true)) &&
                ((this.TotalPages == null && other.TotalPages == null) || (this.TotalPages?.Equals(other.TotalPages) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.PaymentTokens == null && other.PaymentTokens == null) || (this.PaymentTokens?.Equals(other.PaymentTokens) == true)) &&
                ((this.Links == null && other.Links == null) || (this.Links?.Equals(other.Links) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TotalItems = {(this.TotalItems == null ? "null" : this.TotalItems.ToString())}");
            toStringOutput.Add($"this.TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.PaymentTokens = {(this.PaymentTokens == null ? "null" : $"[{string.Join(", ", this.PaymentTokens)} ]")}");
            toStringOutput.Add($"this.Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
        }
    }
}