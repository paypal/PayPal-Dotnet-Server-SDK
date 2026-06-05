
# Get Captured Payment Input

Input structure for the method GetCapturedPayment

## Structure

`GetCapturedPaymentInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CaptureId` | `string` | Required | The PayPal-generated ID for the captured payment for which to show details. |
| `PaypalMockResponse` | `string` | Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

GetCapturedPaymentInput getCapturedPaymentInput = new GetCapturedPaymentInput
{
    CaptureId = "capture_id2",
    PaypalMockResponse = "PayPal-Mock-Response0",
};
```

