// <copyright file="ShippingDetails.cs" company="APIMatic">
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
    /// ShippingDetails.
    /// </summary>
    public class ShippingDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingDetails"/> class.
        /// </summary>
        public ShippingDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingDetails"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="phoneNumber">phone_number.</param>
        /// <param name="type">type.</param>
        /// <param name="options">options.</param>
        /// <param name="address">address.</param>
        public ShippingDetails(
            Models.ShippingName name = null,
            Models.PhoneNumberWithCountryCode phoneNumber = null,
            Models.FullfillmentType? type = null,
            List<Models.ShippingOption> options = null,
            Models.Address address = null)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Options = options;
            this.Address = address;
        }

        /// <summary>
        /// The name of the party.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShippingName Name { get; set; }

        /// <summary>
        /// The phone number in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PhoneNumberWithCountryCode PhoneNumber { get; set; }

        /// <summary>
        /// A classification for the method of purchase fulfillment (e.g shipping, in-store pickup, etc). Either `type` or `options` may be present, but not both.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FullfillmentType? Type { get; set; }

        /// <summary>
        /// An array of shipping options that the payee or merchant offers to the payer to ship or pick up their items.
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ShippingOption> Options { get; set; }

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address Address { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ShippingDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is ShippingDetails other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.PhoneNumber == null && other.PhoneNumber == null) || (this.PhoneNumber?.Equals(other.PhoneNumber) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Options == null && other.Options == null) || (this.Options?.Equals(other.Options) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"this.PhoneNumber = {(this.PhoneNumber == null ? "null" : this.PhoneNumber.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Options = {(this.Options == null ? "null" : $"[{string.Join(", ", this.Options)} ]")}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
        }
    }
}