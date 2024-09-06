// <copyright file="RefundPaymentInstruction.cs" company="APIMatic">
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
    /// RefundPaymentInstruction.
    /// </summary>
    public class RefundPaymentInstruction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPaymentInstruction"/> class.
        /// </summary>
        public RefundPaymentInstruction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPaymentInstruction"/> class.
        /// </summary>
        /// <param name="platformFees">platform_fees.</param>
        public RefundPaymentInstruction(
            List<Models.RefundPlatformFee> platformFees = null)
        {
            this.PlatformFees = platformFees;
        }

        /// <summary>
        /// Specifies the amount that the API caller will contribute to the refund being processed. The amount needs to be lower than platform_fees amount originally captured or the amount that is remaining if multiple refunds have been processed. This field is only applicable to merchants that have been enabled for PayPal Commerce Platform for Marketplaces and Platforms capability. Please speak to your account manager if you want to use this capability.
        /// </summary>
        [JsonProperty("platform_fees", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RefundPlatformFee> PlatformFees { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RefundPaymentInstruction : ({string.Join(", ", toStringOutput)})";
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
            return obj is RefundPaymentInstruction other &&                ((this.PlatformFees == null && other.PlatformFees == null) || (this.PlatformFees?.Equals(other.PlatformFees) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PlatformFees = {(this.PlatformFees == null ? "null" : $"[{string.Join(", ", this.PlatformFees)} ]")}");
        }
    }
}