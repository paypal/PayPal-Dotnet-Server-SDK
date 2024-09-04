// <copyright file="OAuthAuthorizationController.cs" company="APIMatic">
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
    /// OAuthAuthorizationController.
    /// </summary>
    public class OAuthAuthorizationController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthAuthorizationController"/> class.
        /// </summary>
        internal OAuthAuthorizationController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create a new OAuth 2 token.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint.</param>
        /// <returns>Returns the ApiResponse of Models.OAuthToken response from the API call.</returns>
        public ApiResponse<Models.OAuthToken> RequestToken(
                Models.RequestTokenInput input,
                Dictionary<string, object> fieldParameters = null)
            => CoreHelper.RunTask(RequestTokenAsync(input, fieldParameters));

        /// <summary>
        /// Create a new OAuth 2 token.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.OAuthToken response from the API call.</returns>
        public async Task<ApiResponse<Models.OAuthToken>> RequestTokenAsync(
                Models.RequestTokenInput input,
                Dictionary<string, object> fieldParameters = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OAuthToken>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/oauth2/token")
                  .Parameters(_parameters => _parameters
                      .AdditionalForms(_additionalForms => _additionalForms.Setup(fieldParameters))
                      .Form(_form => _form.Setup("grant_type", "client_credentials"))
                      .Header(_header => _header.Setup("Authorization", input.Authorization))
                      .Form(_form => _form.Setup("scope", input.Scope))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("OAuth 2 provider returned an error.", (_reason, _context) => new OAuthProviderException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("OAuth 2 provider says client authentication failed.", (_reason, _context) => new OAuthProviderException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}