// <copyright file="ShipmentCarrier.cs" company="APIMatic">
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
    /// ShipmentCarrier.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum ShipmentCarrier
    {
        /// <summary>
        /// DPDRU.
        /// </summary>
        [EnumMember(Value = "DPD_RU")]
        DPDRU,

        /// <summary>
        /// BGBULGARIANPOST.
        /// </summary>
        [EnumMember(Value = "BG_BULGARIAN_POST")]
        BGBULGARIANPOST,

        /// <summary>
        /// KRKOREAPOST.
        /// </summary>
        [EnumMember(Value = "KR_KOREA_POST")]
        KRKOREAPOST,

        /// <summary>
        /// ZACOURIERIT.
        /// </summary>
        [EnumMember(Value = "ZA_COURIERIT")]
        ZACOURIERIT,

        /// <summary>
        /// FREXAPAQ.
        /// </summary>
        [EnumMember(Value = "FR_EXAPAQ")]
        FREXAPAQ,

        /// <summary>
        /// AREEMIRATESPOST.
        /// </summary>
        [EnumMember(Value = "ARE_EMIRATES_POST")]
        AREEMIRATESPOST,

        /// <summary>
        /// GAC.
        /// </summary>
        [EnumMember(Value = "GAC")]
        GAC,

        /// <summary>
        /// GEIS.
        /// </summary>
        [EnumMember(Value = "GEIS")]
        GEIS,

        /// <summary>
        /// SFEX.
        /// </summary>
        [EnumMember(Value = "SF_EX")]
        SFEX,

        /// <summary>
        /// PAGO.
        /// </summary>
        [EnumMember(Value = "PAGO")]
        PAGO,

        /// <summary>
        /// MYHERMES.
        /// </summary>
        [EnumMember(Value = "MYHERMES")]
        MYHERMES,

        /// <summary>
        /// DIAMONDEUROGISTICS.
        /// </summary>
        [EnumMember(Value = "DIAMOND_EUROGISTICS")]
        DIAMONDEUROGISTICS,

        /// <summary>
        /// CORPORATECOURIERSWEBHOOK.
        /// </summary>
        [EnumMember(Value = "CORPORATECOURIERS_WEBHOOK")]
        CORPORATECOURIERSWEBHOOK,

        /// <summary>
        /// BOND.
        /// </summary>
        [EnumMember(Value = "BOND")]
        BOND,

        /// <summary>
        /// OMNIPARCEL.
        /// </summary>
        [EnumMember(Value = "OMNIPARCEL")]
        OMNIPARCEL,

        /// <summary>
        /// SKPOSTA.
        /// </summary>
        [EnumMember(Value = "SK_POSTA")]
        SKPOSTA,

        /// <summary>
        /// PUROLATOR.
        /// </summary>
        [EnumMember(Value = "PUROLATOR")]
        PUROLATOR,

        /// <summary>
        /// FETCHRWEBHOOK.
        /// </summary>
        [EnumMember(Value = "FETCHR_WEBHOOK")]
        FETCHRWEBHOOK,

        /// <summary>
        /// THEDELIVERYGROUP.
        /// </summary>
        [EnumMember(Value = "THEDELIVERYGROUP")]
        THEDELIVERYGROUP,

        /// <summary>
        /// CELLOSQUARE.
        /// </summary>
        [EnumMember(Value = "CELLO_SQUARE")]
        CELLOSQUARE,

        /// <summary>
        /// TARRIVE.
        /// </summary>
        [EnumMember(Value = "TARRIVE")]
        TARRIVE,

        /// <summary>
        /// COLLIVERY.
        /// </summary>
        [EnumMember(Value = "COLLIVERY")]
        COLLIVERY,

        /// <summary>
        /// MAINFREIGHT.
        /// </summary>
        [EnumMember(Value = "MAINFREIGHT")]
        MAINFREIGHT,

        /// <summary>
        /// INDFIRSTFLIGHT.
        /// </summary>
        [EnumMember(Value = "IND_FIRSTFLIGHT")]
        INDFIRSTFLIGHT,

        /// <summary>
        /// ACSWORLDWIDE.
        /// </summary>
        [EnumMember(Value = "ACSWORLDWIDE")]
        ACSWORLDWIDE,

        /// <summary>
        /// AMSTAN.
        /// </summary>
        [EnumMember(Value = "AMSTAN")]
        AMSTAN,

        /// <summary>
        /// OKAYPARCEL.
        /// </summary>
        [EnumMember(Value = "OKAYPARCEL")]
        OKAYPARCEL,

        /// <summary>
        /// ENVIALIAREFERENCE.
        /// </summary>
        [EnumMember(Value = "ENVIALIA_REFERENCE")]
        ENVIALIAREFERENCE,

        /// <summary>
        /// SEURES.
        /// </summary>
        [EnumMember(Value = "SEUR_ES")]
        SEURES,

        /// <summary>
        /// CONTINENTAL.
        /// </summary>
        [EnumMember(Value = "CONTINENTAL")]
        CONTINENTAL,

        /// <summary>
        /// FDSEXPRESS.
        /// </summary>
        [EnumMember(Value = "FDSEXPRESS")]
        FDSEXPRESS,

        /// <summary>
        /// AMAZONFBASWISHIP.
        /// </summary>
        [EnumMember(Value = "AMAZON_FBA_SWISHIP")]
        AMAZONFBASWISHIP,

        /// <summary>
        /// WYNGS.
        /// </summary>
        [EnumMember(Value = "WYNGS")]
        WYNGS,

        /// <summary>
        /// DHLACTIVETRACING.
        /// </summary>
        [EnumMember(Value = "DHL_ACTIVE_TRACING")]
        DHLACTIVETRACING,

        /// <summary>
        /// ZYLLEM.
        /// </summary>
        [EnumMember(Value = "ZYLLEM")]
        ZYLLEM,

        /// <summary>
        /// RUSTON.
        /// </summary>
        [EnumMember(Value = "RUSTON")]
        RUSTON,

        /// <summary>
        /// XPOST.
        /// </summary>
        [EnumMember(Value = "XPOST")]
        XPOST,

        /// <summary>
        /// CORREOSES.
        /// </summary>
        [EnumMember(Value = "CORREOS_ES")]
        CORREOSES,

        /// <summary>
        /// DHLFR.
        /// </summary>
        [EnumMember(Value = "DHL_FR")]
        DHLFR,

        /// <summary>
        /// PANASIA.
        /// </summary>
        [EnumMember(Value = "PAN_ASIA")]
        PANASIA,

        /// <summary>
        /// BRTIT.
        /// </summary>
        [EnumMember(Value = "BRT_IT")]
        BRTIT,

        /// <summary>
        /// SREKOREA.
        /// </summary>
        [EnumMember(Value = "SRE_KOREA")]
        SREKOREA,

        /// <summary>
        /// SPEEDEE.
        /// </summary>
        [EnumMember(Value = "SPEEDEE")]
        SPEEDEE,

        /// <summary>
        /// TNTUK.
        /// </summary>
        [EnumMember(Value = "TNT_UK")]
        TNTUK,

        /// <summary>
        /// VENIPAK.
        /// </summary>
        [EnumMember(Value = "VENIPAK")]
        VENIPAK,

        /// <summary>
        /// SHREENANDANCOURIER.
        /// </summary>
        [EnumMember(Value = "SHREENANDANCOURIER")]
        SHREENANDANCOURIER,

        /// <summary>
        /// CROSHOT.
        /// </summary>
        [EnumMember(Value = "CROSHOT")]
        CROSHOT,

        /// <summary>
        /// NIPOSTNG.
        /// </summary>
        [EnumMember(Value = "NIPOST_NG")]
        NIPOSTNG,

        /// <summary>
        /// EPSTGLBL.
        /// </summary>
        [EnumMember(Value = "EPST_GLBL")]
        EPSTGLBL,

        /// <summary>
        /// NEWGISTICS.
        /// </summary>
        [EnumMember(Value = "NEWGISTICS")]
        NEWGISTICS,

        /// <summary>
        /// POSTSLOVENIA.
        /// </summary>
        [EnumMember(Value = "POST_SLOVENIA")]
        POSTSLOVENIA,

        /// <summary>
        /// JERSEYPOST.
        /// </summary>
        [EnumMember(Value = "JERSEY_POST")]
        JERSEYPOST,

        /// <summary>
        /// BOMBINOEXP.
        /// </summary>
        [EnumMember(Value = "BOMBINOEXP")]
        BOMBINOEXP,

        /// <summary>
        /// WMG.
        /// </summary>
        [EnumMember(Value = "WMG")]
        WMG,

        /// <summary>
        /// XQEXPRESS.
        /// </summary>
        [EnumMember(Value = "XQ_EXPRESS")]
        XQEXPRESS,

        /// <summary>
        /// FURDECO.
        /// </summary>
        [EnumMember(Value = "FURDECO")]
        FURDECO,

        /// <summary>
        /// LHTEXPRESS.
        /// </summary>
        [EnumMember(Value = "LHT_EXPRESS")]
        LHTEXPRESS,

        /// <summary>
        /// SOUTHAFRICANPOSTOFFICE.
        /// </summary>
        [EnumMember(Value = "SOUTH_AFRICAN_POST_OFFICE")]
        SOUTHAFRICANPOSTOFFICE,

        /// <summary>
        /// SPOTON.
        /// </summary>
        [EnumMember(Value = "SPOTON")]
        SPOTON,

        /// <summary>
        /// DIMERCO.
        /// </summary>
        [EnumMember(Value = "DIMERCO")]
        DIMERCO,

        /// <summary>
        /// CYPRUSPOSTCYP.
        /// </summary>
        [EnumMember(Value = "CYPRUS_POST_CYP")]
        CYPRUSPOSTCYP,

        /// <summary>
        /// ABCUSTOM.
        /// </summary>
        [EnumMember(Value = "ABCUSTOM")]
        ABCUSTOM,

        /// <summary>
        /// INDDELIVREE.
        /// </summary>
        [EnumMember(Value = "IND_DELIVREE")]
        INDDELIVREE,

        /// <summary>
        /// CNBESTEXPRESS.
        /// </summary>
        [EnumMember(Value = "CN_BESTEXPRESS")]
        CNBESTEXPRESS,

        /// <summary>
        /// DXSFTP.
        /// </summary>
        [EnumMember(Value = "DX_SFTP")]
        DXSFTP,

        /// <summary>
        /// PICKUPPMYS.
        /// </summary>
        [EnumMember(Value = "PICKUPP_MYS")]
        PICKUPPMYS,

        /// <summary>
        /// FMX.
        /// </summary>
        [EnumMember(Value = "FMX")]
        FMX,

        /// <summary>
        /// HELLMANN.
        /// </summary>
        [EnumMember(Value = "HELLMANN")]
        HELLMANN,

        /// <summary>
        /// SHIPITASIA.
        /// </summary>
        [EnumMember(Value = "SHIP_IT_ASIA")]
        SHIPITASIA,

        /// <summary>
        /// KERRYECOMMERCE.
        /// </summary>
        [EnumMember(Value = "KERRY_ECOMMERCE")]
        KERRYECOMMERCE,

        /// <summary>
        /// FRETERAPIDO.
        /// </summary>
        [EnumMember(Value = "FRETERAPIDO")]
        FRETERAPIDO,

        /// <summary>
        /// PITNEYBOWES.
        /// </summary>
        [EnumMember(Value = "PITNEY_BOWES")]
        PITNEYBOWES,

        /// <summary>
        /// XPRESSENDK.
        /// </summary>
        [EnumMember(Value = "XPRESSEN_DK")]
        XPRESSENDK,

        /// <summary>
        /// SEURSPAPI.
        /// </summary>
        [EnumMember(Value = "SEUR_SP_API")]
        SEURSPAPI,

        /// <summary>
        /// DELIVERYONTIME.
        /// </summary>
        [EnumMember(Value = "DELIVERYONTIME")]
        DELIVERYONTIME,

        /// <summary>
        /// JINSUNG.
        /// </summary>
        [EnumMember(Value = "JINSUNG")]
        JINSUNG,

        /// <summary>
        /// TRANSKARGO.
        /// </summary>
        [EnumMember(Value = "TRANS_KARGO")]
        TRANSKARGO,

        /// <summary>
        /// SWISHIPDE.
        /// </summary>
        [EnumMember(Value = "SWISHIP_DE")]
        SWISHIPDE,

        /// <summary>
        /// IVOYWEBHOOK.
        /// </summary>
        [EnumMember(Value = "IVOY_WEBHOOK")]
        IVOYWEBHOOK,

        /// <summary>
        /// AIRMEEWEBHOOK.
        /// </summary>
        [EnumMember(Value = "AIRMEE_WEBHOOK")]
        AIRMEEWEBHOOK,

        /// <summary>
        /// DHLBENELUX.
        /// </summary>
        [EnumMember(Value = "DHL_BENELUX")]
        DHLBENELUX,

        /// <summary>
        /// FIRSTMILE.
        /// </summary>
        [EnumMember(Value = "FIRSTMILE")]
        FIRSTMILE,

        /// <summary>
        /// FASTWAYIR.
        /// </summary>
        [EnumMember(Value = "FASTWAY_IR")]
        FASTWAYIR,

        /// <summary>
        /// HHEXP.
        /// </summary>
        [EnumMember(Value = "HH_EXP")]
        HHEXP,

        /// <summary>
        /// MYSMYPOSTONLINE.
        /// </summary>
        [EnumMember(Value = "MYS_MYPOST_ONLINE")]
        MYSMYPOSTONLINE,

        /// <summary>
        /// TNTNL.
        /// </summary>
        [EnumMember(Value = "TNT_NL")]
        TNTNL,

        /// <summary>
        /// TIPSA.
        /// </summary>
        [EnumMember(Value = "TIPSA")]
        TIPSA,

        /// <summary>
        /// TAQBINMY.
        /// </summary>
        [EnumMember(Value = "TAQBIN_MY")]
        TAQBINMY,

        /// <summary>
        /// KGMHUB.
        /// </summary>
        [EnumMember(Value = "KGMHUB")]
        KGMHUB,

        /// <summary>
        /// INTEXPRESS.
        /// </summary>
        [EnumMember(Value = "INTEXPRESS")]
        INTEXPRESS,

        /// <summary>
        /// OVERSEEXP.
        /// </summary>
        [EnumMember(Value = "OVERSE_EXP")]
        OVERSEEXP,

        /// <summary>
        /// ONECLICK.
        /// </summary>
        [EnumMember(Value = "ONECLICK")]
        ONECLICK,

        /// <summary>
        /// ROADRUNNERFREIGHT.
        /// </summary>
        [EnumMember(Value = "ROADRUNNER_FREIGHT")]
        ROADRUNNERFREIGHT,

        /// <summary>
        /// GLSCROTIA.
        /// </summary>
        [EnumMember(Value = "GLS_CROTIA")]
        GLSCROTIA,

        /// <summary>
        /// MRWFTP.
        /// </summary>
        [EnumMember(Value = "MRW_FTP")]
        MRWFTP,

        /// <summary>
        /// BLUEX.
        /// </summary>
        [EnumMember(Value = "BLUEX")]
        BLUEX,

        /// <summary>
        /// DYLT.
        /// </summary>
        [EnumMember(Value = "DYLT")]
        DYLT,

        /// <summary>
        /// DPDIR.
        /// </summary>
        [EnumMember(Value = "DPD_IR")]
        DPDIR,

        /// <summary>
        /// SINGLBL.
        /// </summary>
        [EnumMember(Value = "SIN_GLBL")]
        SINGLBL,

        /// <summary>
        /// TUFFNELLSREFERENCE.
        /// </summary>
        [EnumMember(Value = "TUFFNELLS_REFERENCE")]
        TUFFNELLSREFERENCE,

        /// <summary>
        /// CJPACKET.
        /// </summary>
        [EnumMember(Value = "CJPACKET")]
        CJPACKET,

        /// <summary>
        /// MILKMAN.
        /// </summary>
        [EnumMember(Value = "MILKMAN")]
        MILKMAN,

        /// <summary>
        /// ASIGNA.
        /// </summary>
        [EnumMember(Value = "ASIGNA")]
        ASIGNA,

        /// <summary>
        /// ONEWORLDEXPRESS.
        /// </summary>
        [EnumMember(Value = "ONEWORLDEXPRESS")]
        ONEWORLDEXPRESS,

        /// <summary>
        /// ROYALMAIL.
        /// </summary>
        [EnumMember(Value = "ROYAL_MAIL")]
        ROYALMAIL,

        /// <summary>
        /// VIAEXPRESS.
        /// </summary>
        [EnumMember(Value = "VIA_EXPRESS")]
        VIAEXPRESS,

        /// <summary>
        /// TIGFREIGHT.
        /// </summary>
        [EnumMember(Value = "TIGFREIGHT")]
        TIGFREIGHT,

        /// <summary>
        /// ZTOEXPRESS.
        /// </summary>
        [EnumMember(Value = "ZTO_EXPRESS")]
        ZTOEXPRESS,

        /// <summary>
        /// TWOGO.
        /// </summary>
        [EnumMember(Value = "TWO_GO")]
        TWOGO,

        /// <summary>
        /// IML.
        /// </summary>
        [EnumMember(Value = "IML")]
        IML,

        /// <summary>
        /// INTELVALLEY.
        /// </summary>
        [EnumMember(Value = "INTEL_VALLEY")]
        INTELVALLEY,

        /// <summary>
        /// EFS.
        /// </summary>
        [EnumMember(Value = "EFS")]
        EFS,

        /// <summary>
        /// UKUKMAIL.
        /// </summary>
        [EnumMember(Value = "UK_UK_MAIL")]
        UKUKMAIL,

        /// <summary>
        /// RAM.
        /// </summary>
        [EnumMember(Value = "RAM")]
        RAM,

        /// <summary>
        /// ALLIEDEXPRESS.
        /// </summary>
        [EnumMember(Value = "ALLIEDEXPRESS")]
        ALLIEDEXPRESS,

        /// <summary>
        /// APCOVERNIGHT.
        /// </summary>
        [EnumMember(Value = "APC_OVERNIGHT")]
        APCOVERNIGHT,

        /// <summary>
        /// SHIPPIT.
        /// </summary>
        [EnumMember(Value = "SHIPPIT")]
        SHIPPIT,

        /// <summary>
        /// TFM.
        /// </summary>
        [EnumMember(Value = "TFM")]
        TFM,

        /// <summary>
        /// MXPRESS.
        /// </summary>
        [EnumMember(Value = "M_XPRESS")]
        MXPRESS,

        /// <summary>
        /// HDBBOX.
        /// </summary>
        [EnumMember(Value = "HDB_BOX")]
        HDBBOX,

        /// <summary>
        /// CLEVYLINKS.
        /// </summary>
        [EnumMember(Value = "CLEVY_LINKS")]
        CLEVYLINKS,

        /// <summary>
        /// IBEONE.
        /// </summary>
        [EnumMember(Value = "IBEONE")]
        IBEONE,

        /// <summary>
        /// FIEGENL.
        /// </summary>
        [EnumMember(Value = "FIEGE_NL")]
        FIEGENL,

        /// <summary>
        /// KWEGLOBAL.
        /// </summary>
        [EnumMember(Value = "KWE_GLOBAL")]
        KWEGLOBAL,

        /// <summary>
        /// CTCEXPRESS.
        /// </summary>
        [EnumMember(Value = "CTC_EXPRESS")]
        CTCEXPRESS,

        /// <summary>
        /// LAOPOST.
        /// </summary>
        [EnumMember(Value = "LAO_POST")]
        LAOPOST,

        /// <summary>
        /// AMAZON.
        /// </summary>
        [EnumMember(Value = "AMAZON")]
        AMAZON,

        /// <summary>
        /// MORELINK.
        /// </summary>
        [EnumMember(Value = "MORE_LINK")]
        MORELINK,

        /// <summary>
        /// JX.
        /// </summary>
        [EnumMember(Value = "JX")]
        JX,

        /// <summary>
        /// EASYMAIL.
        /// </summary>
        [EnumMember(Value = "EASY_MAIL")]
        EASYMAIL,

        /// <summary>
        /// ADUIEPYLE.
        /// </summary>
        [EnumMember(Value = "ADUIEPYLE")]
        ADUIEPYLE,

        /// <summary>
        /// GBPANTHER.
        /// </summary>
        [EnumMember(Value = "GB_PANTHER")]
        GBPANTHER,

        /// <summary>
        /// EXPRESSSALE.
        /// </summary>
        [EnumMember(Value = "EXPRESSSALE")]
        EXPRESSSALE,

        /// <summary>
        /// SGDETRACK.
        /// </summary>
        [EnumMember(Value = "SG_DETRACK")]
        SGDETRACK,

        /// <summary>
        /// TRUNKRSWEBHOOK.
        /// </summary>
        [EnumMember(Value = "TRUNKRS_WEBHOOK")]
        TRUNKRSWEBHOOK,

        /// <summary>
        /// MATDESPATCH.
        /// </summary>
        [EnumMember(Value = "MATDESPATCH")]
        MATDESPATCH,

        /// <summary>
        /// DICOM.
        /// </summary>
        [EnumMember(Value = "DICOM")]
        DICOM,

        /// <summary>
        /// MBW.
        /// </summary>
        [EnumMember(Value = "MBW")]
        MBW,

        /// <summary>
        /// KHMCAMBODIAPOST.
        /// </summary>
        [EnumMember(Value = "KHM_CAMBODIA_POST")]
        KHMCAMBODIAPOST,

        /// <summary>
        /// SINOTRANS.
        /// </summary>
        [EnumMember(Value = "SINOTRANS")]
        SINOTRANS,

        /// <summary>
        /// BRTITPARCELID.
        /// </summary>
        [EnumMember(Value = "BRT_IT_PARCELID")]
        BRTITPARCELID,

        /// <summary>
        /// DHLSUPPLYCHAIN.
        /// </summary>
        [EnumMember(Value = "DHL_SUPPLY_CHAIN")]
        DHLSUPPLYCHAIN,

        /// <summary>
        /// DHLPL.
        /// </summary>
        [EnumMember(Value = "DHL_PL")]
        DHLPL,

        /// <summary>
        /// TOPYOU.
        /// </summary>
        [EnumMember(Value = "TOPYOU")]
        TOPYOU,

        /// <summary>
        /// PALEXPRESS.
        /// </summary>
        [EnumMember(Value = "PALEXPRESS")]
        PALEXPRESS,

        /// <summary>
        /// DHLSG.
        /// </summary>
        [EnumMember(Value = "DHL_SG")]
        DHLSG,

        /// <summary>
        /// CNWEDO.
        /// </summary>
        [EnumMember(Value = "CN_WEDO")]
        CNWEDO,

        /// <summary>
        /// FULFILLME.
        /// </summary>
        [EnumMember(Value = "FULFILLME")]
        FULFILLME,

        /// <summary>
        /// DPDDELISTRACK.
        /// </summary>
        [EnumMember(Value = "DPD_DELISTRACK")]
        DPDDELISTRACK,

        /// <summary>
        /// UPSREFERENCE.
        /// </summary>
        [EnumMember(Value = "UPS_REFERENCE")]
        UPSREFERENCE,

        /// <summary>
        /// CARIBOU.
        /// </summary>
        [EnumMember(Value = "CARIBOU")]
        CARIBOU,

        /// <summary>
        /// LOCUSWEBHOOK.
        /// </summary>
        [EnumMember(Value = "LOCUS_WEBHOOK")]
        LOCUSWEBHOOK,

        /// <summary>
        /// DSV.
        /// </summary>
        [EnumMember(Value = "DSV")]
        DSV,

        /// <summary>
        /// CNGOFLY.
        /// </summary>
        [EnumMember(Value = "CN_GOFLY")]
        CNGOFLY,

        /// <summary>
        /// P2PTRC.
        /// </summary>
        [EnumMember(Value = "P2P_TRC")]
        P2PTRC,

        /// <summary>
        /// DIRECTPARCELS.
        /// </summary>
        [EnumMember(Value = "DIRECTPARCELS")]
        DIRECTPARCELS,

        /// <summary>
        /// NOVAPOSHTAINT.
        /// </summary>
        [EnumMember(Value = "NOVA_POSHTA_INT")]
        NOVAPOSHTAINT,

        /// <summary>
        /// FEDEXPOLAND.
        /// </summary>
        [EnumMember(Value = "FEDEX_POLAND")]
        FEDEXPOLAND,

        /// <summary>
        /// CNJCEX.
        /// </summary>
        [EnumMember(Value = "CN_JCEX")]
        CNJCEX,

        /// <summary>
        /// FARINTERNATIONAL.
        /// </summary>
        [EnumMember(Value = "FAR_INTERNATIONAL")]
        FARINTERNATIONAL,

        /// <summary>
        /// IDEXPRESS.
        /// </summary>
        [EnumMember(Value = "IDEXPRESS")]
        IDEXPRESS,

        /// <summary>
        /// GANGBAO.
        /// </summary>
        [EnumMember(Value = "GANGBAO")]
        GANGBAO,

        /// <summary>
        /// NEWAY.
        /// </summary>
        [EnumMember(Value = "NEWAY")]
        NEWAY,

        /// <summary>
        /// POSTNLINT3S.
        /// </summary>
        [EnumMember(Value = "POSTNL_INT_3_S")]
        POSTNLINT3S,

        /// <summary>
        /// RPXID.
        /// </summary>
        [EnumMember(Value = "RPX_ID")]
        RPXID,

        /// <summary>
        /// DESIGNERTRANSPORTWEBHOOK.
        /// </summary>
        [EnumMember(Value = "DESIGNERTRANSPORT_WEBHOOK")]
        DESIGNERTRANSPORTWEBHOOK,

        /// <summary>
        /// GLSSLOVEN.
        /// </summary>
        [EnumMember(Value = "GLS_SLOVEN")]
        GLSSLOVEN,

        /// <summary>
        /// PARCELLEDIN.
        /// </summary>
        [EnumMember(Value = "PARCELLED_IN")]
        PARCELLEDIN,

        /// <summary>
        /// GSIEXPRESS.
        /// </summary>
        [EnumMember(Value = "GSI_EXPRESS")]
        GSIEXPRESS,

        /// <summary>
        /// CONWAY.
        /// </summary>
        [EnumMember(Value = "CON_WAY")]
        CONWAY,

        /// <summary>
        /// BROUWERTRANSPORT.
        /// </summary>
        [EnumMember(Value = "BROUWER_TRANSPORT")]
        BROUWERTRANSPORT,

        /// <summary>
        /// CPEX.
        /// </summary>
        [EnumMember(Value = "CPEX")]
        CPEX,

        /// <summary>
        /// ISRAELPOST.
        /// </summary>
        [EnumMember(Value = "ISRAEL_POST")]
        ISRAELPOST,

        /// <summary>
        /// DTDCIN.
        /// </summary>
        [EnumMember(Value = "DTDC_IN")]
        DTDCIN,

        /// <summary>
        /// PTTPOST.
        /// </summary>
        [EnumMember(Value = "PTT_POST")]
        PTTPOST,

        /// <summary>
        /// XDEWEBHOOK.
        /// </summary>
        [EnumMember(Value = "XDE_WEBHOOK")]
        XDEWEBHOOK,

        /// <summary>
        /// TOLOS.
        /// </summary>
        [EnumMember(Value = "TOLOS")]
        TOLOS,

        /// <summary>
        /// GIAOHANG.
        /// </summary>
        [EnumMember(Value = "GIAO_HANG")]
        GIAOHANG,

        /// <summary>
        /// GEODISESPACE.
        /// </summary>
        [EnumMember(Value = "GEODIS_ESPACE")]
        GEODISESPACE,

        /// <summary>
        /// MAGYARHU.
        /// </summary>
        [EnumMember(Value = "MAGYAR_HU")]
        MAGYARHU,

        /// <summary>
        /// DOORDASHWEBHOOK.
        /// </summary>
        [EnumMember(Value = "DOORDASH_WEBHOOK")]
        DOORDASHWEBHOOK,

        /// <summary>
        /// TIKIID.
        /// </summary>
        [EnumMember(Value = "TIKI_ID")]
        TIKIID,

        /// <summary>
        /// CJHKINTERNATIONAL.
        /// </summary>
        [EnumMember(Value = "CJ_HK_INTERNATIONAL")]
        CJHKINTERNATIONAL,

        /// <summary>
        /// STARTRACKEXPRESS.
        /// </summary>
        [EnumMember(Value = "STAR_TRACK_EXPRESS")]
        STARTRACKEXPRESS,

        /// <summary>
        /// HELTHJEM.
        /// </summary>
        [EnumMember(Value = "HELTHJEM")]
        HELTHJEM,

        /// <summary>
        /// SFB2C.
        /// </summary>
        [EnumMember(Value = "SFB2C")]
        SFB2C,

        /// <summary>
        /// FREIGHTQUOTE.
        /// </summary>
        [EnumMember(Value = "FREIGHTQUOTE")]
        FREIGHTQUOTE,

        /// <summary>
        /// LANDMARKGLOBALREFERENCE.
        /// </summary>
        [EnumMember(Value = "LANDMARK_GLOBAL_REFERENCE")]
        LANDMARKGLOBALREFERENCE,

        /// <summary>
        /// PARCEL2GO.
        /// </summary>
        [EnumMember(Value = "PARCEL2GO")]
        PARCEL2GO,

        /// <summary>
        /// DELNEXT.
        /// </summary>
        [EnumMember(Value = "DELNEXT")]
        DELNEXT,

        /// <summary>
        /// RCL.
        /// </summary>
        [EnumMember(Value = "RCL")]
        RCL,

        /// <summary>
        /// CGSEXPRESS.
        /// </summary>
        [EnumMember(Value = "CGS_EXPRESS")]
        CGSEXPRESS,

        /// <summary>
        /// HKPOST.
        /// </summary>
        [EnumMember(Value = "HK_POST")]
        HKPOST,

        /// <summary>
        /// SAPEXPRESS.
        /// </summary>
        [EnumMember(Value = "SAP_EXPRESS")]
        SAPEXPRESS,

        /// <summary>
        /// PARCELPOSTSG.
        /// </summary>
        [EnumMember(Value = "PARCELPOST_SG")]
        PARCELPOSTSG,

        /// <summary>
        /// HERMES.
        /// </summary>
        [EnumMember(Value = "HERMES")]
        HERMES,

        /// <summary>
        /// INDSAFEEXPRESS.
        /// </summary>
        [EnumMember(Value = "IND_SAFEEXPRESS")]
        INDSAFEEXPRESS,

        /// <summary>
        /// TOPHATTEREXPRESS.
        /// </summary>
        [EnumMember(Value = "TOPHATTEREXPRESS")]
        TOPHATTEREXPRESS,

        /// <summary>
        /// MGLOBAL.
        /// </summary>
        [EnumMember(Value = "MGLOBAL")]
        MGLOBAL,

        /// <summary>
        /// AVERITT.
        /// </summary>
        [EnumMember(Value = "AVERITT")]
        AVERITT,

        /// <summary>
        /// LEADER.
        /// </summary>
        [EnumMember(Value = "LEADER")]
        LEADER,

        /// <summary>
        /// _2EBOX.
        /// </summary>
        [EnumMember(Value = "_2EBOX")]
        _2EBOX,

        /// <summary>
        /// SGSPEEDPOST.
        /// </summary>
        [EnumMember(Value = "SG_SPEEDPOST")]
        SGSPEEDPOST,

        /// <summary>
        /// DBSCHENKERSE.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_SE")]
        DBSCHENKERSE,

        /// <summary>
        /// ISRPOSTDOMESTIC.
        /// </summary>
        [EnumMember(Value = "ISR_POST_DOMESTIC")]
        ISRPOSTDOMESTIC,

        /// <summary>
        /// BESTWAYPARCEL.
        /// </summary>
        [EnumMember(Value = "BESTWAYPARCEL")]
        BESTWAYPARCEL,

        /// <summary>
        /// ASENDIADE.
        /// </summary>
        [EnumMember(Value = "ASENDIA_DE")]
        ASENDIADE,

        /// <summary>
        /// NIGHTLINEUK.
        /// </summary>
        [EnumMember(Value = "NIGHTLINE_UK")]
        NIGHTLINEUK,

        /// <summary>
        /// TAQBINSG.
        /// </summary>
        [EnumMember(Value = "TAQBIN_SG")]
        TAQBINSG,

        /// <summary>
        /// TCKEXPRESS.
        /// </summary>
        [EnumMember(Value = "TCK_EXPRESS")]
        TCKEXPRESS,

        /// <summary>
        /// ENDEAVOURDELIVERY.
        /// </summary>
        [EnumMember(Value = "ENDEAVOUR_DELIVERY")]
        ENDEAVOURDELIVERY,

        /// <summary>
        /// NANJINGWOYUAN.
        /// </summary>
        [EnumMember(Value = "NANJINGWOYUAN")]
        NANJINGWOYUAN,

        /// <summary>
        /// HEPPNERFR.
        /// </summary>
        [EnumMember(Value = "HEPPNER_FR")]
        HEPPNERFR,

        /// <summary>
        /// EMPSCN.
        /// </summary>
        [EnumMember(Value = "EMPS_CN")]
        EMPSCN,

        /// <summary>
        /// FONSEN.
        /// </summary>
        [EnumMember(Value = "FONSEN")]
        FONSEN,

        /// <summary>
        /// PICKRR.
        /// </summary>
        [EnumMember(Value = "PICKRR")]
        PICKRR,

        /// <summary>
        /// APCOVERNIGHTCONNUM.
        /// </summary>
        [EnumMember(Value = "APC_OVERNIGHT_CONNUM")]
        APCOVERNIGHTCONNUM,

        /// <summary>
        /// STARTRACKNEXTFLIGHT.
        /// </summary>
        [EnumMember(Value = "STAR_TRACK_NEXT_FLIGHT")]
        STARTRACKNEXTFLIGHT,

        /// <summary>
        /// DAJIN.
        /// </summary>
        [EnumMember(Value = "DAJIN")]
        DAJIN,

        /// <summary>
        /// UPSFREIGHT.
        /// </summary>
        [EnumMember(Value = "UPS_FREIGHT")]
        UPSFREIGHT,

        /// <summary>
        /// POSTAPLUS.
        /// </summary>
        [EnumMember(Value = "POSTA_PLUS")]
        POSTAPLUS,

        /// <summary>
        /// CEVA.
        /// </summary>
        [EnumMember(Value = "CEVA")]
        CEVA,

        /// <summary>
        /// ANSERX.
        /// </summary>
        [EnumMember(Value = "ANSERX")]
        ANSERX,

        /// <summary>
        /// JSEXPRESS.
        /// </summary>
        [EnumMember(Value = "JS_EXPRESS")]
        JSEXPRESS,

        /// <summary>
        /// PADTF.
        /// </summary>
        [EnumMember(Value = "PADTF")]
        PADTF,

        /// <summary>
        /// UPSMAILINNOVATIONS.
        /// </summary>
        [EnumMember(Value = "UPS_MAIL_INNOVATIONS")]
        UPSMAILINNOVATIONS,

        /// <summary>
        /// EZSHIP.
        /// </summary>
        [EnumMember(Value = "EZSHIP")]
        EZSHIP,

        /// <summary>
        /// SYPOST.
        /// </summary>
        [EnumMember(Value = "SYPOST")]
        SYPOST,

        /// <summary>
        /// AMAZONSHIPMCF.
        /// </summary>
        [EnumMember(Value = "AMAZON_SHIP_MCF")]
        AMAZONSHIPMCF,

        /// <summary>
        /// YUSEN.
        /// </summary>
        [EnumMember(Value = "YUSEN")]
        YUSEN,

        /// <summary>
        /// BRING.
        /// </summary>
        [EnumMember(Value = "BRING")]
        BRING,

        /// <summary>
        /// SDAIT.
        /// </summary>
        [EnumMember(Value = "SDA_IT")]
        SDAIT,

        /// <summary>
        /// GBA.
        /// </summary>
        [EnumMember(Value = "GBA")]
        GBA,

        /// <summary>
        /// NEWEGGEXPRESS.
        /// </summary>
        [EnumMember(Value = "NEWEGGEXPRESS")]
        NEWEGGEXPRESS,

        /// <summary>
        /// SPEEDCOURIERSGR.
        /// </summary>
        [EnumMember(Value = "SPEEDCOURIERS_GR")]
        SPEEDCOURIERSGR,

        /// <summary>
        /// FORRUN.
        /// </summary>
        [EnumMember(Value = "FORRUN")]
        FORRUN,

        /// <summary>
        /// PICKUP.
        /// </summary>
        [EnumMember(Value = "PICKUP")]
        PICKUP,

        /// <summary>
        /// ECMS.
        /// </summary>
        [EnumMember(Value = "ECMS")]
        ECMS,

        /// <summary>
        /// INTELIPOST.
        /// </summary>
        [EnumMember(Value = "INTELIPOST")]
        INTELIPOST,

        /// <summary>
        /// FLASHEXPRESS.
        /// </summary>
        [EnumMember(Value = "FLASHEXPRESS")]
        FLASHEXPRESS,

        /// <summary>
        /// CNSTO.
        /// </summary>
        [EnumMember(Value = "CN_STO")]
        CNSTO,

        /// <summary>
        /// SEKOSFTP.
        /// </summary>
        [EnumMember(Value = "SEKO_SFTP")]
        SEKOSFTP,

        /// <summary>
        /// HOMEDELIVERYSOLUTIONS.
        /// </summary>
        [EnumMember(Value = "HOME_DELIVERY_SOLUTIONS")]
        HOMEDELIVERYSOLUTIONS,

        /// <summary>
        /// DPDHGRY.
        /// </summary>
        [EnumMember(Value = "DPD_HGRY")]
        DPDHGRY,

        /// <summary>
        /// KERRYTTCVN.
        /// </summary>
        [EnumMember(Value = "KERRYTTC_VN")]
        KERRYTTCVN,

        /// <summary>
        /// JOYINGBOX.
        /// </summary>
        [EnumMember(Value = "JOYING_BOX")]
        JOYINGBOX,

        /// <summary>
        /// TOTALEXPRESS.
        /// </summary>
        [EnumMember(Value = "TOTAL_EXPRESS")]
        TOTALEXPRESS,

        /// <summary>
        /// ZJSEXPRESS.
        /// </summary>
        [EnumMember(Value = "ZJS_EXPRESS")]
        ZJSEXPRESS,

        /// <summary>
        /// STARKEN.
        /// </summary>
        [EnumMember(Value = "STARKEN")]
        STARKEN,

        /// <summary>
        /// DEMANDSHIP.
        /// </summary>
        [EnumMember(Value = "DEMANDSHIP")]
        DEMANDSHIP,

        /// <summary>
        /// CNDPEX.
        /// </summary>
        [EnumMember(Value = "CN_DPEX")]
        CNDPEX,

        /// <summary>
        /// AUPOSTCN.
        /// </summary>
        [EnumMember(Value = "AUPOST_CN")]
        AUPOSTCN,

        /// <summary>
        /// LOGISTERS.
        /// </summary>
        [EnumMember(Value = "LOGISTERS")]
        LOGISTERS,

        /// <summary>
        /// GOGLOBALPOST.
        /// </summary>
        [EnumMember(Value = "GOGLOBALPOST")]
        GOGLOBALPOST,

        /// <summary>
        /// GLSCZ.
        /// </summary>
        [EnumMember(Value = "GLS_CZ")]
        GLSCZ,

        /// <summary>
        /// PAACKWEBHOOK.
        /// </summary>
        [EnumMember(Value = "PAACK_WEBHOOK")]
        PAACKWEBHOOK,

        /// <summary>
        /// GRABWEBHOOK.
        /// </summary>
        [EnumMember(Value = "GRAB_WEBHOOK")]
        GRABWEBHOOK,

        /// <summary>
        /// PARCELPOINT.
        /// </summary>
        [EnumMember(Value = "PARCELPOINT")]
        PARCELPOINT,

        /// <summary>
        /// ICUMULUS.
        /// </summary>
        [EnumMember(Value = "ICUMULUS")]
        ICUMULUS,

        /// <summary>
        /// DAIGLOBALTRACK.
        /// </summary>
        [EnumMember(Value = "DAIGLOBALTRACK")]
        DAIGLOBALTRACK,

        /// <summary>
        /// GLOBALIPARCEL.
        /// </summary>
        [EnumMember(Value = "GLOBAL_IPARCEL")]
        GLOBALIPARCEL,

        /// <summary>
        /// YURTICIKARGO.
        /// </summary>
        [EnumMember(Value = "YURTICI_KARGO")]
        YURTICIKARGO,

        /// <summary>
        /// CNPAYPALPACKAGE.
        /// </summary>
        [EnumMember(Value = "CN_PAYPAL_PACKAGE")]
        CNPAYPALPACKAGE,

        /// <summary>
        /// PARCEL2POST.
        /// </summary>
        [EnumMember(Value = "PARCEL_2_POST")]
        PARCEL2POST,

        /// <summary>
        /// GLSIT.
        /// </summary>
        [EnumMember(Value = "GLS_IT")]
        GLSIT,

        /// <summary>
        /// PILLOGISTICS.
        /// </summary>
        [EnumMember(Value = "PIL_LOGISTICS")]
        PILLOGISTICS,

        /// <summary>
        /// HEPPNER.
        /// </summary>
        [EnumMember(Value = "HEPPNER")]
        HEPPNER,

        /// <summary>
        /// GENERALOVERNIGHT.
        /// </summary>
        [EnumMember(Value = "GENERAL_OVERNIGHT")]
        GENERALOVERNIGHT,

        /// <summary>
        /// HAPPY2POINT.
        /// </summary>
        [EnumMember(Value = "HAPPY2POINT")]
        HAPPY2POINT,

        /// <summary>
        /// CHITCHATS.
        /// </summary>
        [EnumMember(Value = "CHITCHATS")]
        CHITCHATS,

        /// <summary>
        /// SMOOTH.
        /// </summary>
        [EnumMember(Value = "SMOOTH")]
        SMOOTH,

        /// <summary>
        /// CLELOGISTICS.
        /// </summary>
        [EnumMember(Value = "CLE_LOGISTICS")]
        CLELOGISTICS,

        /// <summary>
        /// FIEGE.
        /// </summary>
        [EnumMember(Value = "FIEGE")]
        FIEGE,

        /// <summary>
        /// MXCARGO.
        /// </summary>
        [EnumMember(Value = "MX_CARGO")]
        MXCARGO,

        /// <summary>
        /// ZIINGFINALMILE.
        /// </summary>
        [EnumMember(Value = "ZIINGFINALMILE")]
        ZIINGFINALMILE,

        /// <summary>
        /// DAYTONFREIGHT.
        /// </summary>
        [EnumMember(Value = "DAYTON_FREIGHT")]
        DAYTONFREIGHT,

        /// <summary>
        /// TCS.
        /// </summary>
        [EnumMember(Value = "TCS")]
        TCS,

        /// <summary>
        /// AEX.
        /// </summary>
        [EnumMember(Value = "AEX")]
        AEX,

        /// <summary>
        /// HERMESDE.
        /// </summary>
        [EnumMember(Value = "HERMES_DE")]
        HERMESDE,

        /// <summary>
        /// ROUTIFICWEBHOOK.
        /// </summary>
        [EnumMember(Value = "ROUTIFIC_WEBHOOK")]
        ROUTIFICWEBHOOK,

        /// <summary>
        /// GLOBAVEND.
        /// </summary>
        [EnumMember(Value = "GLOBAVEND")]
        GLOBAVEND,

        /// <summary>
        /// CJLOGISTICS.
        /// </summary>
        [EnumMember(Value = "CJ_LOGISTICS")]
        CJLOGISTICS,

        /// <summary>
        /// PALLETNETWORK.
        /// </summary>
        [EnumMember(Value = "PALLET_NETWORK")]
        PALLETNETWORK,

        /// <summary>
        /// RAFPH.
        /// </summary>
        [EnumMember(Value = "RAF_PH")]
        RAFPH,

        /// <summary>
        /// UKXDP.
        /// </summary>
        [EnumMember(Value = "UK_XDP")]
        UKXDP,

        /// <summary>
        /// PAPEREXPRESS.
        /// </summary>
        [EnumMember(Value = "PAPER_EXPRESS")]
        PAPEREXPRESS,

        /// <summary>
        /// LAPOSTESUIVI.
        /// </summary>
        [EnumMember(Value = "LA_POSTE_SUIVI")]
        LAPOSTESUIVI,

        /// <summary>
        /// PAQUETEXPRESS.
        /// </summary>
        [EnumMember(Value = "PAQUETEXPRESS")]
        PAQUETEXPRESS,

        /// <summary>
        /// LIEFERY.
        /// </summary>
        [EnumMember(Value = "LIEFERY")]
        LIEFERY,

        /// <summary>
        /// STRECKTRANSPORT.
        /// </summary>
        [EnumMember(Value = "STRECK_TRANSPORT")]
        STRECKTRANSPORT,

        /// <summary>
        /// PONYEXPRESS.
        /// </summary>
        [EnumMember(Value = "PONY_EXPRESS")]
        PONYEXPRESS,

        /// <summary>
        /// ALWAYSEXPRESS.
        /// </summary>
        [EnumMember(Value = "ALWAYS_EXPRESS")]
        ALWAYSEXPRESS,

        /// <summary>
        /// GBSBROKER.
        /// </summary>
        [EnumMember(Value = "GBS_BROKER")]
        GBSBROKER,

        /// <summary>
        /// CITYLINKMY.
        /// </summary>
        [EnumMember(Value = "CITYLINK_MY")]
        CITYLINKMY,

        /// <summary>
        /// ALLJOY.
        /// </summary>
        [EnumMember(Value = "ALLJOY")]
        ALLJOY,

        /// <summary>
        /// YODEL.
        /// </summary>
        [EnumMember(Value = "YODEL")]
        YODEL,

        /// <summary>
        /// YODELDIR.
        /// </summary>
        [EnumMember(Value = "YODEL_DIR")]
        YODELDIR,

        /// <summary>
        /// STONE3PL.
        /// </summary>
        [EnumMember(Value = "STONE3PL")]
        STONE3PL,

        /// <summary>
        /// PARCELPALWEBHOOK.
        /// </summary>
        [EnumMember(Value = "PARCELPAL_WEBHOOK")]
        PARCELPALWEBHOOK,

        /// <summary>
        /// DHLECOMERCEASA.
        /// </summary>
        [EnumMember(Value = "DHL_ECOMERCE_ASA")]
        DHLECOMERCEASA,

        /// <summary>
        /// SIMPLYPOST.
        /// </summary>
        [EnumMember(Value = "SIMPLYPOST")]
        SIMPLYPOST,

        /// <summary>
        /// KYEXPRESS.
        /// </summary>
        [EnumMember(Value = "KY_EXPRESS")]
        KYEXPRESS,

        /// <summary>
        /// SHENZHEN.
        /// </summary>
        [EnumMember(Value = "SHENZHEN")]
        SHENZHEN,

        /// <summary>
        /// USLASERSHIP.
        /// </summary>
        [EnumMember(Value = "US_LASERSHIP")]
        USLASERSHIP,

        /// <summary>
        /// UCEXPRE.
        /// </summary>
        [EnumMember(Value = "UC_EXPRE")]
        UCEXPRE,

        /// <summary>
        /// DIDADI.
        /// </summary>
        [EnumMember(Value = "DIDADI")]
        DIDADI,

        /// <summary>
        /// CJKR.
        /// </summary>
        [EnumMember(Value = "CJ_KR")]
        CJKR,

        /// <summary>
        /// DBSCHENKERB2B.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_B2B")]
        DBSCHENKERB2B,

        /// <summary>
        /// MXE.
        /// </summary>
        [EnumMember(Value = "MXE")]
        MXE,

        /// <summary>
        /// CAEDELIVERS.
        /// </summary>
        [EnumMember(Value = "CAE_DELIVERS")]
        CAEDELIVERS,

        /// <summary>
        /// PFCEXPRESS.
        /// </summary>
        [EnumMember(Value = "PFCEXPRESS")]
        PFCEXPRESS,

        /// <summary>
        /// WHISTL.
        /// </summary>
        [EnumMember(Value = "WHISTL")]
        WHISTL,

        /// <summary>
        /// WEPOST.
        /// </summary>
        [EnumMember(Value = "WEPOST")]
        WEPOST,

        /// <summary>
        /// DHLPARCELES.
        /// </summary>
        [EnumMember(Value = "DHL_PARCEL_ES")]
        DHLPARCELES,

        /// <summary>
        /// DDEXPRESS.
        /// </summary>
        [EnumMember(Value = "DDEXPRESS")]
        DDEXPRESS,

        /// <summary>
        /// ARAMEXAU.
        /// </summary>
        [EnumMember(Value = "ARAMEX_AU")]
        ARAMEXAU,

        /// <summary>
        /// BNEED.
        /// </summary>
        [EnumMember(Value = "BNEED")]
        BNEED,

        /// <summary>
        /// HKTGX.
        /// </summary>
        [EnumMember(Value = "HK_TGX")]
        HKTGX,

        /// <summary>
        /// LATVIJASPASTS.
        /// </summary>
        [EnumMember(Value = "LATVIJAS_PASTS")]
        LATVIJASPASTS,

        /// <summary>
        /// VIAEUROPE.
        /// </summary>
        [EnumMember(Value = "VIAEUROPE")]
        VIAEUROPE,

        /// <summary>
        /// CORREOUY.
        /// </summary>
        [EnumMember(Value = "CORREO_UY")]
        CORREOUY,

        /// <summary>
        /// CHRONOPOSTFR.
        /// </summary>
        [EnumMember(Value = "CHRONOPOST_FR")]
        CHRONOPOSTFR,

        /// <summary>
        /// JNET.
        /// </summary>
        [EnumMember(Value = "J_NET")]
        JNET,

        /// <summary>
        /// _6LS.
        /// </summary>
        [EnumMember(Value = "_6LS")]
        _6LS,

        /// <summary>
        /// BLRBELPOST.
        /// </summary>
        [EnumMember(Value = "BLR_BELPOST")]
        BLRBELPOST,

        /// <summary>
        /// BIRDSYSTEM.
        /// </summary>
        [EnumMember(Value = "BIRDSYSTEM")]
        BIRDSYSTEM,

        /// <summary>
        /// DOBROPOST.
        /// </summary>
        [EnumMember(Value = "DOBROPOST")]
        DOBROPOST,

        /// <summary>
        /// WAHANAID.
        /// </summary>
        [EnumMember(Value = "WAHANA_ID")]
        WAHANAID,

        /// <summary>
        /// WEASHIP.
        /// </summary>
        [EnumMember(Value = "WEASHIP")]
        WEASHIP,

        /// <summary>
        /// SONICTL.
        /// </summary>
        [EnumMember(Value = "SONICTL")]
        SONICTL,

        /// <summary>
        /// KWT.
        /// </summary>
        [EnumMember(Value = "KWT")]
        KWT,

        /// <summary>
        /// AFLLOGFTP.
        /// </summary>
        [EnumMember(Value = "AFLLOG_FTP")]
        AFLLOGFTP,

        /// <summary>
        /// SKYNETWORLDWIDE.
        /// </summary>
        [EnumMember(Value = "SKYNET_WORLDWIDE")]
        SKYNETWORLDWIDE,

        /// <summary>
        /// NOVAPOSHTA.
        /// </summary>
        [EnumMember(Value = "NOVA_POSHTA")]
        NOVAPOSHTA,

        /// <summary>
        /// SEINO.
        /// </summary>
        [EnumMember(Value = "SEINO")]
        SEINO,

        /// <summary>
        /// SZENDEX.
        /// </summary>
        [EnumMember(Value = "SZENDEX")]
        SZENDEX,

        /// <summary>
        /// BPOSTINT.
        /// </summary>
        [EnumMember(Value = "BPOST_INT")]
        BPOSTINT,

        /// <summary>
        /// DBSCHENKERSV.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_SV")]
        DBSCHENKERSV,

        /// <summary>
        /// AODEUTSCHLAND.
        /// </summary>
        [EnumMember(Value = "AO_DEUTSCHLAND")]
        AODEUTSCHLAND,

        /// <summary>
        /// EUFLEETSOLUTIONS.
        /// </summary>
        [EnumMember(Value = "EU_FLEET_SOLUTIONS")]
        EUFLEETSOLUTIONS,

        /// <summary>
        /// PCFCORP.
        /// </summary>
        [EnumMember(Value = "PCFCORP")]
        PCFCORP,

        /// <summary>
        /// LINKBRIDGE.
        /// </summary>
        [EnumMember(Value = "LINKBRIDGE")]
        LINKBRIDGE,

        /// <summary>
        /// PRIMAMULTICIPTA.
        /// </summary>
        [EnumMember(Value = "PRIMAMULTICIPTA")]
        PRIMAMULTICIPTA,

        /// <summary>
        /// COUREX.
        /// </summary>
        [EnumMember(Value = "COUREX")]
        COUREX,

        /// <summary>
        /// ZAJILEXPRESS.
        /// </summary>
        [EnumMember(Value = "ZAJIL_EXPRESS")]
        ZAJILEXPRESS,

        /// <summary>
        /// COLLECTCO.
        /// </summary>
        [EnumMember(Value = "COLLECTCO")]
        COLLECTCO,

        /// <summary>
        /// JTEXPRESS.
        /// </summary>
        [EnumMember(Value = "JTEXPRESS")]
        JTEXPRESS,

        /// <summary>
        /// FEDEXUK.
        /// </summary>
        [EnumMember(Value = "FEDEX_UK")]
        FEDEXUK,

        /// <summary>
        /// USHIP.
        /// </summary>
        [EnumMember(Value = "USHIP")]
        USHIP,

        /// <summary>
        /// PIXSELL.
        /// </summary>
        [EnumMember(Value = "PIXSELL")]
        PIXSELL,

        /// <summary>
        /// SHIPTOR.
        /// </summary>
        [EnumMember(Value = "SHIPTOR")]
        SHIPTOR,

        /// <summary>
        /// CDEK.
        /// </summary>
        [EnumMember(Value = "CDEK")]
        CDEK,

        /// <summary>
        /// VNMVIETTELPOST.
        /// </summary>
        [EnumMember(Value = "VNM_VIETTELPOST")]
        VNMVIETTELPOST,

        /// <summary>
        /// CJCENTURY.
        /// </summary>
        [EnumMember(Value = "CJ_CENTURY")]
        CJCENTURY,

        /// <summary>
        /// GSO.
        /// </summary>
        [EnumMember(Value = "GSO")]
        GSO,

        /// <summary>
        /// VIWO.
        /// </summary>
        [EnumMember(Value = "VIWO")]
        VIWO,

        /// <summary>
        /// SKYBOX.
        /// </summary>
        [EnumMember(Value = "SKYBOX")]
        SKYBOX,

        /// <summary>
        /// KERRYTJ.
        /// </summary>
        [EnumMember(Value = "KERRYTJ")]
        KERRYTJ,

        /// <summary>
        /// NTLOGISTICSVN.
        /// </summary>
        [EnumMember(Value = "NTLOGISTICS_VN")]
        NTLOGISTICSVN,

        /// <summary>
        /// SDHSCM.
        /// </summary>
        [EnumMember(Value = "SDH_SCM")]
        SDHSCM,

        /// <summary>
        /// ZINC.
        /// </summary>
        [EnumMember(Value = "ZINC")]
        ZINC,

        /// <summary>
        /// DPESOUTHAFRC.
        /// </summary>
        [EnumMember(Value = "DPE_SOUTH_AFRC")]
        DPESOUTHAFRC,

        /// <summary>
        /// CESKACZ.
        /// </summary>
        [EnumMember(Value = "CESKA_CZ")]
        CESKACZ,

        /// <summary>
        /// ACSGR.
        /// </summary>
        [EnumMember(Value = "ACS_GR")]
        ACSGR,

        /// <summary>
        /// DEALERSEND.
        /// </summary>
        [EnumMember(Value = "DEALERSEND")]
        DEALERSEND,

        /// <summary>
        /// JOCOM.
        /// </summary>
        [EnumMember(Value = "JOCOM")]
        JOCOM,

        /// <summary>
        /// CSE.
        /// </summary>
        [EnumMember(Value = "CSE")]
        CSE,

        /// <summary>
        /// TFORCEFINALMILE.
        /// </summary>
        [EnumMember(Value = "TFORCE_FINALMILE")]
        TFORCEFINALMILE,

        /// <summary>
        /// SHIPGATE.
        /// </summary>
        [EnumMember(Value = "SHIP_GATE")]
        SHIPGATE,

        /// <summary>
        /// SHIPTER.
        /// </summary>
        [EnumMember(Value = "SHIPTER")]
        SHIPTER,

        /// <summary>
        /// NATIONALSAMEDAY.
        /// </summary>
        [EnumMember(Value = "NATIONAL_SAMEDAY")]
        NATIONALSAMEDAY,

        /// <summary>
        /// YUNEXPRESS.
        /// </summary>
        [EnumMember(Value = "YUNEXPRESS")]
        YUNEXPRESS,

        /// <summary>
        /// CAINIAO.
        /// </summary>
        [EnumMember(Value = "CAINIAO")]
        CAINIAO,

        /// <summary>
        /// DMSMATRIX.
        /// </summary>
        [EnumMember(Value = "DMS_MATRIX")]
        DMSMATRIX,

        /// <summary>
        /// DIRECTLOG.
        /// </summary>
        [EnumMember(Value = "DIRECTLOG")]
        DIRECTLOG,

        /// <summary>
        /// ASENDIAUS.
        /// </summary>
        [EnumMember(Value = "ASENDIA_US")]
        ASENDIAUS,

        /// <summary>
        /// _3JMSLOGISTICS.
        /// </summary>
        [EnumMember(Value = "_3JMSLOGISTICS")]
        _3JMSLOGISTICS,

        /// <summary>
        /// LICCARDIEXPRESS.
        /// </summary>
        [EnumMember(Value = "LICCARDI_EXPRESS")]
        LICCARDIEXPRESS,

        /// <summary>
        /// SKYPOSTAL.
        /// </summary>
        [EnumMember(Value = "SKY_POSTAL")]
        SKYPOSTAL,

        /// <summary>
        /// CNWANGTONG.
        /// </summary>
        [EnumMember(Value = "CNWANGTONG")]
        CNWANGTONG,

        /// <summary>
        /// POSTNORDLOGISTICSDK.
        /// </summary>
        [EnumMember(Value = "POSTNORD_LOGISTICS_DK")]
        POSTNORDLOGISTICSDK,

        /// <summary>
        /// LOGISTIKA.
        /// </summary>
        [EnumMember(Value = "LOGISTIKA")]
        LOGISTIKA,

        /// <summary>
        /// CELERITAS.
        /// </summary>
        [EnumMember(Value = "CELERITAS")]
        CELERITAS,

        /// <summary>
        /// PRESSIODE.
        /// </summary>
        [EnumMember(Value = "PRESSIODE")]
        PRESSIODE,

        /// <summary>
        /// SHREEMARUTI.
        /// </summary>
        [EnumMember(Value = "SHREE_MARUTI")]
        SHREEMARUTI,

        /// <summary>
        /// LOGISTICSWORLDWIDEHK.
        /// </summary>
        [EnumMember(Value = "LOGISTICSWORLDWIDE_HK")]
        LOGISTICSWORLDWIDEHK,

        /// <summary>
        /// EFEX.
        /// </summary>
        [EnumMember(Value = "EFEX")]
        EFEX,

        /// <summary>
        /// LOTTE.
        /// </summary>
        [EnumMember(Value = "LOTTE")]
        LOTTE,

        /// <summary>
        /// LONESTAR.
        /// </summary>
        [EnumMember(Value = "LONESTAR")]
        LONESTAR,

        /// <summary>
        /// APRISAEXPRESS.
        /// </summary>
        [EnumMember(Value = "APRISAEXPRESS")]
        APRISAEXPRESS,

        /// <summary>
        /// BELRS.
        /// </summary>
        [EnumMember(Value = "BEL_RS")]
        BELRS,

        /// <summary>
        /// OSMWORLDWIDE.
        /// </summary>
        [EnumMember(Value = "OSM_WORLDWIDE")]
        OSMWORLDWIDE,

        /// <summary>
        /// WESTGATEGL.
        /// </summary>
        [EnumMember(Value = "WESTGATE_GL")]
        WESTGATEGL,

        /// <summary>
        /// FASTRACK.
        /// </summary>
        [EnumMember(Value = "FASTRACK")]
        FASTRACK,

        /// <summary>
        /// DTDEXPR.
        /// </summary>
        [EnumMember(Value = "DTD_EXPR")]
        DTDEXPR,

        /// <summary>
        /// ALFATREX.
        /// </summary>
        [EnumMember(Value = "ALFATREX")]
        ALFATREX,

        /// <summary>
        /// PROMEDDELIVERY.
        /// </summary>
        [EnumMember(Value = "PROMEDDELIVERY")]
        PROMEDDELIVERY,

        /// <summary>
        /// THABITLOGISTICS.
        /// </summary>
        [EnumMember(Value = "THABIT_LOGISTICS")]
        THABITLOGISTICS,

        /// <summary>
        /// HCTLOGISTICS.
        /// </summary>
        [EnumMember(Value = "HCT_LOGISTICS")]
        HCTLOGISTICS,

        /// <summary>
        /// CARRYFLAP.
        /// </summary>
        [EnumMember(Value = "CARRY_FLAP")]
        CARRYFLAP,

        /// <summary>
        /// USOLDDOMINION.
        /// </summary>
        [EnumMember(Value = "US_OLD_DOMINION")]
        USOLDDOMINION,

        /// <summary>
        /// ANICAMBOX.
        /// </summary>
        [EnumMember(Value = "ANICAM_BOX")]
        ANICAMBOX,

        /// <summary>
        /// WANBEXPRESS.
        /// </summary>
        [EnumMember(Value = "WANBEXPRESS")]
        WANBEXPRESS,

        /// <summary>
        /// ANPOST.
        /// </summary>
        [EnumMember(Value = "AN_POST")]
        ANPOST,

        /// <summary>
        /// DPDLOCAL.
        /// </summary>
        [EnumMember(Value = "DPD_LOCAL")]
        DPDLOCAL,

        /// <summary>
        /// STALLIONEXPRESS.
        /// </summary>
        [EnumMember(Value = "STALLIONEXPRESS")]
        STALLIONEXPRESS,

        /// <summary>
        /// RAIDEREX.
        /// </summary>
        [EnumMember(Value = "RAIDEREX")]
        RAIDEREX,

        /// <summary>
        /// SHOPFANS.
        /// </summary>
        [EnumMember(Value = "SHOPFANS")]
        SHOPFANS,

        /// <summary>
        /// KYUNGDONGPARCEL.
        /// </summary>
        [EnumMember(Value = "KYUNGDONG_PARCEL")]
        KYUNGDONGPARCEL,

        /// <summary>
        /// CHAMPIONLOGISTICS.
        /// </summary>
        [EnumMember(Value = "CHAMPION_LOGISTICS")]
        CHAMPIONLOGISTICS,

        /// <summary>
        /// PICKUPPSGP.
        /// </summary>
        [EnumMember(Value = "PICKUPP_SGP")]
        PICKUPPSGP,

        /// <summary>
        /// MORNINGEXPRESS.
        /// </summary>
        [EnumMember(Value = "MORNING_EXPRESS")]
        MORNINGEXPRESS,

        /// <summary>
        /// NACEX.
        /// </summary>
        [EnumMember(Value = "NACEX")]
        NACEX,

        /// <summary>
        /// THENILEWEBHOOK.
        /// </summary>
        [EnumMember(Value = "THENILE_WEBHOOK")]
        THENILEWEBHOOK,

        /// <summary>
        /// HOLISOL.
        /// </summary>
        [EnumMember(Value = "HOLISOL")]
        HOLISOL,

        /// <summary>
        /// LBCEXPRESSFTP.
        /// </summary>
        [EnumMember(Value = "LBCEXPRESS_FTP")]
        LBCEXPRESSFTP,

        /// <summary>
        /// KURASI.
        /// </summary>
        [EnumMember(Value = "KURASI")]
        KURASI,

        /// <summary>
        /// USFREDDAWAY.
        /// </summary>
        [EnumMember(Value = "USF_REDDAWAY")]
        USFREDDAWAY,

        /// <summary>
        /// APG.
        /// </summary>
        [EnumMember(Value = "APG")]
        APG,

        /// <summary>
        /// CNBOXC.
        /// </summary>
        [EnumMember(Value = "CN_BOXC")]
        CNBOXC,

        /// <summary>
        /// ECOSCOOTING.
        /// </summary>
        [EnumMember(Value = "ECOSCOOTING")]
        ECOSCOOTING,

        /// <summary>
        /// MAINWAY.
        /// </summary>
        [EnumMember(Value = "MAINWAY")]
        MAINWAY,

        /// <summary>
        /// PAPERFLY.
        /// </summary>
        [EnumMember(Value = "PAPERFLY")]
        PAPERFLY,

        /// <summary>
        /// HOUNDEXPRESS.
        /// </summary>
        [EnumMember(Value = "HOUNDEXPRESS")]
        HOUNDEXPRESS,

        /// <summary>
        /// BOXBERRY.
        /// </summary>
        [EnumMember(Value = "BOX_BERRY")]
        BOXBERRY,

        /// <summary>
        /// EPBOX.
        /// </summary>
        [EnumMember(Value = "EP_BOX")]
        EPBOX,

        /// <summary>
        /// PLUSLOGUK.
        /// </summary>
        [EnumMember(Value = "PLUS_LOG_UK")]
        PLUSLOGUK,

        /// <summary>
        /// FULFILLA.
        /// </summary>
        [EnumMember(Value = "FULFILLA")]
        FULFILLA,

        /// <summary>
        /// ASE.
        /// </summary>
        [EnumMember(Value = "ASE")]
        ASE,

        /// <summary>
        /// MAILPLUS.
        /// </summary>
        [EnumMember(Value = "MAIL_PLUS")]
        MAILPLUS,

        /// <summary>
        /// XPOLOGISTICS.
        /// </summary>
        [EnumMember(Value = "XPO_LOGISTICS")]
        XPOLOGISTICS,

        /// <summary>
        /// WNDIRECT.
        /// </summary>
        [EnumMember(Value = "WNDIRECT")]
        WNDIRECT,

        /// <summary>
        /// CLOUDWISHASIA.
        /// </summary>
        [EnumMember(Value = "CLOUDWISH_ASIA")]
        CLOUDWISHASIA,

        /// <summary>
        /// ZELERIS.
        /// </summary>
        [EnumMember(Value = "ZELERIS")]
        ZELERIS,

        /// <summary>
        /// GIOEXPRESS.
        /// </summary>
        [EnumMember(Value = "GIO_EXPRESS")]
        GIOEXPRESS,

        /// <summary>
        /// OCSWORLDWIDE.
        /// </summary>
        [EnumMember(Value = "OCS_WORLDWIDE")]
        OCSWORLDWIDE,

        /// <summary>
        /// ARKLOGISTICS.
        /// </summary>
        [EnumMember(Value = "ARK_LOGISTICS")]
        ARKLOGISTICS,

        /// <summary>
        /// AQUILINE.
        /// </summary>
        [EnumMember(Value = "AQUILINE")]
        AQUILINE,

        /// <summary>
        /// PILOTFREIGHT.
        /// </summary>
        [EnumMember(Value = "PILOT_FREIGHT")]
        PILOTFREIGHT,

        /// <summary>
        /// QWINTRY.
        /// </summary>
        [EnumMember(Value = "QWINTRY")]
        QWINTRY,

        /// <summary>
        /// DANSKEFRAGT.
        /// </summary>
        [EnumMember(Value = "DANSKE_FRAGT")]
        DANSKEFRAGT,

        /// <summary>
        /// CARRIERS.
        /// </summary>
        [EnumMember(Value = "CARRIERS")]
        CARRIERS,

        /// <summary>
        /// AIRCANADAGLOBAL.
        /// </summary>
        [EnumMember(Value = "AIR_CANADA_GLOBAL")]
        AIRCANADAGLOBAL,

        /// <summary>
        /// PRESIDENTTRANS.
        /// </summary>
        [EnumMember(Value = "PRESIDENT_TRANS")]
        PRESIDENTTRANS,

        /// <summary>
        /// STEPFORWARDFS.
        /// </summary>
        [EnumMember(Value = "STEPFORWARDFS")]
        STEPFORWARDFS,

        /// <summary>
        /// SKYNETUK.
        /// </summary>
        [EnumMember(Value = "SKYNET_UK")]
        SKYNETUK,

        /// <summary>
        /// PITTOHIO.
        /// </summary>
        [EnumMember(Value = "PITTOHIO")]
        PITTOHIO,

        /// <summary>
        /// CORREOSEXPRESS.
        /// </summary>
        [EnumMember(Value = "CORREOS_EXPRESS")]
        CORREOSEXPRESS,

        /// <summary>
        /// RLUS.
        /// </summary>
        [EnumMember(Value = "RL_US")]
        RLUS,

        /// <summary>
        /// MARAXPRESS.
        /// </summary>
        [EnumMember(Value = "MARA_XPRESS")]
        MARAXPRESS,

        /// <summary>
        /// DESTINY.
        /// </summary>
        [EnumMember(Value = "DESTINY")]
        DESTINY,

        /// <summary>
        /// UKYODEL.
        /// </summary>
        [EnumMember(Value = "UK_YODEL")]
        UKYODEL,

        /// <summary>
        /// COMETTECH.
        /// </summary>
        [EnumMember(Value = "COMET_TECH")]
        COMETTECH,

        /// <summary>
        /// DHLPARCELRU.
        /// </summary>
        [EnumMember(Value = "DHL_PARCEL_RU")]
        DHLPARCELRU,

        /// <summary>
        /// TNTREFR.
        /// </summary>
        [EnumMember(Value = "TNT_REFR")]
        TNTREFR,

        /// <summary>
        /// SHREEANJANICOURIER.
        /// </summary>
        [EnumMember(Value = "SHREE_ANJANI_COURIER")]
        SHREEANJANICOURIER,

        /// <summary>
        /// MIKROPAKKETBE.
        /// </summary>
        [EnumMember(Value = "MIKROPAKKET_BE")]
        MIKROPAKKETBE,

        /// <summary>
        /// ETSEXPRESS.
        /// </summary>
        [EnumMember(Value = "ETS_EXPRESS")]
        ETSEXPRESS,

        /// <summary>
        /// COLISPRIVE.
        /// </summary>
        [EnumMember(Value = "COLIS_PRIVE")]
        COLISPRIVE,

        /// <summary>
        /// CNYUNDA.
        /// </summary>
        [EnumMember(Value = "CN_YUNDA")]
        CNYUNDA,

        /// <summary>
        /// AAACOOPER.
        /// </summary>
        [EnumMember(Value = "AAA_COOPER")]
        AAACOOPER,

        /// <summary>
        /// ROCKETPARCEL.
        /// </summary>
        [EnumMember(Value = "ROCKET_PARCEL")]
        ROCKETPARCEL,

        /// <summary>
        /// _360LION.
        /// </summary>
        [EnumMember(Value = "_360LION")]
        _360LION,

        /// <summary>
        /// PANDU.
        /// </summary>
        [EnumMember(Value = "PANDU")]
        PANDU,

        /// <summary>
        /// PROFESSIONALCOURIERS.
        /// </summary>
        [EnumMember(Value = "PROFESSIONAL_COURIERS")]
        PROFESSIONALCOURIERS,

        /// <summary>
        /// FLYTEXPRESS.
        /// </summary>
        [EnumMember(Value = "FLYTEXPRESS")]
        FLYTEXPRESS,

        /// <summary>
        /// LOGISTICSWORLDWIDEMY.
        /// </summary>
        [EnumMember(Value = "LOGISTICSWORLDWIDE_MY")]
        LOGISTICSWORLDWIDEMY,

        /// <summary>
        /// CORREOSDEESPANA.
        /// </summary>
        [EnumMember(Value = "CORREOS_DE_ESPANA")]
        CORREOSDEESPANA,

        /// <summary>
        /// IMX.
        /// </summary>
        [EnumMember(Value = "IMX")]
        IMX,

        /// <summary>
        /// FOURPXEXPRESS.
        /// </summary>
        [EnumMember(Value = "FOUR_PX_EXPRESS")]
        FOURPXEXPRESS,

        /// <summary>
        /// XPRESSBEES.
        /// </summary>
        [EnumMember(Value = "XPRESSBEES")]
        XPRESSBEES,

        /// <summary>
        /// PICKUPPVNM.
        /// </summary>
        [EnumMember(Value = "PICKUPP_VNM")]
        PICKUPPVNM,

        /// <summary>
        /// STARTRACKEXPRESS1.
        /// </summary>
        [EnumMember(Value = "STARTRACK_EXPRESS")]
        STARTRACKEXPRESS1,

        /// <summary>
        /// FRCOLISSIMO.
        /// </summary>
        [EnumMember(Value = "FR_COLISSIMO")]
        FRCOLISSIMO,

        /// <summary>
        /// NACEXSPAINREFERENCE.
        /// </summary>
        [EnumMember(Value = "NACEX_SPAIN_REFERENCE")]
        NACEXSPAINREFERENCE,

        /// <summary>
        /// DHLSUPPLYCHAINAU.
        /// </summary>
        [EnumMember(Value = "DHL_SUPPLY_CHAIN_AU")]
        DHLSUPPLYCHAINAU,

        /// <summary>
        /// ESHIPPING.
        /// </summary>
        [EnumMember(Value = "ESHIPPING")]
        ESHIPPING,

        /// <summary>
        /// SHREETIRUPATI.
        /// </summary>
        [EnumMember(Value = "SHREETIRUPATI")]
        SHREETIRUPATI,

        /// <summary>
        /// HXEXPRESS.
        /// </summary>
        [EnumMember(Value = "HX_EXPRESS")]
        HXEXPRESS,

        /// <summary>
        /// INDOPAKET.
        /// </summary>
        [EnumMember(Value = "INDOPAKET")]
        INDOPAKET,

        /// <summary>
        /// CN17POST.
        /// </summary>
        [EnumMember(Value = "CN_17POST")]
        CN17POST,

        /// <summary>
        /// K1EXPRESS.
        /// </summary>
        [EnumMember(Value = "K1_EXPRESS")]
        K1EXPRESS,

        /// <summary>
        /// CJGLS.
        /// </summary>
        [EnumMember(Value = "CJ_GLS")]
        CJGLS,

        /// <summary>
        /// MYSGDEX.
        /// </summary>
        [EnumMember(Value = "MYS_GDEX")]
        MYSGDEX,

        /// <summary>
        /// NATIONEX.
        /// </summary>
        [EnumMember(Value = "NATIONEX")]
        NATIONEX,

        /// <summary>
        /// ANJUN.
        /// </summary>
        [EnumMember(Value = "ANJUN")]
        ANJUN,

        /// <summary>
        /// FARGOOD.
        /// </summary>
        [EnumMember(Value = "FARGOOD")]
        FARGOOD,

        /// <summary>
        /// SMGEXPRESS.
        /// </summary>
        [EnumMember(Value = "SMG_EXPRESS")]
        SMGEXPRESS,

        /// <summary>
        /// RZYEXPRESS.
        /// </summary>
        [EnumMember(Value = "RZYEXPRESS")]
        RZYEXPRESS,

        /// <summary>
        /// SEFL.
        /// </summary>
        [EnumMember(Value = "SEFL")]
        SEFL,

        /// <summary>
        /// TNTCLICKIT.
        /// </summary>
        [EnumMember(Value = "TNT_CLICK_IT")]
        TNTCLICKIT,

        /// <summary>
        /// HDB.
        /// </summary>
        [EnumMember(Value = "HDB")]
        HDB,

        /// <summary>
        /// HIPSHIPPER.
        /// </summary>
        [EnumMember(Value = "HIPSHIPPER")]
        HIPSHIPPER,

        /// <summary>
        /// RPXLOGISTICS.
        /// </summary>
        [EnumMember(Value = "RPXLOGISTICS")]
        RPXLOGISTICS,

        /// <summary>
        /// KUEHNE.
        /// </summary>
        [EnumMember(Value = "KUEHNE")]
        KUEHNE,

        /// <summary>
        /// ITNEXIVE.
        /// </summary>
        [EnumMember(Value = "IT_NEXIVE")]
        ITNEXIVE,

        /// <summary>
        /// PTS.
        /// </summary>
        [EnumMember(Value = "PTS")]
        PTS,

        /// <summary>
        /// SWISSPOSTFTP.
        /// </summary>
        [EnumMember(Value = "SWISS_POST_FTP")]
        SWISSPOSTFTP,

        /// <summary>
        /// FASTRKSERV.
        /// </summary>
        [EnumMember(Value = "FASTRK_SERV")]
        FASTRKSERV,

        /// <summary>
        /// _472.
        /// </summary>
        [EnumMember(Value = "_4_72")]
        _472,

        /// <summary>
        /// USYRC.
        /// </summary>
        [EnumMember(Value = "US_YRC")]
        USYRC,

        /// <summary>
        /// POSTNLINTL3S.
        /// </summary>
        [EnumMember(Value = "POSTNL_INTL_3S")]
        POSTNLINTL3S,

        /// <summary>
        /// ELIANPOST.
        /// </summary>
        [EnumMember(Value = "ELIAN_POST")]
        ELIANPOST,

        /// <summary>
        /// CUBYN.
        /// </summary>
        [EnumMember(Value = "CUBYN")]
        CUBYN,

        /// <summary>
        /// SAUSAUDIPOST.
        /// </summary>
        [EnumMember(Value = "SAU_SAUDI_POST")]
        SAUSAUDIPOST,

        /// <summary>
        /// ABXEXPRESSMY.
        /// </summary>
        [EnumMember(Value = "ABXEXPRESS_MY")]
        ABXEXPRESSMY,

        /// <summary>
        /// HUAHANEXPRESS.
        /// </summary>
        [EnumMember(Value = "HUAHAN_EXPRESS")]
        HUAHANEXPRESS,

        /// <summary>
        /// INDJAYONEXPRESS.
        /// </summary>
        [EnumMember(Value = "IND_JAYONEXPRESS")]
        INDJAYONEXPRESS,

        /// <summary>
        /// ZESEXPRESS.
        /// </summary>
        [EnumMember(Value = "ZES_EXPRESS")]
        ZESEXPRESS,

        /// <summary>
        /// ZEPTOEXPRESS.
        /// </summary>
        [EnumMember(Value = "ZEPTO_EXPRESS")]
        ZEPTOEXPRESS,

        /// <summary>
        /// SKYNETZA.
        /// </summary>
        [EnumMember(Value = "SKYNET_ZA")]
        SKYNETZA,

        /// <summary>
        /// ZEEK2DOOR.
        /// </summary>
        [EnumMember(Value = "ZEEK_2_DOOR")]
        ZEEK2DOOR,

        /// <summary>
        /// BLINKLASTMILE.
        /// </summary>
        [EnumMember(Value = "BLINKLASTMILE")]
        BLINKLASTMILE,

        /// <summary>
        /// POSTAUKR.
        /// </summary>
        [EnumMember(Value = "POSTA_UKR")]
        POSTAUKR,

        /// <summary>
        /// CHROBINSON.
        /// </summary>
        [EnumMember(Value = "CHROBINSON")]
        CHROBINSON,

        /// <summary>
        /// CNPOST56.
        /// </summary>
        [EnumMember(Value = "CN_POST56")]
        CNPOST56,

        /// <summary>
        /// COURANTPLUS.
        /// </summary>
        [EnumMember(Value = "COURANT_PLUS")]
        COURANTPLUS,

        /// <summary>
        /// SCUDEXEXPRESS.
        /// </summary>
        [EnumMember(Value = "SCUDEX_EXPRESS")]
        SCUDEXEXPRESS,

        /// <summary>
        /// SHIPENTEGRA.
        /// </summary>
        [EnumMember(Value = "SHIPENTEGRA")]
        SHIPENTEGRA,

        /// <summary>
        /// BTWOCEUROPE.
        /// </summary>
        [EnumMember(Value = "B_TWO_C_EUROPE")]
        BTWOCEUROPE,

        /// <summary>
        /// COPE.
        /// </summary>
        [EnumMember(Value = "COPE")]
        COPE,

        /// <summary>
        /// INDGATI.
        /// </summary>
        [EnumMember(Value = "IND_GATI")]
        INDGATI,

        /// <summary>
        /// CNWISHPOST.
        /// </summary>
        [EnumMember(Value = "CN_WISHPOST")]
        CNWISHPOST,

        /// <summary>
        /// NACEXES.
        /// </summary>
        [EnumMember(Value = "NACEX_ES")]
        NACEXES,

        /// <summary>
        /// TAQBINHK.
        /// </summary>
        [EnumMember(Value = "TAQBIN_HK")]
        TAQBINHK,

        /// <summary>
        /// GLOBALTRANZ.
        /// </summary>
        [EnumMember(Value = "GLOBALTRANZ")]
        GLOBALTRANZ,

        /// <summary>
        /// HKD.
        /// </summary>
        [EnumMember(Value = "HKD")]
        HKD,

        /// <summary>
        /// BJSHOMEDELIVERY.
        /// </summary>
        [EnumMember(Value = "BJSHOMEDELIVERY")]
        BJSHOMEDELIVERY,

        /// <summary>
        /// OMNIVA.
        /// </summary>
        [EnumMember(Value = "OMNIVA")]
        OMNIVA,

        /// <summary>
        /// SUTTON.
        /// </summary>
        [EnumMember(Value = "SUTTON")]
        SUTTON,

        /// <summary>
        /// PANTHERREFERENCE.
        /// </summary>
        [EnumMember(Value = "PANTHER_REFERENCE")]
        PANTHERREFERENCE,

        /// <summary>
        /// SFCSERVICE.
        /// </summary>
        [EnumMember(Value = "SFCSERVICE")]
        SFCSERVICE,

        /// <summary>
        /// LTL.
        /// </summary>
        [EnumMember(Value = "LTL")]
        LTL,

        /// <summary>
        /// PARKNPARCEL.
        /// </summary>
        [EnumMember(Value = "PARKNPARCEL")]
        PARKNPARCEL,

        /// <summary>
        /// SPRINGGDS.
        /// </summary>
        [EnumMember(Value = "SPRING_GDS")]
        SPRINGGDS,

        /// <summary>
        /// ECEXPRESS.
        /// </summary>
        [EnumMember(Value = "ECEXPRESS")]
        ECEXPRESS,

        /// <summary>
        /// INTERPARCELAU.
        /// </summary>
        [EnumMember(Value = "INTERPARCEL_AU")]
        INTERPARCELAU,

        /// <summary>
        /// AGILITY.
        /// </summary>
        [EnumMember(Value = "AGILITY")]
        AGILITY,

        /// <summary>
        /// XLEXPRESS.
        /// </summary>
        [EnumMember(Value = "XL_EXPRESS")]
        XLEXPRESS,

        /// <summary>
        /// ADERONLINE.
        /// </summary>
        [EnumMember(Value = "ADERONLINE")]
        ADERONLINE,

        /// <summary>
        /// DIRECTCOURIERS.
        /// </summary>
        [EnumMember(Value = "DIRECTCOURIERS")]
        DIRECTCOURIERS,

        /// <summary>
        /// PLANZER.
        /// </summary>
        [EnumMember(Value = "PLANZER")]
        PLANZER,

        /// <summary>
        /// SENDING.
        /// </summary>
        [EnumMember(Value = "SENDING")]
        SENDING,

        /// <summary>
        /// NINJAVANWB.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_WB")]
        NINJAVANWB,

        /// <summary>
        /// NATIONWIDEMY.
        /// </summary>
        [EnumMember(Value = "NATIONWIDE_MY")]
        NATIONWIDEMY,

        /// <summary>
        /// SENDIT.
        /// </summary>
        [EnumMember(Value = "SENDIT")]
        SENDIT,

        /// <summary>
        /// GBARROW.
        /// </summary>
        [EnumMember(Value = "GB_ARROW")]
        GBARROW,

        /// <summary>
        /// INDGOJAVAS.
        /// </summary>
        [EnumMember(Value = "IND_GOJAVAS")]
        INDGOJAVAS,

        /// <summary>
        /// KPOST.
        /// </summary>
        [EnumMember(Value = "KPOST")]
        KPOST,

        /// <summary>
        /// DHLFREIGHT.
        /// </summary>
        [EnumMember(Value = "DHL_FREIGHT")]
        DHLFREIGHT,

        /// <summary>
        /// BLUECARE.
        /// </summary>
        [EnumMember(Value = "BLUECARE")]
        BLUECARE,

        /// <summary>
        /// JINDOUYUN.
        /// </summary>
        [EnumMember(Value = "JINDOUYUN")]
        JINDOUYUN,

        /// <summary>
        /// TRACKON.
        /// </summary>
        [EnumMember(Value = "TRACKON")]
        TRACKON,

        /// <summary>
        /// GBTUFFNELLS.
        /// </summary>
        [EnumMember(Value = "GB_TUFFNELLS")]
        GBTUFFNELLS,

        /// <summary>
        /// TRUMPCARD.
        /// </summary>
        [EnumMember(Value = "TRUMPCARD")]
        TRUMPCARD,

        /// <summary>
        /// ETOTAL.
        /// </summary>
        [EnumMember(Value = "ETOTAL")]
        ETOTAL,

        /// <summary>
        /// SFPLUSWEBHOOK.
        /// </summary>
        [EnumMember(Value = "SFPLUS_WEBHOOK")]
        SFPLUSWEBHOOK,

        /// <summary>
        /// SEKOLOGISTICS.
        /// </summary>
        [EnumMember(Value = "SEKOLOGISTICS")]
        SEKOLOGISTICS,

        /// <summary>
        /// HERMES2MANNHANDLING.
        /// </summary>
        [EnumMember(Value = "HERMES_2MANN_HANDLING")]
        HERMES2MANNHANDLING,

        /// <summary>
        /// DPDLOCALREF.
        /// </summary>
        [EnumMember(Value = "DPD_LOCAL_REF")]
        DPDLOCALREF,

        /// <summary>
        /// UDS.
        /// </summary>
        [EnumMember(Value = "UDS")]
        UDS,

        /// <summary>
        /// ZASPECIALISEDFREIGHT.
        /// </summary>
        [EnumMember(Value = "ZA_SPECIALISED_FREIGHT")]
        ZASPECIALISEDFREIGHT,

        /// <summary>
        /// THAKERRY.
        /// </summary>
        [EnumMember(Value = "THA_KERRY")]
        THAKERRY,

        /// <summary>
        /// PRTINTSEUR.
        /// </summary>
        [EnumMember(Value = "PRT_INT_SEUR")]
        PRTINTSEUR,

        /// <summary>
        /// BRACORREIOS.
        /// </summary>
        [EnumMember(Value = "BRA_CORREIOS")]
        BRACORREIOS,

        /// <summary>
        /// NZNZPOST.
        /// </summary>
        [EnumMember(Value = "NZ_NZ_POST")]
        NZNZPOST,

        /// <summary>
        /// CNEQUICK.
        /// </summary>
        [EnumMember(Value = "CN_EQUICK")]
        CNEQUICK,

        /// <summary>
        /// MYSEMS.
        /// </summary>
        [EnumMember(Value = "MYS_EMS")]
        MYSEMS,

        /// <summary>
        /// GBNORSK.
        /// </summary>
        [EnumMember(Value = "GB_NORSK")]
        GBNORSK,

        /// <summary>
        /// ESPMRW.
        /// </summary>
        [EnumMember(Value = "ESP_MRW")]
        ESPMRW,

        /// <summary>
        /// ESPPACKLINK.
        /// </summary>
        [EnumMember(Value = "ESP_PACKLINK")]
        ESPPACKLINK,

        /// <summary>
        /// KANGAROOMY.
        /// </summary>
        [EnumMember(Value = "KANGAROO_MY")]
        KANGAROOMY,

        /// <summary>
        /// RPX.
        /// </summary>
        [EnumMember(Value = "RPX")]
        RPX,

        /// <summary>
        /// XDPUKREFERENCE.
        /// </summary>
        [EnumMember(Value = "XDP_UK_REFERENCE")]
        XDPUKREFERENCE,

        /// <summary>
        /// NINJAVANMY.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_MY")]
        NINJAVANMY,

        /// <summary>
        /// ADICIONAL.
        /// </summary>
        [EnumMember(Value = "ADICIONAL")]
        ADICIONAL,

        /// <summary>
        /// NINJAVANID.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_ID")]
        NINJAVANID,

        /// <summary>
        /// ROADBULL.
        /// </summary>
        [EnumMember(Value = "ROADBULL")]
        ROADBULL,

        /// <summary>
        /// YAKIT.
        /// </summary>
        [EnumMember(Value = "YAKIT")]
        YAKIT,

        /// <summary>
        /// MAILAMERICAS.
        /// </summary>
        [EnumMember(Value = "MAILAMERICAS")]
        MAILAMERICAS,

        /// <summary>
        /// MIKROPAKKET.
        /// </summary>
        [EnumMember(Value = "MIKROPAKKET")]
        MIKROPAKKET,

        /// <summary>
        /// DYNALOGIC.
        /// </summary>
        [EnumMember(Value = "DYNALOGIC")]
        DYNALOGIC,

        /// <summary>
        /// DHLES.
        /// </summary>
        [EnumMember(Value = "DHL_ES")]
        DHLES,

        /// <summary>
        /// DHLPARCELNL.
        /// </summary>
        [EnumMember(Value = "DHL_PARCEL_NL")]
        DHLPARCELNL,

        /// <summary>
        /// DHLGLOBALMAILASIA.
        /// </summary>
        [EnumMember(Value = "DHL_GLOBAL_MAIL_ASIA")]
        DHLGLOBALMAILASIA,

        /// <summary>
        /// DAWNWING.
        /// </summary>
        [EnumMember(Value = "DAWN_WING")]
        DAWNWING,

        /// <summary>
        /// GENIKIGR.
        /// </summary>
        [EnumMember(Value = "GENIKI_GR")]
        GENIKIGR,

        /// <summary>
        /// HERMESWORLDUK.
        /// </summary>
        [EnumMember(Value = "HERMESWORLD_UK")]
        HERMESWORLDUK,

        /// <summary>
        /// ALPHAFAST.
        /// </summary>
        [EnumMember(Value = "ALPHAFAST")]
        ALPHAFAST,

        /// <summary>
        /// BUYLOGIC.
        /// </summary>
        [EnumMember(Value = "BUYLOGIC")]
        BUYLOGIC,

        /// <summary>
        /// EKART.
        /// </summary>
        [EnumMember(Value = "EKART")]
        EKART,

        /// <summary>
        /// MEXSENDA.
        /// </summary>
        [EnumMember(Value = "MEX_SENDA")]
        MEXSENDA,

        /// <summary>
        /// SFCLOGISTICS.
        /// </summary>
        [EnumMember(Value = "SFC_LOGISTICS")]
        SFCLOGISTICS,

        /// <summary>
        /// POSTSERBIA.
        /// </summary>
        [EnumMember(Value = "POST_SERBIA")]
        POSTSERBIA,

        /// <summary>
        /// INDDELHIVERY.
        /// </summary>
        [EnumMember(Value = "IND_DELHIVERY")]
        INDDELHIVERY,

        /// <summary>
        /// DEDPDDELISTRACK.
        /// </summary>
        [EnumMember(Value = "DE_DPD_DELISTRACK")]
        DEDPDDELISTRACK,

        /// <summary>
        /// RPD2MAN.
        /// </summary>
        [EnumMember(Value = "RPD2MAN")]
        RPD2MAN,

        /// <summary>
        /// CNSFEXPRESS.
        /// </summary>
        [EnumMember(Value = "CN_SF_EXPRESS")]
        CNSFEXPRESS,

        /// <summary>
        /// YANWEN.
        /// </summary>
        [EnumMember(Value = "YANWEN")]
        YANWEN,

        /// <summary>
        /// MYSSKYNET.
        /// </summary>
        [EnumMember(Value = "MYS_SKYNET")]
        MYSSKYNET,

        /// <summary>
        /// CORREOSDEMEXICO.
        /// </summary>
        [EnumMember(Value = "CORREOS_DE_MEXICO")]
        CORREOSDEMEXICO,

        /// <summary>
        /// CBLLOGISTICA.
        /// </summary>
        [EnumMember(Value = "CBL_LOGISTICA")]
        CBLLOGISTICA,

        /// <summary>
        /// MEXESTAFETA.
        /// </summary>
        [EnumMember(Value = "MEX_ESTAFETA")]
        MEXESTAFETA,

        /// <summary>
        /// AUAUSTRIANPOST.
        /// </summary>
        [EnumMember(Value = "AU_AUSTRIAN_POST")]
        AUAUSTRIANPOST,

        /// <summary>
        /// RINCOS.
        /// </summary>
        [EnumMember(Value = "RINCOS")]
        RINCOS,

        /// <summary>
        /// NLDDHL.
        /// </summary>
        [EnumMember(Value = "NLD_DHL")]
        NLDDHL,

        /// <summary>
        /// RUSSIANPOST.
        /// </summary>
        [EnumMember(Value = "RUSSIAN_POST")]
        RUSSIANPOST,

        /// <summary>
        /// COURIERSPLEASE.
        /// </summary>
        [EnumMember(Value = "COURIERS_PLEASE")]
        COURIERSPLEASE,

        /// <summary>
        /// POSTNORDLOGISTICS.
        /// </summary>
        [EnumMember(Value = "POSTNORD_LOGISTICS")]
        POSTNORDLOGISTICS,

        /// <summary>
        /// FEDEX.
        /// </summary>
        [EnumMember(Value = "FEDEX")]
        FEDEX,

        /// <summary>
        /// DPEEXPRESS.
        /// </summary>
        [EnumMember(Value = "DPE_EXPRESS")]
        DPEEXPRESS,

        /// <summary>
        /// DPD.
        /// </summary>
        [EnumMember(Value = "DPD")]
        DPD,

        /// <summary>
        /// ADSONE.
        /// </summary>
        [EnumMember(Value = "ADSONE")]
        ADSONE,

        /// <summary>
        /// IDNJNE.
        /// </summary>
        [EnumMember(Value = "IDN_JNE")]
        IDNJNE,

        /// <summary>
        /// THECOURIERGUY.
        /// </summary>
        [EnumMember(Value = "THECOURIERGUY")]
        THECOURIERGUY,

        /// <summary>
        /// CNEXPS.
        /// </summary>
        [EnumMember(Value = "CNEXPS")]
        CNEXPS,

        /// <summary>
        /// PRTCHRONOPOST.
        /// </summary>
        [EnumMember(Value = "PRT_CHRONOPOST")]
        PRTCHRONOPOST,

        /// <summary>
        /// LANDMARKGLOBAL.
        /// </summary>
        [EnumMember(Value = "LANDMARK_GLOBAL")]
        LANDMARKGLOBAL,

        /// <summary>
        /// ITDHLECOMMERCE.
        /// </summary>
        [EnumMember(Value = "IT_DHL_ECOMMERCE")]
        ITDHLECOMMERCE,

        /// <summary>
        /// ESPNACEX.
        /// </summary>
        [EnumMember(Value = "ESP_NACEX")]
        ESPNACEX,

        /// <summary>
        /// PRTCTT.
        /// </summary>
        [EnumMember(Value = "PRT_CTT")]
        PRTCTT,

        /// <summary>
        /// BEKIALA.
        /// </summary>
        [EnumMember(Value = "BE_KIALA")]
        BEKIALA,

        /// <summary>
        /// ASENDIAUK.
        /// </summary>
        [EnumMember(Value = "ASENDIA_UK")]
        ASENDIAUK,

        /// <summary>
        /// GLOBALTNT.
        /// </summary>
        [EnumMember(Value = "GLOBAL_TNT")]
        GLOBALTNT,

        /// <summary>
        /// POSTURIS.
        /// </summary>
        [EnumMember(Value = "POSTUR_IS")]
        POSTURIS,

        /// <summary>
        /// EPARCELKR.
        /// </summary>
        [EnumMember(Value = "EPARCEL_KR")]
        EPARCELKR,

        /// <summary>
        /// INPOSTPACZKOMATY.
        /// </summary>
        [EnumMember(Value = "INPOST_PACZKOMATY")]
        INPOSTPACZKOMATY,

        /// <summary>
        /// ITPOSTEITALIA.
        /// </summary>
        [EnumMember(Value = "IT_POSTE_ITALIA")]
        ITPOSTEITALIA,

        /// <summary>
        /// BEBPOST.
        /// </summary>
        [EnumMember(Value = "BE_BPOST")]
        BEBPOST,

        /// <summary>
        /// PLPOCZTAPOLSKA.
        /// </summary>
        [EnumMember(Value = "PL_POCZTA_POLSKA")]
        PLPOCZTAPOLSKA,

        /// <summary>
        /// MYSMYSPOST.
        /// </summary>
        [EnumMember(Value = "MYS_MYS_POST")]
        MYSMYSPOST,

        /// <summary>
        /// SGSGPOST.
        /// </summary>
        [EnumMember(Value = "SG_SG_POST")]
        SGSGPOST,

        /// <summary>
        /// THATHAILANDPOST.
        /// </summary>
        [EnumMember(Value = "THA_THAILAND_POST")]
        THATHAILANDPOST,

        /// <summary>
        /// LEXSHIP.
        /// </summary>
        [EnumMember(Value = "LEXSHIP")]
        LEXSHIP,

        /// <summary>
        /// FASTWAYNZ.
        /// </summary>
        [EnumMember(Value = "FASTWAY_NZ")]
        FASTWAYNZ,

        /// <summary>
        /// DHLAU.
        /// </summary>
        [EnumMember(Value = "DHL_AU")]
        DHLAU,

        /// <summary>
        /// COSTMETICSNOW.
        /// </summary>
        [EnumMember(Value = "COSTMETICSNOW")]
        COSTMETICSNOW,

        /// <summary>
        /// PFLOGISTICS.
        /// </summary>
        [EnumMember(Value = "PFLOGISTICS")]
        PFLOGISTICS,

        /// <summary>
        /// LOOMISEXPRESS.
        /// </summary>
        [EnumMember(Value = "LOOMIS_EXPRESS")]
        LOOMISEXPRESS,

        /// <summary>
        /// GLSITALY.
        /// </summary>
        [EnumMember(Value = "GLS_ITALY")]
        GLSITALY,

        /// <summary>
        /// LINE.
        /// </summary>
        [EnumMember(Value = "LINE")]
        LINE,

        /// <summary>
        /// GELEXPRESS.
        /// </summary>
        [EnumMember(Value = "GEL_EXPRESS")]
        GELEXPRESS,

        /// <summary>
        /// HUODULL.
        /// </summary>
        [EnumMember(Value = "HUODULL")]
        HUODULL,

        /// <summary>
        /// NINJAVANSG.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_SG")]
        NINJAVANSG,

        /// <summary>
        /// JANIO.
        /// </summary>
        [EnumMember(Value = "JANIO")]
        JANIO,

        /// <summary>
        /// AOCOURIER.
        /// </summary>
        [EnumMember(Value = "AO_COURIER")]
        AOCOURIER,

        /// <summary>
        /// BRTITSENDERREF.
        /// </summary>
        [EnumMember(Value = "BRT_IT_SENDER_REF")]
        BRTITSENDERREF,

        /// <summary>
        /// SAILPOST.
        /// </summary>
        [EnumMember(Value = "SAILPOST")]
        SAILPOST,

        /// <summary>
        /// LALAMOVE.
        /// </summary>
        [EnumMember(Value = "LALAMOVE")]
        LALAMOVE,

        /// <summary>
        /// NEWZEALANDCOURIERS.
        /// </summary>
        [EnumMember(Value = "NEWZEALAND_COURIERS")]
        NEWZEALANDCOURIERS,

        /// <summary>
        /// ETOMARS.
        /// </summary>
        [EnumMember(Value = "ETOMARS")]
        ETOMARS,

        /// <summary>
        /// VIRTRANSPORT.
        /// </summary>
        [EnumMember(Value = "VIRTRANSPORT")]
        VIRTRANSPORT,

        /// <summary>
        /// WIZMO.
        /// </summary>
        [EnumMember(Value = "WIZMO")]
        WIZMO,

        /// <summary>
        /// PALLETWAYS.
        /// </summary>
        [EnumMember(Value = "PALLETWAYS")]
        PALLETWAYS,

        /// <summary>
        /// IDIKA.
        /// </summary>
        [EnumMember(Value = "I_DIKA")]
        IDIKA,

        /// <summary>
        /// CFLLOGISTICS.
        /// </summary>
        [EnumMember(Value = "CFL_LOGISTICS")]
        CFLLOGISTICS,

        /// <summary>
        /// GEMWORLDWIDE.
        /// </summary>
        [EnumMember(Value = "GEMWORLDWIDE")]
        GEMWORLDWIDE,

        /// <summary>
        /// GLOBALEXPRESS.
        /// </summary>
        [EnumMember(Value = "GLOBAL_EXPRESS")]
        GLOBALEXPRESS,

        /// <summary>
        /// LOGISTYXTRANSGROUP.
        /// </summary>
        [EnumMember(Value = "LOGISTYX_TRANSGROUP")]
        LOGISTYXTRANSGROUP,

        /// <summary>
        /// WESTBANKCOURIER.
        /// </summary>
        [EnumMember(Value = "WESTBANK_COURIER")]
        WESTBANKCOURIER,

        /// <summary>
        /// ARCOSPEDIZIONI.
        /// </summary>
        [EnumMember(Value = "ARCO_SPEDIZIONI")]
        ARCOSPEDIZIONI,

        /// <summary>
        /// YDHEXPRESS.
        /// </summary>
        [EnumMember(Value = "YDH_EXPRESS")]
        YDHEXPRESS,

        /// <summary>
        /// PARCELINKLOGISTICS.
        /// </summary>
        [EnumMember(Value = "PARCELINKLOGISTICS")]
        PARCELINKLOGISTICS,

        /// <summary>
        /// CNDEXPRESS.
        /// </summary>
        [EnumMember(Value = "CNDEXPRESS")]
        CNDEXPRESS,

        /// <summary>
        /// NOXNIGHTTIMEEXPRESS.
        /// </summary>
        [EnumMember(Value = "NOX_NIGHT_TIME_EXPRESS")]
        NOXNIGHTTIMEEXPRESS,

        /// <summary>
        /// AERONET.
        /// </summary>
        [EnumMember(Value = "AERONET")]
        AERONET,

        /// <summary>
        /// LTIANEXP.
        /// </summary>
        [EnumMember(Value = "LTIANEXP")]
        LTIANEXP,

        /// <summary>
        /// INTEGRA2FTP.
        /// </summary>
        [EnumMember(Value = "INTEGRA2_FTP")]
        INTEGRA2FTP,

        /// <summary>
        /// PARCELONE.
        /// </summary>
        [EnumMember(Value = "PARCELONE")]
        PARCELONE,

        /// <summary>
        /// NOXNACHTEXPRESS.
        /// </summary>
        [EnumMember(Value = "NOX_NACHTEXPRESS")]
        NOXNACHTEXPRESS,

        /// <summary>
        /// CNCHINAPOSTEMS.
        /// </summary>
        [EnumMember(Value = "CN_CHINA_POST_EMS")]
        CNCHINAPOSTEMS,

        /// <summary>
        /// CHUKOU1.
        /// </summary>
        [EnumMember(Value = "CHUKOU1")]
        CHUKOU1,

        /// <summary>
        /// GLSSLOV.
        /// </summary>
        [EnumMember(Value = "GLS_SLOV")]
        GLSSLOV,

        /// <summary>
        /// ORANGEDS.
        /// </summary>
        [EnumMember(Value = "ORANGE_DS")]
        ORANGEDS,

        /// <summary>
        /// JOOMLOGIS.
        /// </summary>
        [EnumMember(Value = "JOOM_LOGIS")]
        JOOMLOGIS,

        /// <summary>
        /// AUSSTARTRACK.
        /// </summary>
        [EnumMember(Value = "AUS_STARTRACK")]
        AUSSTARTRACK,

        /// <summary>
        /// DHL.
        /// </summary>
        [EnumMember(Value = "DHL")]
        DHL,

        /// <summary>
        /// GBAPC.
        /// </summary>
        [EnumMember(Value = "GB_APC")]
        GBAPC,

        /// <summary>
        /// BONDSCOURIERS.
        /// </summary>
        [EnumMember(Value = "BONDSCOURIERS")]
        BONDSCOURIERS,

        /// <summary>
        /// JPNJAPANPOST.
        /// </summary>
        [EnumMember(Value = "JPN_JAPAN_POST")]
        JPNJAPANPOST,

        /// <summary>
        /// USPS.
        /// </summary>
        [EnumMember(Value = "USPS")]
        USPS,

        /// <summary>
        /// WINIT.
        /// </summary>
        [EnumMember(Value = "WINIT")]
        WINIT,

        /// <summary>
        /// ARGOCA.
        /// </summary>
        [EnumMember(Value = "ARG_OCA")]
        ARGOCA,

        /// <summary>
        /// TWTAIWANPOST.
        /// </summary>
        [EnumMember(Value = "TW_TAIWAN_POST")]
        TWTAIWANPOST,

        /// <summary>
        /// DMMNETWORK.
        /// </summary>
        [EnumMember(Value = "DMM_NETWORK")]
        DMMNETWORK,

        /// <summary>
        /// TNT.
        /// </summary>
        [EnumMember(Value = "TNT")]
        TNT,

        /// <summary>
        /// BHPOSTA.
        /// </summary>
        [EnumMember(Value = "BH_POSTA")]
        BHPOSTA,

        /// <summary>
        /// SWEPOSTNORD.
        /// </summary>
        [EnumMember(Value = "SWE_POSTNORD")]
        SWEPOSTNORD,

        /// <summary>
        /// CACANADAPOST.
        /// </summary>
        [EnumMember(Value = "CA_CANADA_POST")]
        CACANADAPOST,

        /// <summary>
        /// WISELOADS.
        /// </summary>
        [EnumMember(Value = "WISELOADS")]
        WISELOADS,

        /// <summary>
        /// ASENDIAHK.
        /// </summary>
        [EnumMember(Value = "ASENDIA_HK")]
        ASENDIAHK,

        /// <summary>
        /// NLDGLS.
        /// </summary>
        [EnumMember(Value = "NLD_GLS")]
        NLDGLS,

        /// <summary>
        /// MEXREDPACK.
        /// </summary>
        [EnumMember(Value = "MEX_REDPACK")]
        MEXREDPACK,

        /// <summary>
        /// JETSHIP.
        /// </summary>
        [EnumMember(Value = "JET_SHIP")]
        JETSHIP,

        /// <summary>
        /// DEDHLEXPRESS.
        /// </summary>
        [EnumMember(Value = "DE_DHL_EXPRESS")]
        DEDHLEXPRESS,

        /// <summary>
        /// NINJAVANTHAI.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_THAI")]
        NINJAVANTHAI,

        /// <summary>
        /// RABENGROUP.
        /// </summary>
        [EnumMember(Value = "RABEN_GROUP")]
        RABENGROUP,

        /// <summary>
        /// ESPASM.
        /// </summary>
        [EnumMember(Value = "ESP_ASM")]
        ESPASM,

        /// <summary>
        /// HRVHRVATSKA.
        /// </summary>
        [EnumMember(Value = "HRV_HRVATSKA")]
        HRVHRVATSKA,

        /// <summary>
        /// GLOBALESTES.
        /// </summary>
        [EnumMember(Value = "GLOBAL_ESTES")]
        GLOBALESTES,

        /// <summary>
        /// LTULIETUVOS.
        /// </summary>
        [EnumMember(Value = "LTU_LIETUVOS")]
        LTULIETUVOS,

        /// <summary>
        /// BELDHL.
        /// </summary>
        [EnumMember(Value = "BEL_DHL")]
        BELDHL,

        /// <summary>
        /// AUAUPOST.
        /// </summary>
        [EnumMember(Value = "AU_AU_POST")]
        AUAUPOST,

        /// <summary>
        /// SPEEDEXCOURIER.
        /// </summary>
        [EnumMember(Value = "SPEEDEXCOURIER")]
        SPEEDEXCOURIER,

        /// <summary>
        /// FRCOLIS.
        /// </summary>
        [EnumMember(Value = "FR_COLIS")]
        FRCOLIS,

        /// <summary>
        /// ARAMEX.
        /// </summary>
        [EnumMember(Value = "ARAMEX")]
        ARAMEX,

        /// <summary>
        /// DPEX.
        /// </summary>
        [EnumMember(Value = "DPEX")]
        DPEX,

        /// <summary>
        /// MYSAIRPAK.
        /// </summary>
        [EnumMember(Value = "MYS_AIRPAK")]
        MYSAIRPAK,

        /// <summary>
        /// CUCKOOEXPRESS.
        /// </summary>
        [EnumMember(Value = "CUCKOOEXPRESS")]
        CUCKOOEXPRESS,

        /// <summary>
        /// DPDPOLAND.
        /// </summary>
        [EnumMember(Value = "DPD_POLAND")]
        DPDPOLAND,

        /// <summary>
        /// NLDPOSTNL.
        /// </summary>
        [EnumMember(Value = "NLD_POSTNL")]
        NLDPOSTNL,

        /// <summary>
        /// NIMEXPRESS.
        /// </summary>
        [EnumMember(Value = "NIM_EXPRESS")]
        NIMEXPRESS,

        /// <summary>
        /// QUANTIUM.
        /// </summary>
        [EnumMember(Value = "QUANTIUM")]
        QUANTIUM,

        /// <summary>
        /// SENDLE.
        /// </summary>
        [EnumMember(Value = "SENDLE")]
        SENDLE,

        /// <summary>
        /// ESPREDUR.
        /// </summary>
        [EnumMember(Value = "ESP_REDUR")]
        ESPREDUR,

        /// <summary>
        /// MATKAHUOLTO.
        /// </summary>
        [EnumMember(Value = "MATKAHUOLTO")]
        MATKAHUOLTO,

        /// <summary>
        /// CPACKET.
        /// </summary>
        [EnumMember(Value = "CPACKET")]
        CPACKET,

        /// <summary>
        /// POSTI.
        /// </summary>
        [EnumMember(Value = "POSTI")]
        POSTI,

        /// <summary>
        /// HUNTEREXPRESS.
        /// </summary>
        [EnumMember(Value = "HUNTER_EXPRESS")]
        HUNTEREXPRESS,

        /// <summary>
        /// CHOIREXP.
        /// </summary>
        [EnumMember(Value = "CHOIR_EXP")]
        CHOIREXP,

        /// <summary>
        /// LEGIONEXPRESS.
        /// </summary>
        [EnumMember(Value = "LEGION_EXPRESS")]
        LEGIONEXPRESS,

        /// <summary>
        /// AUSTRIANPOSTEXPRESS.
        /// </summary>
        [EnumMember(Value = "AUSTRIAN_POST_EXPRESS")]
        AUSTRIANPOSTEXPRESS,

        /// <summary>
        /// GRUPO.
        /// </summary>
        [EnumMember(Value = "GRUPO")]
        GRUPO,

        /// <summary>
        /// POSTARO.
        /// </summary>
        [EnumMember(Value = "POSTA_RO")]
        POSTARO,

        /// <summary>
        /// INTERPARCELUK.
        /// </summary>
        [EnumMember(Value = "INTERPARCEL_UK")]
        INTERPARCELUK,

        /// <summary>
        /// GLOBALABF.
        /// </summary>
        [EnumMember(Value = "GLOBAL_ABF")]
        GLOBALABF,

        /// <summary>
        /// POSTENNORGE.
        /// </summary>
        [EnumMember(Value = "POSTEN_NORGE")]
        POSTENNORGE,

        /// <summary>
        /// XPERTDELIVERY.
        /// </summary>
        [EnumMember(Value = "XPERT_DELIVERY")]
        XPERTDELIVERY,

        /// <summary>
        /// DHLREFR.
        /// </summary>
        [EnumMember(Value = "DHL_REFR")]
        DHLREFR,

        /// <summary>
        /// DHLHK.
        /// </summary>
        [EnumMember(Value = "DHL_HK")]
        DHLHK,

        /// <summary>
        /// SKYNETUAE.
        /// </summary>
        [EnumMember(Value = "SKYNET_UAE")]
        SKYNETUAE,

        /// <summary>
        /// GOJEK.
        /// </summary>
        [EnumMember(Value = "GOJEK")]
        GOJEK,

        /// <summary>
        /// YODELINTNL.
        /// </summary>
        [EnumMember(Value = "YODEL_INTNL")]
        YODELINTNL,

        /// <summary>
        /// JANCO.
        /// </summary>
        [EnumMember(Value = "JANCO")]
        JANCO,

        /// <summary>
        /// YTO.
        /// </summary>
        [EnumMember(Value = "YTO")]
        YTO,

        /// <summary>
        /// WISEEXPRESS.
        /// </summary>
        [EnumMember(Value = "WISE_EXPRESS")]
        WISEEXPRESS,

        /// <summary>
        /// JTEXPRESSVN.
        /// </summary>
        [EnumMember(Value = "JTEXPRESS_VN")]
        JTEXPRESSVN,

        /// <summary>
        /// FEDEXINTLMLSERV.
        /// </summary>
        [EnumMember(Value = "FEDEX_INTL_MLSERV")]
        FEDEXINTLMLSERV,

        /// <summary>
        /// VAMOX.
        /// </summary>
        [EnumMember(Value = "VAMOX")]
        VAMOX,

        /// <summary>
        /// AMSGRP.
        /// </summary>
        [EnumMember(Value = "AMS_GRP")]
        AMSGRP,

        /// <summary>
        /// DHLJP.
        /// </summary>
        [EnumMember(Value = "DHL_JP")]
        DHLJP,

        /// <summary>
        /// HRPARCEL.
        /// </summary>
        [EnumMember(Value = "HRPARCEL")]
        HRPARCEL,

        /// <summary>
        /// GESWL.
        /// </summary>
        [EnumMember(Value = "GESWL")]
        GESWL,

        /// <summary>
        /// BLUESTAR.
        /// </summary>
        [EnumMember(Value = "BLUESTAR")]
        BLUESTAR,

        /// <summary>
        /// CDEKTR.
        /// </summary>
        [EnumMember(Value = "CDEK_TR")]
        CDEKTR,

        /// <summary>
        /// DESCARTES.
        /// </summary>
        [EnumMember(Value = "DESCARTES")]
        DESCARTES,

        /// <summary>
        /// DELTECUK.
        /// </summary>
        [EnumMember(Value = "DELTEC_UK")]
        DELTECUK,

        /// <summary>
        /// DTDCEXPRESS.
        /// </summary>
        [EnumMember(Value = "DTDC_EXPRESS")]
        DTDCEXPRESS,

        /// <summary>
        /// TOURLINE.
        /// </summary>
        [EnumMember(Value = "TOURLINE")]
        TOURLINE,

        /// <summary>
        /// BHWORLDWIDE.
        /// </summary>
        [EnumMember(Value = "BH_WORLDWIDE")]
        BHWORLDWIDE,

        /// <summary>
        /// OCS.
        /// </summary>
        [EnumMember(Value = "OCS")]
        OCS,

        /// <summary>
        /// YINGNUOLOGISTICS.
        /// </summary>
        [EnumMember(Value = "YINGNUO_LOGISTICS")]
        YINGNUOLOGISTICS,

        /// <summary>
        /// UPS.
        /// </summary>
        [EnumMember(Value = "UPS")]
        UPS,

        /// <summary>
        /// TOLL.
        /// </summary>
        [EnumMember(Value = "TOLL")]
        TOLL,

        /// <summary>
        /// PRTSEUR.
        /// </summary>
        [EnumMember(Value = "PRT_SEUR")]
        PRTSEUR,

        /// <summary>
        /// DTDCAU.
        /// </summary>
        [EnumMember(Value = "DTDC_AU")]
        DTDCAU,

        /// <summary>
        /// THADYNAMICLOGISTICS.
        /// </summary>
        [EnumMember(Value = "THA_DYNAMIC_LOGISTICS")]
        THADYNAMICLOGISTICS,

        /// <summary>
        /// UBILOGISTICS.
        /// </summary>
        [EnumMember(Value = "UBI_LOGISTICS")]
        UBILOGISTICS,

        /// <summary>
        /// FEDEXCROSSBORDER.
        /// </summary>
        [EnumMember(Value = "FEDEX_CROSSBORDER")]
        FEDEXCROSSBORDER,

        /// <summary>
        /// A1POST.
        /// </summary>
        [EnumMember(Value = "A1POST")]
        A1POST,

        /// <summary>
        /// TAZMANIANFREIGHT.
        /// </summary>
        [EnumMember(Value = "TAZMANIAN_FREIGHT")]
        TAZMANIANFREIGHT,

        /// <summary>
        /// CJINTMY.
        /// </summary>
        [EnumMember(Value = "CJ_INT_MY")]
        CJINTMY,

        /// <summary>
        /// SAIAFREIGHT.
        /// </summary>
        [EnumMember(Value = "SAIA_FREIGHT")]
        SAIAFREIGHT,

        /// <summary>
        /// SGQXPRESS.
        /// </summary>
        [EnumMember(Value = "SG_QXPRESS")]
        SGQXPRESS,

        /// <summary>
        /// NHANSSOLUTIONS.
        /// </summary>
        [EnumMember(Value = "NHANS_SOLUTIONS")]
        NHANSSOLUTIONS,

        /// <summary>
        /// DPDFR.
        /// </summary>
        [EnumMember(Value = "DPD_FR")]
        DPDFR,

        /// <summary>
        /// COORDINADORA.
        /// </summary>
        [EnumMember(Value = "COORDINADORA")]
        COORDINADORA,

        /// <summary>
        /// ANDREANI.
        /// </summary>
        [EnumMember(Value = "ANDREANI")]
        ANDREANI,

        /// <summary>
        /// DOORA.
        /// </summary>
        [EnumMember(Value = "DOORA")]
        DOORA,

        /// <summary>
        /// INTERPARCELNZ.
        /// </summary>
        [EnumMember(Value = "INTERPARCEL_NZ")]
        INTERPARCELNZ,

        /// <summary>
        /// PHLJAMEXPRESS.
        /// </summary>
        [EnumMember(Value = "PHL_JAMEXPRESS")]
        PHLJAMEXPRESS,

        /// <summary>
        /// BELBELGIUMPOST.
        /// </summary>
        [EnumMember(Value = "BEL_BELGIUM_POST")]
        BELBELGIUMPOST,

        /// <summary>
        /// USAPC.
        /// </summary>
        [EnumMember(Value = "US_APC")]
        USAPC,

        /// <summary>
        /// IDNPOS.
        /// </summary>
        [EnumMember(Value = "IDN_POS")]
        IDNPOS,

        /// <summary>
        /// FRMONDIAL.
        /// </summary>
        [EnumMember(Value = "FR_MONDIAL")]
        FRMONDIAL,

        /// <summary>
        /// DEDHL.
        /// </summary>
        [EnumMember(Value = "DE_DHL")]
        DEDHL,

        /// <summary>
        /// HKRPX.
        /// </summary>
        [EnumMember(Value = "HK_RPX")]
        HKRPX,

        /// <summary>
        /// DHLPIECEID.
        /// </summary>
        [EnumMember(Value = "DHL_PIECEID")]
        DHLPIECEID,

        /// <summary>
        /// VNPOSTEMS.
        /// </summary>
        [EnumMember(Value = "VNPOST_EMS")]
        VNPOSTEMS,

        /// <summary>
        /// RRDONNELLEY.
        /// </summary>
        [EnumMember(Value = "RRDONNELLEY")]
        RRDONNELLEY,

        /// <summary>
        /// DPDDE.
        /// </summary>
        [EnumMember(Value = "DPD_DE")]
        DPDDE,

        /// <summary>
        /// DELCARTIN.
        /// </summary>
        [EnumMember(Value = "DELCART_IN")]
        DELCARTIN,

        /// <summary>
        /// IMEXGLOBALSOLUTIONS.
        /// </summary>
        [EnumMember(Value = "IMEXGLOBALSOLUTIONS")]
        IMEXGLOBALSOLUTIONS,

        /// <summary>
        /// ACOMMERCE.
        /// </summary>
        [EnumMember(Value = "ACOMMERCE")]
        ACOMMERCE,

        /// <summary>
        /// EURODIS.
        /// </summary>
        [EnumMember(Value = "EURODIS")]
        EURODIS,

        /// <summary>
        /// CANPAR.
        /// </summary>
        [EnumMember(Value = "CANPAR")]
        CANPAR,

        /// <summary>
        /// GLS.
        /// </summary>
        [EnumMember(Value = "GLS")]
        GLS,

        /// <summary>
        /// INDECOM.
        /// </summary>
        [EnumMember(Value = "IND_ECOM")]
        INDECOM,

        /// <summary>
        /// ESPENVIALIA.
        /// </summary>
        [EnumMember(Value = "ESP_ENVIALIA")]
        ESPENVIALIA,

        /// <summary>
        /// DHLUK.
        /// </summary>
        [EnumMember(Value = "DHL_UK")]
        DHLUK,

        /// <summary>
        /// SMSAEXPRESS.
        /// </summary>
        [EnumMember(Value = "SMSA_EXPRESS")]
        SMSAEXPRESS,

        /// <summary>
        /// TNTFR.
        /// </summary>
        [EnumMember(Value = "TNT_FR")]
        TNTFR,

        /// <summary>
        /// DEXI.
        /// </summary>
        [EnumMember(Value = "DEX_I")]
        DEXI,

        /// <summary>
        /// BUDBEEWEBHOOK.
        /// </summary>
        [EnumMember(Value = "BUDBEE_WEBHOOK")]
        BUDBEEWEBHOOK,

        /// <summary>
        /// COPACOURIER.
        /// </summary>
        [EnumMember(Value = "COPA_COURIER")]
        COPACOURIER,

        /// <summary>
        /// VNMVIETNAMPOST.
        /// </summary>
        [EnumMember(Value = "VNM_VIETNAM_POST")]
        VNMVIETNAMPOST,

        /// <summary>
        /// DPDHK.
        /// </summary>
        [EnumMember(Value = "DPD_HK")]
        DPDHK,

        /// <summary>
        /// TOLLNZ.
        /// </summary>
        [EnumMember(Value = "TOLL_NZ")]
        TOLLNZ,

        /// <summary>
        /// ECHO.
        /// </summary>
        [EnumMember(Value = "ECHO")]
        ECHO,

        /// <summary>
        /// FEDEXFR.
        /// </summary>
        [EnumMember(Value = "FEDEX_FR")]
        FEDEXFR,

        /// <summary>
        /// BORDEREXPRESS.
        /// </summary>
        [EnumMember(Value = "BORDEREXPRESS")]
        BORDEREXPRESS,

        /// <summary>
        /// MAILPLUSJPN.
        /// </summary>
        [EnumMember(Value = "MAILPLUS_JPN")]
        MAILPLUSJPN,

        /// <summary>
        /// TNTUKREFR.
        /// </summary>
        [EnumMember(Value = "TNT_UK_REFR")]
        TNTUKREFR,

        /// <summary>
        /// KEC.
        /// </summary>
        [EnumMember(Value = "KEC")]
        KEC,

        /// <summary>
        /// DPDRO.
        /// </summary>
        [EnumMember(Value = "DPD_RO")]
        DPDRO,

        /// <summary>
        /// TNTJP.
        /// </summary>
        [EnumMember(Value = "TNT_JP")]
        TNTJP,

        /// <summary>
        /// THCJ.
        /// </summary>
        [EnumMember(Value = "TH_CJ")]
        THCJ,

        /// <summary>
        /// ECCN.
        /// </summary>
        [EnumMember(Value = "EC_CN")]
        ECCN,

        /// <summary>
        /// FASTWAYUK.
        /// </summary>
        [EnumMember(Value = "FASTWAY_UK")]
        FASTWAYUK,

        /// <summary>
        /// FASTWAYUS.
        /// </summary>
        [EnumMember(Value = "FASTWAY_US")]
        FASTWAYUS,

        /// <summary>
        /// GLSDE.
        /// </summary>
        [EnumMember(Value = "GLS_DE")]
        GLSDE,

        /// <summary>
        /// GLSES.
        /// </summary>
        [EnumMember(Value = "GLS_ES")]
        GLSES,

        /// <summary>
        /// GLSFR.
        /// </summary>
        [EnumMember(Value = "GLS_FR")]
        GLSFR,

        /// <summary>
        /// MONDIALBE.
        /// </summary>
        [EnumMember(Value = "MONDIAL_BE")]
        MONDIALBE,

        /// <summary>
        /// SGTIT.
        /// </summary>
        [EnumMember(Value = "SGT_IT")]
        SGTIT,

        /// <summary>
        /// TNTCN.
        /// </summary>
        [EnumMember(Value = "TNT_CN")]
        TNTCN,

        /// <summary>
        /// TNTDE.
        /// </summary>
        [EnumMember(Value = "TNT_DE")]
        TNTDE,

        /// <summary>
        /// TNTES.
        /// </summary>
        [EnumMember(Value = "TNT_ES")]
        TNTES,

        /// <summary>
        /// TNTPL.
        /// </summary>
        [EnumMember(Value = "TNT_PL")]
        TNTPL,

        /// <summary>
        /// PARCELFORCE.
        /// </summary>
        [EnumMember(Value = "PARCELFORCE")]
        PARCELFORCE,

        /// <summary>
        /// SWISSPOST.
        /// </summary>
        [EnumMember(Value = "SWISS_POST")]
        SWISSPOST,

        /// <summary>
        /// TOLLIPEC.
        /// </summary>
        [EnumMember(Value = "TOLL_IPEC")]
        TOLLIPEC,

        /// <summary>
        /// AIR21.
        /// </summary>
        [EnumMember(Value = "AIR_21")]
        AIR21,

        /// <summary>
        /// AIRSPEED.
        /// </summary>
        [EnumMember(Value = "AIRSPEED")]
        AIRSPEED,

        /// <summary>
        /// BERT.
        /// </summary>
        [EnumMember(Value = "BERT")]
        BERT,

        /// <summary>
        /// BLUEDART.
        /// </summary>
        [EnumMember(Value = "BLUEDART")]
        BLUEDART,

        /// <summary>
        /// COLLECTPLUS.
        /// </summary>
        [EnumMember(Value = "COLLECTPLUS")]
        COLLECTPLUS,

        /// <summary>
        /// COURIERPLUS.
        /// </summary>
        [EnumMember(Value = "COURIERPLUS")]
        COURIERPLUS,

        /// <summary>
        /// COURIERPOST.
        /// </summary>
        [EnumMember(Value = "COURIER_POST")]
        COURIERPOST,

        /// <summary>
        /// DHLGLOBALMAIL.
        /// </summary>
        [EnumMember(Value = "DHL_GLOBAL_MAIL")]
        DHLGLOBALMAIL,

        /// <summary>
        /// DPDUK.
        /// </summary>
        [EnumMember(Value = "DPD_UK")]
        DPDUK,

        /// <summary>
        /// DELTECDE.
        /// </summary>
        [EnumMember(Value = "DELTEC_DE")]
        DELTECDE,

        /// <summary>
        /// DEUTSCHEDE.
        /// </summary>
        [EnumMember(Value = "DEUTSCHE_DE")]
        DEUTSCHEDE,

        /// <summary>
        /// DOTZOT.
        /// </summary>
        [EnumMember(Value = "DOTZOT")]
        DOTZOT,

        /// <summary>
        /// ELTAGR.
        /// </summary>
        [EnumMember(Value = "ELTA_GR")]
        ELTAGR,

        /// <summary>
        /// EMSCN.
        /// </summary>
        [EnumMember(Value = "EMS_CN")]
        EMSCN,

        /// <summary>
        /// ECARGO.
        /// </summary>
        [EnumMember(Value = "ECARGO")]
        ECARGO,

        /// <summary>
        /// ENSENDA.
        /// </summary>
        [EnumMember(Value = "ENSENDA")]
        ENSENDA,

        /// <summary>
        /// FERCAMIT.
        /// </summary>
        [EnumMember(Value = "FERCAM_IT")]
        FERCAMIT,

        /// <summary>
        /// FASTWAYZA.
        /// </summary>
        [EnumMember(Value = "FASTWAY_ZA")]
        FASTWAYZA,

        /// <summary>
        /// FASTWAYAU.
        /// </summary>
        [EnumMember(Value = "FASTWAY_AU")]
        FASTWAYAU,

        /// <summary>
        /// FIRSTLOGISITCS.
        /// </summary>
        [EnumMember(Value = "FIRST_LOGISITCS")]
        FIRSTLOGISITCS,

        /// <summary>
        /// GEODIS.
        /// </summary>
        [EnumMember(Value = "GEODIS")]
        GEODIS,

        /// <summary>
        /// GLOBEGISTICS.
        /// </summary>
        [EnumMember(Value = "GLOBEGISTICS")]
        GLOBEGISTICS,

        /// <summary>
        /// GREYHOUND.
        /// </summary>
        [EnumMember(Value = "GREYHOUND")]
        GREYHOUND,

        /// <summary>
        /// JETSHIPMY.
        /// </summary>
        [EnumMember(Value = "JETSHIP_MY")]
        JETSHIPMY,

        /// <summary>
        /// LIONPARCEL.
        /// </summary>
        [EnumMember(Value = "LION_PARCEL")]
        LIONPARCEL,

        /// <summary>
        /// AEROFLASH.
        /// </summary>
        [EnumMember(Value = "AEROFLASH")]
        AEROFLASH,

        /// <summary>
        /// ONTRAC.
        /// </summary>
        [EnumMember(Value = "ONTRAC")]
        ONTRAC,

        /// <summary>
        /// SAGAWA.
        /// </summary>
        [EnumMember(Value = "SAGAWA")]
        SAGAWA,

        /// <summary>
        /// SIODEMKA.
        /// </summary>
        [EnumMember(Value = "SIODEMKA")]
        SIODEMKA,

        /// <summary>
        /// STARTRACK.
        /// </summary>
        [EnumMember(Value = "STARTRACK")]
        STARTRACK,

        /// <summary>
        /// TNTAU.
        /// </summary>
        [EnumMember(Value = "TNT_AU")]
        TNTAU,

        /// <summary>
        /// TNTIT.
        /// </summary>
        [EnumMember(Value = "TNT_IT")]
        TNTIT,

        /// <summary>
        /// TRANSMISSION.
        /// </summary>
        [EnumMember(Value = "TRANSMISSION")]
        TRANSMISSION,

        /// <summary>
        /// YAMATO.
        /// </summary>
        [EnumMember(Value = "YAMATO")]
        YAMATO,

        /// <summary>
        /// DHLIT.
        /// </summary>
        [EnumMember(Value = "DHL_IT")]
        DHLIT,

        /// <summary>
        /// DHLAT.
        /// </summary>
        [EnumMember(Value = "DHL_AT")]
        DHLAT,

        /// <summary>
        /// LOGISTICSWORLDWIDEKR.
        /// </summary>
        [EnumMember(Value = "LOGISTICSWORLDWIDE_KR")]
        LOGISTICSWORLDWIDEKR,

        /// <summary>
        /// GLSSPAIN.
        /// </summary>
        [EnumMember(Value = "GLS_SPAIN")]
        GLSSPAIN,

        /// <summary>
        /// AMAZONUKAPI.
        /// </summary>
        [EnumMember(Value = "AMAZON_UK_API")]
        AMAZONUKAPI,

        /// <summary>
        /// DPDFRREFERENCE.
        /// </summary>
        [EnumMember(Value = "DPD_FR_REFERENCE")]
        DPDFRREFERENCE,

        /// <summary>
        /// DHLPARCELUK.
        /// </summary>
        [EnumMember(Value = "DHLPARCEL_UK")]
        DHLPARCELUK,

        /// <summary>
        /// MEGASAVE.
        /// </summary>
        [EnumMember(Value = "MEGASAVE")]
        MEGASAVE,

        /// <summary>
        /// QUALITYPOST.
        /// </summary>
        [EnumMember(Value = "QUALITYPOST")]
        QUALITYPOST,

        /// <summary>
        /// IDSLOGISTICS.
        /// </summary>
        [EnumMember(Value = "IDS_LOGISTICS")]
        IDSLOGISTICS,

        /// <summary>
        /// JOYINGBOX1.
        /// </summary>
        [EnumMember(Value = "JOYINGBOX")]
        JOYINGBOX1,

        /// <summary>
        /// PANTHERORDERNUMBER.
        /// </summary>
        [EnumMember(Value = "PANTHER_ORDER_NUMBER")]
        PANTHERORDERNUMBER,

        /// <summary>
        /// WATKINSSHEPARD.
        /// </summary>
        [EnumMember(Value = "WATKINS_SHEPARD")]
        WATKINSSHEPARD,

        /// <summary>
        /// FASTTRACK.
        /// </summary>
        [EnumMember(Value = "FASTTRACK")]
        FASTTRACK,

        /// <summary>
        /// UPEXPRESS.
        /// </summary>
        [EnumMember(Value = "UP_EXPRESS")]
        UPEXPRESS,

        /// <summary>
        /// ELOGISTICA.
        /// </summary>
        [EnumMember(Value = "ELOGISTICA")]
        ELOGISTICA,

        /// <summary>
        /// ECOURIER.
        /// </summary>
        [EnumMember(Value = "ECOURIER")]
        ECOURIER,

        /// <summary>
        /// CJPHILIPPINES.
        /// </summary>
        [EnumMember(Value = "CJ_PHILIPPINES")]
        CJPHILIPPINES,

        /// <summary>
        /// SPEEDEX.
        /// </summary>
        [EnumMember(Value = "SPEEDEX")]
        SPEEDEX,

        /// <summary>
        /// ORANGECONNEX.
        /// </summary>
        [EnumMember(Value = "ORANGECONNEX")]
        ORANGECONNEX,

        /// <summary>
        /// TECOR.
        /// </summary>
        [EnumMember(Value = "TECOR")]
        TECOR,

        /// <summary>
        /// SAEE.
        /// </summary>
        [EnumMember(Value = "SAEE")]
        SAEE,

        /// <summary>
        /// GLSITALYFTP.
        /// </summary>
        [EnumMember(Value = "GLS_ITALY_FTP")]
        GLSITALYFTP,

        /// <summary>
        /// DELIVERE.
        /// </summary>
        [EnumMember(Value = "DELIVERE")]
        DELIVERE,

        /// <summary>
        /// YYCOM.
        /// </summary>
        [EnumMember(Value = "YYCOM")]
        YYCOM,

        /// <summary>
        /// ADICIONALPT.
        /// </summary>
        [EnumMember(Value = "ADICIONAL_PT")]
        ADICIONALPT,

        /// <summary>
        /// DKSH.
        /// </summary>
        [EnumMember(Value = "DKSH")]
        DKSH,

        /// <summary>
        /// NIPPONEXPRESSFTP.
        /// </summary>
        [EnumMember(Value = "NIPPON_EXPRESS_FTP")]
        NIPPONEXPRESSFTP,

        /// <summary>
        /// GOLS.
        /// </summary>
        [EnumMember(Value = "GOLS")]
        GOLS,

        /// <summary>
        /// FUJEXP.
        /// </summary>
        [EnumMember(Value = "FUJEXP")]
        FUJEXP,

        /// <summary>
        /// QTRACK.
        /// </summary>
        [EnumMember(Value = "QTRACK")]
        QTRACK,

        /// <summary>
        /// OMLOGISTICSAPI.
        /// </summary>
        [EnumMember(Value = "OMLOGISTICS_API")]
        OMLOGISTICSAPI,

        /// <summary>
        /// GDPHARM.
        /// </summary>
        [EnumMember(Value = "GDPHARM")]
        GDPHARM,

        /// <summary>
        /// MISUMICN.
        /// </summary>
        [EnumMember(Value = "MISUMI_CN")]
        MISUMICN,

        /// <summary>
        /// AIRCANADA.
        /// </summary>
        [EnumMember(Value = "AIR_CANADA")]
        AIRCANADA,

        /// <summary>
        /// CITY56WEBHOOK.
        /// </summary>
        [EnumMember(Value = "CITY56_WEBHOOK")]
        CITY56WEBHOOK,

        /// <summary>
        /// SAGAWAAPI.
        /// </summary>
        [EnumMember(Value = "SAGAWA_API")]
        SAGAWAAPI,

        /// <summary>
        /// KEDAEX.
        /// </summary>
        [EnumMember(Value = "KEDAEX")]
        KEDAEX,

        /// <summary>
        /// PGEONAPI.
        /// </summary>
        [EnumMember(Value = "PGEON_API")]
        PGEONAPI,

        /// <summary>
        /// WEWORLDEXPRESS.
        /// </summary>
        [EnumMember(Value = "WEWORLDEXPRESS")]
        WEWORLDEXPRESS,

        /// <summary>
        /// JTLOGISTICS.
        /// </summary>
        [EnumMember(Value = "JT_LOGISTICS")]
        JTLOGISTICS,

        /// <summary>
        /// TRUSK.
        /// </summary>
        [EnumMember(Value = "TRUSK")]
        TRUSK,

        /// <summary>
        /// VIAXPRESS.
        /// </summary>
        [EnumMember(Value = "VIAXPRESS")]
        VIAXPRESS,

        /// <summary>
        /// DHLSUPPLYCHAINID.
        /// </summary>
        [EnumMember(Value = "DHL_SUPPLYCHAIN_ID")]
        DHLSUPPLYCHAINID,

        /// <summary>
        /// ZUELLIGPHARMASFTP.
        /// </summary>
        [EnumMember(Value = "ZUELLIGPHARMA_SFTP")]
        ZUELLIGPHARMASFTP,

        /// <summary>
        /// MEEST.
        /// </summary>
        [EnumMember(Value = "MEEST")]
        MEEST,

        /// <summary>
        /// TOLLPRIORITY.
        /// </summary>
        [EnumMember(Value = "TOLL_PRIORITY")]
        TOLLPRIORITY,

        /// <summary>
        /// MOTHERSHIPAPI.
        /// </summary>
        [EnumMember(Value = "MOTHERSHIP_API")]
        MOTHERSHIPAPI,

        /// <summary>
        /// CAPITAL.
        /// </summary>
        [EnumMember(Value = "CAPITAL")]
        CAPITAL,

        /// <summary>
        /// EUROPAKETAPI.
        /// </summary>
        [EnumMember(Value = "EUROPAKET_API")]
        EUROPAKETAPI,

        /// <summary>
        /// HFD.
        /// </summary>
        [EnumMember(Value = "HFD")]
        HFD,

        /// <summary>
        /// TOURLINEREFERENCE.
        /// </summary>
        [EnumMember(Value = "TOURLINE_REFERENCE")]
        TOURLINEREFERENCE,

        /// <summary>
        /// GIOECOURIER.
        /// </summary>
        [EnumMember(Value = "GIO_ECOURIER")]
        GIOECOURIER,

        /// <summary>
        /// CNLOGISTICS.
        /// </summary>
        [EnumMember(Value = "CN_LOGISTICS")]
        CNLOGISTICS,

        /// <summary>
        /// PANDION.
        /// </summary>
        [EnumMember(Value = "PANDION")]
        PANDION,

        /// <summary>
        /// BPOSTAPI.
        /// </summary>
        [EnumMember(Value = "BPOST_API")]
        BPOSTAPI,

        /// <summary>
        /// PASSPORTSHIPPING.
        /// </summary>
        [EnumMember(Value = "PASSPORTSHIPPING")]
        PASSPORTSHIPPING,

        /// <summary>
        /// PAKAJO.
        /// </summary>
        [EnumMember(Value = "PAKAJO")]
        PAKAJO,

        /// <summary>
        /// DACHSER.
        /// </summary>
        [EnumMember(Value = "DACHSER")]
        DACHSER,

        /// <summary>
        /// YUSENSFTP.
        /// </summary>
        [EnumMember(Value = "YUSEN_SFTP")]
        YUSENSFTP,

        /// <summary>
        /// SHYPLITE.
        /// </summary>
        [EnumMember(Value = "SHYPLITE")]
        SHYPLITE,

        /// <summary>
        /// XYY.
        /// </summary>
        [EnumMember(Value = "XYY")]
        XYY,

        /// <summary>
        /// MWD.
        /// </summary>
        [EnumMember(Value = "MWD")]
        MWD,

        /// <summary>
        /// FAXECARGO.
        /// </summary>
        [EnumMember(Value = "FAXECARGO")]
        FAXECARGO,

        /// <summary>
        /// MAZET.
        /// </summary>
        [EnumMember(Value = "MAZET")]
        MAZET,

        /// <summary>
        /// FIRSTLOGISTICSAPI.
        /// </summary>
        [EnumMember(Value = "FIRST_LOGISTICS_API")]
        FIRSTLOGISTICSAPI,

        /// <summary>
        /// SPRINTPACK.
        /// </summary>
        [EnumMember(Value = "SPRINT_PACK")]
        SPRINTPACK,

        /// <summary>
        /// HERMESDEFTP.
        /// </summary>
        [EnumMember(Value = "HERMES_DE_FTP")]
        HERMESDEFTP,

        /// <summary>
        /// CONCISE.
        /// </summary>
        [EnumMember(Value = "CONCISE")]
        CONCISE,

        /// <summary>
        /// KERRYEXPRESSTWAPI.
        /// </summary>
        [EnumMember(Value = "KERRY_EXPRESS_TW_API")]
        KERRYEXPRESSTWAPI,

        /// <summary>
        /// EWE.
        /// </summary>
        [EnumMember(Value = "EWE")]
        EWE,

        /// <summary>
        /// FASTDESPATCH.
        /// </summary>
        [EnumMember(Value = "FASTDESPATCH")]
        FASTDESPATCH,

        /// <summary>
        /// ABCUSTOMSFTP.
        /// </summary>
        [EnumMember(Value = "ABCUSTOM_SFTP")]
        ABCUSTOMSFTP,

        /// <summary>
        /// CHAZKI.
        /// </summary>
        [EnumMember(Value = "CHAZKI")]
        CHAZKI,

        /// <summary>
        /// SHIPPIE.
        /// </summary>
        [EnumMember(Value = "SHIPPIE")]
        SHIPPIE,

        /// <summary>
        /// GEODISAPI.
        /// </summary>
        [EnumMember(Value = "GEODIS_API")]
        GEODISAPI,

        /// <summary>
        /// NAQELEXPRESS.
        /// </summary>
        [EnumMember(Value = "NAQEL_EXPRESS")]
        NAQELEXPRESS,

        /// <summary>
        /// PAPAWEBHOOK.
        /// </summary>
        [EnumMember(Value = "PAPA_WEBHOOK")]
        PAPAWEBHOOK,

        /// <summary>
        /// FORWARDAIR.
        /// </summary>
        [EnumMember(Value = "FORWARDAIR")]
        FORWARDAIR,

        /// <summary>
        /// DIALOGOLOGISTICAAPI.
        /// </summary>
        [EnumMember(Value = "DIALOGO_LOGISTICA_API")]
        DIALOGOLOGISTICAAPI,

        /// <summary>
        /// LALAMOVEAPI.
        /// </summary>
        [EnumMember(Value = "LALAMOVE_API")]
        LALAMOVEAPI,

        /// <summary>
        /// TOMYDOOR.
        /// </summary>
        [EnumMember(Value = "TOMYDOOR")]
        TOMYDOOR,

        /// <summary>
        /// KRONOSWEBHOOK.
        /// </summary>
        [EnumMember(Value = "KRONOS_WEBHOOK")]
        KRONOSWEBHOOK,

        /// <summary>
        /// JTCARGO.
        /// </summary>
        [EnumMember(Value = "JTCARGO")]
        JTCARGO,

        /// <summary>
        /// TCAT.
        /// </summary>
        [EnumMember(Value = "T_CAT")]
        TCAT,

        /// <summary>
        /// CONCISEWEBHOOK.
        /// </summary>
        [EnumMember(Value = "CONCISE_WEBHOOK")]
        CONCISEWEBHOOK,

        /// <summary>
        /// TELEPORTWEBHOOK.
        /// </summary>
        [EnumMember(Value = "TELEPORT_WEBHOOK")]
        TELEPORTWEBHOOK,

        /// <summary>
        /// CUSTOMCOAPI.
        /// </summary>
        [EnumMember(Value = "CUSTOMCO_API")]
        CUSTOMCOAPI,

        /// <summary>
        /// SPXTH.
        /// </summary>
        [EnumMember(Value = "SPX_TH")]
        SPXTH,

        /// <summary>
        /// BOLLORELOGISTICS.
        /// </summary>
        [EnumMember(Value = "BOLLORE_LOGISTICS")]
        BOLLORELOGISTICS,

        /// <summary>
        /// CLICKLINKSFTP.
        /// </summary>
        [EnumMember(Value = "CLICKLINK_SFTP")]
        CLICKLINKSFTP,

        /// <summary>
        /// M3LOGISTICS.
        /// </summary>
        [EnumMember(Value = "M3LOGISTICS")]
        M3LOGISTICS,

        /// <summary>
        /// VNPOSTAPI.
        /// </summary>
        [EnumMember(Value = "VNPOST_API")]
        VNPOSTAPI,

        /// <summary>
        /// AXLEHIREFTP.
        /// </summary>
        [EnumMember(Value = "AXLEHIRE_FTP")]
        AXLEHIREFTP,

        /// <summary>
        /// SHADOWFAX.
        /// </summary>
        [EnumMember(Value = "SHADOWFAX")]
        SHADOWFAX,

        /// <summary>
        /// MYHERMESUKAPI.
        /// </summary>
        [EnumMember(Value = "MYHERMES_UK_API")]
        MYHERMESUKAPI,

        /// <summary>
        /// DAIICHI.
        /// </summary>
        [EnumMember(Value = "DAIICHI")]
        DAIICHI,

        /// <summary>
        /// MENSAJEROSURBANOSAPI.
        /// </summary>
        [EnumMember(Value = "MENSAJEROSURBANOS_API")]
        MENSAJEROSURBANOSAPI,

        /// <summary>
        /// POLARSPEED.
        /// </summary>
        [EnumMember(Value = "POLARSPEED")]
        POLARSPEED,

        /// <summary>
        /// IDEXPRESSID.
        /// </summary>
        [EnumMember(Value = "IDEXPRESS_ID")]
        IDEXPRESSID,

        /// <summary>
        /// PAYO.
        /// </summary>
        [EnumMember(Value = "PAYO")]
        PAYO,

        /// <summary>
        /// WHISTLSFTP.
        /// </summary>
        [EnumMember(Value = "WHISTL_SFTP")]
        WHISTLSFTP,

        /// <summary>
        /// INTEXDE.
        /// </summary>
        [EnumMember(Value = "INTEX_DE")]
        INTEXDE,

        /// <summary>
        /// TRANS2U.
        /// </summary>
        [EnumMember(Value = "TRANS2U")]
        TRANS2U,

        /// <summary>
        /// PRODUCTCAREGROUPSFTP.
        /// </summary>
        [EnumMember(Value = "PRODUCTCAREGROUP_SFTP")]
        PRODUCTCAREGROUPSFTP,

        /// <summary>
        /// BIGSMART.
        /// </summary>
        [EnumMember(Value = "BIGSMART")]
        BIGSMART,

        /// <summary>
        /// EXPEDITORSAPIREF.
        /// </summary>
        [EnumMember(Value = "EXPEDITORS_API_REF")]
        EXPEDITORSAPIREF,

        /// <summary>
        /// AITWORLDWIDEAPI.
        /// </summary>
        [EnumMember(Value = "AITWORLDWIDE_API")]
        AITWORLDWIDEAPI,

        /// <summary>
        /// WORLDCOURIER.
        /// </summary>
        [EnumMember(Value = "WORLDCOURIER")]
        WORLDCOURIER,

        /// <summary>
        /// QUIQUP.
        /// </summary>
        [EnumMember(Value = "QUIQUP")]
        QUIQUP,

        /// <summary>
        /// AGEDISSSFTP.
        /// </summary>
        [EnumMember(Value = "AGEDISS_SFTP")]
        AGEDISSSFTP,

        /// <summary>
        /// ANDREANIAPI.
        /// </summary>
        [EnumMember(Value = "ANDREANI_API")]
        ANDREANIAPI,

        /// <summary>
        /// CRLEXPRESS.
        /// </summary>
        [EnumMember(Value = "CRLEXPRESS")]
        CRLEXPRESS,

        /// <summary>
        /// SMARTCAT.
        /// </summary>
        [EnumMember(Value = "SMARTCAT")]
        SMARTCAT,

        /// <summary>
        /// CROSSFLIGHT.
        /// </summary>
        [EnumMember(Value = "CROSSFLIGHT")]
        CROSSFLIGHT,

        /// <summary>
        /// PROCARRIER.
        /// </summary>
        [EnumMember(Value = "PROCARRIER")]
        PROCARRIER,

        /// <summary>
        /// DHLREFERENCEAPI.
        /// </summary>
        [EnumMember(Value = "DHL_REFERENCE_API")]
        DHLREFERENCEAPI,

        /// <summary>
        /// SEINOAPI.
        /// </summary>
        [EnumMember(Value = "SEINO_API")]
        SEINOAPI,

        /// <summary>
        /// WSPEXPRESS.
        /// </summary>
        [EnumMember(Value = "WSPEXPRESS")]
        WSPEXPRESS,

        /// <summary>
        /// KRONOS.
        /// </summary>
        [EnumMember(Value = "KRONOS")]
        KRONOS,

        /// <summary>
        /// TOTALEXPRESSAPI.
        /// </summary>
        [EnumMember(Value = "TOTAL_EXPRESS_API")]
        TOTALEXPRESSAPI,

        /// <summary>
        /// PARCLL.
        /// </summary>
        [EnumMember(Value = "PARCLL")]
        PARCLL,

        /// <summary>
        /// XPEDIGO.
        /// </summary>
        [EnumMember(Value = "XPEDIGO")]
        XPEDIGO,

        /// <summary>
        /// STARTRACKWEBHOOK.
        /// </summary>
        [EnumMember(Value = "STAR_TRACK_WEBHOOK")]
        STARTRACKWEBHOOK,

        /// <summary>
        /// GPOST.
        /// </summary>
        [EnumMember(Value = "GPOST")]
        GPOST,

        /// <summary>
        /// UCS.
        /// </summary>
        [EnumMember(Value = "UCS")]
        UCS,

        /// <summary>
        /// DMFGROUP.
        /// </summary>
        [EnumMember(Value = "DMFGROUP")]
        DMFGROUP,

        /// <summary>
        /// COORDINADORAAPI.
        /// </summary>
        [EnumMember(Value = "COORDINADORA_API")]
        COORDINADORAAPI,

        /// <summary>
        /// MARKEN.
        /// </summary>
        [EnumMember(Value = "MARKEN")]
        MARKEN,

        /// <summary>
        /// NTL.
        /// </summary>
        [EnumMember(Value = "NTL")]
        NTL,

        /// <summary>
        /// REDJEPAKKETJE.
        /// </summary>
        [EnumMember(Value = "REDJEPAKKETJE")]
        REDJEPAKKETJE,

        /// <summary>
        /// ALLIEDEXPRESSFTP.
        /// </summary>
        [EnumMember(Value = "ALLIED_EXPRESS_FTP")]
        ALLIEDEXPRESSFTP,

        /// <summary>
        /// MONDIALRELAYES.
        /// </summary>
        [EnumMember(Value = "MONDIALRELAY_ES")]
        MONDIALRELAYES,

        /// <summary>
        /// NAEKOFTP.
        /// </summary>
        [EnumMember(Value = "NAEKO_FTP")]
        NAEKOFTP,

        /// <summary>
        /// MHI.
        /// </summary>
        [EnumMember(Value = "MHI")]
        MHI,

        /// <summary>
        /// SHIPPIFY.
        /// </summary>
        [EnumMember(Value = "SHIPPIFY")]
        SHIPPIFY,

        /// <summary>
        /// MALCAAMITAPI.
        /// </summary>
        [EnumMember(Value = "MALCA_AMIT_API")]
        MALCAAMITAPI,

        /// <summary>
        /// JTEXPRESSSGAPI.
        /// </summary>
        [EnumMember(Value = "JTEXPRESS_SG_API")]
        JTEXPRESSSGAPI,

        /// <summary>
        /// DACHSERWEB.
        /// </summary>
        [EnumMember(Value = "DACHSER_WEB")]
        DACHSERWEB,

        /// <summary>
        /// FLIGHTLG.
        /// </summary>
        [EnumMember(Value = "FLIGHTLG")]
        FLIGHTLG,

        /// <summary>
        /// CAGO.
        /// </summary>
        [EnumMember(Value = "CAGO")]
        CAGO,

        /// <summary>
        /// COM1EXPRESS.
        /// </summary>
        [EnumMember(Value = "COM1EXPRESS")]
        COM1EXPRESS,

        /// <summary>
        /// TONAMIFTP.
        /// </summary>
        [EnumMember(Value = "TONAMI_FTP")]
        TONAMIFTP,

        /// <summary>
        /// PACKFLEET.
        /// </summary>
        [EnumMember(Value = "PACKFLEET")]
        PACKFLEET,

        /// <summary>
        /// PUROLATORINTERNATIONAL.
        /// </summary>
        [EnumMember(Value = "PUROLATOR_INTERNATIONAL")]
        PUROLATORINTERNATIONAL,

        /// <summary>
        /// WINESHIPPINGWEBHOOK.
        /// </summary>
        [EnumMember(Value = "WINESHIPPING_WEBHOOK")]
        WINESHIPPINGWEBHOOK,

        /// <summary>
        /// DHLESSFTP.
        /// </summary>
        [EnumMember(Value = "DHL_ES_SFTP")]
        DHLESSFTP,

        /// <summary>
        /// PCHOMEAPI.
        /// </summary>
        [EnumMember(Value = "PCHOME_API")]
        PCHOMEAPI,

        /// <summary>
        /// CESKAPOSTAAPI.
        /// </summary>
        [EnumMember(Value = "CESKAPOSTA_API")]
        CESKAPOSTAAPI,

        /// <summary>
        /// GORUSH.
        /// </summary>
        [EnumMember(Value = "GORUSH")]
        GORUSH,

        /// <summary>
        /// HOMERUNNER.
        /// </summary>
        [EnumMember(Value = "HOMERUNNER")]
        HOMERUNNER,

        /// <summary>
        /// AMAZONORDER.
        /// </summary>
        [EnumMember(Value = "AMAZON_ORDER")]
        AMAZONORDER,

        /// <summary>
        /// EFWNOWAPI.
        /// </summary>
        [EnumMember(Value = "EFWNOW_API")]
        EFWNOWAPI,

        /// <summary>
        /// CBLLOGISTICAAPI.
        /// </summary>
        [EnumMember(Value = "CBL_LOGISTICA_API")]
        CBLLOGISTICAAPI,

        /// <summary>
        /// NIMBUSPOST.
        /// </summary>
        [EnumMember(Value = "NIMBUSPOST")]
        NIMBUSPOST,

        /// <summary>
        /// LOGWINLOGISTICS.
        /// </summary>
        [EnumMember(Value = "LOGWIN_LOGISTICS")]
        LOGWINLOGISTICS,

        /// <summary>
        /// NOWLOGAPI.
        /// </summary>
        [EnumMember(Value = "NOWLOG_API")]
        NOWLOGAPI,

        /// <summary>
        /// DPDNL.
        /// </summary>
        [EnumMember(Value = "DPD_NL")]
        DPDNL,

        /// <summary>
        /// GODEPENDABLE.
        /// </summary>
        [EnumMember(Value = "GODEPENDABLE")]
        GODEPENDABLE,

        /// <summary>
        /// ESDEX.
        /// </summary>
        [EnumMember(Value = "ESDEX")]
        ESDEX,

        /// <summary>
        /// LOGISYSTEMSSFTP.
        /// </summary>
        [EnumMember(Value = "LOGISYSTEMS_SFTP")]
        LOGISYSTEMSSFTP,

        /// <summary>
        /// EXPEDITORS.
        /// </summary>
        [EnumMember(Value = "EXPEDITORS")]
        EXPEDITORS,

        /// <summary>
        /// SNTGLOBALAPI.
        /// </summary>
        [EnumMember(Value = "SNTGLOBAL_API")]
        SNTGLOBALAPI,

        /// <summary>
        /// SHIPX.
        /// </summary>
        [EnumMember(Value = "SHIPX")]
        SHIPX,

        /// <summary>
        /// QINTLAPI.
        /// </summary>
        [EnumMember(Value = "QINTL_API")]
        QINTLAPI,

        /// <summary>
        /// PACKS.
        /// </summary>
        [EnumMember(Value = "PACKS")]
        PACKS,

        /// <summary>
        /// POSTNLINTERNATIONAL.
        /// </summary>
        [EnumMember(Value = "POSTNL_INTERNATIONAL")]
        POSTNLINTERNATIONAL,

        /// <summary>
        /// AMAZONEMAILPUSH.
        /// </summary>
        [EnumMember(Value = "AMAZON_EMAIL_PUSH")]
        AMAZONEMAILPUSH,

        /// <summary>
        /// DHLAPI.
        /// </summary>
        [EnumMember(Value = "DHL_API")]
        DHLAPI,

        /// <summary>
        /// SPX.
        /// </summary>
        [EnumMember(Value = "SPX")]
        SPX,

        /// <summary>
        /// AXLEHIRE.
        /// </summary>
        [EnumMember(Value = "AXLEHIRE")]
        AXLEHIRE,

        /// <summary>
        /// ICSCOURIER.
        /// </summary>
        [EnumMember(Value = "ICSCOURIER")]
        ICSCOURIER,

        /// <summary>
        /// DIALOGOLOGISTICA.
        /// </summary>
        [EnumMember(Value = "DIALOGO_LOGISTICA")]
        DIALOGOLOGISTICA,

        /// <summary>
        /// SHUNBANGEXPRESS.
        /// </summary>
        [EnumMember(Value = "SHUNBANG_EXPRESS")]
        SHUNBANGEXPRESS,

        /// <summary>
        /// TCSAPI.
        /// </summary>
        [EnumMember(Value = "TCS_API")]
        TCSAPI,

        /// <summary>
        /// SFEXPRESSCN.
        /// </summary>
        [EnumMember(Value = "SF_EXPRESS_CN")]
        SFEXPRESSCN,

        /// <summary>
        /// PACKETA.
        /// </summary>
        [EnumMember(Value = "PACKETA")]
        PACKETA,

        /// <summary>
        /// SICTELIWAY.
        /// </summary>
        [EnumMember(Value = "SIC_TELIWAY")]
        SICTELIWAY,

        /// <summary>
        /// MONDIALRELAYFR.
        /// </summary>
        [EnumMember(Value = "MONDIALRELAY_FR")]
        MONDIALRELAYFR,

        /// <summary>
        /// INTIMEFTP.
        /// </summary>
        [EnumMember(Value = "INTIME_FTP")]
        INTIMEFTP,

        /// <summary>
        /// JDEXPRESS.
        /// </summary>
        [EnumMember(Value = "JD_EXPRESS")]
        JDEXPRESS,

        /// <summary>
        /// FASTBOX.
        /// </summary>
        [EnumMember(Value = "FASTBOX")]
        FASTBOX,

        /// <summary>
        /// PATHEON.
        /// </summary>
        [EnumMember(Value = "PATHEON")]
        PATHEON,

        /// <summary>
        /// INDIAPOST.
        /// </summary>
        [EnumMember(Value = "INDIA_POST")]
        INDIAPOST,

        /// <summary>
        /// TIPSAREF.
        /// </summary>
        [EnumMember(Value = "TIPSA_REF")]
        TIPSAREF,

        /// <summary>
        /// ECOFREIGHT.
        /// </summary>
        [EnumMember(Value = "ECOFREIGHT")]
        ECOFREIGHT,

        /// <summary>
        /// VOX.
        /// </summary>
        [EnumMember(Value = "VOX")]
        VOX,

        /// <summary>
        /// DIRECTFREIGHTAUREF.
        /// </summary>
        [EnumMember(Value = "DIRECTFREIGHT_AU_REF")]
        DIRECTFREIGHTAUREF,

        /// <summary>
        /// BESTTRANSPORTSFTP.
        /// </summary>
        [EnumMember(Value = "BESTTRANSPORT_SFTP")]
        BESTTRANSPORTSFTP,

        /// <summary>
        /// AUSTRALIAPOSTAPI.
        /// </summary>
        [EnumMember(Value = "AUSTRALIA_POST_API")]
        AUSTRALIAPOSTAPI,

        /// <summary>
        /// FRAGILEPAKSFTP.
        /// </summary>
        [EnumMember(Value = "FRAGILEPAK_SFTP")]
        FRAGILEPAKSFTP,

        /// <summary>
        /// FLIPXP.
        /// </summary>
        [EnumMember(Value = "FLIPXP")]
        FLIPXP,

        /// <summary>
        /// VALUEWEBHOOK.
        /// </summary>
        [EnumMember(Value = "VALUE_WEBHOOK")]
        VALUEWEBHOOK,

        /// <summary>
        /// DAESHIN.
        /// </summary>
        [EnumMember(Value = "DAESHIN")]
        DAESHIN,

        /// <summary>
        /// SHERPA.
        /// </summary>
        [EnumMember(Value = "SHERPA")]
        SHERPA,

        /// <summary>
        /// MWDAPI.
        /// </summary>
        [EnumMember(Value = "MWD_API")]
        MWDAPI,

        /// <summary>
        /// SMARTKARGO.
        /// </summary>
        [EnumMember(Value = "SMARTKARGO")]
        SMARTKARGO,

        /// <summary>
        /// DNJEXPRESS.
        /// </summary>
        [EnumMember(Value = "DNJ_EXPRESS")]
        DNJEXPRESS,

        /// <summary>
        /// GOPEOPLE.
        /// </summary>
        [EnumMember(Value = "GOPEOPLE")]
        GOPEOPLE,

        /// <summary>
        /// MYSENDLEAPI.
        /// </summary>
        [EnumMember(Value = "MYSENDLE_API")]
        MYSENDLEAPI,

        /// <summary>
        /// ARAMEXAPI.
        /// </summary>
        [EnumMember(Value = "ARAMEX_API")]
        ARAMEXAPI,

        /// <summary>
        /// PIDGE.
        /// </summary>
        [EnumMember(Value = "PIDGE")]
        PIDGE,

        /// <summary>
        /// THAIPARCELS.
        /// </summary>
        [EnumMember(Value = "THAIPARCELS")]
        THAIPARCELS,

        /// <summary>
        /// PANTHERREFERENCEAPI.
        /// </summary>
        [EnumMember(Value = "PANTHER_REFERENCE_API")]
        PANTHERREFERENCEAPI,

        /// <summary>
        /// POSTAPLUS1.
        /// </summary>
        [EnumMember(Value = "POSTAPLUS")]
        POSTAPLUS1,

        /// <summary>
        /// BUFFALO.
        /// </summary>
        [EnumMember(Value = "BUFFALO")]
        BUFFALO,

        /// <summary>
        /// UENVIOS.
        /// </summary>
        [EnumMember(Value = "U_ENVIOS")]
        UENVIOS,

        /// <summary>
        /// ELITECO.
        /// </summary>
        [EnumMember(Value = "ELITE_CO")]
        ELITECO,

        /// <summary>
        /// BARQEXP.
        /// </summary>
        [EnumMember(Value = "BARQEXP")]
        BARQEXP,

        /// <summary>
        /// ROCHEINTERNALSFTP.
        /// </summary>
        [EnumMember(Value = "ROCHE_INTERNAL_SFTP")]
        ROCHEINTERNALSFTP,

        /// <summary>
        /// DBSCHENKERICELAND.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_ICELAND")]
        DBSCHENKERICELAND,

        /// <summary>
        /// TNTFRREFERENCE.
        /// </summary>
        [EnumMember(Value = "TNT_FR_REFERENCE")]
        TNTFRREFERENCE,

        /// <summary>
        /// NEWGISTICSAPI.
        /// </summary>
        [EnumMember(Value = "NEWGISTICSAPI")]
        NEWGISTICSAPI,

        /// <summary>
        /// GLOVO.
        /// </summary>
        [EnumMember(Value = "GLOVO")]
        GLOVO,

        /// <summary>
        /// GWLOGISAPI.
        /// </summary>
        [EnumMember(Value = "GWLOGIS_API")]
        GWLOGISAPI,

        /// <summary>
        /// SPREETAILAPI.
        /// </summary>
        [EnumMember(Value = "SPREETAIL_API")]
        SPREETAILAPI,

        /// <summary>
        /// MOOVA.
        /// </summary>
        [EnumMember(Value = "MOOVA")]
        MOOVA,

        /// <summary>
        /// PLYCONGROUP.
        /// </summary>
        [EnumMember(Value = "PLYCONGROUP")]
        PLYCONGROUP,

        /// <summary>
        /// USPSWEBHOOK.
        /// </summary>
        [EnumMember(Value = "USPS_WEBHOOK")]
        USPSWEBHOOK,

        /// <summary>
        /// REIMAGINEDELIVERY.
        /// </summary>
        [EnumMember(Value = "REIMAGINEDELIVERY")]
        REIMAGINEDELIVERY,

        /// <summary>
        /// EDFFTP.
        /// </summary>
        [EnumMember(Value = "EDF_FTP")]
        EDFFTP,

        /// <summary>
        /// DAO365.
        /// </summary>
        [EnumMember(Value = "DAO365")]
        DAO365,

        /// <summary>
        /// BIOCAIRFTP.
        /// </summary>
        [EnumMember(Value = "BIOCAIR_FTP")]
        BIOCAIRFTP,

        /// <summary>
        /// RANSAWEBHOOK.
        /// </summary>
        [EnumMember(Value = "RANSA_WEBHOOK")]
        RANSAWEBHOOK,

        /// <summary>
        /// SHIPXPRES.
        /// </summary>
        [EnumMember(Value = "SHIPXPRES")]
        SHIPXPRES,

        /// <summary>
        /// COURANTPLUSAPI.
        /// </summary>
        [EnumMember(Value = "COURANT_PLUS_API")]
        COURANTPLUSAPI,

        /// <summary>
        /// SHIPA.
        /// </summary>
        [EnumMember(Value = "SHIPA")]
        SHIPA,

        /// <summary>
        /// HOMELOGISTICS.
        /// </summary>
        [EnumMember(Value = "HOMELOGISTICS")]
        HOMELOGISTICS,

        /// <summary>
        /// DX.
        /// </summary>
        [EnumMember(Value = "DX")]
        DX,

        /// <summary>
        /// POSTEITALIANEPACCOCELERE.
        /// </summary>
        [EnumMember(Value = "POSTE_ITALIANE_PACCOCELERE")]
        POSTEITALIANEPACCOCELERE,

        /// <summary>
        /// TOLLWEBHOOK.
        /// </summary>
        [EnumMember(Value = "TOLL_WEBHOOK")]
        TOLLWEBHOOK,

        /// <summary>
        /// LCTBRAPI.
        /// </summary>
        [EnumMember(Value = "LCTBR_API")]
        LCTBRAPI,

        /// <summary>
        /// DXFREIGHT.
        /// </summary>
        [EnumMember(Value = "DX_FREIGHT")]
        DXFREIGHT,

        /// <summary>
        /// DHLSFTP.
        /// </summary>
        [EnumMember(Value = "DHL_SFTP")]
        DHLSFTP,

        /// <summary>
        /// SHIPROCKET.
        /// </summary>
        [EnumMember(Value = "SHIPROCKET")]
        SHIPROCKET,

        /// <summary>
        /// UBERWEBHOOK.
        /// </summary>
        [EnumMember(Value = "UBER_WEBHOOK")]
        UBERWEBHOOK,

        /// <summary>
        /// STATOVERNIGHT.
        /// </summary>
        [EnumMember(Value = "STATOVERNIGHT")]
        STATOVERNIGHT,

        /// <summary>
        /// BURD.
        /// </summary>
        [EnumMember(Value = "BURD")]
        BURD,

        /// <summary>
        /// FASTSHIP.
        /// </summary>
        [EnumMember(Value = "FASTSHIP")]
        FASTSHIP,

        /// <summary>
        /// IBVENTUREWEBHOOK.
        /// </summary>
        [EnumMember(Value = "IBVENTURE_WEBHOOK")]
        IBVENTUREWEBHOOK,

        /// <summary>
        /// GATIKWEAPI.
        /// </summary>
        [EnumMember(Value = "GATI_KWE_API")]
        GATIKWEAPI,

        /// <summary>
        /// CRYOPDPFTP.
        /// </summary>
        [EnumMember(Value = "CRYOPDP_FTP")]
        CRYOPDPFTP,

        /// <summary>
        /// HUBBED.
        /// </summary>
        [EnumMember(Value = "HUBBED")]
        HUBBED,

        /// <summary>
        /// TIPSAAPI.
        /// </summary>
        [EnumMember(Value = "TIPSA_API")]
        TIPSAAPI,

        /// <summary>
        /// ARASKARGO.
        /// </summary>
        [EnumMember(Value = "ARASKARGO")]
        ARASKARGO,

        /// <summary>
        /// THIJSNL.
        /// </summary>
        [EnumMember(Value = "THIJS_NL")]
        THIJSNL,

        /// <summary>
        /// ATSHEALTHCAREREFERENCE.
        /// </summary>
        [EnumMember(Value = "ATSHEALTHCARE_REFERENCE")]
        ATSHEALTHCAREREFERENCE,

        /// <summary>
        /// Enum99MINUTOS.
        /// </summary>
        [EnumMember(Value = "99MINUTOS")]
        Enum99MINUTOS,

        /// <summary>
        /// HELLENICPOST.
        /// </summary>
        [EnumMember(Value = "HELLENIC_POST")]
        HELLENICPOST,

        /// <summary>
        /// HSMGLOBAL.
        /// </summary>
        [EnumMember(Value = "HSM_GLOBAL")]
        HSMGLOBAL,

        /// <summary>
        /// MNX.
        /// </summary>
        [EnumMember(Value = "MNX")]
        MNX,

        /// <summary>
        /// NMTRANSFER.
        /// </summary>
        [EnumMember(Value = "NMTRANSFER")]
        NMTRANSFER,

        /// <summary>
        /// LOGYSTO.
        /// </summary>
        [EnumMember(Value = "LOGYSTO")]
        LOGYSTO,

        /// <summary>
        /// INDIAPOSTINT.
        /// </summary>
        [EnumMember(Value = "INDIA_POST_INT")]
        INDIAPOSTINT,

        /// <summary>
        /// AMAZONFBASWISHIPIN.
        /// </summary>
        [EnumMember(Value = "AMAZON_FBA_SWISHIP_IN")]
        AMAZONFBASWISHIPIN,

        /// <summary>
        /// SRTTRANSPORT.
        /// </summary>
        [EnumMember(Value = "SRT_TRANSPORT")]
        SRTTRANSPORT,

        /// <summary>
        /// BOMI.
        /// </summary>
        [EnumMember(Value = "BOMI")]
        BOMI,

        /// <summary>
        /// DELIVERRSFTP.
        /// </summary>
        [EnumMember(Value = "DELIVERR_SFTP")]
        DELIVERRSFTP,

        /// <summary>
        /// HSDEXPRESS.
        /// </summary>
        [EnumMember(Value = "HSDEXPRESS")]
        HSDEXPRESS,

        /// <summary>
        /// SIMPLETIREWEBHOOK.
        /// </summary>
        [EnumMember(Value = "SIMPLETIRE_WEBHOOK")]
        SIMPLETIREWEBHOOK,

        /// <summary>
        /// HUNTEREXPRESSSFTP.
        /// </summary>
        [EnumMember(Value = "HUNTER_EXPRESS_SFTP")]
        HUNTEREXPRESSSFTP,

        /// <summary>
        /// UPSAPI.
        /// </summary>
        [EnumMember(Value = "UPS_API")]
        UPSAPI,

        /// <summary>
        /// WOOYOUNGLOGISTICSSFTP.
        /// </summary>
        [EnumMember(Value = "WOOYOUNG_LOGISTICS_SFTP")]
        WOOYOUNGLOGISTICSSFTP,

        /// <summary>
        /// PHSEAPI.
        /// </summary>
        [EnumMember(Value = "PHSE_API")]
        PHSEAPI,

        /// <summary>
        /// WISHEMAILPUSH.
        /// </summary>
        [EnumMember(Value = "WISH_EMAIL_PUSH")]
        WISHEMAILPUSH,

        /// <summary>
        /// NORTHLINE.
        /// </summary>
        [EnumMember(Value = "NORTHLINE")]
        NORTHLINE,

        /// <summary>
        /// MEDAFRICA.
        /// </summary>
        [EnumMember(Value = "MEDAFRICA")]
        MEDAFRICA,

        /// <summary>
        /// DPDATSFTP.
        /// </summary>
        [EnumMember(Value = "DPD_AT_SFTP")]
        DPDATSFTP,

        /// <summary>
        /// ANTERAJA.
        /// </summary>
        [EnumMember(Value = "ANTERAJA")]
        ANTERAJA,

        /// <summary>
        /// DHLGLOBALFORWARDINGAPI.
        /// </summary>
        [EnumMember(Value = "DHL_GLOBAL_FORWARDING_API")]
        DHLGLOBALFORWARDINGAPI,

        /// <summary>
        /// LBCEXPRESSAPI.
        /// </summary>
        [EnumMember(Value = "LBCEXPRESS_API")]
        LBCEXPRESSAPI,

        /// <summary>
        /// SIMSGLOBAL.
        /// </summary>
        [EnumMember(Value = "SIMSGLOBAL")]
        SIMSGLOBAL,

        /// <summary>
        /// CDLDELIVERS.
        /// </summary>
        [EnumMember(Value = "CDLDELIVERS")]
        CDLDELIVERS,

        /// <summary>
        /// TYP.
        /// </summary>
        [EnumMember(Value = "TYP")]
        TYP,

        /// <summary>
        /// TESTINGCOURIERWEBHOOK.
        /// </summary>
        [EnumMember(Value = "TESTING_COURIER_WEBHOOK")]
        TESTINGCOURIERWEBHOOK,

        /// <summary>
        /// PANDAGOAPI.
        /// </summary>
        [EnumMember(Value = "PANDAGO_API")]
        PANDAGOAPI,

        /// <summary>
        /// ROYALMAILFTP.
        /// </summary>
        [EnumMember(Value = "ROYAL_MAIL_FTP")]
        ROYALMAILFTP,

        /// <summary>
        /// THUNDEREXPRESS.
        /// </summary>
        [EnumMember(Value = "THUNDEREXPRESS")]
        THUNDEREXPRESS,

        /// <summary>
        /// SECRETLABWEBHOOK.
        /// </summary>
        [EnumMember(Value = "SECRETLAB_WEBHOOK")]
        SECRETLABWEBHOOK,

        /// <summary>
        /// SETEL.
        /// </summary>
        [EnumMember(Value = "SETEL")]
        SETEL,

        /// <summary>
        /// JDWORLDWIDE.
        /// </summary>
        [EnumMember(Value = "JD_WORLDWIDE")]
        JDWORLDWIDE,

        /// <summary>
        /// DPDRUAPI.
        /// </summary>
        [EnumMember(Value = "DPD_RU_API")]
        DPDRUAPI,

        /// <summary>
        /// ARGENTSWEBHOOK.
        /// </summary>
        [EnumMember(Value = "ARGENTS_WEBHOOK")]
        ARGENTSWEBHOOK,

        /// <summary>
        /// POSTONE.
        /// </summary>
        [EnumMember(Value = "POSTONE")]
        POSTONE,

        /// <summary>
        /// TUSKLOGISTICS.
        /// </summary>
        [EnumMember(Value = "TUSKLOGISTICS")]
        TUSKLOGISTICS,

        /// <summary>
        /// RHENUSUKAPI.
        /// </summary>
        [EnumMember(Value = "RHENUS_UK_API")]
        RHENUSUKAPI,

        /// <summary>
        /// TAQBINSGAPI.
        /// </summary>
        [EnumMember(Value = "TAQBIN_SG_API")]
        TAQBINSGAPI,

        /// <summary>
        /// INNTRALOGSFTP.
        /// </summary>
        [EnumMember(Value = "INNTRALOG_SFTP")]
        INNTRALOGSFTP,

        /// <summary>
        /// DAYROSS.
        /// </summary>
        [EnumMember(Value = "DAYROSS")]
        DAYROSS,

        /// <summary>
        /// CORREOSEXPRESSAPI.
        /// </summary>
        [EnumMember(Value = "CORREOSEXPRESS_API")]
        CORREOSEXPRESSAPI,

        /// <summary>
        /// INTERNATIONALSEURAPI.
        /// </summary>
        [EnumMember(Value = "INTERNATIONAL_SEUR_API")]
        INTERNATIONALSEURAPI,

        /// <summary>
        /// YODELAPI.
        /// </summary>
        [EnumMember(Value = "YODEL_API")]
        YODELAPI,

        /// <summary>
        /// HEROEXPRESS.
        /// </summary>
        [EnumMember(Value = "HEROEXPRESS")]
        HEROEXPRESS,

        /// <summary>
        /// DHLSUPPLYCHAININ.
        /// </summary>
        [EnumMember(Value = "DHL_SUPPLYCHAIN_IN")]
        DHLSUPPLYCHAININ,

        /// <summary>
        /// URGENTCARGUS.
        /// </summary>
        [EnumMember(Value = "URGENT_CARGUS")]
        URGENTCARGUS,

        /// <summary>
        /// FRONTDOORCORP.
        /// </summary>
        [EnumMember(Value = "FRONTDOORCORP")]
        FRONTDOORCORP,

        /// <summary>
        /// JTEXPRESSPH.
        /// </summary>
        [EnumMember(Value = "JTEXPRESS_PH")]
        JTEXPRESSPH,

        /// <summary>
        /// PARCELSTARSWEBHOOK.
        /// </summary>
        [EnumMember(Value = "PARCELSTARS_WEBHOOK")]
        PARCELSTARSWEBHOOK,

        /// <summary>
        /// DPDSKSFTP.
        /// </summary>
        [EnumMember(Value = "DPD_SK_SFTP")]
        DPDSKSFTP,

        /// <summary>
        /// MOVIANTO.
        /// </summary>
        [EnumMember(Value = "MOVIANTO")]
        MOVIANTO,

        /// <summary>
        /// OZEPARTSSHIPPING.
        /// </summary>
        [EnumMember(Value = "OZEPARTS_SHIPPING")]
        OZEPARTSSHIPPING,

        /// <summary>
        /// KARGOMKOLAY.
        /// </summary>
        [EnumMember(Value = "KARGOMKOLAY")]
        KARGOMKOLAY,

        /// <summary>
        /// TRUNKRS.
        /// </summary>
        [EnumMember(Value = "TRUNKRS")]
        TRUNKRS,

        /// <summary>
        /// OMNIRPSWEBHOOK.
        /// </summary>
        [EnumMember(Value = "OMNIRPS_WEBHOOK")]
        OMNIRPSWEBHOOK,

        /// <summary>
        /// CHILEXPRESS.
        /// </summary>
        [EnumMember(Value = "CHILEXPRESS")]
        CHILEXPRESS,

        /// <summary>
        /// TESTINGCOURIER.
        /// </summary>
        [EnumMember(Value = "TESTING_COURIER")]
        TESTINGCOURIER,

        /// <summary>
        /// JNEAPI.
        /// </summary>
        [EnumMember(Value = "JNE_API")]
        JNEAPI,

        /// <summary>
        /// BJSHOMEDELIVERYFTP.
        /// </summary>
        [EnumMember(Value = "BJSHOMEDELIVERY_FTP")]
        BJSHOMEDELIVERYFTP,

        /// <summary>
        /// DEXPRESSWEBHOOK.
        /// </summary>
        [EnumMember(Value = "DEXPRESS_WEBHOOK")]
        DEXPRESSWEBHOOK,

        /// <summary>
        /// USPSAPI.
        /// </summary>
        [EnumMember(Value = "USPS_API")]
        USPSAPI,

        /// <summary>
        /// TRANSVIRTUAL.
        /// </summary>
        [EnumMember(Value = "TRANSVIRTUAL")]
        TRANSVIRTUAL,

        /// <summary>
        /// SOLISTICAAPI.
        /// </summary>
        [EnumMember(Value = "SOLISTICA_API")]
        SOLISTICAAPI,

        /// <summary>
        /// CHIENVENTUREWEBHOOK.
        /// </summary>
        [EnumMember(Value = "CHIENVENTURE_WEBHOOK")]
        CHIENVENTUREWEBHOOK,

        /// <summary>
        /// DPDUKSFTP.
        /// </summary>
        [EnumMember(Value = "DPD_UK_SFTP")]
        DPDUKSFTP,

        /// <summary>
        /// INPOSTUK.
        /// </summary>
        [EnumMember(Value = "INPOST_UK")]
        INPOSTUK,

        /// <summary>
        /// JAVIT.
        /// </summary>
        [EnumMember(Value = "JAVIT")]
        JAVIT,

        /// <summary>
        /// ZTODOMESTIC.
        /// </summary>
        [EnumMember(Value = "ZTO_DOMESTIC")]
        ZTODOMESTIC,

        /// <summary>
        /// DHLGTAPI.
        /// </summary>
        [EnumMember(Value = "DHL_GT_API")]
        DHLGTAPI,

        /// <summary>
        /// CEVATRACKING.
        /// </summary>
        [EnumMember(Value = "CEVA_TRACKING")]
        CEVATRACKING,

        /// <summary>
        /// KOMONEXPRESS.
        /// </summary>
        [EnumMember(Value = "KOMON_EXPRESS")]
        KOMONEXPRESS,

        /// <summary>
        /// EASTWESTCOURIERFTP.
        /// </summary>
        [EnumMember(Value = "EASTWESTCOURIER_FTP")]
        EASTWESTCOURIERFTP,

        /// <summary>
        /// DANNIAO.
        /// </summary>
        [EnumMember(Value = "DANNIAO")]
        DANNIAO,

        /// <summary>
        /// SPECTRAN.
        /// </summary>
        [EnumMember(Value = "SPECTRAN")]
        SPECTRAN,

        /// <summary>
        /// DELIVERIT.
        /// </summary>
        [EnumMember(Value = "DELIVER_IT")]
        DELIVERIT,

        /// <summary>
        /// RELAISCOLIS.
        /// </summary>
        [EnumMember(Value = "RELAISCOLIS")]
        RELAISCOLIS,

        /// <summary>
        /// GLSSPAINAPI.
        /// </summary>
        [EnumMember(Value = "GLS_SPAIN_API")]
        GLSSPAINAPI,

        /// <summary>
        /// POSTPLUS.
        /// </summary>
        [EnumMember(Value = "POSTPLUS")]
        POSTPLUS,

        /// <summary>
        /// AIRTERRA.
        /// </summary>
        [EnumMember(Value = "AIRTERRA")]
        AIRTERRA,

        /// <summary>
        /// GIOECOURIERAPI.
        /// </summary>
        [EnumMember(Value = "GIO_ECOURIER_API")]
        GIOECOURIERAPI,

        /// <summary>
        /// DPDCHSFTP.
        /// </summary>
        [EnumMember(Value = "DPD_CH_SFTP")]
        DPDCHSFTP,

        /// <summary>
        /// FEDEXAPI.
        /// </summary>
        [EnumMember(Value = "FEDEX_API")]
        FEDEXAPI,

        /// <summary>
        /// INTERSMARTTRANS.
        /// </summary>
        [EnumMember(Value = "INTERSMARTTRANS")]
        INTERSMARTTRANS,

        /// <summary>
        /// HERMESUKSFTP.
        /// </summary>
        [EnumMember(Value = "HERMES_UK_SFTP")]
        HERMESUKSFTP,

        /// <summary>
        /// EXELOTFTP.
        /// </summary>
        [EnumMember(Value = "EXELOT_FTP")]
        EXELOTFTP,

        /// <summary>
        /// DHLPAAPI.
        /// </summary>
        [EnumMember(Value = "DHL_PA_API")]
        DHLPAAPI,

        /// <summary>
        /// VIRTRANSPORTSFTP.
        /// </summary>
        [EnumMember(Value = "VIRTRANSPORT_SFTP")]
        VIRTRANSPORTSFTP,

        /// <summary>
        /// WORLDNET.
        /// </summary>
        [EnumMember(Value = "WORLDNET")]
        WORLDNET,

        /// <summary>
        /// INSTABOXWEBHOOK.
        /// </summary>
        [EnumMember(Value = "INSTABOX_WEBHOOK")]
        INSTABOXWEBHOOK,

        /// <summary>
        /// KNG.
        /// </summary>
        [EnumMember(Value = "KNG")]
        KNG,

        /// <summary>
        /// FLASHEXPRESSWEBHOOK.
        /// </summary>
        [EnumMember(Value = "FLASHEXPRESS_WEBHOOK")]
        FLASHEXPRESSWEBHOOK,

        /// <summary>
        /// MAGYARPOSTAAPI.
        /// </summary>
        [EnumMember(Value = "MAGYAR_POSTA_API")]
        MAGYARPOSTAAPI,

        /// <summary>
        /// WESHIPAPI.
        /// </summary>
        [EnumMember(Value = "WESHIP_API")]
        WESHIPAPI,

        /// <summary>
        /// OHIWEBHOOK.
        /// </summary>
        [EnumMember(Value = "OHI_WEBHOOK")]
        OHIWEBHOOK,

        /// <summary>
        /// MUDITA.
        /// </summary>
        [EnumMember(Value = "MUDITA")]
        MUDITA,

        /// <summary>
        /// BLUEDARTAPI.
        /// </summary>
        [EnumMember(Value = "BLUEDART_API")]
        BLUEDARTAPI,

        /// <summary>
        /// TCATAPI.
        /// </summary>
        [EnumMember(Value = "T_CAT_API")]
        TCATAPI,

        /// <summary>
        /// ADS.
        /// </summary>
        [EnumMember(Value = "ADS")]
        ADS,

        /// <summary>
        /// HERMESIT.
        /// </summary>
        [EnumMember(Value = "HERMES_IT")]
        HERMESIT,

        /// <summary>
        /// FITZMARKAPI.
        /// </summary>
        [EnumMember(Value = "FITZMARK_API")]
        FITZMARKAPI,

        /// <summary>
        /// POSTIAPI.
        /// </summary>
        [EnumMember(Value = "POSTI_API")]
        POSTIAPI,

        /// <summary>
        /// SMSAEXPRESSWEBHOOK.
        /// </summary>
        [EnumMember(Value = "SMSA_EXPRESS_WEBHOOK")]
        SMSAEXPRESSWEBHOOK,

        /// <summary>
        /// TAMERGROUPWEBHOOK.
        /// </summary>
        [EnumMember(Value = "TAMERGROUP_WEBHOOK")]
        TAMERGROUPWEBHOOK,

        /// <summary>
        /// LIVRAPIDE.
        /// </summary>
        [EnumMember(Value = "LIVRAPIDE")]
        LIVRAPIDE,

        /// <summary>
        /// NIPPONEXPRESS.
        /// </summary>
        [EnumMember(Value = "NIPPON_EXPRESS")]
        NIPPONEXPRESS,

        /// <summary>
        /// BETTERTRUCKS.
        /// </summary>
        [EnumMember(Value = "BETTERTRUCKS")]
        BETTERTRUCKS,

        /// <summary>
        /// FAN.
        /// </summary>
        [EnumMember(Value = "FAN")]
        FAN,

        /// <summary>
        /// PBUSPSFLATSFTP.
        /// </summary>
        [EnumMember(Value = "PB_USPSFLATS_FTP")]
        PBUSPSFLATSFTP,

        /// <summary>
        /// PARCELRIGHT.
        /// </summary>
        [EnumMember(Value = "PARCELRIGHT")]
        PARCELRIGHT,

        /// <summary>
        /// ITHINKLOGISTICS.
        /// </summary>
        [EnumMember(Value = "ITHINKLOGISTICS")]
        ITHINKLOGISTICS,

        /// <summary>
        /// KERRYEXPRESSTHWEBHOOK.
        /// </summary>
        [EnumMember(Value = "KERRY_EXPRESS_TH_WEBHOOK")]
        KERRYEXPRESSTHWEBHOOK,

        /// <summary>
        /// ECOUTIER.
        /// </summary>
        [EnumMember(Value = "ECOUTIER")]
        ECOUTIER,

        /// <summary>
        /// SHOWL.
        /// </summary>
        [EnumMember(Value = "SHOWL")]
        SHOWL,

        /// <summary>
        /// BRTITAPI.
        /// </summary>
        [EnumMember(Value = "BRT_IT_API")]
        BRTITAPI,

        /// <summary>
        /// RIXONHKAPI.
        /// </summary>
        [EnumMember(Value = "RIXONHK_API")]
        RIXONHKAPI,

        /// <summary>
        /// DBSCHENKERAPI.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_API")]
        DBSCHENKERAPI,

        /// <summary>
        /// ILYANGLOGIS.
        /// </summary>
        [EnumMember(Value = "ILYANGLOGIS")]
        ILYANGLOGIS,

        /// <summary>
        /// MAILBOXETC.
        /// </summary>
        [EnumMember(Value = "MAIL_BOX_ETC")]
        MAILBOXETC,

        /// <summary>
        /// WESHIP.
        /// </summary>
        [EnumMember(Value = "WESHIP")]
        WESHIP,

        /// <summary>
        /// DHLGLOBALMAILAPI.
        /// </summary>
        [EnumMember(Value = "DHL_GLOBAL_MAIL_API")]
        DHLGLOBALMAILAPI,

        /// <summary>
        /// ACTIVOS24API.
        /// </summary>
        [EnumMember(Value = "ACTIVOS24_API")]
        ACTIVOS24API,

        /// <summary>
        /// ATSHEALTHCARE.
        /// </summary>
        [EnumMember(Value = "ATSHEALTHCARE")]
        ATSHEALTHCARE,

        /// <summary>
        /// LUWJISTIK.
        /// </summary>
        [EnumMember(Value = "LUWJISTIK")]
        LUWJISTIK,

        /// <summary>
        /// GWWORLD.
        /// </summary>
        [EnumMember(Value = "GW_WORLD")]
        GWWORLD,

        /// <summary>
        /// FAIRSENDENAPI.
        /// </summary>
        [EnumMember(Value = "FAIRSENDEN_API")]
        FAIRSENDENAPI,

        /// <summary>
        /// SERVIPWEBHOOK.
        /// </summary>
        [EnumMember(Value = "SERVIP_WEBHOOK")]
        SERVIPWEBHOOK,

        /// <summary>
        /// SWISHIP.
        /// </summary>
        [EnumMember(Value = "SWISHIP")]
        SWISHIP,

        /// <summary>
        /// TANET.
        /// </summary>
        [EnumMember(Value = "TANET")]
        TANET,

        /// <summary>
        /// HOTSINCARGO.
        /// </summary>
        [EnumMember(Value = "HOTSIN_CARGO")]
        HOTSINCARGO,

        /// <summary>
        /// DIREX.
        /// </summary>
        [EnumMember(Value = "DIREX")]
        DIREX,

        /// <summary>
        /// HUANTONG.
        /// </summary>
        [EnumMember(Value = "HUANTONG")]
        HUANTONG,

        /// <summary>
        /// IMILEAPI.
        /// </summary>
        [EnumMember(Value = "IMILE_API")]
        IMILEAPI,

        /// <summary>
        /// BDMNET.
        /// </summary>
        [EnumMember(Value = "BDMNET")]
        BDMNET,

        /// <summary>
        /// AUEXPRESS.
        /// </summary>
        [EnumMember(Value = "AUEXPRESS")]
        AUEXPRESS,

        /// <summary>
        /// NYTLOGISTICS.
        /// </summary>
        [EnumMember(Value = "NYTLOGISTICS")]
        NYTLOGISTICS,

        /// <summary>
        /// DSVREFERENCE.
        /// </summary>
        [EnumMember(Value = "DSV_REFERENCE")]
        DSVREFERENCE,

        /// <summary>
        /// NOVOFARMAWEBHOOK.
        /// </summary>
        [EnumMember(Value = "NOVOFARMA_WEBHOOK")]
        NOVOFARMAWEBHOOK,

        /// <summary>
        /// AITWORLDWIDESFTP.
        /// </summary>
        [EnumMember(Value = "AITWORLDWIDE_SFTP")]
        AITWORLDWIDESFTP,

        /// <summary>
        /// SHOPOLIVE.
        /// </summary>
        [EnumMember(Value = "SHOPOLIVE")]
        SHOPOLIVE,

        /// <summary>
        /// FNFZA.
        /// </summary>
        [EnumMember(Value = "FNF_ZA")]
        FNFZA,

        /// <summary>
        /// DHLECOMMERCEGC.
        /// </summary>
        [EnumMember(Value = "DHL_ECOMMERCE_GC")]
        DHLECOMMERCEGC,

        /// <summary>
        /// FETCHR.
        /// </summary>
        [EnumMember(Value = "FETCHR")]
        FETCHR,

        /// <summary>
        /// STARLINKSAPI.
        /// </summary>
        [EnumMember(Value = "STARLINKS_API")]
        STARLINKSAPI,

        /// <summary>
        /// YYEXPRESS.
        /// </summary>
        [EnumMember(Value = "YYEXPRESS")]
        YYEXPRESS,

        /// <summary>
        /// SERVIENTREGA.
        /// </summary>
        [EnumMember(Value = "SERVIENTREGA")]
        SERVIENTREGA,

        /// <summary>
        /// HANJIN.
        /// </summary>
        [EnumMember(Value = "HANJIN")]
        HANJIN,

        /// <summary>
        /// SPANISHSEURFTP.
        /// </summary>
        [EnumMember(Value = "SPANISH_SEUR_FTP")]
        SPANISHSEURFTP,

        /// <summary>
        /// DXB2BCONNUM.
        /// </summary>
        [EnumMember(Value = "DX_B2B_CONNUM")]
        DXB2BCONNUM,

        /// <summary>
        /// HELTHJEMAPI.
        /// </summary>
        [EnumMember(Value = "HELTHJEM_API")]
        HELTHJEMAPI,

        /// <summary>
        /// INEXPOST.
        /// </summary>
        [EnumMember(Value = "INEXPOST")]
        INEXPOST,

        /// <summary>
        /// A2BBA.
        /// </summary>
        [EnumMember(Value = "A2B_BA")]
        A2BBA,

        /// <summary>
        /// RHENUSGROUP.
        /// </summary>
        [EnumMember(Value = "RHENUS_GROUP")]
        RHENUSGROUP,

        /// <summary>
        /// SBERLOGISTICSRU.
        /// </summary>
        [EnumMember(Value = "SBERLOGISTICS_RU")]
        SBERLOGISTICSRU,

        /// <summary>
        /// MALCAAMIT.
        /// </summary>
        [EnumMember(Value = "MALCA_AMIT")]
        MALCAAMIT,

        /// <summary>
        /// PPL.
        /// </summary>
        [EnumMember(Value = "PPL")]
        PPL,

        /// <summary>
        /// OSMWORLDWIDESFTP.
        /// </summary>
        [EnumMember(Value = "OSM_WORLDWIDE_SFTP")]
        OSMWORLDWIDESFTP,

        /// <summary>
        /// ACILOGISTIX.
        /// </summary>
        [EnumMember(Value = "ACILOGISTIX")]
        ACILOGISTIX,

        /// <summary>
        /// OPTIMACOURIER.
        /// </summary>
        [EnumMember(Value = "OPTIMACOURIER")]
        OPTIMACOURIER,

        /// <summary>
        /// NOVAPOSHTAAPI.
        /// </summary>
        [EnumMember(Value = "NOVA_POSHTA_API")]
        NOVAPOSHTAAPI,

        /// <summary>
        /// LOGGI.
        /// </summary>
        [EnumMember(Value = "LOGGI")]
        LOGGI,

        /// <summary>
        /// YIFAN.
        /// </summary>
        [EnumMember(Value = "YIFAN")]
        YIFAN,

        /// <summary>
        /// MYDYNALOGIC.
        /// </summary>
        [EnumMember(Value = "MYDYNALOGIC")]
        MYDYNALOGIC,

        /// <summary>
        /// MORNINGLOBAL.
        /// </summary>
        [EnumMember(Value = "MORNINGLOBAL")]
        MORNINGLOBAL,

        /// <summary>
        /// CONCISEAPI.
        /// </summary>
        [EnumMember(Value = "CONCISE_API")]
        CONCISEAPI,

        /// <summary>
        /// FXTRAN.
        /// </summary>
        [EnumMember(Value = "FXTRAN")]
        FXTRAN,

        /// <summary>
        /// DELIVERYOURPARCELZA.
        /// </summary>
        [EnumMember(Value = "DELIVERYOURPARCEL_ZA")]
        DELIVERYOURPARCELZA,

        /// <summary>
        /// UPARCEL.
        /// </summary>
        [EnumMember(Value = "UPARCEL")]
        UPARCEL,

        /// <summary>
        /// MOBIBR.
        /// </summary>
        [EnumMember(Value = "MOBI_BR")]
        MOBIBR,

        /// <summary>
        /// LOGINEXTWEBHOOK.
        /// </summary>
        [EnumMember(Value = "LOGINEXT_WEBHOOK")]
        LOGINEXTWEBHOOK,

        /// <summary>
        /// EMS.
        /// </summary>
        [EnumMember(Value = "EMS")]
        EMS,

        /// <summary>
        /// SPEEDY.
        /// </summary>
        [EnumMember(Value = "SPEEDY")]
        SPEEDY,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}