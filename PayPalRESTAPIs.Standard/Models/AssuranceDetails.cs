// <copyright file="AssuranceDetails.cs" company="APIMatic">
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
    /// AssuranceDetails.
    /// </summary>
    public class AssuranceDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssuranceDetails"/> class.
        /// </summary>
        public AssuranceDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssuranceDetails"/> class.
        /// </summary>
        /// <param name="accountVerified">account_verified.</param>
        /// <param name="cardHolderAuthenticated">card_holder_authenticated.</param>
        public AssuranceDetails(
            bool? accountVerified = false,
            bool? cardHolderAuthenticated = false)
        {
            this.AccountVerified = accountVerified;
            this.CardHolderAuthenticated = cardHolderAuthenticated;
        }

        /// <summary>
        /// If true, indicates that Cardholder possession validation has been performed on returned payment credential.
        /// </summary>
        [JsonProperty("account_verified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccountVerified { get; set; }

        /// <summary>
        /// <![CDATA[
        /// If true, indicates that identification and verifications (ID&V) was performed on the returned payment credential.If false, the same risk-based authentication can be performed as you would for card transactions. This risk-based authentication can include, but not limited to, step-up with 3D Secure protocol if applicable.
        /// ]]>
        /// </summary>
        [JsonProperty("card_holder_authenticated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CardHolderAuthenticated { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AssuranceDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is AssuranceDetails other &&                ((this.AccountVerified == null && other.AccountVerified == null) || (this.AccountVerified?.Equals(other.AccountVerified) == true)) &&
                ((this.CardHolderAuthenticated == null && other.CardHolderAuthenticated == null) || (this.CardHolderAuthenticated?.Equals(other.CardHolderAuthenticated) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountVerified = {(this.AccountVerified == null ? "null" : this.AccountVerified.ToString())}");
            toStringOutput.Add($"this.CardHolderAuthenticated = {(this.CardHolderAuthenticated == null ? "null" : this.CardHolderAuthenticated.ToString())}");
        }
    }
}