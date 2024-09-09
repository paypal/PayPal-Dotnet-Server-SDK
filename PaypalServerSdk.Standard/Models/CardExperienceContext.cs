// <copyright file="CardExperienceContext.cs" company="APIMatic">
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
    /// CardExperienceContext.
    /// </summary>
    public class CardExperienceContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardExperienceContext"/> class.
        /// </summary>
        public CardExperienceContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardExperienceContext"/> class.
        /// </summary>
        /// <param name="returnUrl">return_url.</param>
        /// <param name="cancelUrl">cancel_url.</param>
        public CardExperienceContext(
            string returnUrl = null,
            string cancelUrl = null)
        {
            this.ReturnUrl = returnUrl;
            this.CancelUrl = cancelUrl;
        }

        /// <summary>
        /// Describes the URL.
        /// </summary>
        [JsonProperty("return_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Describes the URL.
        /// </summary>
        [JsonProperty("cancel_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CancelUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardExperienceContext : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardExperienceContext other &&                ((this.ReturnUrl == null && other.ReturnUrl == null) || (this.ReturnUrl?.Equals(other.ReturnUrl) == true)) &&
                ((this.CancelUrl == null && other.CancelUrl == null) || (this.CancelUrl?.Equals(other.CancelUrl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ReturnUrl = {(this.ReturnUrl == null ? "null" : this.ReturnUrl)}");
            toStringOutput.Add($"this.CancelUrl = {(this.CancelUrl == null ? "null" : this.CancelUrl)}");
        }
    }
}