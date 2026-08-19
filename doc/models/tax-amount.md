
# Tax Amount

The tax levied by a government on the purchase of goods or services.

## Structure

`TaxAmount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TaxAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

TaxAmount taxAmount = new TaxAmount
{
    TaxAmountProp = new Money
    {
        CurrencyCode = "currency_code2",
        MValue = "value8",
    },
};
```

