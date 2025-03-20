// <copyright file="OrderAuthorizeRequest.cs" company="APIMatic">
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
    /// OrderAuthorizeRequest.
    /// </summary>
    public class OrderAuthorizeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAuthorizeRequest"/> class.
        /// </summary>
        public OrderAuthorizeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAuthorizeRequest"/> class.
        /// </summary>
        /// <param name="paymentSource">payment_source.</param>
        public OrderAuthorizeRequest(
            Models.OrderAuthorizeRequestPaymentSource paymentSource = null)
        {
            this.PaymentSource = paymentSource;
        }

        /// <summary>
        /// The payment source definition.
        /// </summary>
        [JsonProperty("payment_source", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderAuthorizeRequestPaymentSource PaymentSource { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderAuthorizeRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderAuthorizeRequest other &&
                (this.PaymentSource == null && other.PaymentSource == null ||
                 this.PaymentSource?.Equals(other.PaymentSource) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PaymentSource = {(this.PaymentSource == null ? "null" : this.PaymentSource.ToString())}");
        }
    }
}