// <copyright file="RefundRequest.cs" company="APIMatic">
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
    /// RefundRequest.
    /// </summary>
    public class RefundRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundRequest"/> class.
        /// </summary>
        public RefundRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="customId">custom_id.</param>
        /// <param name="invoiceId">invoice_id.</param>
        /// <param name="noteToPayer">note_to_payer.</param>
        /// <param name="paymentInstruction">payment_instruction.</param>
        public RefundRequest(
            Models.Money amount = null,
            string customId = null,
            string invoiceId = null,
            string noteToPayer = null,
            Models.RefundPaymentInstruction paymentInstruction = null)
        {
            this.Amount = amount;
            this.CustomId = customId;
            this.InvoiceId = invoiceId;
            this.NoteToPayer = noteToPayer;
            this.PaymentInstruction = paymentInstruction;
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Amount { get; set; }

        /// <summary>
        /// The API caller-provided external ID. Used to reconcile API caller-initiated transactions with PayPal transactions. Appears in transaction and settlement reports. The pattern is defined by an external party and supports Unicode.
        /// </summary>
        [JsonProperty("custom_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomId { get; set; }

        /// <summary>
        /// The API caller-provided external invoice ID for this order. The pattern is defined by an external party and supports Unicode.
        /// </summary>
        [JsonProperty("invoice_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives. The pattern is defined by an external party and supports Unicode.
        /// </summary>
        [JsonProperty("note_to_payer", NullValueHandling = NullValueHandling.Ignore)]
        public string NoteToPayer { get; set; }

        /// <summary>
        /// Any additional payments instructions during refund payment processing. This object is only applicable to merchants that have been enabled for PayPal Commerce Platform for Marketplaces and Platforms capability. Please speak to your account manager if you want to use this capability.
        /// </summary>
        [JsonProperty("payment_instruction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RefundPaymentInstruction PaymentInstruction { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RefundRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is RefundRequest other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.CustomId == null && other.CustomId == null) || (this.CustomId?.Equals(other.CustomId) == true)) &&
                ((this.InvoiceId == null && other.InvoiceId == null) || (this.InvoiceId?.Equals(other.InvoiceId) == true)) &&
                ((this.NoteToPayer == null && other.NoteToPayer == null) || (this.NoteToPayer?.Equals(other.NoteToPayer) == true)) &&
                ((this.PaymentInstruction == null && other.PaymentInstruction == null) || (this.PaymentInstruction?.Equals(other.PaymentInstruction) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.CustomId = {(this.CustomId == null ? "null" : this.CustomId)}");
            toStringOutput.Add($"this.InvoiceId = {(this.InvoiceId == null ? "null" : this.InvoiceId)}");
            toStringOutput.Add($"this.NoteToPayer = {(this.NoteToPayer == null ? "null" : this.NoteToPayer)}");
            toStringOutput.Add($"this.PaymentInstruction = {(this.PaymentInstruction == null ? "null" : this.PaymentInstruction.ToString())}");
        }
    }
}