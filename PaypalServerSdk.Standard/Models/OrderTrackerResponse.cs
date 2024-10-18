// <copyright file="OrderTrackerResponse.cs" company="APIMatic">
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
    /// OrderTrackerResponse.
    /// </summary>
    public class OrderTrackerResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTrackerResponse"/> class.
        /// </summary>
        public OrderTrackerResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTrackerResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="items">items.</param>
        /// <param name="links">links.</param>
        /// <param name="createTime">create_time.</param>
        /// <param name="updateTime">update_time.</param>
        public OrderTrackerResponse(
            string id = null,
            Models.OrderTrackerStatus? status = null,
            List<Models.OrderTrackerItem> items = null,
            List<Models.LinkDescription> links = null,
            string createTime = null,
            string updateTime = null)
        {
            this.Id = id;
            this.Status = status;
            this.Items = items;
            this.Links = links;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// The tracker id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The status of the item shipment.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderTrackerStatus? Status { get; set; }

        /// <summary>
        /// An array of details of items in the shipment.
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.OrderTrackerItem> Items { get; set; }

        /// <summary>
        /// An array of request-related HATEOAS links.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LinkDescription> Links { get; set; }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderTrackerResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is OrderTrackerResponse other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true)) &&
                ((this.Links == null && other.Links == null) || (this.Links?.Equals(other.Links) == true)) &&
                ((this.CreateTime == null && other.CreateTime == null) || (this.CreateTime?.Equals(other.CreateTime) == true)) &&
                ((this.UpdateTime == null && other.UpdateTime == null) || (this.UpdateTime?.Equals(other.UpdateTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"this.Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"this.CreateTime = {(this.CreateTime == null ? "null" : this.CreateTime)}");
            toStringOutput.Add($"this.UpdateTime = {(this.UpdateTime == null ? "null" : this.UpdateTime)}");
        }
    }
}