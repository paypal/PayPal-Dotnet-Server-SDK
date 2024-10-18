// <copyright file="UniversalProductCode.cs" company="APIMatic">
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
    /// UniversalProductCode.
    /// </summary>
    public class UniversalProductCode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniversalProductCode"/> class.
        /// </summary>
        public UniversalProductCode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniversalProductCode"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="code">code.</param>
        public UniversalProductCode(
            Models.UpcType type,
            string code)
        {
            this.Type = type;
            this.Code = code;
        }

        /// <summary>
        /// The Universal Product Code type.
        /// </summary>
        [JsonProperty("type")]
        public Models.UpcType Type { get; set; }

        /// <summary>
        /// The UPC product code of the item.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UniversalProductCode : ({string.Join(", ", toStringOutput)})";
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
            return obj is UniversalProductCode other &&                this.Type.Equals(other.Type) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
        }
    }
}