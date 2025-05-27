// <copyright file="PaymentsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using Newtonsoft.Json.Converters;
using PaypalServerSdk.Standard;
using PaypalServerSdk.Standard.Exceptions;
using PaypalServerSdk.Standard.Http.Client;
using PaypalServerSdk.Standard.Http.Response;
using PaypalServerSdk.Standard.Utilities;
using System.Net.Http;

namespace PaypalServerSdk.Standard.Controllers
{
    /// <summary>
    /// PaymentsController.
    /// </summary>
    public class PaymentsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsController"/> class.
        /// </summary>
        internal PaymentsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Captures an authorized payment, by ID.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.CapturedPayment response from the API call.</returns>
        public ApiResponse<Models.CapturedPayment> CaptureAuthorizedPayment(
                Models.CaptureAuthorizedPaymentInput input)
            => CoreHelper.RunTask(CaptureAuthorizedPaymentAsync(input));

        /// <summary>
        /// Captures an authorized payment, by ID.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CapturedPayment response from the API call.</returns>
        public async Task<ApiResponse<Models.CapturedPayment>> CaptureAuthorizedPaymentAsync(
                Models.CaptureAuthorizedPaymentInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CapturedPayment>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/payments/authorizations/{authorization_id}/capture")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("authorization_id", input.AuthorizationId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Mock-Response", input.PaypalMockResponse))
                      .Header(_header => _header.Setup("PayPal-Request-Id", input.PaypalRequestId))
                      .Header(_header => _header.Setup("Prefer", input.Prefer))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The request failed because it is not well-formed or is syntactically incorrect or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The request failed because the caller has insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The request failed because the resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("The server has detected a conflict while processing this request.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The request failed because it is semantically incorrect or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The request failed because an internal server error occurred.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Shows details for a captured payment, by ID.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.CapturedPayment response from the API call.</returns>
        public ApiResponse<Models.CapturedPayment> GetCapturedPayment(
                Models.GetCapturedPaymentInput input)
            => CoreHelper.RunTask(GetCapturedPaymentAsync(input));

        /// <summary>
        /// Shows details for a captured payment, by ID.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CapturedPayment response from the API call.</returns>
        public async Task<ApiResponse<Models.CapturedPayment>> GetCapturedPaymentAsync(
                Models.GetCapturedPaymentInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CapturedPayment>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v2/payments/captures/{capture_id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("capture_id", input.CaptureId))
                      .Header(_header => _header.Setup("PayPal-Mock-Response", input.PaypalMockResponse))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The request failed because the caller has insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The request failed because the resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The request failed because an internal server error occurred.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Reauthorizes an authorized PayPal account payment, by ID. To ensure that funds are still available, reauthorize a payment after its initial three-day honor period expires. Within the 29-day authorization period, you can issue multiple re-authorizations after the honor period expires. If 30 days have transpired since the date of the original authorization, you must create an authorized payment instead of reauthorizing the original authorized payment. A reauthorized payment itself has a new honor period of three days. You can reauthorize an authorized payment from 4 to 29 days after the 3-day honor period. The allowed amount depends on context and geography, for example in US it is up to 115% of the original authorized amount, not to exceed an increase of $75 USD. Supports only the `amount` request parameter. Note: This request is currently not supported for Partner use cases.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.PaymentAuthorization response from the API call.</returns>
        public ApiResponse<Models.PaymentAuthorization> ReauthorizePayment(
                Models.ReauthorizePaymentInput input)
            => CoreHelper.RunTask(ReauthorizePaymentAsync(input));

        /// <summary>
        /// Reauthorizes an authorized PayPal account payment, by ID. To ensure that funds are still available, reauthorize a payment after its initial three-day honor period expires. Within the 29-day authorization period, you can issue multiple re-authorizations after the honor period expires. If 30 days have transpired since the date of the original authorization, you must create an authorized payment instead of reauthorizing the original authorized payment. A reauthorized payment itself has a new honor period of three days. You can reauthorize an authorized payment from 4 to 29 days after the 3-day honor period. The allowed amount depends on context and geography, for example in US it is up to 115% of the original authorized amount, not to exceed an increase of $75 USD. Supports only the `amount` request parameter. Note: This request is currently not supported for Partner use cases.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.PaymentAuthorization response from the API call.</returns>
        public async Task<ApiResponse<Models.PaymentAuthorization>> ReauthorizePaymentAsync(
                Models.ReauthorizePaymentInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentAuthorization>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/payments/authorizations/{authorization_id}/reauthorize")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("authorization_id", input.AuthorizationId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Request-Id", input.PaypalRequestId))
                      .Header(_header => _header.Setup("Prefer", input.Prefer))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The request failed because it is not well-formed or is syntactically incorrect or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The request failed because the resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The request failed because it either is semantically incorrect or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The request failed because an internal server error occurred.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Voids, or cancels, an authorized payment, by ID. You cannot void an authorized payment that has been fully captured.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.PaymentAuthorization response from the API call.</returns>
        public ApiResponse<Models.PaymentAuthorization> VoidPayment(
                Models.VoidPaymentInput input)
            => CoreHelper.RunTask(VoidPaymentAsync(input));

        /// <summary>
        /// Voids, or cancels, an authorized payment, by ID. You cannot void an authorized payment that has been fully captured.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.PaymentAuthorization response from the API call.</returns>
        public async Task<ApiResponse<Models.PaymentAuthorization>> VoidPaymentAsync(
                Models.VoidPaymentInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentAuthorization>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/payments/authorizations/{authorization_id}/void")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("authorization_id", input.AuthorizationId))
                      .Header(_header => _header.Setup("PayPal-Mock-Response", input.PaypalMockResponse))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))
                      .Header(_header => _header.Setup("PayPal-Request-Id", input.PaypalRequestId))
                      .Header(_header => _header.Setup("Prefer", input.Prefer))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The request failed because the caller has insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The request failed because the resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("The request failed because a previous call for the given resource is in progress.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The request failed because it either is semantically incorrect or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The request failed because an internal server error occurred.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Refunds a captured payment, by ID. For a full refund, include an empty payload in the JSON request body. For a partial refund, include an amount object in the JSON request body.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.Refund response from the API call.</returns>
        public ApiResponse<Models.Refund> RefundCapturedPayment(
                Models.RefundCapturedPaymentInput input)
            => CoreHelper.RunTask(RefundCapturedPaymentAsync(input));

        /// <summary>
        /// Refunds a captured payment, by ID. For a full refund, include an empty payload in the JSON request body. For a partial refund, include an amount object in the JSON request body.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Refund response from the API call.</returns>
        public async Task<ApiResponse<Models.Refund>> RefundCapturedPaymentAsync(
                Models.RefundCapturedPaymentInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Refund>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/payments/captures/{capture_id}/refund")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("capture_id", input.CaptureId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Mock-Response", input.PaypalMockResponse))
                      .Header(_header => _header.Setup("PayPal-Request-Id", input.PaypalRequestId))
                      .Header(_header => _header.Setup("Prefer", input.Prefer))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The request failed because it is not well-formed or is syntactically incorrect or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The request failed because the caller has insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The request failed because the resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("The request failed because a previous call for the given resource is in progress.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The request failed because it either is semantically incorrect or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The request failed because an internal server error occurred.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Shows details for an authorized payment, by ID.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.PaymentAuthorization response from the API call.</returns>
        public ApiResponse<Models.PaymentAuthorization> GetAuthorizedPayment(
                Models.GetAuthorizedPaymentInput input)
            => CoreHelper.RunTask(GetAuthorizedPaymentAsync(input));

        /// <summary>
        /// Shows details for an authorized payment, by ID.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.PaymentAuthorization response from the API call.</returns>
        public async Task<ApiResponse<Models.PaymentAuthorization>> GetAuthorizedPaymentAsync(
                Models.GetAuthorizedPaymentInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentAuthorization>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v2/payments/authorizations/{authorization_id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("authorization_id", input.AuthorizationId))
                      .Header(_header => _header.Setup("PayPal-Mock-Response", input.PaypalMockResponse))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The request failed because the resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The request failed because an internal server error occurred.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Shows details for a refund, by ID.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.Refund response from the API call.</returns>
        public ApiResponse<Models.Refund> GetRefund(
                Models.GetRefundInput input)
            => CoreHelper.RunTask(GetRefundAsync(input));

        /// <summary>
        /// Shows details for a refund, by ID.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Refund response from the API call.</returns>
        public async Task<ApiResponse<Models.Refund>> GetRefundAsync(
                Models.GetRefundInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Refund>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v2/payments/refunds/{refund_id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("refund_id", input.RefundId))
                      .Header(_header => _header.Setup("PayPal-Mock-Response", input.PaypalMockResponse))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The request failed because the caller has insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The request failed because the resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The request failed because an internal server error occurred.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}