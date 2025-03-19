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
        ///APPROVED.
        /// Response0000.
        /// </summary>
        [EnumMember(Value = "0000")]
        Response0000,

        /// <summary>
        ///CVV2_FAILURE_POSSIBLE_RETRY_WITH_CVV.
        /// Response00N7.
        /// </summary>
        [EnumMember(Value = "00N7")]
        Response00N7,

        /// <summary>
        ///REFERRAL.
        /// Response0100.
        /// </summary>
        [EnumMember(Value = "0100")]
        Response0100,

        /// <summary>
        ///ACCOUNT_NOT_FOUND.
        /// Response0390.
        /// </summary>
        [EnumMember(Value = "0390")]
        Response0390,

        /// <summary>
        ///DO_NOT_HONOR.
        /// Response0500.
        /// </summary>
        [EnumMember(Value = "0500")]
        Response0500,

        /// <summary>
        ///UNAUTHORIZED_TRANSACTION.
        /// Response0580.
        /// </summary>
        [EnumMember(Value = "0580")]
        Response0580,

        /// <summary>
        ///BAD_RESPONSE_REVERSAL_REQUIRED.
        /// Response0800.
        /// </summary>
        [EnumMember(Value = "0800")]
        Response0800,

        /// <summary>
        ///CRYPTOGRAPHIC_FAILURE.
        /// Response0880.
        /// </summary>
        [EnumMember(Value = "0880")]
        Response0880,

        /// <summary>
        ///UNACCEPTABLE_PIN.
        /// Response0890.
        /// </summary>
        [EnumMember(Value = "0890")]
        Response0890,

        /// <summary>
        ///SYSTEM_MALFUNCTION.
        /// Response0960.
        /// </summary>
        [EnumMember(Value = "0960")]
        Response0960,

        /// <summary>
        ///CANCELLED_PAYMENT.
        /// Response0R00.
        /// </summary>
        [EnumMember(Value = "0R00")]
        Response0R00,

        /// <summary>
        ///PARTIAL_AUTHORIZATION.
        /// Response1000.
        /// </summary>
        [EnumMember(Value = "1000")]
        Response1000,

        /// <summary>
        ///ISSUER_REJECTED.
        /// Response10Br.
        /// </summary>
        [EnumMember(Value = "10BR")]
        Response10Br,

        /// <summary>
        ///INVALID_DATA_FORMAT.
        /// Response1300.
        /// </summary>
        [EnumMember(Value = "1300")]
        Response1300,

        /// <summary>
        ///INVALID_AMOUNT.
        /// Response1310.
        /// </summary>
        [EnumMember(Value = "1310")]
        Response1310,

        /// <summary>
        ///INVALID_TRANSACTION_CARD_ISSUER_ACQUIRER.
        /// Response1312.
        /// </summary>
        [EnumMember(Value = "1312")]
        Response1312,

        /// <summary>
        ///INVALID_CAPTURE_DATE.
        /// Response1317.
        /// </summary>
        [EnumMember(Value = "1317")]
        Response1317,

        /// <summary>
        ///INVALID_CURRENCY_CODE.
        /// Response1320.
        /// </summary>
        [EnumMember(Value = "1320")]
        Response1320,

        /// <summary>
        ///INVALID_ACCOUNT.
        /// Response1330.
        /// </summary>
        [EnumMember(Value = "1330")]
        Response1330,

        /// <summary>
        ///INVALID_ACCOUNT_RECURRING.
        /// Response1335.
        /// </summary>
        [EnumMember(Value = "1335")]
        Response1335,

        /// <summary>
        ///INVALID_TERMINAL.
        /// Response1340.
        /// </summary>
        [EnumMember(Value = "1340")]
        Response1340,

        /// <summary>
        ///INVALID_MERCHANT.
        /// Response1350.
        /// </summary>
        [EnumMember(Value = "1350")]
        Response1350,

        /// <summary>
        ///RESTRICTED_OR_INACTIVE_ACCOUNT.
        /// Response1352.
        /// </summary>
        [EnumMember(Value = "1352")]
        Response1352,

        /// <summary>
        ///BAD_PROCESSING_CODE.
        /// Response1360.
        /// </summary>
        [EnumMember(Value = "1360")]
        Response1360,

        /// <summary>
        ///INVALID_MCC.
        /// Response1370.
        /// </summary>
        [EnumMember(Value = "1370")]
        Response1370,

        /// <summary>
        ///INVALID_EXPIRATION.
        /// Response1380.
        /// </summary>
        [EnumMember(Value = "1380")]
        Response1380,

        /// <summary>
        ///INVALID_CARD_VERIFICATION_VALUE.
        /// Response1382.
        /// </summary>
        [EnumMember(Value = "1382")]
        Response1382,

        /// <summary>
        ///INVALID_LIFE_CYCLE_OF_TRANSACTION.
        /// Response1384.
        /// </summary>
        [EnumMember(Value = "1384")]
        Response1384,

        /// <summary>
        ///INVALID_ORDER.
        /// Response1390.
        /// </summary>
        [EnumMember(Value = "1390")]
        Response1390,

        /// <summary>
        ///TRANSACTION_CANNOT_BE_COMPLETED.
        /// Response1393.
        /// </summary>
        [EnumMember(Value = "1393")]
        Response1393,

        /// <summary>
        ///GENERIC_DECLINE.
        /// Response5100.
        /// </summary>
        [EnumMember(Value = "5100")]
        Response5100,

        /// <summary>
        ///CVV2_FAILURE.
        /// Response5110.
        /// </summary>
        [EnumMember(Value = "5110")]
        Response5110,

        /// <summary>
        ///INSUFFICIENT_FUNDS.
        /// Response5120.
        /// </summary>
        [EnumMember(Value = "5120")]
        Response5120,

        /// <summary>
        ///INVALID_PIN.
        /// Response5130.
        /// </summary>
        [EnumMember(Value = "5130")]
        Response5130,

        /// <summary>
        ///DECLINED_PIN_TRY_EXCEEDED.
        /// Response5135.
        /// </summary>
        [EnumMember(Value = "5135")]
        Response5135,

        /// <summary>
        ///CARD_CLOSED.
        /// Response5140.
        /// </summary>
        [EnumMember(Value = "5140")]
        Response5140,

        /// <summary>
        ///PICKUP_CARD_SPECIAL_CONDITIONS. Try using another card. Do not retry the same card.
        /// Response5150.
        /// </summary>
        [EnumMember(Value = "5150")]
        Response5150,

        /// <summary>
        ///UNAUTHORIZED_USER.
        /// Response5160.
        /// </summary>
        [EnumMember(Value = "5160")]
        Response5160,

        /// <summary>
        ///AVS_FAILURE.
        /// Response5170.
        /// </summary>
        [EnumMember(Value = "5170")]
        Response5170,

        /// <summary>
        ///INVALID_OR_RESTRICTED_CARD. Try using another card. Do not retry the same card.
        /// Response5180.
        /// </summary>
        [EnumMember(Value = "5180")]
        Response5180,

        /// <summary>
        ///SOFT_AVS.
        /// Response5190.
        /// </summary>
        [EnumMember(Value = "5190")]
        Response5190,

        /// <summary>
        ///DUPLICATE_TRANSACTION.
        /// Response5200.
        /// </summary>
        [EnumMember(Value = "5200")]
        Response5200,

        /// <summary>
        ///INVALID_TRANSACTION.
        /// Response5210.
        /// </summary>
        [EnumMember(Value = "5210")]
        Response5210,

        /// <summary>
        ///EXPIRED_CARD.
        /// Response5400.
        /// </summary>
        [EnumMember(Value = "5400")]
        Response5400,

        /// <summary>
        ///INCORRECT_PIN_REENTER.
        /// Response5500.
        /// </summary>
        [EnumMember(Value = "5500")]
        Response5500,

        /// <summary>
        ///DECLINED_SCA_REQUIRED.
        /// Response5650.
        /// </summary>
        [EnumMember(Value = "5650")]
        Response5650,

        /// <summary>
        ///TRANSACTION_NOT_PERMITTED. Outside of scope of accepted business.
        /// Response5700.
        /// </summary>
        [EnumMember(Value = "5700")]
        Response5700,

        /// <summary>
        ///TX_ATTEMPTS_EXCEED_LIMIT.
        /// Response5710.
        /// </summary>
        [EnumMember(Value = "5710")]
        Response5710,

        /// <summary>
        ///REVERSAL_REJECTED.
        /// Response5800.
        /// </summary>
        [EnumMember(Value = "5800")]
        Response5800,

        /// <summary>
        ///INVALID_ISSUE.
        /// Response5900.
        /// </summary>
        [EnumMember(Value = "5900")]
        Response5900,

        /// <summary>
        ///ISSUER_NOT_AVAILABLE_NOT_RETRIABLE.
        /// Response5910.
        /// </summary>
        [EnumMember(Value = "5910")]
        Response5910,

        /// <summary>
        ///ISSUER_NOT_AVAILABLE_RETRIABLE.
        /// Response5920.
        /// </summary>
        [EnumMember(Value = "5920")]
        Response5920,

        /// <summary>
        ///CARD_NOT_ACTIVATED.
        /// Response5930.
        /// </summary>
        [EnumMember(Value = "5930")]
        Response5930,

        /// <summary>
        ///DECLINED_DUE_TO_UPDATED_ACCOUNT. External decline as an updated card has been issued.
        /// Response5950.
        /// </summary>
        [EnumMember(Value = "5950")]
        Response5950,

        /// <summary>
        ///ACCOUNT_NOT_ON_FILE.
        /// Response6300.
        /// </summary>
        [EnumMember(Value = "6300")]
        Response6300,

        /// <summary>
        ///APPROVED_NON_CAPTURE.
        /// Response7600.
        /// </summary>
        [EnumMember(Value = "7600")]
        Response7600,

        /// <summary>
        ///ERROR_3DS.
        /// Response7700.
        /// </summary>
        [EnumMember(Value = "7700")]
        Response7700,

        /// <summary>
        ///AUTHENTICATION_FAILED.
        /// Response7710.
        /// </summary>
        [EnumMember(Value = "7710")]
        Response7710,

        /// <summary>
        ///BIN_ERROR.
        /// Response7800.
        /// </summary>
        [EnumMember(Value = "7800")]
        Response7800,

        /// <summary>
        ///PIN_ERROR.
        /// Response7900.
        /// </summary>
        [EnumMember(Value = "7900")]
        Response7900,

        /// <summary>
        ///PROCESSOR_SYSTEM_ERROR.
        /// Response8000.
        /// </summary>
        [EnumMember(Value = "8000")]
        Response8000,

        /// <summary>
        ///HOST_KEY_ERROR.
        /// Response8010.
        /// </summary>
        [EnumMember(Value = "8010")]
        Response8010,

        /// <summary>
        ///CONFIGURATION_ERROR.
        /// Response8020.
        /// </summary>
        [EnumMember(Value = "8020")]
        Response8020,

        /// <summary>
        ///UNSUPPORTED_OPERATION.
        /// Response8030.
        /// </summary>
        [EnumMember(Value = "8030")]
        Response8030,

        /// <summary>
        ///FATAL_COMMUNICATION_ERROR.
        /// Response8100.
        /// </summary>
        [EnumMember(Value = "8100")]
        Response8100,

        /// <summary>
        ///RETRIABLE_COMMUNICATION_ERROR.
        /// Response8110.
        /// </summary>
        [EnumMember(Value = "8110")]
        Response8110,

        /// <summary>
        ///SYSTEM_UNAVAILABLE.
        /// Response8220.
        /// </summary>
        [EnumMember(Value = "8220")]
        Response8220,

        /// <summary>
        ///DECLINED_PLEASE_RETRY. Retry.
        /// Response9100.
        /// </summary>
        [EnumMember(Value = "9100")]
        Response9100,

        /// <summary>
        ///SUSPECTED_FRAUD. Try using another card. Do not retry the same card.
        /// Response9500.
        /// </summary>
        [EnumMember(Value = "9500")]
        Response9500,

        /// <summary>
        ///SECURITY_VIOLATION.
        /// Response9510.
        /// </summary>
        [EnumMember(Value = "9510")]
        Response9510,

        /// <summary>
        ///LOST_OR_STOLEN. Try using another card. Do not retry the same card.
        /// Response9520.
        /// </summary>
        [EnumMember(Value = "9520")]
        Response9520,

        /// <summary>
        ///HOLD_CALL_CENTER. The merchant must call the number on the back of the card. POS scenario.
        /// Response9530.
        /// </summary>
        [EnumMember(Value = "9530")]
        Response9530,

        /// <summary>
        ///REFUSED_CARD.
        /// Response9540.
        /// </summary>
        [EnumMember(Value = "9540")]
        Response9540,

        /// <summary>
        ///UNRECOGNIZED_RESPONSE_CODE.
        /// Response9600.
        /// </summary>
        [EnumMember(Value = "9600")]
        Response9600,

        /// <summary>
        ///CONTINGENCIES_NOT_RESOLVED.
        /// ResponsePcnr.
        /// </summary>
        [EnumMember(Value = "PCNR")]
        ResponsePcnr,

        /// <summary>
        ///CVV_FAILURE.
        /// ResponsePcvv.
        /// </summary>
        [EnumMember(Value = "PCVV")]
        ResponsePcvv,

        /// <summary>
        ///ACCOUNT_CLOSED. A previously open account is now closed
        /// ResponsePp06.
        /// </summary>
        [EnumMember(Value = "PP06")]
        ResponsePp06,

        /// <summary>
        ///REATTEMPT_NOT_PERMITTED.
        /// ResponsePprn.
        /// </summary>
        [EnumMember(Value = "PPRN")]
        ResponsePprn,

        /// <summary>
        ///BILLING_ADDRESS.
        /// ResponsePpad.
        /// </summary>
        [EnumMember(Value = "PPAD")]
        ResponsePpad,

        /// <summary>
        ///ACCOUNT_BLOCKED_BY_ISSUER.
        /// ResponsePpab.
        /// </summary>
        [EnumMember(Value = "PPAB")]
        ResponsePpab,

        /// <summary>
        ///AMEX_DISABLED.
        /// ResponsePpae.
        /// </summary>
        [EnumMember(Value = "PPAE")]
        ResponsePpae,

        /// <summary>
        ///ADULT_GAMING_UNSUPPORTED.
        /// ResponsePpag.
        /// </summary>
        [EnumMember(Value = "PPAG")]
        ResponsePpag,

        /// <summary>
        ///AMOUNT_INCOMPATIBLE.
        /// ResponsePpai.
        /// </summary>
        [EnumMember(Value = "PPAI")]
        ResponsePpai,

        /// <summary>
        ///AUTH_RESULT.
        /// ResponsePpar.
        /// </summary>
        [EnumMember(Value = "PPAR")]
        ResponsePpar,

        /// <summary>
        ///MCC_CODE.
        /// ResponsePpau.
        /// </summary>
        [EnumMember(Value = "PPAU")]
        ResponsePpau,

        /// <summary>
        ///ARC_AVS.
        /// ResponsePpav.
        /// </summary>
        [EnumMember(Value = "PPAV")]
        ResponsePpav,

        /// <summary>
        ///AMOUNT_EXCEEDED.
        /// ResponsePpax.
        /// </summary>
        [EnumMember(Value = "PPAX")]
        ResponsePpax,

        /// <summary>
        ///BAD_GAMING.
        /// ResponsePpbg.
        /// </summary>
        [EnumMember(Value = "PPBG")]
        ResponsePpbg,

        /// <summary>
        ///ARC_CVV.
        /// ResponsePpc2.
        /// </summary>
        [EnumMember(Value = "PPC2")]
        ResponsePpc2,

        /// <summary>
        ///CE_REGISTRATION_INCOMPLETE.
        /// ResponsePpce.
        /// </summary>
        [EnumMember(Value = "PPCE")]
        ResponsePpce,

        /// <summary>
        ///COUNTRY.
        /// ResponsePpco.
        /// </summary>
        [EnumMember(Value = "PPCO")]
        ResponsePpco,

        /// <summary>
        ///CREDIT_ERROR.
        /// ResponsePpcr.
        /// </summary>
        [EnumMember(Value = "PPCR")]
        ResponsePpcr,

        /// <summary>
        ///CARD_TYPE_UNSUPPORTED.
        /// ResponsePpct.
        /// </summary>
        [EnumMember(Value = "PPCT")]
        ResponsePpct,

        /// <summary>
        ///CURRENCY_USED_INVALID.
        /// ResponsePpcu.
        /// </summary>
        [EnumMember(Value = "PPCU")]
        ResponsePpcu,

        /// <summary>
        ///SECURE_ERROR_3DS.
        /// ResponsePpd3.
        /// </summary>
        [EnumMember(Value = "PPD3")]
        ResponsePpd3,

        /// <summary>
        ///DCC_UNSUPPORTED.
        /// ResponsePpdc.
        /// </summary>
        [EnumMember(Value = "PPDC")]
        ResponsePpdc,

        /// <summary>
        ///DINERS_REJECT.
        /// ResponsePpdi.
        /// </summary>
        [EnumMember(Value = "PPDI")]
        ResponsePpdi,

        /// <summary>
        ///AUTH_MESSAGE.
        /// ResponsePpdv.
        /// </summary>
        [EnumMember(Value = "PPDV")]
        ResponsePpdv,

        /// <summary>
        ///DECLINE_THRESHOLD_BREACH.
        /// ResponsePpdt.
        /// </summary>
        [EnumMember(Value = "PPDT")]
        ResponsePpdt,

        /// <summary>
        ///EXPIRED_FUNDING_INSTRUMENT.
        /// ResponsePpef.
        /// </summary>
        [EnumMember(Value = "PPEF")]
        ResponsePpef,

        /// <summary>
        ///EXCEEDS_FREQUENCY_LIMIT.
        /// ResponsePpel.
        /// </summary>
        [EnumMember(Value = "PPEL")]
        ResponsePpel,

        /// <summary>
        ///INTERNAL_SYSTEM_ERROR.
        /// ResponsePper.
        /// </summary>
        [EnumMember(Value = "PPER")]
        ResponsePper,

        /// <summary>
        ///EXPIRY_DATE.
        /// ResponsePpex.
        /// </summary>
        [EnumMember(Value = "PPEX")]
        ResponsePpex,

        /// <summary>
        ///FUNDING_SOURCE_ALREADY_EXISTS.
        /// ResponsePpfe.
        /// </summary>
        [EnumMember(Value = "PPFE")]
        ResponsePpfe,

        /// <summary>
        ///INVALID_FUNDING_INSTRUMENT.
        /// ResponsePpfi.
        /// </summary>
        [EnumMember(Value = "PPFI")]
        ResponsePpfi,

        /// <summary>
        ///RESTRICTED_FUNDING_INSTRUMENT.
        /// ResponsePpfr.
        /// </summary>
        [EnumMember(Value = "PPFR")]
        ResponsePpfr,

        /// <summary>
        ///FIELD_VALIDATION_FAILED.
        /// ResponsePpfv.
        /// </summary>
        [EnumMember(Value = "PPFV")]
        ResponsePpfv,

        /// <summary>
        ///GAMING_REFUND_ERROR.
        /// ResponsePpgr.
        /// </summary>
        [EnumMember(Value = "PPGR")]
        ResponsePpgr,

        /// <summary>
        ///H1_ERROR.
        /// ResponsePph1.
        /// </summary>
        [EnumMember(Value = "PPH1")]
        ResponsePph1,

        /// <summary>
        ///IDEMPOTENCY_FAILURE.
        /// ResponsePpif.
        /// </summary>
        [EnumMember(Value = "PPIF")]
        ResponsePpif,

        /// <summary>
        ///INVALID_INPUT_FAILURE.
        /// ResponsePpii.
        /// </summary>
        [EnumMember(Value = "PPII")]
        ResponsePpii,

        /// <summary>
        ///ID_MISMATCH.
        /// ResponsePpim.
        /// </summary>
        [EnumMember(Value = "PPIM")]
        ResponsePpim,

        /// <summary>
        ///INVALID_TRACE_ID.
        /// ResponsePpit.
        /// </summary>
        [EnumMember(Value = "PPIT")]
        ResponsePpit,

        /// <summary>
        ///LATE_REVERSAL.
        /// ResponsePplr.
        /// </summary>
        [EnumMember(Value = "PPLR")]
        ResponsePplr,

        /// <summary>
        ///LARGE_STATUS_CODE.
        /// ResponsePpls.
        /// </summary>
        [EnumMember(Value = "PPLS")]
        ResponsePpls,

        /// <summary>
        ///MISSING_BUSINESS_RULE_OR_DATA.
        /// ResponsePpmb.
        /// </summary>
        [EnumMember(Value = "PPMB")]
        ResponsePpmb,

        /// <summary>
        ///BLOCKED_Mastercard.
        /// ResponsePpmc.
        /// </summary>
        [EnumMember(Value = "PPMC")]
        ResponsePpmc,

        /// <summary>
        ///DEPRECATED The PPMD value has been deprecated.
        /// ResponsePpmd.
        /// </summary>
        [EnumMember(Value = "PPMD")]
        ResponsePpmd,

        /// <summary>
        ///NOT_SUPPORTED_NRC.
        /// ResponsePpnc.
        /// </summary>
        [EnumMember(Value = "PPNC")]
        ResponsePpnc,

        /// <summary>
        ///EXCEEDS_NETWORK_FREQUENCY_LIMIT.
        /// ResponsePpnl.
        /// </summary>
        [EnumMember(Value = "PPNL")]
        ResponsePpnl,

        /// <summary>
        ///NO_MID_FOUND.
        /// ResponsePpnm.
        /// </summary>
        [EnumMember(Value = "PPNM")]
        ResponsePpnm,

        /// <summary>
        ///NETWORK_ERROR.
        /// ResponsePpnt.
        /// </summary>
        [EnumMember(Value = "PPNT")]
        ResponsePpnt,

        /// <summary>
        ///NO_PHONE_FOR_DCC_TRANSACTION.
        /// ResponsePpph.
        /// </summary>
        [EnumMember(Value = "PPPH")]
        ResponsePpph,

        /// <summary>
        ///INVALID_PRODUCT.
        /// ResponsePppi.
        /// </summary>
        [EnumMember(Value = "PPPI")]
        ResponsePppi,

        /// <summary>
        ///INVALID_PAYMENT_METHOD.
        /// ResponsePppm.
        /// </summary>
        [EnumMember(Value = "PPPM")]
        ResponsePppm,

        /// <summary>
        ///QUASI_CASH_UNSUPPORTED.
        /// ResponsePpqc.
        /// </summary>
        [EnumMember(Value = "PPQC")]
        ResponsePpqc,

        /// <summary>
        ///UNSUPPORT_REFUND_ON_PENDING_BC.
        /// ResponsePpre.
        /// </summary>
        [EnumMember(Value = "PPRE")]
        ResponsePpre,

        /// <summary>
        ///INVALID_PARENT_TRANSACTION_STATUS.
        /// ResponsePprf.
        /// </summary>
        [EnumMember(Value = "PPRF")]
        ResponsePprf,

        /// <summary>
        ///MERCHANT_NOT_REGISTERED.
        /// ResponsePprr.
        /// </summary>
        [EnumMember(Value = "PPRR")]
        ResponsePprr,

        /// <summary>
        ///BANKAUTH_ROW_MISMATCH.
        /// ResponsePps0.
        /// </summary>
        [EnumMember(Value = "PPS0")]
        ResponsePps0,

        /// <summary>
        ///BANKAUTH_ROW_SETTLED.
        /// ResponsePps1.
        /// </summary>
        [EnumMember(Value = "PPS1")]
        ResponsePps1,

        /// <summary>
        ///BANKAUTH_ROW_VOIDED.
        /// ResponsePps2.
        /// </summary>
        [EnumMember(Value = "PPS2")]
        ResponsePps2,

        /// <summary>
        ///BANKAUTH_EXPIRED.
        /// ResponsePps3.
        /// </summary>
        [EnumMember(Value = "PPS3")]
        ResponsePps3,

        /// <summary>
        ///CURRENCY_MISMATCH.
        /// ResponsePps4.
        /// </summary>
        [EnumMember(Value = "PPS4")]
        ResponsePps4,

        /// <summary>
        ///CREDITCARD_MISMATCH.
        /// ResponsePps5.
        /// </summary>
        [EnumMember(Value = "PPS5")]
        ResponsePps5,

        /// <summary>
        ///AMOUNT_MISMATCH.
        /// ResponsePps6.
        /// </summary>
        [EnumMember(Value = "PPS6")]
        ResponsePps6,

        /// <summary>
        ///ARC_SCORE.
        /// ResponsePpsc.
        /// </summary>
        [EnumMember(Value = "PPSC")]
        ResponsePpsc,

        /// <summary>
        ///STATUS_DESCRIPTION.
        /// ResponsePpsd.
        /// </summary>
        [EnumMember(Value = "PPSD")]
        ResponsePpsd,

        /// <summary>
        ///AMEX_DENIED.
        /// ResponsePpse.
        /// </summary>
        [EnumMember(Value = "PPSE")]
        ResponsePpse,

        /// <summary>
        ///VERIFICATION_TOKEN_EXPIRED.
        /// ResponsePpte.
        /// </summary>
        [EnumMember(Value = "PPTE")]
        ResponsePpte,

        /// <summary>
        ///INVALID_TRACE_REFERENCE.
        /// ResponsePptf.
        /// </summary>
        [EnumMember(Value = "PPTF")]
        ResponsePptf,

        /// <summary>
        ///INVALID_TRANSACTION_ID.
        /// ResponsePpti.
        /// </summary>
        [EnumMember(Value = "PPTI")]
        ResponsePpti,

        /// <summary>
        ///VERIFICATION_TOKEN_REVOKED.
        /// ResponsePptr.
        /// </summary>
        [EnumMember(Value = "PPTR")]
        ResponsePptr,

        /// <summary>
        ///TRANSACTION_TYPE_UNSUPPORTED.
        /// ResponsePptt.
        /// </summary>
        [EnumMember(Value = "PPTT")]
        ResponsePptt,

        /// <summary>
        ///INVALID_VERIFICATION_TOKEN.
        /// ResponsePptv.
        /// </summary>
        [EnumMember(Value = "PPTV")]
        ResponsePptv,

        /// <summary>
        ///USER_NOT_AUTHORIZED.
        /// ResponsePpua.
        /// </summary>
        [EnumMember(Value = "PPUA")]
        ResponsePpua,

        /// <summary>
        ///CURRENCY_CODE_UNSUPPORTED.
        /// ResponsePpuc.
        /// </summary>
        [EnumMember(Value = "PPUC")]
        ResponsePpuc,

        /// <summary>
        ///UNSUPPORT_ENTITY.
        /// ResponsePpue.
        /// </summary>
        [EnumMember(Value = "PPUE")]
        ResponsePpue,

        /// <summary>
        ///UNSUPPORT_INSTALLMENT.
        /// ResponsePpui.
        /// </summary>
        [EnumMember(Value = "PPUI")]
        ResponsePpui,

        /// <summary>
        ///UNSUPPORT_POS_FLAG.
        /// ResponsePpup.
        /// </summary>
        [EnumMember(Value = "PPUP")]
        ResponsePpup,

        /// <summary>
        ///UNSUPPORTED_REVERSAL.
        /// ResponsePpur.
        /// </summary>
        [EnumMember(Value = "PPUR")]
        ResponsePpur,

        /// <summary>
        ///VALIDATE_CURRENCY.
        /// ResponsePpvc.
        /// </summary>
        [EnumMember(Value = "PPVC")]
        ResponsePpvc,

        /// <summary>
        ///VALIDATION_ERROR.
        /// ResponsePpve.
        /// </summary>
        [EnumMember(Value = "PPVE")]
        ResponsePpve,

        /// <summary>
        ///VIRTUAL_TERMINAL_UNSUPPORTED.
        /// ResponsePpvt.
        /// </summary>
        [EnumMember(Value = "PPVT")]
        ResponsePpvt,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}