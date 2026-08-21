
# Plan

The merchant level Recurring Billing plan metadata for the Billing Agreement.

## Structure

`Plan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingCycles` | [`List<BillingCycle>`](../../doc/models/billing-cycle.md) | Required | An array of billing cycles for trial billing and regular billing. A plan can have at most two trial cycles and only one regular cycle.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `3` |
| `OneTimeCharges` | [`OneTimeCharge`](../../doc/models/one-time-charge.md) | Required | The one-time charge info at the time of checkout. |
| `Name` | `string` | Optional | Name of the recurring plan.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127`, *Pattern*: `^[A-Za-z0-9() +',.:-]+$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

Plan plan = new Plan
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
    OneTimeCharges = new OneTimeCharge
    {
        TotalAmount = new Money
        {
            CurrencyCode = "currency_code2",
            MValue = "value8",
        },
        SetupFee = new Money
        {
            CurrencyCode = "currency_code8",
            MValue = "value4",
        },
        ShippingAmount = new Money
        {
            CurrencyCode = "currency_code0",
            MValue = "value6",
        },
        Taxes = new Money
        {
            CurrencyCode = "currency_code6",
            MValue = "value2",
        },
        ProductPrice = new Money
        {
            CurrencyCode = "currency_code6",
            MValue = "value2",
        },
        Subtotal = new Money
        {
            CurrencyCode = "currency_code2",
            MValue = "value8",
        },
    },
    Name = "name4",
};
```

