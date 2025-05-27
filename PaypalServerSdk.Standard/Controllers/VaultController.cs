// <copyright file="VaultController.cs" company="APIMatic">
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
    /// VaultController.
    /// </summary>
    public class VaultController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultController"/> class.
        /// </summary>
        internal VaultController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Delete the payment token associated with the payment token id.
        /// </summary>
        /// <param name="id">Required parameter: ID of the payment token..</param>
        public void DeletePaymentToken(
                string id)
            => CoreHelper.RunVoidTask(DeletePaymentTokenAsync(id));

        /// <summary>
        /// Delete the payment token associated with the payment token id.
        /// </summary>
        /// <param name="id">Required parameter: ID of the payment token..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeletePaymentTokenAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v3/vault/payment-tokens/{id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is not well-formed, syntactically incorrect, or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Authorization failed due to insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("An internal server error has occurred.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a Setup Token from the given payment source and adds it to the Vault of the associated customer.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.SetupTokenResponse response from the API call.</returns>
        public ApiResponse<Models.SetupTokenResponse> CreateSetupToken(
                Models.CreateSetupTokenInput input)
            => CoreHelper.RunTask(CreateSetupTokenAsync(input));

        /// <summary>
        /// Creates a Setup Token from the given payment source and adds it to the Vault of the associated customer.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SetupTokenResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.SetupTokenResponse>> CreateSetupTokenAsync(
                Models.CreateSetupTokenInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SetupTokenResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v3/vault/setup-tokens")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Request-Id", input.PaypalRequestId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is not well-formed, syntactically incorrect, or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Authorization failed due to insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The requested action could not be performed, semantically incorrect, or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("An internal server error has occurred.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a readable representation of temporarily vaulted payment source associated with the setup token id.
        /// </summary>
        /// <param name="id">Required parameter: ID of the setup token..</param>
        /// <returns>Returns the ApiResponse of Models.SetupTokenResponse response from the API call.</returns>
        public ApiResponse<Models.SetupTokenResponse> GetSetupToken(
                string id)
            => CoreHelper.RunTask(GetSetupTokenAsync(id));

        /// <summary>
        /// Returns a readable representation of temporarily vaulted payment source associated with the setup token id.
        /// </summary>
        /// <param name="id">Required parameter: ID of the setup token..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SetupTokenResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.SetupTokenResponse>> GetSetupTokenAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SetupTokenResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v3/vault/setup-tokens/{id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("403", CreateErrorCase("Authorization failed due to insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The specified resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The requested action could not be performed, semantically incorrect, or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("An internal server error has occurred.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a Payment Token from the given payment source and adds it to the Vault of the associated customer.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.PaymentTokenResponse response from the API call.</returns>
        public ApiResponse<Models.PaymentTokenResponse> CreatePaymentToken(
                Models.CreatePaymentTokenInput input)
            => CoreHelper.RunTask(CreatePaymentTokenAsync(input));

        /// <summary>
        /// Creates a Payment Token from the given payment source and adds it to the Vault of the associated customer.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.PaymentTokenResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.PaymentTokenResponse>> CreatePaymentTokenAsync(
                Models.CreatePaymentTokenInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentTokenResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v3/vault/payment-tokens")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(input.Body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("PayPal-Request-Id", input.PaypalRequestId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is not well-formed, syntactically incorrect, or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Authorization failed due to insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Request contains reference to resources that do not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The requested action could not be performed, semantically incorrect, or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("An internal server error has occurred.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns all payment tokens for a customer.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the ApiResponse of Models.CustomerVaultPaymentTokensResponse response from the API call.</returns>
        public ApiResponse<Models.CustomerVaultPaymentTokensResponse> ListCustomerPaymentTokens(
                Models.ListCustomerPaymentTokensInput input)
            => CoreHelper.RunTask(ListCustomerPaymentTokensAsync(input));

        /// <summary>
        /// Returns all payment tokens for a customer.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CustomerVaultPaymentTokensResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.CustomerVaultPaymentTokensResponse>> ListCustomerPaymentTokensAsync(
                Models.ListCustomerPaymentTokensInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomerVaultPaymentTokensResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v3/vault/payment-tokens")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("customer_id", input.CustomerId))
                      .Query(_query => _query.Setup("page_size", input.PageSize))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("total_required", input.TotalRequired))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is not well-formed, syntactically incorrect, or violates schema.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Authorization failed due to insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("An internal server error has occurred.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a readable representation of vaulted payment source associated with the payment token id.
        /// </summary>
        /// <param name="id">Required parameter: ID of the payment token..</param>
        /// <returns>Returns the ApiResponse of Models.PaymentTokenResponse response from the API call.</returns>
        public ApiResponse<Models.PaymentTokenResponse> GetPaymentToken(
                string id)
            => CoreHelper.RunTask(GetPaymentTokenAsync(id));

        /// <summary>
        /// Returns a readable representation of vaulted payment source associated with the payment token id.
        /// </summary>
        /// <param name="id">Required parameter: ID of the payment token..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.PaymentTokenResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.PaymentTokenResponse>> GetPaymentTokenAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentTokenResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v3/vault/payment-tokens/{id}")
                  .WithAuth("Oauth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("403", CreateErrorCase("Authorization failed due to insufficient permissions.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The specified resource does not exist.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("The requested action could not be performed, semantically incorrect, or failed business validation.", (_reason, _context) => new ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("An internal server error has occurred.", (_reason, _context) => new ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}