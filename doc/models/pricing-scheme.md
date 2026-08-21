
# Pricing Scheme

The pricing scheme details.

## Structure

`PricingScheme`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Price` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `PricingModel` | [`PricingModel`](../../doc/models/pricing-model.md) | Required | The pricing model for the billing cycle.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `24`, *Pattern*: `^[A-Z_]+$` |
| `ReloadThresholdAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

PricingScheme pricingScheme = new PricingScheme
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
};
```

