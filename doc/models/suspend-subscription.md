
# Suspend Subscription

The suspend subscription request details.

## Structure

`SuspendSubscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Reason` | `string` | Required | The reason for suspension of the Subscription.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `128`, *Pattern*: `^.*$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

SuspendSubscription suspendSubscription = new SuspendSubscription
{
    Reason = "reason4",
};
```

