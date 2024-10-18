// <copyright file="ShippingName.cs" company="APIMatic">
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
    /// ShippingName.
    /// </summary>
    public class ShippingName
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingName"/> class.
        /// </summary>
        public ShippingName()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingName"/> class.
        /// </summary>
        /// <param name="fullName">full_name.</param>
        public ShippingName(
            string fullName = null)
        {
            this.FullName = fullName;
        }

        /// <summary>
        /// When the party is a person, the party's full name.
        /// </summary>
        [JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FullName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ShippingName : ({string.Join(", ", toStringOutput)})";
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
            return obj is ShippingName other &&                ((this.FullName == null && other.FullName == null) || (this.FullName?.Equals(other.FullName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FullName = {(this.FullName == null ? "null" : this.FullName)}");
        }
    }
}