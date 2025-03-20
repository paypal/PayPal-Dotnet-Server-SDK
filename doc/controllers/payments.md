# Payments

Use the `/payments` resource to authorize, capture, void authorizations, and retrieve captures.

```csharp
PaymentsController paymentsController = client.PaymentsController;
```

## Class Name

`PaymentsController`

## Methods

* [Get Authorized Payment](../../doc/controllers/payments.md#get-authorized-payment)
* [Capture Authorized Payment](../../doc/controllers/payments.md#capture-authorized-payment)
* [Reauthorize Payment](../../doc/controllers/payments.md#reauthorize-payment)
* [Void Payment](../../doc/controllers/payments.md#void-payment)
* [Get Captured Payment](../../doc/controllers/payments.md#get-captured-payment)
* [Refund Captured Payment](../../doc/controllers/payments.md#refund-captured-payment)
* [Get Refund](../../doc/controllers/payments.md#get-refund)


# Get Authorized Payment

Shows details for an authorized payment, by ID.

```csharp
GetAuthorizedPaymentAsync(
    Models.GetAuthorizedPaymentInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorizationId` | `string` | Template, Required | The ID of the authorized payment for which to show details. |
| `paypalMockResponse` | `string` | Header, Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |
| `paypalAuthAssertion` | `string` | Header, Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion). Note:For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentAuthorization](../../doc/models/payment-authorization.md).

## Example Usage

```csharp
GetAuthorizedPaymentInput getAuthorizedPaymentInput = new GetAuthorizedPaymentInput
{
    AuthorizationId = "authorization_id8",
};

try
{
    ApiResponse<PaymentAuthorization> result = await paymentsController.GetAuthorizedPaymentAsync(getAuthorizedPaymentInput);
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
| 404 | The request failed because the resource does not exist. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | The request failed because an internal server error occurred. | `ApiException` |
| Default | The error response. | [`ErrorException`](../../doc/models/error-exception.md) |


# Capture Authorized Payment

Captures an authorized payment, by ID.

```csharp
CaptureAuthorizedPaymentAsync(
    Models.CaptureAuthorizedPaymentInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorizationId` | `string` | Template, Required | The PayPal-generated ID for the authorized payment to capture. |
| `paypalMockResponse` | `string` | Header, Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |
| `paypalRequestId` | `string` | Header, Optional | The server stores keys for 45 days. |
| `prefer` | `string` | Header, Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br>**Default**: `"return=minimal"` |
| `paypalAuthAssertion` | `string` | Header, Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion). Note:For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject. |
| `body` | [`CaptureRequest`](../../doc/models/capture-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CapturedPayment](../../doc/models/captured-payment.md).

## Example Usage

```csharp
CaptureAuthorizedPaymentInput captureAuthorizedPaymentInput = new CaptureAuthorizedPaymentInput
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
    ApiResponse<CapturedPayment> result = await paymentsController.CaptureAuthorizedPaymentAsync(captureAuthorizedPaymentInput);
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


# Reauthorize Payment

Reauthorizes an authorized PayPal account payment, by ID. To ensure that funds are still available, reauthorize a payment after its initial three-day honor period expires. Within the 29-day authorization period, you can issue multiple re-authorizations after the honor period expires. If 30 days have transpired since the date of the original authorization, you must create an authorized payment instead of reauthorizing the original authorized payment. A reauthorized payment itself has a new honor period of three days. You can reauthorize an authorized payment from 4 to 29 days after the 3-day honor period. The allowed amount depends on context and geography, for example in US it is up to 115% of the original authorized amount, not to exceed an increase of $75 USD. Supports only the `amount` request parameter. Note: This request is currently not supported for Partner use cases.

```csharp
ReauthorizePaymentAsync(
    Models.ReauthorizePaymentInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorizationId` | `string` | Template, Required | The PayPal-generated ID for the authorized payment to reauthorize. |
| `paypalRequestId` | `string` | Header, Optional | The server stores keys for 45 days. |
| `prefer` | `string` | Header, Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br>**Default**: `"return=minimal"` |
| `paypalAuthAssertion` | `string` | Header, Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion). Note:For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject. |
| `body` | [`ReauthorizeRequest`](../../doc/models/reauthorize-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentAuthorization](../../doc/models/payment-authorization.md).

## Example Usage

```csharp
ReauthorizePaymentInput reauthorizePaymentInput = new ReauthorizePaymentInput
{
    AuthorizationId = "authorization_id8",
    Prefer = "return=minimal",
};

try
{
    ApiResponse<PaymentAuthorization> result = await paymentsController.ReauthorizePaymentAsync(reauthorizePaymentInput);
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
| 404 | The request failed because the resource does not exist. | [`ErrorException`](../../doc/models/error-exception.md) |
| 422 | The request failed because it either is semantically incorrect or failed business validation. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | The request failed because an internal server error occurred. | `ApiException` |
| Default | The error response. | [`ErrorException`](../../doc/models/error-exception.md) |


# Void Payment

Voids, or cancels, an authorized payment, by ID. You cannot void an authorized payment that has been fully captured.

```csharp
VoidPaymentAsync(
    Models.VoidPaymentInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorizationId` | `string` | Template, Required | The PayPal-generated ID for the authorized payment to void. |
| `paypalMockResponse` | `string` | Header, Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |
| `paypalAuthAssertion` | `string` | Header, Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion). Note:For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject. |
| `paypalRequestId` | `string` | Header, Optional | The server stores keys for 45 days. |
| `prefer` | `string` | Header, Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br>**Default**: `"return=minimal"` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentAuthorization](../../doc/models/payment-authorization.md).

## Example Usage

```csharp
VoidPaymentInput voidPaymentInput = new VoidPaymentInput
{
    AuthorizationId = "authorization_id8",
    Prefer = "return=minimal",
};

try
{
    ApiResponse<PaymentAuthorization> result = await paymentsController.VoidPaymentAsync(voidPaymentInput);
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
| 409 | The request failed because a previous call for the given resource is in progress. | [`ErrorException`](../../doc/models/error-exception.md) |
| 422 | The request failed because it either is semantically incorrect or failed business validation. | [`ErrorException`](../../doc/models/error-exception.md) |
| 500 | The request failed because an internal server error occurred. | `ApiException` |
| Default | The error response. | [`ErrorException`](../../doc/models/error-exception.md) |


# Get Captured Payment

Shows details for a captured payment, by ID.

```csharp
GetCapturedPaymentAsync(
    Models.GetCapturedPaymentInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `captureId` | `string` | Template, Required | The PayPal-generated ID for the captured payment for which to show details. |
| `paypalMockResponse` | `string` | Header, Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CapturedPayment](../../doc/models/captured-payment.md).

## Example Usage

```csharp
GetCapturedPaymentInput getCapturedPaymentInput = new GetCapturedPaymentInput
{
    CaptureId = "capture_id2",
};

try
{
    ApiResponse<CapturedPayment> result = await paymentsController.GetCapturedPaymentAsync(getCapturedPaymentInput);
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


# Refund Captured Payment

Refunds a captured payment, by ID. For a full refund, include an empty payload in the JSON request body. For a partial refund, include an amount object in the JSON request body.

```csharp
RefundCapturedPaymentAsync(
    Models.RefundCapturedPaymentInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `captureId` | `string` | Template, Required | The PayPal-generated ID for the captured payment to refund. |
| `paypalMockResponse` | `string` | Header, Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |
| `paypalRequestId` | `string` | Header, Optional | The server stores keys for 45 days. |
| `prefer` | `string` | Header, Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br>**Default**: `"return=minimal"` |
| `paypalAuthAssertion` | `string` | Header, Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion). Note:For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject. |
| `body` | [`RefundRequest`](../../doc/models/refund-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Refund](../../doc/models/refund.md).

## Example Usage

```csharp
RefundCapturedPaymentInput refundCapturedPaymentInput = new RefundCapturedPaymentInput
{
    CaptureId = "capture_id2",
    Prefer = "return=minimal",
};

try
{
    ApiResponse<Refund> result = await paymentsController.RefundCapturedPaymentAsync(refundCapturedPaymentInput);
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


# Get Refund

Shows details for a refund, by ID.

```csharp
GetRefundAsync(
    Models.GetRefundInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `refundId` | `string` | Template, Required | The PayPal-generated ID for the refund for which to show details. |
| `paypalMockResponse` | `string` | Header, Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |
| `paypalAuthAssertion` | `string` | Header, Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion). Note:For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Refund](../../doc/models/refund.md).

## Example Usage

```csharp
GetRefundInput getRefundInput = new GetRefundInput
{
    RefundId = "refund_id4",
};

try
{
    ApiResponse<Refund> result = await paymentsController.GetRefundAsync(getRefundInput);
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

