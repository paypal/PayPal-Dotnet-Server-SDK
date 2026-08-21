
# Pricing Tier

The pricing tier details.

## Structure

`PricingTier`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartingQuantity` | `string` | Required | The starting quantity for the tier.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `32`, *Pattern*: `^([0-9]+\|([0-9]+)?[.][0-9]+)$` |
| `EndingQuantity` | `string` | Optional | The ending quantity for the tier. Optional for the last tier.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `32`, *Pattern*: `^([0-9]+\|([0-9]+)?[.][0-9]+)$` |
| `Amount` | [`Money`](../../doc/models/money.md) | Required | The currency and amount for a financial transaction, such as a balance or payment due. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

PricingTier pricingTier = new PricingTier
{
    StartingQuantity = "starting_quantity6",
    Amount = new Money
    {
        CurrencyCode = "currency_code6",
        MValue = "value0",
    },
    EndingQuantity = "ending_quantity8",
};
```

