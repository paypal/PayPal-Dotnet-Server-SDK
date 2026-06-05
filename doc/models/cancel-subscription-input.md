
# Cancel Subscription Input

Input structure for the method CancelSubscription

## Structure

`CancelSubscriptionInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The ID of the subscription. |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `Body` | [`CancelSubscriptionRequest`](../../doc/models/cancel-subscription-request.md) | Optional | - |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CancelSubscriptionInput cancelSubscriptionInput = new CancelSubscriptionInput
{
    Id = "id0",
    Body = new CancelSubscriptionRequest
    {
        Reason = "reason8",
    },
};
```

