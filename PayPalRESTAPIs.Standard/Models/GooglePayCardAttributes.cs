// <copyright file="GooglePayCardAttributes.cs" company="APIMatic">
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
    /// GooglePayCardAttributes.
    /// </summary>
    public class GooglePayCardAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePayCardAttributes"/> class.
        /// </summary>
        public GooglePayCardAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePayCardAttributes"/> class.
        /// </summary>
        /// <param name="verification">verification.</param>
        public GooglePayCardAttributes(
            Models.CardVerification verification = null)
        {
            this.Verification = verification;
        }

        /// <summary>
        /// The API caller can opt in to verify the card through PayPal offered verification services (e.g. Smart Dollar Auth, 3DS).
        /// </summary>
        [JsonProperty("verification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardVerification Verification { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GooglePayCardAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is GooglePayCardAttributes other &&                ((this.Verification == null && other.Verification == null) || (this.Verification?.Equals(other.Verification) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Verification = {(this.Verification == null ? "null" : this.Verification.ToString())}");
        }
    }
}