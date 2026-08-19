
# Vault Apple Pay Request

A resource representing a request to vault Apple Pay.

## Structure

`VaultApplePayRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Token` | `string` | Optional | Encrypted Apple Pay token, containing card information. This token would be base64 encoded.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `10000`, *Pattern*: `^.*$` |
| `Card` | [`ApplePayRequestCard`](../../doc/models/apple-pay-request-card.md) | Optional | The payment card to be used to fund a payment. Can be a credit or debit card. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

VaultApplePayRequest vaultApplePayRequest = new VaultApplePayRequest
{
    Token = "token8",
    Card = new ApplePayRequestCard
    {
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

