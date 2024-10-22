// <copyright file="RequestTokenInput.cs" company="APIMatic">
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
    /// RequestTokenInput.
    /// </summary>
    public class RequestTokenInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTokenInput"/> class.
        /// </summary>
        public RequestTokenInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTokenInput"/> class.
        /// </summary>
        /// <param name="grantType">grant_type.</param>
        /// <param name="authorization">Authorization.</param>
        /// <param name="scope">scope.</param>
        public RequestTokenInput(
            string grantType,
            string authorization,
            string scope = null)
        {
            this.GrantType = grantType;
            this.Authorization = authorization;
            this.Scope = scope;
        }

        /// <summary>
        /// Grant Type
        /// </summary>
        [JsonProperty("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// Authorization header in Basic auth format
        /// </summary>
        [JsonProperty("Authorization")]
        public string Authorization { get; set; }

        /// <summary>
        /// Requested scopes as a space-delimited list.
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RequestTokenInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is RequestTokenInput other &&                ((this.GrantType == null && other.GrantType == null) || (this.GrantType?.Equals(other.GrantType) == true)) &&
                ((this.Authorization == null && other.Authorization == null) || (this.Authorization?.Equals(other.Authorization) == true)) &&
                ((this.Scope == null && other.Scope == null) || (this.Scope?.Equals(other.Scope) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GrantType = {(this.GrantType == null ? "null" : this.GrantType)}");
            toStringOutput.Add($"this.Authorization = {(this.Authorization == null ? "null" : this.Authorization)}");
            toStringOutput.Add($"this.Scope = {(this.Scope == null ? "null" : this.Scope)}");
        }
    }
}