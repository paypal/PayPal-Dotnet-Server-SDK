// <copyright file="ErrorDetails.cs" company="APIMatic">
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
    /// ErrorDetails.
    /// </summary>
    public class ErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetails"/> class.
        /// </summary>
        public ErrorDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetails"/> class.
        /// </summary>
        /// <param name="issue">issue.</param>
        /// <param name="field">field.</param>
        /// <param name="mValue">value.</param>
        /// <param name="location">location.</param>
        /// <param name="links">links.</param>
        /// <param name="description">description.</param>
        public ErrorDetails(
            string issue,
            string field = null,
            string mValue = null,
            string location = "body",
            List<Models.LinkDescription> links = null,
            string description = null)
        {
            this.Field = field;
            this.MValue = mValue;
            this.Location = location;
            this.Issue = issue;
            this.Links = links;
            this.Description = description;
        }

        /// <summary>
        /// The field that caused the error. If this field is in the body, set this value to the field's JSON pointer value. Required for client-side errors.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// The value of the field that caused the error.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <summary>
        /// The location of the field that caused the error. Value is `body`, `path`, or `query`.
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// The unique, fine-grained application-level error code.
        /// </summary>
        [JsonProperty("issue")]
        public string Issue { get; set; }

        /// <summary>
        /// An array of request-related [HATEOAS links](/api/rest/responses/#hateoas-links) that are either relevant to the issue by providing additional information or offering potential resolutions.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LinkDescription> Links { get; set; }

        /// <summary>
        /// The human-readable description for an issue. The description can change over the lifetime of an API, so clients must not depend on this value.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ErrorDetails : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ErrorDetails other &&
                (this.Field == null && other.Field == null ||
                 this.Field?.Equals(other.Field) == true) &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true) &&
                (this.Location == null && other.Location == null ||
                 this.Location?.Equals(other.Location) == true) &&
                (this.Issue == null && other.Issue == null ||
                 this.Issue?.Equals(other.Issue) == true) &&
                (this.Links == null && other.Links == null ||
                 this.Links?.Equals(other.Links) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Field = {this.Field ?? "null"}");
            toStringOutput.Add($"MValue = {this.MValue ?? "null"}");
            toStringOutput.Add($"Location = {this.Location ?? "null"}");
            toStringOutput.Add($"Issue = {this.Issue ?? "null"}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
        }
    }
}