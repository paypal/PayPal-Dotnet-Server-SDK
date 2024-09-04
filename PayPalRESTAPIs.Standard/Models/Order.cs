// <copyright file="Order.cs" company="APIMatic">
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
    /// Order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        public Order()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        /// <param name="createTime">create_time.</param>
        /// <param name="updateTime">update_time.</param>
        /// <param name="id">id.</param>
        /// <param name="paymentSource">payment_source.</param>
        /// <param name="intent">intent.</param>
        /// <param name="processingInstruction">processing_instruction.</param>
        /// <param name="payer">payer.</param>
        /// <param name="purchaseUnits">purchase_units.</param>
        /// <param name="status">status.</param>
        /// <param name="links">links.</param>
        public Order(
            string createTime = null,
            string updateTime = null,
            string id = null,
            Models.PaymentSourceResponse paymentSource = null,
            Models.CheckoutPaymentIntent? intent = null,
            Models.ProcessingInstruction? processingInstruction = Models.ProcessingInstruction.NOINSTRUCTION,
            Models.Payer payer = null,
            List<Models.PurchaseUnit> purchaseUnits = null,
            Models.OrderStatus? status = null,
            List<Models.LinkDescription> links = null)
        {
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.Id = id;
            this.PaymentSource = paymentSource;
            this.Intent = intent;
            this.ProcessingInstruction = processingInstruction;
            this.Payer = payer;
            this.PurchaseUnits = purchaseUnits;
            this.Status = status;
            this.Links = links;
        }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// The ID of the order.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The payment source used to fund the payment.
        /// </summary>
        [JsonProperty("payment_source", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentSourceResponse PaymentSource { get; set; }

        /// <summary>
        /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
        /// </summary>
        [JsonProperty("intent", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutPaymentIntent? Intent { get; set; }

        /// <summary>
        /// The instruction to process an order.
        /// </summary>
        [JsonProperty("processing_instruction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProcessingInstruction? ProcessingInstruction { get; set; }

        /// <summary>
        /// Gets or sets Payer.
        /// </summary>
        [JsonProperty("payer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Payer Payer { get; set; }

        /// <summary>
        /// An array of purchase units. Each purchase unit establishes a contract between a customer and merchant. Each purchase unit represents either a full or partial order that the customer intends to purchase from the merchant.
        /// </summary>
        [JsonProperty("purchase_units", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PurchaseUnit> PurchaseUnits { get; set; }

        /// <summary>
        /// The order status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderStatus? Status { get; set; }

        /// <summary>
        /// An array of request-related HATEOAS links. To complete payer approval, use the `approve` link to redirect the payer. The API caller has 3 hours (default setting, this which can be changed by your account manager to 24/48/72 hours to accommodate your use case) from the time the order is created, to redirect your payer. Once redirected, the API caller has 3 hours for the payer to approve the order and either authorize or capture the order. If you are not using the PayPal JavaScript SDK to initiate PayPal Checkout (in context) ensure that you include `application_context.return_url` is specified or you will get "We're sorry, Things don't appear to be working at the moment" after the payer approves the payment.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LinkDescription> Links { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Order : ({string.Join(", ", toStringOutput)})";
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
            return obj is Order other &&                ((this.CreateTime == null && other.CreateTime == null) || (this.CreateTime?.Equals(other.CreateTime) == true)) &&
                ((this.UpdateTime == null && other.UpdateTime == null) || (this.UpdateTime?.Equals(other.UpdateTime) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.PaymentSource == null && other.PaymentSource == null) || (this.PaymentSource?.Equals(other.PaymentSource) == true)) &&
                ((this.Intent == null && other.Intent == null) || (this.Intent?.Equals(other.Intent) == true)) &&
                ((this.ProcessingInstruction == null && other.ProcessingInstruction == null) || (this.ProcessingInstruction?.Equals(other.ProcessingInstruction) == true)) &&
                ((this.Payer == null && other.Payer == null) || (this.Payer?.Equals(other.Payer) == true)) &&
                ((this.PurchaseUnits == null && other.PurchaseUnits == null) || (this.PurchaseUnits?.Equals(other.PurchaseUnits) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Links == null && other.Links == null) || (this.Links?.Equals(other.Links) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreateTime = {(this.CreateTime == null ? "null" : this.CreateTime)}");
            toStringOutput.Add($"this.UpdateTime = {(this.UpdateTime == null ? "null" : this.UpdateTime)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.PaymentSource = {(this.PaymentSource == null ? "null" : this.PaymentSource.ToString())}");
            toStringOutput.Add($"this.Intent = {(this.Intent == null ? "null" : this.Intent.ToString())}");
            toStringOutput.Add($"this.ProcessingInstruction = {(this.ProcessingInstruction == null ? "null" : this.ProcessingInstruction.ToString())}");
            toStringOutput.Add($"this.Payer = {(this.Payer == null ? "null" : this.Payer.ToString())}");
            toStringOutput.Add($"this.PurchaseUnits = {(this.PurchaseUnits == null ? "null" : $"[{string.Join(", ", this.PurchaseUnits)} ]")}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
        }
    }
}