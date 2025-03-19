// <copyright file="PaypalExperienceLandingPage.cs" company="APIMatic">
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
    /// PaypalExperienceLandingPage.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaypalExperienceLandingPage
    {
        /// <summary>
        ///When the customer clicks PayPal Checkout, the customer is redirected to a page to log in to PayPal and approve the payment.
        /// Login.
        /// </summary>
        [EnumMember(Value = "LOGIN")]
        Login,

        /// <summary>
        ///When the customer clicks PayPal Checkout, the customer is redirected to a page to enter credit or debit card and other relevant billing information required to complete the purchase. This option has previously been also called as 'BILLING'
        /// GuestCheckout.
        /// </summary>
        [EnumMember(Value = "GUEST_CHECKOUT")]
        GuestCheckout,

        /// <summary>
        ///When the customer clicks PayPal Checkout, the customer is redirected to either a page to log in to PayPal and approve the payment or to a page to enter credit or debit card and other relevant billing information required to complete the purchase, depending on their previous interaction with PayPal.
        /// NoPreference.
        /// </summary>
        [EnumMember(Value = "NO_PREFERENCE")]
        NoPreference,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}