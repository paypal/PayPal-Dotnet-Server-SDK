// <copyright file="PhoneNumberWithCountryCode.cs" company="APIMatic">
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
    /// PhoneNumberWithCountryCode.
    /// </summary>
    public class PhoneNumberWithCountryCode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberWithCountryCode"/> class.
        /// </summary>
        public PhoneNumberWithCountryCode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberWithCountryCode"/> class.
        /// </summary>
        /// <param name="countryCode">country_code.</param>
        /// <param name="nationalNumber">national_number.</param>
        public PhoneNumberWithCountryCode(
            string countryCode,
            string nationalNumber)
        {
            this.CountryCode = countryCode;
            this.NationalNumber = nationalNumber;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PhoneNumberWithCountryCode : ({string.Join(", ", toStringOutput)})";
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
            return obj is PhoneNumberWithCountryCode other &&                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.NationalNumber == null && other.NationalNumber == null) || (this.NationalNumber?.Equals(other.NationalNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.NationalNumber = {(this.NationalNumber == null ? "null" : this.NationalNumber)}");
        }
    }
}