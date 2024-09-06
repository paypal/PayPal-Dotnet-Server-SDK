// <copyright file="ACHDebitResponse.cs" company="APIMatic">
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
    /// ACHDebitResponse.
    /// </summary>
    public class ACHDebitResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ACHDebitResponse"/> class.
        /// </summary>
        public ACHDebitResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ACHDebitResponse"/> class.
        /// </summary>
        /// <param name="verificationStatus">verification_status.</param>
        public ACHDebitResponse(
            string verificationStatus = "NOT_VERIFIED")
        {
            this.VerificationStatus = verificationStatus;
        }

        /// <summary>
        /// The ach debit verification status.
        /// </summary>
        [JsonProperty("verification_status", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationStatus { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ACHDebitResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ACHDebitResponse other &&                ((this.VerificationStatus == null && other.VerificationStatus == null) || (this.VerificationStatus?.Equals(other.VerificationStatus) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.VerificationStatus = {(this.VerificationStatus == null ? "null" : this.VerificationStatus)}");
        }
    }
}