
# Net Amount Breakdown Item

The net amount. Returned when the currency of the refund is different from the currency of the PayPal account where the merchant holds their funds.

## Structure

`NetAmountBreakdownItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PayableAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `ConvertedAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `ExchangeRate` | [`ExchangeRate`](../../doc/models/exchange-rate.md) | Optional, Read-only | The exchange rate that determines the amount to convert from one currency to another currency. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

NetAmountBreakdownItem netAmountBreakdownItem = new NetAmountBreakdownItem
{
    PayableAmount = new Money
    {
        CurrencyCode = "currency_code8",
        MValue = "value4",
    },
    ConvertedAmount = new Money
    {
        CurrencyCode = "currency_code0",
        MValue = "value6",
    },
};
```

