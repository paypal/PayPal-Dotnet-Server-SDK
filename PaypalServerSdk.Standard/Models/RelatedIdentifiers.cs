// <copyright file="RelatedIdentifiers.cs" company="APIMatic">
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
    /// RelatedIdentifiers.
    /// </summary>
    public class RelatedIdentifiers
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedIdentifiers"/> class.
        /// </summary>
        public RelatedIdentifiers()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedIdentifiers"/> class.
        /// </summary>
        /// <param name="orderId">order_id.</param>
        /// <param name="authorizationId">authorization_id.</param>
        /// <param name="captureId">capture_id.</param>
        public RelatedIdentifiers(
            string orderId = null,
            string authorizationId = null,
            string captureId = null)
        {
            this.OrderId = orderId;
            this.AuthorizationId = authorizationId;
            this.CaptureId = captureId;
        }

        /// <summary>
        /// Order ID related to the resource.
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// Authorization ID related to the resource.
        /// </summary>
        [JsonProperty("authorization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// Capture ID related to the resource.
        /// </summary>
        [JsonProperty("capture_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CaptureId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RelatedIdentifiers : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RelatedIdentifiers other &&
                (this.OrderId == null && other.OrderId == null ||
                 this.OrderId?.Equals(other.OrderId) == true) &&
                (this.AuthorizationId == null && other.AuthorizationId == null ||
                 this.AuthorizationId?.Equals(other.AuthorizationId) == true) &&
                (this.CaptureId == null && other.CaptureId == null ||
                 this.CaptureId?.Equals(other.CaptureId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"OrderId = {this.OrderId ?? "null"}");
            toStringOutput.Add($"AuthorizationId = {this.AuthorizationId ?? "null"}");
            toStringOutput.Add($"CaptureId = {this.CaptureId ?? "null"}");
        }
    }
}