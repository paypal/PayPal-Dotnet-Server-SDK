// <copyright file="CardAuthenticationResponse.cs" company="APIMatic">
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
    /// CardAuthenticationResponse.
    /// </summary>
    public class CardAuthenticationResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardAuthenticationResponse"/> class.
        /// </summary>
        public CardAuthenticationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardAuthenticationResponse"/> class.
        /// </summary>
        /// <param name="threeDSecure">three_d_secure.</param>
        public CardAuthenticationResponse(
            Models.ThreeDSecureAuthenticationResponse threeDSecure = null)
        {
            this.ThreeDSecure = threeDSecure;
        }

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

            return $"CardAuthenticationResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardAuthenticationResponse other &&                ((this.ThreeDSecure == null && other.ThreeDSecure == null) || (this.ThreeDSecure?.Equals(other.ThreeDSecure) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ThreeDSecure = {(this.ThreeDSecure == null ? "null" : this.ThreeDSecure.ToString())}");
        }
    }
}