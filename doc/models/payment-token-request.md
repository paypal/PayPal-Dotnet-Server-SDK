
# Payment Token Request

Payment Token Request where the `source` defines the type of instrument to be stored.

## Structure

`PaymentTokenRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customer` | [`Customer`](../../doc/models/customer.md) | Optional | This object defines a customer in your system. Use it to manage customer profiles, save payment methods and contact details. |
| `PaymentSource` | [`PaymentTokenRequestPaymentSource`](../../doc/models/payment-token-request-payment-source.md) | Required | The payment method to vault with the instrument details. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

PaymentTokenRequest paymentTokenRequest = new PaymentTokenRequest
{
    PaymentSource = new PaymentTokenRequestPaymentSource
    {
        Card = new PaymentTokenRequestCard
        {
            Name = "name6",
            Number = "number6",
            Expiry = "expiry4",
            SecurityCode = "security_code8",
            Brand = CardBrand.CbNationale,
        },
        Token = new VaultTokenRequest
        {
            Id = "id6",
            Type = VaultTokenRequestType.SetupToken,
        },
    },
    Customer = new Customer
    {
        Id = "id0",
        MerchantCustomerId = "merchant_customer_id2",
    },
};
```

