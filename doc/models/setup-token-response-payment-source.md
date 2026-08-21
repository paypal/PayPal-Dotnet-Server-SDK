
# Setup Token Response Payment Source

The setup payment method details.

## Structure

`SetupTokenResponsePaymentSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`SetupTokenResponseCard`](../../doc/models/setup-token-response-card.md) | Optional | - |
| `Paypal` | [`PaypalPaymentToken`](../../doc/models/paypal-payment-token.md) | Optional, Read-only | Full representation of a PayPal Payment Token. |
| `Venmo` | [`VenmoPaymentToken`](../../doc/models/venmo-payment-token.md) | Optional, Read-only | Full representation of a Venmo Payment Token. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

SetupTokenResponsePaymentSource setupTokenResponsePaymentSource = new SetupTokenResponsePaymentSource
{
    Card = new SetupTokenResponseCard
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
};
```

