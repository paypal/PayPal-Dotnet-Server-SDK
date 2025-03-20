// <copyright file="CaptureRequest.cs" company="APIMatic">
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
    /// CaptureRequest.
    /// </summary>
    public class CaptureRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureRequest"/> class.
        /// </summary>
        public CaptureRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureRequest"/> class.
        /// </summary>
        /// <param name="invoiceId">invoice_id.</param>
        /// <param name="noteToPayer">note_to_payer.</param>
        /// <param name="amount">amount.</param>
        /// <param name="finalCapture">final_capture.</param>
        /// <param name="paymentInstruction">payment_instruction.</param>
        /// <param name="softDescriptor">soft_descriptor.</param>
        public CaptureRequest(
            string invoiceId = null,
            string noteToPayer = null,
            Models.Money amount = null,
            bool? finalCapture = false,
            Models.CapturePaymentInstruction paymentInstruction = null,
            string softDescriptor = null)
        {
            this.InvoiceId = invoiceId;
            this.NoteToPayer = noteToPayer;
            this.Amount = amount;
            this.FinalCapture = finalCapture;
            this.PaymentInstruction = paymentInstruction;
            this.SoftDescriptor = softDescriptor;
        }

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [JsonProperty("invoice_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// An informational note about this settlement. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [JsonProperty("note_to_payer", NullValueHandling = NullValueHandling.Ignore)]
        public string NoteToPayer { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Amount { get; set; }

        /// <summary>
        /// Indicates whether you can make additional captures against the authorized payment. Set to `true` if you do not intend to capture additional payments against the authorization. Set to `false` if you intend to capture additional payments against the authorization.
        /// </summary>
        [JsonProperty("final_capture", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FinalCapture { get; set; }

        /// <summary>
        /// Any additional payment instructions to be consider during payment processing. This processing instruction is applicable for Capturing an order or Authorizing an Order.
        /// </summary>
        [JsonProperty("payment_instruction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CapturePaymentInstruction PaymentInstruction { get; set; }

        /// <summary>
        /// The payment descriptor on the payer's account statement.
        /// </summary>
        [JsonProperty("soft_descriptor", NullValueHandling = NullValueHandling.Ignore)]
        public string SoftDescriptor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CaptureRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CaptureRequest other &&
                (this.InvoiceId == null && other.InvoiceId == null ||
                 this.InvoiceId?.Equals(other.InvoiceId) == true) &&
                (this.NoteToPayer == null && other.NoteToPayer == null ||
                 this.NoteToPayer?.Equals(other.NoteToPayer) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.FinalCapture == null && other.FinalCapture == null ||
                 this.FinalCapture?.Equals(other.FinalCapture) == true) &&
                (this.PaymentInstruction == null && other.PaymentInstruction == null ||
                 this.PaymentInstruction?.Equals(other.PaymentInstruction) == true) &&
                (this.SoftDescriptor == null && other.SoftDescriptor == null ||
                 this.SoftDescriptor?.Equals(other.SoftDescriptor) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"InvoiceId = {this.InvoiceId ?? "null"}");
            toStringOutput.Add($"NoteToPayer = {this.NoteToPayer ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"FinalCapture = {(this.FinalCapture == null ? "null" : this.FinalCapture.ToString())}");
            toStringOutput.Add($"PaymentInstruction = {(this.PaymentInstruction == null ? "null" : this.PaymentInstruction.ToString())}");
            toStringOutput.Add($"SoftDescriptor = {this.SoftDescriptor ?? "null"}");
        }
    }
}