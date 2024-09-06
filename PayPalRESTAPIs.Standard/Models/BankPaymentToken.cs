// <copyright file="BankPaymentToken.cs" company="APIMatic">
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
    /// BankPaymentToken.
    /// </summary>
    public class BankPaymentToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankPaymentToken"/> class.
        /// </summary>
        public BankPaymentToken()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankPaymentToken"/> class.
        /// </summary>
        /// <param name="achDebit">ach_debit.</param>
        /// <param name="sepaDebit">sepa_debit.</param>
        public BankPaymentToken(
            Models.ACHDebitResponse achDebit = null,
            Models.SEPADebitResponse sepaDebit = null)
        {
            this.AchDebit = achDebit;
            this.SepaDebit = sepaDebit;
        }

        /// <summary>
        /// A Resource representing a response of vaulted a ACH Debit Account.
        /// </summary>
        [JsonProperty("ach_debit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ACHDebitResponse AchDebit { get; set; }

        /// <summary>
        /// Gets or sets SepaDebit.
        /// </summary>
        [JsonProperty("sepa_debit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SEPADebitResponse SepaDebit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BankPaymentToken : ({string.Join(", ", toStringOutput)})";
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
            return obj is BankPaymentToken other &&                ((this.AchDebit == null && other.AchDebit == null) || (this.AchDebit?.Equals(other.AchDebit) == true)) &&
                ((this.SepaDebit == null && other.SepaDebit == null) || (this.SepaDebit?.Equals(other.SepaDebit) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AchDebit = {(this.AchDebit == null ? "null" : this.AchDebit.ToString())}");
            toStringOutput.Add($"this.SepaDebit = {(this.SepaDebit == null ? "null" : this.SepaDebit.ToString())}");
        }
    }
}