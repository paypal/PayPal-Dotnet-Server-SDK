// <copyright file="ParticipantMetadata.cs" company="APIMatic">
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
    /// ParticipantMetadata.
    /// </summary>
    public class ParticipantMetadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantMetadata"/> class.
        /// </summary>
        public ParticipantMetadata()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantMetadata"/> class.
        /// </summary>
        /// <param name="ipAddress">ip_address.</param>
        public ParticipantMetadata(
            string ipAddress = null)
        {
            this.IpAddress = ipAddress;
        }

        /// <summary>
        /// An Internet Protocol address (IP address). This address assigns a numerical label to each device that is connected to a computer network through the Internet Protocol. Supports IPv4 and IPv6 addresses.
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ParticipantMetadata : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ParticipantMetadata other &&
                (this.IpAddress == null && other.IpAddress == null ||
                 this.IpAddress?.Equals(other.IpAddress) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"IpAddress = {this.IpAddress ?? "null"}");
        }
    }
}