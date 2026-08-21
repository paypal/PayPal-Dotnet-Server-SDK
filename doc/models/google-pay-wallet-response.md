
# Google Pay Wallet Response

Google Pay Wallet payment data.

## Structure

`GooglePayWalletResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The full name representation like Mr J Smith.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `300` |
| `EmailAddress` | `string` | Optional | The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `254`, *Pattern*: ``^(?:[A-Za-z0-9!#$%&'*+/=?^_`{\|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_`{\|}~-]+)*\|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]\|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\|\[(?:(?:25[0-5]\|2[0-4][0-9]\|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]\|2[0-4][0-9]\|[01]?[0-9][0-9]?\|[A-Za-z0-9-]*[A-Za-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]\|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])$`` |
| `PhoneNumber` | [`PhoneNumberWithCountryCode`](../../doc/models/phone-number-with-country-code.md) | Optional | The phone number in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). |
| `Card` | [`GooglePayCardResponse`](../../doc/models/google-pay-card-response.md) | Optional | The payment card to use to fund a Google Pay payment response. Can be a credit or debit card. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

GooglePayWalletResponse googlePayWalletResponse = new GooglePayWalletResponse
{
    Name = "name0",
    EmailAddress = "email_address8",
    PhoneNumber = new PhoneNumberWithCountryCode
    {
        CountryCode = "country_code2",
        NationalNumber = "national_number6",
    },
    Card = new GooglePayCardResponse
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

