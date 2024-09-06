// <copyright file="RefundStatusDetails.cs" company="APIMatic">
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
    /// RefundStatusDetails.
    /// </summary>
    public class RefundStatusDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundStatusDetails"/> class.
        /// </summary>
        public RefundStatusDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundStatusDetails"/> class.
        /// </summary>
        /// <param name="reason">reason.</param>
        public RefundStatusDetails(
            Models.RefundIncompleteReason? reason = null)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// The reason why the refund has the `PENDING` or `FAILED` status.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RefundIncompleteReason? Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RefundStatusDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is RefundStatusDetails other &&                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason.ToString())}");
        }
    }
}