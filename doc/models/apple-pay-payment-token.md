
# Apple Pay Payment Token

A resource representing a response for Apple Pay.

## Structure

`ApplePayPaymentToken`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`ApplePayCard`](../../doc/models/apple-pay-card.md) | Optional | The payment card to be used to fund a payment. Can be a credit or debit card. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

ApplePayPaymentToken applePayPaymentToken = new ApplePayPaymentToken
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
};
```

