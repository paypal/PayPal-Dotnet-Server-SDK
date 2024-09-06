// <copyright file="IHttpClientConfiguration.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Net.Http;
using APIMatic.Core.Http.Configuration;

namespace PayPalRESTAPIs.Standard.Http.Client
{
    /// <summary>
    /// Represents the current state of the Http Client.
    /// </summary>
    public interface IHttpClientConfiguration : ICoreHttpClientConfiguration { }
}
