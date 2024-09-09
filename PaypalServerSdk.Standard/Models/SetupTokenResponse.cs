// <copyright file="SetupTokenResponse.cs" company="APIMatic">
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
    /// SetupTokenResponse.
    /// </summary>
    public class SetupTokenResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetupTokenResponse"/> class.
        /// </summary>
        public SetupTokenResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetupTokenResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="ordinal">ordinal.</param>
        /// <param name="customer">customer.</param>
        /// <param name="status">status.</param>
        /// <param name="paymentSource">payment_source.</param>
        /// <param name="links">links.</param>
        public SetupTokenResponse(
            string id = null,
            int? ordinal = null,
            Models.CustomerRequest customer = null,
            string status = "CREATED",
            Models.SetupTokenResponsePaymentSource paymentSource = null,
            List<Models.LinkDescription> links = null)
        {
            this.Id = id;
            this.Ordinal = ordinal;
            this.Customer = customer;
            this.Status = status;
            this.PaymentSource = paymentSource;
            this.Links = links;
        }

        /// <summary>
        /// The PayPal-generated ID for the vault token.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Ordinal number for sorting.
        /// </summary>
        [JsonProperty("ordinal", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ordinal { get; set; }

        /// <summary>
        /// Customer in merchant's or partner's system of records.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerRequest Customer { get; set; }

        /// <summary>
        /// The status of the payment token.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// The setup payment method details.
        /// </summary>
        [JsonProperty("payment_source", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SetupTokenResponsePaymentSource PaymentSource { get; set; }

        /// <summary>
        /// An array of related [HATEOAS links](/api/rest/responses/#hateoas).
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LinkDescription> Links { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SetupTokenResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is SetupTokenResponse other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Ordinal == null && other.Ordinal == null) || (this.Ordinal?.Equals(other.Ordinal) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.PaymentSource == null && other.PaymentSource == null) || (this.PaymentSource?.Equals(other.PaymentSource) == true)) &&
                ((this.Links == null && other.Links == null) || (this.Links?.Equals(other.Links) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Ordinal = {(this.Ordinal == null ? "null" : this.Ordinal.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.PaymentSource = {(this.PaymentSource == null ? "null" : this.PaymentSource.ToString())}");
            toStringOutput.Add($"this.Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
        }
    }
}