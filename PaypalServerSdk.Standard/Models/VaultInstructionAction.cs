// <copyright file="VaultInstructionAction.cs" company="APIMatic">
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
    /// VaultInstructionAction.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum VaultInstructionAction
    {
        /// <summary>
        ///Vault the payment method after API caller performs a successful POST on Payment Tokens.
        /// OnCreatePaymentTokens.
        /// </summary>
        [EnumMember(Value = "ON_CREATE_PAYMENT_TOKENS")]
        OnCreatePaymentTokens,

        /// <summary>
        ///Vault the payment method on successful payer authentication and approval.
        /// OnPayerApproval.
        /// </summary>
        [EnumMember(Value = "ON_PAYER_APPROVAL")]
        OnPayerApproval,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}