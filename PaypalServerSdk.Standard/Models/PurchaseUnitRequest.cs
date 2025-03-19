// <copyright file="PurchaseUnitRequest.cs" company="APIMatic">
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
    /// PurchaseUnitRequest.
    /// </summary>
    public class PurchaseUnitRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseUnitRequest"/> class.
        /// </summary>
        public PurchaseUnitRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseUnitRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="referenceId">reference_id.</param>
        /// <param name="payee">payee.</param>
        /// <param name="paymentInstruction">payment_instruction.</param>
        /// <param name="description">description.</param>
        /// <param name="customId">custom_id.</param>
        /// <param name="invoiceId">invoice_id.</param>
        /// <param name="softDescriptor">soft_descriptor.</param>
        /// <param name="items">items.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="supplementaryData">supplementary_data.</param>
        public PurchaseUnitRequest(
            Models.AmountWithBreakdown amount,
            string referenceId = null,
            Models.PayeeBase payee = null,
            Models.PaymentInstruction paymentInstruction = null,
            string description = null,
            string customId = null,
            string invoiceId = null,
            string softDescriptor = null,
            List<Models.Item> items = null,
            Models.ShippingDetails shipping = null,
            Models.SupplementaryData supplementaryData = null)
        {
            this.ReferenceId = referenceId;
            this.Amount = amount;
            this.Payee = payee;
            this.PaymentInstruction = paymentInstruction;
            this.Description = description;
            this.CustomId = customId;
            this.InvoiceId = invoiceId;
            this.SoftDescriptor = softDescriptor;
            this.Items = items;
            this.Shipping = shipping;
            this.SupplementaryData = supplementaryData;
        }

        /// <summary>
        /// The API caller-provided external ID for the purchase unit. Required for multiple purchase units when you must update the order through `PATCH`. If you omit this value and the order contains only one purchase unit, PayPal sets this value to `default`.
        /// </summary>
        [JsonProperty("reference_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping, handling, insurance, and discounts, if any. If you specify `amount.breakdown`, the amount equals `item_total` plus `tax_total` plus `shipping` plus `handling` plus `insurance` minus `shipping_discount` minus discount. The amount must be a positive number. For listed of supported currencies and decimal precision, see the PayPal REST APIs Currency Codes.
        /// </summary>
        [JsonProperty("amount")]
        public Models.AmountWithBreakdown Amount { get; set; }

        /// <summary>
        /// The merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
        /// </summary>
        [JsonProperty("payee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayeeBase Payee { get; set; }

        /// <summary>
        /// Any additional payment instructions to be consider during payment processing. This processing instruction is applicable for Capturing an order or Authorizing an Order.
        /// </summary>
        [JsonProperty("payment_instruction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentInstruction PaymentInstruction { get; set; }

        /// <summary>
        /// The purchase description. The maximum length of the character is dependent on the type of characters used. The character length is specified assuming a US ASCII character. Depending on type of character; (e.g. accented character, Japanese characters) the number of characters that that can be specified as input might not equal the permissible max length.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The API caller-provided external ID. Used to reconcile client transactions with PayPal transactions. Appears in transaction and settlement reports but is not visible to the payer.
        /// </summary>
        [JsonProperty("custom_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomId { get; set; }

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [JsonProperty("invoice_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// The soft descriptor is the dynamic text used to construct the statement descriptor that appears on a payer's card statement. If an Order is paid using the "PayPal Wallet", the statement descriptor will appear in following format on the payer's card statement: PAYPAL_prefix+(space)+merchant_descriptor+(space)+ soft_descriptor Note: The merchant descriptor is the descriptor of the merchant’s payment receiving preferences which can be seen by logging into the merchant account https://www.sandbox.paypal.com/businessprofile/settings/info/edit The PAYPAL prefix uses 8 characters. Only the first 22 characters will be displayed in the statement. For example, if: The PayPal prefix toggle is PAYPAL *. The merchant descriptor in the profile is Janes Gift. The soft descriptor is 800-123-1234. Then, the statement descriptor on the card is PAYPAL * Janes Gift 80.
        /// </summary>
        [JsonProperty("soft_descriptor", NullValueHandling = NullValueHandling.Ignore)]
        public string SoftDescriptor { get; set; }

        /// <summary>
        /// An array of items that the customer purchases from the merchant.
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Item> Items { get; set; }

        /// <summary>
        /// The shipping details.
        /// </summary>
        [JsonProperty("shipping", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShippingDetails Shipping { get; set; }

        /// <summary>
        /// Supplementary data about a payment. This object passes information that can be used to improve risk assessments and processing costs, for example, by providing Level 2 and Level 3 payment data.
        /// </summary>
        [JsonProperty("supplementary_data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SupplementaryData SupplementaryData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PurchaseUnitRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PurchaseUnitRequest other &&
                (this.ReferenceId == null && other.ReferenceId == null ||
                 this.ReferenceId?.Equals(other.ReferenceId) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Payee == null && other.Payee == null ||
                 this.Payee?.Equals(other.Payee) == true) &&
                (this.PaymentInstruction == null && other.PaymentInstruction == null ||
                 this.PaymentInstruction?.Equals(other.PaymentInstruction) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.CustomId == null && other.CustomId == null ||
                 this.CustomId?.Equals(other.CustomId) == true) &&
                (this.InvoiceId == null && other.InvoiceId == null ||
                 this.InvoiceId?.Equals(other.InvoiceId) == true) &&
                (this.SoftDescriptor == null && other.SoftDescriptor == null ||
                 this.SoftDescriptor?.Equals(other.SoftDescriptor) == true) &&
                (this.Items == null && other.Items == null ||
                 this.Items?.Equals(other.Items) == true) &&
                (this.Shipping == null && other.Shipping == null ||
                 this.Shipping?.Equals(other.Shipping) == true) &&
                (this.SupplementaryData == null && other.SupplementaryData == null ||
                 this.SupplementaryData?.Equals(other.SupplementaryData) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ReferenceId = {this.ReferenceId ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Payee = {(this.Payee == null ? "null" : this.Payee.ToString())}");
            toStringOutput.Add($"PaymentInstruction = {(this.PaymentInstruction == null ? "null" : this.PaymentInstruction.ToString())}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"CustomId = {this.CustomId ?? "null"}");
            toStringOutput.Add($"InvoiceId = {this.InvoiceId ?? "null"}");
            toStringOutput.Add($"SoftDescriptor = {this.SoftDescriptor ?? "null"}");
            toStringOutput.Add($"Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"SupplementaryData = {(this.SupplementaryData == null ? "null" : this.SupplementaryData.ToString())}");
        }
    }
}