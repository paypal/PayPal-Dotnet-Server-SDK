// <copyright file="PaypalWalletVaultResponse.cs" company="APIMatic">
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
    /// PaypalWalletVaultResponse.
    /// </summary>
    public class PaypalWalletVaultResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalWalletVaultResponse"/> class.
        /// </summary>
        public PaypalWalletVaultResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaypalWalletVaultResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="links">links.</param>
        /// <param name="customer">customer.</param>
        public PaypalWalletVaultResponse(
            string id = null,
            Models.PaypalWalletVaultStatus? status = null,
            List<Models.LinkDescription> links = null,
            Models.PaypalWalletCustomer customer = null)
        {
            this.Id = id;
            this.Status = status;
            this.Links = links;
            this.Customer = customer;
        }

        /// <summary>
        /// The PayPal-generated ID for the saved payment source.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The vault status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalWalletVaultStatus? Status { get; set; }

        /// <summary>
        /// An array of request-related HATEOAS links.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LinkDescription> Links { get; set; }

        /// <summary>
        /// The details about a customer in PayPal's system of record.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaypalWalletCustomer Customer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaypalWalletVaultResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaypalWalletVaultResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Links == null && other.Links == null ||
                 this.Links?.Equals(other.Links) == true) &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
        }
    }
}