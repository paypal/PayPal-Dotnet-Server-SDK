// <copyright file="ListCustomerPaymentTokensInput.cs" company="APIMatic">
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
    /// ListCustomerPaymentTokensInput.
    /// </summary>
    public class ListCustomerPaymentTokensInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCustomerPaymentTokensInput"/> class.
        /// </summary>
        public ListCustomerPaymentTokensInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCustomerPaymentTokensInput"/> class.
        /// </summary>
        /// <param name="customerId">customer_id.</param>
        /// <param name="pageSize">page_size.</param>
        /// <param name="page">page.</param>
        /// <param name="totalRequired">total_required.</param>
        public ListCustomerPaymentTokensInput(
            string customerId,
            int? pageSize = 5,
            int? page = 1,
            bool? totalRequired = false)
        {
            this.CustomerId = customerId;
            this.PageSize = pageSize;
            this.Page = page;
            this.TotalRequired = totalRequired;
        }

        /// <summary>
        /// A unique identifier representing a specific customer in merchant's/partner's system or records.
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// A non-negative, non-zero integer indicating the maximum number of results to return at one time.
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// A non-negative, non-zero integer representing the page of the results.
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// A boolean indicating total number of items (total_items) and pages (total_pages) are expected to be returned in the response.
        /// </summary>
        [JsonProperty("total_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TotalRequired { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListCustomerPaymentTokensInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListCustomerPaymentTokensInput other &&
                (this.CustomerId == null && other.CustomerId == null ||
                 this.CustomerId?.Equals(other.CustomerId) == true) &&
                (this.PageSize == null && other.PageSize == null ||
                 this.PageSize?.Equals(other.PageSize) == true) &&
                (this.Page == null && other.Page == null ||
                 this.Page?.Equals(other.Page) == true) &&
                (this.TotalRequired == null && other.TotalRequired == null ||
                 this.TotalRequired?.Equals(other.TotalRequired) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CustomerId = {this.CustomerId ?? "null"}");
            toStringOutput.Add($"PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
            toStringOutput.Add($"Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"TotalRequired = {(this.TotalRequired == null ? "null" : this.TotalRequired.ToString())}");
        }
    }
}