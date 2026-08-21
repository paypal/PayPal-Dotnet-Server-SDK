
# Platform Fee

The platform or partner fee, commission, or brokerage fee that is associated with the transaction. Not a separate or isolated transaction leg from the external perspective. The platform fee is limited in scope and is always associated with the original payment for the purchase unit.

## Structure

`PlatformFee`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Money`](../../doc/models/money.md) | Required | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Payee` | [`PayeeBase`](../../doc/models/payee-base.md) | Optional | The details for the merchant who receives the funds and fulfills the order. The merchant is also known as the payee. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

PlatformFee platformFee = new PlatformFee
{
    Amount = new Money
    {
        CurrencyCode = "currency_code6",
        MValue = "value0",
    },
    Payee = new PayeeBase
    {
        EmailAddress = "email_address4",
        MerchantId = "merchant_id6",
    },
};
```

