
# Subscription Amount with Breakdown

The breakdown details for the amount. Includes the gross, tax, fee, and shipping amounts.

## Structure

`SubscriptionAmountWithBreakdown`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GrossAmount` | [`Money`](../../doc/models/money.md) | Required | The currency and amount for a financial transaction, such as a balance or payment due. |
| `TotalItemAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `FeeAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `ShippingAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `TaxAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `NetAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

SubscriptionAmountWithBreakdown subscriptionAmountWithBreakdown = new SubscriptionAmountWithBreakdown
{
    GrossAmount = new Money
    {
        CurrencyCode = "currency_code4",
        MValue = "value0",
    },
    TotalItemAmount = new Money
    {
        CurrencyCode = "currency_code8",
        MValue = "value4",
    },
    FeeAmount = new Money
    {
        CurrencyCode = "currency_code2",
        MValue = "value4",
    },
    ShippingAmount = new Money
    {
        CurrencyCode = "currency_code0",
        MValue = "value6",
    },
    TaxAmount = new Money
    {
        CurrencyCode = "currency_code2",
        MValue = "value8",
    },
    NetAmount = new Money
    {
        CurrencyCode = "currency_code6",
        MValue = "value2",
    },
};
```

