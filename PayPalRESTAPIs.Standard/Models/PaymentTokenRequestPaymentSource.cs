// <copyright file="PaymentTokenRequestPaymentSource.cs" company="APIMatic">
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
using PayPalRESTAPIs.Standard;
using PayPalRESTAPIs.Standard.Utilities;

namespace PayPalRESTAPIs.Standard.Models
{
    /// <summary>
    /// PaymentTokenRequestPaymentSource.
    /// </summary>
    public class PaymentTokenRequestPaymentSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenRequestPaymentSource"/> class.
        /// </summary>
        public PaymentTokenRequestPaymentSource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenRequestPaymentSource"/> class.
        /// </summary>
        /// <param name="card">card.</param>
        /// <param name="token">token.</param>
        public PaymentTokenRequestPaymentSource(
            Models.PaymentTokenRequestCard card = null,
            Models.VaultTokenRequest token = null)
        {
            this.Card = card;
            this.Token = token;
        }

        /// <summary>
        /// A Resource representing a request to vault a Card.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentTokenRequestCard Card { get; set; }

        /// <summary>
        /// The Tokenized Payment Source representing a Request to Vault a Token.
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VaultTokenRequest Token { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentTokenRequestPaymentSource : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentTokenRequestPaymentSource other &&                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token.ToString())}");
        }
    }
}