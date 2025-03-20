// <copyright file="SellerProtection.cs" company="APIMatic">
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
    /// SellerProtection.
    /// </summary>
    public class SellerProtection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SellerProtection"/> class.
        /// </summary>
        public SellerProtection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SellerProtection"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="disputeCategories">dispute_categories.</param>
        public SellerProtection(
            Models.SellerProtectionStatus? status = null,
            List<Models.DisputeCategory> disputeCategories = null)
        {
            this.Status = status;
            this.DisputeCategories = disputeCategories;
        }

        /// <summary>
        /// Indicates whether the transaction is eligible for seller protection. For information, see [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SellerProtectionStatus? Status { get; set; }

        /// <summary>
        /// An array of conditions that are covered for the transaction.
        /// </summary>
        [JsonProperty("dispute_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DisputeCategory> DisputeCategories { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SellerProtection : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SellerProtection other &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.DisputeCategories == null && other.DisputeCategories == null ||
                 this.DisputeCategories?.Equals(other.DisputeCategories) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"DisputeCategories = {(this.DisputeCategories == null ? "null" : $"[{string.Join(", ", this.DisputeCategories)} ]")}");
        }
    }
}