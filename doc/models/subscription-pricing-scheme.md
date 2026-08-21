
# Subscription Pricing Scheme

The pricing scheme details.

## Structure

`SubscriptionPricingScheme`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Version` | `int?` | Optional, Read-only | The version of the pricing scheme.<br><br>**Constraints**: `>= 0`, `<= 999` |
| `FixedPrice` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `PricingModel` | [`SubscriptionPricingModel?`](../../doc/models/subscription-pricing-model.md) | Optional | The pricing model for tiered plan. The `tiers` parameter is required.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `24`, *Pattern*: `^[A-Z_]+$` |
| `Tiers` | [`List<PricingTier>`](../../doc/models/pricing-tier.md) | Optional | An array of pricing tiers which are used for billing volume/tiered plans. pricing_model field has to be specified.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `32` |
| `CreateTime` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `UpdateTime` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

SubscriptionPricingScheme subscriptionPricingScheme = new SubscriptionPricingScheme
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
    },
    CreateTime = "create_time2",
};
```

