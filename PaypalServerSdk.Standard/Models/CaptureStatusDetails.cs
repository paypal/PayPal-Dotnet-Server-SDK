// <copyright file="CaptureStatusDetails.cs" company="APIMatic">
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
    /// CaptureStatusDetails.
    /// </summary>
    public class CaptureStatusDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureStatusDetails"/> class.
        /// </summary>
        public CaptureStatusDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureStatusDetails"/> class.
        /// </summary>
        /// <param name="reason">reason.</param>
        public CaptureStatusDetails(
            Models.CaptureIncompleteReason? reason = null)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// The reason why the captured payment status is `PENDING` or `DENIED`.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CaptureIncompleteReason? Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CaptureStatusDetails : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CaptureStatusDetails other &&
                (this.Reason == null && other.Reason == null ||
                 this.Reason?.Equals(other.Reason) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Reason = {(this.Reason == null ? "null" : this.Reason.ToString())}");
        }
    }
}