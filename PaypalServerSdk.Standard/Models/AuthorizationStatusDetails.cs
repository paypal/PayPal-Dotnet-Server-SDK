// <copyright file="AuthorizationStatusDetails.cs" company="APIMatic">
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
    /// AuthorizationStatusDetails.
    /// </summary>
    public class AuthorizationStatusDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationStatusDetails"/> class.
        /// </summary>
        public AuthorizationStatusDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationStatusDetails"/> class.
        /// </summary>
        /// <param name="reason">reason.</param>
        public AuthorizationStatusDetails(
            Models.AuthorizationIncompleteReason? reason = null)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// The reason why the authorized status is `PENDING`.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AuthorizationIncompleteReason? Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AuthorizationStatusDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is AuthorizationStatusDetails other &&                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true));
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