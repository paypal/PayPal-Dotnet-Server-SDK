// <copyright file="PurchaseUnit.cs" company="APIMatic">
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
    /// PurchaseUnit.
    /// </summary>
    public class PurchaseUnit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseUnit"/> class.
        /// </summary>
        public PurchaseUnit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseUnit"/> class.
        /// </summary>
        /// <param name="referenceId">reference_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="payee">payee.</param>
        /// <param name="paymentInstruction">payment_instruction.</param>
        /// <param name="description">description.</param>
        /// <param name="customId">custom_id.</param>
        /// <param name="invoiceId">invoice_id.</param>
        /// <param name="id">id.</param>
        /// <param name="softDescriptor">soft_descriptor.</param>
        /// <param name="items">items.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="supplementaryData">supplementary_data.</param>
        /// <param name="payments">payments.</param>
        /// <param name="mostRecentErrors">most_recent_errors.</param>
        public PurchaseUnit(
            string referenceId = null,
            Models.AmountWithBreakdown amount = null,
            Models.Payee payee = null,
            Models.PaymentInstruction paymentInstruction = null,
            string description = null,
            string customId = null,
            string invoiceId = null,
            string id = null,
            string softDescriptor = null,
            List<Models.Item> items = null,
            Models.ShippingWithTrackingDetails shipping = null,
            Models.SupplementaryData supplementaryData = null,
            Models.PaymentCollection payments = null,
            List<JsonValue> mostRecentErrors = null)
        {
            this.ReferenceId = referenceId;
            this.Amount = amount;
            this.Payee = payee;
            this.PaymentInstruction = paymentInstruction;
            this.Description = description;
            this.CustomId = customId;
            this.InvoiceId = invoiceId;
            this.Id = id;
            this.SoftDescriptor = softDescriptor;
            this.Items = items;
            this.Shipping = shipping;
            this.SupplementaryData = supplementaryData;
            this.Payments = payments;
            this.MostRecentErrors = mostRecentErrors;
        }

        /// <summary>
        /// The API caller-provided external ID for the purchase unit. Required for multiple purchase units when you must update the order through `PATCH`. If you omit this value and the order contains only one purchase unit, PayPal sets this value to `default`. <blockquote><strong>Note:</strong> If there are multiple purchase units, <code>reference_id</code> is required for each purchase unit.</blockquote>
        /// </summary>
        [JsonProperty("reference_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.<br/>If you specify `amount.breakdown`, the amount equals `item_total` plus `tax_total` plus `shipping` plus `handling` plus `insurance` minus `shipping_discount` minus discount.<br/>The amount must be a positive number. For listed of supported currencies and decimal precision, see the PayPal REST APIs <a href="/docs/integration/direct/rest/currency-codes/">Currency Codes</a>.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AmountWithBreakdown Amount { get; set; }

        /// <summary>
        /// The merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
        /// </summary>
        [JsonProperty("payee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Payee Payee { get; set; }

        /// <summary>
        /// Any additional payment instructions to be consider during payment processing. This processing instruction is applicable for Capturing an order or Authorizing an Order.
        /// </summary>
        [JsonProperty("payment_instruction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentInstruction PaymentInstruction { get; set; }

        /// <summary>
        /// The purchase description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The API caller-provided external ID. Used to reconcile API caller-initiated transactions with PayPal transactions. Appears in transaction and settlement reports.
        /// </summary>
        [JsonProperty("custom_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomId { get; set; }

        /// <summary>
        /// The API caller-provided external invoice ID for this order.
        /// </summary>
        [JsonProperty("invoice_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// The PayPal-generated ID for the purchase unit. This ID appears in both the payer's transaction history and the emails that the payer receives. In addition, this ID is available in transaction and settlement reports that merchants and API callers can use to reconcile transactions. This ID is only available when an order is saved by calling <code>v2/checkout/orders/id/save</code>.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The payment descriptor on account transactions on the customer's credit card statement, that PayPal sends to processors. The maximum length of the soft descriptor information that you can pass in the API field is 22 characters, in the following format:<code>22 - len(PAYPAL * (8)) - len(<var>Descriptor in Payment Receiving Preferences of Merchant account</var> + 1)</code>The PAYPAL prefix uses 8 characters.<br/><br/>The soft descriptor supports the following ASCII characters:<ul><li>Alphanumeric characters</li><li>Dashes</li><li>Asterisks</li><li>Periods (.)</li><li>Spaces</li></ul>For Wallet payments marketplace integrations:<ul><li>The merchant descriptor in the Payment Receiving Preferences must be the marketplace name.</li><li>You can't use the remaining space to show the customer service number.</li><li>The remaining spaces can be a combination of seller name and country.</li></ul><br/>For unbranded payments (Direct Card) marketplace integrations, use a combination of the seller name and phone number.
        /// </summary>
        [JsonProperty("soft_descriptor", NullValueHandling = NullValueHandling.Ignore)]
        public string SoftDescriptor { get; set; }

        /// <summary>
        /// An array of items that the customer purchases from the merchant.
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Item> Items { get; set; }

        /// <summary>
        /// The order shipping details.
        /// </summary>
        [JsonProperty("shipping", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShippingWithTrackingDetails Shipping { get; set; }

        /// <summary>
        /// Supplementary data about a payment. This object passes information that can be used to improve risk assessments and processing costs, for example, by providing Level 2 and Level 3 payment data.
        /// </summary>
        [JsonProperty("supplementary_data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SupplementaryData SupplementaryData { get; set; }

        /// <summary>
        /// The collection of payments, or transactions, for a purchase unit in an order. For example, authorized payments, captured payments, and refunds.
        /// </summary>
        [JsonProperty("payments", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentCollection Payments { get; set; }

        /// <summary>
        /// The error reason code and description that are the reason for the most recent order decline.
        /// </summary>
        [JsonProperty("most_recent_errors", NullValueHandling = NullValueHandling.Ignore)]
        public List<JsonValue> MostRecentErrors { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PurchaseUnit : ({string.Join(", ", toStringOutput)})";
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
            return obj is PurchaseUnit other &&                ((this.ReferenceId == null && other.ReferenceId == null) || (this.ReferenceId?.Equals(other.ReferenceId) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Payee == null && other.Payee == null) || (this.Payee?.Equals(other.Payee) == true)) &&
                ((this.PaymentInstruction == null && other.PaymentInstruction == null) || (this.PaymentInstruction?.Equals(other.PaymentInstruction) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.CustomId == null && other.CustomId == null) || (this.CustomId?.Equals(other.CustomId) == true)) &&
                ((this.InvoiceId == null && other.InvoiceId == null) || (this.InvoiceId?.Equals(other.InvoiceId) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.SoftDescriptor == null && other.SoftDescriptor == null) || (this.SoftDescriptor?.Equals(other.SoftDescriptor) == true)) &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true)) &&
                ((this.Shipping == null && other.Shipping == null) || (this.Shipping?.Equals(other.Shipping) == true)) &&
                ((this.SupplementaryData == null && other.SupplementaryData == null) || (this.SupplementaryData?.Equals(other.SupplementaryData) == true)) &&
                ((this.Payments == null && other.Payments == null) || (this.Payments?.Equals(other.Payments) == true)) &&
                ((this.MostRecentErrors == null && other.MostRecentErrors == null) || (this.MostRecentErrors?.Equals(other.MostRecentErrors) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ReferenceId = {(this.ReferenceId == null ? "null" : this.ReferenceId)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Payee = {(this.Payee == null ? "null" : this.Payee.ToString())}");
            toStringOutput.Add($"this.PaymentInstruction = {(this.PaymentInstruction == null ? "null" : this.PaymentInstruction.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.CustomId = {(this.CustomId == null ? "null" : this.CustomId)}");
            toStringOutput.Add($"this.InvoiceId = {(this.InvoiceId == null ? "null" : this.InvoiceId)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.SoftDescriptor = {(this.SoftDescriptor == null ? "null" : this.SoftDescriptor)}");
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"this.Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"this.SupplementaryData = {(this.SupplementaryData == null ? "null" : this.SupplementaryData.ToString())}");
            toStringOutput.Add($"this.Payments = {(this.Payments == null ? "null" : this.Payments.ToString())}");
            toStringOutput.Add($"MostRecentErrors = {(this.MostRecentErrors == null ? "null" : this.MostRecentErrors.ToString())}");
        }
    }
}