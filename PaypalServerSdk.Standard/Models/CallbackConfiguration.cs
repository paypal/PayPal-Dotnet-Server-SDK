// <copyright file="CallbackConfiguration.cs" company="APIMatic">
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
    /// CallbackConfiguration.
    /// </summary>
    public class CallbackConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackConfiguration"/> class.
        /// </summary>
        public CallbackConfiguration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackConfiguration"/> class.
        /// </summary>
        /// <param name="callbackEvents">callback_events.</param>
        /// <param name="callbackUrl">callback_url.</param>
        public CallbackConfiguration(
            List<Models.CallbackEvents> callbackEvents,
            string callbackUrl)
        {
            this.CallbackEvents = callbackEvents;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// An array of callback events merchant can subscribe to for the corresponding callback url. The SHIPPING_ADDRESS callback event is required.
        /// </summary>
        [JsonProperty("callback_events")]
        public List<Models.CallbackEvents> CallbackEvents { get; set; }

        /// <summary>
        /// Merchant provided CallBack url.PayPal/Venmo will use this url to call the merchant back when the events occur .PayPal/Venmo expects a secured url usually in the https format.merchant can append the cart id or other params part of the url as query or path params.
        /// </summary>
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CallbackConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CallbackConfiguration other &&
                (this.CallbackEvents == null && other.CallbackEvents == null ||
                 this.CallbackEvents?.Equals(other.CallbackEvents) == true) &&
                (this.CallbackUrl == null && other.CallbackUrl == null ||
                 this.CallbackUrl?.Equals(other.CallbackUrl) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CallbackEvents = {(this.CallbackEvents == null ? "null" : $"[{string.Join(", ", this.CallbackEvents)} ]")}");
            toStringOutput.Add($"CallbackUrl = {this.CallbackUrl ?? "null"}");
        }
    }
}