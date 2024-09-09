// <copyright file="OrderRequest.cs" company="APIMatic">
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
using PaypalServerSDK.Standard;
using PaypalServerSDK.Standard.Utilities;

namespace PaypalServerSDK.Standard.Models
{
    /// <summary>
    /// OrderRequest.
    /// </summary>
    public class OrderRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequest"/> class.
        /// </summary>
        public OrderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequest"/> class.
        /// </summary>
        /// <param name="intent">intent.</param>
        /// <param name="purchaseUnits">purchase_units.</param>
        /// <param name="payer">payer.</param>
        /// <param name="paymentSource">payment_source.</param>
        /// <param name="applicationContext">application_context.</param>
        public OrderRequest(
            Models.CheckoutPaymentIntent intent,
            List<Models.PurchaseUnitRequest> purchaseUnits,
            Models.Payer payer = null,
            Models.PaymentSource paymentSource = null,
            Models.OrderApplicationContext applicationContext = null)
        {
            this.Intent = intent;
            this.Payer = payer;
            this.PurchaseUnits = purchaseUnits;
            this.PaymentSource = paymentSource;
            this.ApplicationContext = applicationContext;
        }

        /// <summary>
        /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
        /// </summary>
        [JsonProperty("intent")]
        public Models.CheckoutPaymentIntent Intent { get; set; }

        /// <summary>
        /// Gets or sets Payer.
        /// </summary>
        [JsonProperty("payer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Payer Payer { get; set; }

        /// <summary>
        /// An array of purchase units. Each purchase unit establishes a contract between a payer and the payee. Each purchase unit represents either a full or partial order that the payer intends to purchase from the payee.
        /// </summary>
        [JsonProperty("purchase_units")]
        public List<Models.PurchaseUnitRequest> PurchaseUnits { get; set; }

        /// <summary>
        /// The payment source definition.
        /// </summary>
        [JsonProperty("payment_source", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentSource PaymentSource { get; set; }

        /// <summary>
        /// Customizes the payer experience during the approval process for the payment with PayPal.<blockquote><strong>Note:</strong> Partners and Marketplaces might configure <code>brand_name</code> and <code>shipping_preference</code> during partner account setup, which overrides the request values.</blockquote>
        /// </summary>
        [JsonProperty("application_context", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderApplicationContext ApplicationContext { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is OrderRequest other &&                this.Intent.Equals(other.Intent) &&
                ((this.Payer == null && other.Payer == null) || (this.Payer?.Equals(other.Payer) == true)) &&
                ((this.PurchaseUnits == null && other.PurchaseUnits == null) || (this.PurchaseUnits?.Equals(other.PurchaseUnits) == true)) &&
                ((this.PaymentSource == null && other.PaymentSource == null) || (this.PaymentSource?.Equals(other.PaymentSource) == true)) &&
                ((this.ApplicationContext == null && other.ApplicationContext == null) || (this.ApplicationContext?.Equals(other.ApplicationContext) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Intent = {this.Intent}");
            toStringOutput.Add($"this.Payer = {(this.Payer == null ? "null" : this.Payer.ToString())}");
            toStringOutput.Add($"this.PurchaseUnits = {(this.PurchaseUnits == null ? "null" : $"[{string.Join(", ", this.PurchaseUnits)} ]")}");
            toStringOutput.Add($"this.PaymentSource = {(this.PaymentSource == null ? "null" : this.PaymentSource.ToString())}");
            toStringOutput.Add($"this.ApplicationContext = {(this.ApplicationContext == null ? "null" : this.ApplicationContext.ToString())}");
        }
    }
}