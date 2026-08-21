
# Billing Cycle Override

The billing cycle details to override at subscription level. The subscription billing cycle definition has to adhere to the plan billing cycle definition.

## Structure

`BillingCycleOverride`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricingScheme` | [`SubscriptionPricingScheme`](../../doc/models/subscription-pricing-scheme.md) | Optional | The pricing scheme details. |
| `Sequence` | `int` | Required | The order in which this cycle is to run among other billing cycles. For example, a trial billing cycle has a `sequence` of `1` while a regular billing cycle has a `sequence` of `2`, so that trial cycle runs before the regular cycle.<br><br>**Constraints**: `>= 1`, `<= 99` |
| `TotalCycles` | `int?` | Optional | The number of times this billing cycle gets executed. Trial billing cycles can only be executed a finite number of times (value between 1 and 999 for total_cycles). Regular billing cycles can be executed infinite times (value of 0 for total_cycles) or a finite number of times (value between 1 and 999 for total_cycles).<br><br>**Constraints**: `>= 0`, `<= 999` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

BillingCycleOverride billingCycleOverride = new BillingCycleOverride
{
    Sequence = 20,
    PricingScheme = new SubscriptionPricingScheme
    {
        FixedPrice = new Money
        {
            CurrencyCode = "currency_code4",
            MValue = "value0",
        },
        PricingModel = SubscriptionPricingModel.Volume,
        Tiers = new List<PricingTier>
        {
            new PricingTier
            {
                StartingQuantity = "starting_quantity8",
                Amount = new Money
                {
                    CurrencyCode = "currency_code6",
                    MValue = "value0",
                },
                EndingQuantity = "ending_quantity6",
            },
            new PricingTier
            {
                StartingQuantity = "starting_quantity8",
                Amount = new Money
                {
                    CurrencyCode = "currency_code6",
                    MValue = "value0",
                },
                EndingQuantity = "ending_quantity6",
            },
            new PricingTier
            {
                StartingQuantity = "starting_quantity8",
                Amount = new Money
                {
                    CurrencyCode = "currency_code6",
                    MValue = "value0",
                },
                EndingQuantity = "ending_quantity6",
            },
        },
        CreateTime = "create_time4",
    },
    TotalCycles = 210,
};
```

