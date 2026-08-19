
# Payment Supplementary Data

The supplementary data.

## Structure

`PaymentSupplementaryData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RelatedIds` | [`RelatedIdentifiers`](../../doc/models/related-identifiers.md) | Optional | Identifiers related to a specific resource. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

PaymentSupplementaryData paymentSupplementaryData = new PaymentSupplementaryData
{
    RelatedIds = new RelatedIdentifiers
    {
        OrderId = "order_id2",
        AuthorizationId = "authorization_id0",
        CaptureId = "capture_id0",
    },
};
```

