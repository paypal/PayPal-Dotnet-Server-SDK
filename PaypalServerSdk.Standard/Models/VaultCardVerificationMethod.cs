// <copyright file="VaultCardVerificationMethod.cs" company="APIMatic">
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
    /// VaultCardVerificationMethod.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum VaultCardVerificationMethod
    {
        /// <summary>
        ///When an authorization or transaction is attempted this option will return a contingency and HATEOAS link only when local regulations require strong customer authentication, (e.g. 3DS in countries and use cases where it is mandated). The API caller should redirect the payer to the link so that they can authenticate themselves. In all cases, when an authorization is requested the AVS/CVV results will be returned in the response.
        /// ScaWhenRequired.
        /// </summary>
        [EnumMember(Value = "SCA_WHEN_REQUIRED")]
        ScaWhenRequired,

        /// <summary>
        ///Selecting this option will attempt to force a strong customer authentication for the authorization/transaction. In countries where SCA has been defined and implemented it will result in a contingency and HATEOAS link being returned.  The API caller should redirect the payer to that link so that they can authenticate themselves against their issuing bank or other entity. As noted, the HATEOAS link is only available in all regions where strong authentication is supported, (e.g. in European countries where 3DS is live). Merchants can use this setting as an additional layer of security if they choose to. In all cases, when an authorization is requested the AVS/CVV results will be returned in the response.
        /// ScaAlways.
        /// </summary>
        [EnumMember(Value = "SCA_ALWAYS")]
        ScaAlways,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}