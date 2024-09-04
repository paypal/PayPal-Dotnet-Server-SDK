# Payments

Use the `/payments` resource to authorize, capture, void authorizations, and retrieve captures.

```csharp
PaymentsController paymentsController = client.PaymentsController;
```

## Class Name

`PaymentsController`

## Methods

* [Authorizations Get](../../doc/controllers/payments.md#authorizations-get)
* [Authorizations Capture](../../doc/controllers/payments.md#authorizations-capture)
* [Authorizations Reauthorize](../../doc/controllers/payments.md#authorizations-reauthorize)
* [Authorizations Void](../../doc/controllers/payments.md#authorizations-void)
* [Captures Get](../../doc/controllers/payments.md#captures-get)
* [Captures Refund](../../doc/controllers/payments.md#captures-refund)
* [Refunds Get](../../doc/controllers/payments.md#refunds-get)


# Authorizations Get

Shows details for an authorized payment, by ID.

```csharp
AuthorizationsGetAsync(
    string authorizationId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorizationId` | `string` | Template, Required | The ID of the authorized payment for which to show details. |

## Response Type

[`Task<ApiResponse<Models.PaymentAuthorization>>`](../../doc/models/payment-authorization.md)

## Example Usage

```csharp
string authorizationId = "authorization_id8";
try
{
    ApiResponse<PaymentAuthorization> result = await paymentsController.AuthorizationsGetAsync(authorizationId);
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
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`ErrorException`](../../doc/models/error-exception.md) |
| 403 | The request failed because the caller has insufficient permissions. | [`ErrorException`](../../doc/models/error-exception.md) |
| 404 | The request failed because the resource does not exist. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | The request failed because an internal server error occurred. | `ApiException` |
| Default | The error response. | [`ErrorException`](../../doc/models/error-exception.md) |


# Authorizations Capture

Captures an authorized payment, by ID.

```csharp
AuthorizationsCaptureAsync(
    Models.AuthorizationsCaptureInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorizationId` | `string` | Template, Required | The PayPal-generated ID for the authorized payment to capture. |
| `payPalRequestId` | `string` | Header, Optional | The server stores keys for 45 days. |
| `prefer` | `string` | Header, Optional | The preferred server response upon successful completion of the request. Value is:<ul><li><code>return=minimal</code>. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the <code>id</code>, <code>status</code> and HATEOAS links.</li><li><code>return=representation</code>. The server returns a complete resource representation, including the current state of the resource.</li></ul> |
| `body` | [`CaptureRequest`](../../doc/models/capture-request.md) | Body, Optional | - |

## Response Type

[`Task<ApiResponse<Models.CapturedPayment>>`](../../doc/models/captured-payment.md)

## Example Usage

```csharp
AuthorizationsCaptureInput authorizationsCaptureInput = new AuthorizationsCaptureInput
{
    AuthorizationId = "authorization_id8",
    Prefer = "return=minimal",
    Body = new CaptureRequest
    {
        FinalCapture = false,
    },
};

try
{
    ApiResponse<CapturedPayment> result = await paymentsController.AuthorizationsCaptureAsync(authorizationsCaptureInput);
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
| 400 | The request failed because it is not well-formed or is syntactically incorrect or violates schema. | [`ErrorException`](../../doc/models/error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`ErrorException`](../../doc/models/error-exception.md) |
| 403 | The request failed because the caller has insufficient permissions. | [`ErrorException`](../../doc/models/error-exception.md) |
| 404 | The request failed because the resource does not exist. | [`ErrorException`](../../doc/models/error-exception.md) |
| 409 | The server has detected a conflict while processing this request. | [`ErrorException`](../../doc/models/error-exception.md) |
| 422 | The request failed because it is semantically incorrect or failed business validation. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | The request failed because an internal server error occurred. | `ApiException` |
| Default | The error response. | [`ErrorException`](../../doc/models/error-exception.md) |


# Authorizations Reauthorize

Reauthorizes an authorized PayPal account payment, by ID. To ensure that funds are still available, reauthorize a payment after its initial three-day honor period expires. Within the 29-day authorization period, you can issue multiple re-authorizations after the honor period expires.<br/><br/>If 30 days have transpired since the date of the original authorization, you must create an authorized payment instead of reauthorizing the original authorized payment.<br/><br/>A reauthorized payment itself has a new honor period of three days.<br/><br/>You can reauthorize an authorized payment from 4 to 29 days after the 3-day honor period. The allowed amount depends on context and geography, for example in US it is up to 115% of the original authorized amount, not to exceed an increase of $75 USD.<br/><br/>Supports only the `amount` request parameter.<blockquote><strong>Note:</strong> This request is currently not supported for Partner use cases.</blockquote>

```csharp
AuthorizationsReauthorizeAsync(
    Models.AuthorizationsReauthorizeInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorizationId` | `string` | Template, Required | The PayPal-generated ID for the authorized payment to reauthorize. |
| `payPalRequestId` | `string` | Header, Optional | The server stores keys for 45 days. |
| `prefer` | `string` | Header, Optional | The preferred server response upon successful completion of the request. Value is:<ul><li><code>return=minimal</code>. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the <code>id</code>, <code>status</code> and HATEOAS links.</li><li><code>return=representation</code>. The server returns a complete resource representation, including the current state of the resource.</li></ul> |
| `body` | [`ReauthorizeRequest`](../../doc/models/reauthorize-request.md) | Body, Optional | - |

## Response Type

[`Task<ApiResponse<Models.PaymentAuthorization>>`](../../doc/models/payment-authorization.md)

## Example Usage

```csharp
AuthorizationsReauthorizeInput authorizationsReauthorizeInput = new AuthorizationsReauthorizeInput
{
    AuthorizationId = "authorization_id8",
    Prefer = "return=minimal",
};

try
{
    ApiResponse<PaymentAuthorization> result = await paymentsController.AuthorizationsReauthorizeAsync(authorizationsReauthorizeInput);
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
| 400 | The request failed because it is not well-formed or is syntactically incorrect or violates schema. | [`ErrorException`](../../doc/models/error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`ErrorException`](../../doc/models/error-exception.md) |
| 403 | The request failed because the caller has insufficient permissions. | [`ErrorException`](../../doc/models/error-exception.md) |
| 404 | The request failed because the resource does not exist. | [`ErrorException`](../../doc/models/error-exception.md) |
| 422 | The request failed because it either is semantically incorrect or failed business validation. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | The request failed because an internal server error occurred. | `ApiException` |
| Default | The error response. | [`ErrorException`](../../doc/models/error-exception.md) |


# Authorizations Void

Voids, or cancels, an authorized payment, by ID. You cannot void an authorized payment that has been fully captured.

```csharp
AuthorizationsVoidAsync(
    Models.AuthorizationsVoidInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorizationId` | `string` | Template, Required | The PayPal-generated ID for the authorized payment to void. |
| `payPalAuthAssertion` | `string` | Header, Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion).<blockquote><strong>Note:</strong>For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject.</blockquote> |
| `prefer` | `string` | Header, Optional | The preferred server response upon successful completion of the request. Value is:<ul><li><code>return=minimal</code>. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the <code>id</code>, <code>status</code> and HATEOAS links.</li><li><code>return=representation</code>. The server returns a complete resource representation, including the current state of the resource.</li></ul> |

## Response Type

[`Task<ApiResponse<Models.PaymentAuthorization>>`](../../doc/models/payment-authorization.md)

## Example Usage

```csharp
AuthorizationsVoidInput authorizationsVoidInput = new AuthorizationsVoidInput
{
    AuthorizationId = "authorization_id8",
    Prefer = "return=minimal",
};

try
{
    ApiResponse<PaymentAuthorization> result = await paymentsController.AuthorizationsVoidAsync(authorizationsVoidInput);
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
| 400 | The request failed because it is not well-formed or is syntactically incorrect or violates schema. | [`ErrorException`](../../doc/models/error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`ErrorException`](../../doc/models/error-exception.md) |
| 403 | The request failed because the caller has insufficient permissions. | [`ErrorException`](../../doc/models/error-exception.md) |
| 404 | The request failed because the resource does not exist. | [`ErrorException`](../../doc/models/error-exception.md) |
| 409 | The request failed because a previous call for the given resource is in progress. | [`ErrorException`](../../doc/models/error-exception.md) |
| 422 | The request failed because it either is semantically incorrect or failed business validation. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | The request failed because an internal server error occurred. | `ApiException` |
| Default | The error response. | [`ErrorException`](../../doc/models/error-exception.md) |


# Captures Get

Shows details for a captured payment, by ID.

```csharp
CapturesGetAsync(
    string captureId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `captureId` | `string` | Template, Required | The PayPal-generated ID for the captured payment for which to show details. |

## Response Type

[`Task<ApiResponse<Models.CapturedPayment>>`](../../doc/models/captured-payment.md)

## Example Usage

```csharp
string captureId = "capture_id2";
try
{
    ApiResponse<CapturedPayment> result = await paymentsController.CapturesGetAsync(captureId);
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
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`ErrorException`](../../doc/models/error-exception.md) |
| 403 | The request failed because the caller has insufficient permissions. | [`ErrorException`](../../doc/models/error-exception.md) |
| 404 | The request failed because the resource does not exist. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | The request failed because an internal server error occurred. | `ApiException` |
| Default | The error response. | [`ErrorException`](../../doc/models/error-exception.md) |


# Captures Refund

Refunds a captured payment, by ID. For a full refund, include an empty payload in the JSON request body. For a partial refund, include an <code>amount</code> object in the JSON request body.

```csharp
CapturesRefundAsync(
    Models.CapturesRefundInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `captureId` | `string` | Template, Required | The PayPal-generated ID for the captured payment to refund. |
| `payPalRequestId` | `string` | Header, Optional | The server stores keys for 45 days. |
| `prefer` | `string` | Header, Optional | The preferred server response upon successful completion of the request. Value is:<ul><li><code>return=minimal</code>. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the <code>id</code>, <code>status</code> and HATEOAS links.</li><li><code>return=representation</code>. The server returns a complete resource representation, including the current state of the resource.</li></ul> |
| `payPalAuthAssertion` | `string` | Header, Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion).<blockquote><strong>Note:</strong>For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject.</blockquote> |
| `body` | [`RefundRequest`](../../doc/models/refund-request.md) | Body, Optional | - |

## Response Type

[`Task<ApiResponse<Models.Refund>>`](../../doc/models/refund.md)

## Example Usage

```csharp
CapturesRefundInput capturesRefundInput = new CapturesRefundInput
{
    CaptureId = "capture_id2",
    Prefer = "return=minimal",
};

try
{
    ApiResponse<Refund> result = await paymentsController.CapturesRefundAsync(capturesRefundInput);
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
| 400 | The request failed because it is not well-formed or is syntactically incorrect or violates schema. | [`ErrorException`](../../doc/models/error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`ErrorException`](../../doc/models/error-exception.md) |
| 403 | The request failed because the caller has insufficient permissions. | [`ErrorException`](../../doc/models/error-exception.md) |
| 404 | The request failed because the resource does not exist. | [`ErrorException`](../../doc/models/error-exception.md) |
| 409 | The request failed because a previous call for the given resource is in progress. | [`ErrorException`](../../doc/models/error-exception.md) |
| 422 | The request failed because it either is semantically incorrect or failed business validation. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | The request failed because an internal server error occurred. | `ApiException` |
| Default | The error response. | [`ErrorException`](../../doc/models/error-exception.md) |


# Refunds Get

Shows details for a refund, by ID.

```csharp
RefundsGetAsync(
    string refundId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `refundId` | `string` | Template, Required | The PayPal-generated ID for the refund for which to show details. |

## Response Type

[`Task<ApiResponse<Models.Refund>>`](../../doc/models/refund.md)

## Example Usage

```csharp
string refundId = "refund_id4";
try
{
    ApiResponse<Refund> result = await paymentsController.RefundsGetAsync(refundId);
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
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`ErrorException`](../../doc/models/error-exception.md) |
| 403 | The request failed because the caller has insufficient permissions. | [`ErrorException`](../../doc/models/error-exception.md) |
| 404 | The request failed because the resource does not exist. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | The request failed because an internal server error occurred. | `ApiException` |
| Default | The error response. | [`ErrorException`](../../doc/models/error-exception.md) |

