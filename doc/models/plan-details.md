
# Plan Details

The plan details.

## Structure

`PlanDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProductId` | `string` | Optional | The ID for the product.<br><br>**Constraints**: *Minimum Length*: `22`, *Maximum Length*: `22`, *Pattern*: `^PROD-[A-Z0-9]*$` |
| `Name` | `string` | Optional | The plan name.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127`, *Pattern*: `^.*$` |
| `Description` | `string` | Optional | The detailed description of the plan.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127`, *Pattern*: `^.*$` |
| `BillingCycles` | [`List<SubscriptionBillingCycle>`](../../doc/models/subscription-billing-cycle.md) | Optional | An array of billing cycles for trial billing and regular billing. A plan can have at most two trial cycles and only one regular cycle.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `12` |
| `PaymentPreferences` | [`PaymentPreferences`](../../doc/models/payment-preferences.md) | Optional | The payment preferences for a subscription. |
| `MerchantPreferences` | [`MerchantPreferences`](../../doc/models/merchant-preferences.md) | Optional | The merchant preferences for a subscription. |
| `Taxes` | [`Taxes`](../../doc/models/taxes.md) | Optional | The tax details. |
| `QuantitySupported` | `bool?` | Optional | Indicates whether you can subscribe to this plan by providing a quantity for the goods or service.<br><br>**Default**: `false` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

PlanDetails planDetails = new PlanDetails
{
    ProductId = "product_id4",
    Name = "name8",
    Description = "description2",
    BillingCycles = new List<SubscriptionBillingCycle>
    {
        new SubscriptionBillingCycle
        {
            Frequency = new Frequency
            {
                IntervalUnit = IntervalUnit.Day,
                IntervalCount = 94,
            },
            TenureType = TenureType.Regular,
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
        new SubscriptionBillingCycle
        {
            Frequency = new Frequency
            {
                IntervalUnit = IntervalUnit.Day,
                IntervalCount = 94,
            },
            TenureType = TenureType.Regular,
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
        new SubscriptionBillingCycle
        {
            Frequency = new Frequency
            {
                IntervalUnit = IntervalUnit.Day,
                IntervalCount = 94,
            },
            TenureType = TenureType.Regular,
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
    PaymentPreferences = new PaymentPreferences
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
    QuantitySupported = false,
};
```

