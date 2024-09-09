// <copyright file="PhoneWithType.cs" company="APIMatic">
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
    /// PhoneWithType.
    /// </summary>
    public class PhoneWithType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneWithType"/> class.
        /// </summary>
        public PhoneWithType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneWithType"/> class.
        /// </summary>
        /// <param name="phoneNumber">phone_number.</param>
        /// <param name="phoneType">phone_type.</param>
        public PhoneWithType(
            Models.PhoneNumber phoneNumber,
            Models.PhoneType? phoneType = null)
        {
            this.PhoneType = phoneType;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// The phone type.
        /// </summary>
        [JsonProperty("phone_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PhoneType? PhoneType { get; set; }

        /// <summary>
        /// The phone number in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [JsonProperty("phone_number")]
        public Models.PhoneNumber PhoneNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PhoneWithType : ({string.Join(", ", toStringOutput)})";
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
            return obj is PhoneWithType other &&                ((this.PhoneType == null && other.PhoneType == null) || (this.PhoneType?.Equals(other.PhoneType) == true)) &&
                ((this.PhoneNumber == null && other.PhoneNumber == null) || (this.PhoneNumber?.Equals(other.PhoneNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PhoneType = {(this.PhoneType == null ? "null" : this.PhoneType.ToString())}");
            toStringOutput.Add($"this.PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber.ToString())}");
        }
    }
}