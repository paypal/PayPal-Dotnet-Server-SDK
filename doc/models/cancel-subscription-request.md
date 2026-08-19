
# Cancel Subscription Request

The cancel subscription request details.

## Structure

`CancelSubscriptionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Reason` | `string` | Required | The reason for the cancellation of a subscription.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `128`, *Pattern*: `^.*$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CancelSubscriptionRequest cancelSubscriptionRequest = new CancelSubscriptionRequest
{
    Reason = "reason0",
};
```

