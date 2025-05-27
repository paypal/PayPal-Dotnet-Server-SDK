// <copyright file="PaypalWalletContactPreference.cs" company="APIMatic">
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
    /// PaypalWalletContactPreference.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaypalWalletContactPreference
    {
        /// <summary>
        ///The merchant can opt out of showing buyer's contact information on PayPal checkout.
        /// NoContactInfo.
        /// </summary>
        [EnumMember(Value = "NO_CONTACT_INFO")]
        NoContactInfo,

        /// <summary>
        ///The merchant allows buyer to add or update shipping contact information on the PayPal checkout. Please ensure to use this updated information returned in shipping.email_address and shipping.phone_number to contact your buyers.
        /// UpdateContactInfo.
        /// </summary>
        [EnumMember(Value = "UPDATE_CONTACT_INFO")]
        UpdateContactInfo,

        /// <summary>
        ///The buyer can only see but can not override merchant passed contact information (shipping.email_address and shipping.phone_number) on PayPal checkout. NOTE: If you don't pass the contact information, the behavior is the same as NO_CONTACT_INFO preference.
        /// RetainContactInfo.
        /// </summary>
        [EnumMember(Value = "RETAIN_CONTACT_INFO")]
        RetainContactInfo,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}