// <copyright file="LinkDescription.cs" company="APIMatic">
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
    /// LinkDescription.
    /// </summary>
    public class LinkDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkDescription"/> class.
        /// </summary>
        public LinkDescription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkDescription"/> class.
        /// </summary>
        /// <param name="href">href.</param>
        /// <param name="rel">rel.</param>
        /// <param name="method">method.</param>
        public LinkDescription(
            string href,
            string rel,
            Models.LinkHttpMethod? method = null)
        {
            this.Href = href;
            this.Rel = rel;
            this.Method = method;
        }

        /// <summary>
        /// The complete target URL. To make the related call, combine the method with this [URI Template-formatted](https://tools.ietf.org/html/rfc6570) link. For pre-processing, include the `$`, `(`, and `)` characters. The `href` is the key HATEOAS component that links a completed call with a subsequent call.
        /// </summary>
        [JsonProperty("href")]
        public string Href { get; set; }

        /// <summary>
        /// The [link relation type](https://tools.ietf.org/html/rfc5988#section-4), which serves as an ID for a link that unambiguously describes the semantics of the link. See [Link Relations](https://www.iana.org/assignments/link-relations/link-relations.xhtml).
        /// </summary>
        [JsonProperty("rel")]
        public string Rel { get; set; }

        /// <summary>
        /// The HTTP method required to make the related call.
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LinkHttpMethod? Method { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"LinkDescription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is LinkDescription other &&
                (this.Href == null && other.Href == null ||
                 this.Href?.Equals(other.Href) == true) &&
                (this.Rel == null && other.Rel == null ||
                 this.Rel?.Equals(other.Rel) == true) &&
                (this.Method == null && other.Method == null ||
                 this.Method?.Equals(other.Method) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Href = {this.Href ?? "null"}");
            toStringOutput.Add($"Rel = {this.Rel ?? "null"}");
            toStringOutput.Add($"Method = {(this.Method == null ? "null" : this.Method.ToString())}");
        }
    }
}