
# Google Pay Request

Information needed to pay using Google Pay.

## Structure

`GooglePayRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The full name representation like Mr J Smith.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `300` |
| `EmailAddress` | `string` | Optional | The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `254`, *Pattern*: ``^(?:[A-Za-z0-9!#$%&'*+/=?^_`{\|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_`{\|}~-]+)*\|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]\|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\|\[(?:(?:25[0-5]\|2[0-4][0-9]\|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]\|2[0-4][0-9]\|[01]?[0-9][0-9]?\|[A-Za-z0-9-]*[A-Za-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]\|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])$`` |
| `PhoneNumber` | [`PhoneNumberWithCountryCode`](../../doc/models/phone-number-with-country-code.md) | Optional | The phone number in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). |
| `Card` | [`GooglePayRequestCard`](../../doc/models/google-pay-request-card.md) | Optional | The payment card used to fund a Google Pay payment. Can be a credit or debit card. |
| `DecryptedToken` | [`GooglePayDecryptedTokenData`](../../doc/models/google-pay-decrypted-token-data.md) | Optional | Details shared by Google for the merchant to be shared with PayPal. This is required to process the transaction using the Google Pay payment method. |
| `AssuranceDetails` | [`AssuranceDetails`](../../doc/models/assurance-details.md) | Optional | Information about cardholder possession validation and cardholder identification and verifications (ID&V). |
| `ExperienceContext` | [`GooglePayExperienceContext`](../../doc/models/google-pay-experience-context.md) | Optional | Customizes the payer experience during the approval process for the payment. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

GooglePayRequest googlePayRequest = new GooglePayRequest
{
    Name = "name6",
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
};
```

