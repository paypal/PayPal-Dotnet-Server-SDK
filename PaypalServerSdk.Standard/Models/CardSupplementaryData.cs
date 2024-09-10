// <copyright file="CardSupplementaryData.cs" company="APIMatic">
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
    /// CardSupplementaryData.
    /// </summary>
    public class CardSupplementaryData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardSupplementaryData"/> class.
        /// </summary>
        public CardSupplementaryData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardSupplementaryData"/> class.
        /// </summary>
        /// <param name="level2">level_2.</param>
        /// <param name="level3">level_3.</param>
        public CardSupplementaryData(
            Models.Level2CardProcessingData level2 = null,
            Models.Level3CardProcessingData level3 = null)
        {
            this.Level2 = level2;
            this.Level3 = level3;
        }

        /// <summary>
        /// The level 2 card processing data collections. If your merchant account has been configured for Level 2 processing this field will be passed to the processor on your behalf. Please contact your PayPal Technical Account Manager to define level 2 data for your business.
        /// </summary>
        [JsonProperty("level_2", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Level2CardProcessingData Level2 { get; set; }

        /// <summary>
        /// The level 3 card processing data collections, If your merchant account has been configured for Level 3 processing this field will be passed to the processor on your behalf. Please contact your PayPal Technical Account Manager to define level 3 data for your business.
        /// </summary>
        [JsonProperty("level_3", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Level3CardProcessingData Level3 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardSupplementaryData : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardSupplementaryData other &&                ((this.Level2 == null && other.Level2 == null) || (this.Level2?.Equals(other.Level2) == true)) &&
                ((this.Level3 == null && other.Level3 == null) || (this.Level3?.Equals(other.Level3) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Level2 = {(this.Level2 == null ? "null" : this.Level2.ToString())}");
            toStringOutput.Add($"this.Level3 = {(this.Level3 == null ? "null" : this.Level3.ToString())}");
        }
    }
}