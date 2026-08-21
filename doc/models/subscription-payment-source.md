
# Subscription Payment Source

The payment source definition. To be eligible to create subscription using debit or credit card, you will need to sign up here (https://www.paypal.com/bizsignup/entry/product/ppcp). Please note, its available only for non-3DS cards and for merchants in US and AU regions.

## Structure

`SubscriptionPaymentSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`SubscriptionCardRequest`](../../doc/models/subscription-card-request.md) | Optional | The payment card to use to fund a payment. Can be a credit or debit card. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

SubscriptionPaymentSource subscriptionPaymentSource = new SubscriptionPaymentSource
{
    Card = new SubscriptionCardRequest
    {
        Name = "name6",
        Number = "number6",
        Expiry = "expiry4",
        SecurityCode = "security_code8",
        Type = CardType.Unknown,
    },
};
```

