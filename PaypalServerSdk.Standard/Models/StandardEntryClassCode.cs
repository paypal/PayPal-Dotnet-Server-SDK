// <copyright file="StandardEntryClassCode.cs" company="APIMatic">
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
    /// StandardEntryClassCode.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum StandardEntryClassCode
    {
        /// <summary>
        ///The API caller (merchant/partner) accepts authorization and payment information from a consumer over the telephone.
        /// Tel.
        /// </summary>
        [EnumMember(Value = "TEL")]
        Tel,

        /// <summary>
        ///The API caller (merchant/partner) accepts Debit transactions from a consumer on their website.
        /// Web.
        /// </summary>
        [EnumMember(Value = "WEB")]
        Web,

        /// <summary>
        ///Cash concentration and disbursement for corporate debit transaction. Used to disburse or consolidate funds. Entries are usually Optional high-dollar, low-volume, and time-critical. (e.g. intra-company transfers or invoice payments to suppliers).
        /// Ccd.
        /// </summary>
        [EnumMember(Value = "CCD")]
        Ccd,

        /// <summary>
        ///Prearranged payment and deposit entries. Used for debit payments authorized by a consumer account holder, and usually initiated by a company. These are usually recurring debits (such as insurance premiums).
        /// Ppd.
        /// </summary>
        [EnumMember(Value = "PPD")]
        Ppd,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}