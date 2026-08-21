
# Customer Vault Payment Tokens Response

Collection of payment tokens saved for a given customer.

## Structure

`CustomerVaultPaymentTokensResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalItems` | `int?` | Optional | Total number of items.<br><br>**Constraints**: `>= 1`, `<= 50` |
| `TotalPages` | `int?` | Optional | Total number of pages.<br><br>**Constraints**: `>= 1`, `<= 10` |
| `Customer` | [`VaultResponseCustomer`](../../doc/models/vault-response-customer.md) | Optional | This object defines a customer in your system. Use it to manage customer profiles, save payment methods and contact details. |
| `PaymentTokens` | [`List<PaymentTokenResponse>`](../../doc/models/payment-token-response.md) | Optional | **Constraints**: *Minimum Items*: `0`, *Maximum Items*: `64` |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional, Read-only | An array of related [HATEOAS links](https://developer.paypal.com/api/rest/responses/#hateoas).<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `32` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

CustomerVaultPaymentTokensResponse customerVaultPaymentTokensResponse = new CustomerVaultPaymentTokensResponse
{
    TotalItems = 50,
    TotalPages = 10,
    Customer = new VaultResponseCustomer
    {
        Id = "id0",
        MerchantCustomerId = "merchant_customer_id2",
    },
    PaymentTokens = new List<PaymentTokenResponse>
    {
        new PaymentTokenResponse
        {
            Id = "id4",
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
        },
        new PaymentTokenResponse
        {
            Id = "id4",
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
        },
    },
};
```

