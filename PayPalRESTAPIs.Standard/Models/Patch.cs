// <copyright file="Patch.cs" company="APIMatic">
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
    /// Patch.
    /// </summary>
    public class Patch
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Patch"/> class.
        /// </summary>
        public Patch()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Patch"/> class.
        /// </summary>
        /// <param name="op">op.</param>
        /// <param name="path">path.</param>
        /// <param name="mValue">value.</param>
        /// <param name="from">from.</param>
        public Patch(
            Models.PatchOp op,
            string path = null,
            JsonValue mValue = null,
            string from = null)
        {
            this.Op = op;
            this.Path = path;
            this.MValue = mValue;
            this.From = from;
        }

        /// <summary>
        /// The operation.
        /// </summary>
        [JsonProperty("op")]
        public Models.PatchOp Op { get; set; }

        /// <summary>
        /// The <a href="https://tools.ietf.org/html/rfc6901">JSON Pointer</a> to the target document location at which to complete the operation.
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// The value to apply. The <code>remove</code>, <code>copy</code>, and <code>move</code> operations do not require a value. Since <a href="https://www.rfc-editor.org/rfc/rfc69021">JSON Patch</a> allows any type for <code>value</code>, the <code>type</code> property is not specified.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public JsonValue MValue { get; set; }

        /// <summary>
        /// The <a href="https://tools.ietf.org/html/rfc6901">JSON Pointer</a> to the target document location from which to move the value. Required for the <code>move</code> operation.
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Patch : ({string.Join(", ", toStringOutput)})";
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
            return obj is Patch other &&                this.Op.Equals(other.Op) &&
                ((this.Path == null && other.Path == null) || (this.Path?.Equals(other.Path) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Op = {this.Op}");
            toStringOutput.Add($"this.Path = {(this.Path == null ? "null" : this.Path)}");
            toStringOutput.Add($"MValue = {(this.MValue == null ? "null" : this.MValue.ToString())}");
            toStringOutput.Add($"this.From = {(this.From == null ? "null" : this.From)}");
        }
    }
}