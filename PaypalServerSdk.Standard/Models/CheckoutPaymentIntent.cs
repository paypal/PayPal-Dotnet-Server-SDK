// <copyright file="CheckoutPaymentIntent.cs" company="APIMatic">
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
    /// CheckoutPaymentIntent.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CheckoutPaymentIntent
    {
        /// <summary>
        ///The merchant intends to capture payment immediately after the customer makes a payment.
        /// Capture.
        /// </summary>
        [EnumMember(Value = "CAPTURE")]
        Capture,

        /// <summary>
        ///The merchant intends to authorize a payment and place funds on hold after the customer makes a payment. Authorized payments are best captured within three days of authorization but are available to capture for up to 29 days. After the three-day honor period, the original authorized payment expires and you must re-authorize the payment. You must make a separate request to capture payments on demand. This intent is not supported when you have more than one `purchase_unit` within your order.
        /// Authorize.
        /// </summary>
        [EnumMember(Value = "AUTHORIZE")]
        Authorize,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}