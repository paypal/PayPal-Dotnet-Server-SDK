
# One Time Charge

The one-time charge info at the time of checkout.

## Structure

`OneTimeCharge`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SetupFee` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `ShippingAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Taxes` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `ProductPrice` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Subtotal` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `TotalAmount` | [`Money`](../../doc/models/money.md) | Required | The currency and amount for a financial transaction, such as a balance or payment due. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

OneTimeCharge oneTimeCharge = new OneTimeCharge
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
};
```

