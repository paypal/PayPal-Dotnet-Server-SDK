// <copyright file="VaultTokenRequest.cs" company="APIMatic">
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
    /// VaultTokenRequest.
    /// </summary>
    public class VaultTokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultTokenRequest"/> class.
        /// </summary>
        public VaultTokenRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultTokenRequest"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        public VaultTokenRequest(
            string id,
            Models.TokenRequestType type)
        {
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// The PayPal-generated ID for the token.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The tokenization method that generated the ID.
        /// </summary>
        [JsonProperty("type")]
        public Models.TokenRequestType Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VaultTokenRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is VaultTokenRequest other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.Type.Equals(other.Type);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Type = {this.Type}");
        }
    }
}