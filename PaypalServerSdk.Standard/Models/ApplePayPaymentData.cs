// <copyright file="ApplePayPaymentData.cs" company="APIMatic">
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
    /// ApplePayPaymentData.
    /// </summary>
    public class ApplePayPaymentData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayPaymentData"/> class.
        /// </summary>
        public ApplePayPaymentData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayPaymentData"/> class.
        /// </summary>
        /// <param name="cryptogram">cryptogram.</param>
        /// <param name="eciIndicator">eci_indicator.</param>
        /// <param name="emvData">emv_data.</param>
        /// <param name="pin">pin.</param>
        public ApplePayPaymentData(
            string cryptogram = null,
            string eciIndicator = null,
            string emvData = null,
            string pin = null)
        {
            this.Cryptogram = cryptogram;
            this.EciIndicator = eciIndicator;
            this.EmvData = emvData;
            this.Pin = pin;
        }

        /// <summary>
        /// Online payment cryptogram, as defined by 3D Secure. The pattern is defined by an external party and supports Unicode.
        /// </summary>
        [JsonProperty("cryptogram", NullValueHandling = NullValueHandling.Ignore)]
        public string Cryptogram { get; set; }

        /// <summary>
        /// ECI indicator, as defined by 3- Secure. The pattern is defined by an external party and supports Unicode.
        /// </summary>
        [JsonProperty("eci_indicator", NullValueHandling = NullValueHandling.Ignore)]
        public string EciIndicator { get; set; }

        /// <summary>
        /// Encoded Apple Pay EMV Payment Structure used for payments in China. The pattern is defined by an external party and supports Unicode.
        /// </summary>
        [JsonProperty("emv_data", NullValueHandling = NullValueHandling.Ignore)]
        public string EmvData { get; set; }

        /// <summary>
        /// Bank Key encrypted Apple Pay PIN. The pattern is defined by an external party and supports Unicode.
        /// </summary>
        [JsonProperty("pin", NullValueHandling = NullValueHandling.Ignore)]
        public string Pin { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ApplePayPaymentData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ApplePayPaymentData other &&
                (this.Cryptogram == null && other.Cryptogram == null ||
                 this.Cryptogram?.Equals(other.Cryptogram) == true) &&
                (this.EciIndicator == null && other.EciIndicator == null ||
                 this.EciIndicator?.Equals(other.EciIndicator) == true) &&
                (this.EmvData == null && other.EmvData == null ||
                 this.EmvData?.Equals(other.EmvData) == true) &&
                (this.Pin == null && other.Pin == null ||
                 this.Pin?.Equals(other.Pin) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Cryptogram = {this.Cryptogram ?? "null"}");
            toStringOutput.Add($"EciIndicator = {this.EciIndicator ?? "null"}");
            toStringOutput.Add($"EmvData = {this.EmvData ?? "null"}");
            toStringOutput.Add($"Pin = {this.Pin ?? "null"}");
        }
    }
}