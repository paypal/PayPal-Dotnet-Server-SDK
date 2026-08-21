
# Order Authorize Request Payment Source

The payment source definition.

## Structure

`OrderAuthorizeRequestPaymentSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`CardRequest`](../../doc/models/card-request.md) | Optional | The payment card to use to fund a payment. Can be a credit or debit card. Note: Passing card number, cvv and expiry directly via the API requires PCI SAQ D compliance. *PayPal offers a mechanism by which you do not have to take on the PCI SAQ D burden by using hosted fields - refer to this Integration Guide*. |
| `Token` | [`Token`](../../doc/models/token.md) | Optional | The tokenized payment source to fund a payment. |
| `Paypal` | [`PaypalWallet`](../../doc/models/paypal-wallet.md) | Optional | A resource that identifies a PayPal Wallet is used for payment. |
| `ApplePay` | [`ApplePayRequest`](../../doc/models/apple-pay-request.md) | Optional | Information needed to pay using ApplePay. |
| `GooglePay` | [`GooglePayRequest`](../../doc/models/google-pay-request.md) | Optional | Information needed to pay using Google Pay. |
| `Venmo` | [`VenmoWalletRequest`](../../doc/models/venmo-wallet-request.md) | Optional | Information needed to pay using Venmo. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

OrderAuthorizeRequestPaymentSource orderAuthorizeRequestPaymentSource = new OrderAuthorizeRequestPaymentSource
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
    ApplePay = new ApplePayRequest
    {
        Id = "id0",
        Name = "name0",
        EmailAddress = "email_address8",
        PhoneNumber = new PhoneNumber
        {
            NationalNumber = "national_number6",
        },
        DecryptedToken = new ApplePayDecryptedTokenData
        {
            TokenizedCard = new ApplePayTokenizedCard
            {
                Name = "name4",
                Number = "number2",
                Expiry = "expiry2",
                Type = CardType.Unknown,
            },
            TransactionAmount = new Money
            {
                CurrencyCode = "currency_code6",
                MValue = "value2",
            },
            DeviceManufacturerId = "device_manufacturer_id6",
            PaymentDataType = ApplePayPaymentDataType.Enum3Dsecure,
            PaymentData = new ApplePayPaymentData
            {
                Cryptogram = "cryptogram6",
                EciIndicator = "eci_indicator0",
                EmvData = "emv_data0",
                Pin = "pin4",
            },
        },
    },
    GooglePay = new GooglePayRequest
    {
        Name = "name8",
        EmailAddress = "email_address6",
        PhoneNumber = new PhoneNumberWithCountryCode
        {
            CountryCode = "country_code2",
            NationalNumber = "national_number6",
        },
        Card = new GooglePayRequestCard
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
        DecryptedToken = new GooglePayDecryptedTokenData
        {
            PaymentMethod = GooglePayPaymentMethod.Card,
            Card = new GooglePayCard
            {
                Name = "name6",
                Number = "number6",
                Expiry = "expiry4",
                Type = CardType.Unknown,
            },
            AuthenticationMethod = GooglePayAuthenticationMethod.PanOnly,
            MessageId = "message_id0",
            MessageExpiration = "message_expiration2",
            Cryptogram = "cryptogram6",
            EciIndicator = "eci_indicator0",
        },
    },
};
```

