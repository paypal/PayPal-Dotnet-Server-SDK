
# Payment Token Request Payment Source

The payment method to vault with the instrument details.

## Structure

`PaymentTokenRequestPaymentSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`PaymentTokenRequestCard`](../../doc/models/payment-token-request-card.md) | Optional | A Resource representing a request to vault a Card. |
| `Token` | [`VaultTokenRequest`](../../doc/models/vault-token-request.md) | Optional | The Tokenized Payment Source representing a Request to Vault a Token. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

PaymentTokenRequestPaymentSource paymentTokenRequestPaymentSource = new PaymentTokenRequestPaymentSource
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
};
```

