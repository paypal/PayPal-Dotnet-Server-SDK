// <copyright file="AuthorizationStatusWithDetails.cs" company="APIMatic">
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
using PaypalServerSDK.Standard;
using PaypalServerSDK.Standard.Utilities;

namespace PaypalServerSDK.Standard.Models
{
    /// <summary>
    /// AuthorizationStatusWithDetails.
    /// </summary>
    public class AuthorizationStatusWithDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationStatusWithDetails"/> class.
        /// </summary>
        public AuthorizationStatusWithDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationStatusWithDetails"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="statusDetails">status_details.</param>
        public AuthorizationStatusWithDetails(
            Models.AuthorizationStatus? status = null,
            Models.AuthorizationStatusDetails statusDetails = null)
        {
            this.Status = status;
            this.StatusDetails = statusDetails;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AuthorizationStatusWithDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is AuthorizationStatusWithDetails other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.StatusDetails == null && other.StatusDetails == null) || (this.StatusDetails?.Equals(other.StatusDetails) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusDetails = {(this.StatusDetails == null ? "null" : this.StatusDetails.ToString())}");
        }
    }
}