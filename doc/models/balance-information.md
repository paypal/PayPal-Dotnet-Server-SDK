
# Balance Information

The Balance information.

## Structure

`BalanceInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | `string` | Required | The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/) that identifies the currency.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3` |
| `Primary` | `bool?` | Optional | Optional field representing if the currency is primary currency or not. |
| `TotalBalance` | [`Money`](../../doc/models/money.md) | Required | The currency and amount for a financial transaction, such as a balance or payment due. |
| `AvailableBalance` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `WithheldBalance` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

BalanceInformation balanceInformation = new BalanceInformation
{
    Currency = "currency2",
    TotalBalance = new Money
    {
        CurrencyCode = "currency_code6",
        MValue = "value2",
    },
    Primary = false,
    AvailableBalance = new Money
    {
        CurrencyCode = "currency_code8",
        MValue = "value4",
    },
    WithheldBalance = new Money
    {
        CurrencyCode = "currency_code2",
        MValue = "value8",
    },
};
```

