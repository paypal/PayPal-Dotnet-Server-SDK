
# Getting Started with PayPal Server SDK

## Introduction

### ⚠️ Beta Release Notice

This version is considered a **beta release**. While we have done our best to ensure stability and functionality, there may still be bugs, incomplete features, or breaking changes in future updates.

#### Important Notes

- **Available Features:** This SDK currently contains only 3 of PayPal's API endpoints. Additional endpoints and functionality will be added in the future.
- **API Changes:** Expect potential changes in APIs and features as we finalize the product.

### Information

The PayPal Server SDK provides integration access to the PayPal REST APIs. The API endpoints are divided into distinct controllers:

- Orders Controller: <a href="https://developer.paypal.com/docs/api/orders/v2/">Orders API v2</a>
- Payments Controller: <a href="https://developer.paypal.com/docs/api/payments/v2/">Payments API v2</a>
- Vault Controller: <a href="https://developer.paypal.com/docs/api/payment-tokens/v3/">Payment Method Tokens API v3</a> *Available in the US only.*

Find out more here: [https://developer.paypal.com/docs/api/orders/v2/](https://developer.paypal.com/docs/api/orders/v2/)

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package PayPalServerSDK --version 0.7.0
```

You can also view the package at:
https://www.nuget.org/packages/PayPalServerSDK/0.7.0

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Sandbox`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `LogBuilder` | [`LogBuilder`](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/log-builder.md) | Represents the logging configuration builder for API calls |
| `ClientCredentialsAuth` | [`ClientCredentialsAuth`](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

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

* [`Oauth2 (OAuth 2 Client Credentials Grant)`](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/auth/oauth-2-client-credentials-grant.md)

## List of APIs

* [Orders](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/controllers/orders.md)
* [Payments](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/controllers/payments.md)
* [Vault](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/controllers/vault.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/http-string-response.md)
* [HttpContext](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/http-client-configuration-builder.md)
* [ApiException](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/api-exception.md)
* [ApiResponse](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/api-response.md)
* [LogBuilder](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/log-builder.md)
* [LogRequestBuilder](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/log-request-builder.md)
* [LogResponseBuilder](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.7.0/doc/log-response-builder.md)

