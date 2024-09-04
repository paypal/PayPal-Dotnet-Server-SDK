// <copyright file="OAuthProviderError.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using PayPalRESTAPIs.Standard;
using PayPalRESTAPIs.Standard.Utilities;

namespace PayPalRESTAPIs.Standard.Models
{
    /// <summary>
    /// OAuthProviderError.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OAuthProviderError
    {
        /// <summary>
        ///The request is missing a required parameter, includes an unsupported parameter value (other than grant type), repeats a parameter, includes multiple credentials, utilizes more than one mechanism for authenticating the client, or is otherwise malformed.
        /// InvalidRequest.
        /// </summary>
        [EnumMember(Value = "invalid_request")]
        InvalidRequest,

        /// <summary>
        ///Client authentication failed (e.g., unknown client, no client authentication included, or unsupported authentication method).
        /// InvalidClient.
        /// </summary>
        [EnumMember(Value = "invalid_client")]
        InvalidClient,

        /// <summary>
        ///The provided authorization grant (e.g., authorization code, resource owner credentials) or refresh token is invalid, expired, revoked, does not match the redirection URI used in the authorization request, or was issued to another client.
        /// InvalidGrant.
        /// </summary>
        [EnumMember(Value = "invalid_grant")]
        InvalidGrant,

        /// <summary>
        ///The authenticated client is not authorized to use this authorization grant type.
        /// UnauthorizedClient.
        /// </summary>
        [EnumMember(Value = "unauthorized_client")]
        UnauthorizedClient,

        /// <summary>
        ///The authorization grant type is not supported by the authorization server.
        /// UnsupportedGrantType.
        /// </summary>
        [EnumMember(Value = "unsupported_grant_type")]
        UnsupportedGrantType,

        /// <summary>
        ///The requested scope is invalid, unknown, malformed, or exceeds the scope granted by the resource owner.
        /// InvalidScope.
        /// </summary>
        [EnumMember(Value = "invalid_scope")]
        InvalidScope
    }
}