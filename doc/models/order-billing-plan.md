
# Order Billing Plan

Metadata for merchant-managed recurring billing plans. Valid only during the saved payment method token or billing agreement creation.

## Structure

`OrderBillingPlan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingCycles` | [`List<BillingCycle>`](../../doc/models/billing-cycle.md) | Required | An array of billing cycles for trial billing and regular billing. A plan can have at most two trial cycles and only one regular cycle.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `3` |
| `SetupFee` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Name` | `string` | Optional | Name of the recurring plan.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127`, *Pattern*: `^[A-Za-z0-9() +',.:-]+$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

OrderBillingPlan orderBillingPlan = new OrderBillingPlan
{
    BillingCycles = new List<BillingCycle>
    {
        new BillingCycle
        {
            TenureType = TenureType.Regular,
            PricingScheme = new PricingScheme
            {
                PricingModel = PricingModel.AutoReload,
                Price = new Money
                {
                    CurrencyCode = "currency_code8",
                    MValue = "value4",
                },
                ReloadThresholdAmount = new Money
                {
                    CurrencyCode = "currency_code0",
                    MValue = "value6",
                },
            },
            TotalCycles = 1,
            Sequence = 1,
            StartDate = "start_date6",
            Frequency = new CycleFrequency
            {
                IntervalUnit = FrequencyIntervalUnit.Lifetime,
                IntervalCount = 94,
            },
        },
    },
    SetupFee = new Money
    {
        CurrencyCode = "currency_code8",
        MValue = "value4",
    },
    Name = "name6",
};
```

