
# Refund Platform Fee

The platform or partner fee, commission, or brokerage fee that is associated with the transaction. Not a separate or isolated transaction leg from the external perspective. The platform fee is limited in scope and is always associated with the original payment for the purchase unit.

## Structure

`RefundPlatformFee`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Money`](../../doc/models/money.md) | Required | The currency and amount for a financial transaction, such as a balance or payment due. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

RefundPlatformFee refundPlatformFee = new RefundPlatformFee
{
    Amount = new Money
    {
        CurrencyCode = "currency_code6",
        MValue = "value0",
    },
};
```

