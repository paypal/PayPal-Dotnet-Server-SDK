// <copyright file="PaymentAdviceCode.cs" company="APIMatic">
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
    /// PaymentAdviceCode.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaymentAdviceCode
    {
        /// <summary>
        ///For Mastercard, expired card account upgrade or portfolio sale conversion. Obtain new account information before next billing cycle.
        /// PaymentAdvice01.
        /// </summary>
        [EnumMember(Value = "01")]
        PaymentAdvice01,

        /// <summary>
        ///For Mastercard, over credit limit or insufficient funds. Retry the transaction 72 hours later. For Visa, the card holder wants to stop only one specific payment in the recurring payment relationship. The merchant must NOT resubmit the same transaction. The merchant can continue the billing process in the subsequent billing period.
        /// PaymentAdvice02.
        /// </summary>
        [EnumMember(Value = "02")]
        PaymentAdvice02,

        /// <summary>
        ///For Mastercard, account closed as fraudulent. Obtain another type of payment from customer due to account being closed or fraud. Possible reason: Account closed as fraudulent. For Visa, the card holder wants to stop all recurring payment transactions for a specific merchant. Stop recurring payment requests.
        /// PaymentAdvice03.
        /// </summary>
        [EnumMember(Value = "03")]
        PaymentAdvice03,

        /// <summary>
        ///For Mastercard, token requirements not fulfilled for this token type.
        /// PaymentAdvice04.
        /// </summary>
        [EnumMember(Value = "04")]
        PaymentAdvice04,

        /// <summary>
        ///For Mastercard, the card holder has been unsuccessful at canceling recurring payment through merchant. Stop recurring payment requests. For Visa, all recurring payments were canceled for the card number requested. Stop recurring payment requests.
        /// PaymentAdvice21.
        /// </summary>
        [EnumMember(Value = "21")]
        PaymentAdvice21,

        /// <summary>
        ///For Mastercard, merchant does not qualify for product code.
        /// PaymentAdvice22.
        /// </summary>
        [EnumMember(Value = "22")]
        PaymentAdvice22,

        /// <summary>
        ///For Mastercard, retry after 1 hour.
        /// PaymentAdvice24.
        /// </summary>
        [EnumMember(Value = "24")]
        PaymentAdvice24,

        /// <summary>
        ///For Mastercard, retry after 24 hours.
        /// PaymentAdvice25.
        /// </summary>
        [EnumMember(Value = "25")]
        PaymentAdvice25,

        /// <summary>
        ///For Mastercard, retry after 2 days.
        /// PaymentAdvice26.
        /// </summary>
        [EnumMember(Value = "26")]
        PaymentAdvice26,

        /// <summary>
        ///For Mastercard, retry after 4 days.
        /// PaymentAdvice27.
        /// </summary>
        [EnumMember(Value = "27")]
        PaymentAdvice27,

        /// <summary>
        ///For Mastercard, retry after 6 days.
        /// PaymentAdvice28.
        /// </summary>
        [EnumMember(Value = "28")]
        PaymentAdvice28,

        /// <summary>
        ///For Mastercard, retry after 8 days.
        /// PaymentAdvice29.
        /// </summary>
        [EnumMember(Value = "29")]
        PaymentAdvice29,

        /// <summary>
        ///For Mastercard, retry after 10 days .
        /// PaymentAdvice30.
        /// </summary>
        [EnumMember(Value = "30")]
        PaymentAdvice30,

        /// <summary>
        ///For Mastercard, consumer non-reloadable prepaid card.
        /// PaymentAdvice40.
        /// </summary>
        [EnumMember(Value = "40")]
        PaymentAdvice40,

        /// <summary>
        ///For Mastercard, consumer multi-use virtual card number.
        /// PaymentAdvice43.
        /// </summary>
        [EnumMember(Value = "43")]
        PaymentAdvice43,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}