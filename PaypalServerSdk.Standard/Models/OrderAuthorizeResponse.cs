// <copyright file="OrderAuthorizeResponse.cs" company="APIMatic">
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
    /// OrderAuthorizeResponse.
    /// </summary>
    public class OrderAuthorizeResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAuthorizeResponse"/> class.
        /// </summary>
        public OrderAuthorizeResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAuthorizeResponse"/> class.
        /// </summary>
        /// <param name="createTime">create_time.</param>
        /// <param name="updateTime">update_time.</param>
        /// <param name="id">id.</param>
        /// <param name="paymentSource">payment_source.</param>
        /// <param name="intent">intent.</param>
        /// <param name="payer">payer.</param>
        /// <param name="purchaseUnits">purchase_units.</param>
        /// <param name="status">status.</param>
        /// <param name="links">links.</param>
        public OrderAuthorizeResponse(
            string createTime = null,
            string updateTime = null,
            string id = null,
            Models.OrderAuthorizeResponsePaymentSource paymentSource = null,
            Models.CheckoutPaymentIntent? intent = null,
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
            this.Payer = payer;
            this.PurchaseUnits = purchaseUnits;
            this.Status = status;
            this.Links = links;
        }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.
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
        public Models.OrderAuthorizeResponsePaymentSource PaymentSource { get; set; }

        /// <summary>
        /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
        /// </summary>
        [JsonProperty("intent", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutPaymentIntent? Intent { get; set; }

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
        /// An array of request-related [HATEOAS links](/api/rest/responses/#hateoas-links) that are either relevant to the issue by providing additional information or offering potential resolutions.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LinkDescription> Links { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderAuthorizeResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderAuthorizeResponse other &&
                (this.CreateTime == null && other.CreateTime == null ||
                 this.CreateTime?.Equals(other.CreateTime) == true) &&
                (this.UpdateTime == null && other.UpdateTime == null ||
                 this.UpdateTime?.Equals(other.UpdateTime) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.PaymentSource == null && other.PaymentSource == null ||
                 this.PaymentSource?.Equals(other.PaymentSource) == true) &&
                (this.Intent == null && other.Intent == null ||
                 this.Intent?.Equals(other.Intent) == true) &&
                (this.Payer == null && other.Payer == null ||
                 this.Payer?.Equals(other.Payer) == true) &&
                (this.PurchaseUnits == null && other.PurchaseUnits == null ||
                 this.PurchaseUnits?.Equals(other.PurchaseUnits) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Links == null && other.Links == null ||
                 this.Links?.Equals(other.Links) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CreateTime = {this.CreateTime ?? "null"}");
            toStringOutput.Add($"UpdateTime = {this.UpdateTime ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"PaymentSource = {(this.PaymentSource == null ? "null" : this.PaymentSource.ToString())}");
            toStringOutput.Add($"Intent = {(this.Intent == null ? "null" : this.Intent.ToString())}");
            toStringOutput.Add($"Payer = {(this.Payer == null ? "null" : this.Payer.ToString())}");
            toStringOutput.Add($"PurchaseUnits = {(this.PurchaseUnits == null ? "null" : $"[{string.Join(", ", this.PurchaseUnits)} ]")}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
        }
    }
}