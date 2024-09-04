// <copyright file="ReauthorizeRequest.cs" company="APIMatic">
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
    /// ReauthorizeRequest.
    /// </summary>
    public class ReauthorizeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReauthorizeRequest"/> class.
        /// </summary>
        public ReauthorizeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReauthorizeRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        public ReauthorizeRequest(
            Models.Money amount = null)
        {
            this.Amount = amount;
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Amount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReauthorizeRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReauthorizeRequest other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
        }
    }
}