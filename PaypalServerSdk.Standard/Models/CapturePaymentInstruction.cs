// <copyright file="CapturePaymentInstruction.cs" company="APIMatic">
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
    /// CapturePaymentInstruction.
    /// </summary>
    public class CapturePaymentInstruction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CapturePaymentInstruction"/> class.
        /// </summary>
        public CapturePaymentInstruction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapturePaymentInstruction"/> class.
        /// </summary>
        /// <param name="platformFees">platform_fees.</param>
        /// <param name="disbursementMode">disbursement_mode.</param>
        /// <param name="payeeReceivableFxRateId">payee_receivable_fx_rate_id.</param>
        public CapturePaymentInstruction(
            List<Models.PlatformFee> platformFees = null,
            Models.DisbursementMode? disbursementMode = Models.DisbursementMode.Instant,
            string payeeReceivableFxRateId = null)
        {
            this.PlatformFees = platformFees;
            this.DisbursementMode = disbursementMode;
            this.PayeeReceivableFxRateId = payeeReceivableFxRateId;
        }

        /// <summary>
        /// An array of platform or partner fees, commissions, or brokerage fees that associated with the captured payment.
        /// </summary>
        [JsonProperty("platform_fees", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PlatformFee> PlatformFees { get; set; }

        /// <summary>
        /// The funds that are held on behalf of the merchant.
        /// </summary>
        [JsonProperty("disbursement_mode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DisbursementMode? DisbursementMode { get; set; }

        /// <summary>
        /// FX identifier generated returned by PayPal to be used for payment processing in order to honor FX rate (for eligible integrations) to be used when amount is settled/received into the payee account.
        /// </summary>
        [JsonProperty("payee_receivable_fx_rate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayeeReceivableFxRateId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CapturePaymentInstruction : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CapturePaymentInstruction other &&
                (this.PlatformFees == null && other.PlatformFees == null ||
                 this.PlatformFees?.Equals(other.PlatformFees) == true) &&
                (this.DisbursementMode == null && other.DisbursementMode == null ||
                 this.DisbursementMode?.Equals(other.DisbursementMode) == true) &&
                (this.PayeeReceivableFxRateId == null && other.PayeeReceivableFxRateId == null ||
                 this.PayeeReceivableFxRateId?.Equals(other.PayeeReceivableFxRateId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PlatformFees = {(this.PlatformFees == null ? "null" : $"[{string.Join(", ", this.PlatformFees)} ]")}");
            toStringOutput.Add($"DisbursementMode = {(this.DisbursementMode == null ? "null" : this.DisbursementMode.ToString())}");
            toStringOutput.Add($"PayeeReceivableFxRateId = {this.PayeeReceivableFxRateId ?? "null"}");
        }
    }
}