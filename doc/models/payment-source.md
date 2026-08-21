
# Payment Source

The payment source definition.

## Structure

`PaymentSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`CardRequest`](../../doc/models/card-request.md) | Optional | The payment card to use to fund a payment. Can be a credit or debit card. Note: Passing card number, cvv and expiry directly via the API requires PCI SAQ D compliance. *PayPal offers a mechanism by which you do not have to take on the PCI SAQ D burden by using hosted fields - refer to this Integration Guide*. |
| `Token` | [`Token`](../../doc/models/token.md) | Optional | The tokenized payment source to fund a payment. |
| `Paypal` | [`PaypalWallet`](../../doc/models/paypal-wallet.md) | Optional | A resource that identifies a PayPal Wallet is used for payment. |
| `Bancontact` | [`BancontactPaymentRequest`](../../doc/models/bancontact-payment-request.md) | Optional | Information needed to pay using Bancontact. |
| `Blik` | [`BlikPaymentRequest`](../../doc/models/blik-payment-request.md) | Optional | Information needed to pay using BLIK. |
| `Eps` | [`EpsPaymentRequest`](../../doc/models/eps-payment-request.md) | Optional | Information needed to pay using eps. |
| `Giropay` | [`GiropayPaymentRequest`](../../doc/models/giropay-payment-request.md) | Optional | Information needed to pay using giropay. |
| `Ideal` | [`IdealPaymentRequest`](../../doc/models/ideal-payment-request.md) | Optional | Information needed to pay using iDEAL. |
| `Mybank` | [`MybankPaymentRequest`](../../doc/models/mybank-payment-request.md) | Optional | Information needed to pay using MyBank. |
| `P24` | [`P24PaymentRequest`](../../doc/models/p24-payment-request.md) | Optional | Information needed to pay using P24 (Przelewy24). |
| `Sofort` | [`SofortPaymentRequest`](../../doc/models/sofort-payment-request.md) | Optional | Information needed to pay using Sofort. |
| `Trustly` | [`TrustlyPaymentRequest`](../../doc/models/trustly-payment-request.md) | Optional | Information needed to pay using Trustly. |
| `ApplePay` | [`ApplePayRequest`](../../doc/models/apple-pay-request.md) | Optional | Information needed to pay using ApplePay. |
| `GooglePay` | [`GooglePayRequest`](../../doc/models/google-pay-request.md) | Optional | Information needed to pay using Google Pay. |
| `Venmo` | [`VenmoWalletRequest`](../../doc/models/venmo-wallet-request.md) | Optional | Information needed to pay using Venmo. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

PaymentSource paymentSource = new PaymentSource
{
    Card = new CardRequest
    {
        Name = "name6",
        Number = "number6",
        Expiry = "expiry4",
        SecurityCode = "security_code8",
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
    Token = new Token
    {
        Id = "id6",
        Type = TokenType.BillingAgreement,
    },
    Paypal = new PaypalWallet
    {
        VaultId = "vault_id0",
        EmailAddress = "email_address0",
        Name = new Name
        {
            GivenName = "given_name2",
            Surname = "surname8",
        },
        Phone = new PhoneWithType
        {
            PhoneNumber = new PhoneNumber
            {
                NationalNumber = "national_number6",
            },
            PhoneType = PhoneType.Other,
        },
        BirthDate = "birth_date8",
    },
    Bancontact = new BancontactPaymentRequest
    {
        Name = "name0",
        CountryCode = "country_code0",
        ExperienceContext = new ExperienceContext
        {
            BrandName = "brand_name2",
            Locale = "locale6",
            ShippingPreference = ExperienceContextShippingPreference.NoShipping,
            ReturnUrl = "return_url4",
            CancelUrl = "cancel_url6",
        },
    },
    Blik = new BlikPaymentRequest
    {
        Name = "name2",
        CountryCode = "country_code2",
        Email = "email4",
        ExperienceContext = new BlikExperienceContext
        {
            BrandName = "brand_name2",
            Locale = "locale6",
            ShippingPreference = ExperienceContextShippingPreference.NoShipping,
            ReturnUrl = "return_url4",
            CancelUrl = "cancel_url6",
        },
        Level0 = new BlikLevel0PaymentObject
        {
            AuthCode = "auth_code8",
        },
        OneClick = new BlikOneClickPaymentRequest
        {
            ConsumerReference = "consumer_reference2",
            AuthCode = "auth_code0",
            AliasLabel = "alias_label6",
            AliasKey = "alias_key4",
        },
    },
};
```

