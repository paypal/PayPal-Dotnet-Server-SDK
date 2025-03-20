// <copyright file="PaypalWalletAttributesResponse.cs" company="APIMatic">
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
    /// PaypalWalletAttributesResponse.
    /// </summary>
    public class PaypalWalletAttributesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalWalletAttributesResponse"/> class.
        /// </summary>
        public PaypalWalletAttributesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalWalletAttributesResponse"/> class.
        /// </summary>
        /// <param name="vault">vault.</param>
        /// <param name="cobrandedCards">cobranded_cards.</param>
        public PaypalWalletAttributesResponse(
            Models.PaypalWalletVaultResponse vault = null,
            List<Models.CobrandedCard> cobrandedCards = null)
        {
            this.Vault = vault;
            this.CobrandedCards = cobrandedCards;
        }

        /// <summary>
        /// The details about a saved PayPal Wallet payment source.
        /// </summary>
        [JsonProperty("vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalWalletVaultResponse Vault { get; set; }

        /// <summary>
        /// An array of merchant cobranded cards used by buyer to complete an order. This array will be present if a merchant has onboarded their cobranded card with PayPal and provided corresponding label(s).
        /// </summary>
        [JsonProperty("cobranded_cards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CobrandedCard> CobrandedCards { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaypalWalletAttributesResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaypalWalletAttributesResponse other &&
                (this.Vault == null && other.Vault == null ||
                 this.Vault?.Equals(other.Vault) == true) &&
                (this.CobrandedCards == null && other.CobrandedCards == null ||
                 this.CobrandedCards?.Equals(other.CobrandedCards) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Vault = {(this.Vault == null ? "null" : this.Vault.ToString())}");
            toStringOutput.Add($"CobrandedCards = {(this.CobrandedCards == null ? "null" : $"[{string.Join(", ", this.CobrandedCards)} ]")}");
        }
    }
}