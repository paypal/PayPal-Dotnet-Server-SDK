// <copyright file="ActivityTimestamps.cs" company="APIMatic">
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
    /// ActivityTimestamps.
    /// </summary>
    public class ActivityTimestamps
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTimestamps"/> class.
        /// </summary>
        public ActivityTimestamps()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTimestamps"/> class.
        /// </summary>
        /// <param name="createTime">create_time.</param>
        /// <param name="updateTime">update_time.</param>
        public ActivityTimestamps(
            string createTime = null,
            string updateTime = null)
        {
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
        }

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

            return $"ActivityTimestamps : ({string.Join(", ", toStringOutput)})";
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
            return obj is ActivityTimestamps other &&                ((this.CreateTime == null && other.CreateTime == null) || (this.CreateTime?.Equals(other.CreateTime) == true)) &&
                ((this.UpdateTime == null && other.UpdateTime == null) || (this.UpdateTime?.Equals(other.UpdateTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreateTime = {(this.CreateTime == null ? "null" : this.CreateTime)}");
            toStringOutput.Add($"this.UpdateTime = {(this.UpdateTime == null ? "null" : this.UpdateTime)}");
        }
    }
}