// <copyright file="OAuthTokenExtensions.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using PaypalServerSDK.Standard.Models;

namespace PaypalServerSDK.Standard.Authentication
{
    internal static class OAuthTokenExtensions
    {
        internal static bool IsTokenExpired(this OAuthToken token, TimeSpan? clockSkew)
        {
            if (token == null)
            {
                throw new InvalidOperationException("OAuth token is missing.");
            }

            if (token.Expiry == null) return true;
            return token.Expiry < DateTimeOffset.UtcNow.Subtract(clockSkew ?? TimeSpan.Zero).ToUnixTimeSeconds();    
        }
    }
}