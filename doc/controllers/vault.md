# Vault

Use the `/vault` resource to create, retrieve, and delete payment and setup tokens.

```csharp
VaultController vaultController = client.VaultController;
```

## Class Name

`VaultController`

## Methods

* [Payment-Tokens Create](../../doc/controllers/vault.md#payment-tokens-create)
* [Customer Payment-Tokens Get](../../doc/controllers/vault.md#customer-payment-tokens-get)
* [Payment-Tokens Get](../../doc/controllers/vault.md#payment-tokens-get)
* [Payment-Tokens Delete](../../doc/controllers/vault.md#payment-tokens-delete)
* [Setup-Tokens Create](../../doc/controllers/vault.md#setup-tokens-create)
* [Setup-Tokens Get](../../doc/controllers/vault.md#setup-tokens-get)


# Payment-Tokens Create

Creates a Payment Token from the given payment source and adds it to the Vault of the associated customer.

```csharp
PaymentTokensCreateAsync(
    Models.PaymentTokensCreateInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `payPalRequestId` | `string` | Header, Required | The server stores keys for 3 hours. |
| `body` | [`PaymentTokenRequest`](../../doc/models/payment-token-request.md) | Body, Required | Payment Token creation with a financial instrument and an optional customer_id. |

## Response Type

[`Task<ApiResponse<Models.PaymentTokenResponse>>`](../../doc/models/payment-token-response.md)

## Example Usage

```csharp
PaymentTokensCreateInput paymentTokensCreateInput = new PaymentTokensCreateInput
{
    PayPalRequestId = "12345",
    Body = new PaymentTokenRequest
    {
        PaymentSource = new PaymentTokenRequestPaymentSource
        {
            Token = new VaultTokenRequest
            {
                Id = "1234",
                Type = TokenType.SETUPTOKEN,
            },
        },
    },
};

try
{
    ApiResponse<PaymentTokenResponse> result = await vaultController.PaymentTokensCreateAsync(paymentTokensCreateInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Request is not well-formed, syntactically incorrect, or violates schema. | [`ErrorException`](../../doc/models/error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`ErrorException`](../../doc/models/error-exception.md) |
| 404 | Request contains reference to resources that do not exist. | [`ErrorException`](../../doc/models/error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | An internal server error has occurred. | [`ErrorException`](../../doc/models/error-exception.md) |


# Customer Payment-Tokens Get

Returns all payment tokens for a customer.

```csharp
CustomerPaymentTokensGetAsync(
    Models.CustomerPaymentTokensGetInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Query, Required | A unique identifier representing a specific customer in merchant's/partner's system or records. |
| `pageSize` | `int?` | Query, Optional | A non-negative, non-zero integer indicating the maximum number of results to return at one time. |
| `page` | `int?` | Query, Optional | A non-negative, non-zero integer representing the page of the results. |
| `totalRequired` | `bool?` | Query, Optional | A boolean indicating total number of items (total_items) and pages (total_pages) are expected to be returned in the response. |

## Response Type

[`Task<ApiResponse<Models.CustomerVaultPaymentTokensResponse>>`](../../doc/models/customer-vault-payment-tokens-response.md)

## Example Usage

```csharp
CustomerPaymentTokensGetInput customerPaymentTokensGetInput = new CustomerPaymentTokensGetInput
{
    CustomerId = "customer_id8",
    PageSize = 5,
    Page = 1,
    TotalRequired = false,
};

try
{
    ApiResponse<CustomerVaultPaymentTokensResponse> result = await vaultController.CustomerPaymentTokensGetAsync(customerPaymentTokensGetInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Request is not well-formed, syntactically incorrect, or violates schema. | [`ErrorException`](../../doc/models/error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | An internal server error has occurred. | [`ErrorException`](../../doc/models/error-exception.md) |


# Payment-Tokens Get

Returns a readable representation of vaulted payment source associated with the payment token id.

```csharp
PaymentTokensGetAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | ID of the payment token. |

## Response Type

[`Task<ApiResponse<Models.PaymentTokenResponse>>`](../../doc/models/payment-token-response.md)

## Example Usage

```csharp
string id = "id0";
try
{
    ApiResponse<PaymentTokenResponse> result = await vaultController.PaymentTokensGetAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Authorization failed due to insufficient permissions. | [`ErrorException`](../../doc/models/error-exception.md) |
| 404 | The specified resource does not exist. | [`ErrorException`](../../doc/models/error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | An internal server error has occurred. | [`ErrorException`](../../doc/models/error-exception.md) |


# Payment-Tokens Delete

Delete the payment token associated with the payment token id.

```csharp
PaymentTokensDeleteAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | ID of the payment token. |

## Response Type

`Task`

## Example Usage

```csharp
string id = "id0";
try
{
    await vaultController.PaymentTokensDeleteAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Request is not well-formed, syntactically incorrect, or violates schema. | [`ErrorException`](../../doc/models/error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | An internal server error has occurred. | [`ErrorException`](../../doc/models/error-exception.md) |


# Setup-Tokens Create

Creates a Setup Token from the given payment source and adds it to the Vault of the associated customer.

```csharp
SetupTokensCreateAsync(
    Models.SetupTokensCreateInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `payPalRequestId` | `string` | Header, Required | The server stores keys for 3 hours. |
| `body` | [`SetupTokenRequest`](../../doc/models/setup-token-request.md) | Body, Required | Setup Token creation with a instrument type optional financial instrument details and customer_id. |

## Response Type

[`Task<ApiResponse<Models.SetupTokenResponse>>`](../../doc/models/setup-token-response.md)

## Example Usage

```csharp
SetupTokensCreateInput setupTokensCreateInput = new SetupTokensCreateInput
{
    PayPalRequestId = "PayPal-Request-Id6",
    Body = new SetupTokenRequest
    {
        PaymentSource = new SetupTokenRequestPaymentSource
        {
        },
    },
};

try
{
    ApiResponse<SetupTokenResponse> result = await vaultController.SetupTokensCreateAsync(setupTokensCreateInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Request is not well-formed, syntactically incorrect, or violates schema. | [`ErrorException`](../../doc/models/error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`ErrorException`](../../doc/models/error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | An internal server error has occurred. | [`ErrorException`](../../doc/models/error-exception.md) |


# Setup-Tokens Get

Returns a readable representation of temporarily vaulted payment source associated with the setup token id.

```csharp
SetupTokensGetAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | ID of the setup token. |

## Response Type

[`Task<ApiResponse<Models.SetupTokenResponse>>`](../../doc/models/setup-token-response.md)

## Example Usage

```csharp
string id = "id0";
try
{
    ApiResponse<SetupTokenResponse> result = await vaultController.SetupTokensGetAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Authorization failed due to insufficient permissions. | [`ErrorException`](../../doc/models/error-exception.md) |
| 404 | The specified resource does not exist. | [`ErrorException`](../../doc/models/error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | An internal server error has occurred. | [`ErrorException`](../../doc/models/error-exception.md) |

