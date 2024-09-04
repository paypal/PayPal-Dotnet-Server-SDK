// <copyright file="PaymentCollection.cs" company="APIMatic">
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
    /// PaymentCollection.
    /// </summary>
    public class PaymentCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCollection"/> class.
        /// </summary>
        public PaymentCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCollection"/> class.
        /// </summary>
        /// <param name="authorizations">authorizations.</param>
        /// <param name="captures">captures.</param>
        /// <param name="refunds">refunds.</param>
        public PaymentCollection(
            List<Models.AuthorizationWithAdditionalData> authorizations = null,
            List<Models.Capture> captures = null,
            List<Models.Refund> refunds = null)
        {
            this.Authorizations = authorizations;
            this.Captures = captures;
            this.Refunds = refunds;
        }

        /// <summary>
        /// An array of authorized payments for a purchase unit. A purchase unit can have zero or more authorized payments.
        /// </summary>
        [JsonProperty("authorizations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AuthorizationWithAdditionalData> Authorizations { get; set; }

        /// <summary>
        /// An array of captured payments for a purchase unit. A purchase unit can have zero or more captured payments.
        /// </summary>
        [JsonProperty("captures", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Capture> Captures { get; set; }

        /// <summary>
        /// An array of refunds for a purchase unit. A purchase unit can have zero or more refunds.
        /// </summary>
        [JsonProperty("refunds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Refund> Refunds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentCollection : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentCollection other &&                ((this.Authorizations == null && other.Authorizations == null) || (this.Authorizations?.Equals(other.Authorizations) == true)) &&
                ((this.Captures == null && other.Captures == null) || (this.Captures?.Equals(other.Captures) == true)) &&
                ((this.Refunds == null && other.Refunds == null) || (this.Refunds?.Equals(other.Refunds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Authorizations = {(this.Authorizations == null ? "null" : $"[{string.Join(", ", this.Authorizations)} ]")}");
            toStringOutput.Add($"this.Captures = {(this.Captures == null ? "null" : $"[{string.Join(", ", this.Captures)} ]")}");
            toStringOutput.Add($"this.Refunds = {(this.Refunds == null ? "null" : $"[{string.Join(", ", this.Refunds)} ]")}");
        }
    }
}