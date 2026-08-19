
# Cobranded Card

Details about the merchant cobranded card used for order purchase.

## Structure

`CobrandedCard`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Labels` | `List<string>` | Optional | Array of labels for the cobranded card.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `25`, *Minimum Length*: `1`, *Maximum Length*: `256` |
| `Payee` | [`PayeeBase`](../../doc/models/payee-base.md) | Optional | The details for the merchant who receives the funds and fulfills the order. The merchant is also known as the payee. |
| `Amount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

CobrandedCard cobrandedCard = new CobrandedCard
{
    Labels = new List<string>
    {
        "labels2",
    },
    Payee = new PayeeBase
    {
        EmailAddress = "email_address4",
        MerchantId = "merchant_id6",
    },
    Amount = new Money
    {
        CurrencyCode = "currency_code6",
        MValue = "value0",
    },
};
```

