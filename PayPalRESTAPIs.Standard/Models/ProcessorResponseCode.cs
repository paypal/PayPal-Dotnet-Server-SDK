// <copyright file="ProcessorResponseCode.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using PayPalRESTAPIs.Standard;
using PayPalRESTAPIs.Standard.Utilities;

namespace PayPalRESTAPIs.Standard.Models
{
    /// <summary>
    /// ProcessorResponseCode.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum ProcessorResponseCode
    {
        /// <summary>
        /// Enum0000.
        /// </summary>
        [EnumMember(Value = "0000")]
        Enum0000,

        /// <summary>
        /// Enum00N7.
        /// </summary>
        [EnumMember(Value = "00N7")]
        Enum00N7,

        /// <summary>
        /// Enum0100.
        /// </summary>
        [EnumMember(Value = "0100")]
        Enum0100,

        /// <summary>
        /// Enum0390.
        /// </summary>
        [EnumMember(Value = "0390")]
        Enum0390,

        /// <summary>
        /// Enum0500.
        /// </summary>
        [EnumMember(Value = "0500")]
        Enum0500,

        /// <summary>
        /// Enum0580.
        /// </summary>
        [EnumMember(Value = "0580")]
        Enum0580,

        /// <summary>
        /// Enum0800.
        /// </summary>
        [EnumMember(Value = "0800")]
        Enum0800,

        /// <summary>
        /// Enum0880.
        /// </summary>
        [EnumMember(Value = "0880")]
        Enum0880,

        /// <summary>
        /// Enum0890.
        /// </summary>
        [EnumMember(Value = "0890")]
        Enum0890,

        /// <summary>
        /// Enum0960.
        /// </summary>
        [EnumMember(Value = "0960")]
        Enum0960,

        /// <summary>
        /// Enum0R00.
        /// </summary>
        [EnumMember(Value = "0R00")]
        Enum0R00,

        /// <summary>
        /// Enum1000.
        /// </summary>
        [EnumMember(Value = "1000")]
        Enum1000,

        /// <summary>
        /// Enum10BR.
        /// </summary>
        [EnumMember(Value = "10BR")]
        Enum10BR,

        /// <summary>
        /// Enum1300.
        /// </summary>
        [EnumMember(Value = "1300")]
        Enum1300,

        /// <summary>
        /// Enum1310.
        /// </summary>
        [EnumMember(Value = "1310")]
        Enum1310,

        /// <summary>
        /// Enum1312.
        /// </summary>
        [EnumMember(Value = "1312")]
        Enum1312,

        /// <summary>
        /// Enum1317.
        /// </summary>
        [EnumMember(Value = "1317")]
        Enum1317,

        /// <summary>
        /// Enum1320.
        /// </summary>
        [EnumMember(Value = "1320")]
        Enum1320,

        /// <summary>
        /// Enum1330.
        /// </summary>
        [EnumMember(Value = "1330")]
        Enum1330,

        /// <summary>
        /// Enum1335.
        /// </summary>
        [EnumMember(Value = "1335")]
        Enum1335,

        /// <summary>
        /// Enum1340.
        /// </summary>
        [EnumMember(Value = "1340")]
        Enum1340,

        /// <summary>
        /// Enum1350.
        /// </summary>
        [EnumMember(Value = "1350")]
        Enum1350,

        /// <summary>
        /// Enum1352.
        /// </summary>
        [EnumMember(Value = "1352")]
        Enum1352,

        /// <summary>
        /// Enum1360.
        /// </summary>
        [EnumMember(Value = "1360")]
        Enum1360,

        /// <summary>
        /// Enum1370.
        /// </summary>
        [EnumMember(Value = "1370")]
        Enum1370,

        /// <summary>
        /// Enum1380.
        /// </summary>
        [EnumMember(Value = "1380")]
        Enum1380,

        /// <summary>
        /// Enum1382.
        /// </summary>
        [EnumMember(Value = "1382")]
        Enum1382,

        /// <summary>
        /// Enum1384.
        /// </summary>
        [EnumMember(Value = "1384")]
        Enum1384,

        /// <summary>
        /// Enum1390.
        /// </summary>
        [EnumMember(Value = "1390")]
        Enum1390,

        /// <summary>
        /// Enum1393.
        /// </summary>
        [EnumMember(Value = "1393")]
        Enum1393,

        /// <summary>
        /// Enum5100.
        /// </summary>
        [EnumMember(Value = "5100")]
        Enum5100,

        /// <summary>
        /// Enum5110.
        /// </summary>
        [EnumMember(Value = "5110")]
        Enum5110,

        /// <summary>
        /// Enum5120.
        /// </summary>
        [EnumMember(Value = "5120")]
        Enum5120,

        /// <summary>
        /// Enum5130.
        /// </summary>
        [EnumMember(Value = "5130")]
        Enum5130,

        /// <summary>
        /// Enum5135.
        /// </summary>
        [EnumMember(Value = "5135")]
        Enum5135,

        /// <summary>
        /// Enum5140.
        /// </summary>
        [EnumMember(Value = "5140")]
        Enum5140,

        /// <summary>
        /// Enum5150.
        /// </summary>
        [EnumMember(Value = "5150")]
        Enum5150,

        /// <summary>
        /// Enum5160.
        /// </summary>
        [EnumMember(Value = "5160")]
        Enum5160,

        /// <summary>
        /// Enum5170.
        /// </summary>
        [EnumMember(Value = "5170")]
        Enum5170,

        /// <summary>
        /// Enum5180.
        /// </summary>
        [EnumMember(Value = "5180")]
        Enum5180,

        /// <summary>
        /// Enum5190.
        /// </summary>
        [EnumMember(Value = "5190")]
        Enum5190,

        /// <summary>
        /// Enum5200.
        /// </summary>
        [EnumMember(Value = "5200")]
        Enum5200,

        /// <summary>
        /// Enum5210.
        /// </summary>
        [EnumMember(Value = "5210")]
        Enum5210,

        /// <summary>
        /// Enum5400.
        /// </summary>
        [EnumMember(Value = "5400")]
        Enum5400,

        /// <summary>
        /// Enum5500.
        /// </summary>
        [EnumMember(Value = "5500")]
        Enum5500,

        /// <summary>
        /// Enum5650.
        /// </summary>
        [EnumMember(Value = "5650")]
        Enum5650,

        /// <summary>
        /// Enum5700.
        /// </summary>
        [EnumMember(Value = "5700")]
        Enum5700,

        /// <summary>
        /// Enum5710.
        /// </summary>
        [EnumMember(Value = "5710")]
        Enum5710,

        /// <summary>
        /// Enum5800.
        /// </summary>
        [EnumMember(Value = "5800")]
        Enum5800,

        /// <summary>
        /// Enum5900.
        /// </summary>
        [EnumMember(Value = "5900")]
        Enum5900,

        /// <summary>
        /// Enum5910.
        /// </summary>
        [EnumMember(Value = "5910")]
        Enum5910,

        /// <summary>
        /// Enum5920.
        /// </summary>
        [EnumMember(Value = "5920")]
        Enum5920,

        /// <summary>
        /// Enum5930.
        /// </summary>
        [EnumMember(Value = "5930")]
        Enum5930,

        /// <summary>
        /// Enum5950.
        /// </summary>
        [EnumMember(Value = "5950")]
        Enum5950,

        /// <summary>
        /// Enum6300.
        /// </summary>
        [EnumMember(Value = "6300")]
        Enum6300,

        /// <summary>
        /// Enum7600.
        /// </summary>
        [EnumMember(Value = "7600")]
        Enum7600,

        /// <summary>
        /// Enum7700.
        /// </summary>
        [EnumMember(Value = "7700")]
        Enum7700,

        /// <summary>
        /// Enum7710.
        /// </summary>
        [EnumMember(Value = "7710")]
        Enum7710,

        /// <summary>
        /// Enum7800.
        /// </summary>
        [EnumMember(Value = "7800")]
        Enum7800,

        /// <summary>
        /// Enum7900.
        /// </summary>
        [EnumMember(Value = "7900")]
        Enum7900,

        /// <summary>
        /// Enum8000.
        /// </summary>
        [EnumMember(Value = "8000")]
        Enum8000,

        /// <summary>
        /// Enum8010.
        /// </summary>
        [EnumMember(Value = "8010")]
        Enum8010,

        /// <summary>
        /// Enum8020.
        /// </summary>
        [EnumMember(Value = "8020")]
        Enum8020,

        /// <summary>
        /// Enum8030.
        /// </summary>
        [EnumMember(Value = "8030")]
        Enum8030,

        /// <summary>
        /// Enum8100.
        /// </summary>
        [EnumMember(Value = "8100")]
        Enum8100,

        /// <summary>
        /// Enum8110.
        /// </summary>
        [EnumMember(Value = "8110")]
        Enum8110,

        /// <summary>
        /// Enum8220.
        /// </summary>
        [EnumMember(Value = "8220")]
        Enum8220,

        /// <summary>
        /// Enum9100.
        /// </summary>
        [EnumMember(Value = "9100")]
        Enum9100,

        /// <summary>
        /// Enum9500.
        /// </summary>
        [EnumMember(Value = "9500")]
        Enum9500,

        /// <summary>
        /// Enum9510.
        /// </summary>
        [EnumMember(Value = "9510")]
        Enum9510,

        /// <summary>
        /// Enum9520.
        /// </summary>
        [EnumMember(Value = "9520")]
        Enum9520,

        /// <summary>
        /// Enum9530.
        /// </summary>
        [EnumMember(Value = "9530")]
        Enum9530,

        /// <summary>
        /// Enum9540.
        /// </summary>
        [EnumMember(Value = "9540")]
        Enum9540,

        /// <summary>
        /// Enum9600.
        /// </summary>
        [EnumMember(Value = "9600")]
        Enum9600,

        /// <summary>
        /// PCNR.
        /// </summary>
        [EnumMember(Value = "PCNR")]
        PCNR,

        /// <summary>
        /// PCVV.
        /// </summary>
        [EnumMember(Value = "PCVV")]
        PCVV,

        /// <summary>
        /// PP06.
        /// </summary>
        [EnumMember(Value = "PP06")]
        PP06,

        /// <summary>
        /// PPRN.
        /// </summary>
        [EnumMember(Value = "PPRN")]
        PPRN,

        /// <summary>
        /// PPAD.
        /// </summary>
        [EnumMember(Value = "PPAD")]
        PPAD,

        /// <summary>
        /// PPAB.
        /// </summary>
        [EnumMember(Value = "PPAB")]
        PPAB,

        /// <summary>
        /// PPAE.
        /// </summary>
        [EnumMember(Value = "PPAE")]
        PPAE,

        /// <summary>
        /// PPAG.
        /// </summary>
        [EnumMember(Value = "PPAG")]
        PPAG,

        /// <summary>
        /// PPAI.
        /// </summary>
        [EnumMember(Value = "PPAI")]
        PPAI,

        /// <summary>
        /// PPAR.
        /// </summary>
        [EnumMember(Value = "PPAR")]
        PPAR,

        /// <summary>
        /// PPAU.
        /// </summary>
        [EnumMember(Value = "PPAU")]
        PPAU,

        /// <summary>
        /// PPAV.
        /// </summary>
        [EnumMember(Value = "PPAV")]
        PPAV,

        /// <summary>
        /// PPAX.
        /// </summary>
        [EnumMember(Value = "PPAX")]
        PPAX,

        /// <summary>
        /// PPBG.
        /// </summary>
        [EnumMember(Value = "PPBG")]
        PPBG,

        /// <summary>
        /// PPC2.
        /// </summary>
        [EnumMember(Value = "PPC2")]
        PPC2,

        /// <summary>
        /// PPCE.
        /// </summary>
        [EnumMember(Value = "PPCE")]
        PPCE,

        /// <summary>
        /// PPCO.
        /// </summary>
        [EnumMember(Value = "PPCO")]
        PPCO,

        /// <summary>
        /// PPCR.
        /// </summary>
        [EnumMember(Value = "PPCR")]
        PPCR,

        /// <summary>
        /// PPCT.
        /// </summary>
        [EnumMember(Value = "PPCT")]
        PPCT,

        /// <summary>
        /// PPCU.
        /// </summary>
        [EnumMember(Value = "PPCU")]
        PPCU,

        /// <summary>
        /// PPD3.
        /// </summary>
        [EnumMember(Value = "PPD3")]
        PPD3,

        /// <summary>
        /// PPDC.
        /// </summary>
        [EnumMember(Value = "PPDC")]
        PPDC,

        /// <summary>
        /// PPDI.
        /// </summary>
        [EnumMember(Value = "PPDI")]
        PPDI,

        /// <summary>
        /// PPDV.
        /// </summary>
        [EnumMember(Value = "PPDV")]
        PPDV,

        /// <summary>
        /// PPDT.
        /// </summary>
        [EnumMember(Value = "PPDT")]
        PPDT,

        /// <summary>
        /// PPEF.
        /// </summary>
        [EnumMember(Value = "PPEF")]
        PPEF,

        /// <summary>
        /// PPEL.
        /// </summary>
        [EnumMember(Value = "PPEL")]
        PPEL,

        /// <summary>
        /// PPER.
        /// </summary>
        [EnumMember(Value = "PPER")]
        PPER,

        /// <summary>
        /// PPEX.
        /// </summary>
        [EnumMember(Value = "PPEX")]
        PPEX,

        /// <summary>
        /// PPFE.
        /// </summary>
        [EnumMember(Value = "PPFE")]
        PPFE,

        /// <summary>
        /// PPFI.
        /// </summary>
        [EnumMember(Value = "PPFI")]
        PPFI,

        /// <summary>
        /// PPFR.
        /// </summary>
        [EnumMember(Value = "PPFR")]
        PPFR,

        /// <summary>
        /// PPFV.
        /// </summary>
        [EnumMember(Value = "PPFV")]
        PPFV,

        /// <summary>
        /// PPGR.
        /// </summary>
        [EnumMember(Value = "PPGR")]
        PPGR,

        /// <summary>
        /// PPH1.
        /// </summary>
        [EnumMember(Value = "PPH1")]
        PPH1,

        /// <summary>
        /// PPIF.
        /// </summary>
        [EnumMember(Value = "PPIF")]
        PPIF,

        /// <summary>
        /// PPII.
        /// </summary>
        [EnumMember(Value = "PPII")]
        PPII,

        /// <summary>
        /// PPIM.
        /// </summary>
        [EnumMember(Value = "PPIM")]
        PPIM,

        /// <summary>
        /// PPIT.
        /// </summary>
        [EnumMember(Value = "PPIT")]
        PPIT,

        /// <summary>
        /// PPLR.
        /// </summary>
        [EnumMember(Value = "PPLR")]
        PPLR,

        /// <summary>
        /// PPLS.
        /// </summary>
        [EnumMember(Value = "PPLS")]
        PPLS,

        /// <summary>
        /// PPMB.
        /// </summary>
        [EnumMember(Value = "PPMB")]
        PPMB,

        /// <summary>
        /// PPMC.
        /// </summary>
        [EnumMember(Value = "PPMC")]
        PPMC,

        /// <summary>
        /// PPMD.
        /// </summary>
        [EnumMember(Value = "PPMD")]
        PPMD,

        /// <summary>
        /// PPNC.
        /// </summary>
        [EnumMember(Value = "PPNC")]
        PPNC,

        /// <summary>
        /// PPNL.
        /// </summary>
        [EnumMember(Value = "PPNL")]
        PPNL,

        /// <summary>
        /// PPNM.
        /// </summary>
        [EnumMember(Value = "PPNM")]
        PPNM,

        /// <summary>
        /// PPNT.
        /// </summary>
        [EnumMember(Value = "PPNT")]
        PPNT,

        /// <summary>
        /// PPPH.
        /// </summary>
        [EnumMember(Value = "PPPH")]
        PPPH,

        /// <summary>
        /// PPPI.
        /// </summary>
        [EnumMember(Value = "PPPI")]
        PPPI,

        /// <summary>
        /// PPPM.
        /// </summary>
        [EnumMember(Value = "PPPM")]
        PPPM,

        /// <summary>
        /// PPQC.
        /// </summary>
        [EnumMember(Value = "PPQC")]
        PPQC,

        /// <summary>
        /// PPRE.
        /// </summary>
        [EnumMember(Value = "PPRE")]
        PPRE,

        /// <summary>
        /// PPRF.
        /// </summary>
        [EnumMember(Value = "PPRF")]
        PPRF,

        /// <summary>
        /// PPRR.
        /// </summary>
        [EnumMember(Value = "PPRR")]
        PPRR,

        /// <summary>
        /// PPS0.
        /// </summary>
        [EnumMember(Value = "PPS0")]
        PPS0,

        /// <summary>
        /// PPS1.
        /// </summary>
        [EnumMember(Value = "PPS1")]
        PPS1,

        /// <summary>
        /// PPS2.
        /// </summary>
        [EnumMember(Value = "PPS2")]
        PPS2,

        /// <summary>
        /// PPS3.
        /// </summary>
        [EnumMember(Value = "PPS3")]
        PPS3,

        /// <summary>
        /// PPS4.
        /// </summary>
        [EnumMember(Value = "PPS4")]
        PPS4,

        /// <summary>
        /// PPS5.
        /// </summary>
        [EnumMember(Value = "PPS5")]
        PPS5,

        /// <summary>
        /// PPS6.
        /// </summary>
        [EnumMember(Value = "PPS6")]
        PPS6,

        /// <summary>
        /// PPSC.
        /// </summary>
        [EnumMember(Value = "PPSC")]
        PPSC,

        /// <summary>
        /// PPSD.
        /// </summary>
        [EnumMember(Value = "PPSD")]
        PPSD,

        /// <summary>
        /// PPSE.
        /// </summary>
        [EnumMember(Value = "PPSE")]
        PPSE,

        /// <summary>
        /// PPTE.
        /// </summary>
        [EnumMember(Value = "PPTE")]
        PPTE,

        /// <summary>
        /// PPTF.
        /// </summary>
        [EnumMember(Value = "PPTF")]
        PPTF,

        /// <summary>
        /// PPTI.
        /// </summary>
        [EnumMember(Value = "PPTI")]
        PPTI,

        /// <summary>
        /// PPTR.
        /// </summary>
        [EnumMember(Value = "PPTR")]
        PPTR,

        /// <summary>
        /// PPTT.
        /// </summary>
        [EnumMember(Value = "PPTT")]
        PPTT,

        /// <summary>
        /// PPTV.
        /// </summary>
        [EnumMember(Value = "PPTV")]
        PPTV,

        /// <summary>
        /// PPUA.
        /// </summary>
        [EnumMember(Value = "PPUA")]
        PPUA,

        /// <summary>
        /// PPUC.
        /// </summary>
        [EnumMember(Value = "PPUC")]
        PPUC,

        /// <summary>
        /// PPUE.
        /// </summary>
        [EnumMember(Value = "PPUE")]
        PPUE,

        /// <summary>
        /// PPUI.
        /// </summary>
        [EnumMember(Value = "PPUI")]
        PPUI,

        /// <summary>
        /// PPUP.
        /// </summary>
        [EnumMember(Value = "PPUP")]
        PPUP,

        /// <summary>
        /// PPUR.
        /// </summary>
        [EnumMember(Value = "PPUR")]
        PPUR,

        /// <summary>
        /// PPVC.
        /// </summary>
        [EnumMember(Value = "PPVC")]
        PPVC,

        /// <summary>
        /// PPVE.
        /// </summary>
        [EnumMember(Value = "PPVE")]
        PPVE,

        /// <summary>
        /// PPVT.
        /// </summary>
        [EnumMember(Value = "PPVT")]
        PPVT,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}