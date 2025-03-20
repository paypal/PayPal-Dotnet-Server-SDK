// <copyright file="Phone.cs" company="APIMatic">
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
    /// Phone.
    /// </summary>
    public class Phone
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Phone"/> class.
        /// </summary>
        public Phone()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Phone"/> class.
        /// </summary>
        /// <param name="countryCode">country_code.</param>
        /// <param name="nationalNumber">national_number.</param>
        /// <param name="extensionNumber">extension_number.</param>
        public Phone(
            string countryCode,
            string nationalNumber,
            string extensionNumber = null)
        {
            this.CountryCode = countryCode;
            this.NationalNumber = nationalNumber;
            this.ExtensionNumber = extensionNumber;
        }

        /// <summary>
        /// The country calling code (CC), in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). The combined length of the CC and the national number must not be greater than 15 digits. The national number consists of a national destination code (NDC) and subscriber number (SN).
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The national number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). The combined length of the country calling code (CC) and the national number must not be greater than 15 digits. The national number consists of a national destination code (NDC) and subscriber number (SN).
        /// </summary>
        [JsonProperty("national_number")]
        public string NationalNumber { get; set; }

        /// <summary>
        /// The extension number.
        /// </summary>
        [JsonProperty("extension_number", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtensionNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Phone : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Phone other &&
                (this.CountryCode == null && other.CountryCode == null ||
                 this.CountryCode?.Equals(other.CountryCode) == true) &&
                (this.NationalNumber == null && other.NationalNumber == null ||
                 this.NationalNumber?.Equals(other.NationalNumber) == true) &&
                (this.ExtensionNumber == null && other.ExtensionNumber == null ||
                 this.ExtensionNumber?.Equals(other.ExtensionNumber) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CountryCode = {this.CountryCode ?? "null"}");
            toStringOutput.Add($"NationalNumber = {this.NationalNumber ?? "null"}");
            toStringOutput.Add($"ExtensionNumber = {this.ExtensionNumber ?? "null"}");
        }
    }
}