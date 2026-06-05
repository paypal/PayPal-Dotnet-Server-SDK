
# Get Subscription Input

Input structure for the method GetSubscription

## Structure

`GetSubscriptionInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The ID of the subscription. |
| `Fields` | `string` | Optional | List of fields that are to be returned in the response. Possible value for fields are last_failed_payment and plan.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `100` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

GetSubscriptionInput getSubscriptionInput = new GetSubscriptionInput
{
    Id = "id0",
    Fields = "fields8",
};
```

