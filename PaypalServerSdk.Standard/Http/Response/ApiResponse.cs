// <copyright file="ApiResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System.Collections.Generic;
using APIMatic.Core.Types.Sdk;

namespace PaypalServerSDK.Standard.Http.Response
{
    /// <summary>
    /// ApiResponse Class.
    /// </summary>
    /// <typeparam name="T"> Generic type.</typeparam>
    public class ApiResponse<T> : CoreApiResponse<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse{T}"/> class.
        /// </summary>
        /// <param name="statusCode">Status code.</param>
        /// <param name="headers">Headers.</param>
        /// <param name="data">Data.</param>
        public ApiResponse(int statusCode, Dictionary<string, string> headers, T data)
            : base(statusCode, headers, data) { }
    }
}