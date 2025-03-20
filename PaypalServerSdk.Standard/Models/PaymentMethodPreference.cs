// <copyright file="PaymentMethodPreference.cs" company="APIMatic">
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
    /// PaymentMethodPreference.
    /// </summary>
    public class PaymentMethodPreference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodPreference"/> class.
        /// </summary>
        public PaymentMethodPreference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodPreference"/> class.
        /// </summary>
        /// <param name="payeePreferred">payee_preferred.</param>
        /// <param name="standardEntryClassCode">standard_entry_class_code.</param>
        public PaymentMethodPreference(
            Models.PayeePaymentMethodPreference? payeePreferred = Models.PayeePaymentMethodPreference.Unrestricted,
            Models.StandardEntryClassCode? standardEntryClassCode = Models.StandardEntryClassCode.Web)
        {
            this.PayeePreferred = payeePreferred;
            this.StandardEntryClassCode = standardEntryClassCode;
        }

        /// <summary>
        /// The merchant-preferred payment methods.
        /// </summary>
        [JsonProperty("payee_preferred", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayeePaymentMethodPreference? PayeePreferred { get; set; }

        /// <summary>
        /// NACHA (the regulatory body governing the ACH network) requires that API callers (merchants, partners) obtain the consumer’s explicit authorization before initiating a transaction. To stay compliant, you’ll need to make sure that you retain a compliant authorization for each transaction that you originate to the ACH Network using this API. ACH transactions are categorized (using SEC codes) by how you capture authorization from the Receiver (the person whose bank account is being debited or credited). PayPal supports the following SEC codes.
        /// </summary>
        [JsonProperty("standard_entry_class_code", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StandardEntryClassCode? StandardEntryClassCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaymentMethodPreference : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaymentMethodPreference other &&
                (this.PayeePreferred == null && other.PayeePreferred == null ||
                 this.PayeePreferred?.Equals(other.PayeePreferred) == true) &&
                (this.StandardEntryClassCode == null && other.StandardEntryClassCode == null ||
                 this.StandardEntryClassCode?.Equals(other.StandardEntryClassCode) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PayeePreferred = {(this.PayeePreferred == null ? "null" : this.PayeePreferred.ToString())}");
            toStringOutput.Add($"StandardEntryClassCode = {(this.StandardEntryClassCode == null ? "null" : this.StandardEntryClassCode.ToString())}");
        }
    }
}