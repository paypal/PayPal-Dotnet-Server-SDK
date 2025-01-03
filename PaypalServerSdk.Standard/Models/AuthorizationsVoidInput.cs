// <copyright file="AuthorizationsVoidInput.cs" company="APIMatic">
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
    /// AuthorizationsVoidInput.
    /// </summary>
    public class AuthorizationsVoidInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationsVoidInput"/> class.
        /// </summary>
        public AuthorizationsVoidInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationsVoidInput"/> class.
        /// </summary>
        /// <param name="authorizationId">authorization_id.</param>
        /// <param name="paypalAuthAssertion">PayPal-Auth-Assertion.</param>
        /// <param name="paypalRequestId">PayPal-Request-Id.</param>
        /// <param name="prefer">Prefer.</param>
        public AuthorizationsVoidInput(
            string authorizationId,
            string paypalAuthAssertion = null,
            string paypalRequestId = null,
            string prefer = "return=minimal")
        {
            this.AuthorizationId = authorizationId;
            this.PaypalAuthAssertion = paypalAuthAssertion;
            this.PaypalRequestId = paypalRequestId;
            this.Prefer = prefer;
        }

        /// <summary>
        /// The PayPal-generated ID for the authorized payment to void.
        /// </summary>
        [JsonProperty("authorization_id")]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion).<blockquote><strong>Note:</strong>For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject.</blockquote>
        /// </summary>
        [JsonProperty("PayPal-Auth-Assertion", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalAuthAssertion { get; set; }

        /// <summary>
        /// The server stores keys for 45 days.
        /// </summary>
        [JsonProperty("PayPal-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string PaypalRequestId { get; set; }

        /// <summary>
        /// The preferred server response upon successful completion of the request. Value is:<ul><li><code>return=minimal</code>. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the <code>id</code>, <code>status</code> and HATEOAS links.</li><li><code>return=representation</code>. The server returns a complete resource representation, including the current state of the resource.</li></ul>
        /// </summary>
        [JsonProperty("Prefer", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AuthorizationsVoidInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is AuthorizationsVoidInput other &&                ((this.AuthorizationId == null && other.AuthorizationId == null) || (this.AuthorizationId?.Equals(other.AuthorizationId) == true)) &&
                ((this.PaypalAuthAssertion == null && other.PaypalAuthAssertion == null) || (this.PaypalAuthAssertion?.Equals(other.PaypalAuthAssertion) == true)) &&
                ((this.PaypalRequestId == null && other.PaypalRequestId == null) || (this.PaypalRequestId?.Equals(other.PaypalRequestId) == true)) &&
                ((this.Prefer == null && other.Prefer == null) || (this.Prefer?.Equals(other.Prefer) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AuthorizationId = {(this.AuthorizationId == null ? "null" : this.AuthorizationId)}");
            toStringOutput.Add($"this.PaypalAuthAssertion = {(this.PaypalAuthAssertion == null ? "null" : this.PaypalAuthAssertion)}");
            toStringOutput.Add($"this.PaypalRequestId = {(this.PaypalRequestId == null ? "null" : this.PaypalRequestId)}");
            toStringOutput.Add($"this.Prefer = {(this.Prefer == null ? "null" : this.Prefer)}");
        }
    }
}