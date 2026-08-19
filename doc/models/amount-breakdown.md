
# Amount Breakdown

The breakdown of the amount. Breakdown provides details such as total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.

## Structure

`AmountBreakdown`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ItemTotal` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Shipping` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Handling` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `TaxTotal` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Insurance` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `ShippingDiscount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Discount` | [`Money`](../../doc/models/money.md) | Optional | The discount amount and currency code. For list of supported currencies and decimal precision, see the PayPal REST APIs Currency Codes. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

AmountBreakdown amountBreakdown = new AmountBreakdown
{
    ItemTotal = new Money
    {
        CurrencyCode = "currency_code0",
        MValue = "value6",
    },
    Shipping = new Money
    {
        CurrencyCode = "currency_code0",
        MValue = "value6",
    },
    Handling = new Money
    {
        CurrencyCode = "currency_code2",
        MValue = "value8",
    },
    TaxTotal = new Money
    {
        CurrencyCode = "currency_code4",
        MValue = "value0",
    },
    Insurance = new Money
    {
        CurrencyCode = "currency_code2",
        MValue = "value8",
    },
};
```

