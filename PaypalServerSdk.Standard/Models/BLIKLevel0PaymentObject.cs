// <copyright file="BLIKLevel0PaymentObject.cs" company="APIMatic">
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
    /// BLIKLevel0PaymentObject.
    /// </summary>
    public class BLIKLevel0PaymentObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BLIKLevel0PaymentObject"/> class.
        /// </summary>
        public BLIKLevel0PaymentObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BLIKLevel0PaymentObject"/> class.
        /// </summary>
        /// <param name="authCode">auth_code.</param>
        public BLIKLevel0PaymentObject(
            string authCode)
        {
            this.AuthCode = authCode;
        }

        /// <summary>
        /// The 6-digit code used to authenticate a consumer within BLIK.
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BLIKLevel0PaymentObject : ({string.Join(", ", toStringOutput)})";
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
            return obj is BLIKLevel0PaymentObject other &&                ((this.AuthCode == null && other.AuthCode == null) || (this.AuthCode?.Equals(other.AuthCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AuthCode = {(this.AuthCode == null ? "null" : this.AuthCode)}");
        }
    }
}