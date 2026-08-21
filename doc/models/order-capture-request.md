
# Order Capture Request

Completes an capture payment for an order.

## Structure

`OrderCaptureRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentSource` | [`OrderCaptureRequestPaymentSource`](../../doc/models/order-capture-request-payment-source.md) | Optional | The payment source definition. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

OrderCaptureRequest orderCaptureRequest = new OrderCaptureRequest
{
    PaymentSource = new OrderCaptureRequestPaymentSource
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
    },
};
```

