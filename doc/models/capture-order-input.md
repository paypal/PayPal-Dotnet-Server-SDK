
# Capture Order Input

Input structure for the method CaptureOrder

## Structure

`CaptureOrderInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The ID of the order for which to capture a payment.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36`, *Pattern*: `^[A-Z0-9]+$` |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `PaypalMockResponse` | `string` | Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |
| `PaypalRequestId` | `string` | Optional | The server stores keys for 6 hours. The API callers can request the times to up to 72 hours by speaking to their Account Manager. It is mandatory for all single-step create order calls (E.g. Create Order Request with payment source information like Card, PayPal.vault_id, PayPal.billing_agreement_id, etc).<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `108` |
| `Prefer` | `string` | Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br><br>**Default**: `"return=minimal"`<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `25`, *Pattern*: `^[a-zA-Z=,-]*$` |
| `PaypalClientMetadataId` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36` |
| `PaypalAuthAssertion` | `string` | Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see PayPal-Auth-Assertion. |
| `Body` | [`OrderCaptureRequest`](../../doc/models/order-capture-request.md) | Optional | - |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CaptureOrderInput captureOrderInput = new CaptureOrderInput
{
    Id = "id0",
    PaypalMockResponse = "PayPal-Mock-Response0",
    PaypalRequestId = "PayPal-Request-Id6",
    Prefer = "return=minimal",
    PaypalClientMetadataId = "PayPal-Client-Metadata-Id2",
    PaypalAuthAssertion = "PayPal-Auth-Assertion0",
    Body = new OrderCaptureRequest
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
                        CardType = CardBrand.Visa,
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
                        LastDigits = "last_digits0",
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
    },
};
```

