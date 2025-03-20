// <copyright file="SetupTokenRequestPaymentSource.cs" company="APIMatic">
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
    /// SetupTokenRequestPaymentSource.
    /// </summary>
    public class SetupTokenRequestPaymentSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetupTokenRequestPaymentSource"/> class.
        /// </summary>
        public SetupTokenRequestPaymentSource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetupTokenRequestPaymentSource"/> class.
        /// </summary>
        /// <param name="card">card.</param>
        /// <param name="paypal">paypal.</param>
        /// <param name="venmo">venmo.</param>
        /// <param name="token">token.</param>
        public SetupTokenRequestPaymentSource(
            Models.SetupTokenRequestCard card = null,
            Models.VaultPaypalWalletRequest paypal = null,
            Models.VaultVenmoRequest venmo = null,
            Models.VaultTokenRequest token = null)
        {
            this.Card = card;
            this.Paypal = paypal;
            this.Venmo = venmo;
            this.Token = token;
        }

        /// <summary>
        /// A Resource representing a request to vault a Card.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SetupTokenRequestCard Card { get; set; }

        /// <summary>
        /// A resource representing a request to vault PayPal Wallet.
        /// </summary>
        [JsonProperty("paypal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VaultPaypalWalletRequest Paypal { get; set; }

        /// <summary>
        /// Gets or sets Venmo.
        /// </summary>
        [JsonProperty("venmo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VaultVenmoRequest Venmo { get; set; }

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
            return $"SetupTokenRequestPaymentSource : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SetupTokenRequestPaymentSource other &&
                (this.Card == null && other.Card == null ||
                 this.Card?.Equals(other.Card) == true) &&
                (this.Paypal == null && other.Paypal == null ||
                 this.Paypal?.Equals(other.Paypal) == true) &&
                (this.Venmo == null && other.Venmo == null ||
                 this.Venmo?.Equals(other.Venmo) == true) &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"Paypal = {(this.Paypal == null ? "null" : this.Paypal.ToString())}");
            toStringOutput.Add($"Venmo = {(this.Venmo == null ? "null" : this.Venmo.ToString())}");
            toStringOutput.Add($"Token = {(this.Token == null ? "null" : this.Token.ToString())}");
        }
    }
}