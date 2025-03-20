// <copyright file="ThreeDSecureCardAuthenticationResponse.cs" company="APIMatic">
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
    /// ThreeDSecureCardAuthenticationResponse.
    /// </summary>
    public class ThreeDSecureCardAuthenticationResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSecureCardAuthenticationResponse"/> class.
        /// </summary>
        public ThreeDSecureCardAuthenticationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSecureCardAuthenticationResponse"/> class.
        /// </summary>
        /// <param name="authenticationStatus">authentication_status.</param>
        /// <param name="enrollmentStatus">enrollment_status.</param>
        /// <param name="authenticationId">authentication_id.</param>
        public ThreeDSecureCardAuthenticationResponse(
            Models.PaResStatus? authenticationStatus = null,
            Models.EnrollmentStatus? enrollmentStatus = null,
            string authenticationId = null)
        {
            this.AuthenticationStatus = authenticationStatus;
            this.EnrollmentStatus = enrollmentStatus;
            this.AuthenticationId = authenticationId;
        }

        /// <summary>
        /// Transactions status result identifier. The outcome of the issuer's authentication.
        /// </summary>
        [JsonProperty("authentication_status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaResStatus? AuthenticationStatus { get; set; }

        /// <summary>
        /// Status of Authentication eligibility.
        /// </summary>
        [JsonProperty("enrollment_status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EnrollmentStatus? EnrollmentStatus { get; set; }

        /// <summary>
        /// The externally received 3ds authentication id, to be returned in card detokenization response.
        /// </summary>
        [JsonProperty("authentication_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ThreeDSecureCardAuthenticationResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ThreeDSecureCardAuthenticationResponse other &&
                (this.AuthenticationStatus == null && other.AuthenticationStatus == null ||
                 this.AuthenticationStatus?.Equals(other.AuthenticationStatus) == true) &&
                (this.EnrollmentStatus == null && other.EnrollmentStatus == null ||
                 this.EnrollmentStatus?.Equals(other.EnrollmentStatus) == true) &&
                (this.AuthenticationId == null && other.AuthenticationId == null ||
                 this.AuthenticationId?.Equals(other.AuthenticationId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AuthenticationStatus = {(this.AuthenticationStatus == null ? "null" : this.AuthenticationStatus.ToString())}");
            toStringOutput.Add($"EnrollmentStatus = {(this.EnrollmentStatus == null ? "null" : this.EnrollmentStatus.ToString())}");
            toStringOutput.Add($"AuthenticationId = {this.AuthenticationId ?? "null"}");
        }
    }
}