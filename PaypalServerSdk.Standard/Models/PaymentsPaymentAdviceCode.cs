// <copyright file="PaymentsPaymentAdviceCode.cs" company="APIMatic">
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
    /// PaymentsPaymentAdviceCode.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaymentsPaymentAdviceCode
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
        ///For Mastercard, the card holder has been unsuccessful at canceling recurring payment through merchant. Stop recurring payment requests. For Visa, all recurring payments were canceled for the card number requested. Stop recurring payment requests.
        /// PaymentAdvice21.
        /// </summary>
        [EnumMember(Value = "21")]
        PaymentAdvice21,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}