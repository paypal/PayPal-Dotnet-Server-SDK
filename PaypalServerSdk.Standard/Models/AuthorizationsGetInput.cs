// <copyright file="AuthorizationsGetInput.cs" company="APIMatic">
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
    /// AuthorizationsGetInput.
    /// </summary>
    public class AuthorizationsGetInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationsGetInput"/> class.
        /// </summary>
        public AuthorizationsGetInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationsGetInput"/> class.
        /// </summary>
        /// <param name="authorizationId">authorization_id.</param>
        /// <param name="paypalAuthAssertion">PayPal-Auth-Assertion.</param>
        public AuthorizationsGetInput(
            string authorizationId,
            string paypalAuthAssertion = null)
        {
            this.AuthorizationId = authorizationId;
            this.PaypalAuthAssertion = paypalAuthAssertion;
        }

        /// <summary>
        /// The ID of the authorized payment for which to show details.
        /// </summary>
        [JsonProperty("authorization_id")]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion).<blockquote><strong>Note:</strong>For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject.</blockquote>
        /// </summary>
        [JsonProperty("PayPal-Auth-Assertion", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalAuthAssertion { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AuthorizationsGetInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is AuthorizationsGetInput other &&                ((this.AuthorizationId == null && other.AuthorizationId == null) || (this.AuthorizationId?.Equals(other.AuthorizationId) == true)) &&
                ((this.PaypalAuthAssertion == null && other.PaypalAuthAssertion == null) || (this.PaypalAuthAssertion?.Equals(other.PaypalAuthAssertion) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AuthorizationId = {(this.AuthorizationId == null ? "null" : this.AuthorizationId)}");
            toStringOutput.Add($"this.PaypalAuthAssertion = {(this.PaypalAuthAssertion == null ? "null" : this.PaypalAuthAssertion)}");
        }
    }
}