// <copyright file="RefundStatusWithDetails.cs" company="APIMatic">
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
    /// RefundStatusWithDetails.
    /// </summary>
    public class RefundStatusWithDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundStatusWithDetails"/> class.
        /// </summary>
        public RefundStatusWithDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundStatusWithDetails"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="statusDetails">status_details.</param>
        public RefundStatusWithDetails(
            Models.RefundStatus? status = null,
            Models.RefundStatusDetails statusDetails = null)
        {
            this.Status = status;
            this.StatusDetails = statusDetails;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RefundStatusWithDetails : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RefundStatusWithDetails other &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.StatusDetails == null && other.StatusDetails == null ||
                 this.StatusDetails?.Equals(other.StatusDetails) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"StatusDetails = {(this.StatusDetails == null ? "null" : this.StatusDetails.ToString())}");
        }
    }
}