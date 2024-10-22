// <copyright file="SetupTokenResponsePaymentSource.cs" company="APIMatic">
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
    /// SetupTokenResponsePaymentSource.
    /// </summary>
    public class SetupTokenResponsePaymentSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetupTokenResponsePaymentSource"/> class.
        /// </summary>
        public SetupTokenResponsePaymentSource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetupTokenResponsePaymentSource"/> class.
        /// </summary>
        /// <param name="card">card.</param>
        /// <param name="paypal">paypal.</param>
        /// <param name="venmo">venmo.</param>
        public SetupTokenResponsePaymentSource(
            Models.SetupTokenResponseCard card = null,
            Models.PaypalPaymentToken paypal = null,
            Models.VenmoPaymentToken venmo = null)
        {
            this.Card = card;
            this.Paypal = paypal;
            this.Venmo = venmo;
        }

        /// <summary>
        /// Gets or sets Card.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SetupTokenResponseCard Card { get; set; }

        /// <summary>
        /// Gets or sets Paypal.
        /// </summary>
        [JsonProperty("paypal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalPaymentToken Paypal { get; set; }

        /// <summary>
        /// Gets or sets Venmo.
        /// </summary>
        [JsonProperty("venmo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VenmoPaymentToken Venmo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SetupTokenResponsePaymentSource : ({string.Join(", ", toStringOutput)})";
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
            return obj is SetupTokenResponsePaymentSource other &&                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.Paypal == null && other.Paypal == null) || (this.Paypal?.Equals(other.Paypal) == true)) &&
                ((this.Venmo == null && other.Venmo == null) || (this.Venmo?.Equals(other.Venmo) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.Paypal = {(this.Paypal == null ? "null" : this.Paypal.ToString())}");
            toStringOutput.Add($"this.Venmo = {(this.Venmo == null ? "null" : this.Venmo.ToString())}");
        }
    }
}