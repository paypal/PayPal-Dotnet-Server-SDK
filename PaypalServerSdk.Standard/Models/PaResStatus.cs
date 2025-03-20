// <copyright file="PaResStatus.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using PaypalServerSdk.Standard;
using PaypalServerSdk.Standard.Utilities;

namespace PaypalServerSdk.Standard.Models
{
    /// <summary>
    /// PaResStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaResStatus
    {
        /// <summary>
        ///Successful authentication.
        /// SuccessfulAuthentication.
        /// </summary>
        [EnumMember(Value = "Y")]
        SuccessfulAuthentication,

        /// <summary>
        ///Failed authentication / account not verified / transaction denied.
        /// FailedAuthentication.
        /// </summary>
        [EnumMember(Value = "N")]
        FailedAuthentication,

        /// <summary>
        ///Unable to complete authentication.
        /// UnableToCompleteAuthentication.
        /// </summary>
        [EnumMember(Value = "U")]
        UnableToCompleteAuthentication,

        /// <summary>
        ///Successful attempts transaction.
        /// SuccessfulAttemptsTransaction.
        /// </summary>
        [EnumMember(Value = "A")]
        SuccessfulAttemptsTransaction,

        /// <summary>
        ///Challenge required for authentication.
        /// ChallengeRequired.
        /// </summary>
        [EnumMember(Value = "C")]
        ChallengeRequired,

        /// <summary>
        ///Authentication rejected (merchant must not submit for authorization).
        /// AuthenticationRejected.
        /// </summary>
        [EnumMember(Value = "R")]
        AuthenticationRejected,

        /// <summary>
        ///Challenge required; decoupled authentication confirmed.
        /// DecoupledAuthentication.
        /// </summary>
        [EnumMember(Value = "D")]
        DecoupledAuthentication,

        /// <summary>
        ///Informational only; 3DS requestor challenge preference acknowledged.
        /// InformationalOnly.
        /// </summary>
        [EnumMember(Value = "I")]
        InformationalOnly,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}