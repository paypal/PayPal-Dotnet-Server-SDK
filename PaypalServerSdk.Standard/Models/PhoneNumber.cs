// <copyright file="PhoneNumber.cs" company="APIMatic">
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
    /// PhoneNumber.
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber"/> class.
        /// </summary>
        public PhoneNumber()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber"/> class.
        /// </summary>
        /// <param name="nationalNumber">national_number.</param>
        public PhoneNumber(
            string nationalNumber)
        {
            this.NationalNumber = nationalNumber;
        }

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
            return $"PhoneNumber : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PhoneNumber other &&
                (this.NationalNumber == null && other.NationalNumber == null ||
                 this.NationalNumber?.Equals(other.NationalNumber) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"NationalNumber = {this.NationalNumber ?? "null"}");
        }
    }
}