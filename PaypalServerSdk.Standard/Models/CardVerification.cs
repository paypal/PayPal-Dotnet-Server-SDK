// <copyright file="CardVerification.cs" company="APIMatic">
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
    /// CardVerification.
    /// </summary>
    public class CardVerification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardVerification"/> class.
        /// </summary>
        public CardVerification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardVerification"/> class.
        /// </summary>
        /// <param name="method">method.</param>
        public CardVerification(
            Models.OrdersCardVerificationMethod? method = Models.OrdersCardVerificationMethod.ScaWhenRequired)
        {
            this.Method = method;
        }

        /// <summary>
        /// The method used for card verification.
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrdersCardVerificationMethod? Method { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardVerification : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardVerification other &&
                (this.Method == null && other.Method == null ||
                 this.Method?.Equals(other.Method) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Method = {(this.Method == null ? "null" : this.Method.ToString())}");
        }
    }
}