// <copyright file="BlikLevel0PaymentObject.cs" company="APIMatic">
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
    /// BlikLevel0PaymentObject.
    /// </summary>
    public class BlikLevel0PaymentObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlikLevel0PaymentObject"/> class.
        /// </summary>
        public BlikLevel0PaymentObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlikLevel0PaymentObject"/> class.
        /// </summary>
        /// <param name="authCode">auth_code.</param>
        public BlikLevel0PaymentObject(
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

            return $"BlikLevel0PaymentObject : ({string.Join(", ", toStringOutput)})";
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
            return obj is BlikLevel0PaymentObject other &&                ((this.AuthCode == null && other.AuthCode == null) || (this.AuthCode?.Equals(other.AuthCode) == true));
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