// <copyright file="Level3CardProcessingData.cs" company="APIMatic">
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
    /// Level3CardProcessingData.
    /// </summary>
    public class Level3CardProcessingData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Level3CardProcessingData"/> class.
        /// </summary>
        public Level3CardProcessingData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Level3CardProcessingData"/> class.
        /// </summary>
        /// <param name="shippingAmount">shipping_amount.</param>
        /// <param name="dutyAmount">duty_amount.</param>
        /// <param name="discountAmount">discount_amount.</param>
        /// <param name="shippingAddress">shipping_address.</param>
        /// <param name="shipsFromPostalCode">ships_from_postal_code.</param>
        /// <param name="lineItems">line_items.</param>
        public Level3CardProcessingData(
            Models.Money shippingAmount = null,
            Models.Money dutyAmount = null,
            Models.Money discountAmount = null,
            Models.Address shippingAddress = null,
            string shipsFromPostalCode = null,
            List<Models.LineItem> lineItems = null)
        {
            this.ShippingAmount = shippingAmount;
            this.DutyAmount = dutyAmount;
            this.DiscountAmount = discountAmount;
            this.ShippingAddress = shippingAddress;
            this.ShipsFromPostalCode = shipsFromPostalCode;
            this.LineItems = lineItems;
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("shipping_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money ShippingAmount { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("duty_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money DutyAmount { get; set; }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money DiscountAmount { get; set; }

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address ShippingAddress { get; set; }

        /// <summary>
        /// Use this field to specify the postal code of the shipping location.
        /// </summary>
        [JsonProperty("ships_from_postal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ShipsFromPostalCode { get; set; }

        /// <summary>
        /// A list of the items that were purchased with this payment. If your merchant account has been configured for Level 3 processing this field will be passed to the processor on your behalf.
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LineItem> LineItems { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Level3CardProcessingData : ({string.Join(", ", toStringOutput)})";
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
            return obj is Level3CardProcessingData other &&                ((this.ShippingAmount == null && other.ShippingAmount == null) || (this.ShippingAmount?.Equals(other.ShippingAmount) == true)) &&
                ((this.DutyAmount == null && other.DutyAmount == null) || (this.DutyAmount?.Equals(other.DutyAmount) == true)) &&
                ((this.DiscountAmount == null && other.DiscountAmount == null) || (this.DiscountAmount?.Equals(other.DiscountAmount) == true)) &&
                ((this.ShippingAddress == null && other.ShippingAddress == null) || (this.ShippingAddress?.Equals(other.ShippingAddress) == true)) &&
                ((this.ShipsFromPostalCode == null && other.ShipsFromPostalCode == null) || (this.ShipsFromPostalCode?.Equals(other.ShipsFromPostalCode) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ShippingAmount = {(this.ShippingAmount == null ? "null" : this.ShippingAmount.ToString())}");
            toStringOutput.Add($"this.DutyAmount = {(this.DutyAmount == null ? "null" : this.DutyAmount.ToString())}");
            toStringOutput.Add($"this.DiscountAmount = {(this.DiscountAmount == null ? "null" : this.DiscountAmount.ToString())}");
            toStringOutput.Add($"this.ShippingAddress = {(this.ShippingAddress == null ? "null" : this.ShippingAddress.ToString())}");
            toStringOutput.Add($"this.ShipsFromPostalCode = {(this.ShipsFromPostalCode == null ? "null" : this.ShipsFromPostalCode)}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
        }
    }
}