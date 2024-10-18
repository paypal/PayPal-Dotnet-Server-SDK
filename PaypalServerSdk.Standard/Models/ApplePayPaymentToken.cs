// <copyright file="ApplePayPaymentToken.cs" company="APIMatic">
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
    /// ApplePayPaymentToken.
    /// </summary>
    public class ApplePayPaymentToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayPaymentToken"/> class.
        /// </summary>
        public ApplePayPaymentToken()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayPaymentToken"/> class.
        /// </summary>
        /// <param name="card">card.</param>
        public ApplePayPaymentToken(
            Models.ApplePayCard card = null)
        {
            this.Card = card;
        }

        /// <summary>
        /// The payment card to be used to fund a payment. Can be a credit or debit card.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplePayCard Card { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApplePayPaymentToken : ({string.Join(", ", toStringOutput)})";
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
            return obj is ApplePayPaymentToken other &&                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
        }
    }
}