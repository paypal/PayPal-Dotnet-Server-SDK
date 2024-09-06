// <copyright file="SEPADebitAuthorizationDetails.cs" company="APIMatic">
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
    /// SEPADebitAuthorizationDetails.
    /// </summary>
    public class SEPADebitAuthorizationDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SEPADebitAuthorizationDetails"/> class.
        /// </summary>
        public SEPADebitAuthorizationDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SEPADebitAuthorizationDetails"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        public SEPADebitAuthorizationDetails(
            Models.InstrumentAuthorizationStatus? status = null)
        {
            this.Status = status;
        }

        /// <summary>
        /// The authorization status of the wallet instrument.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InstrumentAuthorizationStatus? Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SEPADebitAuthorizationDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is SEPADebitAuthorizationDetails other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
        }
    }
}