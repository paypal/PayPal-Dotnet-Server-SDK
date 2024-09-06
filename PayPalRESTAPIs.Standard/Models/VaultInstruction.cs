// <copyright file="VaultInstruction.cs" company="APIMatic">
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
    /// VaultInstruction.
    /// </summary>
    public class VaultInstruction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultInstruction"/> class.
        /// </summary>
        public VaultInstruction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultInstruction"/> class.
        /// </summary>
        /// <param name="storeInVault">store_in_vault.</param>
        public VaultInstruction(
            Models.StoreInVaultInstruction storeInVault)
        {
            this.StoreInVault = storeInVault;
        }

        /// <summary>
        /// Defines how and when the payment source gets vaulted.
        /// </summary>
        [JsonProperty("store_in_vault")]
        public Models.StoreInVaultInstruction StoreInVault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VaultInstruction : ({string.Join(", ", toStringOutput)})";
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
            return obj is VaultInstruction other &&                this.StoreInVault.Equals(other.StoreInVault);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StoreInVault = {this.StoreInVault}");
        }
    }
}