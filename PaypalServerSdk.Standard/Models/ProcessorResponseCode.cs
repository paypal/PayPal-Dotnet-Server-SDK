// <copyright file="ProcessorResponseCode.cs" company="APIMatic">
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
        /// Enum10Br.
        /// </summary>
        [EnumMember(Value = "10BR")]
        Enum10Br,

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
        /// Pcnr.
        /// </summary>
        [EnumMember(Value = "PCNR")]
        Pcnr,

        /// <summary>
        /// Pcvv.
        /// </summary>
        [EnumMember(Value = "PCVV")]
        Pcvv,

        /// <summary>
        /// Pp06.
        /// </summary>
        [EnumMember(Value = "PP06")]
        Pp06,

        /// <summary>
        /// Pprn.
        /// </summary>
        [EnumMember(Value = "PPRN")]
        Pprn,

        /// <summary>
        /// Ppad.
        /// </summary>
        [EnumMember(Value = "PPAD")]
        Ppad,

        /// <summary>
        /// Ppab.
        /// </summary>
        [EnumMember(Value = "PPAB")]
        Ppab,

        /// <summary>
        /// Ppae.
        /// </summary>
        [EnumMember(Value = "PPAE")]
        Ppae,

        /// <summary>
        /// Ppag.
        /// </summary>
        [EnumMember(Value = "PPAG")]
        Ppag,

        /// <summary>
        /// Ppai.
        /// </summary>
        [EnumMember(Value = "PPAI")]
        Ppai,

        /// <summary>
        /// Ppar.
        /// </summary>
        [EnumMember(Value = "PPAR")]
        Ppar,

        /// <summary>
        /// Ppau.
        /// </summary>
        [EnumMember(Value = "PPAU")]
        Ppau,

        /// <summary>
        /// Ppav.
        /// </summary>
        [EnumMember(Value = "PPAV")]
        Ppav,

        /// <summary>
        /// Ppax.
        /// </summary>
        [EnumMember(Value = "PPAX")]
        Ppax,

        /// <summary>
        /// Ppbg.
        /// </summary>
        [EnumMember(Value = "PPBG")]
        Ppbg,

        /// <summary>
        /// Ppc2.
        /// </summary>
        [EnumMember(Value = "PPC2")]
        Ppc2,

        /// <summary>
        /// Ppce.
        /// </summary>
        [EnumMember(Value = "PPCE")]
        Ppce,

        /// <summary>
        /// Ppco.
        /// </summary>
        [EnumMember(Value = "PPCO")]
        Ppco,

        /// <summary>
        /// Ppcr.
        /// </summary>
        [EnumMember(Value = "PPCR")]
        Ppcr,

        /// <summary>
        /// Ppct.
        /// </summary>
        [EnumMember(Value = "PPCT")]
        Ppct,

        /// <summary>
        /// Ppcu.
        /// </summary>
        [EnumMember(Value = "PPCU")]
        Ppcu,

        /// <summary>
        /// Ppd3.
        /// </summary>
        [EnumMember(Value = "PPD3")]
        Ppd3,

        /// <summary>
        /// Ppdc.
        /// </summary>
        [EnumMember(Value = "PPDC")]
        Ppdc,

        /// <summary>
        /// Ppdi.
        /// </summary>
        [EnumMember(Value = "PPDI")]
        Ppdi,

        /// <summary>
        /// Ppdv.
        /// </summary>
        [EnumMember(Value = "PPDV")]
        Ppdv,

        /// <summary>
        /// Ppdt.
        /// </summary>
        [EnumMember(Value = "PPDT")]
        Ppdt,

        /// <summary>
        /// Ppef.
        /// </summary>
        [EnumMember(Value = "PPEF")]
        Ppef,

        /// <summary>
        /// Ppel.
        /// </summary>
        [EnumMember(Value = "PPEL")]
        Ppel,

        /// <summary>
        /// Pper.
        /// </summary>
        [EnumMember(Value = "PPER")]
        Pper,

        /// <summary>
        /// Ppex.
        /// </summary>
        [EnumMember(Value = "PPEX")]
        Ppex,

        /// <summary>
        /// Ppfe.
        /// </summary>
        [EnumMember(Value = "PPFE")]
        Ppfe,

        /// <summary>
        /// Ppfi.
        /// </summary>
        [EnumMember(Value = "PPFI")]
        Ppfi,

        /// <summary>
        /// Ppfr.
        /// </summary>
        [EnumMember(Value = "PPFR")]
        Ppfr,

        /// <summary>
        /// Ppfv.
        /// </summary>
        [EnumMember(Value = "PPFV")]
        Ppfv,

        /// <summary>
        /// Ppgr.
        /// </summary>
        [EnumMember(Value = "PPGR")]
        Ppgr,

        /// <summary>
        /// Pph1.
        /// </summary>
        [EnumMember(Value = "PPH1")]
        Pph1,

        /// <summary>
        /// Ppif.
        /// </summary>
        [EnumMember(Value = "PPIF")]
        Ppif,

        /// <summary>
        /// Ppii.
        /// </summary>
        [EnumMember(Value = "PPII")]
        Ppii,

        /// <summary>
        /// Ppim.
        /// </summary>
        [EnumMember(Value = "PPIM")]
        Ppim,

        /// <summary>
        /// Ppit.
        /// </summary>
        [EnumMember(Value = "PPIT")]
        Ppit,

        /// <summary>
        /// Pplr.
        /// </summary>
        [EnumMember(Value = "PPLR")]
        Pplr,

        /// <summary>
        /// Ppls.
        /// </summary>
        [EnumMember(Value = "PPLS")]
        Ppls,

        /// <summary>
        /// Ppmb.
        /// </summary>
        [EnumMember(Value = "PPMB")]
        Ppmb,

        /// <summary>
        /// Ppmc.
        /// </summary>
        [EnumMember(Value = "PPMC")]
        Ppmc,

        /// <summary>
        /// Ppmd.
        /// </summary>
        [EnumMember(Value = "PPMD")]
        Ppmd,

        /// <summary>
        /// Ppnc.
        /// </summary>
        [EnumMember(Value = "PPNC")]
        Ppnc,

        /// <summary>
        /// Ppnl.
        /// </summary>
        [EnumMember(Value = "PPNL")]
        Ppnl,

        /// <summary>
        /// Ppnm.
        /// </summary>
        [EnumMember(Value = "PPNM")]
        Ppnm,

        /// <summary>
        /// Ppnt.
        /// </summary>
        [EnumMember(Value = "PPNT")]
        Ppnt,

        /// <summary>
        /// Ppph.
        /// </summary>
        [EnumMember(Value = "PPPH")]
        Ppph,

        /// <summary>
        /// Pppi.
        /// </summary>
        [EnumMember(Value = "PPPI")]
        Pppi,

        /// <summary>
        /// Pppm.
        /// </summary>
        [EnumMember(Value = "PPPM")]
        Pppm,

        /// <summary>
        /// Ppqc.
        /// </summary>
        [EnumMember(Value = "PPQC")]
        Ppqc,

        /// <summary>
        /// Ppre.
        /// </summary>
        [EnumMember(Value = "PPRE")]
        Ppre,

        /// <summary>
        /// Pprf.
        /// </summary>
        [EnumMember(Value = "PPRF")]
        Pprf,

        /// <summary>
        /// Pprr.
        /// </summary>
        [EnumMember(Value = "PPRR")]
        Pprr,

        /// <summary>
        /// Pps0.
        /// </summary>
        [EnumMember(Value = "PPS0")]
        Pps0,

        /// <summary>
        /// Pps1.
        /// </summary>
        [EnumMember(Value = "PPS1")]
        Pps1,

        /// <summary>
        /// Pps2.
        /// </summary>
        [EnumMember(Value = "PPS2")]
        Pps2,

        /// <summary>
        /// Pps3.
        /// </summary>
        [EnumMember(Value = "PPS3")]
        Pps3,

        /// <summary>
        /// Pps4.
        /// </summary>
        [EnumMember(Value = "PPS4")]
        Pps4,

        /// <summary>
        /// Pps5.
        /// </summary>
        [EnumMember(Value = "PPS5")]
        Pps5,

        /// <summary>
        /// Pps6.
        /// </summary>
        [EnumMember(Value = "PPS6")]
        Pps6,

        /// <summary>
        /// Ppsc.
        /// </summary>
        [EnumMember(Value = "PPSC")]
        Ppsc,

        /// <summary>
        /// Ppsd.
        /// </summary>
        [EnumMember(Value = "PPSD")]
        Ppsd,

        /// <summary>
        /// Ppse.
        /// </summary>
        [EnumMember(Value = "PPSE")]
        Ppse,

        /// <summary>
        /// Ppte.
        /// </summary>
        [EnumMember(Value = "PPTE")]
        Ppte,

        /// <summary>
        /// Pptf.
        /// </summary>
        [EnumMember(Value = "PPTF")]
        Pptf,

        /// <summary>
        /// Ppti.
        /// </summary>
        [EnumMember(Value = "PPTI")]
        Ppti,

        /// <summary>
        /// Pptr.
        /// </summary>
        [EnumMember(Value = "PPTR")]
        Pptr,

        /// <summary>
        /// Pptt.
        /// </summary>
        [EnumMember(Value = "PPTT")]
        Pptt,

        /// <summary>
        /// Pptv.
        /// </summary>
        [EnumMember(Value = "PPTV")]
        Pptv,

        /// <summary>
        /// Ppua.
        /// </summary>
        [EnumMember(Value = "PPUA")]
        Ppua,

        /// <summary>
        /// Ppuc.
        /// </summary>
        [EnumMember(Value = "PPUC")]
        Ppuc,

        /// <summary>
        /// Ppue.
        /// </summary>
        [EnumMember(Value = "PPUE")]
        Ppue,

        /// <summary>
        /// Ppui.
        /// </summary>
        [EnumMember(Value = "PPUI")]
        Ppui,

        /// <summary>
        /// Ppup.
        /// </summary>
        [EnumMember(Value = "PPUP")]
        Ppup,

        /// <summary>
        /// Ppur.
        /// </summary>
        [EnumMember(Value = "PPUR")]
        Ppur,

        /// <summary>
        /// Ppvc.
        /// </summary>
        [EnumMember(Value = "PPVC")]
        Ppvc,

        /// <summary>
        /// Ppve.
        /// </summary>
        [EnumMember(Value = "PPVE")]
        Ppve,

        /// <summary>
        /// Ppvt.
        /// </summary>
        [EnumMember(Value = "PPVT")]
        Ppvt,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}