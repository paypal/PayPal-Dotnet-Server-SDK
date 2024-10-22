// <copyright file="AuthenticationResponse.cs" company="APIMatic">
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
    /// AuthenticationResponse.
    /// </summary>
    public class AuthenticationResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationResponse"/> class.
        /// </summary>
        public AuthenticationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationResponse"/> class.
        /// </summary>
        /// <param name="liabilityShift">liability_shift.</param>
        /// <param name="threeDSecure">three_d_secure.</param>
        public AuthenticationResponse(
            Models.LiabilityShiftIndicator? liabilityShift = null,
            Models.ThreeDSecureAuthenticationResponse threeDSecure = null)
        {
            this.LiabilityShift = liabilityShift;
            this.ThreeDSecure = threeDSecure;
        }

        /// <summary>
        /// Liability shift indicator. The outcome of the issuer's authentication.
        /// </summary>
        [JsonProperty("liability_shift", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LiabilityShiftIndicator? LiabilityShift { get; set; }

        /// <summary>
        /// Results of 3D Secure Authentication.
        /// </summary>
        [JsonProperty("three_d_secure", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDSecureAuthenticationResponse ThreeDSecure { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AuthenticationResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is AuthenticationResponse other &&                ((this.LiabilityShift == null && other.LiabilityShift == null) || (this.LiabilityShift?.Equals(other.LiabilityShift) == true)) &&
                ((this.ThreeDSecure == null && other.ThreeDSecure == null) || (this.ThreeDSecure?.Equals(other.ThreeDSecure) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LiabilityShift = {(this.LiabilityShift == null ? "null" : this.LiabilityShift.ToString())}");
            toStringOutput.Add($"this.ThreeDSecure = {(this.ThreeDSecure == null ? "null" : this.ThreeDSecure.ToString())}");
        }
    }
}