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
        /// Shows details for an authorized payment, by ID.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.PaymentAuthorization response from the API call.</returns>
        public ApiResponse<Models.PaymentAuthorization> AuthorizationsGet(
                Models.AuthorizationsGetInput input)
            => CoreHelper.RunTask(AuthorizationsGetAsync(input));

        /// <summary>
        /// Shows details for an authorized payment, by ID.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.PaymentAuthorization response from the API call.</returns>
        public async Task<ApiResponse<Models.PaymentAuthorization>> AuthorizationsGetAsync(
                Models.AuthorizationsGetInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentAuthorization>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v2/payments/authorizations/{authorization_id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("authorization_id", input.AuthorizationId))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The request failed because the resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The request failed because an internal server error occurred.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Captures an authorized payment, by ID.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.CapturedPayment response from the API call.</returns>
        public ApiResponse<Models.CapturedPayment> AuthorizationsCapture(
                Models.AuthorizationsCaptureInput input)
            => CoreHelper.RunTask(AuthorizationsCaptureAsync(input));

        /// <summary>
        /// Captures an authorized payment, by ID.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CapturedPayment response from the API call.</returns>
        public async Task<ApiResponse<Models.CapturedPayment>> AuthorizationsCaptureAsync(
                Models.AuthorizationsCaptureInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CapturedPayment>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/payments/authorizations/{authorization_id}/capture")
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
                  .ErrorCase("403", CreateErrorCase("The request failed because the caller has insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The request failed because the resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("The server has detected a conflict while processing this request.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The request failed because it is semantically incorrect or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The request failed because an internal server error occurred.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Reauthorizes an authorized PayPal account payment, by ID. To ensure that funds are still available, reauthorize a payment after its initial three-day honor period expires. Within the 29-day authorization period, you can issue multiple re-authorizations after the honor period expires.<br/><br/>If 30 days have transpired since the date of the original authorization, you must create an authorized payment instead of reauthorizing the original authorized payment.<br/><br/>A reauthorized payment itself has a new honor period of three days.<br/><br/>You can reauthorize an authorized payment from 4 to 29 days after the 3-day honor period. The allowed amount depends on context and geography, for example in US it is up to 115% of the original authorized amount, not to exceed an increase of $75 USD.<br/><br/>Supports only the `amount` request parameter.<blockquote><strong>Note:</strong> This request is currently not supported for Partner use cases.</blockquote>.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.PaymentAuthorization response from the API call.</returns>
        public ApiResponse<Models.PaymentAuthorization> AuthorizationsReauthorize(
                Models.AuthorizationsReauthorizeInput input)
            => CoreHelper.RunTask(AuthorizationsReauthorizeAsync(input));

        /// <summary>
        /// Reauthorizes an authorized PayPal account payment, by ID. To ensure that funds are still available, reauthorize a payment after its initial three-day honor period expires. Within the 29-day authorization period, you can issue multiple re-authorizations after the honor period expires.<br/><br/>If 30 days have transpired since the date of the original authorization, you must create an authorized payment instead of reauthorizing the original authorized payment.<br/><br/>A reauthorized payment itself has a new honor period of three days.<br/><br/>You can reauthorize an authorized payment from 4 to 29 days after the 3-day honor period. The allowed amount depends on context and geography, for example in US it is up to 115% of the original authorized amount, not to exceed an increase of $75 USD.<br/><br/>Supports only the `amount` request parameter.<blockquote><strong>Note:</strong> This request is currently not supported for Partner use cases.</blockquote>.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.PaymentAuthorization response from the API call.</returns>
        public async Task<ApiResponse<Models.PaymentAuthorization>> AuthorizationsReauthorizeAsync(
                Models.AuthorizationsReauthorizeInput input,
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
        public ApiResponse<Models.PaymentAuthorization> AuthorizationsVoid(
                Models.AuthorizationsVoidInput input)
            => CoreHelper.RunTask(AuthorizationsVoidAsync(input));

        /// <summary>
        /// Voids, or cancels, an authorized payment, by ID. You cannot void an authorized payment that has been fully captured.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.PaymentAuthorization response from the API call.</returns>
        public async Task<ApiResponse<Models.PaymentAuthorization>> AuthorizationsVoidAsync(
                Models.AuthorizationsVoidInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentAuthorization>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/payments/authorizations/{authorization_id}/void")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("authorization_id", input.AuthorizationId))
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
        /// Shows details for a captured payment, by ID.
        /// </summary>
        /// <param name="captureId">Required parameter: The PayPal-generated ID for the captured payment for which to show details..</param>
        /// <returns>Returns the ApiResponse of Models.CapturedPayment response from the API call.</returns>
        public ApiResponse<Models.CapturedPayment> CapturesGet(
                string captureId)
            => CoreHelper.RunTask(CapturesGetAsync(captureId));

        /// <summary>
        /// Shows details for a captured payment, by ID.
        /// </summary>
        /// <param name="captureId">Required parameter: The PayPal-generated ID for the captured payment for which to show details..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CapturedPayment response from the API call.</returns>
        public async Task<ApiResponse<Models.CapturedPayment>> CapturesGetAsync(
                string captureId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CapturedPayment>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v2/payments/captures/{capture_id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("capture_id", captureId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The request failed because the caller has insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The request failed because the resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The request failed because an internal server error occurred.", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Refunds a captured payment, by ID. For a full refund, include an empty payload in the JSON request body. For a partial refund, include an <code>amount</code> object in the JSON request body.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.Refund response from the API call.</returns>
        public ApiResponse<Models.Refund> CapturesRefund(
                Models.CapturesRefundInput input)
            => CoreHelper.RunTask(CapturesRefundAsync(input));

        /// <summary>
        /// Refunds a captured payment, by ID. For a full refund, include an empty payload in the JSON request body. For a partial refund, include an <code>amount</code> object in the JSON request body.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Refund response from the API call.</returns>
        public async Task<ApiResponse<Models.Refund>> CapturesRefundAsync(
                Models.CapturesRefundInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Refund>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/payments/captures/{capture_id}/refund")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("capture_id", input.CaptureId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
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
        /// Shows details for a refund, by ID.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.Refund response from the API call.</returns>
        public ApiResponse<Models.Refund> RefundsGet(
                Models.RefundsGetInput input)
            => CoreHelper.RunTask(RefundsGetAsync(input));

        /// <summary>
        /// Shows details for a refund, by ID.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Refund response from the API call.</returns>
        public async Task<ApiResponse<Models.Refund>> RefundsGetAsync(
                Models.RefundsGetInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Refund>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v2/payments/refunds/{refund_id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("refund_id", input.RefundId))
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