// <copyright file="PayPalWalletVaultResponse.cs" company="APIMatic">
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
    /// PayPalWalletVaultResponse.
    /// </summary>
    public class PayPalWalletVaultResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalWalletVaultResponse"/> class.
        /// </summary>
        public PayPalWalletVaultResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalWalletVaultResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="links">links.</param>
        /// <param name="customer">customer.</param>
        public PayPalWalletVaultResponse(
            string id = null,
            Models.PayPalWalletVaultStatus? status = null,
            List<Models.LinkDescription> links = null,
            Models.PayPalWalletCustomer customer = null)
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
        public Models.PayPalWalletVaultStatus? Status { get; set; }

        /// <summary>
        /// An array of request-related HATEOAS links.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LinkDescription> Links { get; set; }

        /// <summary>
        /// The details about a customer in PayPal's system of record.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayPalWalletCustomer Customer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PayPalWalletVaultResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is PayPalWalletVaultResponse other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Links == null && other.Links == null) || (this.Links?.Equals(other.Links) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
        }
    }
}