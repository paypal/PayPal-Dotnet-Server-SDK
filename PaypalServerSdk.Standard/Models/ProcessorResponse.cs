// <copyright file="ProcessorResponse.cs" company="APIMatic">
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
    /// ProcessorResponse.
    /// </summary>
    public class ProcessorResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessorResponse"/> class.
        /// </summary>
        public ProcessorResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessorResponse"/> class.
        /// </summary>
        /// <param name="avsCode">avs_code.</param>
        /// <param name="cvvCode">cvv_code.</param>
        /// <param name="responseCode">response_code.</param>
        /// <param name="paymentAdviceCode">payment_advice_code.</param>
        public ProcessorResponse(
            Models.AVSCode? avsCode = null,
            Models.CVVCode? cvvCode = null,
            Models.ProcessorResponseCode? responseCode = null,
            Models.PaymentAdviceCode? paymentAdviceCode = null)
        {
            this.AvsCode = avsCode;
            this.CvvCode = cvvCode;
            this.ResponseCode = responseCode;
            this.PaymentAdviceCode = paymentAdviceCode;
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

        /// <summary>
        /// Processor response code for the non-PayPal payment processor errors.
        /// </summary>
        [JsonProperty("response_code", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProcessorResponseCode? ResponseCode { get; set; }

        /// <summary>
        /// The declined payment transactions might have payment advice codes. The card networks, like Visa and Mastercard, return payment advice codes.
        /// </summary>
        [JsonProperty("payment_advice_code", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentAdviceCode? PaymentAdviceCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProcessorResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProcessorResponse other &&                ((this.AvsCode == null && other.AvsCode == null) || (this.AvsCode?.Equals(other.AvsCode) == true)) &&
                ((this.CvvCode == null && other.CvvCode == null) || (this.CvvCode?.Equals(other.CvvCode) == true)) &&
                ((this.ResponseCode == null && other.ResponseCode == null) || (this.ResponseCode?.Equals(other.ResponseCode) == true)) &&
                ((this.PaymentAdviceCode == null && other.PaymentAdviceCode == null) || (this.PaymentAdviceCode?.Equals(other.PaymentAdviceCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AvsCode = {(this.AvsCode == null ? "null" : this.AvsCode.ToString())}");
            toStringOutput.Add($"this.CvvCode = {(this.CvvCode == null ? "null" : this.CvvCode.ToString())}");
            toStringOutput.Add($"this.ResponseCode = {(this.ResponseCode == null ? "null" : this.ResponseCode.ToString())}");
            toStringOutput.Add($"this.PaymentAdviceCode = {(this.PaymentAdviceCode == null ? "null" : this.PaymentAdviceCode.ToString())}");
        }
    }
}