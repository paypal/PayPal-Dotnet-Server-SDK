// <copyright file="CardAttributesResponse.cs" company="APIMatic">
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
    /// CardAttributesResponse.
    /// </summary>
    public class CardAttributesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardAttributesResponse"/> class.
        /// </summary>
        public CardAttributesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardAttributesResponse"/> class.
        /// </summary>
        /// <param name="vault">vault.</param>
        public CardAttributesResponse(
            Models.CardVaultResponse vault = null)
        {
            this.Vault = vault;
        }

        /// <summary>
        /// The details about a saved Card payment source.
        /// </summary>
        [JsonProperty("vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardVaultResponse Vault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CardAttributesResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CardAttributesResponse other &&
                (this.Vault == null && other.Vault == null ||
                 this.Vault?.Equals(other.Vault) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Vault = {(this.Vault == null ? "null" : this.Vault.ToString())}");
        }
    }
}