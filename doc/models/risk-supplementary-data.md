
# Risk Supplementary Data

Additional information necessary to evaluate the risk profile of a transaction.

## Structure

`RiskSupplementaryData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customer` | [`ParticipantMetadata`](../../doc/models/participant-metadata.md) | Optional | Profile information of the sender or receiver. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

RiskSupplementaryData riskSupplementaryData = new RiskSupplementaryData
{
    Customer = new ParticipantMetadata
    {
        IpAddress = "ip_address0",
    },
};
```

