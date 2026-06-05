
# Update Billing Plan Pricing Schemes Input

Input structure for the method UpdateBillingPlanPricingSchemes

## Structure

`UpdateBillingPlanPricingSchemesInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The ID for the plan. |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `Body` | [`UpdatePricingSchemesRequest`](../../doc/models/update-pricing-schemes-request.md) | Optional | - |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

UpdateBillingPlanPricingSchemesInput updateBillingPlanPricingSchemesInput = new UpdateBillingPlanPricingSchemesInput
{
    Id = "id0",
    Body = new UpdatePricingSchemesRequest
    {
        PricingSchemes = new List<UpdatePricingScheme>
        {
            new UpdatePricingScheme
            {
                BillingCycleSequence = 34,
                PricingScheme = new SubscriptionPricingScheme
                {
                    Version = 10,
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
    },
};
```

