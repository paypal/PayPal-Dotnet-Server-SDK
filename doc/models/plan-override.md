
# Plan Override

An inline plan object to customise the subscription. You can override plan level default attributes by providing customised values for the subscription in this object.

## Structure

`PlanOverride`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingCycles` | [`List<BillingCycleOverride>`](../../doc/models/billing-cycle-override.md) | Optional | An array of billing cycles for trial billing and regular billing. The subscription billing cycle definition has to adhere to the plan billing cycle definition.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `12` |
| `PaymentPreferences` | [`PaymentPreferencesOverride`](../../doc/models/payment-preferences-override.md) | Optional | The payment preferences to override at subscription level. |
| `Taxes` | [`TaxesOverride`](../../doc/models/taxes-override.md) | Optional | The tax details. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

PlanOverride planOverride = new PlanOverride
{
    BillingCycles = new List<BillingCycleOverride>
    {
        new BillingCycleOverride
        {
            Sequence = 8,
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
            TotalCycles = 198,
        },
        new BillingCycleOverride
        {
            Sequence = 8,
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
            TotalCycles = 198,
        },
        new BillingCycleOverride
        {
            Sequence = 8,
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
            TotalCycles = 198,
        },
    },
    PaymentPreferences = new PaymentPreferencesOverride
    {
        AutoBillOutstanding = false,
        SetupFee = new Money
        {
            CurrencyCode = "currency_code8",
            MValue = "value4",
        },
        SetupFeeFailureAction = SetupFeeFailureAction.Continue,
        PaymentFailureThreshold = 104,
    },
    Taxes = new TaxesOverride
    {
        Percentage = "percentage8",
        Inclusive = false,
    },
};
```

