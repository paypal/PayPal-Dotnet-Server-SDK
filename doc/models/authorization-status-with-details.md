
# Authorization Status with Details

The status fields and status details for an authorized payment.

## Structure

`AuthorizationStatusWithDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | [`AuthorizationStatus?`](../../doc/models/authorization-status.md) | Optional, Read-only | The status for the authorized payment. |
| `StatusDetails` | [`AuthorizationStatusDetails`](../../doc/models/authorization-status-details.md) | Optional | The details of the authorized payment status. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

AuthorizationStatusWithDetails authorizationStatusWithDetails = new AuthorizationStatusWithDetails
{
    StatusDetails = new AuthorizationStatusDetails
    {
        Reason = AuthorizationIncompleteReason.PendingReview,
    },
};
```

