
# Payment Token Response

Full representation of a saved payment token.

## Structure

`PaymentTokenResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | The PayPal-generated ID for the vaulted payment source. This ID should be stored on the merchant's server so the saved payment source can be used for future transactions.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9a-zA-Z_-]+$` |
| `Customer` | [`CustomerResponse`](../../doc/models/customer-response.md) | Optional | Customer in merchant's or partner's system of records. |
| `PaymentSource` | [`PaymentTokenResponsePaymentSource`](../../doc/models/payment-token-response-payment-source.md) | Optional | The vaulted payment method details. |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional, Read-only | An array of related [HATEOAS links](https://developer.paypal.com/api/rest/responses/#hateoas).<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `32` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

PaymentTokenResponse paymentTokenResponse = new PaymentTokenResponse
{
    Id = "id8",
    Customer = new CustomerResponse
    {
        Id = "id0",
        MerchantCustomerId = "merchant_customer_id2",
    },
    PaymentSource = new PaymentTokenResponsePaymentSource
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
    },
};
```

