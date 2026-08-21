
# Payment Token Response Payment Source

The vaulted payment method details.

## Structure

`PaymentTokenResponsePaymentSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`CardPaymentTokenEntity`](../../doc/models/card-payment-token-entity.md) | Optional | Full representation of a Card Payment Token including network token. |
| `Paypal` | [`PaypalPaymentToken`](../../doc/models/paypal-payment-token.md) | Optional, Read-only | Full representation of a PayPal Payment Token. |
| `Venmo` | [`VenmoPaymentToken`](../../doc/models/venmo-payment-token.md) | Optional, Read-only | Full representation of a Venmo Payment Token. |
| `ApplePay` | [`ApplePayPaymentToken`](../../doc/models/apple-pay-payment-token.md) | Optional | A resource representing a response for Apple Pay. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

PaymentTokenResponsePaymentSource paymentTokenResponsePaymentSource = new PaymentTokenResponsePaymentSource
{
    Card = new CardPaymentTokenEntity
    {
        Name = "name6",
        Brand = CardBrand.CbNationale,
        Expiry = "expiry4",
        BillingAddress = new CardResponseAddress
        {
            CountryCode = "country_code8",
            AddressLine1 = "address_line_12",
            AddressLine2 = "address_line_28",
            AdminArea2 = "admin_area_28",
            AdminArea1 = "admin_area_14",
            PostalCode = "postal_code0",
        },
    },
    ApplePay = new ApplePayPaymentToken
    {
        Card = new ApplePayCard
        {
            Name = "name6",
            Type = CardType.Unknown,
            Brand = CardBrand.CbNationale,
            BillingAddress = new Address
            {
                CountryCode = "country_code8",
                AddressLine1 = "address_line_12",
                AddressLine2 = "address_line_28",
                AdminArea2 = "admin_area_28",
                AdminArea1 = "admin_area_14",
                PostalCode = "postal_code0",
            },
        },
    },
};
```

