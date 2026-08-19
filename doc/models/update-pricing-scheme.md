
# Update Pricing Scheme

The update pricing scheme request details.

## Structure

`UpdatePricingScheme`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingCycleSequence` | `int` | Required | The billing cycle sequence.<br><br>**Constraints**: `>= 1`, `<= 99` |
| `PricingScheme` | [`SubscriptionPricingScheme`](../../doc/models/subscription-pricing-scheme.md) | Required | The pricing scheme details. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

UpdatePricingScheme updatePricingScheme = new UpdatePricingScheme
{
    BillingCycleSequence = 99,
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
};
```

