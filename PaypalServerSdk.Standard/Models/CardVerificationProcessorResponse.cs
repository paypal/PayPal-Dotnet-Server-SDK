// <copyright file="CardVerificationProcessorResponse.cs" company="APIMatic">
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
    /// CardVerificationProcessorResponse.
    /// </summary>
    public class CardVerificationProcessorResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardVerificationProcessorResponse"/> class.
        /// </summary>
        public CardVerificationProcessorResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardVerificationProcessorResponse"/> class.
        /// </summary>
        /// <param name="avsCode">avs_code.</param>
        /// <param name="cvvCode">cvv_code.</param>
        public CardVerificationProcessorResponse(
            Models.AVSCode? avsCode = null,
            Models.CVVCode? cvvCode = null)
        {
            this.AvsCode = avsCode;
            this.CvvCode = cvvCode;
        }

        /// <summary>
        /// The address verification code for Visa, Discover, Mastercard, or American Express transactions.
        /// </summary>
        [JsonProperty("avs_code", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AVSCode? AvsCode { get; set; }

        /// <summary>
        /// The card verification value code for for Visa, Discover, Mastercard, or American Express.
        /// </summary>
        [JsonProperty("cvv_code", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CVVCode? CvvCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardVerificationProcessorResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardVerificationProcessorResponse other &&                ((this.AvsCode == null && other.AvsCode == null) || (this.AvsCode?.Equals(other.AvsCode) == true)) &&
                ((this.CvvCode == null && other.CvvCode == null) || (this.CvvCode?.Equals(other.CvvCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AvsCode = {(this.AvsCode == null ? "null" : this.AvsCode.ToString())}");
            toStringOutput.Add($"this.CvvCode = {(this.CvvCode == null ? "null" : this.CvvCode.ToString())}");
        }
    }
}