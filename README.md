
# Getting Started with Paypal Server SDK

## Introduction

An order represents a payment between two or more parties. Use the Orders API to create, update, retrieve, authorize, and capture orders., Call the Payments API to authorize payments, capture authorized payments, refund payments that have already been captured, and show payment information. Use the Payments API in conjunction with the <a href="/docs/api/orders/v2/">Orders API</a>. For more information, see the <a href="/docs/checkout/">PayPal Checkout Overview</a>., The Payment Method Tokens API saves payment methods so payers don't have to enter details for future transactions. Payers can check out faster or pay without being present after they agree to save a payment method.<br><br>The API associates a payment method with a temporary setup token. Pass the setup token to the API to exchange the setup token for a permanent token.<br><br>The permanent token represents a payment method that's saved to the vault. This token can be used repeatedly for checkout or recurring transactions such as subscriptions.<br><br>The Payment Method Tokens API is available in the US only.

Find out more here: [https://developer.paypal.com/docs/api/orders/v2/](https://developer.paypal.com/docs/api/orders/v2/)

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package PayPalServerSDK --version 0.5.0
```

You can also view the package at:
https://www.nuget.org/packages/PayPalServerSDK/0.5.0

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Sandbox`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `LogBuilder` | [`LogBuilder`](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/log-builder.md) | Represents the logging configuration builder for API calls |
| `ClientCredentialsAuth` | [`ClientCredentialsAuth`](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

The API client can be initialized as follows:

```csharp
PaypalServerSDKClient client = new PaypalServerSDKClient.Builder()
    .ClientCredentialsAuth(
        new ClientCredentialsAuthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .Environment(PaypalServerSDK.Standard.Environment.Sandbox)
    .LoggingConfig(config => config
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```

API calls return an `ApiResponse` object that includes the following fields:

| Field | Description |
|  --- | --- |
| `StatusCode` | Status code of the HTTP response |
| `Headers` | Headers of the HTTP response as a Hash |
| `Data` | The deserialized body of the HTTP response as a String |

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Production | PayPal Live Environment |
| Sandbox | **Default** PayPal Sandbox Environment |

## Authorization

This API uses the following authentication schemes.

* [`Oauth2 (OAuth 2 Client Credentials Grant)`](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/auth/oauth-2-client-credentials-grant.md)

## List of APIs

* [Orders](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/controllers/orders.md)
* [Payments](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/controllers/payments.md)
* [Vault](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/controllers/vault.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/http-string-response.md)
* [HttpContext](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/api-exception.md)
* [LogBuilder](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/log-builder.md)
* [LogRequestBuilder](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/log-request-builder.md)
* [LogResponseBuilder](https://www.github.com/paypal/PayPal-Dotnet-Server-SDK/tree/0.5.0/doc/log-response-builder.md)

