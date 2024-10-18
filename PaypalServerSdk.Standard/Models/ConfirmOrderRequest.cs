// <copyright file="ConfirmOrderRequest.cs" company="APIMatic">
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
    /// ConfirmOrderRequest.
    /// </summary>
    public class ConfirmOrderRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmOrderRequest"/> class.
        /// </summary>
        public ConfirmOrderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmOrderRequest"/> class.
        /// </summary>
        /// <param name="paymentSource">payment_source.</param>
        /// <param name="processingInstruction">processing_instruction.</param>
        /// <param name="applicationContext">application_context.</param>
        public ConfirmOrderRequest(
            Models.PaymentSource paymentSource,
            Models.ProcessingInstruction? processingInstruction = Models.ProcessingInstruction.NoInstruction,
            Models.OrderConfirmApplicationContext applicationContext = null)
        {
            this.PaymentSource = paymentSource;
            this.ProcessingInstruction = processingInstruction;
            this.ApplicationContext = applicationContext;
        }

        /// <summary>
        /// The payment source definition.
        /// </summary>
        [JsonProperty("payment_source")]
        public Models.PaymentSource PaymentSource { get; set; }

        /// <summary>
        /// The instruction to process an order.
        /// </summary>
        [JsonProperty("processing_instruction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProcessingInstruction? ProcessingInstruction { get; set; }

        /// <summary>
        /// Customizes the payer confirmation experience.
        /// </summary>
        [JsonProperty("application_context", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderConfirmApplicationContext ApplicationContext { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConfirmOrderRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ConfirmOrderRequest other &&                ((this.PaymentSource == null && other.PaymentSource == null) || (this.PaymentSource?.Equals(other.PaymentSource) == true)) &&
                ((this.ProcessingInstruction == null && other.ProcessingInstruction == null) || (this.ProcessingInstruction?.Equals(other.ProcessingInstruction) == true)) &&
                ((this.ApplicationContext == null && other.ApplicationContext == null) || (this.ApplicationContext?.Equals(other.ApplicationContext) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PaymentSource = {(this.PaymentSource == null ? "null" : this.PaymentSource.ToString())}");
            toStringOutput.Add($"this.ProcessingInstruction = {(this.ProcessingInstruction == null ? "null" : this.ProcessingInstruction.ToString())}");
            toStringOutput.Add($"this.ApplicationContext = {(this.ApplicationContext == null ? "null" : this.ApplicationContext.ToString())}");
        }
    }
}