
# Subscription Billing Cycle

The billing cycle details.

## Structure

`SubscriptionBillingCycle`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricingScheme` | [`SubscriptionPricingScheme`](../../doc/models/subscription-pricing-scheme.md) | Optional | The pricing scheme details. |
| `Frequency` | [`Frequency`](../../doc/models/frequency.md) | Required | The frequency of the billing cycle. |
| `TenureType` | [`TenureType`](../../doc/models/tenure-type.md) | Required | The tenure type of the billing cycle. In case of a plan having trial cycle, only 2 trial cycles are allowed per plan.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `24`, *Pattern*: `^[A-Z_]+$` |
| `Sequence` | `int` | Required | The order in which this cycle is to run among other billing cycles. For example, a trial billing cycle has a `sequence` of `1` while a regular billing cycle has a `sequence` of `2`, so that trial cycle runs before the regular cycle.<br><br>**Constraints**: `>= 1`, `<= 99` |
| `TotalCycles` | `int?` | Optional | The number of times this billing cycle gets executed. Trial billing cycles can only be executed a finite number of times (value between 1 and 999 for total_cycles). Regular billing cycles can be executed infinite times (value of 0 for total_cycles) or a finite number of times (value between 1 and 999 for total_cycles).<br><br>**Default**: `1`<br><br>**Constraints**: `>= 0`, `<= 999` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

SubscriptionBillingCycle subscriptionBillingCycle = new SubscriptionBillingCycle
{
    Frequency = new Frequency
    {
        IntervalUnit = IntervalUnit.Day,
        IntervalCount = 1,
    },
    TenureType = TenureType.Regular,
    Sequence = 99,
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
    TotalCycles = 1,
};
```

