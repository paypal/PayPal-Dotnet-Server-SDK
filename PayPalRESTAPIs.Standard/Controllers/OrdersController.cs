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
using PayPalRESTAPIs.Standard;
using PayPalRESTAPIs.Standard.Exceptions;
using PayPalRESTAPIs.Standard.Http.Client;
using PayPalRESTAPIs.Standard.Http.Response;
using PayPalRESTAPIs.Standard.Utilities;
using System.Net.Http;

namespace PayPalRESTAPIs.Standard.Controllers
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
        /// Creates an order. Merchants and partners can add Level 2 and 3 data to payments to reduce risk and payment processing costs. For more information about processing payments, see <a href="https://developer.paypal.com/docs/checkout/advanced/processing/">checkout</a> or <a href="https://developer.paypal.com/docs/multiparty/checkout/advanced/processing/">multiparty checkout</a>.<blockquote><strong>Note:</strong> For error handling and troubleshooting, see <a href="https://developer.paypal.com/api/rest/reference/orders/v2/errors/#create-order">Orders v2 errors</a>.</blockquote>.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public ApiResponse<Models.Order> OrdersCreate(
                Models.OrdersCreateInput input)
            => CoreHelper.RunTask(OrdersCreateAsync(input));

        /// <summary>
        /// Creates an order. Merchants and partners can add Level 2 and 3 data to payments to reduce risk and payment processing costs. For more information about processing payments, see <a href="https://developer.paypal.com/docs/checkout/advanced/processing/">checkout</a> or <a href="https://developer.paypal.com/docs/multiparty/checkout/advanced/processing/">multiparty checkout</a>.<blockquote><strong>Note:</strong> For error handling and troubleshooting, see <a href="https://developer.paypal.com/api/rest/reference/orders/v2/errors/#create-order">Orders v2 errors</a>.</blockquote>.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public async Task<ApiResponse<Models.Order>> OrdersCreateAsync(
                Models.OrdersCreateInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Order>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/checkout/orders")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Request-Id", input.PayPalRequestId))
                      .Header(_header => _header.Setup("PayPal-Partner-Attribution-Id", input.PayPalPartnerAttributionId))
                      .Header(_header => _header.Setup("PayPal-Client-Metadata-Id", input.PayPalClientMetadataId))
                      .Header(_header => _header.Setup("Prefer", input.Prefer))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is not well-formed, syntactically incorrect, or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The requested action could not be performed, semantically incorrect, or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Shows details for an order, by ID.<blockquote><strong>Note:</strong> For error handling and troubleshooting, see <a href="https://developer.paypal.com/api/rest/reference/orders/v2/errors/#get-order">Orders v2 errors</a>.</blockquote>.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public ApiResponse<Models.Order> OrdersGet(
                Models.OrdersGetInput input)
            => CoreHelper.RunTask(OrdersGetAsync(input));

        /// <summary>
        /// Shows details for an order, by ID.<blockquote><strong>Note:</strong> For error handling and troubleshooting, see <a href="https://developer.paypal.com/api/rest/reference/orders/v2/errors/#get-order">Orders v2 errors</a>.</blockquote>.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public async Task<ApiResponse<Models.Order>> OrdersGetAsync(
                Models.OrdersGetInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Order>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v2/checkout/orders/{id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", input.Id))
                      .Query(_query => _query.Setup("fields", input.Fields))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Authentication failed due to missing authorization header, or invalid authentication credentials.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The specified resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates an order with a `CREATED` or `APPROVED` status. You cannot update an order with the `COMPLETED` status.<br/><br/>To make an update, you must provide a `reference_id`. If you omit this value with an order that contains only one purchase unit, PayPal sets the value to `default` which enables you to use the path: <code>\"/purchase_units/@reference_id=='default'/{attribute-or-object}\"</code>. Merchants and partners can add Level 2 and 3 data to payments to reduce risk and payment processing costs. For more information about processing payments, see <a href="https://developer.paypal.com/docs/checkout/advanced/processing/">checkout</a> or <a href="https://developer.paypal.com/docs/multiparty/checkout/advanced/processing/">multiparty checkout</a>.<blockquote><strong>Note:</strong> For error handling and troubleshooting, see <a href="https://developer.paypal.com/api/rest/reference/orders/v2/errors/#patch-order">Orders v2 errors</a>.</blockquote>Patchable attributes or objects:<br/><br/><table><thead><th>Attribute</th><th>Op</th><th>Notes</th></thead><tbody><tr><td><code>intent</code></td><td>replace</td><td></td></tr><tr><td><code>payer</code></td><td>replace, add</td><td>Using replace op for <code>payer</code> will replace the whole <code>payer</code> object with the value sent in request.</td></tr><tr><td><code>purchase_units</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].custom_id</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].description</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].payee.email</code></td><td>replace</td><td></td></tr><tr><td><code>purchase_units[].shipping.name</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.email_address</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.phone_number</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.options</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.address</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.type</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].soft_descriptor</code></td><td>replace, remove</td><td></td></tr><tr><td><code>purchase_units[].amount</code></td><td>replace</td><td></td></tr><tr><td><code>purchase_units[].items</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].invoice_id</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].payment_instruction</code></td><td>replace</td><td></td></tr><tr><td><code>purchase_units[].payment_instruction.disbursement_mode</code></td><td>replace</td><td>By default, <code>disbursement_mode</code> is <code>INSTANT</code>.</td></tr><tr><td><code>purchase_units[].payment_instruction.payee_receivable_fx_rate_id</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].payment_instruction.platform_fees</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].supplementary_data.airline</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].supplementary_data.card</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>application_context.client_configuration</code></td><td>replace, add</td><td></td></tr></tbody></table>.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        public void OrdersPatch(
                Models.OrdersPatchInput input)
            => CoreHelper.RunVoidTask(OrdersPatchAsync(input));

        /// <summary>
        /// Updates an order with a `CREATED` or `APPROVED` status. You cannot update an order with the `COMPLETED` status.<br/><br/>To make an update, you must provide a `reference_id`. If you omit this value with an order that contains only one purchase unit, PayPal sets the value to `default` which enables you to use the path: <code>\"/purchase_units/@reference_id=='default'/{attribute-or-object}\"</code>. Merchants and partners can add Level 2 and 3 data to payments to reduce risk and payment processing costs. For more information about processing payments, see <a href="https://developer.paypal.com/docs/checkout/advanced/processing/">checkout</a> or <a href="https://developer.paypal.com/docs/multiparty/checkout/advanced/processing/">multiparty checkout</a>.<blockquote><strong>Note:</strong> For error handling and troubleshooting, see <a href="https://developer.paypal.com/api/rest/reference/orders/v2/errors/#patch-order">Orders v2 errors</a>.</blockquote>Patchable attributes or objects:<br/><br/><table><thead><th>Attribute</th><th>Op</th><th>Notes</th></thead><tbody><tr><td><code>intent</code></td><td>replace</td><td></td></tr><tr><td><code>payer</code></td><td>replace, add</td><td>Using replace op for <code>payer</code> will replace the whole <code>payer</code> object with the value sent in request.</td></tr><tr><td><code>purchase_units</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].custom_id</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].description</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].payee.email</code></td><td>replace</td><td></td></tr><tr><td><code>purchase_units[].shipping.name</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.email_address</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.phone_number</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.options</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.address</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.type</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].soft_descriptor</code></td><td>replace, remove</td><td></td></tr><tr><td><code>purchase_units[].amount</code></td><td>replace</td><td></td></tr><tr><td><code>purchase_units[].items</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].invoice_id</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].payment_instruction</code></td><td>replace</td><td></td></tr><tr><td><code>purchase_units[].payment_instruction.disbursement_mode</code></td><td>replace</td><td>By default, <code>disbursement_mode</code> is <code>INSTANT</code>.</td></tr><tr><td><code>purchase_units[].payment_instruction.payee_receivable_fx_rate_id</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].payment_instruction.platform_fees</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].supplementary_data.airline</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].supplementary_data.card</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>application_context.client_configuration</code></td><td>replace, add</td><td></td></tr></tbody></table>.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task OrdersPatchAsync(
                Models.OrdersPatchInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v2/checkout/orders/{id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("id", input.Id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
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
        public ApiResponse<Models.Order> OrdersConfirm(
                Models.OrdersConfirmInput input)
            => CoreHelper.RunTask(OrdersConfirmAsync(input));

        /// <summary>
        /// Payer confirms their intent to pay for the the Order with the given payment source.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public async Task<ApiResponse<Models.Order>> OrdersConfirmAsync(
                Models.OrdersConfirmInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Order>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/checkout/orders/{id}/confirm-payment-source")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("id", input.Id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Client-Metadata-Id", input.PayPalClientMetadataId))
                      .Header(_header => _header.Setup("Prefer", input.Prefer))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is not well-formed, syntactically incorrect, or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Authorization failed due to insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The requested action could not be performed, semantically incorrect, or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("An internal server error has occurred.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Authorizes payment for an order. To successfully authorize payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request. A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response.<blockquote><strong>Note:</strong> For error handling and troubleshooting, see <a href="https://developer.paypal.com/api/rest/reference/orders/v2/errors/#authorize-order">Orders v2 errors</a>.</blockquote>.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.OrderAuthorizeResponse response from the API call.</returns>
        public ApiResponse<Models.OrderAuthorizeResponse> OrdersAuthorize(
                Models.OrdersAuthorizeInput input)
            => CoreHelper.RunTask(OrdersAuthorizeAsync(input));

        /// <summary>
        /// Authorizes payment for an order. To successfully authorize payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request. A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response.<blockquote><strong>Note:</strong> For error handling and troubleshooting, see <a href="https://developer.paypal.com/api/rest/reference/orders/v2/errors/#authorize-order">Orders v2 errors</a>.</blockquote>.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.OrderAuthorizeResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.OrderAuthorizeResponse>> OrdersAuthorizeAsync(
                Models.OrdersAuthorizeInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OrderAuthorizeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/checkout/orders/{id}/authorize")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("id", input.Id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Request-Id", input.PayPalRequestId))
                      .Header(_header => _header.Setup("Prefer", input.Prefer))
                      .Header(_header => _header.Setup("PayPal-Client-Metadata-Id", input.PayPalClientMetadataId))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PayPalAuthAssertion))))
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
        /// Captures payment for an order. To successfully capture payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request. A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response.<blockquote><strong>Note:</strong> For error handling and troubleshooting, see <a href="https://developer.paypal.com/api/rest/reference/orders/v2/errors/#capture-order">Orders v2 errors</a>.</blockquote>.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public ApiResponse<Models.Order> OrdersCapture(
                Models.OrdersCaptureInput input)
            => CoreHelper.RunTask(OrdersCaptureAsync(input));

        /// <summary>
        /// Captures payment for an order. To successfully capture payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request. A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response.<blockquote><strong>Note:</strong> For error handling and troubleshooting, see <a href="https://developer.paypal.com/api/rest/reference/orders/v2/errors/#capture-order">Orders v2 errors</a>.</blockquote>.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public async Task<ApiResponse<Models.Order>> OrdersCaptureAsync(
                Models.OrdersCaptureInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Order>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/checkout/orders/{id}/capture")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("id", input.Id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Request-Id", input.PayPalRequestId))
                      .Header(_header => _header.Setup("Prefer", input.Prefer))
                      .Header(_header => _header.Setup("PayPal-Client-Metadata-Id", input.PayPalClientMetadataId))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PayPalAuthAssertion))))
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
        public ApiResponse<Models.Order> OrdersTrackCreate(
                Models.OrdersTrackCreateInput input)
            => CoreHelper.RunTask(OrdersTrackCreateAsync(input));

        /// <summary>
        /// Adds tracking information for an Order.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Order response from the API call.</returns>
        public async Task<ApiResponse<Models.Order>> OrdersTrackCreateAsync(
                Models.OrdersTrackCreateInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Order>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/checkout/orders/{id}/track")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("id", input.Id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Auth-Assertion", input.PayPalAuthAssertion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is not well-formed, syntactically incorrect, or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Authorization failed due to insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The specified resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The requested action could not be performed, semantically incorrect, or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("An internal server error has occurred.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("The error response.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// Updates or cancels the tracking information for a PayPal order, by ID. Updatable attributes or objects:<br/><br/><table><thead><th>Attribute</th><th>Op</th><th>Notes</th></thead><tbody></tr><tr><td><code>items</code></td><td>replace</td><td>Using replace op for <code>items</code> will replace the entire <code>items</code> object with the value sent in request.</td></tr><tr><td><code>notify_payer</code></td><td>replace, add</td><td></td></tr><tr><td><code>status</code></td><td>replace</td><td>Only patching status to CANCELLED is currently supported.</td></tr></tbody></table>.
        /// ]]>
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        public void OrdersTrackersPatch(
                Models.OrdersTrackersPatchInput input)
            => CoreHelper.RunVoidTask(OrdersTrackersPatchAsync(input));

        /// <summary>
        /// <![CDATA[
        /// Updates or cancels the tracking information for a PayPal order, by ID. Updatable attributes or objects:<br/><br/><table><thead><th>Attribute</th><th>Op</th><th>Notes</th></thead><tbody></tr><tr><td><code>items</code></td><td>replace</td><td>Using replace op for <code>items</code> will replace the entire <code>items</code> object with the value sent in request.</td></tr><tr><td><code>notify_payer</code></td><td>replace, add</td><td></td></tr><tr><td><code>status</code></td><td>replace</td><td>Only patching status to CANCELLED is currently supported.</td></tr></tbody></table>.
        /// ]]>
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task OrdersTrackersPatchAsync(
                Models.OrdersTrackersPatchInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v2/checkout/orders/{id}/trackers/{tracker_id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Template(_template => _template.Setup("id", input.Id))
                      .Template(_template => _template.Setup("tracker_id", input.TrackerId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
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