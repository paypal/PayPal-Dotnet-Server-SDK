
# Getting Started with PayPal Server SDK

## Introduction

### Important Notes

- **Available Features:** This SDK currently contains only 3 of PayPal's API endpoints. Additional endpoints and functionality will be added in the future.

### Information

The PayPal Server SDK provides integration access to the PayPal REST APIs. The API endpoints are divided into distinct controllers:

- Orders Controller: [Orders API v2](https://developer.paypal.com/docs/api/orders/v2/)
- Payments Controller: [Payments API v2](https://developer.paypal.com/docs/api/payments/v2
- Vault Controller: [Payment Method Tokens API v3](https://developer.paypal.com/docs/api/payment-tokens/v3/) *Available in the US only.*

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package PayPalServerSDK --version 1.1.0
```

You can also view the package at:
https://www.nuget.org/packages/PayPalServerSDK/1.1.0

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | `Environment` | The API environment. <br> **Default: `Environment.Sandbox`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/log-builder.md) | Represents the logging configuration builder for API calls |
| ClientCredentialsAuth | [`ClientCredentialsAuth`](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

The API client can be initialized as follows:

```csharp
PaypalServerSdkClient client = new PaypalServerSdkClient.Builder()
    .ClientCredentialsAuth(
        new ClientCredentialsAuthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .Environment(PaypalServerSdk.Standard.Environment.Sandbox)
    .LoggingConfig(config => config
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Production | PayPal Live Environment |
| Sandbox | **Default** PayPal Sandbox Environment |

## Authorization

This API uses the following authentication schemes.

* [`Oauth2 (OAuth 2 Client Credentials Grant)`](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/auth/oauth-2-client-credentials-grant.md)

## List of APIs

* [Orders](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/controllers/orders.md)
* [Payments](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/controllers/payments.md)
* [Vault](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/controllers/vault.md)

## SDK Infrastructure

### Configuration

* [HttpClientConfiguration](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/http-client-configuration-builder.md)
* [LogBuilder](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/log-builder.md)
* [LogRequestBuilder](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/log-request-builder.md)
* [LogResponseBuilder](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/log-response-builder.md)
* [ProxyConfigurationBuilder](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/http-callback.md)
* [HttpContext](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/http-context.md)
* [HttpRequest](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/http-string-response.md)

### Utilities

* [ApiException](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/api-exception.md)
* [ApiResponse](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/api-response.md)
* [ApiHelper](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/api-helper.md)
* [JsonObject](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/json-object.md)
* [JsonValue](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/1.1.0/doc/json-value.md)

