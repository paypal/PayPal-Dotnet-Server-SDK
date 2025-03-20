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
        ///DPD Russia.
        /// DpdRu.
        /// </summary>
        [EnumMember(Value = "DPD_RU")]
        DpdRu,

        /// <summary>
        ///Bulgarian Posts.
        /// BgBulgarianPost.
        /// </summary>
        [EnumMember(Value = "BG_BULGARIAN_POST")]
        BgBulgarianPost,

        /// <summary>
        ///Koreapost (www.koreapost.go.kr).
        /// KrKoreaPost.
        /// </summary>
        [EnumMember(Value = "KR_KOREA_POST")]
        KrKoreaPost,

        /// <summary>
        ///Courier IT.
        /// ZaCourierit.
        /// </summary>
        [EnumMember(Value = "ZA_COURIERIT")]
        ZaCourierit,

        /// <summary>
        ///DPD France (formerly exapaq).
        /// FrExapaq.
        /// </summary>
        [EnumMember(Value = "FR_EXAPAQ")]
        FrExapaq,

        /// <summary>
        ///Emirates Post.
        /// AreEmiratesPost.
        /// </summary>
        [EnumMember(Value = "ARE_EMIRATES_POST")]
        AreEmiratesPost,

        /// <summary>
        ///GAC.
        /// Gac.
        /// </summary>
        [EnumMember(Value = "GAC")]
        Gac,

        /// <summary>
        ///Geis CZ.
        /// Geis.
        /// </summary>
        [EnumMember(Value = "GEIS")]
        Geis,

        /// <summary>
        ///SF Express.
        /// SfEx.
        /// </summary>
        [EnumMember(Value = "SF_EX")]
        SfEx,

        /// <summary>
        ///Pago Logistics.
        /// Pago.
        /// </summary>
        [EnumMember(Value = "PAGO")]
        Pago,

        /// <summary>
        ///MyHermes UK.
        /// Myhermes.
        /// </summary>
        [EnumMember(Value = "MYHERMES")]
        Myhermes,

        /// <summary>
        ///Diamond Eurogistics Limited.
        /// DiamondEurogistics.
        /// </summary>
        [EnumMember(Value = "DIAMOND_EUROGISTICS")]
        DiamondEurogistics,

        /// <summary>
        ///Corporate Couriers.
        /// CorporatecouriersWebhook.
        /// </summary>
        [EnumMember(Value = "CORPORATECOURIERS_WEBHOOK")]
        CorporatecouriersWebhook,

        /// <summary>
        ///Bond courier.
        /// Bond.
        /// </summary>
        [EnumMember(Value = "BOND")]
        Bond,

        /// <summary>
        ///Omni Parcel.
        /// Omniparcel.
        /// </summary>
        [EnumMember(Value = "OMNIPARCEL")]
        Omniparcel,

        /// <summary>
        ///Slovenska pošta.
        /// SkPosta.
        /// </summary>
        [EnumMember(Value = "SK_POSTA")]
        SkPosta,

        /// <summary>
        ///purolator.
        /// Purolator.
        /// </summary>
        [EnumMember(Value = "PUROLATOR")]
        Purolator,

        /// <summary>
        ///Mena 360 (Fetchr).
        /// FetchrWebhook.
        /// </summary>
        [EnumMember(Value = "FETCHR_WEBHOOK")]
        FetchrWebhook,

        /// <summary>
        ///TDG – The Delivery Group.
        /// Thedeliverygroup.
        /// </summary>
        [EnumMember(Value = "THEDELIVERYGROUP")]
        Thedeliverygroup,

        /// <summary>
        ///Cello Square.
        /// CelloSquare.
        /// </summary>
        [EnumMember(Value = "CELLO_SQUARE")]
        CelloSquare,

        /// <summary>
        ///TONDA GLOBAL.
        /// Tarrive.
        /// </summary>
        [EnumMember(Value = "TARRIVE")]
        Tarrive,

        /// <summary>
        ///MDS Collivery Pty (Ltd).
        /// Collivery.
        /// </summary>
        [EnumMember(Value = "COLLIVERY")]
        Collivery,

        /// <summary>
        ///Mainfreight.
        /// Mainfreight.
        /// </summary>
        [EnumMember(Value = "MAINFREIGHT")]
        Mainfreight,

        /// <summary>
        ///First Flight Couriers.
        /// IndFirstflight.
        /// </summary>
        [EnumMember(Value = "IND_FIRSTFLIGHT")]
        IndFirstflight,

        /// <summary>
        ///ACS Worldwide Express.
        /// Acsworldwide.
        /// </summary>
        [EnumMember(Value = "ACSWORLDWIDE")]
        Acsworldwide,

        /// <summary>
        ///Amstan Logistics.
        /// Amstan.
        /// </summary>
        [EnumMember(Value = "AMSTAN")]
        Amstan,

        /// <summary>
        ///OkayParcel.
        /// Okayparcel.
        /// </summary>
        [EnumMember(Value = "OKAYPARCEL")]
        Okayparcel,

        /// <summary>
        ///Envialia Reference.
        /// EnvialiaReference.
        /// </summary>
        [EnumMember(Value = "ENVIALIA_REFERENCE")]
        EnvialiaReference,

        /// <summary>
        ///Seur Spain.
        /// SeurEs.
        /// </summary>
        [EnumMember(Value = "SEUR_ES")]
        SeurEs,

        /// <summary>
        ///Continental.
        /// Continental.
        /// </summary>
        [EnumMember(Value = "CONTINENTAL")]
        Continental,

        /// <summary>
        ///FDSEXPRESS.
        /// Fdsexpress.
        /// </summary>
        [EnumMember(Value = "FDSEXPRESS")]
        Fdsexpress,

        /// <summary>
        ///Swiship UK.
        /// AmazonFbaSwiship.
        /// </summary>
        [EnumMember(Value = "AMAZON_FBA_SWISHIP")]
        AmazonFbaSwiship,

        /// <summary>
        ///Wyngs.
        /// Wyngs.
        /// </summary>
        [EnumMember(Value = "WYNGS")]
        Wyngs,

        /// <summary>
        ///DHL Active Tracing.
        /// DhlActiveTracing.
        /// </summary>
        [EnumMember(Value = "DHL_ACTIVE_TRACING")]
        DhlActiveTracing,

        /// <summary>
        ///Zyllem.
        /// Zyllem.
        /// </summary>
        [EnumMember(Value = "ZYLLEM")]
        Zyllem,

        /// <summary>
        ///Ruston.
        /// Ruston.
        /// </summary>
        [EnumMember(Value = "RUSTON")]
        Ruston,

        /// <summary>
        ///Xpost.ph.
        /// Xpost.
        /// </summary>
        [EnumMember(Value = "XPOST")]
        Xpost,

        /// <summary>
        ///correos Express (www.correos.es).
        /// CorreosEs.
        /// </summary>
        [EnumMember(Value = "CORREOS_ES")]
        CorreosEs,

        /// <summary>
        ///DHL France (www.dhl.com).
        /// DhlFr.
        /// </summary>
        [EnumMember(Value = "DHL_FR")]
        DhlFr,

        /// <summary>
        ///Pan-Asia International.
        /// PanAsia.
        /// </summary>
        [EnumMember(Value = "PAN_ASIA")]
        PanAsia,

        /// <summary>
        ///BRT couriers Italy (www.brt.it).
        /// BrtIt.
        /// </summary>
        [EnumMember(Value = "BRT_IT")]
        BrtIt,

        /// <summary>
        ///SRE Korea (www.srekorea.co.kr).
        /// SreKorea.
        /// </summary>
        [EnumMember(Value = "SRE_KOREA")]
        SreKorea,

        /// <summary>
        ///Spee-Dee Delivery.
        /// Speedee.
        /// </summary>
        [EnumMember(Value = "SPEEDEE")]
        Speedee,

        /// <summary>
        ///TNT UK Limited (www.tnt.com).
        /// TntUk.
        /// </summary>
        [EnumMember(Value = "TNT_UK")]
        TntUk,

        /// <summary>
        ///Venipak.
        /// Venipak.
        /// </summary>
        [EnumMember(Value = "VENIPAK")]
        Venipak,

        /// <summary>
        ///SHREE NANDAN COURIER.
        /// Shreenandancourier.
        /// </summary>
        [EnumMember(Value = "SHREENANDANCOURIER")]
        Shreenandancourier,

        /// <summary>
        ///Croshot.
        /// Croshot.
        /// </summary>
        [EnumMember(Value = "CROSHOT")]
        Croshot,

        /// <summary>
        ///NIpost (www.nipost.gov.ng).
        /// NipostNg.
        /// </summary>
        [EnumMember(Value = "NIPOST_NG")]
        NipostNg,

        /// <summary>
        ///ePost Global.
        /// EpstGlbl.
        /// </summary>
        [EnumMember(Value = "EPST_GLBL")]
        EpstGlbl,

        /// <summary>
        ///Newgistics.
        /// Newgistics.
        /// </summary>
        [EnumMember(Value = "NEWGISTICS")]
        Newgistics,

        /// <summary>
        ///Post of Slovenia.
        /// PostSlovenia.
        /// </summary>
        [EnumMember(Value = "POST_SLOVENIA")]
        PostSlovenia,

        /// <summary>
        ///Jersey Post.
        /// JerseyPost.
        /// </summary>
        [EnumMember(Value = "JERSEY_POST")]
        JerseyPost,

        /// <summary>
        ///Bombino Express Pvt.
        /// Bombinoexp.
        /// </summary>
        [EnumMember(Value = "BOMBINOEXP")]
        Bombinoexp,

        /// <summary>
        ///WMG Delivery.
        /// Wmg.
        /// </summary>
        [EnumMember(Value = "WMG")]
        Wmg,

        /// <summary>
        ///XQ Express.
        /// XqExpress.
        /// </summary>
        [EnumMember(Value = "XQ_EXPRESS")]
        XqExpress,

        /// <summary>
        ///Furdeco.
        /// Furdeco.
        /// </summary>
        [EnumMember(Value = "FURDECO")]
        Furdeco,

        /// <summary>
        ///LHT Express.
        /// LhtExpress.
        /// </summary>
        [EnumMember(Value = "LHT_EXPRESS")]
        LhtExpress,

        /// <summary>
        ///South African Post Office.
        /// SouthAfricanPostOffice.
        /// </summary>
        [EnumMember(Value = "SOUTH_AFRICAN_POST_OFFICE")]
        SouthAfricanPostOffice,

        /// <summary>
        ///SPOTON Logistics Pvt Ltd.
        /// Spoton.
        /// </summary>
        [EnumMember(Value = "SPOTON")]
        Spoton,

        /// <summary>
        ///Dimerco Express Group.
        /// Dimerco.
        /// </summary>
        [EnumMember(Value = "DIMERCO")]
        Dimerco,

        /// <summary>
        ///cyprus post.
        /// CyprusPostCyp.
        /// </summary>
        [EnumMember(Value = "CYPRUS_POST_CYP")]
        CyprusPostCyp,

        /// <summary>
        ///AB Custom Group.
        /// Abcustom.
        /// </summary>
        [EnumMember(Value = "ABCUSTOM")]
        Abcustom,

        /// <summary>
        ///deliverE.
        /// IndDelivree.
        /// </summary>
        [EnumMember(Value = "IND_DELIVREE")]
        IndDelivree,

        /// <summary>
        ///Best Express.
        /// CnBestexpress.
        /// </summary>
        [EnumMember(Value = "CN_BESTEXPRESS")]
        CnBestexpress,

        /// <summary>
        ///DX (SFTP).
        /// DxSftp.
        /// </summary>
        [EnumMember(Value = "DX_SFTP")]
        DxSftp,

        /// <summary>
        ///PICK UPP.
        /// PickuppMys.
        /// </summary>
        [EnumMember(Value = "PICKUPP_MYS")]
        PickuppMys,

        /// <summary>
        ///FMX.
        /// Fmx.
        /// </summary>
        [EnumMember(Value = "FMX")]
        Fmx,

        /// <summary>
        ///Hellmann Worldwide Logistics.
        /// Hellmann.
        /// </summary>
        [EnumMember(Value = "HELLMANN")]
        Hellmann,

        /// <summary>
        ///Ship It Asia.
        /// ShipItAsia.
        /// </summary>
        [EnumMember(Value = "SHIP_IT_ASIA")]
        ShipItAsia,

        /// <summary>
        ///Kerry eCommerce.
        /// KerryEcommerce.
        /// </summary>
        [EnumMember(Value = "KERRY_ECOMMERCE")]
        KerryEcommerce,

        /// <summary>
        ///Frete Rapido.
        /// Freterapido.
        /// </summary>
        [EnumMember(Value = "FRETERAPIDO")]
        Freterapido,

        /// <summary>
        ///Pitney Bowes.
        /// PitneyBowes.
        /// </summary>
        [EnumMember(Value = "PITNEY_BOWES")]
        PitneyBowes,

        /// <summary>
        ///Xpressen courier.
        /// XpressenDk.
        /// </summary>
        [EnumMember(Value = "XPRESSEN_DK")]
        XpressenDk,

        /// <summary>
        ///Spanish Seur API.
        /// SeurSpApi.
        /// </summary>
        [EnumMember(Value = "SEUR_SP_API")]
        SeurSpApi,

        /// <summary>
        ///DELIVERYONTIME LOGISTICS PVT LTD.
        /// Deliveryontime.
        /// </summary>
        [EnumMember(Value = "DELIVERYONTIME")]
        Deliveryontime,

        /// <summary>
        ///JINSUNG TRADING.
        /// Jinsung.
        /// </summary>
        [EnumMember(Value = "JINSUNG")]
        Jinsung,

        /// <summary>
        ///Trans Kargo Internasional.
        /// TransKargo.
        /// </summary>
        [EnumMember(Value = "TRANS_KARGO")]
        TransKargo,

        /// <summary>
        ///Swiship DE.
        /// SwishipDe.
        /// </summary>
        [EnumMember(Value = "SWISHIP_DE")]
        SwishipDe,

        /// <summary>
        ///Ivoy courier.
        /// IvoyWebhook.
        /// </summary>
        [EnumMember(Value = "IVOY_WEBHOOK")]
        IvoyWebhook,

        /// <summary>
        ///Airmee couriers.
        /// AirmeeWebhook.
        /// </summary>
        [EnumMember(Value = "AIRMEE_WEBHOOK")]
        AirmeeWebhook,

        /// <summary>
        ///dhl benelux.
        /// DhlBenelux.
        /// </summary>
        [EnumMember(Value = "DHL_BENELUX")]
        DhlBenelux,

        /// <summary>
        ///FirstMile.
        /// Firstmile.
        /// </summary>
        [EnumMember(Value = "FIRSTMILE")]
        Firstmile,

        /// <summary>
        ///Fastway Ireland.
        /// FastwayIr.
        /// </summary>
        [EnumMember(Value = "FASTWAY_IR")]
        FastwayIr,

        /// <summary>
        ///Hua Han Logistics.
        /// HhExp.
        /// </summary>
        [EnumMember(Value = "HH_EXP")]
        HhExp,

        /// <summary>
        ///Mypostonline.
        /// MysMypostOnline.
        /// </summary>
        [EnumMember(Value = "MYS_MYPOST_ONLINE")]
        MysMypostOnline,

        /// <summary>
        ///THT Netherland.
        /// TntNl.
        /// </summary>
        [EnumMember(Value = "TNT_NL")]
        TntNl,

        /// <summary>
        ///TIPSA courier.
        /// Tipsa.
        /// </summary>
        [EnumMember(Value = "TIPSA")]
        Tipsa,

        /// <summary>
        ///TAQBIN Malaysia.
        /// TaqbinMy.
        /// </summary>
        [EnumMember(Value = "TAQBIN_MY")]
        TaqbinMy,

        /// <summary>
        ///KGM Hub.
        /// Kgmhub.
        /// </summary>
        [EnumMember(Value = "KGMHUB")]
        Kgmhub,

        /// <summary>
        ///Internet Express.
        /// Intexpress.
        /// </summary>
        [EnumMember(Value = "INTEXPRESS")]
        Intexpress,

        /// <summary>
        ///Overseas Express.
        /// OverseExp.
        /// </summary>
        [EnumMember(Value = "OVERSE_EXP")]
        OverseExp,

        /// <summary>
        ///One click delivery services.
        /// Oneclick.
        /// </summary>
        [EnumMember(Value = "ONECLICK")]
        Oneclick,

        /// <summary>
        ///Roadbull Logistics.
        /// RoadrunnerFreight.
        /// </summary>
        [EnumMember(Value = "ROADRUNNER_FREIGHT")]
        RoadrunnerFreight,

        /// <summary>
        ///GLS Croatia.
        /// GlsCrotia.
        /// </summary>
        [EnumMember(Value = "GLS_CROTIA")]
        GlsCrotia,

        /// <summary>
        ///MRW courier.
        /// MrwFtp.
        /// </summary>
        [EnumMember(Value = "MRW_FTP")]
        MrwFtp,

        /// <summary>
        ///Blue Express.
        /// Bluex.
        /// </summary>
        [EnumMember(Value = "BLUEX")]
        Bluex,

        /// <summary>
        ///Daylight Transport.
        /// Dylt.
        /// </summary>
        [EnumMember(Value = "DYLT")]
        Dylt,

        /// <summary>
        ///DPD Ireland.
        /// DpdIr.
        /// </summary>
        [EnumMember(Value = "DPD_IR")]
        DpdIr,

        /// <summary>
        ///Sin Global Express.
        /// SinGlbl.
        /// </summary>
        [EnumMember(Value = "SIN_GLBL")]
        SinGlbl,

        /// <summary>
        ///Tuffnells Parcels Express- Reference.
        /// TuffnellsReference.
        /// </summary>
        [EnumMember(Value = "TUFFNELLS_REFERENCE")]
        TuffnellsReference,

        /// <summary>
        ///CJ Packet.
        /// Cjpacket.
        /// </summary>
        [EnumMember(Value = "CJPACKET")]
        Cjpacket,

        /// <summary>
        ///Milkman courier.
        /// Milkman.
        /// </summary>
        [EnumMember(Value = "MILKMAN")]
        Milkman,

        /// <summary>
        ///ASIGNA courier.
        /// Asigna.
        /// </summary>
        [EnumMember(Value = "ASIGNA")]
        Asigna,

        /// <summary>
        ///One World Express.
        /// Oneworldexpress.
        /// </summary>
        [EnumMember(Value = "ONEWORLDEXPRESS")]
        Oneworldexpress,

        /// <summary>
        ///RoyalShipments.
        /// RoyalMail.
        /// </summary>
        [EnumMember(Value = "ROYAL_MAIL")]
        RoyalMail,

        /// <summary>
        ///Viaxpress.
        /// ViaExpress.
        /// </summary>
        [EnumMember(Value = "VIA_EXPRESS")]
        ViaExpress,

        /// <summary>
        ///TIG Freight.
        /// Tigfreight.
        /// </summary>
        [EnumMember(Value = "TIGFREIGHT")]
        Tigfreight,

        /// <summary>
        ///ZTO Express.
        /// ZtoExpress.
        /// </summary>
        [EnumMember(Value = "ZTO_EXPRESS")]
        ZtoExpress,

        /// <summary>
        ///2GO Courier.
        /// TwoGo.
        /// </summary>
        [EnumMember(Value = "TWO_GO")]
        TwoGo,

        /// <summary>
        ///IML courier.
        /// Iml.
        /// </summary>
        [EnumMember(Value = "IML")]
        Iml,

        /// <summary>
        ///Intel-Valley Supply chain (ShenZhen) Co. Ltd.
        /// IntelValley.
        /// </summary>
        [EnumMember(Value = "INTEL_VALLEY")]
        IntelValley,

        /// <summary>
        ///EFS (E-commerce Fulfillment Service).
        /// Efs.
        /// </summary>
        [EnumMember(Value = "EFS")]
        Efs,

        /// <summary>
        ///UK mail (ukmail.com).
        /// UkUkMail.
        /// </summary>
        [EnumMember(Value = "UK_UK_MAIL")]
        UkUkMail,

        /// <summary>
        ///RAM courier.
        /// Ram.
        /// </summary>
        [EnumMember(Value = "RAM")]
        Ram,

        /// <summary>
        ///Allied Express.
        /// Alliedexpress.
        /// </summary>
        [EnumMember(Value = "ALLIEDEXPRESS")]
        Alliedexpress,

        /// <summary>
        ///APC overnight (apc-overnight.com).
        /// ApcOvernight.
        /// </summary>
        [EnumMember(Value = "APC_OVERNIGHT")]
        ApcOvernight,

        /// <summary>
        ///Shippit.
        /// Shippit.
        /// </summary>
        [EnumMember(Value = "SHIPPIT")]
        Shippit,

        /// <summary>
        ///TFM Xpress.
        /// Tfm.
        /// </summary>
        [EnumMember(Value = "TFM")]
        Tfm,

        /// <summary>
        ///M Xpress Sdn Bhd.
        /// MXpress.
        /// </summary>
        [EnumMember(Value = "M_XPRESS")]
        MXpress,

        /// <summary>
        ///Haidaibao (BOX).
        /// HdbBox.
        /// </summary>
        [EnumMember(Value = "HDB_BOX")]
        HdbBox,

        /// <summary>
        ///Clevy Links.
        /// ClevyLinks.
        /// </summary>
        [EnumMember(Value = "CLEVY_LINKS")]
        ClevyLinks,

        /// <summary>
        ///Beone Logistics.
        /// Ibeone.
        /// </summary>
        [EnumMember(Value = "IBEONE")]
        Ibeone,

        /// <summary>
        ///Fiege Netherlands.
        /// FiegeNl.
        /// </summary>
        [EnumMember(Value = "FIEGE_NL")]
        FiegeNl,

        /// <summary>
        ///KWE Global.
        /// KweGlobal.
        /// </summary>
        [EnumMember(Value = "KWE_GLOBAL")]
        KweGlobal,

        /// <summary>
        ///CTC Express.
        /// CtcExpress.
        /// </summary>
        [EnumMember(Value = "CTC_EXPRESS")]
        CtcExpress,

        /// <summary>
        ///Amazon Shipping.
        /// Amazon.
        /// </summary>
        [EnumMember(Value = "AMAZON")]
        Amazon,

        /// <summary>
        ///Morelink.
        /// MoreLink.
        /// </summary>
        [EnumMember(Value = "MORE_LINK")]
        MoreLink,

        /// <summary>
        ///JX courier.
        /// Jx.
        /// </summary>
        [EnumMember(Value = "JX")]
        Jx,

        /// <summary>
        ///Easy Mail.
        /// EasyMail.
        /// </summary>
        [EnumMember(Value = "EASY_MAIL")]
        EasyMail,

        /// <summary>
        ///A Duie Pyle.
        /// Aduiepyle.
        /// </summary>
        [EnumMember(Value = "ADUIEPYLE")]
        Aduiepyle,

        /// <summary>
        ///Panther.
        /// GbPanther.
        /// </summary>
        [EnumMember(Value = "GB_PANTHER")]
        GbPanther,

        /// <summary>
        ///Expresssale.
        /// Expresssale.
        /// </summary>
        [EnumMember(Value = "EXPRESSSALE")]
        Expresssale,

        /// <summary>
        ///Detrack.
        /// SgDetrack.
        /// </summary>
        [EnumMember(Value = "SG_DETRACK")]
        SgDetrack,

        /// <summary>
        ///Trunkrs courier.
        /// TrunkrsWebhook.
        /// </summary>
        [EnumMember(Value = "TRUNKRS_WEBHOOK")]
        TrunkrsWebhook,

        /// <summary>
        ///Matdespatch.
        /// Matdespatch.
        /// </summary>
        [EnumMember(Value = "MATDESPATCH")]
        Matdespatch,

        /// <summary>
        ///GLS Logistic Systems Canada Ltd./Dicom.
        /// Dicom.
        /// </summary>
        [EnumMember(Value = "DICOM")]
        Dicom,

        /// <summary>
        ///MBW Courier Inc..
        /// Mbw.
        /// </summary>
        [EnumMember(Value = "MBW")]
        Mbw,

        /// <summary>
        ///Cambodia Post.
        /// KhmCambodiaPost.
        /// </summary>
        [EnumMember(Value = "KHM_CAMBODIA_POST")]
        KhmCambodiaPost,

        /// <summary>
        ///Sinotrans.
        /// Sinotrans.
        /// </summary>
        [EnumMember(Value = "SINOTRANS")]
        Sinotrans,

        /// <summary>
        ///BRT Bartolini(Parcel ID).
        /// BrtItParcelid.
        /// </summary>
        [EnumMember(Value = "BRT_IT_PARCELID")]
        BrtItParcelid,

        /// <summary>
        ///DHL Supply Chain APAC.
        /// DhlSupplyChain.
        /// </summary>
        [EnumMember(Value = "DHL_SUPPLY_CHAIN")]
        DhlSupplyChain,

        /// <summary>
        ///DHL Poland.
        /// DhlPl.
        /// </summary>
        [EnumMember(Value = "DHL_PL")]
        DhlPl,

        /// <summary>
        ///TopYou.
        /// Topyou.
        /// </summary>
        [EnumMember(Value = "TOPYOU")]
        Topyou,

        /// <summary>
        ///PAL Express Limited.
        /// Palexpress.
        /// </summary>
        [EnumMember(Value = "PALEXPRESS")]
        Palexpress,

        /// <summary>
        ///dhl Singapore.
        /// DhlSg.
        /// </summary>
        [EnumMember(Value = "DHL_SG")]
        DhlSg,

        /// <summary>
        ///WeDo Logistics.
        /// CnWedo.
        /// </summary>
        [EnumMember(Value = "CN_WEDO")]
        CnWedo,

        /// <summary>
        ///Fulfillme.
        /// Fulfillme.
        /// </summary>
        [EnumMember(Value = "FULFILLME")]
        Fulfillme,

        /// <summary>
        ///DPD delistrack.
        /// DpdDelistrack.
        /// </summary>
        [EnumMember(Value = "DPD_DELISTRACK")]
        DpdDelistrack,

        /// <summary>
        ///UPS Reference.
        /// UpsReference.
        /// </summary>
        [EnumMember(Value = "UPS_REFERENCE")]
        UpsReference,

        /// <summary>
        ///Caribou.
        /// Caribou.
        /// </summary>
        [EnumMember(Value = "CARIBOU")]
        Caribou,

        /// <summary>
        ///Locus courier.
        /// LocusWebhook.
        /// </summary>
        [EnumMember(Value = "LOCUS_WEBHOOK")]
        LocusWebhook,

        /// <summary>
        ///DSV courier.
        /// Dsv.
        /// </summary>
        [EnumMember(Value = "DSV")]
        Dsv,

        /// <summary>
        ///P2P TrakPak.
        /// P2PTrc.
        /// </summary>
        [EnumMember(Value = "P2P_TRC")]
        P2PTrc,

        /// <summary>
        ///Direct Parcels.
        /// Directparcels.
        /// </summary>
        [EnumMember(Value = "DIRECTPARCELS")]
        Directparcels,

        /// <summary>
        ///Nova Poshta (International).
        /// NovaPoshtaInt.
        /// </summary>
        [EnumMember(Value = "NOVA_POSHTA_INT")]
        NovaPoshtaInt,

        /// <summary>
        ///FedEx® Poland Domestic.
        /// FedexPoland.
        /// </summary>
        [EnumMember(Value = "FEDEX_POLAND")]
        FedexPoland,

        /// <summary>
        ///JCEX courier.
        /// CnJcex.
        /// </summary>
        [EnumMember(Value = "CN_JCEX")]
        CnJcex,

        /// <summary>
        ///FAR international.
        /// FarInternational.
        /// </summary>
        [EnumMember(Value = "FAR_INTERNATIONAL")]
        FarInternational,

        /// <summary>
        ///IDEX courier.
        /// Idexpress.
        /// </summary>
        [EnumMember(Value = "IDEXPRESS")]
        Idexpress,

        /// <summary>
        ///GANGBAO Supplychain.
        /// Gangbao.
        /// </summary>
        [EnumMember(Value = "GANGBAO")]
        Gangbao,

        /// <summary>
        ///Neway Transport.
        /// Neway.
        /// </summary>
        [EnumMember(Value = "NEWAY")]
        Neway,

        /// <summary>
        ///PostNL International.
        /// PostnlInt3S.
        /// </summary>
        [EnumMember(Value = "POSTNL_INT_3_S")]
        PostnlInt3S,

        /// <summary>
        ///RPX Indonesia.
        /// RpxId.
        /// </summary>
        [EnumMember(Value = "RPX_ID")]
        RpxId,

        /// <summary>
        ///Designer Transport.
        /// DesignertransportWebhook.
        /// </summary>
        [EnumMember(Value = "DESIGNERTRANSPORT_WEBHOOK")]
        DesignertransportWebhook,

        /// <summary>
        ///GLS Slovenia.
        /// GlsSloven.
        /// </summary>
        [EnumMember(Value = "GLS_SLOVEN")]
        GlsSloven,

        /// <summary>
        ///Parcelled.in.
        /// ParcelledIn.
        /// </summary>
        [EnumMember(Value = "PARCELLED_IN")]
        ParcelledIn,

        /// <summary>
        ///GSI EXPRESS.
        /// GsiExpress.
        /// </summary>
        [EnumMember(Value = "GSI_EXPRESS")]
        GsiExpress,

        /// <summary>
        ///Con-way Freight.
        /// ConWay.
        /// </summary>
        [EnumMember(Value = "CON_WAY")]
        ConWay,

        /// <summary>
        ///Brouwer Transport en Logistiek.
        /// BrouwerTransport.
        /// </summary>
        [EnumMember(Value = "BROUWER_TRANSPORT")]
        BrouwerTransport,

        /// <summary>
        ///Captain Express International.
        /// Cpex.
        /// </summary>
        [EnumMember(Value = "CPEX")]
        Cpex,

        /// <summary>
        ///Israel Post.
        /// IsraelPost.
        /// </summary>
        [EnumMember(Value = "ISRAEL_POST")]
        IsraelPost,

        /// <summary>
        ///DTDC India.
        /// DtdcIn.
        /// </summary>
        [EnumMember(Value = "DTDC_IN")]
        DtdcIn,

        /// <summary>
        ///PTT Post.
        /// PttPost.
        /// </summary>
        [EnumMember(Value = "PTT_POST")]
        PttPost,

        /// <summary>
        ///Ximex Delivery Express.
        /// XdeWebhook.
        /// </summary>
        [EnumMember(Value = "XDE_WEBHOOK")]
        XdeWebhook,

        /// <summary>
        ///Tolos courier.
        /// Tolos.
        /// </summary>
        [EnumMember(Value = "TOLOS")]
        Tolos,

        /// <summary>
        ///Giao hàng nhanh.
        /// GiaoHang.
        /// </summary>
        [EnumMember(Value = "GIAO_HANG")]
        GiaoHang,

        /// <summary>
        ///Geodis E-space.
        /// GeodisEspace.
        /// </summary>
        [EnumMember(Value = "GEODIS_ESPACE")]
        GeodisEspace,

        /// <summary>
        ///Magyar Post.
        /// MagyarHu.
        /// </summary>
        [EnumMember(Value = "MAGYAR_HU")]
        MagyarHu,

        /// <summary>
        ///DoorDash.
        /// DoordashWebhook.
        /// </summary>
        [EnumMember(Value = "DOORDASH_WEBHOOK")]
        DoordashWebhook,

        /// <summary>
        ///Tiki shipment.
        /// TikiId.
        /// </summary>
        [EnumMember(Value = "TIKI_ID")]
        TikiId,

        /// <summary>
        ///CJ Logistics International(Hong Kong).
        /// CjHkInternational.
        /// </summary>
        [EnumMember(Value = "CJ_HK_INTERNATIONAL")]
        CjHkInternational,

        /// <summary>
        ///Star Track Express.
        /// StarTrackExpress.
        /// </summary>
        [EnumMember(Value = "STAR_TRACK_EXPRESS")]
        StarTrackExpress,

        /// <summary>
        ///Helthjem.
        /// Helthjem.
        /// </summary>
        [EnumMember(Value = "HELTHJEM")]
        Helthjem,

        /// <summary>
        ///SF International.
        /// Sfb2C.
        /// </summary>
        [EnumMember(Value = "SFB2C")]
        Sfb2C,

        /// <summary>
        ///Freightquote by C.H. Robinson.
        /// Freightquote.
        /// </summary>
        [EnumMember(Value = "FREIGHTQUOTE")]
        Freightquote,

        /// <summary>
        ///Landmark Global Reference.
        /// LandmarkGlobalReference.
        /// </summary>
        [EnumMember(Value = "LANDMARK_GLOBAL_REFERENCE")]
        LandmarkGlobalReference,

        /// <summary>
        ///Parcel2Go.
        /// Parcel2Go.
        /// </summary>
        [EnumMember(Value = "PARCEL2GO")]
        Parcel2Go,

        /// <summary>
        ///Delnext.
        /// Delnext.
        /// </summary>
        [EnumMember(Value = "DELNEXT")]
        Delnext,

        /// <summary>
        ///Red Carpet Logistics.
        /// Rcl.
        /// </summary>
        [EnumMember(Value = "RCL")]
        Rcl,

        /// <summary>
        ///CGS Express.
        /// CgsExpress.
        /// </summary>
        [EnumMember(Value = "CGS_EXPRESS")]
        CgsExpress,

        /// <summary>
        ///Hongkong Post (www.hongkongpost.hk).
        /// HkPost.
        /// </summary>
        [EnumMember(Value = "HK_POST")]
        HkPost,

        /// <summary>
        ///SAP EXPRESS.
        /// SapExpress.
        /// </summary>
        [EnumMember(Value = "SAP_EXPRESS")]
        SapExpress,

        /// <summary>
        ///Parcel Post Singapore.
        /// ParcelpostSg.
        /// </summary>
        [EnumMember(Value = "PARCELPOST_SG")]
        ParcelpostSg,

        /// <summary>
        ///HermesWorld UK.
        /// Hermes.
        /// </summary>
        [EnumMember(Value = "HERMES")]
        Hermes,

        /// <summary>
        ///Safexpress.
        /// IndSafeexpress.
        /// </summary>
        [EnumMember(Value = "IND_SAFEEXPRESS")]
        IndSafeexpress,

        /// <summary>
        ///Tophatter Express.
        /// Tophatterexpress.
        /// </summary>
        [EnumMember(Value = "TOPHATTEREXPRESS")]
        Tophatterexpress,

        /// <summary>
        ///PT MGLOBAL LOGISTICS INDONESIA.
        /// Mglobal.
        /// </summary>
        [EnumMember(Value = "MGLOBAL")]
        Mglobal,

        /// <summary>
        ///Averitt Express.
        /// Averitt.
        /// </summary>
        [EnumMember(Value = "AVERITT")]
        Averitt,

        /// <summary>
        ///leader.
        /// Leader.
        /// </summary>
        [EnumMember(Value = "LEADER")]
        Leader,

        /// <summary>
        ///2ebox courier.
        /// _2Ebox.
        /// </summary>
        [EnumMember(Value = "_2EBOX")]
        _2Ebox,

        /// <summary>
        ///Singapore Speedpost.
        /// SgSpeedpost.
        /// </summary>
        [EnumMember(Value = "SG_SPEEDPOST")]
        SgSpeedpost,

        /// <summary>
        ///DB Schenker (www.dbschenker.com).
        /// DbschenkerSe.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_SE")]
        DbschenkerSe,

        /// <summary>
        ///Israel Post Domestic.
        /// IsrPostDomestic.
        /// </summary>
        [EnumMember(Value = "ISR_POST_DOMESTIC")]
        IsrPostDomestic,

        /// <summary>
        ///Best Way Parcel.
        /// Bestwayparcel.
        /// </summary>
        [EnumMember(Value = "BESTWAYPARCEL")]
        Bestwayparcel,

        /// <summary>
        ///asendia_de.
        /// AsendiaDe.
        /// </summary>
        [EnumMember(Value = "ASENDIA_DE")]
        AsendiaDe,

        /// <summary>
        ///nightline_uk.
        /// NightlineUk.
        /// </summary>
        [EnumMember(Value = "NIGHTLINE_UK")]
        NightlineUk,

        /// <summary>
        ///taqbin_sg.
        /// TaqbinSg.
        /// </summary>
        [EnumMember(Value = "TAQBIN_SG")]
        TaqbinSg,

        /// <summary>
        ///TCK Express.
        /// TckExpress.
        /// </summary>
        [EnumMember(Value = "TCK_EXPRESS")]
        TckExpress,

        /// <summary>
        ///Endeavour Delivery.
        /// EndeavourDelivery.
        /// </summary>
        [EnumMember(Value = "ENDEAVOUR_DELIVERY")]
        EndeavourDelivery,

        /// <summary>
        ///Nanjing Woyuan.
        /// Nanjingwoyuan.
        /// </summary>
        [EnumMember(Value = "NANJINGWOYUAN")]
        Nanjingwoyuan,

        /// <summary>
        ///Heppner France.
        /// HeppnerFr.
        /// </summary>
        [EnumMember(Value = "HEPPNER_FR")]
        HeppnerFr,

        /// <summary>
        ///EMPS Express.
        /// EmpsCn.
        /// </summary>
        [EnumMember(Value = "EMPS_CN")]
        EmpsCn,

        /// <summary>
        ///Fonsen Logistics.
        /// Fonsen.
        /// </summary>
        [EnumMember(Value = "FONSEN")]
        Fonsen,

        /// <summary>
        ///Pickrr.
        /// Pickrr.
        /// </summary>
        [EnumMember(Value = "PICKRR")]
        Pickrr,

        /// <summary>
        ///APC Overnight Consignment.
        /// ApcOvernightConnum.
        /// </summary>
        [EnumMember(Value = "APC_OVERNIGHT_CONNUM")]
        ApcOvernightConnum,

        /// <summary>
        ///Star Track Next Flight.
        /// StarTrackNextFlight.
        /// </summary>
        [EnumMember(Value = "STAR_TRACK_NEXT_FLIGHT")]
        StarTrackNextFlight,

        /// <summary>
        ///Shanghai Aqrum Chemical Logistics Co.Ltd.
        /// Dajin.
        /// </summary>
        [EnumMember(Value = "DAJIN")]
        Dajin,

        /// <summary>
        ///UPS Freight.
        /// UpsFreight.
        /// </summary>
        [EnumMember(Value = "UPS_FREIGHT")]
        UpsFreight,

        /// <summary>
        ///Posta Plus.
        /// PostaPlus.
        /// </summary>
        [EnumMember(Value = "POSTA_PLUS")]
        PostaPlus,

        /// <summary>
        ///CEVA LOGISTICS.
        /// Ceva.
        /// </summary>
        [EnumMember(Value = "CEVA")]
        Ceva,

        /// <summary>
        ///ANSERX courier.
        /// Anserx.
        /// </summary>
        [EnumMember(Value = "ANSERX")]
        Anserx,

        /// <summary>
        ///JS EXPRESS.
        /// JsExpress.
        /// </summary>
        [EnumMember(Value = "JS_EXPRESS")]
        JsExpress,

        /// <summary>
        ///padtf.com.
        /// Padtf.
        /// </summary>
        [EnumMember(Value = "PADTF")]
        Padtf,

        /// <summary>
        ///UPS Mail Innovations.
        /// UpsMailInnovations.
        /// </summary>
        [EnumMember(Value = "UPS_MAIL_INNOVATIONS")]
        UpsMailInnovations,

        /// <summary>
        ///Sunyou Post.
        /// Sypost.
        /// </summary>
        [EnumMember(Value = "SYPOST")]
        Sypost,

        /// <summary>
        ///Amazon Shipping + Amazon MCF.
        /// AmazonShipMcf.
        /// </summary>
        [EnumMember(Value = "AMAZON_SHIP_MCF")]
        AmazonShipMcf,

        /// <summary>
        ///Yusen Logistics.
        /// Yusen.
        /// </summary>
        [EnumMember(Value = "YUSEN")]
        Yusen,

        /// <summary>
        ///Bring.
        /// Bring.
        /// </summary>
        [EnumMember(Value = "BRING")]
        Bring,

        /// <summary>
        ///SDA Italy.
        /// SdaIt.
        /// </summary>
        [EnumMember(Value = "SDA_IT")]
        SdaIt,

        /// <summary>
        ///GBA Services Ltd.
        /// Gba.
        /// </summary>
        [EnumMember(Value = "GBA")]
        Gba,

        /// <summary>
        ///Newegg Express.
        /// Neweggexpress.
        /// </summary>
        [EnumMember(Value = "NEWEGGEXPRESS")]
        Neweggexpress,

        /// <summary>
        ///Speed Couriers.
        /// SpeedcouriersGr.
        /// </summary>
        [EnumMember(Value = "SPEEDCOURIERS_GR")]
        SpeedcouriersGr,

        /// <summary>
        ///forrun Pvt Ltd (Arpatech Venture).
        /// Forrun.
        /// </summary>
        [EnumMember(Value = "FORRUN")]
        Forrun,

        /// <summary>
        ///Pickupp.
        /// Pickup.
        /// </summary>
        [EnumMember(Value = "PICKUP")]
        Pickup,

        /// <summary>
        ///ECMS International Logistics Co..
        /// Ecms.
        /// </summary>
        [EnumMember(Value = "ECMS")]
        Ecms,

        /// <summary>
        ///Intelipost (TMS for LATAM).
        /// Intelipost.
        /// </summary>
        [EnumMember(Value = "INTELIPOST")]
        Intelipost,

        /// <summary>
        ///Flash Express.
        /// Flashexpress.
        /// </summary>
        [EnumMember(Value = "FLASHEXPRESS")]
        Flashexpress,

        /// <summary>
        ///STO Express.
        /// CnSto.
        /// </summary>
        [EnumMember(Value = "CN_STO")]
        CnSto,

        /// <summary>
        ///SEKO Worldwide.
        /// SekoSftp.
        /// </summary>
        [EnumMember(Value = "SEKO_SFTP")]
        SekoSftp,

        /// <summary>
        ///Home Delivery Solutions Ltd.
        /// HomeDeliverySolutions.
        /// </summary>
        [EnumMember(Value = "HOME_DELIVERY_SOLUTIONS")]
        HomeDeliverySolutions,

        /// <summary>
        ///DPD Hungary.
        /// DpdHgry.
        /// </summary>
        [EnumMember(Value = "DPD_HGRY")]
        DpdHgry,

        /// <summary>
        ///Kerry Express (Vietnam) Co Ltd.
        /// KerryttcVn.
        /// </summary>
        [EnumMember(Value = "KERRYTTC_VN")]
        KerryttcVn,

        /// <summary>
        ///Joying Box.
        /// JoyingBox.
        /// </summary>
        [EnumMember(Value = "JOYING_BOX")]
        JoyingBox,

        /// <summary>
        ///Total Express.
        /// TotalExpress.
        /// </summary>
        [EnumMember(Value = "TOTAL_EXPRESS")]
        TotalExpress,

        /// <summary>
        ///ZJS International.
        /// ZjsExpress.
        /// </summary>
        [EnumMember(Value = "ZJS_EXPRESS")]
        ZjsExpress,

        /// <summary>
        ///STARKEN couriers.
        /// Starken.
        /// </summary>
        [EnumMember(Value = "STARKEN")]
        Starken,

        /// <summary>
        ///DemandShip.
        /// Demandship.
        /// </summary>
        [EnumMember(Value = "DEMANDSHIP")]
        Demandship,

        /// <summary>
        ///DPEX.
        /// CnDpex.
        /// </summary>
        [EnumMember(Value = "CN_DPEX")]
        CnDpex,

        /// <summary>
        ///AuPost China.
        /// AupostCn.
        /// </summary>
        [EnumMember(Value = "AUPOST_CN")]
        AupostCn,

        /// <summary>
        ///Logisters.
        /// Logisters.
        /// </summary>
        [EnumMember(Value = "LOGISTERS")]
        Logisters,

        /// <summary>
        ///Global Post.
        /// Goglobalpost.
        /// </summary>
        [EnumMember(Value = "GOGLOBALPOST")]
        Goglobalpost,

        /// <summary>
        ///GLS Czech Republic.
        /// GlsCz.
        /// </summary>
        [EnumMember(Value = "GLS_CZ")]
        GlsCz,

        /// <summary>
        ///Paack courier.
        /// PaackWebhook.
        /// </summary>
        [EnumMember(Value = "PAACK_WEBHOOK")]
        PaackWebhook,

        /// <summary>
        ///Grab courier.
        /// GrabWebhook.
        /// </summary>
        [EnumMember(Value = "GRAB_WEBHOOK")]
        GrabWebhook,

        /// <summary>
        ///Parcelpoint.
        /// Parcelpoint.
        /// </summary>
        [EnumMember(Value = "PARCELPOINT")]
        Parcelpoint,

        /// <summary>
        ///iCumulus.
        /// Icumulus.
        /// </summary>
        [EnumMember(Value = "ICUMULUS")]
        Icumulus,

        /// <summary>
        ///DAI Post.
        /// Daiglobaltrack.
        /// </summary>
        [EnumMember(Value = "DAIGLOBALTRACK")]
        Daiglobaltrack,

        /// <summary>
        ///i-parcel.
        /// GlobalIparcel.
        /// </summary>
        [EnumMember(Value = "GLOBAL_IPARCEL")]
        GlobalIparcel,

        /// <summary>
        ///Yurtici Kargo.
        /// YurticiKargo.
        /// </summary>
        [EnumMember(Value = "YURTICI_KARGO")]
        YurticiKargo,

        /// <summary>
        ///PayPal Package.
        /// CnPaypalPackage.
        /// </summary>
        [EnumMember(Value = "CN_PAYPAL_PACKAGE")]
        CnPaypalPackage,

        /// <summary>
        ///Parcel To Post.
        /// Parcel2Post.
        /// </summary>
        [EnumMember(Value = "PARCEL_2_POST")]
        Parcel2Post,

        /// <summary>
        ///GLS Italy.
        /// GlsIt.
        /// </summary>
        [EnumMember(Value = "GLS_IT")]
        GlsIt,

        /// <summary>
        ///PIL Logistics (China) Co..
        /// PilLogistics.
        /// </summary>
        [EnumMember(Value = "PIL_LOGISTICS")]
        PilLogistics,

        /// <summary>
        ///Heppner Internationale Spedition GmbH & Co..
        /// Heppner.
        /// </summary>
        [EnumMember(Value = "HEPPNER")]
        Heppner,

        /// <summary>
        ///Go!Express and logistics.
        /// GeneralOvernight.
        /// </summary>
        [EnumMember(Value = "GENERAL_OVERNIGHT")]
        GeneralOvernight,

        /// <summary>
        ///Happy 2ThePoint.
        /// Happy2Point.
        /// </summary>
        [EnumMember(Value = "HAPPY2POINT")]
        Happy2Point,

        /// <summary>
        ///Chit Chats.
        /// Chitchats.
        /// </summary>
        [EnumMember(Value = "CHITCHATS")]
        Chitchats,

        /// <summary>
        ///Smooth Couriers.
        /// Smooth.
        /// </summary>
        [EnumMember(Value = "SMOOTH")]
        Smooth,

        /// <summary>
        ///CL E-Logistics Solutions Limited.
        /// CleLogistics.
        /// </summary>
        [EnumMember(Value = "CLE_LOGISTICS")]
        CleLogistics,

        /// <summary>
        ///Fiege Logistics.
        /// Fiege.
        /// </summary>
        [EnumMember(Value = "FIEGE")]
        Fiege,

        /// <summary>
        ///M&X cargo.
        /// MxCargo.
        /// </summary>
        [EnumMember(Value = "MX_CARGO")]
        MxCargo,

        /// <summary>
        ///Ziing Final Mile Inc.
        /// Ziingfinalmile.
        /// </summary>
        [EnumMember(Value = "ZIINGFINALMILE")]
        Ziingfinalmile,

        /// <summary>
        ///Dayton Freight.
        /// DaytonFreight.
        /// </summary>
        [EnumMember(Value = "DAYTON_FREIGHT")]
        DaytonFreight,

        /// <summary>
        ///TCS courier.
        /// Tcs.
        /// </summary>
        [EnumMember(Value = "TCS")]
        Tcs,

        /// <summary>
        ///AEX Group.
        /// Aex.
        /// </summary>
        [EnumMember(Value = "AEX")]
        Aex,

        /// <summary>
        ///Hermes Germany.
        /// HermesDe.
        /// </summary>
        [EnumMember(Value = "HERMES_DE")]
        HermesDe,

        /// <summary>
        ///Routific.
        /// RoutificWebhook.
        /// </summary>
        [EnumMember(Value = "ROUTIFIC_WEBHOOK")]
        RoutificWebhook,

        /// <summary>
        ///Globavend.
        /// Globavend.
        /// </summary>
        [EnumMember(Value = "GLOBAVEND")]
        Globavend,

        /// <summary>
        ///CJ Logistics International.
        /// CjLogistics.
        /// </summary>
        [EnumMember(Value = "CJ_LOGISTICS")]
        CjLogistics,

        /// <summary>
        ///The Pallet Network.
        /// PalletNetwork.
        /// </summary>
        [EnumMember(Value = "PALLET_NETWORK")]
        PalletNetwork,

        /// <summary>
        ///RAF Philippines.
        /// RafPh.
        /// </summary>
        [EnumMember(Value = "RAF_PH")]
        RafPh,

        /// <summary>
        ///XDP Express.
        /// UkXdp.
        /// </summary>
        [EnumMember(Value = "UK_XDP")]
        UkXdp,

        /// <summary>
        ///Paper Express.
        /// PaperExpress.
        /// </summary>
        [EnumMember(Value = "PAPER_EXPRESS")]
        PaperExpress,

        /// <summary>
        ///La Poste.
        /// LaPosteSuivi.
        /// </summary>
        [EnumMember(Value = "LA_POSTE_SUIVI")]
        LaPosteSuivi,

        /// <summary>
        ///Paquetexpress.
        /// Paquetexpress.
        /// </summary>
        [EnumMember(Value = "PAQUETEXPRESS")]
        Paquetexpress,

        /// <summary>
        ///liefery.
        /// Liefery.
        /// </summary>
        [EnumMember(Value = "LIEFERY")]
        Liefery,

        /// <summary>
        ///Streck Transport.
        /// StreckTransport.
        /// </summary>
        [EnumMember(Value = "STRECK_TRANSPORT")]
        StreckTransport,

        /// <summary>
        ///Pony express.
        /// PonyExpress.
        /// </summary>
        [EnumMember(Value = "PONY_EXPRESS")]
        PonyExpress,

        /// <summary>
        ///Always Express.
        /// AlwaysExpress.
        /// </summary>
        [EnumMember(Value = "ALWAYS_EXPRESS")]
        AlwaysExpress,

        /// <summary>
        ///GBS-Broker.
        /// GbsBroker.
        /// </summary>
        [EnumMember(Value = "GBS_BROKER")]
        GbsBroker,

        /// <summary>
        ///City-Link Express.
        /// CitylinkMy.
        /// </summary>
        [EnumMember(Value = "CITYLINK_MY")]
        CitylinkMy,

        /// <summary>
        ///ALLJOY SUPPLY CHAIN.
        /// Alljoy.
        /// </summary>
        [EnumMember(Value = "ALLJOY")]
        Alljoy,

        /// <summary>
        ///yodel.
        /// Yodel.
        /// </summary>
        [EnumMember(Value = "YODEL")]
        Yodel,

        /// <summary>
        ///Yodel Direct.
        /// YodelDir.
        /// </summary>
        [EnumMember(Value = "YODEL_DIR")]
        YodelDir,

        /// <summary>
        ///STONE3PL.
        /// Stone3Pl.
        /// </summary>
        [EnumMember(Value = "STONE3PL")]
        Stone3Pl,

        /// <summary>
        ///ParcelPal.
        /// ParcelpalWebhook.
        /// </summary>
        [EnumMember(Value = "PARCELPAL_WEBHOOK")]
        ParcelpalWebhook,

        /// <summary>
        ///DHL eCommerce Asia (API).
        /// DhlEcomerceAsa.
        /// </summary>
        [EnumMember(Value = "DHL_ECOMERCE_ASA")]
        DhlEcomerceAsa,

        /// <summary>
        ///J&T Express Singapore.
        /// Simplypost.
        /// </summary>
        [EnumMember(Value = "SIMPLYPOST")]
        Simplypost,

        /// <summary>
        ///Kua Yue Express.
        /// KyExpress.
        /// </summary>
        [EnumMember(Value = "KY_EXPRESS")]
        KyExpress,

        /// <summary>
        ///shenzhen 1st International Logistics(Group)Co.
        /// Shenzhen.
        /// </summary>
        [EnumMember(Value = "SHENZHEN")]
        Shenzhen,

        /// <summary>
        ///LaserShip.
        /// UsLasership.
        /// </summary>
        [EnumMember(Value = "US_LASERSHIP")]
        UsLasership,

        /// <summary>
        ///ucexpress.
        /// UcExpre.
        /// </summary>
        [EnumMember(Value = "UC_EXPRE")]
        UcExpre,

        /// <summary>
        ///DIDADI Logistics tech.
        /// Didadi.
        /// </summary>
        [EnumMember(Value = "DIDADI")]
        Didadi,

        /// <summary>
        ///CJ Korea Express.
        /// CjKr.
        /// </summary>
        [EnumMember(Value = "CJ_KR")]
        CjKr,

        /// <summary>
        ///DB Schenker B2B.
        /// DbschenkerB2B.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_B2B")]
        DbschenkerB2B,

        /// <summary>
        ///MXE Express.
        /// Mxe.
        /// </summary>
        [EnumMember(Value = "MXE")]
        Mxe,

        /// <summary>
        ///CAE Delivers.
        /// CaeDelivers.
        /// </summary>
        [EnumMember(Value = "CAE_DELIVERS")]
        CaeDelivers,

        /// <summary>
        ///PFC Express.
        /// Pfcexpress.
        /// </summary>
        [EnumMember(Value = "PFCEXPRESS")]
        Pfcexpress,

        /// <summary>
        ///Whistl.
        /// Whistl.
        /// </summary>
        [EnumMember(Value = "WHISTL")]
        Whistl,

        /// <summary>
        ///WePost Sdn Bhd.
        /// Wepost.
        /// </summary>
        [EnumMember(Value = "WEPOST")]
        Wepost,

        /// <summary>
        ///DHL parcel Spain(www.dhl.com).
        /// DhlParcelEs.
        /// </summary>
        [EnumMember(Value = "DHL_PARCEL_ES")]
        DhlParcelEs,

        /// <summary>
        ///DD Express Courier.
        /// Ddexpress.
        /// </summary>
        [EnumMember(Value = "DDEXPRESS")]
        Ddexpress,

        /// <summary>
        ///Aramex Australia (formerly Fastway AU).
        /// AramexAu.
        /// </summary>
        [EnumMember(Value = "ARAMEX_AU")]
        AramexAu,

        /// <summary>
        ///Bneed courier.
        /// Bneed.
        /// </summary>
        [EnumMember(Value = "BNEED")]
        Bneed,

        /// <summary>
        ///Kerry Express Hong Kong.
        /// HkTgx.
        /// </summary>
        [EnumMember(Value = "HK_TGX")]
        HkTgx,

        /// <summary>
        ///Latvijas Pasts.
        /// LatvijasPasts.
        /// </summary>
        [EnumMember(Value = "LATVIJAS_PASTS")]
        LatvijasPasts,

        /// <summary>
        ///ViaEurope.
        /// Viaeurope.
        /// </summary>
        [EnumMember(Value = "VIAEUROPE")]
        Viaeurope,

        /// <summary>
        ///Correo Uruguayo.
        /// CorreoUy.
        /// </summary>
        [EnumMember(Value = "CORREO_UY")]
        CorreoUy,

        /// <summary>
        ///Chronopost france (www.chronopost.fr).
        /// ChronopostFr.
        /// </summary>
        [EnumMember(Value = "CHRONOPOST_FR")]
        ChronopostFr,

        /// <summary>
        ///J-Net.
        /// JNet.
        /// </summary>
        [EnumMember(Value = "J_NET")]
        JNet,

        /// <summary>
        ///6ls.com.
        /// _6Ls.
        /// </summary>
        [EnumMember(Value = "_6LS")]
        _6Ls,

        /// <summary>
        ///Belpost.
        /// BlrBelpost.
        /// </summary>
        [EnumMember(Value = "BLR_BELPOST")]
        BlrBelpost,

        /// <summary>
        ///BirdSystem.
        /// Birdsystem.
        /// </summary>
        [EnumMember(Value = "BIRDSYSTEM")]
        Birdsystem,

        /// <summary>
        ///DobroPost.
        /// Dobropost.
        /// </summary>
        [EnumMember(Value = "DOBROPOST")]
        Dobropost,

        /// <summary>
        ///Wahana express (www.wahana.com).
        /// WahanaId.
        /// </summary>
        [EnumMember(Value = "WAHANA_ID")]
        WahanaId,

        /// <summary>
        ///Weaship.
        /// Weaship.
        /// </summary>
        [EnumMember(Value = "WEASHIP")]
        Weaship,

        /// <summary>
        ///Sonic Transportation & Logistics.
        /// Sonictl.
        /// </summary>
        [EnumMember(Value = "SONICTL")]
        Sonictl,

        /// <summary>
        ///Shenzhen Jinghuada Logistics Co..
        /// Kwt.
        /// </summary>
        [EnumMember(Value = "KWT")]
        Kwt,

        /// <summary>
        ///AFL LOGISTICS.
        /// AfllogFtp.
        /// </summary>
        [EnumMember(Value = "AFLLOG_FTP")]
        AfllogFtp,

        /// <summary>
        ///SkyNet Worldwide Express.
        /// SkynetWorldwide.
        /// </summary>
        [EnumMember(Value = "SKYNET_WORLDWIDE")]
        SkynetWorldwide,

        /// <summary>
        ///Nova Poshta (novaposhta.ua).
        /// NovaPoshta.
        /// </summary>
        [EnumMember(Value = "NOVA_POSHTA")]
        NovaPoshta,

        /// <summary>
        ///Seino.
        /// Seino.
        /// </summary>
        [EnumMember(Value = "SEINO")]
        Seino,

        /// <summary>
        ///SZENDEX.
        /// Szendex.
        /// </summary>
        [EnumMember(Value = "SZENDEX")]
        Szendex,

        /// <summary>
        ///Bpost international.
        /// BpostInt.
        /// </summary>
        [EnumMember(Value = "BPOST_INT")]
        BpostInt,

        /// <summary>
        ///DB Schenker Sweden.
        /// DbschenkerSv.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_SV")]
        DbschenkerSv,

        /// <summary>
        ///AO Deutschland.
        /// AoDeutschland.
        /// </summary>
        [EnumMember(Value = "AO_DEUTSCHLAND")]
        AoDeutschland,

        /// <summary>
        ///EU Fleet Solutions.
        /// EuFleetSolutions.
        /// </summary>
        [EnumMember(Value = "EU_FLEET_SOLUTIONS")]
        EuFleetSolutions,

        /// <summary>
        ///PCF Final Mile.
        /// Pcfcorp.
        /// </summary>
        [EnumMember(Value = "PCFCORP")]
        Pcfcorp,

        /// <summary>
        ///Link Bridge(BeiJing)international logistics co..
        /// Linkbridge.
        /// </summary>
        [EnumMember(Value = "LINKBRIDGE")]
        Linkbridge,

        /// <summary>
        ///PT Prima Multi Cipta.
        /// Primamulticipta.
        /// </summary>
        [EnumMember(Value = "PRIMAMULTICIPTA")]
        Primamulticipta,

        /// <summary>
        ///Urbanfox.
        /// Courex.
        /// </summary>
        [EnumMember(Value = "COUREX")]
        Courex,

        /// <summary>
        ///Zajil Express Company.
        /// ZajilExpress.
        /// </summary>
        [EnumMember(Value = "ZAJIL_EXPRESS")]
        ZajilExpress,

        /// <summary>
        ///CollectCo.
        /// Collectco.
        /// </summary>
        [EnumMember(Value = "COLLECTCO")]
        Collectco,

        /// <summary>
        ///J&T EXPRESS MALAYSIA.
        /// Jtexpress.
        /// </summary>
        [EnumMember(Value = "JTEXPRESS")]
        Jtexpress,

        /// <summary>
        ///FedEx® UK.
        /// FedexUk.
        /// </summary>
        [EnumMember(Value = "FEDEX_UK")]
        FedexUk,

        /// <summary>
        ///uShip courier.
        /// Uship.
        /// </summary>
        [EnumMember(Value = "USHIP")]
        Uship,

        /// <summary>
        ///PIXSELL LOGISTICS.
        /// Pixsell.
        /// </summary>
        [EnumMember(Value = "PIXSELL")]
        Pixsell,

        /// <summary>
        ///Shiptor.
        /// Shiptor.
        /// </summary>
        [EnumMember(Value = "SHIPTOR")]
        Shiptor,

        /// <summary>
        ///CDEK courier.
        /// Cdek.
        /// </summary>
        [EnumMember(Value = "CDEK")]
        Cdek,

        /// <summary>
        ///ViettelPost.
        /// VnmViettelpost.
        /// </summary>
        [EnumMember(Value = "VNM_VIETTELPOST")]
        VnmViettelpost,

        /// <summary>
        ///CJ Century.
        /// CjCentury.
        /// </summary>
        [EnumMember(Value = "CJ_CENTURY")]
        CjCentury,

        /// <summary>
        ///GSO(GLS-USA).
        /// Gso.
        /// </summary>
        [EnumMember(Value = "GSO")]
        Gso,

        /// <summary>
        ///VIWO IoT.
        /// Viwo.
        /// </summary>
        [EnumMember(Value = "VIWO")]
        Viwo,

        /// <summary>
        ///SKYBOX.
        /// Skybox.
        /// </summary>
        [EnumMember(Value = "SKYBOX")]
        Skybox,

        /// <summary>
        ///Kerry TJ Logistics.
        /// Kerrytj.
        /// </summary>
        [EnumMember(Value = "KERRYTJ")]
        Kerrytj,

        /// <summary>
        ///Nhat Tin Logistics.
        /// NtlogisticsVn.
        /// </summary>
        [EnumMember(Value = "NTLOGISTICS_VN")]
        NtlogisticsVn,

        /// <summary>
        ///lightning monkey.
        /// SdhScm.
        /// </summary>
        [EnumMember(Value = "SDH_SCM")]
        SdhScm,

        /// <summary>
        ///Zinc courier.
        /// Zinc.
        /// </summary>
        [EnumMember(Value = "ZINC")]
        Zinc,

        /// <summary>
        ///DPE South Africa.
        /// DpeSouthAfrc.
        /// </summary>
        [EnumMember(Value = "DPE_SOUTH_AFRC")]
        DpeSouthAfrc,

        /// <summary>
        ///Czech Post.
        /// CeskaCz.
        /// </summary>
        [EnumMember(Value = "CESKA_CZ")]
        CeskaCz,

        /// <summary>
        ///ACS Courier.
        /// AcsGr.
        /// </summary>
        [EnumMember(Value = "ACS_GR")]
        AcsGr,

        /// <summary>
        ///DealerSend.
        /// Dealersend.
        /// </summary>
        [EnumMember(Value = "DEALERSEND")]
        Dealersend,

        /// <summary>
        ///Jocom.
        /// Jocom.
        /// </summary>
        [EnumMember(Value = "JOCOM")]
        Jocom,

        /// <summary>
        ///CSE courier.
        /// Cse.
        /// </summary>
        [EnumMember(Value = "CSE")]
        Cse,

        /// <summary>
        ///TForce Final Mile.
        /// TforceFinalmile.
        /// </summary>
        [EnumMember(Value = "TFORCE_FINALMILE")]
        TforceFinalmile,

        /// <summary>
        ///ShipGate.
        /// ShipGate.
        /// </summary>
        [EnumMember(Value = "SHIP_GATE")]
        ShipGate,

        /// <summary>
        ///SHIPTER.
        /// Shipter.
        /// </summary>
        [EnumMember(Value = "SHIPTER")]
        Shipter,

        /// <summary>
        ///National Sameday.
        /// NationalSameday.
        /// </summary>
        [EnumMember(Value = "NATIONAL_SAMEDAY")]
        NationalSameday,

        /// <summary>
        ///YunExpress.
        /// Yunexpress.
        /// </summary>
        [EnumMember(Value = "YUNEXPRESS")]
        Yunexpress,

        /// <summary>
        ///AliExpress Standard Shipping.
        /// Cainiao.
        /// </summary>
        [EnumMember(Value = "CAINIAO")]
        Cainiao,

        /// <summary>
        ///DMSMatrix.
        /// DmsMatrix.
        /// </summary>
        [EnumMember(Value = "DMS_MATRIX")]
        DmsMatrix,

        /// <summary>
        ///Directlog (www.directlog.com.br).
        /// Directlog.
        /// </summary>
        [EnumMember(Value = "DIRECTLOG")]
        Directlog,

        /// <summary>
        ///Asendia USA.
        /// AsendiaUs.
        /// </summary>
        [EnumMember(Value = "ASENDIA_US")]
        AsendiaUs,

        /// <summary>
        ///3JMS Logistics.
        /// _3Jmslogistics.
        /// </summary>
        [EnumMember(Value = "_3JMSLOGISTICS")]
        _3Jmslogistics,

        /// <summary>
        ///LICCARDI EXPRESS COURIER.
        /// LiccardiExpress.
        /// </summary>
        [EnumMember(Value = "LICCARDI_EXPRESS")]
        LiccardiExpress,

        /// <summary>
        ///SkyPostal.
        /// SkyPostal.
        /// </summary>
        [EnumMember(Value = "SKY_POSTAL")]
        SkyPostal,

        /// <summary>
        ///cnwangtong.
        /// Cnwangtong.
        /// </summary>
        [EnumMember(Value = "CNWANGTONG")]
        Cnwangtong,

        /// <summary>
        ///ostnord denmark.
        /// PostnordLogisticsDk.
        /// </summary>
        [EnumMember(Value = "POSTNORD_LOGISTICS_DK")]
        PostnordLogisticsDk,

        /// <summary>
        ///Logistika.
        /// Logistika.
        /// </summary>
        [EnumMember(Value = "LOGISTIKA")]
        Logistika,

        /// <summary>
        ///Celeritas Transporte.
        /// Celeritas.
        /// </summary>
        [EnumMember(Value = "CELERITAS")]
        Celeritas,

        /// <summary>
        ///Pressio.
        /// Pressiode.
        /// </summary>
        [EnumMember(Value = "PRESSIODE")]
        Pressiode,

        /// <summary>
        ///Shree Maruti Courier Services Pvt Ltd.
        /// ShreeMaruti.
        /// </summary>
        [EnumMember(Value = "SHREE_MARUTI")]
        ShreeMaruti,

        /// <summary>
        ///Logistic Worldwide Express (LWE Honkong).
        /// LogisticsworldwideHk.
        /// </summary>
        [EnumMember(Value = "LOGISTICSWORLDWIDE_HK")]
        LogisticsworldwideHk,

        /// <summary>
        ///eFEx (E-Commerce Fulfillment & Express).
        /// Efex.
        /// </summary>
        [EnumMember(Value = "EFEX")]
        Efex,

        /// <summary>
        ///Lotte Global Logistics.
        /// Lotte.
        /// </summary>
        [EnumMember(Value = "LOTTE")]
        Lotte,

        /// <summary>
        ///Lone Star Overnight.
        /// Lonestar.
        /// </summary>
        [EnumMember(Value = "LONESTAR")]
        Lonestar,

        /// <summary>
        ///Aprisa Express.
        /// Aprisaexpress.
        /// </summary>
        [EnumMember(Value = "APRISAEXPRESS")]
        Aprisaexpress,

        /// <summary>
        ///BEL North Russia.
        /// BelRs.
        /// </summary>
        [EnumMember(Value = "BEL_RS")]
        BelRs,

        /// <summary>
        ///OSM Worldwide.
        /// OsmWorldwide.
        /// </summary>
        [EnumMember(Value = "OSM_WORLDWIDE")]
        OsmWorldwide,

        /// <summary>
        ///Westgate Global.
        /// WestgateGl.
        /// </summary>
        [EnumMember(Value = "WESTGATE_GL")]
        WestgateGl,

        /// <summary>
        ///Fasttrack.
        /// Fastrack.
        /// </summary>
        [EnumMember(Value = "FASTRACK")]
        Fastrack,

        /// <summary>
        ///DTD Express.
        /// DtdExpr.
        /// </summary>
        [EnumMember(Value = "DTD_EXPR")]
        DtdExpr,

        /// <summary>
        ///AlfaTrex.
        /// Alfatrex.
        /// </summary>
        [EnumMember(Value = "ALFATREX")]
        Alfatrex,

        /// <summary>
        ///ProMed Delivery.
        /// Promeddelivery.
        /// </summary>
        [EnumMember(Value = "PROMEDDELIVERY")]
        Promeddelivery,

        /// <summary>
        ///Thabit Logistics.
        /// ThabitLogistics.
        /// </summary>
        [EnumMember(Value = "THABIT_LOGISTICS")]
        ThabitLogistics,

        /// <summary>
        ///HCT LOGISTICS CO.LTD..
        /// HctLogistics.
        /// </summary>
        [EnumMember(Value = "HCT_LOGISTICS")]
        HctLogistics,

        /// <summary>
        ///Carry-Flap Co..
        /// CarryFlap.
        /// </summary>
        [EnumMember(Value = "CARRY_FLAP")]
        CarryFlap,

        /// <summary>
        ///Old Dominion Freight Line.
        /// UsOldDominion.
        /// </summary>
        [EnumMember(Value = "US_OLD_DOMINION")]
        UsOldDominion,

        /// <summary>
        ///ANICAM BOX EXPRESS.
        /// AnicamBox.
        /// </summary>
        [EnumMember(Value = "ANICAM_BOX")]
        AnicamBox,

        /// <summary>
        ///WanbExpress.
        /// Wanbexpress.
        /// </summary>
        [EnumMember(Value = "WANBEXPRESS")]
        Wanbexpress,

        /// <summary>
        ///An Post.
        /// AnPost.
        /// </summary>
        [EnumMember(Value = "AN_POST")]
        AnPost,

        /// <summary>
        ///DPD Local.
        /// DpdLocal.
        /// </summary>
        [EnumMember(Value = "DPD_LOCAL")]
        DpdLocal,

        /// <summary>
        ///Stallion Express.
        /// Stallionexpress.
        /// </summary>
        [EnumMember(Value = "STALLIONEXPRESS")]
        Stallionexpress,

        /// <summary>
        ///RaidereX.
        /// Raiderex.
        /// </summary>
        [EnumMember(Value = "RAIDEREX")]
        Raiderex,

        /// <summary>
        ///ShopfansRU LLC.
        /// Shopfans.
        /// </summary>
        [EnumMember(Value = "SHOPFANS")]
        Shopfans,

        /// <summary>
        ///Kyungdong Parcel.
        /// KyungdongParcel.
        /// </summary>
        [EnumMember(Value = "KYUNGDONG_PARCEL")]
        KyungdongParcel,

        /// <summary>
        ///Champion Logistics.
        /// ChampionLogistics.
        /// </summary>
        [EnumMember(Value = "CHAMPION_LOGISTICS")]
        ChampionLogistics,

        /// <summary>
        ///PICK UPP (Singapore).
        /// PickuppSgp.
        /// </summary>
        [EnumMember(Value = "PICKUPP_SGP")]
        PickuppSgp,

        /// <summary>
        ///Morning Express.
        /// MorningExpress.
        /// </summary>
        [EnumMember(Value = "MORNING_EXPRESS")]
        MorningExpress,

        /// <summary>
        ///NACEX.
        /// Nacex.
        /// </summary>
        [EnumMember(Value = "NACEX")]
        Nacex,

        /// <summary>
        ///SortHub courier.
        /// ThenileWebhook.
        /// </summary>
        [EnumMember(Value = "THENILE_WEBHOOK")]
        ThenileWebhook,

        /// <summary>
        ///Holisol.
        /// Holisol.
        /// </summary>
        [EnumMember(Value = "HOLISOL")]
        Holisol,

        /// <summary>
        ///LBC EXPRESS INC..
        /// LbcexpressFtp.
        /// </summary>
        [EnumMember(Value = "LBCEXPRESS_FTP")]
        LbcexpressFtp,

        /// <summary>
        ///KURASI.
        /// Kurasi.
        /// </summary>
        [EnumMember(Value = "KURASI")]
        Kurasi,

        /// <summary>
        ///USF Reddaway.
        /// UsfReddaway.
        /// </summary>
        [EnumMember(Value = "USF_REDDAWAY")]
        UsfReddaway,

        /// <summary>
        ///APG eCommerce Solutions.
        /// Apg.
        /// </summary>
        [EnumMember(Value = "APG")]
        Apg,

        /// <summary>
        ///BoxC courier.
        /// CnBoxc.
        /// </summary>
        [EnumMember(Value = "CN_BOXC")]
        CnBoxc,

        /// <summary>
        ///ECOSCOOTING.
        /// Ecoscooting.
        /// </summary>
        [EnumMember(Value = "ECOSCOOTING")]
        Ecoscooting,

        /// <summary>
        ///Mainway.
        /// Mainway.
        /// </summary>
        [EnumMember(Value = "MAINWAY")]
        Mainway,

        /// <summary>
        ///Paperfly Private Limited.
        /// Paperfly.
        /// </summary>
        [EnumMember(Value = "PAPERFLY")]
        Paperfly,

        /// <summary>
        ///Hound Express.
        /// Houndexpress.
        /// </summary>
        [EnumMember(Value = "HOUNDEXPRESS")]
        Houndexpress,

        /// <summary>
        ///Boxberry courier.
        /// BoxBerry.
        /// </summary>
        [EnumMember(Value = "BOX_BERRY")]
        BoxBerry,

        /// <summary>
        ///EP-Box courier.
        /// EpBox.
        /// </summary>
        [EnumMember(Value = "EP_BOX")]
        EpBox,

        /// <summary>
        ///Plus UK Logistics.
        /// PlusLogUk.
        /// </summary>
        [EnumMember(Value = "PLUS_LOG_UK")]
        PlusLogUk,

        /// <summary>
        ///Fulfilla.
        /// Fulfilla.
        /// </summary>
        [EnumMember(Value = "FULFILLA")]
        Fulfilla,

        /// <summary>
        ///ASE KARGO.
        /// Ase.
        /// </summary>
        [EnumMember(Value = "ASE")]
        Ase,

        /// <summary>
        ///MailPlus.
        /// MailPlus.
        /// </summary>
        [EnumMember(Value = "MAIL_PLUS")]
        MailPlus,

        /// <summary>
        ///XPO logistics.
        /// XpoLogistics.
        /// </summary>
        [EnumMember(Value = "XPO_LOGISTICS")]
        XpoLogistics,

        /// <summary>
        ///wnDirect.
        /// Wndirect.
        /// </summary>
        [EnumMember(Value = "WNDIRECT")]
        Wndirect,

        /// <summary>
        ///Cloudwish Asia.
        /// CloudwishAsia.
        /// </summary>
        [EnumMember(Value = "CLOUDWISH_ASIA")]
        CloudwishAsia,

        /// <summary>
        ///Zeleris.
        /// Zeleris.
        /// </summary>
        [EnumMember(Value = "ZELERIS")]
        Zeleris,

        /// <summary>
        ///Gio Express.
        /// GioExpress.
        /// </summary>
        [EnumMember(Value = "GIO_EXPRESS")]
        GioExpress,

        /// <summary>
        ///OCS WORLDWIDE.
        /// OcsWorldwide.
        /// </summary>
        [EnumMember(Value = "OCS_WORLDWIDE")]
        OcsWorldwide,

        /// <summary>
        ///ARK Logistics.
        /// ArkLogistics.
        /// </summary>
        [EnumMember(Value = "ARK_LOGISTICS")]
        ArkLogistics,

        /// <summary>
        ///Aquiline.
        /// Aquiline.
        /// </summary>
        [EnumMember(Value = "AQUILINE")]
        Aquiline,

        /// <summary>
        ///Pilot Freight Services.
        /// PilotFreight.
        /// </summary>
        [EnumMember(Value = "PILOT_FREIGHT")]
        PilotFreight,

        /// <summary>
        ///Qwintry Logistics.
        /// Qwintry.
        /// </summary>
        [EnumMember(Value = "QWINTRY")]
        Qwintry,

        /// <summary>
        ///Danske Fragtaend.
        /// DanskeFragt.
        /// </summary>
        [EnumMember(Value = "DANSKE_FRAGT")]
        DanskeFragt,

        /// <summary>
        ///Carriers courier.
        /// Carriers.
        /// </summary>
        [EnumMember(Value = "CARRIERS")]
        Carriers,

        /// <summary>
        ///Rivo (Air canada).
        /// AirCanadaGlobal.
        /// </summary>
        [EnumMember(Value = "AIR_CANADA_GLOBAL")]
        AirCanadaGlobal,

        /// <summary>
        ///PRESIDENT TRANSNET CORP.
        /// PresidentTrans.
        /// </summary>
        [EnumMember(Value = "PRESIDENT_TRANS")]
        PresidentTrans,

        /// <summary>
        ///STEP FORWARD FREIGHT SERVICE CO LTD.
        /// Stepforwardfs.
        /// </summary>
        [EnumMember(Value = "STEPFORWARDFS")]
        Stepforwardfs,

        /// <summary>
        ///Skynet UK.
        /// SkynetUk.
        /// </summary>
        [EnumMember(Value = "SKYNET_UK")]
        SkynetUk,

        /// <summary>
        ///PITT OHIO.
        /// Pittohio.
        /// </summary>
        [EnumMember(Value = "PITTOHIO")]
        Pittohio,

        /// <summary>
        ///Correos Express.
        /// CorreosExpress.
        /// </summary>
        [EnumMember(Value = "CORREOS_EXPRESS")]
        CorreosExpress,

        /// <summary>
        ///RL Carriers.
        /// RlUs.
        /// </summary>
        [EnumMember(Value = "RL_US")]
        RlUs,

        /// <summary>
        ///Destiny Transportation.
        /// Destiny.
        /// </summary>
        [EnumMember(Value = "DESTINY")]
        Destiny,

        /// <summary>
        ///Yodel (www.yodel.co.uk).
        /// UkYodel.
        /// </summary>
        [EnumMember(Value = "UK_YODEL")]
        UkYodel,

        /// <summary>
        ///CometTech.
        /// CometTech.
        /// </summary>
        [EnumMember(Value = "COMET_TECH")]
        CometTech,

        /// <summary>
        ///DHL Parcel Russia.
        /// DhlParcelRu.
        /// </summary>
        [EnumMember(Value = "DHL_PARCEL_RU")]
        DhlParcelRu,

        /// <summary>
        ///TNT Reference.
        /// TntRefr.
        /// </summary>
        [EnumMember(Value = "TNT_REFR")]
        TntRefr,

        /// <summary>
        ///Shree Anjani Courier.
        /// ShreeAnjaniCourier.
        /// </summary>
        [EnumMember(Value = "SHREE_ANJANI_COURIER")]
        ShreeAnjaniCourier,

        /// <summary>
        ///Mikropakket Belgium.
        /// MikropakketBe.
        /// </summary>
        [EnumMember(Value = "MIKROPAKKET_BE")]
        MikropakketBe,

        /// <summary>
        ///RETS express.
        /// EtsExpress.
        /// </summary>
        [EnumMember(Value = "ETS_EXPRESS")]
        EtsExpress,

        /// <summary>
        ///Colis Privé.
        /// ColisPrive.
        /// </summary>
        [EnumMember(Value = "COLIS_PRIVE")]
        ColisPrive,

        /// <summary>
        ///Yunda Express.
        /// CnYunda.
        /// </summary>
        [EnumMember(Value = "CN_YUNDA")]
        CnYunda,

        /// <summary>
        ///AAA Cooper.
        /// AaaCooper.
        /// </summary>
        [EnumMember(Value = "AAA_COOPER")]
        AaaCooper,

        /// <summary>
        ///Rocket Parcel International.
        /// RocketParcel.
        /// </summary>
        [EnumMember(Value = "ROCKET_PARCEL")]
        RocketParcel,

        /// <summary>
        ///360 Lion Express.
        /// _360Lion.
        /// </summary>
        [EnumMember(Value = "_360LION")]
        _360Lion,

        /// <summary>
        ///PANDU.
        /// Pandu.
        /// </summary>
        [EnumMember(Value = "PANDU")]
        Pandu,

        /// <summary>
        ///PROFESSIONAL COURIERS.
        /// ProfessionalCouriers.
        /// </summary>
        [EnumMember(Value = "PROFESSIONAL_COURIERS")]
        ProfessionalCouriers,

        /// <summary>
        ///FLYTEXPRESS.
        /// Flytexpress.
        /// </summary>
        [EnumMember(Value = "FLYTEXPRESS")]
        Flytexpress,

        /// <summary>
        ///LOGISTICSWORLDWIDE MY.
        /// LogisticsworldwideMy.
        /// </summary>
        [EnumMember(Value = "LOGISTICSWORLDWIDE_MY")]
        LogisticsworldwideMy,

        /// <summary>
        ///CORREOS DE ESPANA.
        /// CorreosDeEspana.
        /// </summary>
        [EnumMember(Value = "CORREOS_DE_ESPANA")]
        CorreosDeEspana,

        /// <summary>
        ///IMX.
        /// Imx.
        /// </summary>
        [EnumMember(Value = "IMX")]
        Imx,

        /// <summary>
        ///FOUR PX EXPRESS.
        /// FourPxExpress.
        /// </summary>
        [EnumMember(Value = "FOUR_PX_EXPRESS")]
        FourPxExpress,

        /// <summary>
        ///XPRESSBEES.
        /// Xpressbees.
        /// </summary>
        [EnumMember(Value = "XPRESSBEES")]
        Xpressbees,

        /// <summary>
        ///pickupp_vnm.
        /// PickuppVnm.
        /// </summary>
        [EnumMember(Value = "PICKUPP_VNM")]
        PickuppVnm,

        /// <summary>
        ///startrack_express.
        /// StartrackExpress1.
        /// </summary>
        [EnumMember(Value = "STARTRACK_EXPRESS")]
        StartrackExpress1,

        /// <summary>
        ///fr_colissimo.
        /// FrColissimo.
        /// </summary>
        [EnumMember(Value = "FR_COLISSIMO")]
        FrColissimo,

        /// <summary>
        ///nacex_spain_reference.
        /// NacexSpainReference.
        /// </summary>
        [EnumMember(Value = "NACEX_SPAIN_REFERENCE")]
        NacexSpainReference,

        /// <summary>
        ///dhl_supply_chain_au.
        /// DhlSupplyChainAu.
        /// </summary>
        [EnumMember(Value = "DHL_SUPPLY_CHAIN_AU")]
        DhlSupplyChainAu,

        /// <summary>
        ///Eshipping.
        /// Eshipping.
        /// </summary>
        [EnumMember(Value = "ESHIPPING")]
        Eshipping,

        /// <summary>
        ///SHREE TIRUPATI COURIER SERVICES PVT. LTD..
        /// Shreetirupati.
        /// </summary>
        [EnumMember(Value = "SHREETIRUPATI")]
        Shreetirupati,

        /// <summary>
        ///HX Express.
        /// HxExpress.
        /// </summary>
        [EnumMember(Value = "HX_EXPRESS")]
        HxExpress,

        /// <summary>
        ///INDOPAKET.
        /// Indopaket.
        /// </summary>
        [EnumMember(Value = "INDOPAKET")]
        Indopaket,

        /// <summary>
        ///17 Post Service.
        /// Cn17Post.
        /// </summary>
        [EnumMember(Value = "CN_17POST")]
        Cn17Post,

        /// <summary>
        ///K1 Express.
        /// K1Express.
        /// </summary>
        [EnumMember(Value = "K1_EXPRESS")]
        K1Express,

        /// <summary>
        ///CJ GLS.
        /// CjGls.
        /// </summary>
        [EnumMember(Value = "CJ_GLS")]
        CjGls,

        /// <summary>
        ///GDEX courier.
        /// MysGdex.
        /// </summary>
        [EnumMember(Value = "MYS_GDEX")]
        MysGdex,

        /// <summary>
        ///Nationex courier.
        /// Nationex.
        /// </summary>
        [EnumMember(Value = "NATIONEX")]
        Nationex,

        /// <summary>
        ///Anjun couriers.
        /// Anjun.
        /// </summary>
        [EnumMember(Value = "ANJUN")]
        Anjun,

        /// <summary>
        ///FarGood.
        /// Fargood.
        /// </summary>
        [EnumMember(Value = "FARGOOD")]
        Fargood,

        /// <summary>
        ///SMG Direct.
        /// SmgExpress.
        /// </summary>
        [EnumMember(Value = "SMG_EXPRESS")]
        SmgExpress,

        /// <summary>
        ///RZY Express.
        /// Rzyexpress.
        /// </summary>
        [EnumMember(Value = "RZYEXPRESS")]
        Rzyexpress,

        /// <summary>
        ///Southeastern Freight Lines.
        /// Sefl.
        /// </summary>
        [EnumMember(Value = "SEFL")]
        Sefl,

        /// <summary>
        ///TNT-Click Italy.
        /// TntClickIt.
        /// </summary>
        [EnumMember(Value = "TNT_CLICK_IT")]
        TntClickIt,

        /// <summary>
        ///Haidaibao.
        /// Hdb.
        /// </summary>
        [EnumMember(Value = "HDB")]
        Hdb,

        /// <summary>
        ///Hipshipper.
        /// Hipshipper.
        /// </summary>
        [EnumMember(Value = "HIPSHIPPER")]
        Hipshipper,

        /// <summary>
        ///RPX Logistics.
        /// Rpxlogistics.
        /// </summary>
        [EnumMember(Value = "RPXLOGISTICS")]
        Rpxlogistics,

        /// <summary>
        ///Kuehne + Nagel.
        /// Kuehne.
        /// </summary>
        [EnumMember(Value = "KUEHNE")]
        Kuehne,

        /// <summary>
        ///Nexive (TNT Post Italy).
        /// ItNexive.
        /// </summary>
        [EnumMember(Value = "IT_NEXIVE")]
        ItNexive,

        /// <summary>
        ///PTS courier.
        /// Pts.
        /// </summary>
        [EnumMember(Value = "PTS")]
        Pts,

        /// <summary>
        ///Swiss Post FTP.
        /// SwissPostFtp.
        /// </summary>
        [EnumMember(Value = "SWISS_POST_FTP")]
        SwissPostFtp,

        /// <summary>
        ///Fastrak Services.
        /// FastrkServ.
        /// </summary>
        [EnumMember(Value = "FASTRK_SERV")]
        FastrkServ,

        /// <summary>
        ///4-72 Entregando.
        /// _472.
        /// </summary>
        [EnumMember(Value = "_4_72")]
        _472,

        /// <summary>
        ///YRC courier.
        /// UsYrc.
        /// </summary>
        [EnumMember(Value = "US_YRC")]
        UsYrc,

        /// <summary>
        ///PostNL International 3S.
        /// PostnlIntl3S.
        /// </summary>
        [EnumMember(Value = "POSTNL_INTL_3S")]
        PostnlIntl3S,

        /// <summary>
        ///Yilian (Elian) Supply Chain.
        /// ElianPost.
        /// </summary>
        [EnumMember(Value = "ELIAN_POST")]
        ElianPost,

        /// <summary>
        ///Cubyn.
        /// Cubyn.
        /// </summary>
        [EnumMember(Value = "CUBYN")]
        Cubyn,

        /// <summary>
        ///Saudi Post.
        /// SauSaudiPost.
        /// </summary>
        [EnumMember(Value = "SAU_SAUDI_POST")]
        SauSaudiPost,

        /// <summary>
        ///ABX Express.
        /// AbxexpressMy.
        /// </summary>
        [EnumMember(Value = "ABXEXPRESS_MY")]
        AbxexpressMy,

        /// <summary>
        ///HUAHANG EXPRESS.
        /// HuahanExpress.
        /// </summary>
        [EnumMember(Value = "HUAHAN_EXPRESS")]
        HuahanExpress,

        /// <summary>
        ///Eshun international Logistic.
        /// ZesExpress.
        /// </summary>
        [EnumMember(Value = "ZES_EXPRESS")]
        ZesExpress,

        /// <summary>
        ///ZeptoExpress.
        /// ZeptoExpress.
        /// </summary>
        [EnumMember(Value = "ZEPTO_EXPRESS")]
        ZeptoExpress,

        /// <summary>
        ///Skynet World Wide Express South Africa.
        /// SkynetZa.
        /// </summary>
        [EnumMember(Value = "SKYNET_ZA")]
        SkynetZa,

        /// <summary>
        ///Zeek2Door.
        /// Zeek2Door.
        /// </summary>
        [EnumMember(Value = "ZEEK_2_DOOR")]
        Zeek2Door,

        /// <summary>
        ///Blink.
        /// Blinklastmile.
        /// </summary>
        [EnumMember(Value = "BLINKLASTMILE")]
        Blinklastmile,

        /// <summary>
        ///UkrPoshta.
        /// PostaUkr.
        /// </summary>
        [EnumMember(Value = "POSTA_UKR")]
        PostaUkr,

        /// <summary>
        ///C.H. Robinson Worldwide.
        /// Chrobinson.
        /// </summary>
        [EnumMember(Value = "CHROBINSON")]
        Chrobinson,

        /// <summary>
        ///Post56.
        /// CnPost56.
        /// </summary>
        [EnumMember(Value = "CN_POST56")]
        CnPost56,

        /// <summary>
        ///Courant Plus.
        /// CourantPlus.
        /// </summary>
        [EnumMember(Value = "COURANT_PLUS")]
        CourantPlus,

        /// <summary>
        ///Scudex Express.
        /// ScudexExpress.
        /// </summary>
        [EnumMember(Value = "SCUDEX_EXPRESS")]
        ScudexExpress,

        /// <summary>
        ///ShipEntegra.
        /// Shipentegra.
        /// </summary>
        [EnumMember(Value = "SHIPENTEGRA")]
        Shipentegra,

        /// <summary>
        ///B2C courier Europe.
        /// BTwoCEurope.
        /// </summary>
        [EnumMember(Value = "B_TWO_C_EUROPE")]
        BTwoCEurope,

        /// <summary>
        ///Cope Sensitive Freight.
        /// Cope.
        /// </summary>
        [EnumMember(Value = "COPE")]
        Cope,

        /// <summary>
        ///Gati-KWE.
        /// IndGati.
        /// </summary>
        [EnumMember(Value = "IND_GATI")]
        IndGati,

        /// <summary>
        ///WishPost.
        /// CnWishpost.
        /// </summary>
        [EnumMember(Value = "CN_WISHPOST")]
        CnWishpost,

        /// <summary>
        ///NACEX Spain.
        /// NacexEs.
        /// </summary>
        [EnumMember(Value = "NACEX_ES")]
        NacexEs,

        /// <summary>
        ///TAQBIN Hong Kong.
        /// TaqbinHk.
        /// </summary>
        [EnumMember(Value = "TAQBIN_HK")]
        TaqbinHk,

        /// <summary>
        ///GlobalTranz.
        /// Globaltranz.
        /// </summary>
        [EnumMember(Value = "GLOBALTRANZ")]
        Globaltranz,

        /// <summary>
        ///Qingdao HKD International Logistics.
        /// Hkd.
        /// </summary>
        [EnumMember(Value = "HKD")]
        Hkd,

        /// <summary>
        ///BJS Distribution courier.
        /// Bjshomedelivery.
        /// </summary>
        [EnumMember(Value = "BJSHOMEDELIVERY")]
        Bjshomedelivery,

        /// <summary>
        ///Omniva.
        /// Omniva.
        /// </summary>
        [EnumMember(Value = "OMNIVA")]
        Omniva,

        /// <summary>
        ///Sutton Transport.
        /// Sutton.
        /// </summary>
        [EnumMember(Value = "SUTTON")]
        Sutton,

        /// <summary>
        ///Panther Reference.
        /// PantherReference.
        /// </summary>
        [EnumMember(Value = "PANTHER_REFERENCE")]
        PantherReference,

        /// <summary>
        ///SFC Service.
        /// Sfcservice.
        /// </summary>
        [EnumMember(Value = "SFCSERVICE")]
        Sfcservice,

        /// <summary>
        ///LTL COURIER.
        /// Ltl.
        /// </summary>
        [EnumMember(Value = "LTL")]
        Ltl,

        /// <summary>
        ///Park N Parcel.
        /// Parknparcel.
        /// </summary>
        [EnumMember(Value = "PARKNPARCEL")]
        Parknparcel,

        /// <summary>
        ///Spring GDS.
        /// SpringGds.
        /// </summary>
        [EnumMember(Value = "SPRING_GDS")]
        SpringGds,

        /// <summary>
        ///ECexpress.
        /// Ecexpress.
        /// </summary>
        [EnumMember(Value = "ECEXPRESS")]
        Ecexpress,

        /// <summary>
        ///Interparcel Australia.
        /// InterparcelAu.
        /// </summary>
        [EnumMember(Value = "INTERPARCEL_AU")]
        InterparcelAu,

        /// <summary>
        ///Agility.
        /// Agility.
        /// </summary>
        [EnumMember(Value = "AGILITY")]
        Agility,

        /// <summary>
        ///XL Express.
        /// XlExpress.
        /// </summary>
        [EnumMember(Value = "XL_EXPRESS")]
        XlExpress,

        /// <summary>
        ///Ader couriers.
        /// Aderonline.
        /// </summary>
        [EnumMember(Value = "ADERONLINE")]
        Aderonline,

        /// <summary>
        ///Direct Couriers.
        /// Directcouriers.
        /// </summary>
        [EnumMember(Value = "DIRECTCOURIERS")]
        Directcouriers,

        /// <summary>
        ///Planzer Group.
        /// Planzer.
        /// </summary>
        [EnumMember(Value = "PLANZER")]
        Planzer,

        /// <summary>
        ///Sending Transporte Urgente y Comunicacion.
        /// Sending.
        /// </summary>
        [EnumMember(Value = "SENDING")]
        Sending,

        /// <summary>
        ///Ninjavan Webhook.
        /// NinjavanWb.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_WB")]
        NinjavanWb,

        /// <summary>
        ///Nationwide Express Courier Services Bhd (www.nationwide.com.my).
        /// NationwideMy.
        /// </summary>
        [EnumMember(Value = "NATIONWIDE_MY")]
        NationwideMy,

        /// <summary>
        ///Sendit.
        /// Sendit.
        /// </summary>
        [EnumMember(Value = "SENDIT")]
        Sendit,

        /// <summary>
        ///Arrow XL.
        /// GbArrow.
        /// </summary>
        [EnumMember(Value = "GB_ARROW")]
        GbArrow,

        /// <summary>
        ///GoJavas.
        /// IndGojavas.
        /// </summary>
        [EnumMember(Value = "IND_GOJAVAS")]
        IndGojavas,

        /// <summary>
        ///Korea Post.
        /// Kpost.
        /// </summary>
        [EnumMember(Value = "KPOST")]
        Kpost,

        /// <summary>
        ///DHL Freight.
        /// DhlFreight.
        /// </summary>
        [EnumMember(Value = "DHL_FREIGHT")]
        DhlFreight,

        /// <summary>
        ///Bluecare Express Ltd.
        /// Bluecare.
        /// </summary>
        [EnumMember(Value = "BLUECARE")]
        Bluecare,

        /// <summary>
        ///jindouyun courier.
        /// Jindouyun.
        /// </summary>
        [EnumMember(Value = "JINDOUYUN")]
        Jindouyun,

        /// <summary>
        ///Trackon Couriers Pvt. Ltd.
        /// Trackon.
        /// </summary>
        [EnumMember(Value = "TRACKON")]
        Trackon,

        /// <summary>
        ///Tuffnells Parcels Express.
        /// GbTuffnells.
        /// </summary>
        [EnumMember(Value = "GB_TUFFNELLS")]
        GbTuffnells,

        /// <summary>
        ///TRUMPCARD LLC.
        /// Trumpcard.
        /// </summary>
        [EnumMember(Value = "TRUMPCARD")]
        Trumpcard,

        /// <summary>
        ///eTotal Solution Limited.
        /// Etotal.
        /// </summary>
        [EnumMember(Value = "ETOTAL")]
        Etotal,

        /// <summary>
        ///Zeek courier.
        /// SfplusWebhook.
        /// </summary>
        [EnumMember(Value = "SFPLUS_WEBHOOK")]
        SfplusWebhook,

        /// <summary>
        ///SEKO Logistics.
        /// Sekologistics.
        /// </summary>
        [EnumMember(Value = "SEKOLOGISTICS")]
        Sekologistics,

        /// <summary>
        ///Hermes Einrichtungs Service GmbH & Co. KG.
        /// Hermes2MannHandling.
        /// </summary>
        [EnumMember(Value = "HERMES_2MANN_HANDLING")]
        Hermes2MannHandling,

        /// <summary>
        ///DPD Local reference.
        /// DpdLocalRef.
        /// </summary>
        [EnumMember(Value = "DPD_LOCAL_REF")]
        DpdLocalRef,

        /// <summary>
        ///United Delivery Service.
        /// Uds.
        /// </summary>
        [EnumMember(Value = "UDS")]
        Uds,

        /// <summary>
        ///Specialised Freight.
        /// ZaSpecialisedFreight.
        /// </summary>
        [EnumMember(Value = "ZA_SPECIALISED_FREIGHT")]
        ZaSpecialisedFreight,

        /// <summary>
        ///Kerry Express Thailand.
        /// ThaKerry.
        /// </summary>
        [EnumMember(Value = "THA_KERRY")]
        ThaKerry,

        /// <summary>
        ///SEUR International.
        /// PrtIntSeur.
        /// </summary>
        [EnumMember(Value = "PRT_INT_SEUR")]
        PrtIntSeur,

        /// <summary>
        ///Correios Brazil.
        /// BraCorreios.
        /// </summary>
        [EnumMember(Value = "BRA_CORREIOS")]
        BraCorreios,

        /// <summary>
        ///New Zealand Post.
        /// NzNzPost.
        /// </summary>
        [EnumMember(Value = "NZ_NZ_POST")]
        NzNzPost,

        /// <summary>
        ///Equick China.
        /// CnEquick.
        /// </summary>
        [EnumMember(Value = "CN_EQUICK")]
        CnEquick,

        /// <summary>
        ///Malaysia Post EMS / Pos Laju.
        /// MysEms.
        /// </summary>
        [EnumMember(Value = "MYS_EMS")]
        MysEms,

        /// <summary>
        ///Norsk Global.
        /// GbNorsk.
        /// </summary>
        [EnumMember(Value = "GB_NORSK")]
        GbNorsk,

        /// <summary>
        ///MRW spain.
        /// EspMrw.
        /// </summary>
        [EnumMember(Value = "ESP_MRW")]
        EspMrw,

        /// <summary>
        ///Packlink.
        /// EspPacklink.
        /// </summary>
        [EnumMember(Value = "ESP_PACKLINK")]
        EspPacklink,

        /// <summary>
        ///Kangaroo Worldwide Express.
        /// KangarooMy.
        /// </summary>
        [EnumMember(Value = "KANGAROO_MY")]
        KangarooMy,

        /// <summary>
        ///RPX Online.
        /// Rpx.
        /// </summary>
        [EnumMember(Value = "RPX")]
        Rpx,

        /// <summary>
        ///XDP Express Reference.
        /// XdpUkReference.
        /// </summary>
        [EnumMember(Value = "XDP_UK_REFERENCE")]
        XdpUkReference,

        /// <summary>
        ///ninja van (www.ninjavan.co).
        /// NinjavanMy.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_MY")]
        NinjavanMy,

        /// <summary>
        ///Adicional Logistics.
        /// Adicional.
        /// </summary>
        [EnumMember(Value = "ADICIONAL")]
        Adicional,

        /// <summary>
        ///Red Carpet Logistics.
        /// Roadbull.
        /// </summary>
        [EnumMember(Value = "ROADBULL")]
        Roadbull,

        /// <summary>
        ///Yakit courier.
        /// Yakit.
        /// </summary>
        [EnumMember(Value = "YAKIT")]
        Yakit,

        /// <summary>
        ///MailAmericas.
        /// Mailamericas.
        /// </summary>
        [EnumMember(Value = "MAILAMERICAS")]
        Mailamericas,

        /// <summary>
        ///Mikropakket.
        /// Mikropakket.
        /// </summary>
        [EnumMember(Value = "MIKROPAKKET")]
        Mikropakket,

        /// <summary>
        ///Dynamic Logistics.
        /// Dynalogic.
        /// </summary>
        [EnumMember(Value = "DYNALOGIC")]
        Dynalogic,

        /// <summary>
        ///DHL Spain(www.dhl.com).
        /// DhlEs.
        /// </summary>
        [EnumMember(Value = "DHL_ES")]
        DhlEs,

        /// <summary>
        ///DHL Parcel NL.
        /// DhlParcelNl.
        /// </summary>
        [EnumMember(Value = "DHL_PARCEL_NL")]
        DhlParcelNl,

        /// <summary>
        ///DHL Global Mail Asia (www.dhl.com).
        /// DhlGlobalMailAsia.
        /// </summary>
        [EnumMember(Value = "DHL_GLOBAL_MAIL_ASIA")]
        DhlGlobalMailAsia,

        /// <summary>
        ///Dawn Wing.
        /// DawnWing.
        /// </summary>
        [EnumMember(Value = "DAWN_WING")]
        DawnWing,

        /// <summary>
        ///Geniki Taxydromiki.
        /// GenikiGr.
        /// </summary>
        [EnumMember(Value = "GENIKI_GR")]
        GenikiGr,

        /// <summary>
        ///hermesworld_uk.
        /// HermesworldUk.
        /// </summary>
        [EnumMember(Value = "HERMESWORLD_UK")]
        HermesworldUk,

        /// <summary>
        ///Alphafast (www.alphafast.com).
        /// Alphafast.
        /// </summary>
        [EnumMember(Value = "ALPHAFAST")]
        Alphafast,

        /// <summary>
        ///buylogic.
        /// Buylogic.
        /// </summary>
        [EnumMember(Value = "BUYLOGIC")]
        Buylogic,

        /// <summary>
        ///Ekart logistics (ekartlogistics.com).
        /// Ekart.
        /// </summary>
        [EnumMember(Value = "EKART")]
        Ekart,

        /// <summary>
        ///mexico senda express.
        /// MexSenda.
        /// </summary>
        [EnumMember(Value = "MEX_SENDA")]
        MexSenda,

        /// <summary>
        ///SFC.
        /// SfcLogistics.
        /// </summary>
        [EnumMember(Value = "SFC_LOGISTICS")]
        SfcLogistics,

        /// <summary>
        ///Posta Serbia.
        /// PostSerbia.
        /// </summary>
        [EnumMember(Value = "POST_SERBIA")]
        PostSerbia,

        /// <summary>
        ///Delhivery India.
        /// IndDelhivery.
        /// </summary>
        [EnumMember(Value = "IND_DELHIVERY")]
        IndDelhivery,

        /// <summary>
        ///DPD Germany.
        /// DeDpdDelistrack.
        /// </summary>
        [EnumMember(Value = "DE_DPD_DELISTRACK")]
        DeDpdDelistrack,

        /// <summary>
        ///RPD2man Deliveries.
        /// Rpd2Man.
        /// </summary>
        [EnumMember(Value = "RPD2MAN")]
        Rpd2Man,

        /// <summary>
        ///SF Express (www.sf-express.com).
        /// CnSfExpress.
        /// </summary>
        [EnumMember(Value = "CN_SF_EXPRESS")]
        CnSfExpress,

        /// <summary>
        ///Yanwen Logistics.
        /// Yanwen.
        /// </summary>
        [EnumMember(Value = "YANWEN")]
        Yanwen,

        /// <summary>
        ///Skynet Malaysia.
        /// MysSkynet.
        /// </summary>
        [EnumMember(Value = "MYS_SKYNET")]
        MysSkynet,

        /// <summary>
        ///correos mexico.
        /// CorreosDeMexico.
        /// </summary>
        [EnumMember(Value = "CORREOS_DE_MEXICO")]
        CorreosDeMexico,

        /// <summary>
        ///CBL Logistica.
        /// CblLogistica.
        /// </summary>
        [EnumMember(Value = "CBL_LOGISTICA")]
        CblLogistica,

        /// <summary>
        ///Estafeta (www.estafeta.com).
        /// MexEstafeta.
        /// </summary>
        [EnumMember(Value = "MEX_ESTAFETA")]
        MexEstafeta,

        /// <summary>
        ///Austrian Post (Registered).
        /// AuAustrianPost.
        /// </summary>
        [EnumMember(Value = "AU_AUSTRIAN_POST")]
        AuAustrianPost,

        /// <summary>
        ///Rincos.
        /// Rincos.
        /// </summary>
        [EnumMember(Value = "RINCOS")]
        Rincos,

        /// <summary>
        ///DHL Netherland.
        /// NldDhl.
        /// </summary>
        [EnumMember(Value = "NLD_DHL")]
        NldDhl,

        /// <summary>
        ///Russian post.
        /// RussianPost.
        /// </summary>
        [EnumMember(Value = "RUSSIAN_POST")]
        RussianPost,

        /// <summary>
        ///CouriersPlease (couriersplease.com.au).
        /// CouriersPlease.
        /// </summary>
        [EnumMember(Value = "COURIERS_PLEASE")]
        CouriersPlease,

        /// <summary>
        ///PostNord Logistics.
        /// PostnordLogistics.
        /// </summary>
        [EnumMember(Value = "POSTNORD_LOGISTICS")]
        PostnordLogistics,

        /// <summary>
        ///Fedex.
        /// Fedex.
        /// </summary>
        [EnumMember(Value = "FEDEX")]
        Fedex,

        /// <summary>
        ///DPE Express.
        /// DpeExpress.
        /// </summary>
        [EnumMember(Value = "DPE_EXPRESS")]
        DpeExpress,

        /// <summary>
        ///DPD.
        /// Dpd.
        /// </summary>
        [EnumMember(Value = "DPD")]
        Dpd,

        /// <summary>
        ///ADSone.
        /// Adsone.
        /// </summary>
        [EnumMember(Value = "ADSONE")]
        Adsone,

        /// <summary>
        ///JNE Express (Jalur Nugraha Ekakurir).
        /// IdnJne.
        /// </summary>
        [EnumMember(Value = "IDN_JNE")]
        IdnJne,

        /// <summary>
        ///The Courier Guy.
        /// Thecourierguy.
        /// </summary>
        [EnumMember(Value = "THECOURIERGUY")]
        Thecourierguy,

        /// <summary>
        ///CNE Express.
        /// Cnexps.
        /// </summary>
        [EnumMember(Value = "CNEXPS")]
        Cnexps,

        /// <summary>
        ///Chronopost Portugal.
        /// PrtChronopost.
        /// </summary>
        [EnumMember(Value = "PRT_CHRONOPOST")]
        PrtChronopost,

        /// <summary>
        ///Landmark Global.
        /// LandmarkGlobal.
        /// </summary>
        [EnumMember(Value = "LANDMARK_GLOBAL")]
        LandmarkGlobal,

        /// <summary>
        ///DHL International.
        /// ItDhlEcommerce.
        /// </summary>
        [EnumMember(Value = "IT_DHL_ECOMMERCE")]
        ItDhlEcommerce,

        /// <summary>
        ///NACEX Spain.
        /// EspNacex.
        /// </summary>
        [EnumMember(Value = "ESP_NACEX")]
        EspNacex,

        /// <summary>
        ///CTT Portugal.
        /// PrtCtt.
        /// </summary>
        [EnumMember(Value = "PRT_CTT")]
        PrtCtt,

        /// <summary>
        ///Kiala.
        /// BeKiala.
        /// </summary>
        [EnumMember(Value = "BE_KIALA")]
        BeKiala,

        /// <summary>
        ///Asendia UK.
        /// AsendiaUk.
        /// </summary>
        [EnumMember(Value = "ASENDIA_UK")]
        AsendiaUk,

        /// <summary>
        ///TNT global.
        /// GlobalTnt.
        /// </summary>
        [EnumMember(Value = "GLOBAL_TNT")]
        GlobalTnt,

        /// <summary>
        ///Iceland Post.
        /// PosturIs.
        /// </summary>
        [EnumMember(Value = "POSTUR_IS")]
        PosturIs,

        /// <summary>
        ///eParcel Korea.
        /// EparcelKr.
        /// </summary>
        [EnumMember(Value = "EPARCEL_KR")]
        EparcelKr,

        /// <summary>
        ///InPost Paczkomaty.
        /// InpostPaczkomaty.
        /// </summary>
        [EnumMember(Value = "INPOST_PACZKOMATY")]
        InpostPaczkomaty,

        /// <summary>
        ///Poste italiane (www.poste.it).
        /// ItPosteItalia.
        /// </summary>
        [EnumMember(Value = "IT_POSTE_ITALIA")]
        ItPosteItalia,

        /// <summary>
        ///Bpost (www.bpost.be).
        /// BeBpost.
        /// </summary>
        [EnumMember(Value = "BE_BPOST")]
        BeBpost,

        /// <summary>
        ///Poczta Polska (www.poczta-polska.pl).
        /// PlPocztaPolska.
        /// </summary>
        [EnumMember(Value = "PL_POCZTA_POLSKA")]
        PlPocztaPolska,

        /// <summary>
        ///Malaysia Post.
        /// MysMysPost.
        /// </summary>
        [EnumMember(Value = "MYS_MYS_POST")]
        MysMysPost,

        /// <summary>
        ///Singapore Post.
        /// SgSgPost.
        /// </summary>
        [EnumMember(Value = "SG_SG_POST")]
        SgSgPost,

        /// <summary>
        ///Thailand Post (www.thailandpost.co.th).
        /// ThaThailandPost.
        /// </summary>
        [EnumMember(Value = "THA_THAILAND_POST")]
        ThaThailandPost,

        /// <summary>
        ///LexShip.
        /// Lexship.
        /// </summary>
        [EnumMember(Value = "LEXSHIP")]
        Lexship,

        /// <summary>
        ///Fastway New Zealand.
        /// FastwayNz.
        /// </summary>
        [EnumMember(Value = "FASTWAY_NZ")]
        FastwayNz,

        /// <summary>
        ///DHL Supply Chain Australia.
        /// DhlAu.
        /// </summary>
        [EnumMember(Value = "DHL_AU")]
        DhlAu,

        /// <summary>
        ///Cosmetics Now.
        /// Costmeticsnow.
        /// </summary>
        [EnumMember(Value = "COSTMETICSNOW")]
        Costmeticsnow,

        /// <summary>
        ///PFL.
        /// Pflogistics.
        /// </summary>
        [EnumMember(Value = "PFLOGISTICS")]
        Pflogistics,

        /// <summary>
        ///Loomis Express.
        /// LoomisExpress.
        /// </summary>
        [EnumMember(Value = "LOOMIS_EXPRESS")]
        LoomisExpress,

        /// <summary>
        ///GLS Italy.
        /// GlsItaly.
        /// </summary>
        [EnumMember(Value = "GLS_ITALY")]
        GlsItaly,

        /// <summary>
        ///Line Clear Express & Logistics Sdn Bhd.
        /// Line.
        /// </summary>
        [EnumMember(Value = "LINE")]
        Line,

        /// <summary>
        ///Gel Express Logistik.
        /// GelExpress.
        /// </summary>
        [EnumMember(Value = "GEL_EXPRESS")]
        GelExpress,

        /// <summary>
        ///Huodull.
        /// Huodull.
        /// </summary>
        [EnumMember(Value = "HUODULL")]
        Huodull,

        /// <summary>
        ///Ninja van Singapore.
        /// NinjavanSg.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_SG")]
        NinjavanSg,

        /// <summary>
        ///Janio Asia.
        /// Janio.
        /// </summary>
        [EnumMember(Value = "JANIO")]
        Janio,

        /// <summary>
        ///AO Logistics.
        /// AoCourier.
        /// </summary>
        [EnumMember(Value = "AO_COURIER")]
        AoCourier,

        /// <summary>
        ///BRT Bartolini(Sender Reference).
        /// BrtItSenderRef.
        /// </summary>
        [EnumMember(Value = "BRT_IT_SENDER_REF")]
        BrtItSenderRef,

        /// <summary>
        ///SAILPOST.
        /// Sailpost.
        /// </summary>
        [EnumMember(Value = "SAILPOST")]
        Sailpost,

        /// <summary>
        ///Lalamove.
        /// Lalamove.
        /// </summary>
        [EnumMember(Value = "LALAMOVE")]
        Lalamove,

        /// <summary>
        ///NEW ZEALAND COURIERS.
        /// NewzealandCouriers.
        /// </summary>
        [EnumMember(Value = "NEWZEALAND_COURIERS")]
        NewzealandCouriers,

        /// <summary>
        ///Etomars.
        /// Etomars.
        /// </summary>
        [EnumMember(Value = "ETOMARS")]
        Etomars,

        /// <summary>
        ///VIR Transport.
        /// Virtransport.
        /// </summary>
        [EnumMember(Value = "VIRTRANSPORT")]
        Virtransport,

        /// <summary>
        ///Wizmo.
        /// Wizmo.
        /// </summary>
        [EnumMember(Value = "WIZMO")]
        Wizmo,

        /// <summary>
        ///Palletways.
        /// Palletways.
        /// </summary>
        [EnumMember(Value = "PALLETWAYS")]
        Palletways,

        /// <summary>
        ///i-dika.
        /// IDika.
        /// </summary>
        [EnumMember(Value = "I_DIKA")]
        IDika,

        /// <summary>
        ///CFL Logistics.
        /// CflLogistics.
        /// </summary>
        [EnumMember(Value = "CFL_LOGISTICS")]
        CflLogistics,

        /// <summary>
        ///GEM Worldwide.
        /// Gemworldwide.
        /// </summary>
        [EnumMember(Value = "GEMWORLDWIDE")]
        Gemworldwide,

        /// <summary>
        ///Tai Wan Global Business.
        /// GlobalExpress.
        /// </summary>
        [EnumMember(Value = "GLOBAL_EXPRESS")]
        GlobalExpress,

        /// <summary>
        ///Transgroup courier.
        /// LogistyxTransgroup.
        /// </summary>
        [EnumMember(Value = "LOGISTYX_TRANSGROUP")]
        LogistyxTransgroup,

        /// <summary>
        ///West Bank Courier.
        /// WestbankCourier.
        /// </summary>
        [EnumMember(Value = "WESTBANK_COURIER")]
        WestbankCourier,

        /// <summary>
        ///Arco Spedizioni SP.
        /// ArcoSpedizioni.
        /// </summary>
        [EnumMember(Value = "ARCO_SPEDIZIONI")]
        ArcoSpedizioni,

        /// <summary>
        ///YDH express.
        /// YdhExpress.
        /// </summary>
        [EnumMember(Value = "YDH_EXPRESS")]
        YdhExpress,

        /// <summary>
        ///Parcelink Logistics.
        /// Parcelinklogistics.
        /// </summary>
        [EnumMember(Value = "PARCELINKLOGISTICS")]
        Parcelinklogistics,

        /// <summary>
        ///CND Express.
        /// Cndexpress.
        /// </summary>
        [EnumMember(Value = "CNDEXPRESS")]
        Cndexpress,

        /// <summary>
        ///NOX NightTimeExpress.
        /// NoxNightTimeExpress.
        /// </summary>
        [EnumMember(Value = "NOX_NIGHT_TIME_EXPRESS")]
        NoxNightTimeExpress,

        /// <summary>
        ///Aeronet couriers.
        /// Aeronet.
        /// </summary>
        [EnumMember(Value = "AERONET")]
        Aeronet,

        /// <summary>
        ///LTIAN EXP.
        /// Ltianexp.
        /// </summary>
        [EnumMember(Value = "LTIANEXP")]
        Ltianexp,

        /// <summary>
        ///Integra2.
        /// Integra2Ftp.
        /// </summary>
        [EnumMember(Value = "INTEGRA2_FTP")]
        Integra2Ftp,

        /// <summary>
        ///PARCEL ONE.
        /// Parcelone.
        /// </summary>
        [EnumMember(Value = "PARCELONE")]
        Parcelone,

        /// <summary>
        ///Innight Express Germany GmbH (nox NachtExpress).
        /// NoxNachtexpress.
        /// </summary>
        [EnumMember(Value = "NOX_NACHTEXPRESS")]
        NoxNachtexpress,

        /// <summary>
        ///China Post.
        /// CnChinaPostEms.
        /// </summary>
        [EnumMember(Value = "CN_CHINA_POST_EMS")]
        CnChinaPostEms,

        /// <summary>
        ///Chukou1.
        /// Chukou1.
        /// </summary>
        [EnumMember(Value = "CHUKOU1")]
        Chukou1,

        /// <summary>
        ///GLS General Logistics Systems Slovakia s.r.o..
        /// GlsSlov.
        /// </summary>
        [EnumMember(Value = "GLS_SLOV")]
        GlsSlov,

        /// <summary>
        ///OrangeDS (Orange Distribution Solutions Inc).
        /// OrangeDs.
        /// </summary>
        [EnumMember(Value = "ORANGE_DS")]
        OrangeDs,

        /// <summary>
        ///Joom Logistics.
        /// JoomLogis.
        /// </summary>
        [EnumMember(Value = "JOOM_LOGIS")]
        JoomLogis,

        /// <summary>
        ///StarTrack (startrack.com.au).
        /// AusStartrack.
        /// </summary>
        [EnumMember(Value = "AUS_STARTRACK")]
        AusStartrack,

        /// <summary>
        ///dhl Global.
        /// Dhl.
        /// </summary>
        [EnumMember(Value = "DHL")]
        Dhl,

        /// <summary>
        ///APC postal logistics germany.
        /// GbApc.
        /// </summary>
        [EnumMember(Value = "GB_APC")]
        GbApc,

        /// <summary>
        ///Bonds Courier Service (bondscouriers.com.au).
        /// Bondscouriers.
        /// </summary>
        [EnumMember(Value = "BONDSCOURIERS")]
        Bondscouriers,

        /// <summary>
        ///Japan Post.
        /// JpnJapanPost.
        /// </summary>
        [EnumMember(Value = "JPN_JAPAN_POST")]
        JpnJapanPost,

        /// <summary>
        ///United States Postal Service.
        /// Usps.
        /// </summary>
        [EnumMember(Value = "USPS")]
        Usps,

        /// <summary>
        ///WinIt.
        /// Winit.
        /// </summary>
        [EnumMember(Value = "WINIT")]
        Winit,

        /// <summary>
        ///OCA Argentina.
        /// ArgOca.
        /// </summary>
        [EnumMember(Value = "ARG_OCA")]
        ArgOca,

        /// <summary>
        ///Taiwan Post.
        /// TwTaiwanPost.
        /// </summary>
        [EnumMember(Value = "TW_TAIWAN_POST")]
        TwTaiwanPost,

        /// <summary>
        ///DMM Network.
        /// DmmNetwork.
        /// </summary>
        [EnumMember(Value = "DMM_NETWORK")]
        DmmNetwork,

        /// <summary>
        ///TNT Express.
        /// Tnt.
        /// </summary>
        [EnumMember(Value = "TNT")]
        Tnt,

        /// <summary>
        ///BH Posta (www.posta.ba).
        /// BhPosta.
        /// </summary>
        [EnumMember(Value = "BH_POSTA")]
        BhPosta,

        /// <summary>
        ///Postnord sweden.
        /// SwePostnord.
        /// </summary>
        [EnumMember(Value = "SWE_POSTNORD")]
        SwePostnord,

        /// <summary>
        ///Canada Post.
        /// CaCanadaPost.
        /// </summary>
        [EnumMember(Value = "CA_CANADA_POST")]
        CaCanadaPost,

        /// <summary>
        ///Wiseloads.
        /// Wiseloads.
        /// </summary>
        [EnumMember(Value = "WISELOADS")]
        Wiseloads,

        /// <summary>
        ///Asendia HonKong.
        /// AsendiaHk.
        /// </summary>
        [EnumMember(Value = "ASENDIA_HK")]
        AsendiaHk,

        /// <summary>
        ///GLS Netherland.
        /// NldGls.
        /// </summary>
        [EnumMember(Value = "NLD_GLS")]
        NldGls,

        /// <summary>
        ///Redpack.
        /// MexRedpack.
        /// </summary>
        [EnumMember(Value = "MEX_REDPACK")]
        MexRedpack,

        /// <summary>
        ///Jet-Ship Worldwide.
        /// JetShip.
        /// </summary>
        [EnumMember(Value = "JET_SHIP")]
        JetShip,

        /// <summary>
        ///DHL Express.
        /// DeDhlExpress.
        /// </summary>
        [EnumMember(Value = "DE_DHL_EXPRESS")]
        DeDhlExpress,

        /// <summary>
        ///Ninja van Thai.
        /// NinjavanThai.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_THAI")]
        NinjavanThai,

        /// <summary>
        ///Raben Group.
        /// RabenGroup.
        /// </summary>
        [EnumMember(Value = "RABEN_GROUP")]
        RabenGroup,

        /// <summary>
        ///ASM(GLS Spain).
        /// EspAsm.
        /// </summary>
        [EnumMember(Value = "ESP_ASM")]
        EspAsm,

        /// <summary>
        ///Hrvatska posta.
        /// HrvHrvatska.
        /// </summary>
        [EnumMember(Value = "HRV_HRVATSKA")]
        HrvHrvatska,

        /// <summary>
        ///Estes Express Lines.
        /// GlobalEstes.
        /// </summary>
        [EnumMember(Value = "GLOBAL_ESTES")]
        GlobalEstes,

        /// <summary>
        ///Lietuvos pastas.
        /// LtuLietuvos.
        /// </summary>
        [EnumMember(Value = "LTU_LIETUVOS")]
        LtuLietuvos,

        /// <summary>
        ///DHL Benelux.
        /// BelDhl.
        /// </summary>
        [EnumMember(Value = "BEL_DHL")]
        BelDhl,

        /// <summary>
        ///Australia Post.
        /// AuAuPost.
        /// </summary>
        [EnumMember(Value = "AU_AU_POST")]
        AuAuPost,

        /// <summary>
        ///SPEEDEX couriers.
        /// Speedexcourier.
        /// </summary>
        [EnumMember(Value = "SPEEDEXCOURIER")]
        Speedexcourier,

        /// <summary>
        ///Colissimo.
        /// FrColis.
        /// </summary>
        [EnumMember(Value = "FR_COLIS")]
        FrColis,

        /// <summary>
        ///Aramex.
        /// Aramex.
        /// </summary>
        [EnumMember(Value = "ARAMEX")]
        Aramex,

        /// <summary>
        ///DPEX (www.dpex.com).
        /// Dpex.
        /// </summary>
        [EnumMember(Value = "DPEX")]
        Dpex,

        /// <summary>
        ///Airpak Express.
        /// MysAirpak.
        /// </summary>
        [EnumMember(Value = "MYS_AIRPAK")]
        MysAirpak,

        /// <summary>
        ///Cuckoo Express.
        /// Cuckooexpress.
        /// </summary>
        [EnumMember(Value = "CUCKOOEXPRESS")]
        Cuckooexpress,

        /// <summary>
        ///DPD Poland.
        /// DpdPoland.
        /// </summary>
        [EnumMember(Value = "DPD_POLAND")]
        DpdPoland,

        /// <summary>
        ///PostNL International.
        /// NldPostnl.
        /// </summary>
        [EnumMember(Value = "NLD_POSTNL")]
        NldPostnl,

        /// <summary>
        ///Nim Express.
        /// NimExpress.
        /// </summary>
        [EnumMember(Value = "NIM_EXPRESS")]
        NimExpress,

        /// <summary>
        ///Quantium.
        /// Quantium.
        /// </summary>
        [EnumMember(Value = "QUANTIUM")]
        Quantium,

        /// <summary>
        ///Sendle.
        /// Sendle.
        /// </summary>
        [EnumMember(Value = "SENDLE")]
        Sendle,

        /// <summary>
        ///Redur Spain.
        /// EspRedur.
        /// </summary>
        [EnumMember(Value = "ESP_REDUR")]
        EspRedur,

        /// <summary>
        ///Matkahuolto.
        /// Matkahuolto.
        /// </summary>
        [EnumMember(Value = "MATKAHUOLTO")]
        Matkahuolto,

        /// <summary>
        ///Cpacket couriers.
        /// Cpacket.
        /// </summary>
        [EnumMember(Value = "CPACKET")]
        Cpacket,

        /// <summary>
        ///Posti courier.
        /// Posti.
        /// </summary>
        [EnumMember(Value = "POSTI")]
        Posti,

        /// <summary>
        ///Hunter Express.
        /// HunterExpress.
        /// </summary>
        [EnumMember(Value = "HUNTER_EXPRESS")]
        HunterExpress,

        /// <summary>
        ///Choir Express Indonesia.
        /// ChoirExp.
        /// </summary>
        [EnumMember(Value = "CHOIR_EXP")]
        ChoirExp,

        /// <summary>
        ///Legion Express.
        /// LegionExpress.
        /// </summary>
        [EnumMember(Value = "LEGION_EXPRESS")]
        LegionExpress,

        /// <summary>
        ///austrian post.
        /// AustrianPostExpress.
        /// </summary>
        [EnumMember(Value = "AUSTRIAN_POST_EXPRESS")]
        AustrianPostExpress,

        /// <summary>
        ///Grupo ampm.
        /// Grupo.
        /// </summary>
        [EnumMember(Value = "GRUPO")]
        Grupo,

        /// <summary>
        ///Post Roman (www.posta-romana.ro).
        /// PostaRo.
        /// </summary>
        [EnumMember(Value = "POSTA_RO")]
        PostaRo,

        /// <summary>
        ///Interparcel UK.
        /// InterparcelUk.
        /// </summary>
        [EnumMember(Value = "INTERPARCEL_UK")]
        InterparcelUk,

        /// <summary>
        ///ABF Freight.
        /// GlobalAbf.
        /// </summary>
        [EnumMember(Value = "GLOBAL_ABF")]
        GlobalAbf,

        /// <summary>
        ///Posten Norge (www.posten.no).
        /// PostenNorge.
        /// </summary>
        [EnumMember(Value = "POSTEN_NORGE")]
        PostenNorge,

        /// <summary>
        ///Xpert Delivery.
        /// XpertDelivery.
        /// </summary>
        [EnumMember(Value = "XPERT_DELIVERY")]
        XpertDelivery,

        /// <summary>
        ///DHl (Reference number).
        /// DhlRefr.
        /// </summary>
        [EnumMember(Value = "DHL_REFR")]
        DhlRefr,

        /// <summary>
        ///DHL HonKong.
        /// DhlHk.
        /// </summary>
        [EnumMember(Value = "DHL_HK")]
        DhlHk,

        /// <summary>
        ///SKYNET UAE.
        /// SkynetUae.
        /// </summary>
        [EnumMember(Value = "SKYNET_UAE")]
        SkynetUae,

        /// <summary>
        ///Gojek.
        /// Gojek.
        /// </summary>
        [EnumMember(Value = "GOJEK")]
        Gojek,

        /// <summary>
        ///Yodel International.
        /// YodelIntnl.
        /// </summary>
        [EnumMember(Value = "YODEL_INTNL")]
        YodelIntnl,

        /// <summary>
        ///Janco Ecommerce.
        /// Janco.
        /// </summary>
        [EnumMember(Value = "JANCO")]
        Janco,

        /// <summary>
        ///YTO Express.
        /// Yto.
        /// </summary>
        [EnumMember(Value = "YTO")]
        Yto,

        /// <summary>
        ///Wise Express.
        /// WiseExpress.
        /// </summary>
        [EnumMember(Value = "WISE_EXPRESS")]
        WiseExpress,

        /// <summary>
        ///J&T Express Vietnam.
        /// JtexpressVn.
        /// </summary>
        [EnumMember(Value = "JTEXPRESS_VN")]
        JtexpressVn,

        /// <summary>
        ///FedEx International MailService.
        /// FedexIntlMlserv.
        /// </summary>
        [EnumMember(Value = "FEDEX_INTL_MLSERV")]
        FedexIntlMlserv,

        /// <summary>
        ///VAMOX.
        /// Vamox.
        /// </summary>
        [EnumMember(Value = "VAMOX")]
        Vamox,

        /// <summary>
        ///AMS Group.
        /// AmsGrp.
        /// </summary>
        [EnumMember(Value = "AMS_GRP")]
        AmsGrp,

        /// <summary>
        ///DHL Japan.
        /// DhlJp.
        /// </summary>
        [EnumMember(Value = "DHL_JP")]
        DhlJp,

        /// <summary>
        ///HR Parcel.
        /// Hrparcel.
        /// </summary>
        [EnumMember(Value = "HRPARCEL")]
        Hrparcel,

        /// <summary>
        ///GESWL Express.
        /// Geswl.
        /// </summary>
        [EnumMember(Value = "GESWL")]
        Geswl,

        /// <summary>
        ///Blue Star.
        /// Bluestar.
        /// </summary>
        [EnumMember(Value = "BLUESTAR")]
        Bluestar,

        /// <summary>
        ///CDEK TR.
        /// CdekTr.
        /// </summary>
        [EnumMember(Value = "CDEK_TR")]
        CdekTr,

        /// <summary>
        ///Innovel courier.
        /// Descartes.
        /// </summary>
        [EnumMember(Value = "DESCARTES")]
        Descartes,

        /// <summary>
        ///Deltec Courier.
        /// DeltecUk.
        /// </summary>
        [EnumMember(Value = "DELTEC_UK")]
        DeltecUk,

        /// <summary>
        ///DTDC express.
        /// DtdcExpress.
        /// </summary>
        [EnumMember(Value = "DTDC_EXPRESS")]
        DtdcExpress,

        /// <summary>
        ///tourline.
        /// Tourline.
        /// </summary>
        [EnumMember(Value = "TOURLINE")]
        Tourline,

        /// <summary>
        ///B&H Worldwide.
        /// BhWorldwide.
        /// </summary>
        [EnumMember(Value = "BH_WORLDWIDE")]
        BhWorldwide,

        /// <summary>
        ///OCS ANA Group.
        /// Ocs.
        /// </summary>
        [EnumMember(Value = "OCS")]
        Ocs,

        /// <summary>
        ///yingnuo logistics.
        /// YingnuoLogistics.
        /// </summary>
        [EnumMember(Value = "YINGNUO_LOGISTICS")]
        YingnuoLogistics,

        /// <summary>
        ///United Parcel Service.
        /// Ups.
        /// </summary>
        [EnumMember(Value = "UPS")]
        Ups,

        /// <summary>
        ///Toll IPEC.
        /// Toll.
        /// </summary>
        [EnumMember(Value = "TOLL")]
        Toll,

        /// <summary>
        ///SEUR portugal.
        /// PrtSeur.
        /// </summary>
        [EnumMember(Value = "PRT_SEUR")]
        PrtSeur,

        /// <summary>
        ///DTDC Australia.
        /// DtdcAu.
        /// </summary>
        [EnumMember(Value = "DTDC_AU")]
        DtdcAu,

        /// <summary>
        ///Dynamic Logistics.
        /// ThaDynamicLogistics.
        /// </summary>
        [EnumMember(Value = "THA_DYNAMIC_LOGISTICS")]
        ThaDynamicLogistics,

        /// <summary>
        ///UBI Smart Parcel.
        /// UbiLogistics.
        /// </summary>
        [EnumMember(Value = "UBI_LOGISTICS")]
        UbiLogistics,

        /// <summary>
        ///FedEx Cross Border.
        /// FedexCrossborder.
        /// </summary>
        [EnumMember(Value = "FEDEX_CROSSBORDER")]
        FedexCrossborder,

        /// <summary>
        ///A1Post.
        /// A1Post.
        /// </summary>
        [EnumMember(Value = "A1POST")]
        A1Post,

        /// <summary>
        ///Tazmanian Freight Systems.
        /// TazmanianFreight.
        /// </summary>
        [EnumMember(Value = "TAZMANIAN_FREIGHT")]
        TazmanianFreight,

        /// <summary>
        ///CJ International malaysia.
        /// CjIntMy.
        /// </summary>
        [EnumMember(Value = "CJ_INT_MY")]
        CjIntMy,

        /// <summary>
        ///Saia LTL Freight.
        /// SaiaFreight.
        /// </summary>
        [EnumMember(Value = "SAIA_FREIGHT")]
        SaiaFreight,

        /// <summary>
        ///Qxpress.
        /// SgQxpress.
        /// </summary>
        [EnumMember(Value = "SG_QXPRESS")]
        SgQxpress,

        /// <summary>
        ///Nhans Solutions.
        /// NhansSolutions.
        /// </summary>
        [EnumMember(Value = "NHANS_SOLUTIONS")]
        NhansSolutions,

        /// <summary>
        ///DPD France.
        /// DpdFr.
        /// </summary>
        [EnumMember(Value = "DPD_FR")]
        DpdFr,

        /// <summary>
        ///Coordinadora.
        /// Coordinadora.
        /// </summary>
        [EnumMember(Value = "COORDINADORA")]
        Coordinadora,

        /// <summary>
        ///Grupo logistico Andreani.
        /// Andreani.
        /// </summary>
        [EnumMember(Value = "ANDREANI")]
        Andreani,

        /// <summary>
        ///Doora Logistics.
        /// Doora.
        /// </summary>
        [EnumMember(Value = "DOORA")]
        Doora,

        /// <summary>
        ///Interparcel New Zealand.
        /// InterparcelNz.
        /// </summary>
        [EnumMember(Value = "INTERPARCEL_NZ")]
        InterparcelNz,

        /// <summary>
        ///Jam Express Philippines.
        /// PhlJamexpress.
        /// </summary>
        [EnumMember(Value = "PHL_JAMEXPRESS")]
        PhlJamexpress,

        /// <summary>
        ///bel_belgium_post.
        /// BelBelgiumPost.
        /// </summary>
        [EnumMember(Value = "BEL_BELGIUM_POST")]
        BelBelgiumPost,

        /// <summary>
        ///us_apc.
        /// UsApc.
        /// </summary>
        [EnumMember(Value = "US_APC")]
        UsApc,

        /// <summary>
        ///idn_pos.
        /// IdnPos.
        /// </summary>
        [EnumMember(Value = "IDN_POS")]
        IdnPos,

        /// <summary>
        ///fr_mondial.
        /// FrMondial.
        /// </summary>
        [EnumMember(Value = "FR_MONDIAL")]
        FrMondial,

        /// <summary>
        ///DE DHL.
        /// DeDhl.
        /// </summary>
        [EnumMember(Value = "DE_DHL")]
        DeDhl,

        /// <summary>
        ///hk_rpx.
        /// HkRpx.
        /// </summary>
        [EnumMember(Value = "HK_RPX")]
        HkRpx,

        /// <summary>
        ///dhl_pieceid.
        /// DhlPieceid.
        /// </summary>
        [EnumMember(Value = "DHL_PIECEID")]
        DhlPieceid,

        /// <summary>
        ///vnpost_ems.
        /// VnpostEms.
        /// </summary>
        [EnumMember(Value = "VNPOST_EMS")]
        VnpostEms,

        /// <summary>
        ///rrdonnelley.
        /// Rrdonnelley.
        /// </summary>
        [EnumMember(Value = "RRDONNELLEY")]
        Rrdonnelley,

        /// <summary>
        ///dpd_de.
        /// DpdDe.
        /// </summary>
        [EnumMember(Value = "DPD_DE")]
        DpdDe,

        /// <summary>
        ///delcart_in.
        /// DelcartIn.
        /// </summary>
        [EnumMember(Value = "DELCART_IN")]
        DelcartIn,

        /// <summary>
        ///imexglobalsolutions.
        /// Imexglobalsolutions.
        /// </summary>
        [EnumMember(Value = "IMEXGLOBALSOLUTIONS")]
        Imexglobalsolutions,

        /// <summary>
        ///ACOMMERCE.
        /// Acommerce.
        /// </summary>
        [EnumMember(Value = "ACOMMERCE")]
        Acommerce,

        /// <summary>
        ///eurodis.
        /// Eurodis.
        /// </summary>
        [EnumMember(Value = "EURODIS")]
        Eurodis,

        /// <summary>
        ///CANPAR.
        /// Canpar.
        /// </summary>
        [EnumMember(Value = "CANPAR")]
        Canpar,

        /// <summary>
        ///GLS.
        /// Gls.
        /// </summary>
        [EnumMember(Value = "GLS")]
        Gls,

        /// <summary>
        ///Ecom Express.
        /// IndEcom.
        /// </summary>
        [EnumMember(Value = "IND_ECOM")]
        IndEcom,

        /// <summary>
        ///Envialia.
        /// EspEnvialia.
        /// </summary>
        [EnumMember(Value = "ESP_ENVIALIA")]
        EspEnvialia,

        /// <summary>
        ///dhl UK.
        /// DhlUk.
        /// </summary>
        [EnumMember(Value = "DHL_UK")]
        DhlUk,

        /// <summary>
        ///SMSA Express.
        /// SmsaExpress.
        /// </summary>
        [EnumMember(Value = "SMSA_EXPRESS")]
        SmsaExpress,

        /// <summary>
        ///TNT France.
        /// TntFr.
        /// </summary>
        [EnumMember(Value = "TNT_FR")]
        TntFr,

        /// <summary>
        ///DEX-I courier.
        /// DexI.
        /// </summary>
        [EnumMember(Value = "DEX_I")]
        DexI,

        /// <summary>
        ///Budbee courier.
        /// BudbeeWebhook.
        /// </summary>
        [EnumMember(Value = "BUDBEE_WEBHOOK")]
        BudbeeWebhook,

        /// <summary>
        ///Copa Airlines Courier.
        /// CopaCourier.
        /// </summary>
        [EnumMember(Value = "COPA_COURIER")]
        CopaCourier,

        /// <summary>
        ///Vietnam Post.
        /// VnmVietnamPost.
        /// </summary>
        [EnumMember(Value = "VNM_VIETNAM_POST")]
        VnmVietnamPost,

        /// <summary>
        ///DPD HongKong.
        /// DpdHk.
        /// </summary>
        [EnumMember(Value = "DPD_HK")]
        DpdHk,

        /// <summary>
        ///Toll New Zealand.
        /// TollNz.
        /// </summary>
        [EnumMember(Value = "TOLL_NZ")]
        TollNz,

        /// <summary>
        ///Echo courier.
        /// Echo.
        /// </summary>
        [EnumMember(Value = "ECHO")]
        Echo,

        /// <summary>
        ///FedEx® Freight.
        /// FedexFr.
        /// </summary>
        [EnumMember(Value = "FEDEX_FR")]
        FedexFr,

        /// <summary>
        ///Border Express.
        /// Borderexpress.
        /// </summary>
        [EnumMember(Value = "BORDEREXPRESS")]
        Borderexpress,

        /// <summary>
        ///MailPlus (Japan).
        /// MailplusJpn.
        /// </summary>
        [EnumMember(Value = "MAILPLUS_JPN")]
        MailplusJpn,

        /// <summary>
        ///TNT UK Reference.
        /// TntUkRefr.
        /// </summary>
        [EnumMember(Value = "TNT_UK_REFR")]
        TntUkRefr,

        /// <summary>
        ///KEC courier.
        /// Kec.
        /// </summary>
        [EnumMember(Value = "KEC")]
        Kec,

        /// <summary>
        ///DPD Romania.
        /// DpdRo.
        /// </summary>
        [EnumMember(Value = "DPD_RO")]
        DpdRo,

        /// <summary>
        ///TNT_JP.
        /// TntJp.
        /// </summary>
        [EnumMember(Value = "TNT_JP")]
        TntJp,

        /// <summary>
        ///TH_CJ.
        /// ThCj.
        /// </summary>
        [EnumMember(Value = "TH_CJ")]
        ThCj,

        /// <summary>
        ///EC_CN.
        /// EcCn.
        /// </summary>
        [EnumMember(Value = "EC_CN")]
        EcCn,

        /// <summary>
        ///FASTWAY_UK.
        /// FastwayUk.
        /// </summary>
        [EnumMember(Value = "FASTWAY_UK")]
        FastwayUk,

        /// <summary>
        ///FASTWAY_US.
        /// FastwayUs.
        /// </summary>
        [EnumMember(Value = "FASTWAY_US")]
        FastwayUs,

        /// <summary>
        ///GLS_DE.
        /// GlsDe.
        /// </summary>
        [EnumMember(Value = "GLS_DE")]
        GlsDe,

        /// <summary>
        ///GLS_ES.
        /// GlsEs.
        /// </summary>
        [EnumMember(Value = "GLS_ES")]
        GlsEs,

        /// <summary>
        ///GLS_FR.
        /// GlsFr.
        /// </summary>
        [EnumMember(Value = "GLS_FR")]
        GlsFr,

        /// <summary>
        ///MONDIAL_BE.
        /// MondialBe.
        /// </summary>
        [EnumMember(Value = "MONDIAL_BE")]
        MondialBe,

        /// <summary>
        ///SGT_IT.
        /// SgtIt.
        /// </summary>
        [EnumMember(Value = "SGT_IT")]
        SgtIt,

        /// <summary>
        ///TNT_CN.
        /// TntCn.
        /// </summary>
        [EnumMember(Value = "TNT_CN")]
        TntCn,

        /// <summary>
        ///TNT_DE.
        /// TntDe.
        /// </summary>
        [EnumMember(Value = "TNT_DE")]
        TntDe,

        /// <summary>
        ///TNT_ES.
        /// TntEs.
        /// </summary>
        [EnumMember(Value = "TNT_ES")]
        TntEs,

        /// <summary>
        ///TNT_PL.
        /// TntPl.
        /// </summary>
        [EnumMember(Value = "TNT_PL")]
        TntPl,

        /// <summary>
        ///PARCELFORCE.
        /// Parcelforce.
        /// </summary>
        [EnumMember(Value = "PARCELFORCE")]
        Parcelforce,

        /// <summary>
        ///SWISS POST.
        /// SwissPost.
        /// </summary>
        [EnumMember(Value = "SWISS_POST")]
        SwissPost,

        /// <summary>
        ///TOLL IPEC.
        /// TollIpec.
        /// </summary>
        [EnumMember(Value = "TOLL_IPEC")]
        TollIpec,

        /// <summary>
        ///AIR 21.
        /// Air21.
        /// </summary>
        [EnumMember(Value = "AIR_21")]
        Air21,

        /// <summary>
        ///AIRSPEED.
        /// Airspeed.
        /// </summary>
        [EnumMember(Value = "AIRSPEED")]
        Airspeed,

        /// <summary>
        ///BERT.
        /// Bert.
        /// </summary>
        [EnumMember(Value = "BERT")]
        Bert,

        /// <summary>
        ///BLUEDART.
        /// Bluedart.
        /// </summary>
        [EnumMember(Value = "BLUEDART")]
        Bluedart,

        /// <summary>
        ///COLLECTPLUS.
        /// Collectplus.
        /// </summary>
        [EnumMember(Value = "COLLECTPLUS")]
        Collectplus,

        /// <summary>
        ///COURIERPLUS.
        /// Courierplus.
        /// </summary>
        [EnumMember(Value = "COURIERPLUS")]
        Courierplus,

        /// <summary>
        ///COURIER POST.
        /// CourierPost.
        /// </summary>
        [EnumMember(Value = "COURIER_POST")]
        CourierPost,

        /// <summary>
        ///dhl_global_mail.
        /// DhlGlobalMail.
        /// </summary>
        [EnumMember(Value = "DHL_GLOBAL_MAIL")]
        DhlGlobalMail,

        /// <summary>
        ///dpd_uk.
        /// DpdUk.
        /// </summary>
        [EnumMember(Value = "DPD_UK")]
        DpdUk,

        /// <summary>
        ///DELTEC DE.
        /// DeltecDe.
        /// </summary>
        [EnumMember(Value = "DELTEC_DE")]
        DeltecDe,

        /// <summary>
        ///deutsche_de.
        /// DeutscheDe.
        /// </summary>
        [EnumMember(Value = "DEUTSCHE_DE")]
        DeutscheDe,

        /// <summary>
        ///DOTZOT.
        /// Dotzot.
        /// </summary>
        [EnumMember(Value = "DOTZOT")]
        Dotzot,

        /// <summary>
        ///elta_gr.
        /// EltaGr.
        /// </summary>
        [EnumMember(Value = "ELTA_GR")]
        EltaGr,

        /// <summary>
        ///ems_cn.
        /// EmsCn.
        /// </summary>
        [EnumMember(Value = "EMS_CN")]
        EmsCn,

        /// <summary>
        ///ECARGO.
        /// Ecargo.
        /// </summary>
        [EnumMember(Value = "ECARGO")]
        Ecargo,

        /// <summary>
        ///ENSENDA.
        /// Ensenda.
        /// </summary>
        [EnumMember(Value = "ENSENDA")]
        Ensenda,

        /// <summary>
        ///fercam_it.
        /// FercamIt.
        /// </summary>
        [EnumMember(Value = "FERCAM_IT")]
        FercamIt,

        /// <summary>
        ///fastway_za.
        /// FastwayZa.
        /// </summary>
        [EnumMember(Value = "FASTWAY_ZA")]
        FastwayZa,

        /// <summary>
        ///fastway_au.
        /// FastwayAu.
        /// </summary>
        [EnumMember(Value = "FASTWAY_AU")]
        FastwayAu,

        /// <summary>
        ///first_logisitcs.
        /// FirstLogisitcs.
        /// </summary>
        [EnumMember(Value = "FIRST_LOGISITCS")]
        FirstLogisitcs,

        /// <summary>
        ///GEODIS.
        /// Geodis.
        /// </summary>
        [EnumMember(Value = "GEODIS")]
        Geodis,

        /// <summary>
        ///GLOBEGISTICS.
        /// Globegistics.
        /// </summary>
        [EnumMember(Value = "GLOBEGISTICS")]
        Globegistics,

        /// <summary>
        ///GREYHOUND.
        /// Greyhound.
        /// </summary>
        [EnumMember(Value = "GREYHOUND")]
        Greyhound,

        /// <summary>
        ///jetship_my.
        /// JetshipMy.
        /// </summary>
        [EnumMember(Value = "JETSHIP_MY")]
        JetshipMy,

        /// <summary>
        ///LION PARCEL.
        /// LionParcel.
        /// </summary>
        [EnumMember(Value = "LION_PARCEL")]
        LionParcel,

        /// <summary>
        ///AEROFLASH.
        /// Aeroflash.
        /// </summary>
        [EnumMember(Value = "AEROFLASH")]
        Aeroflash,

        /// <summary>
        ///ONTRAC.
        /// Ontrac.
        /// </summary>
        [EnumMember(Value = "ONTRAC")]
        Ontrac,

        /// <summary>
        ///SAGAWA.
        /// Sagawa.
        /// </summary>
        [EnumMember(Value = "SAGAWA")]
        Sagawa,

        /// <summary>
        ///SIODEMKA.
        /// Siodemka.
        /// </summary>
        [EnumMember(Value = "SIODEMKA")]
        Siodemka,

        /// <summary>
        ///startrack.
        /// Startrack.
        /// </summary>
        [EnumMember(Value = "STARTRACK")]
        Startrack,

        /// <summary>
        ///tnt_au.
        /// TntAu.
        /// </summary>
        [EnumMember(Value = "TNT_AU")]
        TntAu,

        /// <summary>
        ///tnt_it.
        /// TntIt.
        /// </summary>
        [EnumMember(Value = "TNT_IT")]
        TntIt,

        /// <summary>
        ///TRANSMISSION.
        /// Transmission.
        /// </summary>
        [EnumMember(Value = "TRANSMISSION")]
        Transmission,

        /// <summary>
        ///YAMATO.
        /// Yamato.
        /// </summary>
        [EnumMember(Value = "YAMATO")]
        Yamato,

        /// <summary>
        ///dhl_it.
        /// DhlIt.
        /// </summary>
        [EnumMember(Value = "DHL_IT")]
        DhlIt,

        /// <summary>
        ///dhl_at.
        /// DhlAt.
        /// </summary>
        [EnumMember(Value = "DHL_AT")]
        DhlAt,

        /// <summary>
        ///LOGISTICSWORLDWIDE KR.
        /// LogisticsworldwideKr.
        /// </summary>
        [EnumMember(Value = "LOGISTICSWORLDWIDE_KR")]
        LogisticsworldwideKr,

        /// <summary>
        ///gls_spain.
        /// GlsSpain.
        /// </summary>
        [EnumMember(Value = "GLS_SPAIN")]
        GlsSpain,

        /// <summary>
        ///amazon_uk_api.
        /// AmazonUkApi.
        /// </summary>
        [EnumMember(Value = "AMAZON_UK_API")]
        AmazonUkApi,

        /// <summary>
        ///dpd_fr_reference.
        /// DpdFrReference.
        /// </summary>
        [EnumMember(Value = "DPD_FR_REFERENCE")]
        DpdFrReference,

        /// <summary>
        ///dhlparcel_uk.
        /// DhlparcelUk.
        /// </summary>
        [EnumMember(Value = "DHLPARCEL_UK")]
        DhlparcelUk,

        /// <summary>
        ///megasave.
        /// Megasave.
        /// </summary>
        [EnumMember(Value = "MEGASAVE")]
        Megasave,

        /// <summary>
        ///qualitypost.
        /// Qualitypost.
        /// </summary>
        [EnumMember(Value = "QUALITYPOST")]
        Qualitypost,

        /// <summary>
        ///ids_logistics.
        /// IdsLogistics.
        /// </summary>
        [EnumMember(Value = "IDS_LOGISTICS")]
        IdsLogistics,

        /// <summary>
        ///joyingbox.
        /// Joyingbox1.
        /// </summary>
        [EnumMember(Value = "JOYINGBOX")]
        Joyingbox1,

        /// <summary>
        ///panther_order_number.
        /// PantherOrderNumber.
        /// </summary>
        [EnumMember(Value = "PANTHER_ORDER_NUMBER")]
        PantherOrderNumber,

        /// <summary>
        ///watkins_shepard.
        /// WatkinsShepard.
        /// </summary>
        [EnumMember(Value = "WATKINS_SHEPARD")]
        WatkinsShepard,

        /// <summary>
        ///fasttrack.
        /// Fasttrack.
        /// </summary>
        [EnumMember(Value = "FASTTRACK")]
        Fasttrack,

        /// <summary>
        ///up_express.
        /// UpExpress.
        /// </summary>
        [EnumMember(Value = "UP_EXPRESS")]
        UpExpress,

        /// <summary>
        ///elogistica.
        /// Elogistica.
        /// </summary>
        [EnumMember(Value = "ELOGISTICA")]
        Elogistica,

        /// <summary>
        ///ecourier.
        /// Ecourier.
        /// </summary>
        [EnumMember(Value = "ECOURIER")]
        Ecourier,

        /// <summary>
        ///cj_philippines.
        /// CjPhilippines.
        /// </summary>
        [EnumMember(Value = "CJ_PHILIPPINES")]
        CjPhilippines,

        /// <summary>
        ///speedex.
        /// Speedex.
        /// </summary>
        [EnumMember(Value = "SPEEDEX")]
        Speedex,

        /// <summary>
        ///orangeconnex.
        /// Orangeconnex.
        /// </summary>
        [EnumMember(Value = "ORANGECONNEX")]
        Orangeconnex,

        /// <summary>
        ///tecor.
        /// Tecor.
        /// </summary>
        [EnumMember(Value = "TECOR")]
        Tecor,

        /// <summary>
        ///saee.
        /// Saee.
        /// </summary>
        [EnumMember(Value = "SAEE")]
        Saee,

        /// <summary>
        ///gls_italy_ftp.
        /// GlsItalyFtp.
        /// </summary>
        [EnumMember(Value = "GLS_ITALY_FTP")]
        GlsItalyFtp,

        /// <summary>
        ///delivere.
        /// Delivere.
        /// </summary>
        [EnumMember(Value = "DELIVERE")]
        Delivere,

        /// <summary>
        ///yycom.
        /// Yycom.
        /// </summary>
        [EnumMember(Value = "YYCOM")]
        Yycom,

        /// <summary>
        ///Adicional Logistics.
        /// AdicionalPt.
        /// </summary>
        [EnumMember(Value = "ADICIONAL_PT")]
        AdicionalPt,

        /// <summary>
        ///DKSH.
        /// Dksh.
        /// </summary>
        [EnumMember(Value = "DKSH")]
        Dksh,

        /// <summary>
        ///Nippon Express.
        /// NipponExpressFtp.
        /// </summary>
        [EnumMember(Value = "NIPPON_EXPRESS_FTP")]
        NipponExpressFtp,

        /// <summary>
        ///GO Logistics & Storage.
        /// Gols.
        /// </summary>
        [EnumMember(Value = "GOLS")]
        Gols,

        /// <summary>
        ///FUJIE EXPRESS.
        /// Fujexp.
        /// </summary>
        [EnumMember(Value = "FUJEXP")]
        Fujexp,

        /// <summary>
        ///QTrack.
        /// Qtrack.
        /// </summary>
        [EnumMember(Value = "QTRACK")]
        Qtrack,

        /// <summary>
        ///OM LOGISTICS LTD.
        /// OmlogisticsApi.
        /// </summary>
        [EnumMember(Value = "OMLOGISTICS_API")]
        OmlogisticsApi,

        /// <summary>
        ///GDPharm Logistics.
        /// Gdpharm.
        /// </summary>
        [EnumMember(Value = "GDPHARM")]
        Gdpharm,

        /// <summary>
        ///MISUMI Group Inc..
        /// MisumiCn.
        /// </summary>
        [EnumMember(Value = "MISUMI_CN")]
        MisumiCn,

        /// <summary>
        ///Rivo.
        /// AirCanada.
        /// </summary>
        [EnumMember(Value = "AIR_CANADA")]
        AirCanada,

        /// <summary>
        ///City Express.
        /// City56Webhook.
        /// </summary>
        [EnumMember(Value = "CITY56_WEBHOOK")]
        City56Webhook,

        /// <summary>
        ///Sagawa.
        /// SagawaApi.
        /// </summary>
        [EnumMember(Value = "SAGAWA_API")]
        SagawaApi,

        /// <summary>
        ///KedaEX.
        /// Kedaex.
        /// </summary>
        [EnumMember(Value = "KEDAEX")]
        Kedaex,

        /// <summary>
        ///Pgeon.
        /// PgeonApi.
        /// </summary>
        [EnumMember(Value = "PGEON_API")]
        PgeonApi,

        /// <summary>
        ///We World Express.
        /// Weworldexpress.
        /// </summary>
        [EnumMember(Value = "WEWORLDEXPRESS")]
        Weworldexpress,

        /// <summary>
        ///J&T International logistics.
        /// JtLogistics.
        /// </summary>
        [EnumMember(Value = "JT_LOGISTICS")]
        JtLogistics,

        /// <summary>
        ///Trusk France.
        /// Trusk.
        /// </summary>
        [EnumMember(Value = "TRUSK")]
        Trusk,

        /// <summary>
        ///ViaXpress.
        /// Viaxpress.
        /// </summary>
        [EnumMember(Value = "VIAXPRESS")]
        Viaxpress,

        /// <summary>
        ///DHL Supply Chain Indonesia.
        /// DhlSupplychainId.
        /// </summary>
        [EnumMember(Value = "DHL_SUPPLYCHAIN_ID")]
        DhlSupplychainId,

        /// <summary>
        ///Zuellig Pharma Korea.
        /// ZuelligpharmaSftp.
        /// </summary>
        [EnumMember(Value = "ZUELLIGPHARMA_SFTP")]
        ZuelligpharmaSftp,

        /// <summary>
        ///Meest.
        /// Meest.
        /// </summary>
        [EnumMember(Value = "MEEST")]
        Meest,

        /// <summary>
        ///Toll Priority.
        /// TollPriority.
        /// </summary>
        [EnumMember(Value = "TOLL_PRIORITY")]
        TollPriority,

        /// <summary>
        ///Mothership.
        /// MothershipApi.
        /// </summary>
        [EnumMember(Value = "MOTHERSHIP_API")]
        MothershipApi,

        /// <summary>
        ///Capital Transport.
        /// Capital.
        /// </summary>
        [EnumMember(Value = "CAPITAL")]
        Capital,

        /// <summary>
        ///Europacket+.
        /// EuropaketApi.
        /// </summary>
        [EnumMember(Value = "EUROPAKET_API")]
        EuropaketApi,

        /// <summary>
        ///HFD.
        /// Hfd.
        /// </summary>
        [EnumMember(Value = "HFD")]
        Hfd,

        /// <summary>
        ///Tourline Express.
        /// TourlineReference.
        /// </summary>
        [EnumMember(Value = "TOURLINE_REFERENCE")]
        TourlineReference,

        /// <summary>
        ///GIO Express Inc.
        /// GioEcourier.
        /// </summary>
        [EnumMember(Value = "GIO_ECOURIER")]
        GioEcourier,

        /// <summary>
        ///CN Logistics.
        /// CnLogistics.
        /// </summary>
        [EnumMember(Value = "CN_LOGISTICS")]
        CnLogistics,

        /// <summary>
        ///Pandion.
        /// Pandion.
        /// </summary>
        [EnumMember(Value = "PANDION")]
        Pandion,

        /// <summary>
        ///Bpost API.
        /// BpostApi.
        /// </summary>
        [EnumMember(Value = "BPOST_API")]
        BpostApi,

        /// <summary>
        ///Passport Shipping.
        /// Passportshipping.
        /// </summary>
        [EnumMember(Value = "PASSPORTSHIPPING")]
        Passportshipping,

        /// <summary>
        ///Pakajo World.
        /// Pakajo.
        /// </summary>
        [EnumMember(Value = "PAKAJO")]
        Pakajo,

        /// <summary>
        ///DACHSER.
        /// Dachser.
        /// </summary>
        [EnumMember(Value = "DACHSER")]
        Dachser,

        /// <summary>
        ///Yusen Logistics.
        /// YusenSftp.
        /// </summary>
        [EnumMember(Value = "YUSEN_SFTP")]
        YusenSftp,

        /// <summary>
        ///Shypmax.
        /// Shyplite.
        /// </summary>
        [EnumMember(Value = "SHYPLITE")]
        Shyplite,

        /// <summary>
        ///Xingyunyi Logistics.
        /// Xyy.
        /// </summary>
        [EnumMember(Value = "XYY")]
        Xyy,

        /// <summary>
        ///Metropolitan Warehouse & Delivery.
        /// Mwd.
        /// </summary>
        [EnumMember(Value = "MWD")]
        Mwd,

        /// <summary>
        ///Faxe Cargo.
        /// Faxecargo.
        /// </summary>
        [EnumMember(Value = "FAXECARGO")]
        Faxecargo,

        /// <summary>
        ///Groupe Mazet.
        /// Mazet.
        /// </summary>
        [EnumMember(Value = "MAZET")]
        Mazet,

        /// <summary>
        ///First Logistics.
        /// FirstLogisticsApi.
        /// </summary>
        [EnumMember(Value = "FIRST_LOGISTICS_API")]
        FirstLogisticsApi,

        /// <summary>
        ///SPRINT PACK.
        /// SprintPack.
        /// </summary>
        [EnumMember(Value = "SPRINT_PACK")]
        SprintPack,

        /// <summary>
        ///Hermes Germany.
        /// HermesDeFtp.
        /// </summary>
        [EnumMember(Value = "HERMES_DE_FTP")]
        HermesDeFtp,

        /// <summary>
        ///Concise.
        /// Concise.
        /// </summary>
        [EnumMember(Value = "CONCISE")]
        Concise,

        /// <summary>
        ///Kerry Express TaiWan.
        /// KerryExpressTwApi.
        /// </summary>
        [EnumMember(Value = "KERRY_EXPRESS_TW_API")]
        KerryExpressTwApi,

        /// <summary>
        ///EWE Global Express.
        /// Ewe.
        /// </summary>
        [EnumMember(Value = "EWE")]
        Ewe,

        /// <summary>
        ///Fast Despatch Logistics Limited.
        /// Fastdespatch.
        /// </summary>
        [EnumMember(Value = "FASTDESPATCH")]
        Fastdespatch,

        /// <summary>
        ///AB Custom Group.
        /// AbcustomSftp.
        /// </summary>
        [EnumMember(Value = "ABCUSTOM_SFTP")]
        AbcustomSftp,

        /// <summary>
        ///Chazki.
        /// Chazki.
        /// </summary>
        [EnumMember(Value = "CHAZKI")]
        Chazki,

        /// <summary>
        ///Shippie.
        /// Shippie.
        /// </summary>
        [EnumMember(Value = "SHIPPIE")]
        Shippie,

        /// <summary>
        ///GEODIS - Distribution & Express.
        /// GeodisApi.
        /// </summary>
        [EnumMember(Value = "GEODIS_API")]
        GeodisApi,

        /// <summary>
        ///Naqel Express.
        /// NaqelExpress.
        /// </summary>
        [EnumMember(Value = "NAQEL_EXPRESS")]
        NaqelExpress,

        /// <summary>
        ///Papa.
        /// PapaWebhook.
        /// </summary>
        [EnumMember(Value = "PAPA_WEBHOOK")]
        PapaWebhook,

        /// <summary>
        ///Forward Air.
        /// Forwardair.
        /// </summary>
        [EnumMember(Value = "FORWARDAIR")]
        Forwardair,

        /// <summary>
        ///Dialogo Logistica.
        /// DialogoLogisticaApi.
        /// </summary>
        [EnumMember(Value = "DIALOGO_LOGISTICA_API")]
        DialogoLogisticaApi,

        /// <summary>
        ///Lalamove.
        /// LalamoveApi.
        /// </summary>
        [EnumMember(Value = "LALAMOVE_API")]
        LalamoveApi,

        /// <summary>
        ///Tomydoor.
        /// Tomydoor.
        /// </summary>
        [EnumMember(Value = "TOMYDOOR")]
        Tomydoor,

        /// <summary>
        ///Kronos Express.
        /// KronosWebhook.
        /// </summary>
        [EnumMember(Value = "KRONOS_WEBHOOK")]
        KronosWebhook,

        /// <summary>
        ///J&T CARGO.
        /// Jtcargo.
        /// </summary>
        [EnumMember(Value = "JTCARGO")]
        Jtcargo,

        /// <summary>
        ///T-cat.
        /// TCat.
        /// </summary>
        [EnumMember(Value = "T_CAT")]
        TCat,

        /// <summary>
        ///Concise.
        /// ConciseWebhook.
        /// </summary>
        [EnumMember(Value = "CONCISE_WEBHOOK")]
        ConciseWebhook,

        /// <summary>
        ///Teleport.
        /// TeleportWebhook.
        /// </summary>
        [EnumMember(Value = "TELEPORT_WEBHOOK")]
        TeleportWebhook,

        /// <summary>
        ///The Custom Companies.
        /// CustomcoApi.
        /// </summary>
        [EnumMember(Value = "CUSTOMCO_API")]
        CustomcoApi,

        /// <summary>
        ///Shopee Xpress.
        /// SpxTh.
        /// </summary>
        [EnumMember(Value = "SPX_TH")]
        SpxTh,

        /// <summary>
        ///Bollore Logistics.
        /// BolloreLogistics.
        /// </summary>
        [EnumMember(Value = "BOLLORE_LOGISTICS")]
        BolloreLogistics,

        /// <summary>
        ///ClickLink.
        /// ClicklinkSftp.
        /// </summary>
        [EnumMember(Value = "CLICKLINK_SFTP")]
        ClicklinkSftp,

        /// <summary>
        ///M3 Logistics.
        /// M3Logistics.
        /// </summary>
        [EnumMember(Value = "M3LOGISTICS")]
        M3Logistics,

        /// <summary>
        ///Vietnam Post.
        /// VnpostApi.
        /// </summary>
        [EnumMember(Value = "VNPOST_API")]
        VnpostApi,

        /// <summary>
        ///Axlehire.
        /// AxlehireFtp.
        /// </summary>
        [EnumMember(Value = "AXLEHIRE_FTP")]
        AxlehireFtp,

        /// <summary>
        ///Shadowfax.
        /// Shadowfax.
        /// </summary>
        [EnumMember(Value = "SHADOWFAX")]
        Shadowfax,

        /// <summary>
        ///EVRi.
        /// MyhermesUkApi.
        /// </summary>
        [EnumMember(Value = "MYHERMES_UK_API")]
        MyhermesUkApi,

        /// <summary>
        ///Daiichi Freight System Inc.
        /// Daiichi.
        /// </summary>
        [EnumMember(Value = "DAIICHI")]
        Daiichi,

        /// <summary>
        ///Mensajeros Urbanos.
        /// MensajerosurbanosApi.
        /// </summary>
        [EnumMember(Value = "MENSAJEROSURBANOS_API")]
        MensajerosurbanosApi,

        /// <summary>
        ///PolarSpeed Inc.
        /// Polarspeed.
        /// </summary>
        [EnumMember(Value = "POLARSPEED")]
        Polarspeed,

        /// <summary>
        ///iDexpress Indonesia.
        /// IdexpressId.
        /// </summary>
        [EnumMember(Value = "IDEXPRESS_ID")]
        IdexpressId,

        /// <summary>
        ///Payo.
        /// Payo.
        /// </summary>
        [EnumMember(Value = "PAYO")]
        Payo,

        /// <summary>
        ///Whistl.
        /// WhistlSftp.
        /// </summary>
        [EnumMember(Value = "WHISTL_SFTP")]
        WhistlSftp,

        /// <summary>
        ///INTEX Paketdienst GmbH.
        /// IntexDe.
        /// </summary>
        [EnumMember(Value = "INTEX_DE")]
        IntexDe,

        /// <summary>
        ///Trans2u.
        /// Trans2U.
        /// </summary>
        [EnumMember(Value = "TRANS2U")]
        Trans2U,

        /// <summary>
        ///Product Care Services Limited.
        /// ProductcaregroupSftp.
        /// </summary>
        [EnumMember(Value = "PRODUCTCAREGROUP_SFTP")]
        ProductcaregroupSftp,

        /// <summary>
        ///Big Smart.
        /// Bigsmart.
        /// </summary>
        [EnumMember(Value = "BIGSMART")]
        Bigsmart,

        /// <summary>
        ///Expeditors API Reference.
        /// ExpeditorsApiRef.
        /// </summary>
        [EnumMember(Value = "EXPEDITORS_API_REF")]
        ExpeditorsApiRef,

        /// <summary>
        ///AIT.
        /// AitworldwideApi.
        /// </summary>
        [EnumMember(Value = "AITWORLDWIDE_API")]
        AitworldwideApi,

        /// <summary>
        ///World Courier.
        /// Worldcourier.
        /// </summary>
        [EnumMember(Value = "WORLDCOURIER")]
        Worldcourier,

        /// <summary>
        ///Quiqup.
        /// Quiqup.
        /// </summary>
        [EnumMember(Value = "QUIQUP")]
        Quiqup,

        /// <summary>
        ///Agediss.
        /// AgedissSftp.
        /// </summary>
        [EnumMember(Value = "AGEDISS_SFTP")]
        AgedissSftp,

        /// <summary>
        ///Andreani.
        /// AndreaniApi.
        /// </summary>
        [EnumMember(Value = "ANDREANI_API")]
        AndreaniApi,

        /// <summary>
        ///CRL Express.
        /// Crlexpress.
        /// </summary>
        [EnumMember(Value = "CRLEXPRESS")]
        Crlexpress,

        /// <summary>
        ///SMARTCAT.
        /// Smartcat.
        /// </summary>
        [EnumMember(Value = "SMARTCAT")]
        Smartcat,

        /// <summary>
        ///Crossflight Limited.
        /// Crossflight.
        /// </summary>
        [EnumMember(Value = "CROSSFLIGHT")]
        Crossflight,

        /// <summary>
        ///Pro Carrier.
        /// Procarrier.
        /// </summary>
        [EnumMember(Value = "PROCARRIER")]
        Procarrier,

        /// <summary>
        ///DHL (Reference number).
        /// DhlReferenceApi.
        /// </summary>
        [EnumMember(Value = "DHL_REFERENCE_API")]
        DhlReferenceApi,

        /// <summary>
        ///Seino.
        /// SeinoApi.
        /// </summary>
        [EnumMember(Value = "SEINO_API")]
        SeinoApi,

        /// <summary>
        ///WSP Express.
        /// Wspexpress.
        /// </summary>
        [EnumMember(Value = "WSPEXPRESS")]
        Wspexpress,

        /// <summary>
        ///Kronos Express.
        /// Kronos.
        /// </summary>
        [EnumMember(Value = "KRONOS")]
        Kronos,

        /// <summary>
        ///Total Express.
        /// TotalExpressApi.
        /// </summary>
        [EnumMember(Value = "TOTAL_EXPRESS_API")]
        TotalExpressApi,

        /// <summary>
        ///PARCLL.
        /// Parcll.
        /// </summary>
        [EnumMember(Value = "PARCLL")]
        Parcll,

        /// <summary>
        ///Xpedigo.
        /// Xpedigo.
        /// </summary>
        [EnumMember(Value = "XPEDIGO")]
        Xpedigo,

        /// <summary>
        ///StarTrack.
        /// StarTrackWebhook.
        /// </summary>
        [EnumMember(Value = "STAR_TRACK_WEBHOOK")]
        StarTrackWebhook,

        /// <summary>
        ///Georgian Post.
        /// Gpost.
        /// </summary>
        [EnumMember(Value = "GPOST")]
        Gpost,

        /// <summary>
        ///UCS.
        /// Ucs.
        /// </summary>
        [EnumMember(Value = "UCS")]
        Ucs,

        /// <summary>
        ///DMF.
        /// Dmfgroup.
        /// </summary>
        [EnumMember(Value = "DMFGROUP")]
        Dmfgroup,

        /// <summary>
        ///Coordinadora.
        /// CoordinadoraApi.
        /// </summary>
        [EnumMember(Value = "COORDINADORA_API")]
        CoordinadoraApi,

        /// <summary>
        ///Marken.
        /// Marken.
        /// </summary>
        [EnumMember(Value = "MARKEN")]
        Marken,

        /// <summary>
        ///NTL logistics.
        /// Ntl.
        /// </summary>
        [EnumMember(Value = "NTL")]
        Ntl,

        /// <summary>
        ///Red je Pakketje.
        /// Redjepakketje.
        /// </summary>
        [EnumMember(Value = "REDJEPAKKETJE")]
        Redjepakketje,

        /// <summary>
        ///Allied Express (FTP).
        /// AlliedExpressFtp.
        /// </summary>
        [EnumMember(Value = "ALLIED_EXPRESS_FTP")]
        AlliedExpressFtp,

        /// <summary>
        ///Mondial Relay Spain(Punto Pack).
        /// MondialrelayEs.
        /// </summary>
        [EnumMember(Value = "MONDIALRELAY_ES")]
        MondialrelayEs,

        /// <summary>
        ///Naeko Logistics.
        /// NaekoFtp.
        /// </summary>
        [EnumMember(Value = "NAEKO_FTP")]
        NaekoFtp,

        /// <summary>
        ///Mhi.
        /// Mhi.
        /// </summary>
        [EnumMember(Value = "MHI")]
        Mhi,

        /// <summary>
        ///Shippify, Inc.
        /// Shippify.
        /// </summary>
        [EnumMember(Value = "SHIPPIFY")]
        Shippify,

        /// <summary>
        ///Malca Amit.
        /// MalcaAmitApi.
        /// </summary>
        [EnumMember(Value = "MALCA_AMIT_API")]
        MalcaAmitApi,

        /// <summary>
        ///J&T Express Singapore.
        /// JtexpressSgApi.
        /// </summary>
        [EnumMember(Value = "JTEXPRESS_SG_API")]
        JtexpressSgApi,

        /// <summary>
        ///DACHSER.
        /// DachserWeb.
        /// </summary>
        [EnumMember(Value = "DACHSER_WEB")]
        DachserWeb,

        /// <summary>
        ///Flight Logistics Group.
        /// Flightlg.
        /// </summary>
        [EnumMember(Value = "FLIGHTLG")]
        Flightlg,

        /// <summary>
        ///Cago.
        /// Cago.
        /// </summary>
        [EnumMember(Value = "CAGO")]
        Cago,

        /// <summary>
        ///ComOne Express.
        /// Com1Express.
        /// </summary>
        [EnumMember(Value = "COM1EXPRESS")]
        Com1Express,

        /// <summary>
        ///Tonami.
        /// TonamiFtp.
        /// </summary>
        [EnumMember(Value = "TONAMI_FTP")]
        TonamiFtp,

        /// <summary>
        ///PACKFLEET.
        /// Packfleet.
        /// </summary>
        [EnumMember(Value = "PACKFLEET")]
        Packfleet,

        /// <summary>
        ///Purolator International.
        /// PurolatorInternational.
        /// </summary>
        [EnumMember(Value = "PUROLATOR_INTERNATIONAL")]
        PurolatorInternational,

        /// <summary>
        ///Wineshipping.
        /// WineshippingWebhook.
        /// </summary>
        [EnumMember(Value = "WINESHIPPING_WEBHOOK")]
        WineshippingWebhook,

        /// <summary>
        ///DHL Spain Domestic.
        /// DhlEsSftp.
        /// </summary>
        [EnumMember(Value = "DHL_ES_SFTP")]
        DhlEsSftp,

        /// <summary>
        ///網家速配股份有限公司.
        /// PchomeApi.
        /// </summary>
        [EnumMember(Value = "PCHOME_API")]
        PchomeApi,

        /// <summary>
        ///Czech Post.
        /// CeskapostaApi.
        /// </summary>
        [EnumMember(Value = "CESKAPOSTA_API")]
        CeskapostaApi,

        /// <summary>
        ///Go Rush.
        /// Gorush.
        /// </summary>
        [EnumMember(Value = "GORUSH")]
        Gorush,

        /// <summary>
        ///HomeRunner.
        /// Homerunner.
        /// </summary>
        [EnumMember(Value = "HOMERUNNER")]
        Homerunner,

        /// <summary>
        ///Amazon order.
        /// AmazonOrder.
        /// </summary>
        [EnumMember(Value = "AMAZON_ORDER")]
        AmazonOrder,

        /// <summary>
        ///Estes Forwarding Worldwide.
        /// EfwnowApi.
        /// </summary>
        [EnumMember(Value = "EFWNOW_API")]
        EfwnowApi,

        /// <summary>
        ///CBL Logistica (API).
        /// CblLogisticaApi.
        /// </summary>
        [EnumMember(Value = "CBL_LOGISTICA_API")]
        CblLogisticaApi,

        /// <summary>
        ///NimbusPost.
        /// Nimbuspost.
        /// </summary>
        [EnumMember(Value = "NIMBUSPOST")]
        Nimbuspost,

        /// <summary>
        ///Logwin Logistics.
        /// LogwinLogistics.
        /// </summary>
        [EnumMember(Value = "LOGWIN_LOGISTICS")]
        LogwinLogistics,

        /// <summary>
        ///Sequoialog.
        /// NowlogApi.
        /// </summary>
        [EnumMember(Value = "NOWLOG_API")]
        NowlogApi,

        /// <summary>
        ///DPD Netherlands.
        /// DpdNl.
        /// </summary>
        [EnumMember(Value = "DPD_NL")]
        DpdNl,

        /// <summary>
        ///Dependable Supply Chain Services.
        /// Godependable.
        /// </summary>
        [EnumMember(Value = "GODEPENDABLE")]
        Godependable,

        /// <summary>
        ///Top Ideal Express.
        /// Esdex.
        /// </summary>
        [EnumMember(Value = "ESDEX")]
        Esdex,

        /// <summary>
        ///Kiitäjät.
        /// LogisystemsSftp.
        /// </summary>
        [EnumMember(Value = "LOGISYSTEMS_SFTP")]
        LogisystemsSftp,

        /// <summary>
        ///Expeditors.
        /// Expeditors.
        /// </summary>
        [EnumMember(Value = "EXPEDITORS")]
        Expeditors,

        /// <summary>
        ///Snt Global Etrax.
        /// SntglobalApi.
        /// </summary>
        [EnumMember(Value = "SNTGLOBAL_API")]
        SntglobalApi,

        /// <summary>
        ///ShipX.
        /// Shipx.
        /// </summary>
        [EnumMember(Value = "SHIPX")]
        Shipx,

        /// <summary>
        ///Quickstat Courier LLC.
        /// QintlApi.
        /// </summary>
        [EnumMember(Value = "QINTL_API")]
        QintlApi,

        /// <summary>
        ///Packs.
        /// Packs.
        /// </summary>
        [EnumMember(Value = "PACKS")]
        Packs,

        /// <summary>
        ///PostNL International.
        /// PostnlInternational.
        /// </summary>
        [EnumMember(Value = "POSTNL_INTERNATIONAL")]
        PostnlInternational,

        /// <summary>
        ///Amazon.
        /// AmazonEmailPush.
        /// </summary>
        [EnumMember(Value = "AMAZON_EMAIL_PUSH")]
        AmazonEmailPush,

        /// <summary>
        ///DHL.
        /// DhlApi.
        /// </summary>
        [EnumMember(Value = "DHL_API")]
        DhlApi,

        /// <summary>
        ///Shopee Express.
        /// Spx.
        /// </summary>
        [EnumMember(Value = "SPX")]
        Spx,

        /// <summary>
        ///AxleHire.
        /// Axlehire.
        /// </summary>
        [EnumMember(Value = "AXLEHIRE")]
        Axlehire,

        /// <summary>
        ///ICS COURIER.
        /// Icscourier.
        /// </summary>
        [EnumMember(Value = "ICSCOURIER")]
        Icscourier,

        /// <summary>
        ///Dialogo Logistica.
        /// DialogoLogistica.
        /// </summary>
        [EnumMember(Value = "DIALOGO_LOGISTICA")]
        DialogoLogistica,

        /// <summary>
        ///ShunBang Express.
        /// ShunbangExpress.
        /// </summary>
        [EnumMember(Value = "SHUNBANG_EXPRESS")]
        ShunbangExpress,

        /// <summary>
        ///TCS.
        /// TcsApi.
        /// </summary>
        [EnumMember(Value = "TCS_API")]
        TcsApi,

        /// <summary>
        ///SF Express China.
        /// SfExpressCn.
        /// </summary>
        [EnumMember(Value = "SF_EXPRESS_CN")]
        SfExpressCn,

        /// <summary>
        ///Packeta.
        /// Packeta.
        /// </summary>
        [EnumMember(Value = "PACKETA")]
        Packeta,

        /// <summary>
        ///Teliway SIC Express.
        /// SicTeliway.
        /// </summary>
        [EnumMember(Value = "SIC_TELIWAY")]
        SicTeliway,

        /// <summary>
        ///Mondial Relay France.
        /// MondialrelayFr.
        /// </summary>
        [EnumMember(Value = "MONDIALRELAY_FR")]
        MondialrelayFr,

        /// <summary>
        ///InTime.
        /// IntimeFtp.
        /// </summary>
        [EnumMember(Value = "INTIME_FTP")]
        IntimeFtp,

        /// <summary>
        ///京东物流.
        /// JdExpress.
        /// </summary>
        [EnumMember(Value = "JD_EXPRESS")]
        JdExpress,

        /// <summary>
        ///Fastbox.
        /// Fastbox.
        /// </summary>
        [EnumMember(Value = "FASTBOX")]
        Fastbox,

        /// <summary>
        ///Patheon Logistics.
        /// Patheon.
        /// </summary>
        [EnumMember(Value = "PATHEON")]
        Patheon,

        /// <summary>
        ///India Post Domestic.
        /// IndiaPost.
        /// </summary>
        [EnumMember(Value = "INDIA_POST")]
        IndiaPost,

        /// <summary>
        ///Tipsa Reference.
        /// TipsaRef.
        /// </summary>
        [EnumMember(Value = "TIPSA_REF")]
        TipsaRef,

        /// <summary>
        ///Eco Freight.
        /// Ecofreight.
        /// </summary>
        [EnumMember(Value = "ECOFREIGHT")]
        Ecofreight,

        /// <summary>
        ///VOX SOLUCION EMPRESARIAL SRL.
        /// Vox.
        /// </summary>
        [EnumMember(Value = "VOX")]
        Vox,

        /// <summary>
        ///Direct Freight Express.
        /// DirectfreightAuRef.
        /// </summary>
        [EnumMember(Value = "DIRECTFREIGHT_AU_REF")]
        DirectfreightAuRef,

        /// <summary>
        ///Best Transport.
        /// BesttransportSftp.
        /// </summary>
        [EnumMember(Value = "BESTTRANSPORT_SFTP")]
        BesttransportSftp,

        /// <summary>
        ///Australia Post.
        /// AustraliaPostApi.
        /// </summary>
        [EnumMember(Value = "AUSTRALIA_POST_API")]
        AustraliaPostApi,

        /// <summary>
        ///FragilePAK.
        /// FragilepakSftp.
        /// </summary>
        [EnumMember(Value = "FRAGILEPAK_SFTP")]
        FragilepakSftp,

        /// <summary>
        ///FlipXpress.
        /// Flipxp.
        /// </summary>
        [EnumMember(Value = "FLIPXP")]
        Flipxp,

        /// <summary>
        ///Value Logistics.
        /// ValueWebhook.
        /// </summary>
        [EnumMember(Value = "VALUE_WEBHOOK")]
        ValueWebhook,

        /// <summary>
        ///Daeshin.
        /// Daeshin.
        /// </summary>
        [EnumMember(Value = "DAESHIN")]
        Daeshin,

        /// <summary>
        ///Sherpa.
        /// Sherpa.
        /// </summary>
        [EnumMember(Value = "SHERPA")]
        Sherpa,

        /// <summary>
        ///Metropolitan Warehouse & Delivery.
        /// MwdApi.
        /// </summary>
        [EnumMember(Value = "MWD_API")]
        MwdApi,

        /// <summary>
        ///SmartKargo.
        /// Smartkargo.
        /// </summary>
        [EnumMember(Value = "SMARTKARGO")]
        Smartkargo,

        /// <summary>
        ///DNJ Express.
        /// DnjExpress.
        /// </summary>
        [EnumMember(Value = "DNJ_EXPRESS")]
        DnjExpress,

        /// <summary>
        ///Go People.
        /// Gopeople.
        /// </summary>
        [EnumMember(Value = "GOPEOPLE")]
        Gopeople,

        /// <summary>
        ///mySendle.
        /// MysendleApi.
        /// </summary>
        [EnumMember(Value = "MYSENDLE_API")]
        MysendleApi,

        /// <summary>
        ///Aramex.
        /// AramexApi.
        /// </summary>
        [EnumMember(Value = "ARAMEX_API")]
        AramexApi,

        /// <summary>
        ///Pidge.
        /// Pidge.
        /// </summary>
        [EnumMember(Value = "PIDGE")]
        Pidge,

        /// <summary>
        ///TP Logistic.
        /// Thaiparcels.
        /// </summary>
        [EnumMember(Value = "THAIPARCELS")]
        Thaiparcels,

        /// <summary>
        ///Panther Reference.
        /// PantherReferenceApi.
        /// </summary>
        [EnumMember(Value = "PANTHER_REFERENCE_API")]
        PantherReferenceApi,

        /// <summary>
        ///Posta Plus.
        /// Postaplus1.
        /// </summary>
        [EnumMember(Value = "POSTAPLUS")]
        Postaplus1,

        /// <summary>
        ///BUFFALO.
        /// Buffalo.
        /// </summary>
        [EnumMember(Value = "BUFFALO")]
        Buffalo,

        /// <summary>
        ///U-ENVIOS.
        /// UEnvios.
        /// </summary>
        [EnumMember(Value = "U_ENVIOS")]
        UEnvios,

        /// <summary>
        ///Elite Express.
        /// EliteCo.
        /// </summary>
        [EnumMember(Value = "ELITE_CO")]
        EliteCo,

        /// <summary>
        ///Roche Internal Courier.
        /// RocheInternalSftp.
        /// </summary>
        [EnumMember(Value = "ROCHE_INTERNAL_SFTP")]
        RocheInternalSftp,

        /// <summary>
        ///DB Schenker Iceland.
        /// DbschenkerIceland.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_ICELAND")]
        DbschenkerIceland,

        /// <summary>
        ///TNT France Reference.
        /// TntFrReference.
        /// </summary>
        [EnumMember(Value = "TNT_FR_REFERENCE")]
        TntFrReference,

        /// <summary>
        ///Newgistics API.
        /// Newgisticsapi.
        /// </summary>
        [EnumMember(Value = "NEWGISTICSAPI")]
        Newgisticsapi,

        /// <summary>
        ///Glovo.
        /// Glovo.
        /// </summary>
        [EnumMember(Value = "GLOVO")]
        Glovo,

        /// <summary>
        ///G.I.G.
        /// GwlogisApi.
        /// </summary>
        [EnumMember(Value = "GWLOGIS_API")]
        GwlogisApi,

        /// <summary>
        ///Spreetail.
        /// SpreetailApi.
        /// </summary>
        [EnumMember(Value = "SPREETAIL_API")]
        SpreetailApi,

        /// <summary>
        ///Moova.
        /// Moova.
        /// </summary>
        [EnumMember(Value = "MOOVA")]
        Moova,

        /// <summary>
        ///Plycon Transportation Group.
        /// Plycongroup.
        /// </summary>
        [EnumMember(Value = "PLYCONGROUP")]
        Plycongroup,

        /// <summary>
        ///USPS Informed Visibility - Webhook.
        /// UspsWebhook.
        /// </summary>
        [EnumMember(Value = "USPS_WEBHOOK")]
        UspsWebhook,

        /// <summary>
        ///maergo.
        /// Reimaginedelivery.
        /// </summary>
        [EnumMember(Value = "REIMAGINEDELIVERY")]
        Reimaginedelivery,

        /// <summary>
        ///Eurodifarm.
        /// EdfFtp.
        /// </summary>
        [EnumMember(Value = "EDF_FTP")]
        EdfFtp,

        /// <summary>
        ///DAO365.
        /// Dao365.
        /// </summary>
        [EnumMember(Value = "DAO365")]
        Dao365,

        /// <summary>
        ///BioCair.
        /// BiocairFtp.
        /// </summary>
        [EnumMember(Value = "BIOCAIR_FTP")]
        BiocairFtp,

        /// <summary>
        ///Ransa.
        /// RansaWebhook.
        /// </summary>
        [EnumMember(Value = "RANSA_WEBHOOK")]
        RansaWebhook,

        /// <summary>
        ///SHIPXPRESS.
        /// Shipxpres.
        /// </summary>
        [EnumMember(Value = "SHIPXPRES")]
        Shipxpres,

        /// <summary>
        ///Courant Plus.
        /// CourantPlusApi.
        /// </summary>
        [EnumMember(Value = "COURANT_PLUS_API")]
        CourantPlusApi,

        /// <summary>
        ///SHIPA.
        /// Shipa.
        /// </summary>
        [EnumMember(Value = "SHIPA")]
        Shipa,

        /// <summary>
        ///Home Logistics.
        /// Homelogistics.
        /// </summary>
        [EnumMember(Value = "HOMELOGISTICS")]
        Homelogistics,

        /// <summary>
        ///DX.
        /// Dx.
        /// </summary>
        [EnumMember(Value = "DX")]
        Dx,

        /// <summary>
        ///Poste Italiane Paccocelere.
        /// PosteItalianePaccocelere.
        /// </summary>
        [EnumMember(Value = "POSTE_ITALIANE_PACCOCELERE")]
        PosteItalianePaccocelere,

        /// <summary>
        ///Toll Group.
        /// TollWebhook.
        /// </summary>
        [EnumMember(Value = "TOLL_WEBHOOK")]
        TollWebhook,

        /// <summary>
        ///LCT do Brasil.
        /// LctbrApi.
        /// </summary>
        [EnumMember(Value = "LCTBR_API")]
        LctbrApi,

        /// <summary>
        ///DX Freight.
        /// DxFreight.
        /// </summary>
        [EnumMember(Value = "DX_FREIGHT")]
        DxFreight,

        /// <summary>
        ///DHL Express.
        /// DhlSftp.
        /// </summary>
        [EnumMember(Value = "DHL_SFTP")]
        DhlSftp,

        /// <summary>
        ///Shiprocket X.
        /// Shiprocket.
        /// </summary>
        [EnumMember(Value = "SHIPROCKET")]
        Shiprocket,

        /// <summary>
        ///Uber.
        /// UberWebhook.
        /// </summary>
        [EnumMember(Value = "UBER_WEBHOOK")]
        UberWebhook,

        /// <summary>
        ///Stat Overnight.
        /// Statovernight.
        /// </summary>
        [EnumMember(Value = "STATOVERNIGHT")]
        Statovernight,

        /// <summary>
        ///Burd Delivery.
        /// Burd.
        /// </summary>
        [EnumMember(Value = "BURD")]
        Burd,

        /// <summary>
        ///Fastship Express.
        /// Fastship.
        /// </summary>
        [EnumMember(Value = "FASTSHIP")]
        Fastship,

        /// <summary>
        ///IB Venture.
        /// IbventureWebhook.
        /// </summary>
        [EnumMember(Value = "IBVENTURE_WEBHOOK")]
        IbventureWebhook,

        /// <summary>
        ///Gati-KWE.
        /// GatiKweApi.
        /// </summary>
        [EnumMember(Value = "GATI_KWE_API")]
        GatiKweApi,

        /// <summary>
        ///CryoPDP.
        /// CryopdpFtp.
        /// </summary>
        [EnumMember(Value = "CRYOPDP_FTP")]
        CryopdpFtp,

        /// <summary>
        ///HUBBED.
        /// Hubbed.
        /// </summary>
        [EnumMember(Value = "HUBBED")]
        Hubbed,

        /// <summary>
        ///Tipsa API.
        /// TipsaApi.
        /// </summary>
        [EnumMember(Value = "TIPSA_API")]
        TipsaApi,

        /// <summary>
        ///Aras Cargo.
        /// Araskargo.
        /// </summary>
        [EnumMember(Value = "ARASKARGO")]
        Araskargo,

        /// <summary>
        ///Thijs Logistiek.
        /// ThijsNl.
        /// </summary>
        [EnumMember(Value = "THIJS_NL")]
        ThijsNl,

        /// <summary>
        ///ATS Healthcare.
        /// AtshealthcareReference.
        /// </summary>
        [EnumMember(Value = "ATSHEALTHCARE_REFERENCE")]
        AtshealthcareReference,

        /// <summary>
        ///99minutos.
        /// Enum99Minutos.
        /// </summary>
        [EnumMember(Value = "99MINUTOS")]
        Enum99Minutos,

        /// <summary>
        ///Hellenic (Greece) Post.
        /// HellenicPost.
        /// </summary>
        [EnumMember(Value = "HELLENIC_POST")]
        HellenicPost,

        /// <summary>
        ///HSM Global.
        /// HsmGlobal.
        /// </summary>
        [EnumMember(Value = "HSM_GLOBAL")]
        HsmGlobal,

        /// <summary>
        ///MNX.
        /// Mnx.
        /// </summary>
        [EnumMember(Value = "MNX")]
        Mnx,

        /// <summary>
        ///N&M Transfer Co., Inc..
        /// Nmtransfer.
        /// </summary>
        [EnumMember(Value = "NMTRANSFER")]
        Nmtransfer,

        /// <summary>
        ///Logysto.
        /// Logysto.
        /// </summary>
        [EnumMember(Value = "LOGYSTO")]
        Logysto,

        /// <summary>
        ///India Post International.
        /// IndiaPostInt.
        /// </summary>
        [EnumMember(Value = "INDIA_POST_INT")]
        IndiaPostInt,

        /// <summary>
        ///Swiship IN.
        /// AmazonFbaSwishipIn.
        /// </summary>
        [EnumMember(Value = "AMAZON_FBA_SWISHIP_IN")]
        AmazonFbaSwishipIn,

        /// <summary>
        ///SRT Transport.
        /// SrtTransport.
        /// </summary>
        [EnumMember(Value = "SRT_TRANSPORT")]
        SrtTransport,

        /// <summary>
        ///Bomi Group.
        /// Bomi.
        /// </summary>
        [EnumMember(Value = "BOMI")]
        Bomi,

        /// <summary>
        ///Deliverr.
        /// DeliverrSftp.
        /// </summary>
        [EnumMember(Value = "DELIVERR_SFTP")]
        DeliverrSftp,

        /// <summary>
        ///HSDEXPRESS.
        /// Hsdexpress.
        /// </summary>
        [EnumMember(Value = "HSDEXPRESS")]
        Hsdexpress,

        /// <summary>
        ///SimpleTire.
        /// SimpletireWebhook.
        /// </summary>
        [EnumMember(Value = "SIMPLETIRE_WEBHOOK")]
        SimpletireWebhook,

        /// <summary>
        ///Hunter Express.
        /// HunterExpressSftp.
        /// </summary>
        [EnumMember(Value = "HUNTER_EXPRESS_SFTP")]
        HunterExpressSftp,

        /// <summary>
        ///UPS.
        /// UpsApi.
        /// </summary>
        [EnumMember(Value = "UPS_API")]
        UpsApi,

        /// <summary>
        ///WOO YOUNG LOGISTICS CO.,LTD..
        /// WooyoungLogisticsSftp.
        /// </summary>
        [EnumMember(Value = "WOOYOUNG_LOGISTICS_SFTP")]
        WooyoungLogisticsSftp,

        /// <summary>
        ///PHSE.
        /// PhseApi.
        /// </summary>
        [EnumMember(Value = "PHSE_API")]
        PhseApi,

        /// <summary>
        ///Wish.
        /// WishEmailPush.
        /// </summary>
        [EnumMember(Value = "WISH_EMAIL_PUSH")]
        WishEmailPush,

        /// <summary>
        ///Northline.
        /// Northline.
        /// </summary>
        [EnumMember(Value = "NORTHLINE")]
        Northline,

        /// <summary>
        ///Med Africa Logistics.
        /// Medafrica.
        /// </summary>
        [EnumMember(Value = "MEDAFRICA")]
        Medafrica,

        /// <summary>
        ///DPD Austria.
        /// DpdAtSftp.
        /// </summary>
        [EnumMember(Value = "DPD_AT_SFTP")]
        DpdAtSftp,

        /// <summary>
        ///Anteraja.
        /// Anteraja.
        /// </summary>
        [EnumMember(Value = "ANTERAJA")]
        Anteraja,

        /// <summary>
        ///DHL Global Forwarding API.
        /// DhlGlobalForwardingApi.
        /// </summary>
        [EnumMember(Value = "DHL_GLOBAL_FORWARDING_API")]
        DhlGlobalForwardingApi,

        /// <summary>
        ///LBC EXPRESS INC..
        /// LbcexpressApi.
        /// </summary>
        [EnumMember(Value = "LBCEXPRESS_API")]
        LbcexpressApi,

        /// <summary>
        ///Sims Global.
        /// Simsglobal.
        /// </summary>
        [EnumMember(Value = "SIMSGLOBAL")]
        Simsglobal,

        /// <summary>
        ///CDL Last Mile.
        /// Cdldelivers.
        /// </summary>
        [EnumMember(Value = "CDLDELIVERS")]
        Cdldelivers,

        /// <summary>
        ///TYP.
        /// Typ.
        /// </summary>
        [EnumMember(Value = "TYP")]
        Typ,

        /// <summary>
        ///Testing Courier.
        /// TestingCourierWebhook.
        /// </summary>
        [EnumMember(Value = "TESTING_COURIER_WEBHOOK")]
        TestingCourierWebhook,

        /// <summary>
        ///Pandago.
        /// PandagoApi.
        /// </summary>
        [EnumMember(Value = "PANDAGO_API")]
        PandagoApi,

        /// <summary>
        ///Royal Mail.
        /// RoyalMailFtp.
        /// </summary>
        [EnumMember(Value = "ROYAL_MAIL_FTP")]
        RoyalMailFtp,

        /// <summary>
        ///Thunder Express Australia.
        /// Thunderexpress.
        /// </summary>
        [EnumMember(Value = "THUNDEREXPRESS")]
        Thunderexpress,

        /// <summary>
        ///Secretlab.
        /// SecretlabWebhook.
        /// </summary>
        [EnumMember(Value = "SECRETLAB_WEBHOOK")]
        SecretlabWebhook,

        /// <summary>
        ///Setel Express.
        /// Setel.
        /// </summary>
        [EnumMember(Value = "SETEL")]
        Setel,

        /// <summary>
        ///JD Worldwide.
        /// JdWorldwide.
        /// </summary>
        [EnumMember(Value = "JD_WORLDWIDE")]
        JdWorldwide,

        /// <summary>
        ///DPD Russia.
        /// DpdRuApi.
        /// </summary>
        [EnumMember(Value = "DPD_RU_API")]
        DpdRuApi,

        /// <summary>
        ///Argents Express Group.
        /// ArgentsWebhook.
        /// </summary>
        [EnumMember(Value = "ARGENTS_WEBHOOK")]
        ArgentsWebhook,

        /// <summary>
        ///Post ONE.
        /// Postone.
        /// </summary>
        [EnumMember(Value = "POSTONE")]
        Postone,

        /// <summary>
        ///Tusk Logistics.
        /// Tusklogistics.
        /// </summary>
        [EnumMember(Value = "TUSKLOGISTICS")]
        Tusklogistics,

        /// <summary>
        ///Rhenus Logistics UK.
        /// RhenusUkApi.
        /// </summary>
        [EnumMember(Value = "RHENUS_UK_API")]
        RhenusUkApi,

        /// <summary>
        ///Yamato Singapore.
        /// TaqbinSgApi.
        /// </summary>
        [EnumMember(Value = "TAQBIN_SG_API")]
        TaqbinSgApi,

        /// <summary>
        ///Inntralog GmbH.
        /// InntralogSftp.
        /// </summary>
        [EnumMember(Value = "INNTRALOG_SFTP")]
        InntralogSftp,

        /// <summary>
        ///Day & Ross.
        /// Dayross.
        /// </summary>
        [EnumMember(Value = "DAYROSS")]
        Dayross,

        /// <summary>
        ///Correos Express (API).
        /// CorreosexpressApi.
        /// </summary>
        [EnumMember(Value = "CORREOSEXPRESS_API")]
        CorreosexpressApi,

        /// <summary>
        ///International Seur API.
        /// InternationalSeurApi.
        /// </summary>
        [EnumMember(Value = "INTERNATIONAL_SEUR_API")]
        InternationalSeurApi,

        /// <summary>
        ///Yodel API.
        /// YodelApi.
        /// </summary>
        [EnumMember(Value = "YODEL_API")]
        YodelApi,

        /// <summary>
        ///Hero Express.
        /// Heroexpress.
        /// </summary>
        [EnumMember(Value = "HEROEXPRESS")]
        Heroexpress,

        /// <summary>
        ///DHL supply chain India.
        /// DhlSupplychainIn.
        /// </summary>
        [EnumMember(Value = "DHL_SUPPLYCHAIN_IN")]
        DhlSupplychainIn,

        /// <summary>
        ///Urgent Cargus.
        /// UrgentCargus.
        /// </summary>
        [EnumMember(Value = "URGENT_CARGUS")]
        UrgentCargus,

        /// <summary>
        ///FRONTdoor Collective.
        /// Frontdoorcorp.
        /// </summary>
        [EnumMember(Value = "FRONTDOORCORP")]
        Frontdoorcorp,

        /// <summary>
        ///J&T Express Philippines.
        /// JtexpressPh.
        /// </summary>
        [EnumMember(Value = "JTEXPRESS_PH")]
        JtexpressPh,

        /// <summary>
        ///Parcelstars.
        /// ParcelstarsWebhook.
        /// </summary>
        [EnumMember(Value = "PARCELSTARS_WEBHOOK")]
        ParcelstarsWebhook,

        /// <summary>
        ///DPD Slovakia.
        /// DpdSkSftp.
        /// </summary>
        [EnumMember(Value = "DPD_SK_SFTP")]
        DpdSkSftp,

        /// <summary>
        ///Movianto.
        /// Movianto.
        /// </summary>
        [EnumMember(Value = "MOVIANTO")]
        Movianto,

        /// <summary>
        ///Ozeparts Shipping.
        /// OzepartsShipping.
        /// </summary>
        [EnumMember(Value = "OZEPARTS_SHIPPING")]
        OzepartsShipping,

        /// <summary>
        ///KargomKolay (CargoMini).
        /// Kargomkolay.
        /// </summary>
        [EnumMember(Value = "KARGOMKOLAY")]
        Kargomkolay,

        /// <summary>
        ///Trunkrs.
        /// Trunkrs.
        /// </summary>
        [EnumMember(Value = "TRUNKRS")]
        Trunkrs,

        /// <summary>
        ///Omni Returns.
        /// OmnirpsWebhook.
        /// </summary>
        [EnumMember(Value = "OMNIRPS_WEBHOOK")]
        OmnirpsWebhook,

        /// <summary>
        ///Chile Express.
        /// Chilexpress.
        /// </summary>
        [EnumMember(Value = "CHILEXPRESS")]
        Chilexpress,

        /// <summary>
        ///Testing Courier.
        /// TestingCourier.
        /// </summary>
        [EnumMember(Value = "TESTING_COURIER")]
        TestingCourier,

        /// <summary>
        ///JNE (API).
        /// JneApi.
        /// </summary>
        [EnumMember(Value = "JNE_API")]
        JneApi,

        /// <summary>
        ///BJS Distribution, Storage & Couriers - FTP.
        /// BjshomedeliveryFtp.
        /// </summary>
        [EnumMember(Value = "BJSHOMEDELIVERY_FTP")]
        BjshomedeliveryFtp,

        /// <summary>
        ///D Express.
        /// DexpressWebhook.
        /// </summary>
        [EnumMember(Value = "DEXPRESS_WEBHOOK")]
        DexpressWebhook,

        /// <summary>
        ///USPS API.
        /// UspsApi.
        /// </summary>
        [EnumMember(Value = "USPS_API")]
        UspsApi,

        /// <summary>
        ///TransVirtual.
        /// Transvirtual.
        /// </summary>
        [EnumMember(Value = "TRANSVIRTUAL")]
        Transvirtual,

        /// <summary>
        ///solistica.
        /// SolisticaApi.
        /// </summary>
        [EnumMember(Value = "SOLISTICA_API")]
        SolisticaApi,

        /// <summary>
        ///Chienventure.
        /// ChienventureWebhook.
        /// </summary>
        [EnumMember(Value = "CHIENVENTURE_WEBHOOK")]
        ChienventureWebhook,

        /// <summary>
        ///DPD UK.
        /// DpdUkSftp.
        /// </summary>
        [EnumMember(Value = "DPD_UK_SFTP")]
        DpdUkSftp,

        /// <summary>
        ///InPost.
        /// InpostUk.
        /// </summary>
        [EnumMember(Value = "INPOST_UK")]
        InpostUk,

        /// <summary>
        ///Javit.
        /// Javit.
        /// </summary>
        [EnumMember(Value = "JAVIT")]
        Javit,

        /// <summary>
        ///ZTO Express China.
        /// ZtoDomestic.
        /// </summary>
        [EnumMember(Value = "ZTO_DOMESTIC")]
        ZtoDomestic,

        /// <summary>
        ///DHL Global Forwarding Guatemala.
        /// DhlGtApi.
        /// </summary>
        [EnumMember(Value = "DHL_GT_API")]
        DhlGtApi,

        /// <summary>
        ///CEVA Package.
        /// CevaTracking.
        /// </summary>
        [EnumMember(Value = "CEVA_TRACKING")]
        CevaTracking,

        /// <summary>
        ///Komon Express.
        /// KomonExpress.
        /// </summary>
        [EnumMember(Value = "KOMON_EXPRESS")]
        KomonExpress,

        /// <summary>
        ///East West Courier Pte Ltd.
        /// EastwestcourierFtp.
        /// </summary>
        [EnumMember(Value = "EASTWESTCOURIER_FTP")]
        EastwestcourierFtp,

        /// <summary>
        ///Danniao.
        /// Danniao.
        /// </summary>
        [EnumMember(Value = "DANNIAO")]
        Danniao,

        /// <summary>
        ///Spectran.
        /// Spectran.
        /// </summary>
        [EnumMember(Value = "SPECTRAN")]
        Spectran,

        /// <summary>
        ///Deliver-iT.
        /// DeliverIt.
        /// </summary>
        [EnumMember(Value = "DELIVER_IT")]
        DeliverIt,

        /// <summary>
        ///Relais Colis.
        /// Relaiscolis.
        /// </summary>
        [EnumMember(Value = "RELAISCOLIS")]
        Relaiscolis,

        /// <summary>
        ///GLS Spain.
        /// GlsSpainApi.
        /// </summary>
        [EnumMember(Value = "GLS_SPAIN_API")]
        GlsSpainApi,

        /// <summary>
        ///PostPlus.
        /// Postplus.
        /// </summary>
        [EnumMember(Value = "POSTPLUS")]
        Postplus,

        /// <summary>
        ///Airterra.
        /// Airterra.
        /// </summary>
        [EnumMember(Value = "AIRTERRA")]
        Airterra,

        /// <summary>
        ///GIO Express Ecourier.
        /// GioEcourierApi.
        /// </summary>
        [EnumMember(Value = "GIO_ECOURIER_API")]
        GioEcourierApi,

        /// <summary>
        ///DPD Switzerland.
        /// DpdChSftp.
        /// </summary>
        [EnumMember(Value = "DPD_CH_SFTP")]
        DpdChSftp,

        /// <summary>
        ///FedEx®.
        /// FedexApi.
        /// </summary>
        [EnumMember(Value = "FEDEX_API")]
        FedexApi,

        /// <summary>
        ///INTERSMARTTRANS & SOLUTIONS SL.
        /// Intersmarttrans.
        /// </summary>
        [EnumMember(Value = "INTERSMARTTRANS")]
        Intersmarttrans,

        /// <summary>
        ///Hermes UK.
        /// HermesUkSftp.
        /// </summary>
        [EnumMember(Value = "HERMES_UK_SFTP")]
        HermesUkSftp,

        /// <summary>
        ///Exelot Ltd..
        /// ExelotFtp.
        /// </summary>
        [EnumMember(Value = "EXELOT_FTP")]
        ExelotFtp,

        /// <summary>
        ///DHL GLOBAL FORWARDING PANAMÁ.
        /// DhlPaApi.
        /// </summary>
        [EnumMember(Value = "DHL_PA_API")]
        DhlPaApi,

        /// <summary>
        ///Vir Transport.
        /// VirtransportSftp.
        /// </summary>
        [EnumMember(Value = "VIRTRANSPORT_SFTP")]
        VirtransportSftp,

        /// <summary>
        ///Worldnet Logistics.
        /// Worldnet.
        /// </summary>
        [EnumMember(Value = "WORLDNET")]
        Worldnet,

        /// <summary>
        ///Instabox.
        /// InstaboxWebhook.
        /// </summary>
        [EnumMember(Value = "INSTABOX_WEBHOOK")]
        InstaboxWebhook,

        /// <summary>
        ///Keuhne + Nagel Global.
        /// Kng.
        /// </summary>
        [EnumMember(Value = "KNG")]
        Kng,

        /// <summary>
        ///Flash Express.
        /// FlashexpressWebhook.
        /// </summary>
        [EnumMember(Value = "FLASHEXPRESS_WEBHOOK")]
        FlashexpressWebhook,

        /// <summary>
        ///Magyar Posta.
        /// MagyarPostaApi.
        /// </summary>
        [EnumMember(Value = "MAGYAR_POSTA_API")]
        MagyarPostaApi,

        /// <summary>
        ///WeShip.
        /// WeshipApi.
        /// </summary>
        [EnumMember(Value = "WESHIP_API")]
        WeshipApi,

        /// <summary>
        ///Ohi.
        /// OhiWebhook.
        /// </summary>
        [EnumMember(Value = "OHI_WEBHOOK")]
        OhiWebhook,

        /// <summary>
        ///MUDITA.
        /// Mudita.
        /// </summary>
        [EnumMember(Value = "MUDITA")]
        Mudita,

        /// <summary>
        ///Bluedart.
        /// BluedartApi.
        /// </summary>
        [EnumMember(Value = "BLUEDART_API")]
        BluedartApi,

        /// <summary>
        ///T-cat.
        /// TCatApi.
        /// </summary>
        [EnumMember(Value = "T_CAT_API")]
        TCatApi,

        /// <summary>
        ///ADS Express.
        /// Ads.
        /// </summary>
        [EnumMember(Value = "ADS")]
        Ads,

        /// <summary>
        ///HR Parcel.
        /// HermesIt.
        /// </summary>
        [EnumMember(Value = "HERMES_IT")]
        HermesIt,

        /// <summary>
        ///FitzMark.
        /// FitzmarkApi.
        /// </summary>
        [EnumMember(Value = "FITZMARK_API")]
        FitzmarkApi,

        /// <summary>
        ///Posti API.
        /// PostiApi.
        /// </summary>
        [EnumMember(Value = "POSTI_API")]
        PostiApi,

        /// <summary>
        ///SMSA Express.
        /// SmsaExpressWebhook.
        /// </summary>
        [EnumMember(Value = "SMSA_EXPRESS_WEBHOOK")]
        SmsaExpressWebhook,

        /// <summary>
        ///Tamer Logistics.
        /// TamergroupWebhook.
        /// </summary>
        [EnumMember(Value = "TAMERGROUP_WEBHOOK")]
        TamergroupWebhook,

        /// <summary>
        ///Livrapide.
        /// Livrapide.
        /// </summary>
        [EnumMember(Value = "LIVRAPIDE")]
        Livrapide,

        /// <summary>
        ///Nippon Express.
        /// NipponExpress.
        /// </summary>
        [EnumMember(Value = "NIPPON_EXPRESS")]
        NipponExpress,

        /// <summary>
        ///Better Trucks.
        /// Bettertrucks.
        /// </summary>
        [EnumMember(Value = "BETTERTRUCKS")]
        Bettertrucks,

        /// <summary>
        ///FAN COURIER EXPRESS.
        /// Fan.
        /// </summary>
        [EnumMember(Value = "FAN")]
        Fan,

        /// <summary>
        ///USPS Flats (Pitney Bowes).
        /// PbUspsflatsFtp.
        /// </summary>
        [EnumMember(Value = "PB_USPSFLATS_FTP")]
        PbUspsflatsFtp,

        /// <summary>
        ///Parcel Right.
        /// Parcelright.
        /// </summary>
        [EnumMember(Value = "PARCELRIGHT")]
        Parcelright,

        /// <summary>
        ///iThink Logistics.
        /// Ithinklogistics.
        /// </summary>
        [EnumMember(Value = "ITHINKLOGISTICS")]
        Ithinklogistics,

        /// <summary>
        ///Kerry Logistics.
        /// KerryExpressThWebhook.
        /// </summary>
        [EnumMember(Value = "KERRY_EXPRESS_TH_WEBHOOK")]
        KerryExpressThWebhook,

        /// <summary>
        ///eCoutier.
        /// Ecoutier.
        /// </summary>
        [EnumMember(Value = "ECOUTIER")]
        Ecoutier,

        /// <summary>
        ///SENHONG INTERNATIONAL LOGISTICS.
        /// Showl.
        /// </summary>
        [EnumMember(Value = "SHOWL")]
        Showl,

        /// <summary>
        ///BRT Bartolini API.
        /// BrtItApi.
        /// </summary>
        [EnumMember(Value = "BRT_IT_API")]
        BrtItApi,

        /// <summary>
        ///Rixon Logistics.
        /// RixonhkApi.
        /// </summary>
        [EnumMember(Value = "RIXONHK_API")]
        RixonhkApi,

        /// <summary>
        ///DB Schenker.
        /// DbschenkerApi.
        /// </summary>
        [EnumMember(Value = "DBSCHENKER_API")]
        DbschenkerApi,

        /// <summary>
        ///Ilyang logistics.
        /// Ilyanglogis.
        /// </summary>
        [EnumMember(Value = "ILYANGLOGIS")]
        Ilyanglogis,

        /// <summary>
        ///Mail Boxes Etc..
        /// MailBoxEtc.
        /// </summary>
        [EnumMember(Value = "MAIL_BOX_ETC")]
        MailBoxEtc,

        /// <summary>
        ///WeShip.
        /// Weship.
        /// </summary>
        [EnumMember(Value = "WESHIP")]
        Weship,

        /// <summary>
        ///DHL eCommerce Solutions.
        /// DhlGlobalMailApi.
        /// </summary>
        [EnumMember(Value = "DHL_GLOBAL_MAIL_API")]
        DhlGlobalMailApi,

        /// <summary>
        ///Activos24.
        /// Activos24Api.
        /// </summary>
        [EnumMember(Value = "ACTIVOS24_API")]
        Activos24Api,

        /// <summary>
        ///ATS Healthcare.
        /// Atshealthcare.
        /// </summary>
        [EnumMember(Value = "ATSHEALTHCARE")]
        Atshealthcare,

        /// <summary>
        ///Luwjistik.
        /// Luwjistik.
        /// </summary>
        [EnumMember(Value = "LUWJISTIK")]
        Luwjistik,

        /// <summary>
        ///Gebrüder Weiss.
        /// GwWorld.
        /// </summary>
        [EnumMember(Value = "GW_WORLD")]
        GwWorld,

        /// <summary>
        ///fairsenden.
        /// FairsendenApi.
        /// </summary>
        [EnumMember(Value = "FAIRSENDEN_API")]
        FairsendenApi,

        /// <summary>
        ///SerVIP.
        /// ServipWebhook.
        /// </summary>
        [EnumMember(Value = "SERVIP_WEBHOOK")]
        ServipWebhook,

        /// <summary>
        ///Swiship.
        /// Swiship.
        /// </summary>
        [EnumMember(Value = "SWISHIP")]
        Swiship,

        /// <summary>
        ///Transport Ambientales.
        /// Tanet.
        /// </summary>
        [EnumMember(Value = "TANET")]
        Tanet,

        /// <summary>
        ///SHENZHEN HOTSIN CARGO INT'L FORWARDING CO.,LTD.
        /// HotsinCargo.
        /// </summary>
        [EnumMember(Value = "HOTSIN_CARGO")]
        HotsinCargo,

        /// <summary>
        ///Direx.
        /// Direx.
        /// </summary>
        [EnumMember(Value = "DIREX")]
        Direx,

        /// <summary>
        ///HuanTong.
        /// Huantong.
        /// </summary>
        [EnumMember(Value = "HUANTONG")]
        Huantong,

        /// <summary>
        ///iMile.
        /// ImileApi.
        /// </summary>
        [EnumMember(Value = "IMILE_API")]
        ImileApi,

        /// <summary>
        ///Au Express.
        /// Auexpress.
        /// </summary>
        [EnumMember(Value = "AUEXPRESS")]
        Auexpress,

        /// <summary>
        ///NYT SUPPLY CHAIN LOGISTICS Co.,LTD.
        /// Nytlogistics.
        /// </summary>
        [EnumMember(Value = "NYTLOGISTICS")]
        Nytlogistics,

        /// <summary>
        ///DSV Futurewave.
        /// DsvReference.
        /// </summary>
        [EnumMember(Value = "DSV_REFERENCE")]
        DsvReference,

        /// <summary>
        ///Novofarma.
        /// NovofarmaWebhook.
        /// </summary>
        [EnumMember(Value = "NOVOFARMA_WEBHOOK")]
        NovofarmaWebhook,

        /// <summary>
        ///AIT.
        /// AitworldwideSftp.
        /// </summary>
        [EnumMember(Value = "AITWORLDWIDE_SFTP")]
        AitworldwideSftp,

        /// <summary>
        ///Olive.
        /// Shopolive.
        /// </summary>
        [EnumMember(Value = "SHOPOLIVE")]
        Shopolive,

        /// <summary>
        ///Fast & Furious.
        /// FnfZa.
        /// </summary>
        [EnumMember(Value = "FNF_ZA")]
        FnfZa,

        /// <summary>
        ///DHL eCommerce Greater China.
        /// DhlEcommerceGc.
        /// </summary>
        [EnumMember(Value = "DHL_ECOMMERCE_GC")]
        DhlEcommerceGc,

        /// <summary>
        ///Fetchr.
        /// Fetchr.
        /// </summary>
        [EnumMember(Value = "FETCHR")]
        Fetchr,

        /// <summary>
        ///Starlinks Global.
        /// StarlinksApi.
        /// </summary>
        [EnumMember(Value = "STARLINKS_API")]
        StarlinksApi,

        /// <summary>
        ///YYEXPRESS.
        /// Yyexpress.
        /// </summary>
        [EnumMember(Value = "YYEXPRESS")]
        Yyexpress,

        /// <summary>
        ///Servientrega.
        /// Servientrega.
        /// </summary>
        [EnumMember(Value = "SERVIENTREGA")]
        Servientrega,

        /// <summary>
        ///HanJin.
        /// Hanjin.
        /// </summary>
        [EnumMember(Value = "HANJIN")]
        Hanjin,

        /// <summary>
        ///Spanish Seur.
        /// SpanishSeurFtp.
        /// </summary>
        [EnumMember(Value = "SPANISH_SEUR_FTP")]
        SpanishSeurFtp,

        /// <summary>
        ///DX (B2B).
        /// DxB2BConnum.
        /// </summary>
        [EnumMember(Value = "DX_B2B_CONNUM")]
        DxB2BConnum,

        /// <summary>
        ///Helthjem.
        /// HelthjemApi.
        /// </summary>
        [EnumMember(Value = "HELTHJEM_API")]
        HelthjemApi,

        /// <summary>
        ///Inexpost.
        /// Inexpost.
        /// </summary>
        [EnumMember(Value = "INEXPOST")]
        Inexpost,

        /// <summary>
        ///A2B Express Logistics.
        /// A2BBa.
        /// </summary>
        [EnumMember(Value = "A2B_BA")]
        A2BBa,

        /// <summary>
        ///Rhenus Logistics.
        /// RhenusGroup.
        /// </summary>
        [EnumMember(Value = "RHENUS_GROUP")]
        RhenusGroup,

        /// <summary>
        ///Sber Logistics.
        /// SberlogisticsRu.
        /// </summary>
        [EnumMember(Value = "SBERLOGISTICS_RU")]
        SberlogisticsRu,

        /// <summary>
        ///Malca-Amit.
        /// MalcaAmit.
        /// </summary>
        [EnumMember(Value = "MALCA_AMIT")]
        MalcaAmit,

        /// <summary>
        ///Professional Parcel Logistics.
        /// Ppl.
        /// </summary>
        [EnumMember(Value = "PPL")]
        Ppl,

        /// <summary>
        ///OSM Worldwide.
        /// OsmWorldwideSftp.
        /// </summary>
        [EnumMember(Value = "OSM_WORLDWIDE_SFTP")]
        OsmWorldwideSftp,

        /// <summary>
        ///ACI Logistix.
        /// Acilogistix.
        /// </summary>
        [EnumMember(Value = "ACILOGISTIX")]
        Acilogistix,

        /// <summary>
        ///Optima Courier.
        /// Optimacourier.
        /// </summary>
        [EnumMember(Value = "OPTIMACOURIER")]
        Optimacourier,

        /// <summary>
        ///Nova Poshta API.
        /// NovaPoshtaApi.
        /// </summary>
        [EnumMember(Value = "NOVA_POSHTA_API")]
        NovaPoshtaApi,

        /// <summary>
        ///Loggi.
        /// Loggi.
        /// </summary>
        [EnumMember(Value = "LOGGI")]
        Loggi,

        /// <summary>
        ///YiFan Express.
        /// Yifan.
        /// </summary>
        [EnumMember(Value = "YIFAN")]
        Yifan,

        /// <summary>
        ///My DynaLogic.
        /// Mydynalogic.
        /// </summary>
        [EnumMember(Value = "MYDYNALOGIC")]
        Mydynalogic,

        /// <summary>
        ///Morning Global.
        /// Morninglobal.
        /// </summary>
        [EnumMember(Value = "MORNINGLOBAL")]
        Morninglobal,

        /// <summary>
        ///Concise.
        /// ConciseApi.
        /// </summary>
        [EnumMember(Value = "CONCISE_API")]
        ConciseApi,

        /// <summary>
        ///Falcon Express.
        /// Fxtran.
        /// </summary>
        [EnumMember(Value = "FXTRAN")]
        Fxtran,

        /// <summary>
        ///Deliver Your Parcel.
        /// DeliveryourparcelZa.
        /// </summary>
        [EnumMember(Value = "DELIVERYOURPARCEL_ZA")]
        DeliveryourparcelZa,

        /// <summary>
        ///uParcel.
        /// Uparcel.
        /// </summary>
        [EnumMember(Value = "UPARCEL")]
        Uparcel,

        /// <summary>
        ///Mobi Logistica.
        /// MobiBr.
        /// </summary>
        [EnumMember(Value = "MOBI_BR")]
        MobiBr,

        /// <summary>
        ///T&W Delivery.
        /// LoginextWebhook.
        /// </summary>
        [EnumMember(Value = "LOGINEXT_WEBHOOK")]
        LoginextWebhook,

        /// <summary>
        ///EMS.
        /// Ems.
        /// </summary>
        [EnumMember(Value = "EMS")]
        Ems,

        /// <summary>
        ///Speedy.
        /// Speedy.
        /// </summary>
        [EnumMember(Value = "SPEEDY")]
        Speedy,

        /// <summary>
        ///Zoom.
        /// ZoomRed.
        /// </summary>
        [EnumMember(Value = "ZOOM_RED")]
        ZoomRed,

        /// <summary>
        ///Navlungo.
        /// Navlungo.
        /// </summary>
        [EnumMember(Value = "NAVLUNGO")]
        Navlungo,

        /// <summary>
        ///Castle Parcels.
        /// Castleparcels.
        /// </summary>
        [EnumMember(Value = "CASTLEPARCELS")]
        Castleparcels,

        /// <summary>
        ///Weee.
        /// Weee.
        /// </summary>
        [EnumMember(Value = "WEEE")]
        Weee,

        /// <summary>
        ///Packaly.
        /// Packaly.
        /// </summary>
        [EnumMember(Value = "PACKALY")]
        Packaly,

        /// <summary>
        ///Yunhuipost.
        /// Yunhuipost.
        /// </summary>
        [EnumMember(Value = "YUNHUIPOST")]
        Yunhuipost,

        /// <summary>
        ///YouParcel.
        /// Youparcel.
        /// </summary>
        [EnumMember(Value = "YOUPARCEL")]
        Youparcel,

        /// <summary>
        ///Leman.
        /// Leman.
        /// </summary>
        [EnumMember(Value = "LEMAN")]
        Leman,

        /// <summary>
        ///Moovin.
        /// Moovin.
        /// </summary>
        [EnumMember(Value = "MOOVIN")]
        Moovin,

        /// <summary>
        ///Urb-it.
        /// UrbIt.
        /// </summary>
        [EnumMember(Value = "URB_IT")]
        UrbIt,

        /// <summary>
        ///Multientrega.
        /// Multientregapanama.
        /// </summary>
        [EnumMember(Value = "MULTIENTREGAPANAMA")]
        Multientregapanama,

        /// <summary>
        ///Jusdasr.
        /// Jusdasr.
        /// </summary>
        [EnumMember(Value = "JUSDASR")]
        Jusdasr,

        /// <summary>
        ///Discount Post.
        /// Discountpost.
        /// </summary>
        [EnumMember(Value = "DISCOUNTPOST")]
        Discountpost,

        /// <summary>
        ///Rhenus Logistics UK.
        /// RhenusUk.
        /// </summary>
        [EnumMember(Value = "RHENUS_UK")]
        RhenusUk,

        /// <summary>
        ///Swiship JP.
        /// SwishipJp.
        /// </summary>
        [EnumMember(Value = "SWISHIP_JP")]
        SwishipJp,

        /// <summary>
        ///GLS USA.
        /// GlsUs.
        /// </summary>
        [EnumMember(Value = "GLS_US")]
        GlsUs,

        /// <summary>
        ///Southwestern Motor Transport. Inc.
        /// Smtl.
        /// </summary>
        [EnumMember(Value = "SMTL")]
        Smtl,

        /// <summary>
        ///Discount Post Emega.
        /// Emega.
        /// </summary>
        [EnumMember(Value = "EMEGA")]
        Emega,

        /// <summary>
        ///EXPRESSONE Slovenia.
        /// ExpressoneSv.
        /// </summary>
        [EnumMember(Value = "EXPRESSONE_SV")]
        ExpressoneSv,

        /// <summary>
        ///hepsiJET.
        /// Hepsijet.
        /// </summary>
        [EnumMember(Value = "HEPSIJET")]
        Hepsijet,

        /// <summary>
        ///Welivery.
        /// Welivery.
        /// </summary>
        [EnumMember(Value = "WELIVERY")]
        Welivery,

        /// <summary>
        ///Bringer Parcel Services.
        /// Bringer.
        /// </summary>
        [EnumMember(Value = "BRINGER")]
        Bringer,

        /// <summary>
        ///EasyRoutes.
        /// Easyroutes.
        /// </summary>
        [EnumMember(Value = "EASYROUTES")]
        Easyroutes,

        /// <summary>
        ///MRW.
        /// Mrw.
        /// </summary>
        [EnumMember(Value = "MRW")]
        Mrw,

        /// <summary>
        ///RPM.
        /// Rpm.
        /// </summary>
        [EnumMember(Value = "RPM")]
        Rpm,

        /// <summary>
        ///DPD Portugal.
        /// DpdPrt.
        /// </summary>
        [EnumMember(Value = "DPD_PRT")]
        DpdPrt,

        /// <summary>
        ///GLS Romania.
        /// GlsRomania.
        /// </summary>
        [EnumMember(Value = "GLS_ROMANIA")]
        GlsRomania,

        /// <summary>
        ///LM Parcel.
        /// Lmparcel.
        /// </summary>
        [EnumMember(Value = "LMPARCEL")]
        Lmparcel,

        /// <summary>
        ///GTA GSM.
        /// Gtagsm.
        /// </summary>
        [EnumMember(Value = "GTAGSM")]
        Gtagsm,

        /// <summary>
        ///DOMINO.
        /// Domino.
        /// </summary>
        [EnumMember(Value = "DOMINO")]
        Domino,

        /// <summary>
        ///eShipper.
        /// Eshipper.
        /// </summary>
        [EnumMember(Value = "ESHIPPER")]
        Eshipper,

        /// <summary>
        ///Transpak Inc..
        /// Transpak.
        /// </summary>
        [EnumMember(Value = "TRANSPAK")]
        Transpak,

        /// <summary>
        ///Xindus.
        /// Xindus.
        /// </summary>
        [EnumMember(Value = "XINDUS")]
        Xindus,

        /// <summary>
        ///Aoyue.
        /// Aoyue.
        /// </summary>
        [EnumMember(Value = "AOYUE")]
        Aoyue,

        /// <summary>
        ///Easyparcel.
        /// Easyparcel.
        /// </summary>
        [EnumMember(Value = "EASYPARCEL")]
        Easyparcel,

        /// <summary>
        ///EXPRESSONE.
        /// Expressone.
        /// </summary>
        [EnumMember(Value = "EXPRESSONE")]
        Expressone,

        /// <summary>
        ///Sendeo Kargo.
        /// SendeoKargo.
        /// </summary>
        [EnumMember(Value = "SENDEO_KARGO")]
        SendeoKargo,

        /// <summary>
        ///Speedaf Express.
        /// Speedaf.
        /// </summary>
        [EnumMember(Value = "SPEEDAF")]
        Speedaf,

        /// <summary>
        ///eTower.
        /// Etower.
        /// </summary>
        [EnumMember(Value = "ETOWER")]
        Etower,

        /// <summary>
        ///GC Express.
        /// Gcx.
        /// </summary>
        [EnumMember(Value = "GCX")]
        Gcx,

        /// <summary>
        ///Ninjavan Vietnam.
        /// NinjavanVn.
        /// </summary>
        [EnumMember(Value = "NINJAVAN_VN")]
        NinjavanVn,

        /// <summary>
        ///Allegro.
        /// Allegro.
        /// </summary>
        [EnumMember(Value = "ALLEGRO")]
        Allegro,

        /// <summary>
        ///Jumppoint.
        /// Jumppoint.
        /// </summary>
        [EnumMember(Value = "JUMPPOINT")]
        Jumppoint,

        /// <summary>
        ///ShipGlobal.
        /// ShipglobalUs.
        /// </summary>
        [EnumMember(Value = "SHIPGLOBAL_US")]
        ShipglobalUs,

        /// <summary>
        ///Kinisi Transport Pty Ltd.
        /// Kinisi.
        /// </summary>
        [EnumMember(Value = "KINISI")]
        Kinisi,

        /// <summary>
        ///Oakh Harbour Freight Lines.
        /// Oakh.
        /// </summary>
        [EnumMember(Value = "OAKH")]
        Oakh,

        /// <summary>
        ///American West.
        /// Awest.
        /// </summary>
        [EnumMember(Value = "AWEST")]
        Awest,

        /// <summary>
        ///Barsan Global Lojistik.
        /// Barsan.
        /// </summary>
        [EnumMember(Value = "BARSAN")]
        Barsan,

        /// <summary>
        ///Energo Logistic.
        /// Energologistic.
        /// </summary>
        [EnumMember(Value = "ENERGOLOGISTIC")]
        Energologistic,

        /// <summary>
        ///Madrooex.
        /// Madrooex.
        /// </summary>
        [EnumMember(Value = "MADROOEX")]
        Madrooex,

        /// <summary>
        ///GoBolt.
        /// Gobolt.
        /// </summary>
        [EnumMember(Value = "GOBOLT")]
        Gobolt,

        /// <summary>
        ///Swiss Universal Express.
        /// SwissUniversalExpress.
        /// </summary>
        [EnumMember(Value = "SWISS_UNIVERSAL_EXPRESS")]
        SwissUniversalExpress,

        /// <summary>
        ///IOR Direct Solutions.
        /// Iordirect.
        /// </summary>
        [EnumMember(Value = "IORDIRECT")]
        Iordirect,

        /// <summary>
        ///xmszm.
        /// Xmszm.
        /// </summary>
        [EnumMember(Value = "XMSZM")]
        Xmszm,

        /// <summary>
        ///GLS Hungary.
        /// GlsHun.
        /// </summary>
        [EnumMember(Value = "GLS_HUN")]
        GlsHun,

        /// <summary>
        ///Sendy Express.
        /// Sendy.
        /// </summary>
        [EnumMember(Value = "SENDY")]
        Sendy,

        /// <summary>
        ///Brauns Express.
        /// Braunsexpress.
        /// </summary>
        [EnumMember(Value = "BRAUNSEXPRESS")]
        Braunsexpress,

        /// <summary>
        ///Grand Slam Express.
        /// Grandslamexpress.
        /// </summary>
        [EnumMember(Value = "GRANDSLAMEXPRESS")]
        Grandslamexpress,

        /// <summary>
        ///XGS.
        /// Xgs.
        /// </summary>
        [EnumMember(Value = "XGS")]
        Xgs,

        /// <summary>
        ///OTS.
        /// Otschile.
        /// </summary>
        [EnumMember(Value = "OTSCHILE")]
        Otschile,

        /// <summary>
        ///Pack-Up.
        /// PackUp.
        /// </summary>
        [EnumMember(Value = "PACK_UP")]
        PackUp,

        /// <summary>
        ///Parcelstars.
        /// Parcelstars.
        /// </summary>
        [EnumMember(Value = "PARCELSTARS")]
        Parcelstars,

        /// <summary>
        ///Team Express Service LLC.
        /// Teamexpressllc.
        /// </summary>
        [EnumMember(Value = "TEAMEXPRESSLLC")]
        Teamexpressllc,

        /// <summary>
        ///Asyad Express.
        /// Asyadexpress.
        /// </summary>
        [EnumMember(Value = "ASYADEXPRESS")]
        Asyadexpress,

        /// <summary>
        ///TDN.
        /// Tdn.
        /// </summary>
        [EnumMember(Value = "TDN")]
        Tdn,

        /// <summary>
        ///Early Bird.
        /// Earlybird.
        /// </summary>
        [EnumMember(Value = "EARLYBIRD")]
        Earlybird,

        /// <summary>
        ///Cacesa.
        /// Cacesa.
        /// </summary>
        [EnumMember(Value = "CACESA")]
        Cacesa,

        /// <summary>
        ///Parceljet.
        /// Parceljet.
        /// </summary>
        [EnumMember(Value = "PARCELJET")]
        Parceljet,

        /// <summary>
        ///MNG Kargo.
        /// MngKargo.
        /// </summary>
        [EnumMember(Value = "MNG_KARGO")]
        MngKargo,

        /// <summary>
        ///Super Pac Line.
        /// Superpackline.
        /// </summary>
        [EnumMember(Value = "SUPERPACKLINE")]
        Superpackline,

        /// <summary>
        ///SpeedX.
        /// Speedx.
        /// </summary>
        [EnumMember(Value = "SPEEDX")]
        Speedx,

        /// <summary>
        ///Vesyl.
        /// Vesyl.
        /// </summary>
        [EnumMember(Value = "VESYL")]
        Vesyl,

        /// <summary>
        ///Sky King.
        /// Skyking.
        /// </summary>
        [EnumMember(Value = "SKYKING")]
        Skyking,

        /// <summary>
        ///DIR.
        /// Dirmensajeria.
        /// </summary>
        [EnumMember(Value = "DIRMENSAJERIA")]
        Dirmensajeria,

        /// <summary>
        ///Netlogix.
        /// Netlogixgroup.
        /// </summary>
        [EnumMember(Value = "NETLOGIXGROUP")]
        Netlogixgroup,

        /// <summary>
        ///ZYEX.
        /// Zyou.
        /// </summary>
        [EnumMember(Value = "ZYOU")]
        Zyou,

        /// <summary>
        ///Jawar.
        /// Jawar.
        /// </summary>
        [EnumMember(Value = "JAWAR")]
        Jawar,

        /// <summary>
        ///Associate Global Systems.
        /// Agsystems.
        /// </summary>
        [EnumMember(Value = "AGSYSTEMS")]
        Agsystems,

        /// <summary>
        ///GPS.
        /// Gps.
        /// </summary>
        [EnumMember(Value = "GPS")]
        Gps,

        /// <summary>
        ///PTT Kargo.
        /// PttKargo.
        /// </summary>
        [EnumMember(Value = "PTT_KARGO")]
        PttKargo,

        /// <summary>
        ///Maergo.
        /// Maergo.
        /// </summary>
        [EnumMember(Value = "MAERGO")]
        Maergo,

        /// <summary>
        ///AICS.
        /// Arihantcourier.
        /// </summary>
        [EnumMember(Value = "ARIHANTCOURIER")]
        Arihantcourier,

        /// <summary>
        ///VicTas Freight Express.
        /// Vtfe.
        /// </summary>
        [EnumMember(Value = "VTFE")]
        Vtfe,

        /// <summary>
        ///Yunant.
        /// Yunant.
        /// </summary>
        [EnumMember(Value = "YUNANT")]
        Yunant,

        /// <summary>
        ///Urbify.
        /// Urbify.
        /// </summary>
        [EnumMember(Value = "URBIFY")]
        Urbify,

        /// <summary>
        ///pack-man.
        /// PackMan.
        /// </summary>
        [EnumMember(Value = "PACK_MAN")]
        PackMan,

        /// <summary>
        ///LIEFERGRUN.
        /// Liefergrun.
        /// </summary>
        [EnumMember(Value = "LIEFERGRUN")]
        Liefergrun,

        /// <summary>
        ///Obibox.
        /// Obibox.
        /// </summary>
        [EnumMember(Value = "OBIBOX")]
        Obibox,

        /// <summary>
        ///Paikeda.
        /// Paikeda.
        /// </summary>
        [EnumMember(Value = "PAIKEDA")]
        Paikeda,

        /// <summary>
        ///Scotty.
        /// Scotty.
        /// </summary>
        [EnumMember(Value = "SCOTTY")]
        Scotty,

        /// <summary>
        ///Intelcom.
        /// IntelcomCa.
        /// </summary>
        [EnumMember(Value = "INTELCOM_CA")]
        IntelcomCa,

        /// <summary>
        ///swe.
        /// Swe.
        /// </summary>
        [EnumMember(Value = "SWE")]
        Swe,

        /// <summary>
        ///Asendia Global.
        /// Asendia.
        /// </summary>
        [EnumMember(Value = "ASENDIA")]
        Asendia,

        /// <summary>
        ///DPD Austria.
        /// DpdAt.
        /// </summary>
        [EnumMember(Value = "DPD_AT")]
        DpdAt,

        /// <summary>
        ///Relay.
        /// Relay.
        /// </summary>
        [EnumMember(Value = "RELAY")]
        Relay,

        /// <summary>
        ///ATA.
        /// Ata.
        /// </summary>
        [EnumMember(Value = "ATA")]
        Ata,

        /// <summary>
        ///SkyExpress Internationals.
        /// SkyexpressInternational.
        /// </summary>
        [EnumMember(Value = "SKYEXPRESS_INTERNATIONAL")]
        SkyexpressInternational,

        /// <summary>
        ///Surat Kargo.
        /// SuratKargo.
        /// </summary>
        [EnumMember(Value = "SURAT_KARGO")]
        SuratKargo,

        /// <summary>
        ///SG LINK.
        /// Sglink.
        /// </summary>
        [EnumMember(Value = "SGLINK")]
        Sglink,

        /// <summary>
        ///FleetOptics.
        /// Fleetopticsinc.
        /// </summary>
        [EnumMember(Value = "FLEETOPTICSINC")]
        Fleetopticsinc,

        /// <summary>
        ///shopline.
        /// Shopline.
        /// </summary>
        [EnumMember(Value = "SHOPLINE")]
        Shopline,

        /// <summary>
        ///PIGGYSHIP.
        /// Piggyship.
        /// </summary>
        [EnumMember(Value = "PIGGYSHIP")]
        Piggyship,

        /// <summary>
        ///LogoiX.
        /// Logoix.
        /// </summary>
        [EnumMember(Value = "LOGOIX")]
        Logoix,

        /// <summary>
        ///Kolay Gelsin.
        /// KolayGelsin.
        /// </summary>
        [EnumMember(Value = "KOLAY_GELSIN")]
        KolayGelsin,

        /// <summary>
        ///Associated Couriers.
        /// AssociatedCouriers.
        /// </summary>
        [EnumMember(Value = "ASSOCIATED_COURIERS")]
        AssociatedCouriers,

        /// <summary>
        ///ups-checker.
        /// UpsChecker.
        /// </summary>
        [EnumMember(Value = "UPS_CHECKER")]
        UpsChecker,

        /// <summary>
        ///Wineshipping.
        /// Wineshipping.
        /// </summary>
        [EnumMember(Value = "WINESHIPPING")]
        Wineshipping,

        /// <summary>
        ///Spedisci online.
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