// <copyright file="VenmoWalletAttributesResponse.cs" company="APIMatic">
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
    /// VenmoWalletAttributesResponse.
    /// </summary>
    public class VenmoWalletAttributesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VenmoWalletAttributesResponse"/> class.
        /// </summary>
        public VenmoWalletAttributesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VenmoWalletAttributesResponse"/> class.
        /// </summary>
        /// <param name="vault">vault.</param>
        public VenmoWalletAttributesResponse(
            Models.VaultResponse vault = null)
        {
            this.Vault = vault;
        }

        /// <summary>
        /// The details about a saved payment source.
        /// </summary>
        [JsonProperty("vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VaultResponse Vault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VenmoWalletAttributesResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is VenmoWalletAttributesResponse other &&                ((this.Vault == null && other.Vault == null) || (this.Vault?.Equals(other.Vault) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Vault = {(this.Vault == null ? "null" : this.Vault.ToString())}");
        }
    }
}