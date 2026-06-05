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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.GetAuthorizedPaymentInput`](../../doc/models/get-authorized-payment-input.md) | Required | Input structure for the method GetAuthorizedPayment |

## Response Type

**200**: A successful request returns the HTTP 200 OK status code and a JSON response body that shows authorization details.

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
    Console.WriteLine(e.Message);
    if (e is ErrorException)
    {
       // TODO: Handle ErrorException exception here
    }
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


# Capture Authorized Payment

Captures an authorized payment, by ID.

```csharp
CaptureAuthorizedPaymentAsync(
    Models.CaptureAuthorizedPaymentInput input)
```

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.CaptureAuthorizedPaymentInput`](../../doc/models/capture-authorized-payment-input.md) | Required | Input structure for the method CaptureAuthorizedPayment |

## Response Type

**200**: A successful request returns the HTTP 200 OK status code and a JSON response body that shows captured payment details.

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
    Console.WriteLine(e.Message);
    if (e is ErrorException)
    {
       // TODO: Handle ErrorException exception here
    }
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

Reauthorizes an authorized PayPal account payment, by ID. To ensure that funds are still available, reauthorize a payment after its initial three-day honor period expires. Within the 29-day authorization period, you can issue multiple re-authorizations after the honor period expires. If 30 days have transpired since the date of the original authorization, you must create an authorized payment instead of reauthorizing the original authorized payment. A reauthorized payment itself has a new honor period of three days. You can reauthorize an authorized payment from 4 to 29 days after the 3-day honor period. The allowed amount depends on context and geography, for example in US it is up to 115% of the original authorized amount, not to exceed an increase of $75 USD. Supports only the `amount` request parameter.

```csharp
ReauthorizePaymentAsync(
    Models.ReauthorizePaymentInput input)
```

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ReauthorizePaymentInput`](../../doc/models/reauthorize-payment-input.md) | Required | Input structure for the method ReauthorizePayment |

## Response Type

**200**: A successful request returns the HTTP 200 OK status code and a JSON response body that shows the reauthorized payment details.

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
    Console.WriteLine(e.Message);
    if (e is ErrorException)
    {
       // TODO: Handle ErrorException exception here
    }
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


# Void Payment

Voids, or cancels, an authorized payment, by ID. You cannot void an authorized payment that has been fully captured.

```csharp
VoidPaymentAsync(
    Models.VoidPaymentInput input)
```

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.VoidPaymentInput`](../../doc/models/void-payment-input.md) | Required | Input structure for the method VoidPayment |

## Response Type

**200**: A successful request returns the HTTP 200 OK status code and a JSON response body that shows authorization details. This response is returned when the Prefer header is set to return=representation.

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
    Console.WriteLine(e.Message);
    if (e is ErrorException)
    {
       // TODO: Handle ErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.GetCapturedPaymentInput`](../../doc/models/get-captured-payment-input.md) | Required | Input structure for the method GetCapturedPayment |

## Response Type

**200**: A successful request returns the HTTP 200 OK status code and a JSON response body that shows captured payment details.

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
    Console.WriteLine(e.Message);
    if (e is ErrorException)
    {
       // TODO: Handle ErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.RefundCapturedPaymentInput`](../../doc/models/refund-captured-payment-input.md) | Required | Input structure for the method RefundCapturedPayment |

## Response Type

**200**: A successful request returns the HTTP 200 OK status code and a JSON response body that shows refund details.

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
    Console.WriteLine(e.Message);
    if (e is ErrorException)
    {
       // TODO: Handle ErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.GetRefundInput`](../../doc/models/get-refund-input.md) | Required | Input structure for the method GetRefund |

## Response Type

**200**: A successful request returns the HTTP 200 OK status code and a JSON response body that shows refund details.

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
    Console.WriteLine(e.Message);
    if (e is ErrorException)
    {
       // TODO: Handle ErrorException exception here
    }
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

