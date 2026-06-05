
# Capture Subscription Input

Input structure for the method CaptureSubscription

## Structure

`CaptureSubscriptionInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The ID of the subscription. |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `PaypalRequestId` | `string` | Optional | The server stores keys for 72 hours. |
| `Body` | [`CaptureSubscriptionRequest`](../../doc/models/capture-subscription-request.md) | Optional | - |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CaptureSubscriptionInput captureSubscriptionInput = new CaptureSubscriptionInput
{
    Id = "id0",
    PaypalRequestId = "PayPal-Request-Id6",
    Body = new CaptureSubscriptionRequest
    {
        Note = "note8",
        CaptureType = CaptureType.OutstandingBalance,
        Amount = new Money
        {
            CurrencyCode = "currency_code6",
            MValue = "value0",
        },
    },
};
```

