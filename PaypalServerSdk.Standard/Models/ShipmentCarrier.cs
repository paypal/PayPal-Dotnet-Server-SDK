// <copyright file="ShipmentCarrier.cs" company="APIMatic">
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
    /// ShipmentCarrier.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum ShipmentCarrier
    {
        /// <summary>
        /// DpdRu.
        /// </summary>
        [EnumMember(Value = "DPD_RU")]
        DpdRu,

        /// <summary>
        /// BgBulgarianPost.
        /// </summary>
        [EnumMember(Value = "BG_BULGARIAN_POST")]
        BgBulgarianPost,

        /// <summary>
        /// KrKoreaPost.
        /// </summary>
        [EnumMember(Value = "KR_KOREA_POST")]
        KrKoreaPost,

        /// <summary>
        /// ZaCourierit.
        /// </summary>
        [EnumMember(Value = "ZA_COURIERIT")]
        ZaCourierit,

        /// <summary>
        /// FrExapaq.
        /// </summary>
        [EnumMember(Value = "FR_EXAPAQ")]
        FrExapaq,

        /// <summary>
        /// AreEmiratesPost.
        /// </summary>
        [EnumMember(Value = "ARE_EMIRATES_POST")]
        AreEmiratesPost,

        /// <summary>
        /// Gac.
        /// </summary>
        [EnumMember(Value = "GAC")]
        Gac,

        /// <summary>
        /// Geis.
        /// </summary>
        [EnumMember(Value = "GEIS")]
        Geis,

        /// <summary>
        /// SfEx.
        /// </summary>
        [EnumMember(Value = "SF_EX")]
        SfEx,

        /// <summary>
        /// Pago.
        /// </summary>
        [EnumMember(Value = "PAGO")]
        Pago,

        /// <summary>
        /// Myhermes.
        /// </summary>
        [EnumMember(Value = "MYHERMES")]
        Myhermes,

        /// <summary>
        /// DiamondEurogistics.
        /// </summary>
        [EnumMember(Value = "DIAMOND_EUROGISTICS")]
        DiamondEurogistics,

        /// <summary>
        /// CorporatecouriersWebhook.
        /// </summary>
        [EnumMember(Value = "CORPORATECOURIERS_WEBHOOK")]
        CorporatecouriersWebhook,

        /// <summary>
        /// Bond.
        /// </summary>
        [EnumMember(Value = "BOND")]
        Bond,

        /// <summary>
        /// Omniparcel.
        /// </summary>
        [EnumMember(Value = "OMNIPARCEL")]
        Omniparcel,

        /// <summary>
        /// SkPosta.
        /// </summary>
        [EnumMember(Value = "SK_POSTA")]
        SkPosta,

        /// <summary>
        /// Purolator.
        /// </summary>
        [EnumMember(Value = "PUROLATOR")]
        Purolator,

        /// <summary>
        /// FetchrWebhook.
        /// </summary>
        [EnumMember(Value = "FETCHR_WEBHOOK")]
        FetchrWebhook,

        /// <summary>
        /// Thedeliverygroup.
        /// </summary>
        [EnumMember(Value = "THEDELIVERYGROUP")]
        Thedeliverygroup,

        /// <summary>
        /// CelloSquare.
        /// </summary>
        [EnumMember(Value = "CELLO_SQUARE")]
        CelloSquare,

        /// <summary>
        /// Tarrive.
        /// </summary>
        [EnumMember(Value = "TARRIVE")]
        Tarrive,

        /// <summary>
        /// Collivery.
        /// </summary>
        [EnumMember(Value = "COLLIVERY")]
        Collivery,

        /// <summary>
        /// Mainfreight.
        /// </summary>
        [EnumMember(Value = "MAINFREIGHT")]
        Mainfreight,

        /// <summary>
        /// IndFirstflight.
        /// </summary>
        [EnumMember(Value = "IND_FIRSTFLIGHT")]
        IndFirstflight,

        /// <summary>
        /// Acsworldwide.
        /// </summary>
        [EnumMember(Value = "ACSWORLDWIDE")]
        Acsworldwide,

        /// <summary>
        /// Amstan.
        /// </summary>
        [EnumMember(Value = "AMSTAN")]
        Amstan,

        /// <summary>
        /// Okayparcel.
        /// </summary>
        [EnumMember(Value = "OKAYPARCEL")]
        Okayparcel,

        /// <summary>
        /// EnvialiaReference.
        /// </summary>
        [EnumMember(Value = "ENVIALIA_REFERENCE")]
        EnvialiaReference,

        /// <summary>
        /// SeurEs.
        /// </summary>
        [EnumMember(Value = "SEUR_ES")]
        SeurEs,

        /// <summary>
        /// Continental.
        /// </summary>
        [EnumMember(Value = "CONTINENTAL")]
        Continental,

        /// <summary>
        /// Fdsexpress.
        /// </summary>
        [EnumMember(Value = "FDSEXPRESS")]
        Fdsexpress,

        /// <summary>
        /// AmazonFbaSwiship.
        /// </summary>
        [EnumMember(Value = "AMAZON_FBA_SWISHIP")]
        AmazonFbaSwiship,

        /// <summary>
        /// Wyngs.
        /// </summary>
        [EnumMember(Value = "WYNGS")]
        Wyngs,

        /// <summary>
        /// DhlActiveTracing.
        /// </summary>
        [EnumMember(Value = "DHL_ACTIVE_TRACING")]
        DhlActiveTracing,

        /// <summary>
        /// Zyllem.
        /// </summary>
        [EnumMember(Value = "ZYLLEM")]
        Zyllem,

        /// <summary>
        /// Ruston.
        /// </summary>
        [EnumMember(Value = "RUSTON")]
        Ruston,

        /// <summary>
        /// Xpost.
        /// </summary>
        [EnumMember(Value = "XPOST")]
        Xpost,

        /// <summary>
        /// CorreosEs.
        /// </summary>
        [EnumMember(Value = "CORREOS_ES")]
        CorreosEs,

        /// <summary>
        /// DhlFr.
        /// </summary>
        [EnumMember(Value = "DHL_FR")]
        DhlFr,

        /// <summary>
        /// PanAsia.
        /// </summary>
        [EnumMember(Value = "PAN_ASIA")]
        PanAsia,

        /// <summary>
        /// BrtIt.
        /// </summary>
        [EnumMember(Value = "BRT_IT")]
        BrtIt,

        /// <summary>
        /// SreKorea.
        /// </summary>
        [EnumMember(Value = "SRE_KOREA")]
        SreKorea,

        /// <summary>
        /// Speedee.
        /// </summary>
        [EnumMember(Value = "SPEEDEE")]
        Speedee,

        /// <summary>
        /// TntUk.
        /// </summary>
        [EnumMember(Value = "TNT_UK")]
        TntUk,

        /// <summary>
        /// Venipak.
        /// </summary>
        [EnumMember(Value = "VENIPAK")]
        Venipak,

        /// <summary>
        /// Shreenandancourier.
        /// </summary>
        [EnumMember(Value = "SHREENANDANCOURIER")]
        Shreenandancourier,

        /// <summary>
        /// Croshot.
        /// </summary>
        [EnumMember(Value = "CROSHOT")]
        Croshot,

        /// <summary>
        /// NipostNg.
        /// </summary>
        [EnumMember(Value = "NIPOST_NG")]
        NipostNg,

        /// <summary>
        /// EpstGlbl.
        /// </summary>
        [EnumMember(Value = "EPST_GLBL")]
        EpstGlbl,

        /// <summary>
        /// Newgistics.
        /// </summary>
        [EnumMember(Value = "NEWGISTICS")]
        Newgistics,

        /// <summary>
        /// PostSlovenia.
        /// </summary>
        [EnumMember(Value = "POST_SLOVENIA")]
        PostSlovenia,

        /// <summary>
        /// JerseyPost.
        /// </summary>
        [EnumMember(Value = "JERSEY_POST")]
        JerseyPost,

        /// <summary>
        /// Bombinoexp.
        /// </summary>
        [EnumMember(Value = "BOMBINOEXP")]
        Bombinoexp,

        /// <summary>
        /// Wmg.
        /// </summary>
        [EnumMember(Value = "WMG")]
        Wmg,

        /// <summary>
        /// XqExpress.
        /// </summary>
        [EnumMember(Value = "XQ_EXPRESS")]
        XqExpress,

        /// <summary>
        /// Furdeco.
        /// </summary>
        [EnumMember(Value = "FURDECO")]
        Furdeco,

        /// <summary>
        /// LhtExpress.
        /// </summary>
        [EnumMember(Value = "LHT_EXPRESS")]
        LhtExpress,

        /// <summary>
        /// SouthAfricanPostOffice.
        /// </summary>
        [EnumMember(Value = "SOUTH_AFRICAN_POST_OFFICE")]
        SouthAfricanPostOffice,

        /// <summary>
        /// Spoton.
        /// </summary>
        [EnumMember(Value = "SPOTON")]
        Spoton,

        /// <summary>
        /// Dimerco.
        /// </summary>
        [EnumMember(Value = "DIMERCO")]
        Dimerco,

        /// <summary>
        /// CyprusPostCyp.
        /// </summary>
        [EnumMember(Value = "CYPRUS_POST_CYP")]
        CyprusPostCyp,

        /// <summary>
        /// Abcustom.
        /// </summary>
        [EnumMember(Value = "ABCUSTOM")]
        Abcustom,

        /// <summary>
        /// IndDelivree.
        /// </summary>
        [EnumMember(Value = "IND_DELIVREE")]
        IndDelivree,

        /// <summary>
        /// CnBestexpress.
        /// </summary>
        [EnumMember(Value = "CN_BESTEXPRESS")]
        CnBestexpress,

        /// <summary>
        /// DxSftp.
        /// </summary>
        [EnumMember(Value = "DX_SFTP")]
        DxSftp,

        /// <summary>
        /// PickuppMys.
        /// </summary>
        [EnumMember(Value = "PICKUPP_MYS")]
        PickuppMys,

        /// <summary>
        /// Fmx.
        /// </summary>
        [EnumMember(Value = "FMX")]
        Fmx,

        /// <summary>
        /// Hellmann.
        /// </summary>
        [EnumMember(Value = "HELLMANN")]
        Hellmann,

        /// <summary>
        /// ShipItAsia.
        /// </summary>
        [EnumMember(Value = "SHIP_IT_ASIA")]
        ShipItAsia,

        /// <summary>
        /// KerryEcommerce.
        /// </summary>
        [EnumMember(Value = "KERRY_ECOMMERCE")]
        KerryEcommerce,

        /// <summary>
        /// Freterapido.
        /// </summary>
        [EnumMember(Value = "FRETERAPIDO")]
        Freterapido,

        /// <summary>
        /// PitneyBowes.
        /// </summary>
        [EnumMember(Value = "PITNEY_BOWES")]
        PitneyBowes,

        /// <summary>
        /// XpressenDk.
        /// </summary>
        [EnumMember(Value = "XPRESSEN_DK")]
        XpressenDk,

        /// <summary>
        /// SeurSpApi.
        /// </summary>
        [EnumMember(Value = "SEUR_SP_API")]
        SeurSpApi,

        /// <summary>
        /// Deliveryontime.
        /// </summary>
        [EnumMember(Value = "DELIVERYONTIME")]
        Deliveryontime,

        /// <summary>
        /// Jinsung.
        /// </summary>
        [EnumMember(Value = "JINSUNG")]
        Jinsung,

        /// <summary>
        /// TransKargo.
        /// </summary>
        [EnumMember(Value = "TRANS_KARGO")]
        TransKargo,

        /// <summary>
        /// SwishipDe.
        /// </summary>
        [EnumMember(Value = "SWISHIP_DE")]
        SwishipDe,

        /// <summary>
        /// IvoyWebhook.
        /// </summary>
        [EnumMember(Value = "IVOY_WEBHOOK")]
        IvoyWebhook,

        /// <summary>
        /// AirmeeWebhook.
        /// </summary>
        [EnumMember(Value = "AIRMEE_WEBHOOK")]
        AirmeeWebhook,

        /// <summary>
        /// DhlBenelux.
        /// </summary>
        [EnumMember(Value = "DHL_BENELUX")]
        DhlBenelux,

        /// <summary>
        /// Firstmile.
        /// </summary>
        [EnumMember(Value = "FIRSTMILE")]
        Firstmile,

        /// <summary>
        /// FastwayIr.
        /// </summary>
        [EnumMember(Value = "FASTWAY_IR")]
        FastwayIr,

        /// <summary>
        /// HhExp.
        /// </summary>
        [EnumMember(Value = "HH_EXP")]
        HhExp,

        /// <summary>
        /// MysMypostOnline.
        /// </summary>
        [EnumMember(Value = "MYS_MYPOST_ONLINE")]
        MysMypostOnline,

        /// <summary>
        /// TntNl.
        /// </summary>
        [EnumMember(Value = "TNT_NL")]
        TntNl,

        /// <summary>
        /// Tipsa.
        /// </summary>
        [EnumMember(Value = "TIPSA")]
        Tipsa,

        /// <summary>
        /// TaqbinMy.
        /// </summary>
        [EnumMember(Value = "TAQBIN_MY")]
        TaqbinMy,

        /// <summary>
        /// Kgmhub.
        /// </summary>
        [EnumMember(Value = "KGMHUB")]
        Kgmhub,

        /// <summary>
        /// Intexpress.
        /// </summary>
        [EnumMember(Value = "INTEXPRESS")]
        Intexpress,

        /// <summary>
        /// OverseExp.
        /// </summary>
        [EnumMember(Value = "OVERSE_EXP")]
        OverseExp,

        /// <summary>
        /// Oneclick.
        /// </summary>
        [EnumMember(Value = "ONECLICK")]
        Oneclick,

        /// <summary>
        /// RoadrunnerFreight.
        /// </summary>
        [EnumMember(Value = "ROADRUNNER_FREIGHT")]
        RoadrunnerFreight,

        /// <summary>
        /// GlsCrotia.
        /// </summary>
        [EnumMember(Value = "GLS_CROTIA")]
        GlsCrotia,

        /// <summary>
        /// MrwFtp.
        /// </summary>
        [EnumMember(Value = "MRW_FTP")]
        MrwFtp,

        /// <summary>
        /// Bluex.
        /// </summary>
        [EnumMember(Value = "BLUEX")]
        Bluex,

        /// <summary>
        /// Dylt.
        /// </summary>
        [EnumMember(Value = "DYLT")]
        Dylt,

        /// <summary>
        /// DpdIr.
        /// </summary>
        [EnumMember(Value = "DPD_IR")]
        DpdIr,

        /// <summary>
        /// SinGlbl.
        /// </summary>
        [EnumMember(Value = "SIN_GLBL")]
        SinGlbl,

        /// <summary>
        /// TuffnellsReference.
        /// </summary>
        [EnumMember(Value = "TUFFNELLS_REFERENCE")]
        TuffnellsReference,

        /// <summary>
        /// Cjpacket.
        /// </summary>
        [EnumMember(Value = "CJPACKET")]
        Cjpacket,

        /// <summary>
        /// Milkman.
        /// </summary>
        [EnumMember(Value = "MILKMAN")]
        Milkman,

        /// <summary>
        /// Asigna.
        /// </summary>
        [EnumMember(Value = "ASIGNA")]
        Asigna,

        /// <summary>
        /// Oneworldexpress.
        /// </summary>
        [EnumMember(Value = "ONEWORLDEXPRESS")]
        Oneworldexpress,

        /// <summary>
        /// RoyalMail.
        /// </summary>
        [EnumMember(Value = "ROYAL_MAIL")]
        RoyalMail,

        /// <summary>
        /// ViaExpress.
        /// </summary>
        [EnumMember(Value = "VIA_EXPRESS")]
        ViaExpress,

        /// <summary>
        /// Tigfreight.
        /// </summary>
        [EnumMember(Value = "TIGFREIGHT")]
        Tigfreight,

        /// <summary>
        /// ZtoExpress.
        /// </summary>
        [EnumMember(Value = "ZTO_EXPRESS")]
        ZtoExpress,

        /// <summary>
        /// TwoGo.
        /// </summary>
        [EnumMember(Value = "TWO_GO")]
        TwoGo,

        /// <summary>
        /// Iml.
        /// </summary>
        [EnumMember(Value = "IML")]
        Iml,

        /// <summary>
        /// IntelValley.
        /// </summary>
        [EnumMember(Value = "INTEL_VALLEY")]
        IntelValley,

        /// <summary>
        /// Efs.
        /// </summary>
        [EnumMember(Value = "EFS")]
        Efs,

        /// <summary>
        /// UkUkMail.
        /// </summary>
        [EnumMember(Value = "UK_UK_MAIL")]
        UkUkMail,

        /// <summary>
        /// Ram.
        /// </summary>
        [EnumMember(Value = "RAM")]
        Ram,

        /// <summary>
        /// Alliedexpress.
        /// </summary>
        [EnumMember(Value = "ALLIEDEXPRESS")]
        Alliedexpress,

        /// <summary>
        /// ApcOvernight.
        /// </summary>
        [EnumMember(Value = "APC_OVERNIGHT")]
        ApcOvernight,

        /// <summary>
        /// Shippit.
        /// </summary>
        [EnumMember(Value = "SHIPPIT")]
        Shippit,

        /// <summary>
        /// Tfm.
        /// </summary>
        [EnumMember(Value = "TFM")]
        Tfm,

        /// <summary>
        /// MXpress.
        /// </summary>
        [EnumMember(Value = "M_XPRESS")]
        MXpress,

        /// <summary>
        /// HdbBox.
        /// </summary>
        [EnumMember(Value = "HDB_BOX")]
        HdbBox,

        /// <summary>
        /// ClevyLinks.
        /// </summary>
        [EnumMember(Value = "CLEVY_LINKS")]
        ClevyLinks,

        /// <summary>
        /// Ibeone.
        /// </summary>
        [EnumMember(Value = "IBEONE")]
        Ibeone,

        /// <summary>
        /// FiegeNl.
        /// </summary>
        [EnumMember(Value = "FIEGE_NL")]
        FiegeNl,

        /// <summary>
        /// KweGlobal.
        /// </summary>
        [EnumMember(Value = "KWE_GLOBAL")]
        KweGlobal,

        /// <summary>
        /// CtcExpress.
        /// </summary>
        [EnumMember(Value = "CTC_EXPRESS")]
        CtcExpress,

        /// <summary>
        /// LaoPost.
        /// </summary>
        [EnumMember(Value = "LAO_POST")]
        LaoPost,

        /// <summary>
        /// Amazon.
        /// </summary>
        [EnumMember(Value = "AMAZON")]
        Amazon,

        /// <summary>
        /// MoreLink.
        /// </summary>
        [EnumMember(Value = "MORE_LINK")]
        MoreLink,

        /// <summary>
        /// Jx.
        /// </summary>
        [EnumMember(Value = "JX")]
        Jx,

        /// <summary>
        /// EasyMail.
        /// </summary>
        [EnumMember(Value = "EASY_MAIL")]
        EasyMail,

        /// <summary>
        /// Aduiepyle.
        /// </summary>
        [EnumMember(Value = "ADUIEPYLE")]
        Aduiepyle,

        /// <summary>
        /// GbPanther.
        /// </summary>
        [EnumMember(Value = "GB_PANTHER")]
        GbPanther,

        /// <summary>
        /// Expresssale.
        /// </summary>
        [EnumMember(Value = "EXPRESSSALE")]
        Expresssale,

        /// <summary>
        /// SgDetrack.
        /// </summary>
        [EnumMember(Value = "SG_DETRACK")]
        SgDetrack,

        /// <summary>
        /// TrunkrsWebhook.
        /// </summary>
        [EnumMember(Value = "TRUNKRS_WEBHOOK")]
        TrunkrsWebhook,

        /// <summary>
        /// Matdespatch.
        /// </summary>
        [EnumMember(Value = "MATDESPATCH")]
        Matdespatch,

        /// <summary>
        /// Dicom.
        /// </summary>
        [EnumMember(Value = "DICOM")]
        Dicom,

        /// <summary>
        /// Mbw.
        /// </summary>
        [EnumMember(Value = "MBW")]
        Mbw,

        /// <summary>
        /// KhmCambodiaPost.
        /// </summary>
        [EnumMember(Value = "KHM_CAMBODIA_POST")]
        KhmCambodiaPost,

        /// <summary>
        /// Sinotrans.
        /// </summary>
        [EnumMember(Value = "SINOTRANS")]
        Sinotrans,

        /// <summary>
        /// BrtItParcelid.
        /// </summary>
        [EnumMember(Value = "BRT_IT_PARCELID")]
        BrtItParcelid,

        /// <summary>
        /// DhlSupplyChain.
        /// </summary>
        [EnumMember(Value = "DHL_SUPPLY_CHAIN")]
        DhlSupplyChain,

        /// <summary>
        /// DhlPl.
        /// </summary>
        [EnumMember(Value = "DHL_PL")]
        DhlPl,

        /// <summary>
        /// Topyou.
        /// </summary>
        [EnumMember(Value = "TOPYOU")]
        Topyou,

        /// <summary>
        /// Palexpress.
        /// </summary>
        [EnumMember(Value = "PALEXPRESS")]
        Palexpress,

        /// <summary>
        /// DhlSg.
        /// </summary>
        [EnumMember(Value = "DHL_SG")]
        DhlSg,

        /// <summary>
        /// CnWedo.
        /// </summary>
        [EnumMember(Value = "CN_WEDO")]
        CnWedo,

        /// <summary>
        /// Fulfillme.
        /// </summary>
        [EnumMember(Value = "FULFILLME")]
        Fulfillme,

        /// <summary>
        /// DpdDelistrack.
        /// </summary>
        [EnumMember(Value = "DPD_DELISTRACK")]
        DpdDelistrack,

        /// <summary>
        /// UpsReference.
        /// </summary>
        [EnumMember(Value = "UPS_REFERENCE")]
        UpsReference,

        /// <summary>
        /// Caribou.
        /// </summary>
        [EnumMember(Value = "CARIBOU")]
        Caribou,

        /// <summary>
        /// LocusWebhook.
        /// </summary>
        [EnumMember(Value = "LOCUS_WEBHOOK")]
        LocusWebhook,

        /// <summary>
        /// Dsv.
        /// </summary>
        [EnumMember(Value = "DSV")]
        Dsv,

        /// <summary>
        /// CnGofly.
        /// </summary>
        [EnumMember(Value = "CN_GOFLY")]
        CnGofly,

        /// <summary>
        /// P2PTrc.
        /// </summary>
        [EnumMember(Value = "P2P_TRC")]
        P2PTrc,

        /// <summary>
        /// Directparcels.
        /// </summary>
        [EnumMember(Value = "DIRECTPARCELS")]
        Directparcels,

        /// <summary>
        /// NovaPoshtaInt.
        /// </summary>
        [EnumMember(Value = "NOVA_POSHTA_INT")]
        NovaPoshtaInt,

        /// <summary>
        /// FedexPoland.
        /// </summary>
        [EnumMember(Value = "FEDEX_POLAND")]
        FedexPoland,

        /// <summary>
        /// CnJcex.
        /// </summary>
        [EnumMember(Value = "CN_JCEX")]
        CnJcex,

        /// <summary>
        /// FarInternational.
        /// </summary>
        [EnumMember(Value = "FAR_INTERNATIONAL")]
        FarInternational,

        /// <summary>
        /// Idexpress.
        /// </summary>
        [EnumMember(Value = "IDEXPRESS")]
        Idexpress,

        /// <summary>
        /// Gangbao.
        /// </summary>
        [EnumMember(Value = "GANGBAO")]
        Gangbao,

        /// <summary>
        /// Neway.
        /// </summary>
        [EnumMember(Value = "NEWAY")]
        Neway,

        /// <summary>
        /// PostnlInt3S.
        /// </summary>
        [EnumMember(Value = "POSTNL_INT_3_S")]
        PostnlInt3S,

        /// <summary>
        /// RpxId.
        /// </summary>
        [EnumMember(Value = "RPX_ID")]
        RpxId,

        /// <summary>
        /// DesignertransportWebhook.
        /// </summary>
        [EnumMember(Value = "DESIGNERTRANSPORT_WEBHOOK")]
        DesignertransportWebhook,

        /// <summary>
        /// GlsSloven.
        /// </summary>
        [EnumMember(Value = "GLS_SLOVEN")]
        GlsSloven,

        /// <summary>
        /// ParcelledIn.
        /// </summary>
        [EnumMember(Value = "PARCELLED_IN")]
        ParcelledIn,

        /// <summary>
        /// GsiExpress.
        /// </summary>
        [EnumMember(Value = "GSI_EXPRESS")]
        GsiExpress,

        /// <summary>
        /// ConWay.
        /// </summary>
        [EnumMember(Value = "CON_WAY")]
        ConWay,

        /// <summary>
        /// BrouwerTransport.
        /// </summary>
        [EnumMember(Value = "BROUWER_TRANSPORT")]
        BrouwerTransport,

        /// <summary>
        /// Cpex.
        /// </summary>
        [EnumMember(Value = "CPEX")]
        Cpex,

        /// <summary>
        /// IsraelPost.
        /// </summary>
        [EnumMember(Value = "ISRAEL_POST")]
        IsraelPost,

        /// <summary>
        /// DtdcIn.
        /// </summary>
        [EnumMember(Value = "DTDC_IN")]
        DtdcIn,

        /// <summary>
        /// PttPost.
        /// </summary>
        [EnumMember(Value = "PTT_POST")]
        PttPost,

        /// <summary>
        /// XdeWebhook.
        /// </summary>
        [EnumMember(Value = "XDE_WEBHOOK")]
        XdeWebhook,

        /// <summary>
        /// Tolos.
        /// </summary>
        [EnumMember(Value = "TOLOS")]
        Tolos,

        /// <summary>
        /// GiaoHang.
        /// </summary>
        [EnumMember(Value = "GIAO_HANG")]
        GiaoHang,

        /// <summary>
        /// GeodisEspace.
        /// </summary>
        [EnumMember(Value = "GEODIS_ESPACE")]
        GeodisEspace,

        /// <summary>
        /// MagyarHu.
        /// </summary>
        [EnumMember(Value = "MAGYAR_HU")]
        MagyarHu,

        /// <summary>
        /// DoordashWebhook.
        /// </summary>
        [EnumMember(Value = "DOORDASH_WEBHOOK")]
        DoordashWebhook,

        /// <summary>
        /// TikiId.
        /// </summary>
        [EnumMember(Value = "TIKI_ID")]
        TikiId,

        /// <summary>
        /// CjHkInternational.
        /// </summary>
        [EnumMember(Value = "CJ_HK_INTERNATIONAL")]
        CjHkInternational,

        /// <summary>
        /// StarTrackExpress.
        /// </summary>
        [EnumMember(Value = "STAR_TRACK_EXPRESS")]
        StarTrackExpress,

        /// <summary>
        /// Helthjem.
        /// </summary>
        [EnumMember(Value = "HELTHJEM")]
        Helthjem,

        /// <summary>
        /// Sfb2C.
        /// </summary>
        [EnumMember(Value = "SFB2C")]
        Sfb2C,

        /// <summary>
        /// Freightquote.
        /// </summary>
        [EnumMember(Value = "FREIGHTQUOTE")]
        Freightquote,

        /// <summary>
        /// LandmarkGlobalReference.
        /// </summary>
        [EnumMember(Value = "LANDMARK_GLOBAL_REFERENCE")]
        LandmarkGlobalReference,

        /// <summary>
        /// Parcel2Go.
        /// </summary>
        [EnumMember(Value = "PARCEL2GO")]
        Parcel2Go,

        /// <summary>
        /// Delnext.
        /// </summary>
        [EnumMember(Value = "DELNEXT")]
        Delnext,

        /// <summary>
        /// Rcl.
        /// </summary>
        [EnumMember(Value = "RCL")]
        Rcl,

        /// <summary>
        /// CgsExpress.
        /// </summary>
        [EnumMember(Value = "CGS_EXPRESS")]
        CgsExpress,

        /// <summary>
        /// HkPost.
        /// </summary>
        [EnumMember(Value = "HK_POST")]
        HkPost,

        /// <summary>
        /// SapExpress.
        /// </summary>
        [EnumMember(Value = "SAP_EXPRESS")]
        SapExpress,

        /// <summary>
        /// ParcelpostSg.
        /// </summary>
        [EnumMember(Value = "PARCELPOST_SG")]
        ParcelpostSg,

        /// <summary>
        /// Hermes.
        /// </summary>
        [EnumMember(Value = "HERMES")]
        Hermes,

        /// <summary>
        /// IndSafeexpress.
        /// </summary>
        [EnumMember(Value = "IND_SAFEEXPRESS")]
        IndSafeexpress,

        /// <summary>
        /// Tophatterexpress.
        /// </summary>
        [EnumMember(Value = "TOPHATTEREXPRESS")]
        Tophatterexpress,

        /// <summary>
        /// Mglobal.
        /// </summary>
        [EnumMember(Value = "MGLOBAL")]
        Mglobal,

        /// <summary>
        /// Averitt.
        /// </summary>
        [EnumMember(Value = "AVERITT")]
        Averitt,

        /// <summary>
        /// Leader.
        /// </summary>
        [EnumMember(Value = "LEADER")]
        Leader,

        /// <summary>
        /// _2Ebox.
        /// </summary>
        [EnumMember(Value = "_2EBOX")]
        _2Ebox,

        /// <summary>
        /// SgSpeedpost.
        /// </summary>
        [EnumMember(Value = "SG_SPEEDPOST")]
        SgSpeedpost,

        /// <summary>
        /// DbschenkerSe.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_SE")]
        DbschenkerSe,

        /// <summary>
        /// IsrPostDomestic.
        /// </summary>
        [EnumMember(Value = "ISR_POST_DOMESTIC")]
        IsrPostDomestic,

        /// <summary>
        /// Bestwayparcel.
        /// </summary>
        [EnumMember(Value = "BESTWAYPARCEL")]
        Bestwayparcel,

        /// <summary>
        /// AsendiaDe.
        /// </summary>
        [EnumMember(Value = "ASENDIA_DE")]
        AsendiaDe,

        /// <summary>
        /// NightlineUk.
        /// </summary>
        [EnumMember(Value = "NIGHTLINE_UK")]
        NightlineUk,

        /// <summary>
        /// TaqbinSg.
        /// </summary>
        [EnumMember(Value = "TAQBIN_SG")]
        TaqbinSg,

        /// <summary>
        /// TckExpress.
        /// </summary>
        [EnumMember(Value = "TCK_EXPRESS")]
        TckExpress,

        /// <summary>
        /// EndeavourDelivery.
        /// </summary>
        [EnumMember(Value = "ENDEAVOUR_DELIVERY")]
        EndeavourDelivery,

        /// <summary>
        /// Nanjingwoyuan.
        /// </summary>
        [EnumMember(Value = "NANJINGWOYUAN")]
        Nanjingwoyuan,

        /// <summary>
        /// HeppnerFr.
        /// </summary>
        [EnumMember(Value = "HEPPNER_FR")]
        HeppnerFr,

        /// <summary>
        /// EmpsCn.
        /// </summary>
        [EnumMember(Value = "EMPS_CN")]
        EmpsCn,

        /// <summary>
        /// Fonsen.
        /// </summary>
        [EnumMember(Value = "FONSEN")]
        Fonsen,

        /// <summary>
        /// Pickrr.
        /// </summary>
        [EnumMember(Value = "PICKRR")]
        Pickrr,

        /// <summary>
        /// ApcOvernightConnum.
        /// </summary>
        [EnumMember(Value = "APC_OVERNIGHT_CONNUM")]
        ApcOvernightConnum,

        /// <summary>
        /// StarTrackNextFlight.
        /// </summary>
        [EnumMember(Value = "STAR_TRACK_NEXT_FLIGHT")]
        StarTrackNextFlight,

        /// <summary>
        /// Dajin.
        /// </summary>
        [EnumMember(Value = "DAJIN")]
        Dajin,

        /// <summary>
        /// UpsFreight.
        /// </summary>
        [EnumMember(Value = "UPS_FREIGHT")]
        UpsFreight,

        /// <summary>
        /// PostaPlus.
        /// </summary>
        [EnumMember(Value = "POSTA_PLUS")]
        PostaPlus,

        /// <summary>
        /// Ceva.
        /// </summary>
        [EnumMember(Value = "CEVA")]
        Ceva,

        /// <summary>
        /// Anserx.
        /// </summary>
        [EnumMember(Value = "ANSERX")]
        Anserx,

        /// <summary>
        /// JsExpress.
        /// </summary>
        [EnumMember(Value = "JS_EXPRESS")]
        JsExpress,

        /// <summary>
        /// Padtf.
        /// </summary>
        [EnumMember(Value = "PADTF")]
        Padtf,

        /// <summary>
        /// UpsMailInnovations.
        /// </summary>
        [EnumMember(Value = "UPS_MAIL_INNOVATIONS")]
        UpsMailInnovations,

        /// <summary>
        /// Ezship.
        /// </summary>
        [EnumMember(Value = "EZSHIP")]
        Ezship,

        /// <summary>
        /// Sypost.
        /// </summary>
        [EnumMember(Value = "SYPOST")]
        Sypost,

        /// <summary>
        /// AmazonShipMcf.
        /// </summary>
        [EnumMember(Value = "AMAZON_SHIP_MCF")]
        AmazonShipMcf,

        /// <summary>
        /// Yusen.
        /// </summary>
        [EnumMember(Value = "YUSEN")]
        Yusen,

        /// <summary>
        /// Bring.
        /// </summary>
        [EnumMember(Value = "BRING")]
        Bring,

        /// <summary>
        /// SdaIt.
        /// </summary>
        [EnumMember(Value = "SDA_IT")]
        SdaIt,

        /// <summary>
        /// Gba.
        /// </summary>
        [EnumMember(Value = "GBA")]
        Gba,

        /// <summary>
        /// Neweggexpress.
        /// </summary>
        [EnumMember(Value = "NEWEGGEXPRESS")]
        Neweggexpress,

        /// <summary>
        /// SpeedcouriersGr.
        /// </summary>
        [EnumMember(Value = "SPEEDCOURIERS_GR")]
        SpeedcouriersGr,

        /// <summary>
        /// Forrun.
        /// </summary>
        [EnumMember(Value = "FORRUN")]
        Forrun,

        /// <summary>
        /// Pickup.
        /// </summary>
        [EnumMember(Value = "PICKUP")]
        Pickup,

        /// <summary>
        /// Ecms.
        /// </summary>
        [EnumMember(Value = "ECMS")]
        Ecms,

        /// <summary>
        /// Intelipost.
        /// </summary>
        [EnumMember(Value = "INTELIPOST")]
        Intelipost,

        /// <summary>
        /// Flashexpress.
        /// </summary>
        [EnumMember(Value = "FLASHEXPRESS")]
        Flashexpress,

        /// <summary>
        /// CnSto.
        /// </summary>
        [EnumMember(Value = "CN_STO")]
        CnSto,

        /// <summary>
        /// SekoSftp.
        /// </summary>
        [EnumMember(Value = "SEKO_SFTP")]
        SekoSftp,

        /// <summary>
        /// HomeDeliverySolutions.
        /// </summary>
        [EnumMember(Value = "HOME_DELIVERY_SOLUTIONS")]
        HomeDeliverySolutions,

        /// <summary>
        /// DpdHgry.
        /// </summary>
        [EnumMember(Value = "DPD_HGRY")]
        DpdHgry,

        /// <summary>
        /// KerryttcVn.
        /// </summary>
        [EnumMember(Value = "KERRYTTC_VN")]
        KerryttcVn,

        /// <summary>
        /// JoyingBox.
        /// </summary>
        [EnumMember(Value = "JOYING_BOX")]
        JoyingBox,

        /// <summary>
        /// TotalExpress.
        /// </summary>
        [EnumMember(Value = "TOTAL_EXPRESS")]
        TotalExpress,

        /// <summary>
        /// ZjsExpress.
        /// </summary>
        [EnumMember(Value = "ZJS_EXPRESS")]
        ZjsExpress,

        /// <summary>
        /// Starken.
        /// </summary>
        [EnumMember(Value = "STARKEN")]
        Starken,

        /// <summary>
        /// Demandship.
        /// </summary>
        [EnumMember(Value = "DEMANDSHIP")]
        Demandship,

        /// <summary>
        /// CnDpex.
        /// </summary>
        [EnumMember(Value = "CN_DPEX")]
        CnDpex,

        /// <summary>
        /// AupostCn.
        /// </summary>
        [EnumMember(Value = "AUPOST_CN")]
        AupostCn,

        /// <summary>
        /// Logisters.
        /// </summary>
        [EnumMember(Value = "LOGISTERS")]
        Logisters,

        /// <summary>
        /// Goglobalpost.
        /// </summary>
        [EnumMember(Value = "GOGLOBALPOST")]
        Goglobalpost,

        /// <summary>
        /// GlsCz.
        /// </summary>
        [EnumMember(Value = "GLS_CZ")]
        GlsCz,

        /// <summary>
        /// PaackWebhook.
        /// </summary>
        [EnumMember(Value = "PAACK_WEBHOOK")]
        PaackWebhook,

        /// <summary>
        /// GrabWebhook.
        /// </summary>
        [EnumMember(Value = "GRAB_WEBHOOK")]
        GrabWebhook,

        /// <summary>
        /// Parcelpoint.
        /// </summary>
        [EnumMember(Value = "PARCELPOINT")]
        Parcelpoint,

        /// <summary>
        /// Icumulus.
        /// </summary>
        [EnumMember(Value = "ICUMULUS")]
        Icumulus,

        /// <summary>
        /// Daiglobaltrack.
        /// </summary>
        [EnumMember(Value = "DAIGLOBALTRACK")]
        Daiglobaltrack,

        /// <summary>
        /// GlobalIparcel.
        /// </summary>
        [EnumMember(Value = "GLOBAL_IPARCEL")]
        GlobalIparcel,

        /// <summary>
        /// YurticiKargo.
        /// </summary>
        [EnumMember(Value = "YURTICI_KARGO")]
        YurticiKargo,

        /// <summary>
        /// CnPaypalPackage.
        /// </summary>
        [EnumMember(Value = "CN_PAYPAL_PACKAGE")]
        CnPaypalPackage,

        /// <summary>
        /// Parcel2Post.
        /// </summary>
        [EnumMember(Value = "PARCEL_2_POST")]
        Parcel2Post,

        /// <summary>
        /// GlsIt.
        /// </summary>
        [EnumMember(Value = "GLS_IT")]
        GlsIt,

        /// <summary>
        /// PilLogistics.
        /// </summary>
        [EnumMember(Value = "PIL_LOGISTICS")]
        PilLogistics,

        /// <summary>
        /// Heppner.
        /// </summary>
        [EnumMember(Value = "HEPPNER")]
        Heppner,

        /// <summary>
        /// GeneralOvernight.
        /// </summary>
        [EnumMember(Value = "GENERAL_OVERNIGHT")]
        GeneralOvernight,

        /// <summary>
        /// Happy2Point.
        /// </summary>
        [EnumMember(Value = "HAPPY2POINT")]
        Happy2Point,

        /// <summary>
        /// Chitchats.
        /// </summary>
        [EnumMember(Value = "CHITCHATS")]
        Chitchats,

        /// <summary>
        /// Smooth.
        /// </summary>
        [EnumMember(Value = "SMOOTH")]
        Smooth,

        /// <summary>
        /// CleLogistics.
        /// </summary>
        [EnumMember(Value = "CLE_LOGISTICS")]
        CleLogistics,

        /// <summary>
        /// Fiege.
        /// </summary>
        [EnumMember(Value = "FIEGE")]
        Fiege,

        /// <summary>
        /// MxCargo.
        /// </summary>
        [EnumMember(Value = "MX_CARGO")]
        MxCargo,

        /// <summary>
        /// Ziingfinalmile.
        /// </summary>
        [EnumMember(Value = "ZIINGFINALMILE")]
        Ziingfinalmile,

        /// <summary>
        /// DaytonFreight.
        /// </summary>
        [EnumMember(Value = "DAYTON_FREIGHT")]
        DaytonFreight,

        /// <summary>
        /// Tcs.
        /// </summary>
        [EnumMember(Value = "TCS")]
        Tcs,

        /// <summary>
        /// Aex.
        /// </summary>
        [EnumMember(Value = "AEX")]
        Aex,

        /// <summary>
        /// HermesDe.
        /// </summary>
        [EnumMember(Value = "HERMES_DE")]
        HermesDe,

        /// <summary>
        /// RoutificWebhook.
        /// </summary>
        [EnumMember(Value = "ROUTIFIC_WEBHOOK")]
        RoutificWebhook,

        /// <summary>
        /// Globavend.
        /// </summary>
        [EnumMember(Value = "GLOBAVEND")]
        Globavend,

        /// <summary>
        /// CjLogistics.
        /// </summary>
        [EnumMember(Value = "CJ_LOGISTICS")]
        CjLogistics,

        /// <summary>
        /// PalletNetwork.
        /// </summary>
        [EnumMember(Value = "PALLET_NETWORK")]
        PalletNetwork,

        /// <summary>
        /// RafPh.
        /// </summary>
        [EnumMember(Value = "RAF_PH")]
        RafPh,

        /// <summary>
        /// UkXdp.
        /// </summary>
        [EnumMember(Value = "UK_XDP")]
        UkXdp,

        /// <summary>
        /// PaperExpress.
        /// </summary>
        [EnumMember(Value = "PAPER_EXPRESS")]
        PaperExpress,

        /// <summary>
        /// LaPosteSuivi.
        /// </summary>
        [EnumMember(Value = "LA_POSTE_SUIVI")]
        LaPosteSuivi,

        /// <summary>
        /// Paquetexpress.
        /// </summary>
        [EnumMember(Value = "PAQUETEXPRESS")]
        Paquetexpress,

        /// <summary>
        /// Liefery.
        /// </summary>
        [EnumMember(Value = "LIEFERY")]
        Liefery,

        /// <summary>
        /// StreckTransport.
        /// </summary>
        [EnumMember(Value = "STRECK_TRANSPORT")]
        StreckTransport,

        /// <summary>
        /// PonyExpress.
        /// </summary>
        [EnumMember(Value = "PONY_EXPRESS")]
        PonyExpress,

        /// <summary>
        /// AlwaysExpress.
        /// </summary>
        [EnumMember(Value = "ALWAYS_EXPRESS")]
        AlwaysExpress,

        /// <summary>
        /// GbsBroker.
        /// </summary>
        [EnumMember(Value = "GBS_BROKER")]
        GbsBroker,

        /// <summary>
        /// CitylinkMy.
        /// </summary>
        [EnumMember(Value = "CITYLINK_MY")]
        CitylinkMy,

        /// <summary>
        /// Alljoy.
        /// </summary>
        [EnumMember(Value = "ALLJOY")]
        Alljoy,

        /// <summary>
        /// Yodel.
        /// </summary>
        [EnumMember(Value = "YODEL")]
        Yodel,

        /// <summary>
        /// YodelDir.
        /// </summary>
        [EnumMember(Value = "YODEL_DIR")]
        YodelDir,

        /// <summary>
        /// Stone3Pl.
        /// </summary>
        [EnumMember(Value = "STONE3PL")]
        Stone3Pl,

        /// <summary>
        /// ParcelpalWebhook.
        /// </summary>
        [EnumMember(Value = "PARCELPAL_WEBHOOK")]
        ParcelpalWebhook,

        /// <summary>
        /// DhlEcomerceAsa.
        /// </summary>
        [EnumMember(Value = "DHL_ECOMERCE_ASA")]
        DhlEcomerceAsa,

        /// <summary>
        /// Simplypost.
        /// </summary>
        [EnumMember(Value = "SIMPLYPOST")]
        Simplypost,

        /// <summary>
        /// KyExpress.
        /// </summary>
        [EnumMember(Value = "KY_EXPRESS")]
        KyExpress,

        /// <summary>
        /// Shenzhen.
        /// </summary>
        [EnumMember(Value = "SHENZHEN")]
        Shenzhen,

        /// <summary>
        /// UsLasership.
        /// </summary>
        [EnumMember(Value = "US_LASERSHIP")]
        UsLasership,

        /// <summary>
        /// UcExpre.
        /// </summary>
        [EnumMember(Value = "UC_EXPRE")]
        UcExpre,

        /// <summary>
        /// Didadi.
        /// </summary>
        [EnumMember(Value = "DIDADI")]
        Didadi,

        /// <summary>
        /// CjKr.
        /// </summary>
        [EnumMember(Value = "CJ_KR")]
        CjKr,

        /// <summary>
        /// DbschenkerB2B.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_B2B")]
        DbschenkerB2B,

        /// <summary>
        /// Mxe.
        /// </summary>
        [EnumMember(Value = "MXE")]
        Mxe,

        /// <summary>
        /// CaeDelivers.
        /// </summary>
        [EnumMember(Value = "CAE_DELIVERS")]
        CaeDelivers,

        /// <summary>
        /// Pfcexpress.
        /// </summary>
        [EnumMember(Value = "PFCEXPRESS")]
        Pfcexpress,

        /// <summary>
        /// Whistl.
        /// </summary>
        [EnumMember(Value = "WHISTL")]
        Whistl,

        /// <summary>
        /// Wepost.
        /// </summary>
        [EnumMember(Value = "WEPOST")]
        Wepost,

        /// <summary>
        /// DhlParcelEs.
        /// </summary>
        [EnumMember(Value = "DHL_PARCEL_ES")]
        DhlParcelEs,

        /// <summary>
        /// Ddexpress.
        /// </summary>
        [EnumMember(Value = "DDEXPRESS")]
        Ddexpress,

        /// <summary>
        /// AramexAu.
        /// </summary>
        [EnumMember(Value = "ARAMEX_AU")]
        AramexAu,

        /// <summary>
        /// Bneed.
        /// </summary>
        [EnumMember(Value = "BNEED")]
        Bneed,

        /// <summary>
        /// HkTgx.
        /// </summary>
        [EnumMember(Value = "HK_TGX")]
        HkTgx,

        /// <summary>
        /// LatvijasPasts.
        /// </summary>
        [EnumMember(Value = "LATVIJAS_PASTS")]
        LatvijasPasts,

        /// <summary>
        /// Viaeurope.
        /// </summary>
        [EnumMember(Value = "VIAEUROPE")]
        Viaeurope,

        /// <summary>
        /// CorreoUy.
        /// </summary>
        [EnumMember(Value = "CORREO_UY")]
        CorreoUy,

        /// <summary>
        /// ChronopostFr.
        /// </summary>
        [EnumMember(Value = "CHRONOPOST_FR")]
        ChronopostFr,

        /// <summary>
        /// JNet.
        /// </summary>
        [EnumMember(Value = "J_NET")]
        JNet,

        /// <summary>
        /// _6Ls.
        /// </summary>
        [EnumMember(Value = "_6LS")]
        _6Ls,

        /// <summary>
        /// BlrBelpost.
        /// </summary>
        [EnumMember(Value = "BLR_BELPOST")]
        BlrBelpost,

        /// <summary>
        /// Birdsystem.
        /// </summary>
        [EnumMember(Value = "BIRDSYSTEM")]
        Birdsystem,

        /// <summary>
        /// Dobropost.
        /// </summary>
        [EnumMember(Value = "DOBROPOST")]
        Dobropost,

        /// <summary>
        /// WahanaId.
        /// </summary>
        [EnumMember(Value = "WAHANA_ID")]
        WahanaId,

        /// <summary>
        /// Weaship.
        /// </summary>
        [EnumMember(Value = "WEASHIP")]
        Weaship,

        /// <summary>
        /// Sonictl.
        /// </summary>
        [EnumMember(Value = "SONICTL")]
        Sonictl,

        /// <summary>
        /// Kwt.
        /// </summary>
        [EnumMember(Value = "KWT")]
        Kwt,

        /// <summary>
        /// AfllogFtp.
        /// </summary>
        [EnumMember(Value = "AFLLOG_FTP")]
        AfllogFtp,

        /// <summary>
        /// SkynetWorldwide.
        /// </summary>
        [EnumMember(Value = "SKYNET_WORLDWIDE")]
        SkynetWorldwide,

        /// <summary>
        /// NovaPoshta.
        /// </summary>
        [EnumMember(Value = "NOVA_POSHTA")]
        NovaPoshta,

        /// <summary>
        /// Seino.
        /// </summary>
        [EnumMember(Value = "SEINO")]
        Seino,

        /// <summary>
        /// Szendex.
        /// </summary>
        [EnumMember(Value = "SZENDEX")]
        Szendex,

        /// <summary>
        /// BpostInt.
        /// </summary>
        [EnumMember(Value = "BPOST_INT")]
        BpostInt,

        /// <summary>
        /// DbschenkerSv.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_SV")]
        DbschenkerSv,

        /// <summary>
        /// AoDeutschland.
        /// </summary>
        [EnumMember(Value = "AO_DEUTSCHLAND")]
        AoDeutschland,

        /// <summary>
        /// EuFleetSolutions.
        /// </summary>
        [EnumMember(Value = "EU_FLEET_SOLUTIONS")]
        EuFleetSolutions,

        /// <summary>
        /// Pcfcorp.
        /// </summary>
        [EnumMember(Value = "PCFCORP")]
        Pcfcorp,

        /// <summary>
        /// Linkbridge.
        /// </summary>
        [EnumMember(Value = "LINKBRIDGE")]
        Linkbridge,

        /// <summary>
        /// Primamulticipta.
        /// </summary>
        [EnumMember(Value = "PRIMAMULTICIPTA")]
        Primamulticipta,

        /// <summary>
        /// Courex.
        /// </summary>
        [EnumMember(Value = "COUREX")]
        Courex,

        /// <summary>
        /// ZajilExpress.
        /// </summary>
        [EnumMember(Value = "ZAJIL_EXPRESS")]
        ZajilExpress,

        /// <summary>
        /// Collectco.
        /// </summary>
        [EnumMember(Value = "COLLECTCO")]
        Collectco,

        /// <summary>
        /// Jtexpress.
        /// </summary>
        [EnumMember(Value = "JTEXPRESS")]
        Jtexpress,

        /// <summary>
        /// FedexUk.
        /// </summary>
        [EnumMember(Value = "FEDEX_UK")]
        FedexUk,

        /// <summary>
        /// Uship.
        /// </summary>
        [EnumMember(Value = "USHIP")]
        Uship,

        /// <summary>
        /// Pixsell.
        /// </summary>
        [EnumMember(Value = "PIXSELL")]
        Pixsell,

        /// <summary>
        /// Shiptor.
        /// </summary>
        [EnumMember(Value = "SHIPTOR")]
        Shiptor,

        /// <summary>
        /// Cdek.
        /// </summary>
        [EnumMember(Value = "CDEK")]
        Cdek,

        /// <summary>
        /// VnmViettelpost.
        /// </summary>
        [EnumMember(Value = "VNM_VIETTELPOST")]
        VnmViettelpost,

        /// <summary>
        /// CjCentury.
        /// </summary>
        [EnumMember(Value = "CJ_CENTURY")]
        CjCentury,

        /// <summary>
        /// Gso.
        /// </summary>
        [EnumMember(Value = "GSO")]
        Gso,

        /// <summary>
        /// Viwo.
        /// </summary>
        [EnumMember(Value = "VIWO")]
        Viwo,

        /// <summary>
        /// Skybox.
        /// </summary>
        [EnumMember(Value = "SKYBOX")]
        Skybox,

        /// <summary>
        /// Kerrytj.
        /// </summary>
        [EnumMember(Value = "KERRYTJ")]
        Kerrytj,

        /// <summary>
        /// NtlogisticsVn.
        /// </summary>
        [EnumMember(Value = "NTLOGISTICS_VN")]
        NtlogisticsVn,

        /// <summary>
        /// SdhScm.
        /// </summary>
        [EnumMember(Value = "SDH_SCM")]
        SdhScm,

        /// <summary>
        /// Zinc.
        /// </summary>
        [EnumMember(Value = "ZINC")]
        Zinc,

        /// <summary>
        /// DpeSouthAfrc.
        /// </summary>
        [EnumMember(Value = "DPE_SOUTH_AFRC")]
        DpeSouthAfrc,

        /// <summary>
        /// CeskaCz.
        /// </summary>
        [EnumMember(Value = "CESKA_CZ")]
        CeskaCz,

        /// <summary>
        /// AcsGr.
        /// </summary>
        [EnumMember(Value = "ACS_GR")]
        AcsGr,

        /// <summary>
        /// Dealersend.
        /// </summary>
        [EnumMember(Value = "DEALERSEND")]
        Dealersend,

        /// <summary>
        /// Jocom.
        /// </summary>
        [EnumMember(Value = "JOCOM")]
        Jocom,

        /// <summary>
        /// Cse.
        /// </summary>
        [EnumMember(Value = "CSE")]
        Cse,

        /// <summary>
        /// TforceFinalmile.
        /// </summary>
        [EnumMember(Value = "TFORCE_FINALMILE")]
        TforceFinalmile,

        /// <summary>
        /// ShipGate.
        /// </summary>
        [EnumMember(Value = "SHIP_GATE")]
        ShipGate,

        /// <summary>
        /// Shipter.
        /// </summary>
        [EnumMember(Value = "SHIPTER")]
        Shipter,

        /// <summary>
        /// NationalSameday.
        /// </summary>
        [EnumMember(Value = "NATIONAL_SAMEDAY")]
        NationalSameday,

        /// <summary>
        /// Yunexpress.
        /// </summary>
        [EnumMember(Value = "YUNEXPRESS")]
        Yunexpress,

        /// <summary>
        /// Cainiao.
        /// </summary>
        [EnumMember(Value = "CAINIAO")]
        Cainiao,

        /// <summary>
        /// DmsMatrix.
        /// </summary>
        [EnumMember(Value = "DMS_MATRIX")]
        DmsMatrix,

        /// <summary>
        /// Directlog.
        /// </summary>
        [EnumMember(Value = "DIRECTLOG")]
        Directlog,

        /// <summary>
        /// AsendiaUs.
        /// </summary>
        [EnumMember(Value = "ASENDIA_US")]
        AsendiaUs,

        /// <summary>
        /// _3Jmslogistics.
        /// </summary>
        [EnumMember(Value = "_3JMSLOGISTICS")]
        _3Jmslogistics,

        /// <summary>
        /// LiccardiExpress.
        /// </summary>
        [EnumMember(Value = "LICCARDI_EXPRESS")]
        LiccardiExpress,

        /// <summary>
        /// SkyPostal.
        /// </summary>
        [EnumMember(Value = "SKY_POSTAL")]
        SkyPostal,

        /// <summary>
        /// Cnwangtong.
        /// </summary>
        [EnumMember(Value = "CNWANGTONG")]
        Cnwangtong,

        /// <summary>
        /// PostnordLogisticsDk.
        /// </summary>
        [EnumMember(Value = "POSTNORD_LOGISTICS_DK")]
        PostnordLogisticsDk,

        /// <summary>
        /// Logistika.
        /// </summary>
        [EnumMember(Value = "LOGISTIKA")]
        Logistika,

        /// <summary>
        /// Celeritas.
        /// </summary>
        [EnumMember(Value = "CELERITAS")]
        Celeritas,

        /// <summary>
        /// Pressiode.
        /// </summary>
        [EnumMember(Value = "PRESSIODE")]
        Pressiode,

        /// <summary>
        /// ShreeMaruti.
        /// </summary>
        [EnumMember(Value = "SHREE_MARUTI")]
        ShreeMaruti,

        /// <summary>
        /// LogisticsworldwideHk.
        /// </summary>
        [EnumMember(Value = "LOGISTICSWORLDWIDE_HK")]
        LogisticsworldwideHk,

        /// <summary>
        /// Efex.
        /// </summary>
        [EnumMember(Value = "EFEX")]
        Efex,

        /// <summary>
        /// Lotte.
        /// </summary>
        [EnumMember(Value = "LOTTE")]
        Lotte,

        /// <summary>
        /// Lonestar.
        /// </summary>
        [EnumMember(Value = "LONESTAR")]
        Lonestar,

        /// <summary>
        /// Aprisaexpress.
        /// </summary>
        [EnumMember(Value = "APRISAEXPRESS")]
        Aprisaexpress,

        /// <summary>
        /// BelRs.
        /// </summary>
        [EnumMember(Value = "BEL_RS")]
        BelRs,

        /// <summary>
        /// OsmWorldwide.
        /// </summary>
        [EnumMember(Value = "OSM_WORLDWIDE")]
        OsmWorldwide,

        /// <summary>
        /// WestgateGl.
        /// </summary>
        [EnumMember(Value = "WESTGATE_GL")]
        WestgateGl,

        /// <summary>
        /// Fastrack.
        /// </summary>
        [EnumMember(Value = "FASTRACK")]
        Fastrack,

        /// <summary>
        /// DtdExpr.
        /// </summary>
        [EnumMember(Value = "DTD_EXPR")]
        DtdExpr,

        /// <summary>
        /// Alfatrex.
        /// </summary>
        [EnumMember(Value = "ALFATREX")]
        Alfatrex,

        /// <summary>
        /// Promeddelivery.
        /// </summary>
        [EnumMember(Value = "PROMEDDELIVERY")]
        Promeddelivery,

        /// <summary>
        /// ThabitLogistics.
        /// </summary>
        [EnumMember(Value = "THABIT_LOGISTICS")]
        ThabitLogistics,

        /// <summary>
        /// HctLogistics.
        /// </summary>
        [EnumMember(Value = "HCT_LOGISTICS")]
        HctLogistics,

        /// <summary>
        /// CarryFlap.
        /// </summary>
        [EnumMember(Value = "CARRY_FLAP")]
        CarryFlap,

        /// <summary>
        /// UsOldDominion.
        /// </summary>
        [EnumMember(Value = "US_OLD_DOMINION")]
        UsOldDominion,

        /// <summary>
        /// AnicamBox.
        /// </summary>
        [EnumMember(Value = "ANICAM_BOX")]
        AnicamBox,

        /// <summary>
        /// Wanbexpress.
        /// </summary>
        [EnumMember(Value = "WANBEXPRESS")]
        Wanbexpress,

        /// <summary>
        /// AnPost.
        /// </summary>
        [EnumMember(Value = "AN_POST")]
        AnPost,

        /// <summary>
        /// DpdLocal.
        /// </summary>
        [EnumMember(Value = "DPD_LOCAL")]
        DpdLocal,

        /// <summary>
        /// Stallionexpress.
        /// </summary>
        [EnumMember(Value = "STALLIONEXPRESS")]
        Stallionexpress,

        /// <summary>
        /// Raiderex.
        /// </summary>
        [EnumMember(Value = "RAIDEREX")]
        Raiderex,

        /// <summary>
        /// Shopfans.
        /// </summary>
        [EnumMember(Value = "SHOPFANS")]
        Shopfans,

        /// <summary>
        /// KyungdongParcel.
        /// </summary>
        [EnumMember(Value = "KYUNGDONG_PARCEL")]
        KyungdongParcel,

        /// <summary>
        /// ChampionLogistics.
        /// </summary>
        [EnumMember(Value = "CHAMPION_LOGISTICS")]
        ChampionLogistics,

        /// <summary>
        /// PickuppSgp.
        /// </summary>
        [EnumMember(Value = "PICKUPP_SGP")]
        PickuppSgp,

        /// <summary>
        /// MorningExpress.
        /// </summary>
        [EnumMember(Value = "MORNING_EXPRESS")]
        MorningExpress,

        /// <summary>
        /// Nacex.
        /// </summary>
        [EnumMember(Value = "NACEX")]
        Nacex,

        /// <summary>
        /// ThenileWebhook.
        /// </summary>
        [EnumMember(Value = "THENILE_WEBHOOK")]
        ThenileWebhook,

        /// <summary>
        /// Holisol.
        /// </summary>
        [EnumMember(Value = "HOLISOL")]
        Holisol,

        /// <summary>
        /// LbcexpressFtp.
        /// </summary>
        [EnumMember(Value = "LBCEXPRESS_FTP")]
        LbcexpressFtp,

        /// <summary>
        /// Kurasi.
        /// </summary>
        [EnumMember(Value = "KURASI")]
        Kurasi,

        /// <summary>
        /// UsfReddaway.
        /// </summary>
        [EnumMember(Value = "USF_REDDAWAY")]
        UsfReddaway,

        /// <summary>
        /// Apg.
        /// </summary>
        [EnumMember(Value = "APG")]
        Apg,

        /// <summary>
        /// CnBoxc.
        /// </summary>
        [EnumMember(Value = "CN_BOXC")]
        CnBoxc,

        /// <summary>
        /// Ecoscooting.
        /// </summary>
        [EnumMember(Value = "ECOSCOOTING")]
        Ecoscooting,

        /// <summary>
        /// Mainway.
        /// </summary>
        [EnumMember(Value = "MAINWAY")]
        Mainway,

        /// <summary>
        /// Paperfly.
        /// </summary>
        [EnumMember(Value = "PAPERFLY")]
        Paperfly,

        /// <summary>
        /// Houndexpress.
        /// </summary>
        [EnumMember(Value = "HOUNDEXPRESS")]
        Houndexpress,

        /// <summary>
        /// BoxBerry.
        /// </summary>
        [EnumMember(Value = "BOX_BERRY")]
        BoxBerry,

        /// <summary>
        /// EpBox.
        /// </summary>
        [EnumMember(Value = "EP_BOX")]
        EpBox,

        /// <summary>
        /// PlusLogUk.
        /// </summary>
        [EnumMember(Value = "PLUS_LOG_UK")]
        PlusLogUk,

        /// <summary>
        /// Fulfilla.
        /// </summary>
        [EnumMember(Value = "FULFILLA")]
        Fulfilla,

        /// <summary>
        /// Ase.
        /// </summary>
        [EnumMember(Value = "ASE")]
        Ase,

        /// <summary>
        /// MailPlus.
        /// </summary>
        [EnumMember(Value = "MAIL_PLUS")]
        MailPlus,

        /// <summary>
        /// XpoLogistics.
        /// </summary>
        [EnumMember(Value = "XPO_LOGISTICS")]
        XpoLogistics,

        /// <summary>
        /// Wndirect.
        /// </summary>
        [EnumMember(Value = "WNDIRECT")]
        Wndirect,

        /// <summary>
        /// CloudwishAsia.
        /// </summary>
        [EnumMember(Value = "CLOUDWISH_ASIA")]
        CloudwishAsia,

        /// <summary>
        /// Zeleris.
        /// </summary>
        [EnumMember(Value = "ZELERIS")]
        Zeleris,

        /// <summary>
        /// GioExpress.
        /// </summary>
        [EnumMember(Value = "GIO_EXPRESS")]
        GioExpress,

        /// <summary>
        /// OcsWorldwide.
        /// </summary>
        [EnumMember(Value = "OCS_WORLDWIDE")]
        OcsWorldwide,

        /// <summary>
        /// ArkLogistics.
        /// </summary>
        [EnumMember(Value = "ARK_LOGISTICS")]
        ArkLogistics,

        /// <summary>
        /// Aquiline.
        /// </summary>
        [EnumMember(Value = "AQUILINE")]
        Aquiline,

        /// <summary>
        /// PilotFreight.
        /// </summary>
        [EnumMember(Value = "PILOT_FREIGHT")]
        PilotFreight,

        /// <summary>
        /// Qwintry.
        /// </summary>
        [EnumMember(Value = "QWINTRY")]
        Qwintry,

        /// <summary>
        /// DanskeFragt.
        /// </summary>
        [EnumMember(Value = "DANSKE_FRAGT")]
        DanskeFragt,

        /// <summary>
        /// Carriers.
        /// </summary>
        [EnumMember(Value = "CARRIERS")]
        Carriers,

        /// <summary>
        /// AirCanadaGlobal.
        /// </summary>
        [EnumMember(Value = "AIR_CANADA_GLOBAL")]
        AirCanadaGlobal,

        /// <summary>
        /// PresidentTrans.
        /// </summary>
        [EnumMember(Value = "PRESIDENT_TRANS")]
        PresidentTrans,

        /// <summary>
        /// Stepforwardfs.
        /// </summary>
        [EnumMember(Value = "STEPFORWARDFS")]
        Stepforwardfs,

        /// <summary>
        /// SkynetUk.
        /// </summary>
        [EnumMember(Value = "SKYNET_UK")]
        SkynetUk,

        /// <summary>
        /// Pittohio.
        /// </summary>
        [EnumMember(Value = "PITTOHIO")]
        Pittohio,

        /// <summary>
        /// CorreosExpress.
        /// </summary>
        [EnumMember(Value = "CORREOS_EXPRESS")]
        CorreosExpress,

        /// <summary>
        /// RlUs.
        /// </summary>
        [EnumMember(Value = "RL_US")]
        RlUs,

        /// <summary>
        /// MaraXpress.
        /// </summary>
        [EnumMember(Value = "MARA_XPRESS")]
        MaraXpress,

        /// <summary>
        /// Destiny.
        /// </summary>
        [EnumMember(Value = "DESTINY")]
        Destiny,

        /// <summary>
        /// UkYodel.
        /// </summary>
        [EnumMember(Value = "UK_YODEL")]
        UkYodel,

        /// <summary>
        /// CometTech.
        /// </summary>
        [EnumMember(Value = "COMET_TECH")]
        CometTech,

        /// <summary>
        /// DhlParcelRu.
        /// </summary>
        [EnumMember(Value = "DHL_PARCEL_RU")]
        DhlParcelRu,

        /// <summary>
        /// TntRefr.
        /// </summary>
        [EnumMember(Value = "TNT_REFR")]
        TntRefr,

        /// <summary>
        /// ShreeAnjaniCourier.
        /// </summary>
        [EnumMember(Value = "SHREE_ANJANI_COURIER")]
        ShreeAnjaniCourier,

        /// <summary>
        /// MikropakketBe.
        /// </summary>
        [EnumMember(Value = "MIKROPAKKET_BE")]
        MikropakketBe,

        /// <summary>
        /// EtsExpress.
        /// </summary>
        [EnumMember(Value = "ETS_EXPRESS")]
        EtsExpress,

        /// <summary>
        /// ColisPrive.
        /// </summary>
        [EnumMember(Value = "COLIS_PRIVE")]
        ColisPrive,

        /// <summary>
        /// CnYunda.
        /// </summary>
        [EnumMember(Value = "CN_YUNDA")]
        CnYunda,

        /// <summary>
        /// AaaCooper.
        /// </summary>
        [EnumMember(Value = "AAA_COOPER")]
        AaaCooper,

        /// <summary>
        /// RocketParcel.
        /// </summary>
        [EnumMember(Value = "ROCKET_PARCEL")]
        RocketParcel,

        /// <summary>
        /// _360Lion.
        /// </summary>
        [EnumMember(Value = "_360LION")]
        _360Lion,

        /// <summary>
        /// Pandu.
        /// </summary>
        [EnumMember(Value = "PANDU")]
        Pandu,

        /// <summary>
        /// ProfessionalCouriers.
        /// </summary>
        [EnumMember(Value = "PROFESSIONAL_COURIERS")]
        ProfessionalCouriers,

        /// <summary>
        /// Flytexpress.
        /// </summary>
        [EnumMember(Value = "FLYTEXPRESS")]
        Flytexpress,

        /// <summary>
        /// LogisticsworldwideMy.
        /// </summary>
        [EnumMember(Value = "LOGISTICSWORLDWIDE_MY")]
        LogisticsworldwideMy,

        /// <summary>
        /// CorreosDeEspana.
        /// </summary>
        [EnumMember(Value = "CORREOS_DE_ESPANA")]
        CorreosDeEspana,

        /// <summary>
        /// Imx.
        /// </summary>
        [EnumMember(Value = "IMX")]
        Imx,

        /// <summary>
        /// FourPxExpress.
        /// </summary>
        [EnumMember(Value = "FOUR_PX_EXPRESS")]
        FourPxExpress,

        /// <summary>
        /// Xpressbees.
        /// </summary>
        [EnumMember(Value = "XPRESSBEES")]
        Xpressbees,

        /// <summary>
        /// PickuppVnm.
        /// </summary>
        [EnumMember(Value = "PICKUPP_VNM")]
        PickuppVnm,

        /// <summary>
        /// StartrackExpress1.
        /// </summary>
        [EnumMember(Value = "STARTRACK_EXPRESS")]
        StartrackExpress1,

        /// <summary>
        /// FrColissimo.
        /// </summary>
        [EnumMember(Value = "FR_COLISSIMO")]
        FrColissimo,

        /// <summary>
        /// NacexSpainReference.
        /// </summary>
        [EnumMember(Value = "NACEX_SPAIN_REFERENCE")]
        NacexSpainReference,

        /// <summary>
        /// DhlSupplyChainAu.
        /// </summary>
        [EnumMember(Value = "DHL_SUPPLY_CHAIN_AU")]
        DhlSupplyChainAu,

        /// <summary>
        /// Eshipping.
        /// </summary>
        [EnumMember(Value = "ESHIPPING")]
        Eshipping,

        /// <summary>
        /// Shreetirupati.
        /// </summary>
        [EnumMember(Value = "SHREETIRUPATI")]
        Shreetirupati,

        /// <summary>
        /// HxExpress.
        /// </summary>
        [EnumMember(Value = "HX_EXPRESS")]
        HxExpress,

        /// <summary>
        /// Indopaket.
        /// </summary>
        [EnumMember(Value = "INDOPAKET")]
        Indopaket,

        /// <summary>
        /// Cn17Post.
        /// </summary>
        [EnumMember(Value = "CN_17POST")]
        Cn17Post,

        /// <summary>
        /// K1Express.
        /// </summary>
        [EnumMember(Value = "K1_EXPRESS")]
        K1Express,

        /// <summary>
        /// CjGls.
        /// </summary>
        [EnumMember(Value = "CJ_GLS")]
        CjGls,

        /// <summary>
        /// MysGdex.
        /// </summary>
        [EnumMember(Value = "MYS_GDEX")]
        MysGdex,

        /// <summary>
        /// Nationex.
        /// </summary>
        [EnumMember(Value = "NATIONEX")]
        Nationex,

        /// <summary>
        /// Anjun.
        /// </summary>
        [EnumMember(Value = "ANJUN")]
        Anjun,

        /// <summary>
        /// Fargood.
        /// </summary>
        [EnumMember(Value = "FARGOOD")]
        Fargood,

        /// <summary>
        /// SmgExpress.
        /// </summary>
        [EnumMember(Value = "SMG_EXPRESS")]
        SmgExpress,

        /// <summary>
        /// Rzyexpress.
        /// </summary>
        [EnumMember(Value = "RZYEXPRESS")]
        Rzyexpress,

        /// <summary>
        /// Sefl.
        /// </summary>
        [EnumMember(Value = "SEFL")]
        Sefl,

        /// <summary>
        /// TntClickIt.
        /// </summary>
        [EnumMember(Value = "TNT_CLICK_IT")]
        TntClickIt,

        /// <summary>
        /// Hdb.
        /// </summary>
        [EnumMember(Value = "HDB")]
        Hdb,

        /// <summary>
        /// Hipshipper.
        /// </summary>
        [EnumMember(Value = "HIPSHIPPER")]
        Hipshipper,

        /// <summary>
        /// Rpxlogistics.
        /// </summary>
        [EnumMember(Value = "RPXLOGISTICS")]
        Rpxlogistics,

        /// <summary>
        /// Kuehne.
        /// </summary>
        [EnumMember(Value = "KUEHNE")]
        Kuehne,

        /// <summary>
        /// ItNexive.
        /// </summary>
        [EnumMember(Value = "IT_NEXIVE")]
        ItNexive,

        /// <summary>
        /// Pts.
        /// </summary>
        [EnumMember(Value = "PTS")]
        Pts,

        /// <summary>
        /// SwissPostFtp.
        /// </summary>
        [EnumMember(Value = "SWISS_POST_FTP")]
        SwissPostFtp,

        /// <summary>
        /// FastrkServ.
        /// </summary>
        [EnumMember(Value = "FASTRK_SERV")]
        FastrkServ,

        /// <summary>
        /// _472.
        /// </summary>
        [EnumMember(Value = "_4_72")]
        _472,

        /// <summary>
        /// UsYrc.
        /// </summary>
        [EnumMember(Value = "US_YRC")]
        UsYrc,

        /// <summary>
        /// PostnlIntl3S.
        /// </summary>
        [EnumMember(Value = "POSTNL_INTL_3S")]
        PostnlIntl3S,

        /// <summary>
        /// ElianPost.
        /// </summary>
        [EnumMember(Value = "ELIAN_POST")]
        ElianPost,

        /// <summary>
        /// Cubyn.
        /// </summary>
        [EnumMember(Value = "CUBYN")]
        Cubyn,

        /// <summary>
        /// SauSaudiPost.
        /// </summary>
        [EnumMember(Value = "SAU_SAUDI_POST")]
        SauSaudiPost,

        /// <summary>
        /// AbxexpressMy.
        /// </summary>
        [EnumMember(Value = "ABXEXPRESS_MY")]
        AbxexpressMy,

        /// <summary>
        /// HuahanExpress.
        /// </summary>
        [EnumMember(Value = "HUAHAN_EXPRESS")]
        HuahanExpress,

        /// <summary>
        /// IndJayonexpress.
        /// </summary>
        [EnumMember(Value = "IND_JAYONEXPRESS")]
        IndJayonexpress,

        /// <summary>
        /// ZesExpress.
        /// </summary>
        [EnumMember(Value = "ZES_EXPRESS")]
        ZesExpress,

        /// <summary>
        /// ZeptoExpress.
        /// </summary>
        [EnumMember(Value = "ZEPTO_EXPRESS")]
        ZeptoExpress,

        /// <summary>
        /// SkynetZa.
        /// </summary>
        [EnumMember(Value = "SKYNET_ZA")]
        SkynetZa,

        /// <summary>
        /// Zeek2Door.
        /// </summary>
        [EnumMember(Value = "ZEEK_2_DOOR")]
        Zeek2Door,

        /// <summary>
        /// Blinklastmile.
        /// </summary>
        [EnumMember(Value = "BLINKLASTMILE")]
        Blinklastmile,

        /// <summary>
        /// PostaUkr.
        /// </summary>
        [EnumMember(Value = "POSTA_UKR")]
        PostaUkr,

        /// <summary>
        /// Chrobinson.
        /// </summary>
        [EnumMember(Value = "CHROBINSON")]
        Chrobinson,

        /// <summary>
        /// CnPost56.
        /// </summary>
        [EnumMember(Value = "CN_POST56")]
        CnPost56,

        /// <summary>
        /// CourantPlus.
        /// </summary>
        [EnumMember(Value = "COURANT_PLUS")]
        CourantPlus,

        /// <summary>
        /// ScudexExpress.
        /// </summary>
        [EnumMember(Value = "SCUDEX_EXPRESS")]
        ScudexExpress,

        /// <summary>
        /// Shipentegra.
        /// </summary>
        [EnumMember(Value = "SHIPENTEGRA")]
        Shipentegra,

        /// <summary>
        /// BTwoCEurope.
        /// </summary>
        [EnumMember(Value = "B_TWO_C_EUROPE")]
        BTwoCEurope,

        /// <summary>
        /// Cope.
        /// </summary>
        [EnumMember(Value = "COPE")]
        Cope,

        /// <summary>
        /// IndGati.
        /// </summary>
        [EnumMember(Value = "IND_GATI")]
        IndGati,

        /// <summary>
        /// CnWishpost.
        /// </summary>
        [EnumMember(Value = "CN_WISHPOST")]
        CnWishpost,

        /// <summary>
        /// NacexEs.
        /// </summary>
        [EnumMember(Value = "NACEX_ES")]
        NacexEs,

        /// <summary>
        /// TaqbinHk.
        /// </summary>
        [EnumMember(Value = "TAQBIN_HK")]
        TaqbinHk,

        /// <summary>
        /// Globaltranz.
        /// </summary>
        [EnumMember(Value = "GLOBALTRANZ")]
        Globaltranz,

        /// <summary>
        /// Hkd.
        /// </summary>
        [EnumMember(Value = "HKD")]
        Hkd,

        /// <summary>
        /// Bjshomedelivery.
        /// </summary>
        [EnumMember(Value = "BJSHOMEDELIVERY")]
        Bjshomedelivery,

        /// <summary>
        /// Omniva.
        /// </summary>
        [EnumMember(Value = "OMNIVA")]
        Omniva,

        /// <summary>
        /// Sutton.
        /// </summary>
        [EnumMember(Value = "SUTTON")]
        Sutton,

        /// <summary>
        /// PantherReference.
        /// </summary>
        [EnumMember(Value = "PANTHER_REFERENCE")]
        PantherReference,

        /// <summary>
        /// Sfcservice.
        /// </summary>
        [EnumMember(Value = "SFCSERVICE")]
        Sfcservice,

        /// <summary>
        /// Ltl.
        /// </summary>
        [EnumMember(Value = "LTL")]
        Ltl,

        /// <summary>
        /// Parknparcel.
        /// </summary>
        [EnumMember(Value = "PARKNPARCEL")]
        Parknparcel,

        /// <summary>
        /// SpringGds.
        /// </summary>
        [EnumMember(Value = "SPRING_GDS")]
        SpringGds,

        /// <summary>
        /// Ecexpress.
        /// </summary>
        [EnumMember(Value = "ECEXPRESS")]
        Ecexpress,

        /// <summary>
        /// InterparcelAu.
        /// </summary>
        [EnumMember(Value = "INTERPARCEL_AU")]
        InterparcelAu,

        /// <summary>
        /// Agility.
        /// </summary>
        [EnumMember(Value = "AGILITY")]
        Agility,

        /// <summary>
        /// XlExpress.
        /// </summary>
        [EnumMember(Value = "XL_EXPRESS")]
        XlExpress,

        /// <summary>
        /// Aderonline.
        /// </summary>
        [EnumMember(Value = "ADERONLINE")]
        Aderonline,

        /// <summary>
        /// Directcouriers.
        /// </summary>
        [EnumMember(Value = "DIRECTCOURIERS")]
        Directcouriers,

        /// <summary>
        /// Planzer.
        /// </summary>
        [EnumMember(Value = "PLANZER")]
        Planzer,

        /// <summary>
        /// Sending.
        /// </summary>
        [EnumMember(Value = "SENDING")]
        Sending,

        /// <summary>
        /// NinjavanWb.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_WB")]
        NinjavanWb,

        /// <summary>
        /// NationwideMy.
        /// </summary>
        [EnumMember(Value = "NATIONWIDE_MY")]
        NationwideMy,

        /// <summary>
        /// Sendit.
        /// </summary>
        [EnumMember(Value = "SENDIT")]
        Sendit,

        /// <summary>
        /// GbArrow.
        /// </summary>
        [EnumMember(Value = "GB_ARROW")]
        GbArrow,

        /// <summary>
        /// IndGojavas.
        /// </summary>
        [EnumMember(Value = "IND_GOJAVAS")]
        IndGojavas,

        /// <summary>
        /// Kpost.
        /// </summary>
        [EnumMember(Value = "KPOST")]
        Kpost,

        /// <summary>
        /// DhlFreight.
        /// </summary>
        [EnumMember(Value = "DHL_FREIGHT")]
        DhlFreight,

        /// <summary>
        /// Bluecare.
        /// </summary>
        [EnumMember(Value = "BLUECARE")]
        Bluecare,

        /// <summary>
        /// Jindouyun.
        /// </summary>
        [EnumMember(Value = "JINDOUYUN")]
        Jindouyun,

        /// <summary>
        /// Trackon.
        /// </summary>
        [EnumMember(Value = "TRACKON")]
        Trackon,

        /// <summary>
        /// GbTuffnells.
        /// </summary>
        [EnumMember(Value = "GB_TUFFNELLS")]
        GbTuffnells,

        /// <summary>
        /// Trumpcard.
        /// </summary>
        [EnumMember(Value = "TRUMPCARD")]
        Trumpcard,

        /// <summary>
        /// Etotal.
        /// </summary>
        [EnumMember(Value = "ETOTAL")]
        Etotal,

        /// <summary>
        /// SfplusWebhook.
        /// </summary>
        [EnumMember(Value = "SFPLUS_WEBHOOK")]
        SfplusWebhook,

        /// <summary>
        /// Sekologistics.
        /// </summary>
        [EnumMember(Value = "SEKOLOGISTICS")]
        Sekologistics,

        /// <summary>
        /// Hermes2MannHandling.
        /// </summary>
        [EnumMember(Value = "HERMES_2MANN_HANDLING")]
        Hermes2MannHandling,

        /// <summary>
        /// DpdLocalRef.
        /// </summary>
        [EnumMember(Value = "DPD_LOCAL_REF")]
        DpdLocalRef,

        /// <summary>
        /// Uds.
        /// </summary>
        [EnumMember(Value = "UDS")]
        Uds,

        /// <summary>
        /// ZaSpecialisedFreight.
        /// </summary>
        [EnumMember(Value = "ZA_SPECIALISED_FREIGHT")]
        ZaSpecialisedFreight,

        /// <summary>
        /// ThaKerry.
        /// </summary>
        [EnumMember(Value = "THA_KERRY")]
        ThaKerry,

        /// <summary>
        /// PrtIntSeur.
        /// </summary>
        [EnumMember(Value = "PRT_INT_SEUR")]
        PrtIntSeur,

        /// <summary>
        /// BraCorreios.
        /// </summary>
        [EnumMember(Value = "BRA_CORREIOS")]
        BraCorreios,

        /// <summary>
        /// NzNzPost.
        /// </summary>
        [EnumMember(Value = "NZ_NZ_POST")]
        NzNzPost,

        /// <summary>
        /// CnEquick.
        /// </summary>
        [EnumMember(Value = "CN_EQUICK")]
        CnEquick,

        /// <summary>
        /// MysEms.
        /// </summary>
        [EnumMember(Value = "MYS_EMS")]
        MysEms,

        /// <summary>
        /// GbNorsk.
        /// </summary>
        [EnumMember(Value = "GB_NORSK")]
        GbNorsk,

        /// <summary>
        /// EspMrw.
        /// </summary>
        [EnumMember(Value = "ESP_MRW")]
        EspMrw,

        /// <summary>
        /// EspPacklink.
        /// </summary>
        [EnumMember(Value = "ESP_PACKLINK")]
        EspPacklink,

        /// <summary>
        /// KangarooMy.
        /// </summary>
        [EnumMember(Value = "KANGAROO_MY")]
        KangarooMy,

        /// <summary>
        /// Rpx.
        /// </summary>
        [EnumMember(Value = "RPX")]
        Rpx,

        /// <summary>
        /// XdpUkReference.
        /// </summary>
        [EnumMember(Value = "XDP_UK_REFERENCE")]
        XdpUkReference,

        /// <summary>
        /// NinjavanMy.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_MY")]
        NinjavanMy,

        /// <summary>
        /// Adicional.
        /// </summary>
        [EnumMember(Value = "ADICIONAL")]
        Adicional,

        /// <summary>
        /// NinjavanId.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_ID")]
        NinjavanId,

        /// <summary>
        /// Roadbull.
        /// </summary>
        [EnumMember(Value = "ROADBULL")]
        Roadbull,

        /// <summary>
        /// Yakit.
        /// </summary>
        [EnumMember(Value = "YAKIT")]
        Yakit,

        /// <summary>
        /// Mailamericas.
        /// </summary>
        [EnumMember(Value = "MAILAMERICAS")]
        Mailamericas,

        /// <summary>
        /// Mikropakket.
        /// </summary>
        [EnumMember(Value = "MIKROPAKKET")]
        Mikropakket,

        /// <summary>
        /// Dynalogic.
        /// </summary>
        [EnumMember(Value = "DYNALOGIC")]
        Dynalogic,

        /// <summary>
        /// DhlEs.
        /// </summary>
        [EnumMember(Value = "DHL_ES")]
        DhlEs,

        /// <summary>
        /// DhlParcelNl.
        /// </summary>
        [EnumMember(Value = "DHL_PARCEL_NL")]
        DhlParcelNl,

        /// <summary>
        /// DhlGlobalMailAsia.
        /// </summary>
        [EnumMember(Value = "DHL_GLOBAL_MAIL_ASIA")]
        DhlGlobalMailAsia,

        /// <summary>
        /// DawnWing.
        /// </summary>
        [EnumMember(Value = "DAWN_WING")]
        DawnWing,

        /// <summary>
        /// GenikiGr.
        /// </summary>
        [EnumMember(Value = "GENIKI_GR")]
        GenikiGr,

        /// <summary>
        /// HermesworldUk.
        /// </summary>
        [EnumMember(Value = "HERMESWORLD_UK")]
        HermesworldUk,

        /// <summary>
        /// Alphafast.
        /// </summary>
        [EnumMember(Value = "ALPHAFAST")]
        Alphafast,

        /// <summary>
        /// Buylogic.
        /// </summary>
        [EnumMember(Value = "BUYLOGIC")]
        Buylogic,

        /// <summary>
        /// Ekart.
        /// </summary>
        [EnumMember(Value = "EKART")]
        Ekart,

        /// <summary>
        /// MexSenda.
        /// </summary>
        [EnumMember(Value = "MEX_SENDA")]
        MexSenda,

        /// <summary>
        /// SfcLogistics.
        /// </summary>
        [EnumMember(Value = "SFC_LOGISTICS")]
        SfcLogistics,

        /// <summary>
        /// PostSerbia.
        /// </summary>
        [EnumMember(Value = "POST_SERBIA")]
        PostSerbia,

        /// <summary>
        /// IndDelhivery.
        /// </summary>
        [EnumMember(Value = "IND_DELHIVERY")]
        IndDelhivery,

        /// <summary>
        /// DeDpdDelistrack.
        /// </summary>
        [EnumMember(Value = "DE_DPD_DELISTRACK")]
        DeDpdDelistrack,

        /// <summary>
        /// Rpd2Man.
        /// </summary>
        [EnumMember(Value = "RPD2MAN")]
        Rpd2Man,

        /// <summary>
        /// CnSfExpress.
        /// </summary>
        [EnumMember(Value = "CN_SF_EXPRESS")]
        CnSfExpress,

        /// <summary>
        /// Yanwen.
        /// </summary>
        [EnumMember(Value = "YANWEN")]
        Yanwen,

        /// <summary>
        /// MysSkynet.
        /// </summary>
        [EnumMember(Value = "MYS_SKYNET")]
        MysSkynet,

        /// <summary>
        /// CorreosDeMexico.
        /// </summary>
        [EnumMember(Value = "CORREOS_DE_MEXICO")]
        CorreosDeMexico,

        /// <summary>
        /// CblLogistica.
        /// </summary>
        [EnumMember(Value = "CBL_LOGISTICA")]
        CblLogistica,

        /// <summary>
        /// MexEstafeta.
        /// </summary>
        [EnumMember(Value = "MEX_ESTAFETA")]
        MexEstafeta,

        /// <summary>
        /// AuAustrianPost.
        /// </summary>
        [EnumMember(Value = "AU_AUSTRIAN_POST")]
        AuAustrianPost,

        /// <summary>
        /// Rincos.
        /// </summary>
        [EnumMember(Value = "RINCOS")]
        Rincos,

        /// <summary>
        /// NldDhl.
        /// </summary>
        [EnumMember(Value = "NLD_DHL")]
        NldDhl,

        /// <summary>
        /// RussianPost.
        /// </summary>
        [EnumMember(Value = "RUSSIAN_POST")]
        RussianPost,

        /// <summary>
        /// CouriersPlease.
        /// </summary>
        [EnumMember(Value = "COURIERS_PLEASE")]
        CouriersPlease,

        /// <summary>
        /// PostnordLogistics.
        /// </summary>
        [EnumMember(Value = "POSTNORD_LOGISTICS")]
        PostnordLogistics,

        /// <summary>
        /// Fedex.
        /// </summary>
        [EnumMember(Value = "FEDEX")]
        Fedex,

        /// <summary>
        /// DpeExpress.
        /// </summary>
        [EnumMember(Value = "DPE_EXPRESS")]
        DpeExpress,

        /// <summary>
        /// Dpd.
        /// </summary>
        [EnumMember(Value = "DPD")]
        Dpd,

        /// <summary>
        /// Adsone.
        /// </summary>
        [EnumMember(Value = "ADSONE")]
        Adsone,

        /// <summary>
        /// IdnJne.
        /// </summary>
        [EnumMember(Value = "IDN_JNE")]
        IdnJne,

        /// <summary>
        /// Thecourierguy.
        /// </summary>
        [EnumMember(Value = "THECOURIERGUY")]
        Thecourierguy,

        /// <summary>
        /// Cnexps.
        /// </summary>
        [EnumMember(Value = "CNEXPS")]
        Cnexps,

        /// <summary>
        /// PrtChronopost.
        /// </summary>
        [EnumMember(Value = "PRT_CHRONOPOST")]
        PrtChronopost,

        /// <summary>
        /// LandmarkGlobal.
        /// </summary>
        [EnumMember(Value = "LANDMARK_GLOBAL")]
        LandmarkGlobal,

        /// <summary>
        /// ItDhlEcommerce.
        /// </summary>
        [EnumMember(Value = "IT_DHL_ECOMMERCE")]
        ItDhlEcommerce,

        /// <summary>
        /// EspNacex.
        /// </summary>
        [EnumMember(Value = "ESP_NACEX")]
        EspNacex,

        /// <summary>
        /// PrtCtt.
        /// </summary>
        [EnumMember(Value = "PRT_CTT")]
        PrtCtt,

        /// <summary>
        /// BeKiala.
        /// </summary>
        [EnumMember(Value = "BE_KIALA")]
        BeKiala,

        /// <summary>
        /// AsendiaUk.
        /// </summary>
        [EnumMember(Value = "ASENDIA_UK")]
        AsendiaUk,

        /// <summary>
        /// GlobalTnt.
        /// </summary>
        [EnumMember(Value = "GLOBAL_TNT")]
        GlobalTnt,

        /// <summary>
        /// PosturIs.
        /// </summary>
        [EnumMember(Value = "POSTUR_IS")]
        PosturIs,

        /// <summary>
        /// EparcelKr.
        /// </summary>
        [EnumMember(Value = "EPARCEL_KR")]
        EparcelKr,

        /// <summary>
        /// InpostPaczkomaty.
        /// </summary>
        [EnumMember(Value = "INPOST_PACZKOMATY")]
        InpostPaczkomaty,

        /// <summary>
        /// ItPosteItalia.
        /// </summary>
        [EnumMember(Value = "IT_POSTE_ITALIA")]
        ItPosteItalia,

        /// <summary>
        /// BeBpost.
        /// </summary>
        [EnumMember(Value = "BE_BPOST")]
        BeBpost,

        /// <summary>
        /// PlPocztaPolska.
        /// </summary>
        [EnumMember(Value = "PL_POCZTA_POLSKA")]
        PlPocztaPolska,

        /// <summary>
        /// MysMysPost.
        /// </summary>
        [EnumMember(Value = "MYS_MYS_POST")]
        MysMysPost,

        /// <summary>
        /// SgSgPost.
        /// </summary>
        [EnumMember(Value = "SG_SG_POST")]
        SgSgPost,

        /// <summary>
        /// ThaThailandPost.
        /// </summary>
        [EnumMember(Value = "THA_THAILAND_POST")]
        ThaThailandPost,

        /// <summary>
        /// Lexship.
        /// </summary>
        [EnumMember(Value = "LEXSHIP")]
        Lexship,

        /// <summary>
        /// FastwayNz.
        /// </summary>
        [EnumMember(Value = "FASTWAY_NZ")]
        FastwayNz,

        /// <summary>
        /// DhlAu.
        /// </summary>
        [EnumMember(Value = "DHL_AU")]
        DhlAu,

        /// <summary>
        /// Costmeticsnow.
        /// </summary>
        [EnumMember(Value = "COSTMETICSNOW")]
        Costmeticsnow,

        /// <summary>
        /// Pflogistics.
        /// </summary>
        [EnumMember(Value = "PFLOGISTICS")]
        Pflogistics,

        /// <summary>
        /// LoomisExpress.
        /// </summary>
        [EnumMember(Value = "LOOMIS_EXPRESS")]
        LoomisExpress,

        /// <summary>
        /// GlsItaly.
        /// </summary>
        [EnumMember(Value = "GLS_ITALY")]
        GlsItaly,

        /// <summary>
        /// Line.
        /// </summary>
        [EnumMember(Value = "LINE")]
        Line,

        /// <summary>
        /// GelExpress.
        /// </summary>
        [EnumMember(Value = "GEL_EXPRESS")]
        GelExpress,

        /// <summary>
        /// Huodull.
        /// </summary>
        [EnumMember(Value = "HUODULL")]
        Huodull,

        /// <summary>
        /// NinjavanSg.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_SG")]
        NinjavanSg,

        /// <summary>
        /// Janio.
        /// </summary>
        [EnumMember(Value = "JANIO")]
        Janio,

        /// <summary>
        /// AoCourier.
        /// </summary>
        [EnumMember(Value = "AO_COURIER")]
        AoCourier,

        /// <summary>
        /// BrtItSenderRef.
        /// </summary>
        [EnumMember(Value = "BRT_IT_SENDER_REF")]
        BrtItSenderRef,

        /// <summary>
        /// Sailpost.
        /// </summary>
        [EnumMember(Value = "SAILPOST")]
        Sailpost,

        /// <summary>
        /// Lalamove.
        /// </summary>
        [EnumMember(Value = "LALAMOVE")]
        Lalamove,

        /// <summary>
        /// NewzealandCouriers.
        /// </summary>
        [EnumMember(Value = "NEWZEALAND_COURIERS")]
        NewzealandCouriers,

        /// <summary>
        /// Etomars.
        /// </summary>
        [EnumMember(Value = "ETOMARS")]
        Etomars,

        /// <summary>
        /// Virtransport.
        /// </summary>
        [EnumMember(Value = "VIRTRANSPORT")]
        Virtransport,

        /// <summary>
        /// Wizmo.
        /// </summary>
        [EnumMember(Value = "WIZMO")]
        Wizmo,

        /// <summary>
        /// Palletways.
        /// </summary>
        [EnumMember(Value = "PALLETWAYS")]
        Palletways,

        /// <summary>
        /// IDika.
        /// </summary>
        [EnumMember(Value = "I_DIKA")]
        IDika,

        /// <summary>
        /// CflLogistics.
        /// </summary>
        [EnumMember(Value = "CFL_LOGISTICS")]
        CflLogistics,

        /// <summary>
        /// Gemworldwide.
        /// </summary>
        [EnumMember(Value = "GEMWORLDWIDE")]
        Gemworldwide,

        /// <summary>
        /// GlobalExpress.
        /// </summary>
        [EnumMember(Value = "GLOBAL_EXPRESS")]
        GlobalExpress,

        /// <summary>
        /// LogistyxTransgroup.
        /// </summary>
        [EnumMember(Value = "LOGISTYX_TRANSGROUP")]
        LogistyxTransgroup,

        /// <summary>
        /// WestbankCourier.
        /// </summary>
        [EnumMember(Value = "WESTBANK_COURIER")]
        WestbankCourier,

        /// <summary>
        /// ArcoSpedizioni.
        /// </summary>
        [EnumMember(Value = "ARCO_SPEDIZIONI")]
        ArcoSpedizioni,

        /// <summary>
        /// YdhExpress.
        /// </summary>
        [EnumMember(Value = "YDH_EXPRESS")]
        YdhExpress,

        /// <summary>
        /// Parcelinklogistics.
        /// </summary>
        [EnumMember(Value = "PARCELINKLOGISTICS")]
        Parcelinklogistics,

        /// <summary>
        /// Cndexpress.
        /// </summary>
        [EnumMember(Value = "CNDEXPRESS")]
        Cndexpress,

        /// <summary>
        /// NoxNightTimeExpress.
        /// </summary>
        [EnumMember(Value = "NOX_NIGHT_TIME_EXPRESS")]
        NoxNightTimeExpress,

        /// <summary>
        /// Aeronet.
        /// </summary>
        [EnumMember(Value = "AERONET")]
        Aeronet,

        /// <summary>
        /// Ltianexp.
        /// </summary>
        [EnumMember(Value = "LTIANEXP")]
        Ltianexp,

        /// <summary>
        /// Integra2Ftp.
        /// </summary>
        [EnumMember(Value = "INTEGRA2_FTP")]
        Integra2Ftp,

        /// <summary>
        /// Parcelone.
        /// </summary>
        [EnumMember(Value = "PARCELONE")]
        Parcelone,

        /// <summary>
        /// NoxNachtexpress.
        /// </summary>
        [EnumMember(Value = "NOX_NACHTEXPRESS")]
        NoxNachtexpress,

        /// <summary>
        /// CnChinaPostEms.
        /// </summary>
        [EnumMember(Value = "CN_CHINA_POST_EMS")]
        CnChinaPostEms,

        /// <summary>
        /// Chukou1.
        /// </summary>
        [EnumMember(Value = "CHUKOU1")]
        Chukou1,

        /// <summary>
        /// GlsSlov.
        /// </summary>
        [EnumMember(Value = "GLS_SLOV")]
        GlsSlov,

        /// <summary>
        /// OrangeDs.
        /// </summary>
        [EnumMember(Value = "ORANGE_DS")]
        OrangeDs,

        /// <summary>
        /// JoomLogis.
        /// </summary>
        [EnumMember(Value = "JOOM_LOGIS")]
        JoomLogis,

        /// <summary>
        /// AusStartrack.
        /// </summary>
        [EnumMember(Value = "AUS_STARTRACK")]
        AusStartrack,

        /// <summary>
        /// Dhl.
        /// </summary>
        [EnumMember(Value = "DHL")]
        Dhl,

        /// <summary>
        /// GbApc.
        /// </summary>
        [EnumMember(Value = "GB_APC")]
        GbApc,

        /// <summary>
        /// Bondscouriers.
        /// </summary>
        [EnumMember(Value = "BONDSCOURIERS")]
        Bondscouriers,

        /// <summary>
        /// JpnJapanPost.
        /// </summary>
        [EnumMember(Value = "JPN_JAPAN_POST")]
        JpnJapanPost,

        /// <summary>
        /// Usps.
        /// </summary>
        [EnumMember(Value = "USPS")]
        Usps,

        /// <summary>
        /// Winit.
        /// </summary>
        [EnumMember(Value = "WINIT")]
        Winit,

        /// <summary>
        /// ArgOca.
        /// </summary>
        [EnumMember(Value = "ARG_OCA")]
        ArgOca,

        /// <summary>
        /// TwTaiwanPost.
        /// </summary>
        [EnumMember(Value = "TW_TAIWAN_POST")]
        TwTaiwanPost,

        /// <summary>
        /// DmmNetwork.
        /// </summary>
        [EnumMember(Value = "DMM_NETWORK")]
        DmmNetwork,

        /// <summary>
        /// Tnt.
        /// </summary>
        [EnumMember(Value = "TNT")]
        Tnt,

        /// <summary>
        /// BhPosta.
        /// </summary>
        [EnumMember(Value = "BH_POSTA")]
        BhPosta,

        /// <summary>
        /// SwePostnord.
        /// </summary>
        [EnumMember(Value = "SWE_POSTNORD")]
        SwePostnord,

        /// <summary>
        /// CaCanadaPost.
        /// </summary>
        [EnumMember(Value = "CA_CANADA_POST")]
        CaCanadaPost,

        /// <summary>
        /// Wiseloads.
        /// </summary>
        [EnumMember(Value = "WISELOADS")]
        Wiseloads,

        /// <summary>
        /// AsendiaHk.
        /// </summary>
        [EnumMember(Value = "ASENDIA_HK")]
        AsendiaHk,

        /// <summary>
        /// NldGls.
        /// </summary>
        [EnumMember(Value = "NLD_GLS")]
        NldGls,

        /// <summary>
        /// MexRedpack.
        /// </summary>
        [EnumMember(Value = "MEX_REDPACK")]
        MexRedpack,

        /// <summary>
        /// JetShip.
        /// </summary>
        [EnumMember(Value = "JET_SHIP")]
        JetShip,

        /// <summary>
        /// DeDhlExpress.
        /// </summary>
        [EnumMember(Value = "DE_DHL_EXPRESS")]
        DeDhlExpress,

        /// <summary>
        /// NinjavanThai.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_THAI")]
        NinjavanThai,

        /// <summary>
        /// RabenGroup.
        /// </summary>
        [EnumMember(Value = "RABEN_GROUP")]
        RabenGroup,

        /// <summary>
        /// EspAsm.
        /// </summary>
        [EnumMember(Value = "ESP_ASM")]
        EspAsm,

        /// <summary>
        /// HrvHrvatska.
        /// </summary>
        [EnumMember(Value = "HRV_HRVATSKA")]
        HrvHrvatska,

        /// <summary>
        /// GlobalEstes.
        /// </summary>
        [EnumMember(Value = "GLOBAL_ESTES")]
        GlobalEstes,

        /// <summary>
        /// LtuLietuvos.
        /// </summary>
        [EnumMember(Value = "LTU_LIETUVOS")]
        LtuLietuvos,

        /// <summary>
        /// BelDhl.
        /// </summary>
        [EnumMember(Value = "BEL_DHL")]
        BelDhl,

        /// <summary>
        /// AuAuPost.
        /// </summary>
        [EnumMember(Value = "AU_AU_POST")]
        AuAuPost,

        /// <summary>
        /// Speedexcourier.
        /// </summary>
        [EnumMember(Value = "SPEEDEXCOURIER")]
        Speedexcourier,

        /// <summary>
        /// FrColis.
        /// </summary>
        [EnumMember(Value = "FR_COLIS")]
        FrColis,

        /// <summary>
        /// Aramex.
        /// </summary>
        [EnumMember(Value = "ARAMEX")]
        Aramex,

        /// <summary>
        /// Dpex.
        /// </summary>
        [EnumMember(Value = "DPEX")]
        Dpex,

        /// <summary>
        /// MysAirpak.
        /// </summary>
        [EnumMember(Value = "MYS_AIRPAK")]
        MysAirpak,

        /// <summary>
        /// Cuckooexpress.
        /// </summary>
        [EnumMember(Value = "CUCKOOEXPRESS")]
        Cuckooexpress,

        /// <summary>
        /// DpdPoland.
        /// </summary>
        [EnumMember(Value = "DPD_POLAND")]
        DpdPoland,

        /// <summary>
        /// NldPostnl.
        /// </summary>
        [EnumMember(Value = "NLD_POSTNL")]
        NldPostnl,

        /// <summary>
        /// NimExpress.
        /// </summary>
        [EnumMember(Value = "NIM_EXPRESS")]
        NimExpress,

        /// <summary>
        /// Quantium.
        /// </summary>
        [EnumMember(Value = "QUANTIUM")]
        Quantium,

        /// <summary>
        /// Sendle.
        /// </summary>
        [EnumMember(Value = "SENDLE")]
        Sendle,

        /// <summary>
        /// EspRedur.
        /// </summary>
        [EnumMember(Value = "ESP_REDUR")]
        EspRedur,

        /// <summary>
        /// Matkahuolto.
        /// </summary>
        [EnumMember(Value = "MATKAHUOLTO")]
        Matkahuolto,

        /// <summary>
        /// Cpacket.
        /// </summary>
        [EnumMember(Value = "CPACKET")]
        Cpacket,

        /// <summary>
        /// Posti.
        /// </summary>
        [EnumMember(Value = "POSTI")]
        Posti,

        /// <summary>
        /// HunterExpress.
        /// </summary>
        [EnumMember(Value = "HUNTER_EXPRESS")]
        HunterExpress,

        /// <summary>
        /// ChoirExp.
        /// </summary>
        [EnumMember(Value = "CHOIR_EXP")]
        ChoirExp,

        /// <summary>
        /// LegionExpress.
        /// </summary>
        [EnumMember(Value = "LEGION_EXPRESS")]
        LegionExpress,

        /// <summary>
        /// AustrianPostExpress.
        /// </summary>
        [EnumMember(Value = "AUSTRIAN_POST_EXPRESS")]
        AustrianPostExpress,

        /// <summary>
        /// Grupo.
        /// </summary>
        [EnumMember(Value = "GRUPO")]
        Grupo,

        /// <summary>
        /// PostaRo.
        /// </summary>
        [EnumMember(Value = "POSTA_RO")]
        PostaRo,

        /// <summary>
        /// InterparcelUk.
        /// </summary>
        [EnumMember(Value = "INTERPARCEL_UK")]
        InterparcelUk,

        /// <summary>
        /// GlobalAbf.
        /// </summary>
        [EnumMember(Value = "GLOBAL_ABF")]
        GlobalAbf,

        /// <summary>
        /// PostenNorge.
        /// </summary>
        [EnumMember(Value = "POSTEN_NORGE")]
        PostenNorge,

        /// <summary>
        /// XpertDelivery.
        /// </summary>
        [EnumMember(Value = "XPERT_DELIVERY")]
        XpertDelivery,

        /// <summary>
        /// DhlRefr.
        /// </summary>
        [EnumMember(Value = "DHL_REFR")]
        DhlRefr,

        /// <summary>
        /// DhlHk.
        /// </summary>
        [EnumMember(Value = "DHL_HK")]
        DhlHk,

        /// <summary>
        /// SkynetUae.
        /// </summary>
        [EnumMember(Value = "SKYNET_UAE")]
        SkynetUae,

        /// <summary>
        /// Gojek.
        /// </summary>
        [EnumMember(Value = "GOJEK")]
        Gojek,

        /// <summary>
        /// YodelIntnl.
        /// </summary>
        [EnumMember(Value = "YODEL_INTNL")]
        YodelIntnl,

        /// <summary>
        /// Janco.
        /// </summary>
        [EnumMember(Value = "JANCO")]
        Janco,

        /// <summary>
        /// Yto.
        /// </summary>
        [EnumMember(Value = "YTO")]
        Yto,

        /// <summary>
        /// WiseExpress.
        /// </summary>
        [EnumMember(Value = "WISE_EXPRESS")]
        WiseExpress,

        /// <summary>
        /// JtexpressVn.
        /// </summary>
        [EnumMember(Value = "JTEXPRESS_VN")]
        JtexpressVn,

        /// <summary>
        /// FedexIntlMlserv.
        /// </summary>
        [EnumMember(Value = "FEDEX_INTL_MLSERV")]
        FedexIntlMlserv,

        /// <summary>
        /// Vamox.
        /// </summary>
        [EnumMember(Value = "VAMOX")]
        Vamox,

        /// <summary>
        /// AmsGrp.
        /// </summary>
        [EnumMember(Value = "AMS_GRP")]
        AmsGrp,

        /// <summary>
        /// DhlJp.
        /// </summary>
        [EnumMember(Value = "DHL_JP")]
        DhlJp,

        /// <summary>
        /// Hrparcel.
        /// </summary>
        [EnumMember(Value = "HRPARCEL")]
        Hrparcel,

        /// <summary>
        /// Geswl.
        /// </summary>
        [EnumMember(Value = "GESWL")]
        Geswl,

        /// <summary>
        /// Bluestar.
        /// </summary>
        [EnumMember(Value = "BLUESTAR")]
        Bluestar,

        /// <summary>
        /// CdekTr.
        /// </summary>
        [EnumMember(Value = "CDEK_TR")]
        CdekTr,

        /// <summary>
        /// Descartes.
        /// </summary>
        [EnumMember(Value = "DESCARTES")]
        Descartes,

        /// <summary>
        /// DeltecUk.
        /// </summary>
        [EnumMember(Value = "DELTEC_UK")]
        DeltecUk,

        /// <summary>
        /// DtdcExpress.
        /// </summary>
        [EnumMember(Value = "DTDC_EXPRESS")]
        DtdcExpress,

        /// <summary>
        /// Tourline.
        /// </summary>
        [EnumMember(Value = "TOURLINE")]
        Tourline,

        /// <summary>
        /// BhWorldwide.
        /// </summary>
        [EnumMember(Value = "BH_WORLDWIDE")]
        BhWorldwide,

        /// <summary>
        /// Ocs.
        /// </summary>
        [EnumMember(Value = "OCS")]
        Ocs,

        /// <summary>
        /// YingnuoLogistics.
        /// </summary>
        [EnumMember(Value = "YINGNUO_LOGISTICS")]
        YingnuoLogistics,

        /// <summary>
        /// Ups.
        /// </summary>
        [EnumMember(Value = "UPS")]
        Ups,

        /// <summary>
        /// Toll.
        /// </summary>
        [EnumMember(Value = "TOLL")]
        Toll,

        /// <summary>
        /// PrtSeur.
        /// </summary>
        [EnumMember(Value = "PRT_SEUR")]
        PrtSeur,

        /// <summary>
        /// DtdcAu.
        /// </summary>
        [EnumMember(Value = "DTDC_AU")]
        DtdcAu,

        /// <summary>
        /// ThaDynamicLogistics.
        /// </summary>
        [EnumMember(Value = "THA_DYNAMIC_LOGISTICS")]
        ThaDynamicLogistics,

        /// <summary>
        /// UbiLogistics.
        /// </summary>
        [EnumMember(Value = "UBI_LOGISTICS")]
        UbiLogistics,

        /// <summary>
        /// FedexCrossborder.
        /// </summary>
        [EnumMember(Value = "FEDEX_CROSSBORDER")]
        FedexCrossborder,

        /// <summary>
        /// A1Post.
        /// </summary>
        [EnumMember(Value = "A1POST")]
        A1Post,

        /// <summary>
        /// TazmanianFreight.
        /// </summary>
        [EnumMember(Value = "TAZMANIAN_FREIGHT")]
        TazmanianFreight,

        /// <summary>
        /// CjIntMy.
        /// </summary>
        [EnumMember(Value = "CJ_INT_MY")]
        CjIntMy,

        /// <summary>
        /// SaiaFreight.
        /// </summary>
        [EnumMember(Value = "SAIA_FREIGHT")]
        SaiaFreight,

        /// <summary>
        /// SgQxpress.
        /// </summary>
        [EnumMember(Value = "SG_QXPRESS")]
        SgQxpress,

        /// <summary>
        /// NhansSolutions.
        /// </summary>
        [EnumMember(Value = "NHANS_SOLUTIONS")]
        NhansSolutions,

        /// <summary>
        /// DpdFr.
        /// </summary>
        [EnumMember(Value = "DPD_FR")]
        DpdFr,

        /// <summary>
        /// Coordinadora.
        /// </summary>
        [EnumMember(Value = "COORDINADORA")]
        Coordinadora,

        /// <summary>
        /// Andreani.
        /// </summary>
        [EnumMember(Value = "ANDREANI")]
        Andreani,

        /// <summary>
        /// Doora.
        /// </summary>
        [EnumMember(Value = "DOORA")]
        Doora,

        /// <summary>
        /// InterparcelNz.
        /// </summary>
        [EnumMember(Value = "INTERPARCEL_NZ")]
        InterparcelNz,

        /// <summary>
        /// PhlJamexpress.
        /// </summary>
        [EnumMember(Value = "PHL_JAMEXPRESS")]
        PhlJamexpress,

        /// <summary>
        /// BelBelgiumPost.
        /// </summary>
        [EnumMember(Value = "BEL_BELGIUM_POST")]
        BelBelgiumPost,

        /// <summary>
        /// UsApc.
        /// </summary>
        [EnumMember(Value = "US_APC")]
        UsApc,

        /// <summary>
        /// IdnPos.
        /// </summary>
        [EnumMember(Value = "IDN_POS")]
        IdnPos,

        /// <summary>
        /// FrMondial.
        /// </summary>
        [EnumMember(Value = "FR_MONDIAL")]
        FrMondial,

        /// <summary>
        /// DeDhl.
        /// </summary>
        [EnumMember(Value = "DE_DHL")]
        DeDhl,

        /// <summary>
        /// HkRpx.
        /// </summary>
        [EnumMember(Value = "HK_RPX")]
        HkRpx,

        /// <summary>
        /// DhlPieceid.
        /// </summary>
        [EnumMember(Value = "DHL_PIECEID")]
        DhlPieceid,

        /// <summary>
        /// VnpostEms.
        /// </summary>
        [EnumMember(Value = "VNPOST_EMS")]
        VnpostEms,

        /// <summary>
        /// Rrdonnelley.
        /// </summary>
        [EnumMember(Value = "RRDONNELLEY")]
        Rrdonnelley,

        /// <summary>
        /// DpdDe.
        /// </summary>
        [EnumMember(Value = "DPD_DE")]
        DpdDe,

        /// <summary>
        /// DelcartIn.
        /// </summary>
        [EnumMember(Value = "DELCART_IN")]
        DelcartIn,

        /// <summary>
        /// Imexglobalsolutions.
        /// </summary>
        [EnumMember(Value = "IMEXGLOBALSOLUTIONS")]
        Imexglobalsolutions,

        /// <summary>
        /// Acommerce.
        /// </summary>
        [EnumMember(Value = "ACOMMERCE")]
        Acommerce,

        /// <summary>
        /// Eurodis.
        /// </summary>
        [EnumMember(Value = "EURODIS")]
        Eurodis,

        /// <summary>
        /// Canpar.
        /// </summary>
        [EnumMember(Value = "CANPAR")]
        Canpar,

        /// <summary>
        /// Gls.
        /// </summary>
        [EnumMember(Value = "GLS")]
        Gls,

        /// <summary>
        /// IndEcom.
        /// </summary>
        [EnumMember(Value = "IND_ECOM")]
        IndEcom,

        /// <summary>
        /// EspEnvialia.
        /// </summary>
        [EnumMember(Value = "ESP_ENVIALIA")]
        EspEnvialia,

        /// <summary>
        /// DhlUk.
        /// </summary>
        [EnumMember(Value = "DHL_UK")]
        DhlUk,

        /// <summary>
        /// SmsaExpress.
        /// </summary>
        [EnumMember(Value = "SMSA_EXPRESS")]
        SmsaExpress,

        /// <summary>
        /// TntFr.
        /// </summary>
        [EnumMember(Value = "TNT_FR")]
        TntFr,

        /// <summary>
        /// DexI.
        /// </summary>
        [EnumMember(Value = "DEX_I")]
        DexI,

        /// <summary>
        /// BudbeeWebhook.
        /// </summary>
        [EnumMember(Value = "BUDBEE_WEBHOOK")]
        BudbeeWebhook,

        /// <summary>
        /// CopaCourier.
        /// </summary>
        [EnumMember(Value = "COPA_COURIER")]
        CopaCourier,

        /// <summary>
        /// VnmVietnamPost.
        /// </summary>
        [EnumMember(Value = "VNM_VIETNAM_POST")]
        VnmVietnamPost,

        /// <summary>
        /// DpdHk.
        /// </summary>
        [EnumMember(Value = "DPD_HK")]
        DpdHk,

        /// <summary>
        /// TollNz.
        /// </summary>
        [EnumMember(Value = "TOLL_NZ")]
        TollNz,

        /// <summary>
        /// Echo.
        /// </summary>
        [EnumMember(Value = "ECHO")]
        Echo,

        /// <summary>
        /// FedexFr.
        /// </summary>
        [EnumMember(Value = "FEDEX_FR")]
        FedexFr,

        /// <summary>
        /// Borderexpress.
        /// </summary>
        [EnumMember(Value = "BORDEREXPRESS")]
        Borderexpress,

        /// <summary>
        /// MailplusJpn.
        /// </summary>
        [EnumMember(Value = "MAILPLUS_JPN")]
        MailplusJpn,

        /// <summary>
        /// TntUkRefr.
        /// </summary>
        [EnumMember(Value = "TNT_UK_REFR")]
        TntUkRefr,

        /// <summary>
        /// Kec.
        /// </summary>
        [EnumMember(Value = "KEC")]
        Kec,

        /// <summary>
        /// DpdRo.
        /// </summary>
        [EnumMember(Value = "DPD_RO")]
        DpdRo,

        /// <summary>
        /// TntJp.
        /// </summary>
        [EnumMember(Value = "TNT_JP")]
        TntJp,

        /// <summary>
        /// ThCj.
        /// </summary>
        [EnumMember(Value = "TH_CJ")]
        ThCj,

        /// <summary>
        /// EcCn.
        /// </summary>
        [EnumMember(Value = "EC_CN")]
        EcCn,

        /// <summary>
        /// FastwayUk.
        /// </summary>
        [EnumMember(Value = "FASTWAY_UK")]
        FastwayUk,

        /// <summary>
        /// FastwayUs.
        /// </summary>
        [EnumMember(Value = "FASTWAY_US")]
        FastwayUs,

        /// <summary>
        /// GlsDe.
        /// </summary>
        [EnumMember(Value = "GLS_DE")]
        GlsDe,

        /// <summary>
        /// GlsEs.
        /// </summary>
        [EnumMember(Value = "GLS_ES")]
        GlsEs,

        /// <summary>
        /// GlsFr.
        /// </summary>
        [EnumMember(Value = "GLS_FR")]
        GlsFr,

        /// <summary>
        /// MondialBe.
        /// </summary>
        [EnumMember(Value = "MONDIAL_BE")]
        MondialBe,

        /// <summary>
        /// SgtIt.
        /// </summary>
        [EnumMember(Value = "SGT_IT")]
        SgtIt,

        /// <summary>
        /// TntCn.
        /// </summary>
        [EnumMember(Value = "TNT_CN")]
        TntCn,

        /// <summary>
        /// TntDe.
        /// </summary>
        [EnumMember(Value = "TNT_DE")]
        TntDe,

        /// <summary>
        /// TntEs.
        /// </summary>
        [EnumMember(Value = "TNT_ES")]
        TntEs,

        /// <summary>
        /// TntPl.
        /// </summary>
        [EnumMember(Value = "TNT_PL")]
        TntPl,

        /// <summary>
        /// Parcelforce.
        /// </summary>
        [EnumMember(Value = "PARCELFORCE")]
        Parcelforce,

        /// <summary>
        /// SwissPost.
        /// </summary>
        [EnumMember(Value = "SWISS_POST")]
        SwissPost,

        /// <summary>
        /// TollIpec.
        /// </summary>
        [EnumMember(Value = "TOLL_IPEC")]
        TollIpec,

        /// <summary>
        /// Air21.
        /// </summary>
        [EnumMember(Value = "AIR_21")]
        Air21,

        /// <summary>
        /// Airspeed.
        /// </summary>
        [EnumMember(Value = "AIRSPEED")]
        Airspeed,

        /// <summary>
        /// Bert.
        /// </summary>
        [EnumMember(Value = "BERT")]
        Bert,

        /// <summary>
        /// Bluedart.
        /// </summary>
        [EnumMember(Value = "BLUEDART")]
        Bluedart,

        /// <summary>
        /// Collectplus.
        /// </summary>
        [EnumMember(Value = "COLLECTPLUS")]
        Collectplus,

        /// <summary>
        /// Courierplus.
        /// </summary>
        [EnumMember(Value = "COURIERPLUS")]
        Courierplus,

        /// <summary>
        /// CourierPost.
        /// </summary>
        [EnumMember(Value = "COURIER_POST")]
        CourierPost,

        /// <summary>
        /// DhlGlobalMail.
        /// </summary>
        [EnumMember(Value = "DHL_GLOBAL_MAIL")]
        DhlGlobalMail,

        /// <summary>
        /// DpdUk.
        /// </summary>
        [EnumMember(Value = "DPD_UK")]
        DpdUk,

        /// <summary>
        /// DeltecDe.
        /// </summary>
        [EnumMember(Value = "DELTEC_DE")]
        DeltecDe,

        /// <summary>
        /// DeutscheDe.
        /// </summary>
        [EnumMember(Value = "DEUTSCHE_DE")]
        DeutscheDe,

        /// <summary>
        /// Dotzot.
        /// </summary>
        [EnumMember(Value = "DOTZOT")]
        Dotzot,

        /// <summary>
        /// EltaGr.
        /// </summary>
        [EnumMember(Value = "ELTA_GR")]
        EltaGr,

        /// <summary>
        /// EmsCn.
        /// </summary>
        [EnumMember(Value = "EMS_CN")]
        EmsCn,

        /// <summary>
        /// Ecargo.
        /// </summary>
        [EnumMember(Value = "ECARGO")]
        Ecargo,

        /// <summary>
        /// Ensenda.
        /// </summary>
        [EnumMember(Value = "ENSENDA")]
        Ensenda,

        /// <summary>
        /// FercamIt.
        /// </summary>
        [EnumMember(Value = "FERCAM_IT")]
        FercamIt,

        /// <summary>
        /// FastwayZa.
        /// </summary>
        [EnumMember(Value = "FASTWAY_ZA")]
        FastwayZa,

        /// <summary>
        /// FastwayAu.
        /// </summary>
        [EnumMember(Value = "FASTWAY_AU")]
        FastwayAu,

        /// <summary>
        /// FirstLogisitcs.
        /// </summary>
        [EnumMember(Value = "FIRST_LOGISITCS")]
        FirstLogisitcs,

        /// <summary>
        /// Geodis.
        /// </summary>
        [EnumMember(Value = "GEODIS")]
        Geodis,

        /// <summary>
        /// Globegistics.
        /// </summary>
        [EnumMember(Value = "GLOBEGISTICS")]
        Globegistics,

        /// <summary>
        /// Greyhound.
        /// </summary>
        [EnumMember(Value = "GREYHOUND")]
        Greyhound,

        /// <summary>
        /// JetshipMy.
        /// </summary>
        [EnumMember(Value = "JETSHIP_MY")]
        JetshipMy,

        /// <summary>
        /// LionParcel.
        /// </summary>
        [EnumMember(Value = "LION_PARCEL")]
        LionParcel,

        /// <summary>
        /// Aeroflash.
        /// </summary>
        [EnumMember(Value = "AEROFLASH")]
        Aeroflash,

        /// <summary>
        /// Ontrac.
        /// </summary>
        [EnumMember(Value = "ONTRAC")]
        Ontrac,

        /// <summary>
        /// Sagawa.
        /// </summary>
        [EnumMember(Value = "SAGAWA")]
        Sagawa,

        /// <summary>
        /// Siodemka.
        /// </summary>
        [EnumMember(Value = "SIODEMKA")]
        Siodemka,

        /// <summary>
        /// Startrack.
        /// </summary>
        [EnumMember(Value = "STARTRACK")]
        Startrack,

        /// <summary>
        /// TntAu.
        /// </summary>
        [EnumMember(Value = "TNT_AU")]
        TntAu,

        /// <summary>
        /// TntIt.
        /// </summary>
        [EnumMember(Value = "TNT_IT")]
        TntIt,

        /// <summary>
        /// Transmission.
        /// </summary>
        [EnumMember(Value = "TRANSMISSION")]
        Transmission,

        /// <summary>
        /// Yamato.
        /// </summary>
        [EnumMember(Value = "YAMATO")]
        Yamato,

        /// <summary>
        /// DhlIt.
        /// </summary>
        [EnumMember(Value = "DHL_IT")]
        DhlIt,

        /// <summary>
        /// DhlAt.
        /// </summary>
        [EnumMember(Value = "DHL_AT")]
        DhlAt,

        /// <summary>
        /// LogisticsworldwideKr.
        /// </summary>
        [EnumMember(Value = "LOGISTICSWORLDWIDE_KR")]
        LogisticsworldwideKr,

        /// <summary>
        /// GlsSpain.
        /// </summary>
        [EnumMember(Value = "GLS_SPAIN")]
        GlsSpain,

        /// <summary>
        /// AmazonUkApi.
        /// </summary>
        [EnumMember(Value = "AMAZON_UK_API")]
        AmazonUkApi,

        /// <summary>
        /// DpdFrReference.
        /// </summary>
        [EnumMember(Value = "DPD_FR_REFERENCE")]
        DpdFrReference,

        /// <summary>
        /// DhlparcelUk.
        /// </summary>
        [EnumMember(Value = "DHLPARCEL_UK")]
        DhlparcelUk,

        /// <summary>
        /// Megasave.
        /// </summary>
        [EnumMember(Value = "MEGASAVE")]
        Megasave,

        /// <summary>
        /// Qualitypost.
        /// </summary>
        [EnumMember(Value = "QUALITYPOST")]
        Qualitypost,

        /// <summary>
        /// IdsLogistics.
        /// </summary>
        [EnumMember(Value = "IDS_LOGISTICS")]
        IdsLogistics,

        /// <summary>
        /// Joyingbox1.
        /// </summary>
        [EnumMember(Value = "JOYINGBOX")]
        Joyingbox1,

        /// <summary>
        /// PantherOrderNumber.
        /// </summary>
        [EnumMember(Value = "PANTHER_ORDER_NUMBER")]
        PantherOrderNumber,

        /// <summary>
        /// WatkinsShepard.
        /// </summary>
        [EnumMember(Value = "WATKINS_SHEPARD")]
        WatkinsShepard,

        /// <summary>
        /// Fasttrack.
        /// </summary>
        [EnumMember(Value = "FASTTRACK")]
        Fasttrack,

        /// <summary>
        /// UpExpress.
        /// </summary>
        [EnumMember(Value = "UP_EXPRESS")]
        UpExpress,

        /// <summary>
        /// Elogistica.
        /// </summary>
        [EnumMember(Value = "ELOGISTICA")]
        Elogistica,

        /// <summary>
        /// Ecourier.
        /// </summary>
        [EnumMember(Value = "ECOURIER")]
        Ecourier,

        /// <summary>
        /// CjPhilippines.
        /// </summary>
        [EnumMember(Value = "CJ_PHILIPPINES")]
        CjPhilippines,

        /// <summary>
        /// Speedex.
        /// </summary>
        [EnumMember(Value = "SPEEDEX")]
        Speedex,

        /// <summary>
        /// Orangeconnex.
        /// </summary>
        [EnumMember(Value = "ORANGECONNEX")]
        Orangeconnex,

        /// <summary>
        /// Tecor.
        /// </summary>
        [EnumMember(Value = "TECOR")]
        Tecor,

        /// <summary>
        /// Saee.
        /// </summary>
        [EnumMember(Value = "SAEE")]
        Saee,

        /// <summary>
        /// GlsItalyFtp.
        /// </summary>
        [EnumMember(Value = "GLS_ITALY_FTP")]
        GlsItalyFtp,

        /// <summary>
        /// Delivere.
        /// </summary>
        [EnumMember(Value = "DELIVERE")]
        Delivere,

        /// <summary>
        /// Yycom.
        /// </summary>
        [EnumMember(Value = "YYCOM")]
        Yycom,

        /// <summary>
        /// AdicionalPt.
        /// </summary>
        [EnumMember(Value = "ADICIONAL_PT")]
        AdicionalPt,

        /// <summary>
        /// Dksh.
        /// </summary>
        [EnumMember(Value = "DKSH")]
        Dksh,

        /// <summary>
        /// NipponExpressFtp.
        /// </summary>
        [EnumMember(Value = "NIPPON_EXPRESS_FTP")]
        NipponExpressFtp,

        /// <summary>
        /// Gols.
        /// </summary>
        [EnumMember(Value = "GOLS")]
        Gols,

        /// <summary>
        /// Fujexp.
        /// </summary>
        [EnumMember(Value = "FUJEXP")]
        Fujexp,

        /// <summary>
        /// Qtrack.
        /// </summary>
        [EnumMember(Value = "QTRACK")]
        Qtrack,

        /// <summary>
        /// OmlogisticsApi.
        /// </summary>
        [EnumMember(Value = "OMLOGISTICS_API")]
        OmlogisticsApi,

        /// <summary>
        /// Gdpharm.
        /// </summary>
        [EnumMember(Value = "GDPHARM")]
        Gdpharm,

        /// <summary>
        /// MisumiCn.
        /// </summary>
        [EnumMember(Value = "MISUMI_CN")]
        MisumiCn,

        /// <summary>
        /// AirCanada.
        /// </summary>
        [EnumMember(Value = "AIR_CANADA")]
        AirCanada,

        /// <summary>
        /// City56Webhook.
        /// </summary>
        [EnumMember(Value = "CITY56_WEBHOOK")]
        City56Webhook,

        /// <summary>
        /// SagawaApi.
        /// </summary>
        [EnumMember(Value = "SAGAWA_API")]
        SagawaApi,

        /// <summary>
        /// Kedaex.
        /// </summary>
        [EnumMember(Value = "KEDAEX")]
        Kedaex,

        /// <summary>
        /// PgeonApi.
        /// </summary>
        [EnumMember(Value = "PGEON_API")]
        PgeonApi,

        /// <summary>
        /// Weworldexpress.
        /// </summary>
        [EnumMember(Value = "WEWORLDEXPRESS")]
        Weworldexpress,

        /// <summary>
        /// JtLogistics.
        /// </summary>
        [EnumMember(Value = "JT_LOGISTICS")]
        JtLogistics,

        /// <summary>
        /// Trusk.
        /// </summary>
        [EnumMember(Value = "TRUSK")]
        Trusk,

        /// <summary>
        /// Viaxpress.
        /// </summary>
        [EnumMember(Value = "VIAXPRESS")]
        Viaxpress,

        /// <summary>
        /// DhlSupplychainId.
        /// </summary>
        [EnumMember(Value = "DHL_SUPPLYCHAIN_ID")]
        DhlSupplychainId,

        /// <summary>
        /// ZuelligpharmaSftp.
        /// </summary>
        [EnumMember(Value = "ZUELLIGPHARMA_SFTP")]
        ZuelligpharmaSftp,

        /// <summary>
        /// Meest.
        /// </summary>
        [EnumMember(Value = "MEEST")]
        Meest,

        /// <summary>
        /// TollPriority.
        /// </summary>
        [EnumMember(Value = "TOLL_PRIORITY")]
        TollPriority,

        /// <summary>
        /// MothershipApi.
        /// </summary>
        [EnumMember(Value = "MOTHERSHIP_API")]
        MothershipApi,

        /// <summary>
        /// Capital.
        /// </summary>
        [EnumMember(Value = "CAPITAL")]
        Capital,

        /// <summary>
        /// EuropaketApi.
        /// </summary>
        [EnumMember(Value = "EUROPAKET_API")]
        EuropaketApi,

        /// <summary>
        /// Hfd.
        /// </summary>
        [EnumMember(Value = "HFD")]
        Hfd,

        /// <summary>
        /// TourlineReference.
        /// </summary>
        [EnumMember(Value = "TOURLINE_REFERENCE")]
        TourlineReference,

        /// <summary>
        /// GioEcourier.
        /// </summary>
        [EnumMember(Value = "GIO_ECOURIER")]
        GioEcourier,

        /// <summary>
        /// CnLogistics.
        /// </summary>
        [EnumMember(Value = "CN_LOGISTICS")]
        CnLogistics,

        /// <summary>
        /// Pandion.
        /// </summary>
        [EnumMember(Value = "PANDION")]
        Pandion,

        /// <summary>
        /// BpostApi.
        /// </summary>
        [EnumMember(Value = "BPOST_API")]
        BpostApi,

        /// <summary>
        /// Passportshipping.
        /// </summary>
        [EnumMember(Value = "PASSPORTSHIPPING")]
        Passportshipping,

        /// <summary>
        /// Pakajo.
        /// </summary>
        [EnumMember(Value = "PAKAJO")]
        Pakajo,

        /// <summary>
        /// Dachser.
        /// </summary>
        [EnumMember(Value = "DACHSER")]
        Dachser,

        /// <summary>
        /// YusenSftp.
        /// </summary>
        [EnumMember(Value = "YUSEN_SFTP")]
        YusenSftp,

        /// <summary>
        /// Shyplite.
        /// </summary>
        [EnumMember(Value = "SHYPLITE")]
        Shyplite,

        /// <summary>
        /// Xyy.
        /// </summary>
        [EnumMember(Value = "XYY")]
        Xyy,

        /// <summary>
        /// Mwd.
        /// </summary>
        [EnumMember(Value = "MWD")]
        Mwd,

        /// <summary>
        /// Faxecargo.
        /// </summary>
        [EnumMember(Value = "FAXECARGO")]
        Faxecargo,

        /// <summary>
        /// Mazet.
        /// </summary>
        [EnumMember(Value = "MAZET")]
        Mazet,

        /// <summary>
        /// FirstLogisticsApi.
        /// </summary>
        [EnumMember(Value = "FIRST_LOGISTICS_API")]
        FirstLogisticsApi,

        /// <summary>
        /// SprintPack.
        /// </summary>
        [EnumMember(Value = "SPRINT_PACK")]
        SprintPack,

        /// <summary>
        /// HermesDeFtp.
        /// </summary>
        [EnumMember(Value = "HERMES_DE_FTP")]
        HermesDeFtp,

        /// <summary>
        /// Concise.
        /// </summary>
        [EnumMember(Value = "CONCISE")]
        Concise,

        /// <summary>
        /// KerryExpressTwApi.
        /// </summary>
        [EnumMember(Value = "KERRY_EXPRESS_TW_API")]
        KerryExpressTwApi,

        /// <summary>
        /// Ewe.
        /// </summary>
        [EnumMember(Value = "EWE")]
        Ewe,

        /// <summary>
        /// Fastdespatch.
        /// </summary>
        [EnumMember(Value = "FASTDESPATCH")]
        Fastdespatch,

        /// <summary>
        /// AbcustomSftp.
        /// </summary>
        [EnumMember(Value = "ABCUSTOM_SFTP")]
        AbcustomSftp,

        /// <summary>
        /// Chazki.
        /// </summary>
        [EnumMember(Value = "CHAZKI")]
        Chazki,

        /// <summary>
        /// Shippie.
        /// </summary>
        [EnumMember(Value = "SHIPPIE")]
        Shippie,

        /// <summary>
        /// GeodisApi.
        /// </summary>
        [EnumMember(Value = "GEODIS_API")]
        GeodisApi,

        /// <summary>
        /// NaqelExpress.
        /// </summary>
        [EnumMember(Value = "NAQEL_EXPRESS")]
        NaqelExpress,

        /// <summary>
        /// PapaWebhook.
        /// </summary>
        [EnumMember(Value = "PAPA_WEBHOOK")]
        PapaWebhook,

        /// <summary>
        /// Forwardair.
        /// </summary>
        [EnumMember(Value = "FORWARDAIR")]
        Forwardair,

        /// <summary>
        /// DialogoLogisticaApi.
        /// </summary>
        [EnumMember(Value = "DIALOGO_LOGISTICA_API")]
        DialogoLogisticaApi,

        /// <summary>
        /// LalamoveApi.
        /// </summary>
        [EnumMember(Value = "LALAMOVE_API")]
        LalamoveApi,

        /// <summary>
        /// Tomydoor.
        /// </summary>
        [EnumMember(Value = "TOMYDOOR")]
        Tomydoor,

        /// <summary>
        /// KronosWebhook.
        /// </summary>
        [EnumMember(Value = "KRONOS_WEBHOOK")]
        KronosWebhook,

        /// <summary>
        /// Jtcargo.
        /// </summary>
        [EnumMember(Value = "JTCARGO")]
        Jtcargo,

        /// <summary>
        /// TCat.
        /// </summary>
        [EnumMember(Value = "T_CAT")]
        TCat,

        /// <summary>
        /// ConciseWebhook.
        /// </summary>
        [EnumMember(Value = "CONCISE_WEBHOOK")]
        ConciseWebhook,

        /// <summary>
        /// TeleportWebhook.
        /// </summary>
        [EnumMember(Value = "TELEPORT_WEBHOOK")]
        TeleportWebhook,

        /// <summary>
        /// CustomcoApi.
        /// </summary>
        [EnumMember(Value = "CUSTOMCO_API")]
        CustomcoApi,

        /// <summary>
        /// SpxTh.
        /// </summary>
        [EnumMember(Value = "SPX_TH")]
        SpxTh,

        /// <summary>
        /// BolloreLogistics.
        /// </summary>
        [EnumMember(Value = "BOLLORE_LOGISTICS")]
        BolloreLogistics,

        /// <summary>
        /// ClicklinkSftp.
        /// </summary>
        [EnumMember(Value = "CLICKLINK_SFTP")]
        ClicklinkSftp,

        /// <summary>
        /// M3Logistics.
        /// </summary>
        [EnumMember(Value = "M3LOGISTICS")]
        M3Logistics,

        /// <summary>
        /// VnpostApi.
        /// </summary>
        [EnumMember(Value = "VNPOST_API")]
        VnpostApi,

        /// <summary>
        /// AxlehireFtp.
        /// </summary>
        [EnumMember(Value = "AXLEHIRE_FTP")]
        AxlehireFtp,

        /// <summary>
        /// Shadowfax.
        /// </summary>
        [EnumMember(Value = "SHADOWFAX")]
        Shadowfax,

        /// <summary>
        /// MyhermesUkApi.
        /// </summary>
        [EnumMember(Value = "MYHERMES_UK_API")]
        MyhermesUkApi,

        /// <summary>
        /// Daiichi.
        /// </summary>
        [EnumMember(Value = "DAIICHI")]
        Daiichi,

        /// <summary>
        /// MensajerosurbanosApi.
        /// </summary>
        [EnumMember(Value = "MENSAJEROSURBANOS_API")]
        MensajerosurbanosApi,

        /// <summary>
        /// Polarspeed.
        /// </summary>
        [EnumMember(Value = "POLARSPEED")]
        Polarspeed,

        /// <summary>
        /// IdexpressId.
        /// </summary>
        [EnumMember(Value = "IDEXPRESS_ID")]
        IdexpressId,

        /// <summary>
        /// Payo.
        /// </summary>
        [EnumMember(Value = "PAYO")]
        Payo,

        /// <summary>
        /// WhistlSftp.
        /// </summary>
        [EnumMember(Value = "WHISTL_SFTP")]
        WhistlSftp,

        /// <summary>
        /// IntexDe.
        /// </summary>
        [EnumMember(Value = "INTEX_DE")]
        IntexDe,

        /// <summary>
        /// Trans2U.
        /// </summary>
        [EnumMember(Value = "TRANS2U")]
        Trans2U,

        /// <summary>
        /// ProductcaregroupSftp.
        /// </summary>
        [EnumMember(Value = "PRODUCTCAREGROUP_SFTP")]
        ProductcaregroupSftp,

        /// <summary>
        /// Bigsmart.
        /// </summary>
        [EnumMember(Value = "BIGSMART")]
        Bigsmart,

        /// <summary>
        /// ExpeditorsApiRef.
        /// </summary>
        [EnumMember(Value = "EXPEDITORS_API_REF")]
        ExpeditorsApiRef,

        /// <summary>
        /// AitworldwideApi.
        /// </summary>
        [EnumMember(Value = "AITWORLDWIDE_API")]
        AitworldwideApi,

        /// <summary>
        /// Worldcourier.
        /// </summary>
        [EnumMember(Value = "WORLDCOURIER")]
        Worldcourier,

        /// <summary>
        /// Quiqup.
        /// </summary>
        [EnumMember(Value = "QUIQUP")]
        Quiqup,

        /// <summary>
        /// AgedissSftp.
        /// </summary>
        [EnumMember(Value = "AGEDISS_SFTP")]
        AgedissSftp,

        /// <summary>
        /// AndreaniApi.
        /// </summary>
        [EnumMember(Value = "ANDREANI_API")]
        AndreaniApi,

        /// <summary>
        /// Crlexpress.
        /// </summary>
        [EnumMember(Value = "CRLEXPRESS")]
        Crlexpress,

        /// <summary>
        /// Smartcat.
        /// </summary>
        [EnumMember(Value = "SMARTCAT")]
        Smartcat,

        /// <summary>
        /// Crossflight.
        /// </summary>
        [EnumMember(Value = "CROSSFLIGHT")]
        Crossflight,

        /// <summary>
        /// Procarrier.
        /// </summary>
        [EnumMember(Value = "PROCARRIER")]
        Procarrier,

        /// <summary>
        /// DhlReferenceApi.
        /// </summary>
        [EnumMember(Value = "DHL_REFERENCE_API")]
        DhlReferenceApi,

        /// <summary>
        /// SeinoApi.
        /// </summary>
        [EnumMember(Value = "SEINO_API")]
        SeinoApi,

        /// <summary>
        /// Wspexpress.
        /// </summary>
        [EnumMember(Value = "WSPEXPRESS")]
        Wspexpress,

        /// <summary>
        /// Kronos.
        /// </summary>
        [EnumMember(Value = "KRONOS")]
        Kronos,

        /// <summary>
        /// TotalExpressApi.
        /// </summary>
        [EnumMember(Value = "TOTAL_EXPRESS_API")]
        TotalExpressApi,

        /// <summary>
        /// Parcll.
        /// </summary>
        [EnumMember(Value = "PARCLL")]
        Parcll,

        /// <summary>
        /// Xpedigo.
        /// </summary>
        [EnumMember(Value = "XPEDIGO")]
        Xpedigo,

        /// <summary>
        /// StarTrackWebhook.
        /// </summary>
        [EnumMember(Value = "STAR_TRACK_WEBHOOK")]
        StarTrackWebhook,

        /// <summary>
        /// Gpost.
        /// </summary>
        [EnumMember(Value = "GPOST")]
        Gpost,

        /// <summary>
        /// Ucs.
        /// </summary>
        [EnumMember(Value = "UCS")]
        Ucs,

        /// <summary>
        /// Dmfgroup.
        /// </summary>
        [EnumMember(Value = "DMFGROUP")]
        Dmfgroup,

        /// <summary>
        /// CoordinadoraApi.
        /// </summary>
        [EnumMember(Value = "COORDINADORA_API")]
        CoordinadoraApi,

        /// <summary>
        /// Marken.
        /// </summary>
        [EnumMember(Value = "MARKEN")]
        Marken,

        /// <summary>
        /// Ntl.
        /// </summary>
        [EnumMember(Value = "NTL")]
        Ntl,

        /// <summary>
        /// Redjepakketje.
        /// </summary>
        [EnumMember(Value = "REDJEPAKKETJE")]
        Redjepakketje,

        /// <summary>
        /// AlliedExpressFtp.
        /// </summary>
        [EnumMember(Value = "ALLIED_EXPRESS_FTP")]
        AlliedExpressFtp,

        /// <summary>
        /// MondialrelayEs.
        /// </summary>
        [EnumMember(Value = "MONDIALRELAY_ES")]
        MondialrelayEs,

        /// <summary>
        /// NaekoFtp.
        /// </summary>
        [EnumMember(Value = "NAEKO_FTP")]
        NaekoFtp,

        /// <summary>
        /// Mhi.
        /// </summary>
        [EnumMember(Value = "MHI")]
        Mhi,

        /// <summary>
        /// Shippify.
        /// </summary>
        [EnumMember(Value = "SHIPPIFY")]
        Shippify,

        /// <summary>
        /// MalcaAmitApi.
        /// </summary>
        [EnumMember(Value = "MALCA_AMIT_API")]
        MalcaAmitApi,

        /// <summary>
        /// JtexpressSgApi.
        /// </summary>
        [EnumMember(Value = "JTEXPRESS_SG_API")]
        JtexpressSgApi,

        /// <summary>
        /// DachserWeb.
        /// </summary>
        [EnumMember(Value = "DACHSER_WEB")]
        DachserWeb,

        /// <summary>
        /// Flightlg.
        /// </summary>
        [EnumMember(Value = "FLIGHTLG")]
        Flightlg,

        /// <summary>
        /// Cago.
        /// </summary>
        [EnumMember(Value = "CAGO")]
        Cago,

        /// <summary>
        /// Com1Express.
        /// </summary>
        [EnumMember(Value = "COM1EXPRESS")]
        Com1Express,

        /// <summary>
        /// TonamiFtp.
        /// </summary>
        [EnumMember(Value = "TONAMI_FTP")]
        TonamiFtp,

        /// <summary>
        /// Packfleet.
        /// </summary>
        [EnumMember(Value = "PACKFLEET")]
        Packfleet,

        /// <summary>
        /// PurolatorInternational.
        /// </summary>
        [EnumMember(Value = "PUROLATOR_INTERNATIONAL")]
        PurolatorInternational,

        /// <summary>
        /// WineshippingWebhook.
        /// </summary>
        [EnumMember(Value = "WINESHIPPING_WEBHOOK")]
        WineshippingWebhook,

        /// <summary>
        /// DhlEsSftp.
        /// </summary>
        [EnumMember(Value = "DHL_ES_SFTP")]
        DhlEsSftp,

        /// <summary>
        /// PchomeApi.
        /// </summary>
        [EnumMember(Value = "PCHOME_API")]
        PchomeApi,

        /// <summary>
        /// CeskapostaApi.
        /// </summary>
        [EnumMember(Value = "CESKAPOSTA_API")]
        CeskapostaApi,

        /// <summary>
        /// Gorush.
        /// </summary>
        [EnumMember(Value = "GORUSH")]
        Gorush,

        /// <summary>
        /// Homerunner.
        /// </summary>
        [EnumMember(Value = "HOMERUNNER")]
        Homerunner,

        /// <summary>
        /// AmazonOrder.
        /// </summary>
        [EnumMember(Value = "AMAZON_ORDER")]
        AmazonOrder,

        /// <summary>
        /// EfwnowApi.
        /// </summary>
        [EnumMember(Value = "EFWNOW_API")]
        EfwnowApi,

        /// <summary>
        /// CblLogisticaApi.
        /// </summary>
        [EnumMember(Value = "CBL_LOGISTICA_API")]
        CblLogisticaApi,

        /// <summary>
        /// Nimbuspost.
        /// </summary>
        [EnumMember(Value = "NIMBUSPOST")]
        Nimbuspost,

        /// <summary>
        /// LogwinLogistics.
        /// </summary>
        [EnumMember(Value = "LOGWIN_LOGISTICS")]
        LogwinLogistics,

        /// <summary>
        /// NowlogApi.
        /// </summary>
        [EnumMember(Value = "NOWLOG_API")]
        NowlogApi,

        /// <summary>
        /// DpdNl.
        /// </summary>
        [EnumMember(Value = "DPD_NL")]
        DpdNl,

        /// <summary>
        /// Godependable.
        /// </summary>
        [EnumMember(Value = "GODEPENDABLE")]
        Godependable,

        /// <summary>
        /// Esdex.
        /// </summary>
        [EnumMember(Value = "ESDEX")]
        Esdex,

        /// <summary>
        /// LogisystemsSftp.
        /// </summary>
        [EnumMember(Value = "LOGISYSTEMS_SFTP")]
        LogisystemsSftp,

        /// <summary>
        /// Expeditors.
        /// </summary>
        [EnumMember(Value = "EXPEDITORS")]
        Expeditors,

        /// <summary>
        /// SntglobalApi.
        /// </summary>
        [EnumMember(Value = "SNTGLOBAL_API")]
        SntglobalApi,

        /// <summary>
        /// Shipx.
        /// </summary>
        [EnumMember(Value = "SHIPX")]
        Shipx,

        /// <summary>
        /// QintlApi.
        /// </summary>
        [EnumMember(Value = "QINTL_API")]
        QintlApi,

        /// <summary>
        /// Packs.
        /// </summary>
        [EnumMember(Value = "PACKS")]
        Packs,

        /// <summary>
        /// PostnlInternational.
        /// </summary>
        [EnumMember(Value = "POSTNL_INTERNATIONAL")]
        PostnlInternational,

        /// <summary>
        /// AmazonEmailPush.
        /// </summary>
        [EnumMember(Value = "AMAZON_EMAIL_PUSH")]
        AmazonEmailPush,

        /// <summary>
        /// DhlApi.
        /// </summary>
        [EnumMember(Value = "DHL_API")]
        DhlApi,

        /// <summary>
        /// Spx.
        /// </summary>
        [EnumMember(Value = "SPX")]
        Spx,

        /// <summary>
        /// Axlehire.
        /// </summary>
        [EnumMember(Value = "AXLEHIRE")]
        Axlehire,

        /// <summary>
        /// Icscourier.
        /// </summary>
        [EnumMember(Value = "ICSCOURIER")]
        Icscourier,

        /// <summary>
        /// DialogoLogistica.
        /// </summary>
        [EnumMember(Value = "DIALOGO_LOGISTICA")]
        DialogoLogistica,

        /// <summary>
        /// ShunbangExpress.
        /// </summary>
        [EnumMember(Value = "SHUNBANG_EXPRESS")]
        ShunbangExpress,

        /// <summary>
        /// TcsApi.
        /// </summary>
        [EnumMember(Value = "TCS_API")]
        TcsApi,

        /// <summary>
        /// SfExpressCn.
        /// </summary>
        [EnumMember(Value = "SF_EXPRESS_CN")]
        SfExpressCn,

        /// <summary>
        /// Packeta.
        /// </summary>
        [EnumMember(Value = "PACKETA")]
        Packeta,

        /// <summary>
        /// SicTeliway.
        /// </summary>
        [EnumMember(Value = "SIC_TELIWAY")]
        SicTeliway,

        /// <summary>
        /// MondialrelayFr.
        /// </summary>
        [EnumMember(Value = "MONDIALRELAY_FR")]
        MondialrelayFr,

        /// <summary>
        /// IntimeFtp.
        /// </summary>
        [EnumMember(Value = "INTIME_FTP")]
        IntimeFtp,

        /// <summary>
        /// JdExpress.
        /// </summary>
        [EnumMember(Value = "JD_EXPRESS")]
        JdExpress,

        /// <summary>
        /// Fastbox.
        /// </summary>
        [EnumMember(Value = "FASTBOX")]
        Fastbox,

        /// <summary>
        /// Patheon.
        /// </summary>
        [EnumMember(Value = "PATHEON")]
        Patheon,

        /// <summary>
        /// IndiaPost.
        /// </summary>
        [EnumMember(Value = "INDIA_POST")]
        IndiaPost,

        /// <summary>
        /// TipsaRef.
        /// </summary>
        [EnumMember(Value = "TIPSA_REF")]
        TipsaRef,

        /// <summary>
        /// Ecofreight.
        /// </summary>
        [EnumMember(Value = "ECOFREIGHT")]
        Ecofreight,

        /// <summary>
        /// Vox.
        /// </summary>
        [EnumMember(Value = "VOX")]
        Vox,

        /// <summary>
        /// DirectfreightAuRef.
        /// </summary>
        [EnumMember(Value = "DIRECTFREIGHT_AU_REF")]
        DirectfreightAuRef,

        /// <summary>
        /// BesttransportSftp.
        /// </summary>
        [EnumMember(Value = "BESTTRANSPORT_SFTP")]
        BesttransportSftp,

        /// <summary>
        /// AustraliaPostApi.
        /// </summary>
        [EnumMember(Value = "AUSTRALIA_POST_API")]
        AustraliaPostApi,

        /// <summary>
        /// FragilepakSftp.
        /// </summary>
        [EnumMember(Value = "FRAGILEPAK_SFTP")]
        FragilepakSftp,

        /// <summary>
        /// Flipxp.
        /// </summary>
        [EnumMember(Value = "FLIPXP")]
        Flipxp,

        /// <summary>
        /// ValueWebhook.
        /// </summary>
        [EnumMember(Value = "VALUE_WEBHOOK")]
        ValueWebhook,

        /// <summary>
        /// Daeshin.
        /// </summary>
        [EnumMember(Value = "DAESHIN")]
        Daeshin,

        /// <summary>
        /// Sherpa.
        /// </summary>
        [EnumMember(Value = "SHERPA")]
        Sherpa,

        /// <summary>
        /// MwdApi.
        /// </summary>
        [EnumMember(Value = "MWD_API")]
        MwdApi,

        /// <summary>
        /// Smartkargo.
        /// </summary>
        [EnumMember(Value = "SMARTKARGO")]
        Smartkargo,

        /// <summary>
        /// DnjExpress.
        /// </summary>
        [EnumMember(Value = "DNJ_EXPRESS")]
        DnjExpress,

        /// <summary>
        /// Gopeople.
        /// </summary>
        [EnumMember(Value = "GOPEOPLE")]
        Gopeople,

        /// <summary>
        /// MysendleApi.
        /// </summary>
        [EnumMember(Value = "MYSENDLE_API")]
        MysendleApi,

        /// <summary>
        /// AramexApi.
        /// </summary>
        [EnumMember(Value = "ARAMEX_API")]
        AramexApi,

        /// <summary>
        /// Pidge.
        /// </summary>
        [EnumMember(Value = "PIDGE")]
        Pidge,

        /// <summary>
        /// Thaiparcels.
        /// </summary>
        [EnumMember(Value = "THAIPARCELS")]
        Thaiparcels,

        /// <summary>
        /// PantherReferenceApi.
        /// </summary>
        [EnumMember(Value = "PANTHER_REFERENCE_API")]
        PantherReferenceApi,

        /// <summary>
        /// Postaplus1.
        /// </summary>
        [EnumMember(Value = "POSTAPLUS")]
        Postaplus1,

        /// <summary>
        /// Buffalo.
        /// </summary>
        [EnumMember(Value = "BUFFALO")]
        Buffalo,

        /// <summary>
        /// UEnvios.
        /// </summary>
        [EnumMember(Value = "U_ENVIOS")]
        UEnvios,

        /// <summary>
        /// EliteCo.
        /// </summary>
        [EnumMember(Value = "ELITE_CO")]
        EliteCo,

        /// <summary>
        /// Barqexp.
        /// </summary>
        [EnumMember(Value = "BARQEXP")]
        Barqexp,

        /// <summary>
        /// RocheInternalSftp.
        /// </summary>
        [EnumMember(Value = "ROCHE_INTERNAL_SFTP")]
        RocheInternalSftp,

        /// <summary>
        /// DbschenkerIceland.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_ICELAND")]
        DbschenkerIceland,

        /// <summary>
        /// TntFrReference.
        /// </summary>
        [EnumMember(Value = "TNT_FR_REFERENCE")]
        TntFrReference,

        /// <summary>
        /// Newgisticsapi.
        /// </summary>
        [EnumMember(Value = "NEWGISTICSAPI")]
        Newgisticsapi,

        /// <summary>
        /// Glovo.
        /// </summary>
        [EnumMember(Value = "GLOVO")]
        Glovo,

        /// <summary>
        /// GwlogisApi.
        /// </summary>
        [EnumMember(Value = "GWLOGIS_API")]
        GwlogisApi,

        /// <summary>
        /// SpreetailApi.
        /// </summary>
        [EnumMember(Value = "SPREETAIL_API")]
        SpreetailApi,

        /// <summary>
        /// Moova.
        /// </summary>
        [EnumMember(Value = "MOOVA")]
        Moova,

        /// <summary>
        /// Plycongroup.
        /// </summary>
        [EnumMember(Value = "PLYCONGROUP")]
        Plycongroup,

        /// <summary>
        /// UspsWebhook.
        /// </summary>
        [EnumMember(Value = "USPS_WEBHOOK")]
        UspsWebhook,

        /// <summary>
        /// Reimaginedelivery.
        /// </summary>
        [EnumMember(Value = "REIMAGINEDELIVERY")]
        Reimaginedelivery,

        /// <summary>
        /// EdfFtp.
        /// </summary>
        [EnumMember(Value = "EDF_FTP")]
        EdfFtp,

        /// <summary>
        /// Dao365.
        /// </summary>
        [EnumMember(Value = "DAO365")]
        Dao365,

        /// <summary>
        /// BiocairFtp.
        /// </summary>
        [EnumMember(Value = "BIOCAIR_FTP")]
        BiocairFtp,

        /// <summary>
        /// RansaWebhook.
        /// </summary>
        [EnumMember(Value = "RANSA_WEBHOOK")]
        RansaWebhook,

        /// <summary>
        /// Shipxpres.
        /// </summary>
        [EnumMember(Value = "SHIPXPRES")]
        Shipxpres,

        /// <summary>
        /// CourantPlusApi.
        /// </summary>
        [EnumMember(Value = "COURANT_PLUS_API")]
        CourantPlusApi,

        /// <summary>
        /// Shipa.
        /// </summary>
        [EnumMember(Value = "SHIPA")]
        Shipa,

        /// <summary>
        /// Homelogistics.
        /// </summary>
        [EnumMember(Value = "HOMELOGISTICS")]
        Homelogistics,

        /// <summary>
        /// Dx.
        /// </summary>
        [EnumMember(Value = "DX")]
        Dx,

        /// <summary>
        /// PosteItalianePaccocelere.
        /// </summary>
        [EnumMember(Value = "POSTE_ITALIANE_PACCOCELERE")]
        PosteItalianePaccocelere,

        /// <summary>
        /// TollWebhook.
        /// </summary>
        [EnumMember(Value = "TOLL_WEBHOOK")]
        TollWebhook,

        /// <summary>
        /// LctbrApi.
        /// </summary>
        [EnumMember(Value = "LCTBR_API")]
        LctbrApi,

        /// <summary>
        /// DxFreight.
        /// </summary>
        [EnumMember(Value = "DX_FREIGHT")]
        DxFreight,

        /// <summary>
        /// DhlSftp.
        /// </summary>
        [EnumMember(Value = "DHL_SFTP")]
        DhlSftp,

        /// <summary>
        /// Shiprocket.
        /// </summary>
        [EnumMember(Value = "SHIPROCKET")]
        Shiprocket,

        /// <summary>
        /// UberWebhook.
        /// </summary>
        [EnumMember(Value = "UBER_WEBHOOK")]
        UberWebhook,

        /// <summary>
        /// Statovernight.
        /// </summary>
        [EnumMember(Value = "STATOVERNIGHT")]
        Statovernight,

        /// <summary>
        /// Burd.
        /// </summary>
        [EnumMember(Value = "BURD")]
        Burd,

        /// <summary>
        /// Fastship.
        /// </summary>
        [EnumMember(Value = "FASTSHIP")]
        Fastship,

        /// <summary>
        /// IbventureWebhook.
        /// </summary>
        [EnumMember(Value = "IBVENTURE_WEBHOOK")]
        IbventureWebhook,

        /// <summary>
        /// GatiKweApi.
        /// </summary>
        [EnumMember(Value = "GATI_KWE_API")]
        GatiKweApi,

        /// <summary>
        /// CryopdpFtp.
        /// </summary>
        [EnumMember(Value = "CRYOPDP_FTP")]
        CryopdpFtp,

        /// <summary>
        /// Hubbed.
        /// </summary>
        [EnumMember(Value = "HUBBED")]
        Hubbed,

        /// <summary>
        /// TipsaApi.
        /// </summary>
        [EnumMember(Value = "TIPSA_API")]
        TipsaApi,

        /// <summary>
        /// Araskargo.
        /// </summary>
        [EnumMember(Value = "ARASKARGO")]
        Araskargo,

        /// <summary>
        /// ThijsNl.
        /// </summary>
        [EnumMember(Value = "THIJS_NL")]
        ThijsNl,

        /// <summary>
        /// AtshealthcareReference.
        /// </summary>
        [EnumMember(Value = "ATSHEALTHCARE_REFERENCE")]
        AtshealthcareReference,

        /// <summary>
        /// Enum99Minutos.
        /// </summary>
        [EnumMember(Value = "99MINUTOS")]
        Enum99Minutos,

        /// <summary>
        /// HellenicPost.
        /// </summary>
        [EnumMember(Value = "HELLENIC_POST")]
        HellenicPost,

        /// <summary>
        /// HsmGlobal.
        /// </summary>
        [EnumMember(Value = "HSM_GLOBAL")]
        HsmGlobal,

        /// <summary>
        /// Mnx.
        /// </summary>
        [EnumMember(Value = "MNX")]
        Mnx,

        /// <summary>
        /// Nmtransfer.
        /// </summary>
        [EnumMember(Value = "NMTRANSFER")]
        Nmtransfer,

        /// <summary>
        /// Logysto.
        /// </summary>
        [EnumMember(Value = "LOGYSTO")]
        Logysto,

        /// <summary>
        /// IndiaPostInt.
        /// </summary>
        [EnumMember(Value = "INDIA_POST_INT")]
        IndiaPostInt,

        /// <summary>
        /// AmazonFbaSwishipIn.
        /// </summary>
        [EnumMember(Value = "AMAZON_FBA_SWISHIP_IN")]
        AmazonFbaSwishipIn,

        /// <summary>
        /// SrtTransport.
        /// </summary>
        [EnumMember(Value = "SRT_TRANSPORT")]
        SrtTransport,

        /// <summary>
        /// Bomi.
        /// </summary>
        [EnumMember(Value = "BOMI")]
        Bomi,

        /// <summary>
        /// DeliverrSftp.
        /// </summary>
        [EnumMember(Value = "DELIVERR_SFTP")]
        DeliverrSftp,

        /// <summary>
        /// Hsdexpress.
        /// </summary>
        [EnumMember(Value = "HSDEXPRESS")]
        Hsdexpress,

        /// <summary>
        /// SimpletireWebhook.
        /// </summary>
        [EnumMember(Value = "SIMPLETIRE_WEBHOOK")]
        SimpletireWebhook,

        /// <summary>
        /// HunterExpressSftp.
        /// </summary>
        [EnumMember(Value = "HUNTER_EXPRESS_SFTP")]
        HunterExpressSftp,

        /// <summary>
        /// UpsApi.
        /// </summary>
        [EnumMember(Value = "UPS_API")]
        UpsApi,

        /// <summary>
        /// WooyoungLogisticsSftp.
        /// </summary>
        [EnumMember(Value = "WOOYOUNG_LOGISTICS_SFTP")]
        WooyoungLogisticsSftp,

        /// <summary>
        /// PhseApi.
        /// </summary>
        [EnumMember(Value = "PHSE_API")]
        PhseApi,

        /// <summary>
        /// WishEmailPush.
        /// </summary>
        [EnumMember(Value = "WISH_EMAIL_PUSH")]
        WishEmailPush,

        /// <summary>
        /// Northline.
        /// </summary>
        [EnumMember(Value = "NORTHLINE")]
        Northline,

        /// <summary>
        /// Medafrica.
        /// </summary>
        [EnumMember(Value = "MEDAFRICA")]
        Medafrica,

        /// <summary>
        /// DpdAtSftp.
        /// </summary>
        [EnumMember(Value = "DPD_AT_SFTP")]
        DpdAtSftp,

        /// <summary>
        /// Anteraja.
        /// </summary>
        [EnumMember(Value = "ANTERAJA")]
        Anteraja,

        /// <summary>
        /// DhlGlobalForwardingApi.
        /// </summary>
        [EnumMember(Value = "DHL_GLOBAL_FORWARDING_API")]
        DhlGlobalForwardingApi,

        /// <summary>
        /// LbcexpressApi.
        /// </summary>
        [EnumMember(Value = "LBCEXPRESS_API")]
        LbcexpressApi,

        /// <summary>
        /// Simsglobal.
        /// </summary>
        [EnumMember(Value = "SIMSGLOBAL")]
        Simsglobal,

        /// <summary>
        /// Cdldelivers.
        /// </summary>
        [EnumMember(Value = "CDLDELIVERS")]
        Cdldelivers,

        /// <summary>
        /// Typ.
        /// </summary>
        [EnumMember(Value = "TYP")]
        Typ,

        /// <summary>
        /// TestingCourierWebhook.
        /// </summary>
        [EnumMember(Value = "TESTING_COURIER_WEBHOOK")]
        TestingCourierWebhook,

        /// <summary>
        /// PandagoApi.
        /// </summary>
        [EnumMember(Value = "PANDAGO_API")]
        PandagoApi,

        /// <summary>
        /// RoyalMailFtp.
        /// </summary>
        [EnumMember(Value = "ROYAL_MAIL_FTP")]
        RoyalMailFtp,

        /// <summary>
        /// Thunderexpress.
        /// </summary>
        [EnumMember(Value = "THUNDEREXPRESS")]
        Thunderexpress,

        /// <summary>
        /// SecretlabWebhook.
        /// </summary>
        [EnumMember(Value = "SECRETLAB_WEBHOOK")]
        SecretlabWebhook,

        /// <summary>
        /// Setel.
        /// </summary>
        [EnumMember(Value = "SETEL")]
        Setel,

        /// <summary>
        /// JdWorldwide.
        /// </summary>
        [EnumMember(Value = "JD_WORLDWIDE")]
        JdWorldwide,

        /// <summary>
        /// DpdRuApi.
        /// </summary>
        [EnumMember(Value = "DPD_RU_API")]
        DpdRuApi,

        /// <summary>
        /// ArgentsWebhook.
        /// </summary>
        [EnumMember(Value = "ARGENTS_WEBHOOK")]
        ArgentsWebhook,

        /// <summary>
        /// Postone.
        /// </summary>
        [EnumMember(Value = "POSTONE")]
        Postone,

        /// <summary>
        /// Tusklogistics.
        /// </summary>
        [EnumMember(Value = "TUSKLOGISTICS")]
        Tusklogistics,

        /// <summary>
        /// RhenusUkApi.
        /// </summary>
        [EnumMember(Value = "RHENUS_UK_API")]
        RhenusUkApi,

        /// <summary>
        /// TaqbinSgApi.
        /// </summary>
        [EnumMember(Value = "TAQBIN_SG_API")]
        TaqbinSgApi,

        /// <summary>
        /// InntralogSftp.
        /// </summary>
        [EnumMember(Value = "INNTRALOG_SFTP")]
        InntralogSftp,

        /// <summary>
        /// Dayross.
        /// </summary>
        [EnumMember(Value = "DAYROSS")]
        Dayross,

        /// <summary>
        /// CorreosexpressApi.
        /// </summary>
        [EnumMember(Value = "CORREOSEXPRESS_API")]
        CorreosexpressApi,

        /// <summary>
        /// InternationalSeurApi.
        /// </summary>
        [EnumMember(Value = "INTERNATIONAL_SEUR_API")]
        InternationalSeurApi,

        /// <summary>
        /// YodelApi.
        /// </summary>
        [EnumMember(Value = "YODEL_API")]
        YodelApi,

        /// <summary>
        /// Heroexpress.
        /// </summary>
        [EnumMember(Value = "HEROEXPRESS")]
        Heroexpress,

        /// <summary>
        /// DhlSupplychainIn.
        /// </summary>
        [EnumMember(Value = "DHL_SUPPLYCHAIN_IN")]
        DhlSupplychainIn,

        /// <summary>
        /// UrgentCargus.
        /// </summary>
        [EnumMember(Value = "URGENT_CARGUS")]
        UrgentCargus,

        /// <summary>
        /// Frontdoorcorp.
        /// </summary>
        [EnumMember(Value = "FRONTDOORCORP")]
        Frontdoorcorp,

        /// <summary>
        /// JtexpressPh.
        /// </summary>
        [EnumMember(Value = "JTEXPRESS_PH")]
        JtexpressPh,

        /// <summary>
        /// ParcelstarsWebhook.
        /// </summary>
        [EnumMember(Value = "PARCELSTARS_WEBHOOK")]
        ParcelstarsWebhook,

        /// <summary>
        /// DpdSkSftp.
        /// </summary>
        [EnumMember(Value = "DPD_SK_SFTP")]
        DpdSkSftp,

        /// <summary>
        /// Movianto.
        /// </summary>
        [EnumMember(Value = "MOVIANTO")]
        Movianto,

        /// <summary>
        /// OzepartsShipping.
        /// </summary>
        [EnumMember(Value = "OZEPARTS_SHIPPING")]
        OzepartsShipping,

        /// <summary>
        /// Kargomkolay.
        /// </summary>
        [EnumMember(Value = "KARGOMKOLAY")]
        Kargomkolay,

        /// <summary>
        /// Trunkrs.
        /// </summary>
        [EnumMember(Value = "TRUNKRS")]
        Trunkrs,

        /// <summary>
        /// OmnirpsWebhook.
        /// </summary>
        [EnumMember(Value = "OMNIRPS_WEBHOOK")]
        OmnirpsWebhook,

        /// <summary>
        /// Chilexpress.
        /// </summary>
        [EnumMember(Value = "CHILEXPRESS")]
        Chilexpress,

        /// <summary>
        /// TestingCourier.
        /// </summary>
        [EnumMember(Value = "TESTING_COURIER")]
        TestingCourier,

        /// <summary>
        /// JneApi.
        /// </summary>
        [EnumMember(Value = "JNE_API")]
        JneApi,

        /// <summary>
        /// BjshomedeliveryFtp.
        /// </summary>
        [EnumMember(Value = "BJSHOMEDELIVERY_FTP")]
        BjshomedeliveryFtp,

        /// <summary>
        /// DexpressWebhook.
        /// </summary>
        [EnumMember(Value = "DEXPRESS_WEBHOOK")]
        DexpressWebhook,

        /// <summary>
        /// UspsApi.
        /// </summary>
        [EnumMember(Value = "USPS_API")]
        UspsApi,

        /// <summary>
        /// Transvirtual.
        /// </summary>
        [EnumMember(Value = "TRANSVIRTUAL")]
        Transvirtual,

        /// <summary>
        /// SolisticaApi.
        /// </summary>
        [EnumMember(Value = "SOLISTICA_API")]
        SolisticaApi,

        /// <summary>
        /// ChienventureWebhook.
        /// </summary>
        [EnumMember(Value = "CHIENVENTURE_WEBHOOK")]
        ChienventureWebhook,

        /// <summary>
        /// DpdUkSftp.
        /// </summary>
        [EnumMember(Value = "DPD_UK_SFTP")]
        DpdUkSftp,

        /// <summary>
        /// InpostUk.
        /// </summary>
        [EnumMember(Value = "INPOST_UK")]
        InpostUk,

        /// <summary>
        /// Javit.
        /// </summary>
        [EnumMember(Value = "JAVIT")]
        Javit,

        /// <summary>
        /// ZtoDomestic.
        /// </summary>
        [EnumMember(Value = "ZTO_DOMESTIC")]
        ZtoDomestic,

        /// <summary>
        /// DhlGtApi.
        /// </summary>
        [EnumMember(Value = "DHL_GT_API")]
        DhlGtApi,

        /// <summary>
        /// CevaTracking.
        /// </summary>
        [EnumMember(Value = "CEVA_TRACKING")]
        CevaTracking,

        /// <summary>
        /// KomonExpress.
        /// </summary>
        [EnumMember(Value = "KOMON_EXPRESS")]
        KomonExpress,

        /// <summary>
        /// EastwestcourierFtp.
        /// </summary>
        [EnumMember(Value = "EASTWESTCOURIER_FTP")]
        EastwestcourierFtp,

        /// <summary>
        /// Danniao.
        /// </summary>
        [EnumMember(Value = "DANNIAO")]
        Danniao,

        /// <summary>
        /// Spectran.
        /// </summary>
        [EnumMember(Value = "SPECTRAN")]
        Spectran,

        /// <summary>
        /// DeliverIt.
        /// </summary>
        [EnumMember(Value = "DELIVER_IT")]
        DeliverIt,

        /// <summary>
        /// Relaiscolis.
        /// </summary>
        [EnumMember(Value = "RELAISCOLIS")]
        Relaiscolis,

        /// <summary>
        /// GlsSpainApi.
        /// </summary>
        [EnumMember(Value = "GLS_SPAIN_API")]
        GlsSpainApi,

        /// <summary>
        /// Postplus.
        /// </summary>
        [EnumMember(Value = "POSTPLUS")]
        Postplus,

        /// <summary>
        /// Airterra.
        /// </summary>
        [EnumMember(Value = "AIRTERRA")]
        Airterra,

        /// <summary>
        /// GioEcourierApi.
        /// </summary>
        [EnumMember(Value = "GIO_ECOURIER_API")]
        GioEcourierApi,

        /// <summary>
        /// DpdChSftp.
        /// </summary>
        [EnumMember(Value = "DPD_CH_SFTP")]
        DpdChSftp,

        /// <summary>
        /// FedexApi.
        /// </summary>
        [EnumMember(Value = "FEDEX_API")]
        FedexApi,

        /// <summary>
        /// Intersmarttrans.
        /// </summary>
        [EnumMember(Value = "INTERSMARTTRANS")]
        Intersmarttrans,

        /// <summary>
        /// HermesUkSftp.
        /// </summary>
        [EnumMember(Value = "HERMES_UK_SFTP")]
        HermesUkSftp,

        /// <summary>
        /// ExelotFtp.
        /// </summary>
        [EnumMember(Value = "EXELOT_FTP")]
        ExelotFtp,

        /// <summary>
        /// DhlPaApi.
        /// </summary>
        [EnumMember(Value = "DHL_PA_API")]
        DhlPaApi,

        /// <summary>
        /// VirtransportSftp.
        /// </summary>
        [EnumMember(Value = "VIRTRANSPORT_SFTP")]
        VirtransportSftp,

        /// <summary>
        /// Worldnet.
        /// </summary>
        [EnumMember(Value = "WORLDNET")]
        Worldnet,

        /// <summary>
        /// InstaboxWebhook.
        /// </summary>
        [EnumMember(Value = "INSTABOX_WEBHOOK")]
        InstaboxWebhook,

        /// <summary>
        /// Kng.
        /// </summary>
        [EnumMember(Value = "KNG")]
        Kng,

        /// <summary>
        /// FlashexpressWebhook.
        /// </summary>
        [EnumMember(Value = "FLASHEXPRESS_WEBHOOK")]
        FlashexpressWebhook,

        /// <summary>
        /// MagyarPostaApi.
        /// </summary>
        [EnumMember(Value = "MAGYAR_POSTA_API")]
        MagyarPostaApi,

        /// <summary>
        /// WeshipApi.
        /// </summary>
        [EnumMember(Value = "WESHIP_API")]
        WeshipApi,

        /// <summary>
        /// OhiWebhook.
        /// </summary>
        [EnumMember(Value = "OHI_WEBHOOK")]
        OhiWebhook,

        /// <summary>
        /// Mudita.
        /// </summary>
        [EnumMember(Value = "MUDITA")]
        Mudita,

        /// <summary>
        /// BluedartApi.
        /// </summary>
        [EnumMember(Value = "BLUEDART_API")]
        BluedartApi,

        /// <summary>
        /// TCatApi.
        /// </summary>
        [EnumMember(Value = "T_CAT_API")]
        TCatApi,

        /// <summary>
        /// Ads.
        /// </summary>
        [EnumMember(Value = "ADS")]
        Ads,

        /// <summary>
        /// HermesIt.
        /// </summary>
        [EnumMember(Value = "HERMES_IT")]
        HermesIt,

        /// <summary>
        /// FitzmarkApi.
        /// </summary>
        [EnumMember(Value = "FITZMARK_API")]
        FitzmarkApi,

        /// <summary>
        /// PostiApi.
        /// </summary>
        [EnumMember(Value = "POSTI_API")]
        PostiApi,

        /// <summary>
        /// SmsaExpressWebhook.
        /// </summary>
        [EnumMember(Value = "SMSA_EXPRESS_WEBHOOK")]
        SmsaExpressWebhook,

        /// <summary>
        /// TamergroupWebhook.
        /// </summary>
        [EnumMember(Value = "TAMERGROUP_WEBHOOK")]
        TamergroupWebhook,

        /// <summary>
        /// Livrapide.
        /// </summary>
        [EnumMember(Value = "LIVRAPIDE")]
        Livrapide,

        /// <summary>
        /// NipponExpress.
        /// </summary>
        [EnumMember(Value = "NIPPON_EXPRESS")]
        NipponExpress,

        /// <summary>
        /// Bettertrucks.
        /// </summary>
        [EnumMember(Value = "BETTERTRUCKS")]
        Bettertrucks,

        /// <summary>
        /// Fan.
        /// </summary>
        [EnumMember(Value = "FAN")]
        Fan,

        /// <summary>
        /// PbUspsflatsFtp.
        /// </summary>
        [EnumMember(Value = "PB_USPSFLATS_FTP")]
        PbUspsflatsFtp,

        /// <summary>
        /// Parcelright.
        /// </summary>
        [EnumMember(Value = "PARCELRIGHT")]
        Parcelright,

        /// <summary>
        /// Ithinklogistics.
        /// </summary>
        [EnumMember(Value = "ITHINKLOGISTICS")]
        Ithinklogistics,

        /// <summary>
        /// KerryExpressThWebhook.
        /// </summary>
        [EnumMember(Value = "KERRY_EXPRESS_TH_WEBHOOK")]
        KerryExpressThWebhook,

        /// <summary>
        /// Ecoutier.
        /// </summary>
        [EnumMember(Value = "ECOUTIER")]
        Ecoutier,

        /// <summary>
        /// Showl.
        /// </summary>
        [EnumMember(Value = "SHOWL")]
        Showl,

        /// <summary>
        /// BrtItApi.
        /// </summary>
        [EnumMember(Value = "BRT_IT_API")]
        BrtItApi,

        /// <summary>
        /// RixonhkApi.
        /// </summary>
        [EnumMember(Value = "RIXONHK_API")]
        RixonhkApi,

        /// <summary>
        /// DbschenkerApi.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_API")]
        DbschenkerApi,

        /// <summary>
        /// Ilyanglogis.
        /// </summary>
        [EnumMember(Value = "ILYANGLOGIS")]
        Ilyanglogis,

        /// <summary>
        /// MailBoxEtc.
        /// </summary>
        [EnumMember(Value = "MAIL_BOX_ETC")]
        MailBoxEtc,

        /// <summary>
        /// Weship.
        /// </summary>
        [EnumMember(Value = "WESHIP")]
        Weship,

        /// <summary>
        /// DhlGlobalMailApi.
        /// </summary>
        [EnumMember(Value = "DHL_GLOBAL_MAIL_API")]
        DhlGlobalMailApi,

        /// <summary>
        /// Activos24Api.
        /// </summary>
        [EnumMember(Value = "ACTIVOS24_API")]
        Activos24Api,

        /// <summary>
        /// Atshealthcare.
        /// </summary>
        [EnumMember(Value = "ATSHEALTHCARE")]
        Atshealthcare,

        /// <summary>
        /// Luwjistik.
        /// </summary>
        [EnumMember(Value = "LUWJISTIK")]
        Luwjistik,

        /// <summary>
        /// GwWorld.
        /// </summary>
        [EnumMember(Value = "GW_WORLD")]
        GwWorld,

        /// <summary>
        /// FairsendenApi.
        /// </summary>
        [EnumMember(Value = "FAIRSENDEN_API")]
        FairsendenApi,

        /// <summary>
        /// ServipWebhook.
        /// </summary>
        [EnumMember(Value = "SERVIP_WEBHOOK")]
        ServipWebhook,

        /// <summary>
        /// Swiship.
        /// </summary>
        [EnumMember(Value = "SWISHIP")]
        Swiship,

        /// <summary>
        /// Tanet.
        /// </summary>
        [EnumMember(Value = "TANET")]
        Tanet,

        /// <summary>
        /// HotsinCargo.
        /// </summary>
        [EnumMember(Value = "HOTSIN_CARGO")]
        HotsinCargo,

        /// <summary>
        /// Direx.
        /// </summary>
        [EnumMember(Value = "DIREX")]
        Direx,

        /// <summary>
        /// Huantong.
        /// </summary>
        [EnumMember(Value = "HUANTONG")]
        Huantong,

        /// <summary>
        /// ImileApi.
        /// </summary>
        [EnumMember(Value = "IMILE_API")]
        ImileApi,

        /// <summary>
        /// Bdmnet.
        /// </summary>
        [EnumMember(Value = "BDMNET")]
        Bdmnet,

        /// <summary>
        /// Auexpress.
        /// </summary>
        [EnumMember(Value = "AUEXPRESS")]
        Auexpress,

        /// <summary>
        /// Nytlogistics.
        /// </summary>
        [EnumMember(Value = "NYTLOGISTICS")]
        Nytlogistics,

        /// <summary>
        /// DsvReference.
        /// </summary>
        [EnumMember(Value = "DSV_REFERENCE")]
        DsvReference,

        /// <summary>
        /// NovofarmaWebhook.
        /// </summary>
        [EnumMember(Value = "NOVOFARMA_WEBHOOK")]
        NovofarmaWebhook,

        /// <summary>
        /// AitworldwideSftp.
        /// </summary>
        [EnumMember(Value = "AITWORLDWIDE_SFTP")]
        AitworldwideSftp,

        /// <summary>
        /// Shopolive.
        /// </summary>
        [EnumMember(Value = "SHOPOLIVE")]
        Shopolive,

        /// <summary>
        /// FnfZa.
        /// </summary>
        [EnumMember(Value = "FNF_ZA")]
        FnfZa,

        /// <summary>
        /// DhlEcommerceGc.
        /// </summary>
        [EnumMember(Value = "DHL_ECOMMERCE_GC")]
        DhlEcommerceGc,

        /// <summary>
        /// Fetchr.
        /// </summary>
        [EnumMember(Value = "FETCHR")]
        Fetchr,

        /// <summary>
        /// StarlinksApi.
        /// </summary>
        [EnumMember(Value = "STARLINKS_API")]
        StarlinksApi,

        /// <summary>
        /// Yyexpress.
        /// </summary>
        [EnumMember(Value = "YYEXPRESS")]
        Yyexpress,

        /// <summary>
        /// Servientrega.
        /// </summary>
        [EnumMember(Value = "SERVIENTREGA")]
        Servientrega,

        /// <summary>
        /// Hanjin.
        /// </summary>
        [EnumMember(Value = "HANJIN")]
        Hanjin,

        /// <summary>
        /// SpanishSeurFtp.
        /// </summary>
        [EnumMember(Value = "SPANISH_SEUR_FTP")]
        SpanishSeurFtp,

        /// <summary>
        /// DxB2BConnum.
        /// </summary>
        [EnumMember(Value = "DX_B2B_CONNUM")]
        DxB2BConnum,

        /// <summary>
        /// HelthjemApi.
        /// </summary>
        [EnumMember(Value = "HELTHJEM_API")]
        HelthjemApi,

        /// <summary>
        /// Inexpost.
        /// </summary>
        [EnumMember(Value = "INEXPOST")]
        Inexpost,

        /// <summary>
        /// A2BBa.
        /// </summary>
        [EnumMember(Value = "A2B_BA")]
        A2BBa,

        /// <summary>
        /// RhenusGroup.
        /// </summary>
        [EnumMember(Value = "RHENUS_GROUP")]
        RhenusGroup,

        /// <summary>
        /// SberlogisticsRu.
        /// </summary>
        [EnumMember(Value = "SBERLOGISTICS_RU")]
        SberlogisticsRu,

        /// <summary>
        /// MalcaAmit.
        /// </summary>
        [EnumMember(Value = "MALCA_AMIT")]
        MalcaAmit,

        /// <summary>
        /// Ppl.
        /// </summary>
        [EnumMember(Value = "PPL")]
        Ppl,

        /// <summary>
        /// OsmWorldwideSftp.
        /// </summary>
        [EnumMember(Value = "OSM_WORLDWIDE_SFTP")]
        OsmWorldwideSftp,

        /// <summary>
        /// Acilogistix.
        /// </summary>
        [EnumMember(Value = "ACILOGISTIX")]
        Acilogistix,

        /// <summary>
        /// Optimacourier.
        /// </summary>
        [EnumMember(Value = "OPTIMACOURIER")]
        Optimacourier,

        /// <summary>
        /// NovaPoshtaApi.
        /// </summary>
        [EnumMember(Value = "NOVA_POSHTA_API")]
        NovaPoshtaApi,

        /// <summary>
        /// Loggi.
        /// </summary>
        [EnumMember(Value = "LOGGI")]
        Loggi,

        /// <summary>
        /// Yifan.
        /// </summary>
        [EnumMember(Value = "YIFAN")]
        Yifan,

        /// <summary>
        /// Mydynalogic.
        /// </summary>
        [EnumMember(Value = "MYDYNALOGIC")]
        Mydynalogic,

        /// <summary>
        /// Morninglobal.
        /// </summary>
        [EnumMember(Value = "MORNINGLOBAL")]
        Morninglobal,

        /// <summary>
        /// ConciseApi.
        /// </summary>
        [EnumMember(Value = "CONCISE_API")]
        ConciseApi,

        /// <summary>
        /// Fxtran.
        /// </summary>
        [EnumMember(Value = "FXTRAN")]
        Fxtran,

        /// <summary>
        /// DeliveryourparcelZa.
        /// </summary>
        [EnumMember(Value = "DELIVERYOURPARCEL_ZA")]
        DeliveryourparcelZa,

        /// <summary>
        /// Uparcel.
        /// </summary>
        [EnumMember(Value = "UPARCEL")]
        Uparcel,

        /// <summary>
        /// MobiBr.
        /// </summary>
        [EnumMember(Value = "MOBI_BR")]
        MobiBr,

        /// <summary>
        /// LoginextWebhook.
        /// </summary>
        [EnumMember(Value = "LOGINEXT_WEBHOOK")]
        LoginextWebhook,

        /// <summary>
        /// Ems.
        /// </summary>
        [EnumMember(Value = "EMS")]
        Ems,

        /// <summary>
        /// Speedy.
        /// </summary>
        [EnumMember(Value = "SPEEDY")]
        Speedy,

        /// <summary>
        /// ZoomRed.
        /// </summary>
        [EnumMember(Value = "ZOOM_RED")]
        ZoomRed,

        /// <summary>
        /// Navlungo.
        /// </summary>
        [EnumMember(Value = "NAVLUNGO")]
        Navlungo,

        /// <summary>
        /// Castleparcels.
        /// </summary>
        [EnumMember(Value = "CASTLEPARCELS")]
        Castleparcels,

        /// <summary>
        /// Weee.
        /// </summary>
        [EnumMember(Value = "WEEE")]
        Weee,

        /// <summary>
        /// Packaly.
        /// </summary>
        [EnumMember(Value = "PACKALY")]
        Packaly,

        /// <summary>
        /// Yunhuipost.
        /// </summary>
        [EnumMember(Value = "YUNHUIPOST")]
        Yunhuipost,

        /// <summary>
        /// Youparcel.
        /// </summary>
        [EnumMember(Value = "YOUPARCEL")]
        Youparcel,

        /// <summary>
        /// Leman.
        /// </summary>
        [EnumMember(Value = "LEMAN")]
        Leman,

        /// <summary>
        /// Moovin.
        /// </summary>
        [EnumMember(Value = "MOOVIN")]
        Moovin,

        /// <summary>
        /// UrbIt.
        /// </summary>
        [EnumMember(Value = "URB_IT")]
        UrbIt,

        /// <summary>
        /// Multientregapanama.
        /// </summary>
        [EnumMember(Value = "MULTIENTREGAPANAMA")]
        Multientregapanama,

        /// <summary>
        /// Jusdasr.
        /// </summary>
        [EnumMember(Value = "JUSDASR")]
        Jusdasr,

        /// <summary>
        /// Discountpost.
        /// </summary>
        [EnumMember(Value = "DISCOUNTPOST")]
        Discountpost,

        /// <summary>
        /// RhenusUk.
        /// </summary>
        [EnumMember(Value = "RHENUS_UK")]
        RhenusUk,

        /// <summary>
        /// SwishipJp.
        /// </summary>
        [EnumMember(Value = "SWISHIP_JP")]
        SwishipJp,

        /// <summary>
        /// GlsUs.
        /// </summary>
        [EnumMember(Value = "GLS_US")]
        GlsUs,

        /// <summary>
        /// Smtl.
        /// </summary>
        [EnumMember(Value = "SMTL")]
        Smtl,

        /// <summary>
        /// Emega.
        /// </summary>
        [EnumMember(Value = "EMEGA")]
        Emega,

        /// <summary>
        /// ExpressoneSv.
        /// </summary>
        [EnumMember(Value = "EXPRESSONE_SV")]
        ExpressoneSv,

        /// <summary>
        /// Hepsijet.
        /// </summary>
        [EnumMember(Value = "HEPSIJET")]
        Hepsijet,

        /// <summary>
        /// Welivery.
        /// </summary>
        [EnumMember(Value = "WELIVERY")]
        Welivery,

        /// <summary>
        /// Bringer.
        /// </summary>
        [EnumMember(Value = "BRINGER")]
        Bringer,

        /// <summary>
        /// Easyroutes.
        /// </summary>
        [EnumMember(Value = "EASYROUTES")]
        Easyroutes,

        /// <summary>
        /// Mrw.
        /// </summary>
        [EnumMember(Value = "MRW")]
        Mrw,

        /// <summary>
        /// Rpm.
        /// </summary>
        [EnumMember(Value = "RPM")]
        Rpm,

        /// <summary>
        /// DpdPrt.
        /// </summary>
        [EnumMember(Value = "DPD_PRT")]
        DpdPrt,

        /// <summary>
        /// GlsRomania.
        /// </summary>
        [EnumMember(Value = "GLS_ROMANIA")]
        GlsRomania,

        /// <summary>
        /// Lmparcel.
        /// </summary>
        [EnumMember(Value = "LMPARCEL")]
        Lmparcel,

        /// <summary>
        /// Gtagsm.
        /// </summary>
        [EnumMember(Value = "GTAGSM")]
        Gtagsm,

        /// <summary>
        /// Domino.
        /// </summary>
        [EnumMember(Value = "DOMINO")]
        Domino,

        /// <summary>
        /// Eshipper.
        /// </summary>
        [EnumMember(Value = "ESHIPPER")]
        Eshipper,

        /// <summary>
        /// Transpak.
        /// </summary>
        [EnumMember(Value = "TRANSPAK")]
        Transpak,

        /// <summary>
        /// Xindus.
        /// </summary>
        [EnumMember(Value = "XINDUS")]
        Xindus,

        /// <summary>
        /// Aoyue.
        /// </summary>
        [EnumMember(Value = "AOYUE")]
        Aoyue,

        /// <summary>
        /// Easyparcel.
        /// </summary>
        [EnumMember(Value = "EASYPARCEL")]
        Easyparcel,

        /// <summary>
        /// Expressone.
        /// </summary>
        [EnumMember(Value = "EXPRESSONE")]
        Expressone,

        /// <summary>
        /// SendeoKargo.
        /// </summary>
        [EnumMember(Value = "SENDEO_KARGO")]
        SendeoKargo,

        /// <summary>
        /// Speedaf.
        /// </summary>
        [EnumMember(Value = "SPEEDAF")]
        Speedaf,

        /// <summary>
        /// Etower.
        /// </summary>
        [EnumMember(Value = "ETOWER")]
        Etower,

        /// <summary>
        /// Gcx.
        /// </summary>
        [EnumMember(Value = "GCX")]
        Gcx,

        /// <summary>
        /// NinjavanVn.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_VN")]
        NinjavanVn,

        /// <summary>
        /// Allegro.
        /// </summary>
        [EnumMember(Value = "ALLEGRO")]
        Allegro,

        /// <summary>
        /// Jumppoint.
        /// </summary>
        [EnumMember(Value = "JUMPPOINT")]
        Jumppoint,

        /// <summary>
        /// ShipglobalUs.
        /// </summary>
        [EnumMember(Value = "SHIPGLOBAL_US")]
        ShipglobalUs,

        /// <summary>
        /// Kinisi.
        /// </summary>
        [EnumMember(Value = "KINISI")]
        Kinisi,

        /// <summary>
        /// Oakh.
        /// </summary>
        [EnumMember(Value = "OAKH")]
        Oakh,

        /// <summary>
        /// Awest.
        /// </summary>
        [EnumMember(Value = "AWEST")]
        Awest,

        /// <summary>
        /// Barsan.
        /// </summary>
        [EnumMember(Value = "BARSAN")]
        Barsan,

        /// <summary>
        /// Energologistic.
        /// </summary>
        [EnumMember(Value = "ENERGOLOGISTIC")]
        Energologistic,

        /// <summary>
        /// Madrooex.
        /// </summary>
        [EnumMember(Value = "MADROOEX")]
        Madrooex,

        /// <summary>
        /// Gobolt.
        /// </summary>
        [EnumMember(Value = "GOBOLT")]
        Gobolt,

        /// <summary>
        /// SwissUniversalExpress.
        /// </summary>
        [EnumMember(Value = "SWISS_UNIVERSAL_EXPRESS")]
        SwissUniversalExpress,

        /// <summary>
        /// Iordirect.
        /// </summary>
        [EnumMember(Value = "IORDIRECT")]
        Iordirect,

        /// <summary>
        /// Xmszm.
        /// </summary>
        [EnumMember(Value = "XMSZM")]
        Xmszm,

        /// <summary>
        /// GlsHun.
        /// </summary>
        [EnumMember(Value = "GLS_HUN")]
        GlsHun,

        /// <summary>
        /// Sendy.
        /// </summary>
        [EnumMember(Value = "SENDY")]
        Sendy,

        /// <summary>
        /// Braunsexpress.
        /// </summary>
        [EnumMember(Value = "BRAUNSEXPRESS")]
        Braunsexpress,

        /// <summary>
        /// Grandslamexpress.
        /// </summary>
        [EnumMember(Value = "GRANDSLAMEXPRESS")]
        Grandslamexpress,

        /// <summary>
        /// Xgs.
        /// </summary>
        [EnumMember(Value = "XGS")]
        Xgs,

        /// <summary>
        /// Otschile.
        /// </summary>
        [EnumMember(Value = "OTSCHILE")]
        Otschile,

        /// <summary>
        /// PackUp.
        /// </summary>
        [EnumMember(Value = "PACK_UP")]
        PackUp,

        /// <summary>
        /// Parcelstars.
        /// </summary>
        [EnumMember(Value = "PARCELSTARS")]
        Parcelstars,

        /// <summary>
        /// Teamexpressllc.
        /// </summary>
        [EnumMember(Value = "TEAMEXPRESSLLC")]
        Teamexpressllc,

        /// <summary>
        /// Asyadexpress.
        /// </summary>
        [EnumMember(Value = "ASYADEXPRESS")]
        Asyadexpress,

        /// <summary>
        /// Tdn.
        /// </summary>
        [EnumMember(Value = "TDN")]
        Tdn,

        /// <summary>
        /// Earlybird.
        /// </summary>
        [EnumMember(Value = "EARLYBIRD")]
        Earlybird,

        /// <summary>
        /// Cacesa.
        /// </summary>
        [EnumMember(Value = "CACESA")]
        Cacesa,

        /// <summary>
        /// Parceljet.
        /// </summary>
        [EnumMember(Value = "PARCELJET")]
        Parceljet,

        /// <summary>
        /// MngKargo.
        /// </summary>
        [EnumMember(Value = "MNG_KARGO")]
        MngKargo,

        /// <summary>
        /// Superpackline.
        /// </summary>
        [EnumMember(Value = "SUPERPACKLINE")]
        Superpackline,

        /// <summary>
        /// Speedx.
        /// </summary>
        [EnumMember(Value = "SPEEDX")]
        Speedx,

        /// <summary>
        /// Vesyl.
        /// </summary>
        [EnumMember(Value = "VESYL")]
        Vesyl,

        /// <summary>
        /// Skyking.
        /// </summary>
        [EnumMember(Value = "SKYKING")]
        Skyking,

        /// <summary>
        /// Dirmensajeria.
        /// </summary>
        [EnumMember(Value = "DIRMENSAJERIA")]
        Dirmensajeria,

        /// <summary>
        /// Netlogixgroup.
        /// </summary>
        [EnumMember(Value = "NETLOGIXGROUP")]
        Netlogixgroup,

        /// <summary>
        /// Zyou.
        /// </summary>
        [EnumMember(Value = "ZYOU")]
        Zyou,

        /// <summary>
        /// Jawar.
        /// </summary>
        [EnumMember(Value = "JAWAR")]
        Jawar,

        /// <summary>
        /// Agsystems.
        /// </summary>
        [EnumMember(Value = "AGSYSTEMS")]
        Agsystems,

        /// <summary>
        /// Gps.
        /// </summary>
        [EnumMember(Value = "GPS")]
        Gps,

        /// <summary>
        /// PttKargo.
        /// </summary>
        [EnumMember(Value = "PTT_KARGO")]
        PttKargo,

        /// <summary>
        /// Maergo.
        /// </summary>
        [EnumMember(Value = "MAERGO")]
        Maergo,

        /// <summary>
        /// Arihantcourier.
        /// </summary>
        [EnumMember(Value = "ARIHANTCOURIER")]
        Arihantcourier,

        /// <summary>
        /// Vtfe.
        /// </summary>
        [EnumMember(Value = "VTFE")]
        Vtfe,

        /// <summary>
        /// Yunant.
        /// </summary>
        [EnumMember(Value = "YUNANT")]
        Yunant,

        /// <summary>
        /// Urbify.
        /// </summary>
        [EnumMember(Value = "URBIFY")]
        Urbify,

        /// <summary>
        /// PackMan.
        /// </summary>
        [EnumMember(Value = "PACK_MAN")]
        PackMan,

        /// <summary>
        /// Liefergrun.
        /// </summary>
        [EnumMember(Value = "LIEFERGRUN")]
        Liefergrun,

        /// <summary>
        /// Obibox.
        /// </summary>
        [EnumMember(Value = "OBIBOX")]
        Obibox,

        /// <summary>
        /// Paikeda.
        /// </summary>
        [EnumMember(Value = "PAIKEDA")]
        Paikeda,

        /// <summary>
        /// Scotty.
        /// </summary>
        [EnumMember(Value = "SCOTTY")]
        Scotty,

        /// <summary>
        /// IntelcomCa.
        /// </summary>
        [EnumMember(Value = "INTELCOM_CA")]
        IntelcomCa,

        /// <summary>
        /// Swe.
        /// </summary>
        [EnumMember(Value = "SWE")]
        Swe,

        /// <summary>
        /// Asendia.
        /// </summary>
        [EnumMember(Value = "ASENDIA")]
        Asendia,

        /// <summary>
        /// DpdAt.
        /// </summary>
        [EnumMember(Value = "DPD_AT")]
        DpdAt,

        /// <summary>
        /// Relay.
        /// </summary>
        [EnumMember(Value = "RELAY")]
        Relay,

        /// <summary>
        /// Ata.
        /// </summary>
        [EnumMember(Value = "ATA")]
        Ata,

        /// <summary>
        /// SkyexpressInternational.
        /// </summary>
        [EnumMember(Value = "SKYEXPRESS_INTERNATIONAL")]
        SkyexpressInternational,

        /// <summary>
        /// SuratKargo.
        /// </summary>
        [EnumMember(Value = "SURAT_KARGO")]
        SuratKargo,

        /// <summary>
        /// Sglink.
        /// </summary>
        [EnumMember(Value = "SGLINK")]
        Sglink,

        /// <summary>
        /// Fleetopticsinc.
        /// </summary>
        [EnumMember(Value = "FLEETOPTICSINC")]
        Fleetopticsinc,

        /// <summary>
        /// Shopline.
        /// </summary>
        [EnumMember(Value = "SHOPLINE")]
        Shopline,

        /// <summary>
        /// Piggyship.
        /// </summary>
        [EnumMember(Value = "PIGGYSHIP")]
        Piggyship,

        /// <summary>
        /// Logoix.
        /// </summary>
        [EnumMember(Value = "LOGOIX")]
        Logoix,

        /// <summary>
        /// KolayGelsin.
        /// </summary>
        [EnumMember(Value = "KOLAY_GELSIN")]
        KolayGelsin,

        /// <summary>
        /// AssociatedCouriers.
        /// </summary>
        [EnumMember(Value = "ASSOCIATED_COURIERS")]
        AssociatedCouriers,

        /// <summary>
        /// UpsChecker.
        /// </summary>
        [EnumMember(Value = "UPS_CHECKER")]
        UpsChecker,

        /// <summary>
        /// Wineshipping.
        /// </summary>
        [EnumMember(Value = "WINESHIPPING")]
        Wineshipping,

        /// <summary>
        /// Spedisci.
        /// </summary>
        [EnumMember(Value = "SPEDISCI")]
        Spedisci,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}