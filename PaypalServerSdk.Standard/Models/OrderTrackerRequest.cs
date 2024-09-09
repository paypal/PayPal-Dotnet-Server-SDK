// <copyright file="OrderTrackerRequest.cs" company="APIMatic">
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
    /// OrderTrackerRequest.
    /// </summary>
    public class OrderTrackerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTrackerRequest"/> class.
        /// </summary>
        public OrderTrackerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTrackerRequest"/> class.
        /// </summary>
        /// <param name="captureId">capture_id.</param>
        /// <param name="trackingNumber">tracking_number.</param>
        /// <param name="carrier">carrier.</param>
        /// <param name="carrierNameOther">carrier_name_other.</param>
        /// <param name="notifyPayer">notify_payer.</param>
        /// <param name="items">items.</param>
        public OrderTrackerRequest(
            string captureId,
            string trackingNumber = null,
            Models.ShipmentCarrier? carrier = null,
            string carrierNameOther = null,
            bool? notifyPayer = false,
            List<Models.OrderTrackerItem> items = null)
        {
            this.TrackingNumber = trackingNumber;
            this.Carrier = carrier;
            this.CarrierNameOther = carrierNameOther;
            this.CaptureId = captureId;
            this.NotifyPayer = notifyPayer;
            this.Items = items;
        }

        /// <summary>
        /// The tracking number for the shipment. This property supports Unicode.
        /// </summary>
        [JsonProperty("tracking_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// The carrier for the shipment. Some carriers have a global version as well as local subsidiaries. The subsidiaries are repeated over many countries and might also have an entry in the global list. Choose the carrier for your country. If the carrier is not available for your country, choose the global version of the carrier. If your carrier name is not in the list, set `carrier` to `OTHER` and set carrier name in `carrier_name_other`. For allowed values, see <a href="/docs/tracking/reference/carriers/">Carriers</a>.
        /// </summary>
        [JsonProperty("carrier", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShipmentCarrier? Carrier { get; set; }

        /// <summary>
        /// The name of the carrier for the shipment. Provide this value only if the carrier parameter is OTHER. This property supports Unicode.
        /// </summary>
        [JsonProperty("carrier_name_other", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierNameOther { get; set; }

        /// <summary>
        /// The PayPal capture ID.
        /// </summary>
        [JsonProperty("capture_id")]
        public string CaptureId { get; set; }

        /// <summary>
        /// If true, sends an email notification to the payer of the PayPal transaction. The email contains the tracking information that was uploaded through the API.
        /// </summary>
        [JsonProperty("notify_payer", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyPayer { get; set; }

        /// <summary>
        /// An array of details of items in the shipment.
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.OrderTrackerItem> Items { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderTrackerRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is OrderTrackerRequest other &&                ((this.TrackingNumber == null && other.TrackingNumber == null) || (this.TrackingNumber?.Equals(other.TrackingNumber) == true)) &&
                ((this.Carrier == null && other.Carrier == null) || (this.Carrier?.Equals(other.Carrier) == true)) &&
                ((this.CarrierNameOther == null && other.CarrierNameOther == null) || (this.CarrierNameOther?.Equals(other.CarrierNameOther) == true)) &&
                ((this.CaptureId == null && other.CaptureId == null) || (this.CaptureId?.Equals(other.CaptureId) == true)) &&
                ((this.NotifyPayer == null && other.NotifyPayer == null) || (this.NotifyPayer?.Equals(other.NotifyPayer) == true)) &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TrackingNumber = {(this.TrackingNumber == null ? "null" : this.TrackingNumber)}");
            toStringOutput.Add($"this.Carrier = {(this.Carrier == null ? "null" : this.Carrier.ToString())}");
            toStringOutput.Add($"this.CarrierNameOther = {(this.CarrierNameOther == null ? "null" : this.CarrierNameOther)}");
            toStringOutput.Add($"this.CaptureId = {(this.CaptureId == null ? "null" : this.CaptureId)}");
            toStringOutput.Add($"this.NotifyPayer = {(this.NotifyPayer == null ? "null" : this.NotifyPayer.ToString())}");
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
        }
    }
}