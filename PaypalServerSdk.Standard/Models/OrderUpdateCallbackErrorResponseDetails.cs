// <copyright file="OrderUpdateCallbackErrorResponseDetails.cs" company="APIMatic">
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
    /// OrderUpdateCallbackErrorResponseDetails.
    /// </summary>
    public class OrderUpdateCallbackErrorResponseDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateCallbackErrorResponseDetails"/> class.
        /// </summary>
        public OrderUpdateCallbackErrorResponseDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateCallbackErrorResponseDetails"/> class.
        /// </summary>
        /// <param name="issue">issue.</param>
        /// <param name="field">field.</param>
        /// <param name="mValue">value.</param>
        public OrderUpdateCallbackErrorResponseDetails(
            string issue,
            string field = null,
            string mValue = null)
        {
            this.Field = field;
            this.MValue = mValue;
            this.Issue = issue;
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
        /// The unique, fine-grained application-level error code.
        /// </summary>
        [JsonProperty("issue")]
        public string Issue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderUpdateCallbackErrorResponseDetails : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderUpdateCallbackErrorResponseDetails other &&
                (this.Field == null && other.Field == null ||
                 this.Field?.Equals(other.Field) == true) &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true) &&
                (this.Issue == null && other.Issue == null ||
                 this.Issue?.Equals(other.Issue) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Field = {this.Field ?? "null"}");
            toStringOutput.Add($"MValue = {this.MValue ?? "null"}");
            toStringOutput.Add($"Issue = {this.Issue ?? "null"}");
        }
    }
}