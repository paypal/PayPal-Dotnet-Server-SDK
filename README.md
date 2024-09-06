
# Getting Started with PayPal REST APIs

## Introduction

An order represents a payment between two or more parties. Use the Orders API to create, update, retrieve, authorize, and capture orders., Call the Payments API to authorize payments, capture authorized payments, refund payments that have already been captured, and show payment information. Use the Payments API in conjunction with the <a href="/docs/api/orders/v2/">Orders API</a>. For more information, see the <a href="/docs/checkout/">PayPal Checkout Overview</a>., The Payment Method Tokens API saves payment methods so payers don't have to enter details for future transactions. Payers can check out faster or pay without being present after they agree to save a payment method.<br><br>The API associates a payment method with a temporary setup token. Pass the setup token to the API to exchange the setup token for a permanent token.<br><br>The permanent token represents a payment method that's saved to the vault. This token can be used repeatedly for checkout or recurring transactions such as subscriptions.<br><br>The Payment Method Tokens API is available in the US only.

Find out more here: [https://developer.paypal.com/docs/api/orders/v2/](https://developer.paypal.com/docs/api/orders/v2/)

## Building

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore is enabled, these dependencies will be installed automatically. Therefore, you will need internet access for build.

* Open the solution (PayPalRESTAPIs.sln) file.

Invoke the build process using Ctrl + Shift + B shortcut key or using the Build menu as shown below.

The build process generates a portable class library, which can be used like a normal class library. More information on how to use can be found at the MSDN Portable Class Libraries documentation.

The supported version is **.NET Standard 2.0**. For checking compatibility of your .NET implementation with the generated library, [click here](https://dotnet.microsoft.com/en-us/platform/dotnet-standard#versions).

## Installation

The following section explains how to use the PayPalRESTAPIs.Standard library in a new project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the solution explorer and choose `Add -> New Project`.

![Add a new project in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=PayPal%20REST%20APIs-CSharp&workspaceName=PayPalRESTAPIs&projectName=PayPalRESTAPIs.Standard&rootNamespace=PayPalRESTAPIs.Standard&step=addProject)

Next, choose `Console Application`, provide `TestConsoleProject` as the project name and click OK.

![Create a new Console Application in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=PayPal%20REST%20APIs-CSharp&workspaceName=PayPalRESTAPIs&projectName=PayPalRESTAPIs.Standard&rootNamespace=PayPalRESTAPIs.Standard&step=createProject)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the `TestConsoleProject` as the start-up project. To do this, right-click on the `TestConsoleProject` and choose `Set as StartUp Project` form the context menu.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=PayPal%20REST%20APIs-CSharp&workspaceName=PayPalRESTAPIs&projectName=PayPalRESTAPIs.Standard&rootNamespace=PayPalRESTAPIs.Standard&step=setStartup)

### 3. Add reference of the library project

In order to use the `PayPalRESTAPIs.Standard` library in the new project, first we must add a project reference to the `TestConsoleProject`. First, right click on the `References` node in the solution explorer and click `Add Reference...`

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=PayPal%20REST%20APIs-CSharp&workspaceName=PayPalRESTAPIs&projectName=PayPalRESTAPIs.Standard&rootNamespace=PayPalRESTAPIs.Standard&step=addReference)

Next, a window will be displayed where we must set the `checkbox` on `PayPalRESTAPIs.Standard` and click `OK`. By doing this, we have added a reference of the `PayPalRESTAPIs.Standard` project into the new `TestConsoleProject`.

![Creating a project reference](https://apidocs.io/illustration/cs?workspaceFolder=PayPal%20REST%20APIs-CSharp&workspaceName=PayPalRESTAPIs&projectName=PayPalRESTAPIs.Standard&rootNamespace=PayPalRESTAPIs.Standard&step=createReference)

### 4. Write sample code

Once the `TestConsoleProject` is created, a file named `Program.cs` will be visible in the solution explorer with an empty `Main` method. This is the entry point for the execution of the entire solution. Here, you can add code to initialize the client library and acquire the instance of a Controller class. Sample code to initialize the client library and using Controller methods is given in the subsequent sections.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=PayPal%20REST%20APIs-CSharp&workspaceName=PayPalRESTAPIs&projectName=PayPalRESTAPIs.Standard&rootNamespace=PayPalRESTAPIs.Standard&step=addCode)

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Sandbox`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `LogBuilder` | [`LogBuilder`](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/log-builder.md) | Represents the logging configuration builder for API calls |
| `ClientCredentialsAuth` | [`ClientCredentialsAuth`](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

The API client can be initialized as follows:

```csharp
PayPalRESTAPIs.Standard.PayPalRESTAPIsClient client = new PayPalRESTAPIs.Standard.PayPalRESTAPIsClient.Builder()
    .ClientCredentialsAuth(
        new ClientCredentialsAuthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .Environment(PayPalRESTAPIs.Standard.Environment.Sandbox)
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

* [`Oauth2 (OAuth 2 Client Credentials Grant)`](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/auth/oauth-2-client-credentials-grant.md)

## List of APIs

* [Orders](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/controllers/orders.md)
* [Payments](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/controllers/payments.md)
* [Vault](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/controllers/vault.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/http-request.md)
* [HttpResponse](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/http-string-response.md)
* [HttpContext](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/api-exception.md)
* [LogBuilder](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/log-builder.md)
* [LogRequestBuilder](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/log-request-builder.md)
* [LogResponseBuilder](https://www.github.com/moizgillani/paypal-csharp-sdk/tree/1.0.5/doc/log-response-builder.md)

