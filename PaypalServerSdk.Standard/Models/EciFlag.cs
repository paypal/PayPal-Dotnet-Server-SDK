// <copyright file="EciFlag.cs" company="APIMatic">
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
    /// EciFlag.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum EciFlag
    {
        /// <summary>
        ///Mastercard non-3-D Secure transaction.
        /// MastercardNon3DSecureTransaction.
        /// </summary>
        [EnumMember(Value = "MASTERCARD_NON_3D_SECURE_TRANSACTION")]
        MastercardNon3DSecureTransaction,

        /// <summary>
        ///Mastercard attempted authentication transaction.
        /// MastercardAttemptedAuthenticationTransaction.
        /// </summary>
        [EnumMember(Value = "MASTERCARD_ATTEMPTED_AUTHENTICATION_TRANSACTION")]
        MastercardAttemptedAuthenticationTransaction,

        /// <summary>
        ///Mastercard fully authenticated transaction.
        /// MastercardFullyAuthenticatedTransaction.
        /// </summary>
        [EnumMember(Value = "MASTERCARD_FULLY_AUTHENTICATED_TRANSACTION")]
        MastercardFullyAuthenticatedTransaction,

        /// <summary>
        ///VISA, AMEX, JCB, DINERS CLUB fully authenticated transaction.
        /// FullyAuthenticatedTransaction.
        /// </summary>
        [EnumMember(Value = "FULLY_AUTHENTICATED_TRANSACTION")]
        FullyAuthenticatedTransaction,

        /// <summary>
        ///VISA, AMEX, JCB, DINERS CLUB attempted authentication transaction.
        /// AttemptedAuthenticationTransaction.
        /// </summary>
        [EnumMember(Value = "ATTEMPTED_AUTHENTICATION_TRANSACTION")]
        AttemptedAuthenticationTransaction,

        /// <summary>
        ///VISA, AMEX, JCB, DINERS CLUB non-3-D Secure transaction.
        /// Non3DSecureTransaction.
        /// </summary>
        [EnumMember(Value = "NON_3D_SECURE_TRANSACTION")]
        Non3DSecureTransaction,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}