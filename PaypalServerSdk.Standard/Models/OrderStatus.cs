// <copyright file="OrderStatus.cs" company="APIMatic">
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
    /// OrderStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum OrderStatus
    {
        /// <summary>
        ///The order was created with the specified context.
        /// Created.
        /// </summary>
        [EnumMember(Value = "CREATED")]
        Created,

        /// <summary>
        ///The order was saved and persisted. The order status continues to be in progress until a capture is made with final_capture = true for all purchase units within the order.
        /// Saved.
        /// </summary>
        [EnumMember(Value = "SAVED")]
        Saved,

        /// <summary>
        ///The customer approved the payment through the PayPal wallet or another form of guest or unbranded payment. For example, a card, bank account, or so on.
        /// Approved.
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        Approved,

        /// <summary>
        ///All purchase units in the order are voided.
        /// Voided.
        /// </summary>
        [EnumMember(Value = "VOIDED")]
        Voided,

        /// <summary>
        ///The intent of the Order was completed and a `payments` resource was created. A completed Order may have authorized a payment, captured an authorized payment, or in some cases, the payment may have been declined. Please verify the payment status under purchase_unitsArray.payments before proceeding with Order fulfillment.
        /// Completed.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,

        /// <summary>
        ///The order requires an action from the payer (e.g. 3DS authentication). Redirect the payer to the "rel":"payer-action" HATEOAS link returned as part of the response prior to authorizing or capturing the order. Some payment sources may not return a payer-action HATEOAS link (eg. MB WAY). For these payment sources the payer-action is managed by the scheme itself (eg. through SMS, email, in-app notification, etc).
        /// PayerActionRequired.
        /// </summary>
        [EnumMember(Value = "PAYER_ACTION_REQUIRED")]
        PayerActionRequired,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}