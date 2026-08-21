
# Incentive Information

The incentive details.

## Structure

`IncentiveInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IncentiveDetails` | [`List<IncentiveDetails>`](../../doc/models/incentive-details.md) | Optional | An array of incentive details.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `32767` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

IncentiveInformation incentiveInformation = new IncentiveInformation
{
    IncentiveDetails = new List<IncentiveDetails>
    {
        new IncentiveDetails
        {
            IncentiveType = "incentive_type4",
            IncentiveCode = "incentive_code0",
            IncentiveAmount = new Money
            {
                CurrencyCode = "currency_code4",
                MValue = "value0",
            },
            IncentiveProgramCode = "incentive_program_code4",
        },
    },
};
```

