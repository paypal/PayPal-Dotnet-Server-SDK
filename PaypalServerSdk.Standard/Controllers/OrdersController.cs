// <copyright file="OrdersController.cs" company="APIMatic">
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
    /// OrdersController.
    /// </summary>
    public class OrdersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersController"/> class.
        /// </summary>
        internal OrdersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates an order. Merchants and partners can add Level 2 and 3 data to payments to reduce risk and payment processing costs. For more information about processing payments, see checkout or multiparty checkout. Note: For error handling and troubleshooting, see Orders v2 errors.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public ApiResponse<Models.Order> CreateOrder(
                Models.CreateOrderInput input)
            => CoreHelper.RunTask(CreateOrderAsync(input));

        /// <summary>
        /// Creates an order. Merchants and partners can add Level 2 and 3 data to payments to reduce risk and payment processing costs. For more information about processing payments, see checkout or multiparty checkout. Note: For error handling and troubleshooting, see Orders v2 errors.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public async Task<ApiResponse<Models.Order>> CreateOrderAsync(
                Models.CreateOrderInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Order>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/checkout/orders")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Mock-Response", input.PaypalMockResponse))
                      .Header(_header => _header.Setup("PayPal-Request-Id", input.PaypalRequestId))
                      .Header(_header => _header.Setup("PayPal-Partner-Attribution-Id", input.PaypalPartnerAttributionId))
                      .Header(_header => _header.Setup("PayPal-Client-Metadata-Id", input.PaypalClientMetadataId))
                      .Header(_header => _header.Setup("Prefer", input.Prefer))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is not well-formed, syntactically incorrect, or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The requested action could not be performed, semantically incorrect, or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Shows details for an order, by ID. Note: For error handling and troubleshooting, see Orders v2 errors.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public ApiResponse<Models.Order> GetOrder(
                Models.GetOrderInput input)
            => CoreHelper.RunTask(GetOrderAsync(input));

        /// <summary>
        /// Shows details for an order, by ID. Note: For error handling and troubleshooting, see Orders v2 errors.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public async Task<ApiResponse<Models.Order>> GetOrderAsync(
                Models.GetOrderInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Order>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v2/checkout/orders/{id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", input.Id))
                      .Header(_header => _header.Setup("PayPal-Mock-Response", input.PaypalMockResponse))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))
                      .Query(_query => _query.Setup("fields", input.Fields))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The specified resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates an order with a `CREATED` or `APPROVED` status. You cannot update an order with the `COMPLETED` status. To make an update, you must provide a `reference_id`. If you omit this value with an order that contains only one purchase unit, PayPal sets the value to `default` which enables you to use the path: \"/purchase_units/@reference_id=='default'/{attribute-or-object}\". Merchants and partners can add Level 2 and 3 data to payments to reduce risk and payment processing costs. For more information about processing payments, see checkout or multiparty checkout. Note: For error handling and troubleshooting, see Orders v2 errors. Patchable attributes or objects: Attribute Op Notes intent replace payer replace, add Using replace op for payer will replace the whole payer object with the value sent in request. purchase_units replace, add purchase_units[].custom_id replace, add, remove purchase_units[].description replace, add, remove purchase_units[].payee.email replace purchase_units[].shipping.name replace, add purchase_units[].shipping.email_address replace, add purchase_units[].shipping.phone_number replace, add purchase_units[].shipping.options replace, add purchase_units[].shipping.address replace, add purchase_units[].shipping.type replace, add purchase_units[].soft_descriptor replace, remove purchase_units[].amount replace purchase_units[].items replace, add, remove purchase_units[].invoice_id replace, add, remove purchase_units[].payment_instruction replace purchase_units[].payment_instruction.disbursement_mode replace By default, disbursement_mode is INSTANT. purchase_units[].payment_instruction.payee_receivable_fx_rate_id replace, add, remove purchase_units[].payment_instruction.platform_fees replace, add, remove purchase_units[].supplementary_data.airline replace, add, remove purchase_units[].supplementary_data.card replace, add, remove application_context.client_configuration replace, add.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        public void PatchOrder(
                Models.PatchOrderInput input)
            => CoreHelper.RunVoidTask(PatchOrderAsync(input));

        /// <summary>
        /// Updates an order with a `CREATED` or `APPROVED` status. You cannot update an order with the `COMPLETED` status. To make an update, you must provide a `reference_id`. If you omit this value with an order that contains only one purchase unit, PayPal sets the value to `default` which enables you to use the path: \"/purchase_units/@reference_id=='default'/{attribute-or-object}\". Merchants and partners can add Level 2 and 3 data to payments to reduce risk and payment processing costs. For more information about processing payments, see checkout or multiparty checkout. Note: For error handling and troubleshooting, see Orders v2 errors. Patchable attributes or objects: Attribute Op Notes intent replace payer replace, add Using replace op for payer will replace the whole payer object with the value sent in request. purchase_units replace, add purchase_units[].custom_id replace, add, remove purchase_units[].description replace, add, remove purchase_units[].payee.email replace purchase_units[].shipping.name replace, add purchase_units[].shipping.email_address replace, add purchase_units[].shipping.phone_number replace, add purchase_units[].shipping.options replace, add purchase_units[].shipping.address replace, add purchase_units[].shipping.type replace, add purchase_units[].soft_descriptor replace, remove purchase_units[].amount replace purchase_units[].items replace, add, remove purchase_units[].invoice_id replace, add, remove purchase_units[].payment_instruction replace purchase_units[].payment_instruction.disbursement_mode replace By default, disbursement_mode is INSTANT. purchase_units[].payment_instruction.payee_receivable_fx_rate_id replace, add, remove purchase_units[].payment_instruction.platform_fees replace, add, remove purchase_units[].supplementary_data.airline replace, add, remove purchase_units[].supplementary_data.card replace, add, remove application_context.client_configuration replace, add.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task PatchOrderAsync(
                Models.PatchOrderInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v2/checkout/orders/{id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("id", input.Id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Mock-Response", input.PaypalMockResponse))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is not well-formed, syntactically incorrect, or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The specified resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The requested action could not be performed, semantically incorrect, or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Payer confirms their intent to pay for the the Order with the given payment source.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public ApiResponse<Models.Order> ConfirmOrder(
                Models.ConfirmOrderInput input)
            => CoreHelper.RunTask(ConfirmOrderAsync(input));

        /// <summary>
        /// Payer confirms their intent to pay for the the Order with the given payment source.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public async Task<ApiResponse<Models.Order>> ConfirmOrderAsync(
                Models.ConfirmOrderInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Order>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/checkout/orders/{id}/confirm-payment-source")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("id", input.Id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Client-Metadata-Id", input.PaypalClientMetadataId))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))
                      .Header(_header => _header.Setup("Prefer", input.Prefer))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is not well-formed, syntactically incorrect, or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Authorization failed due to insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The requested action could not be performed, semantically incorrect, or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("An internal server error has occurred.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Authorizes payment for an order. To successfully authorize payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request. A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response. Note: For error handling and troubleshooting, see Orders v2 errors.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.OrderAuthorizeResponse response from the API call.</returns>
        public ApiResponse<Models.OrderAuthorizeResponse> AuthorizeOrder(
                Models.AuthorizeOrderInput input)
            => CoreHelper.RunTask(AuthorizeOrderAsync(input));

        /// <summary>
        /// Authorizes payment for an order. To successfully authorize payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request. A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response. Note: For error handling and troubleshooting, see Orders v2 errors.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.OrderAuthorizeResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.OrderAuthorizeResponse>> AuthorizeOrderAsync(
                Models.AuthorizeOrderInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OrderAuthorizeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/checkout/orders/{id}/authorize")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("id", input.Id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Mock-Response", input.PaypalMockResponse))
                      .Header(_header => _header.Setup("PayPal-Request-Id", input.PaypalRequestId))
                      .Header(_header => _header.Setup("Prefer", input.Prefer))
                      .Header(_header => _header.Setup("PayPal-Client-Metadata-Id", input.PaypalClientMetadataId))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is not well-formed, syntactically incorrect, or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The authorized payment failed due to insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The specified resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The requested action could not be performed, semantically incorrect, or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("An internal server error has occurred.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Captures payment for an order. To successfully capture payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request. A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response. Note: For error handling and troubleshooting, see Orders v2 errors.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public ApiResponse<Models.Order> CaptureOrder(
                Models.CaptureOrderInput input)
            => CoreHelper.RunTask(CaptureOrderAsync(input));

        /// <summary>
        /// Captures payment for an order. To successfully capture payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request. A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response. Note: For error handling and troubleshooting, see Orders v2 errors.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public async Task<ApiResponse<Models.Order>> CaptureOrderAsync(
                Models.CaptureOrderInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Order>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/checkout/orders/{id}/capture")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("id", input.Id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Mock-Response", input.PaypalMockResponse))
                      .Header(_header => _header.Setup("PayPal-Request-Id", input.PaypalRequestId))
                      .Header(_header => _header.Setup("Prefer", input.Prefer))
                      .Header(_header => _header.Setup("PayPal-Client-Metadata-Id", input.PaypalClientMetadataId))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is not well-formed, syntactically incorrect, or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The authorized payment failed due to insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The specified resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The requested action could not be performed, semantically incorrect, or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("An internal server error has occurred.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Adds tracking information for an Order.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public ApiResponse<Models.Order> CreateOrderTracking(
                Models.CreateOrderTrackingInput input)
            => CoreHelper.RunTask(CreateOrderTrackingAsync(input));

        /// <summary>
        /// Adds tracking information for an Order.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public async Task<ApiResponse<Models.Order>> CreateOrderTrackingAsync(
                Models.CreateOrderTrackingInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Order>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/checkout/orders/{id}/track")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("id", input.Id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is not well-formed, syntactically incorrect, or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Authorization failed due to insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The specified resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The requested action could not be performed, semantically incorrect, or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("An internal server error has occurred.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates or cancels the tracking information for a PayPal order, by ID. Updatable attributes or objects: Attribute Op Notes items replace Using replace op for items will replace the entire items object with the value sent in request. notify_payer replace, add status replace Only patching status to CANCELLED is currently supported.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        public void UpdateOrderTracking(
                Models.UpdateOrderTrackingInput input)
            => CoreHelper.RunVoidTask(UpdateOrderTrackingAsync(input));

        /// <summary>
        /// Updates or cancels the tracking information for a PayPal order, by ID. Updatable attributes or objects: Attribute Op Notes items replace Using replace op for items will replace the entire items object with the value sent in request. notify_payer replace, add status replace Only patching status to CANCELLED is currently supported.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UpdateOrderTrackingAsync(
                Models.UpdateOrderTrackingInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v2/checkout/orders/{id}/trackers/{tracker_id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("id", input.Id))
                      .Template(_template => _template.Setup("tracker_id", input.TrackerId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PaypalAuthAssertion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is not well-formed, syntactically incorrect, or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Authorization failed due to insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The specified resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The requested action could not be performed, semantically incorrect, or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("An internal server error has occurred.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}