
# Update Pricing Schemes Request

The update pricing scheme request details.

## Structure

`UpdatePricingSchemesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricingSchemes` | [`List<UpdatePricingScheme>`](../../doc/models/update-pricing-scheme.md) | Required | An array of pricing schemes.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `99` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

UpdatePricingSchemesRequest updatePricingSchemesRequest = new UpdatePricingSchemesRequest
{
    PricingSchemes = new List<UpdatePricingScheme>
    {
        new UpdatePricingScheme
        {
            BillingCycleSequence = 34,
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
        },
    },
};
```

