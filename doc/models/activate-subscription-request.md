
# Activate Subscription Request

The activate subscription request details.

## Structure

`ActivateSubscriptionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Reason` | `string` | Optional | The reason for activation of a subscription. Required to reactivate the subscription.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `128`, *Pattern*: `^.*$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

ActivateSubscriptionRequest activateSubscriptionRequest = new ActivateSubscriptionRequest
{
    Reason = "reason6",
};
```

