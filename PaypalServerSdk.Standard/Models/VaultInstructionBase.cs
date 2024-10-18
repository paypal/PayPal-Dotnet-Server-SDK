// <copyright file="VaultInstructionBase.cs" company="APIMatic">
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
    /// VaultInstructionBase.
    /// </summary>
    public class VaultInstructionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultInstructionBase"/> class.
        /// </summary>
        public VaultInstructionBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultInstructionBase"/> class.
        /// </summary>
        /// <param name="storeInVault">store_in_vault.</param>
        public VaultInstructionBase(
            Models.StoreInVaultInstruction? storeInVault = null)
        {
            this.StoreInVault = storeInVault;
        }

        /// <summary>
        /// Defines how and when the payment source gets vaulted.
        /// </summary>
        [JsonProperty("store_in_vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StoreInVaultInstruction? StoreInVault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VaultInstructionBase : ({string.Join(", ", toStringOutput)})";
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
            return obj is VaultInstructionBase other &&                ((this.StoreInVault == null && other.StoreInVault == null) || (this.StoreInVault?.Equals(other.StoreInVault) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StoreInVault = {(this.StoreInVault == null ? "null" : this.StoreInVault.ToString())}");
        }
    }
}