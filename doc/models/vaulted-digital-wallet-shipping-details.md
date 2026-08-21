
# Vaulted Digital Wallet Shipping Details

The shipping details.

## Structure

`VaultedDigitalWalletShippingDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | [`ShippingName`](../../doc/models/shipping-name.md) | Optional | The name of the party. |
| `EmailAddress` | `string` | Optional | The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `254`, *Pattern*: ``^(?:[A-Za-z0-9!#$%&'*+/=?^_`{\|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_`{\|}~-]+)*\|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]\|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\|\[(?:(?:25[0-5]\|2[0-4][0-9]\|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]\|2[0-4][0-9]\|[01]?[0-9][0-9]?\|[A-Za-z0-9-]*[A-Za-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]\|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])$`` |
| `PhoneNumber` | [`PhoneNumberWithCountryCode`](../../doc/models/phone-number-with-country-code.md) | Optional | The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). |
| `Type` | [`FulfillmentType?`](../../doc/models/fulfillment-type.md) | Optional | A classification for the method of purchase fulfillment (e.g shipping, in-store pickup, etc). Either `type` or `options` may be present, but not both.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9A-Z_]+$` |
| `Address` | [`Address`](../../doc/models/address.md) | Optional | The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute). |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

VaultedDigitalWalletShippingDetails vaultedDigitalWalletShippingDetails = new VaultedDigitalWalletShippingDetails
{
    Name = new ShippingName
    {
        FullName = "full_name6",
    },
    EmailAddress = "email_address6",
    PhoneNumber = new PhoneNumberWithCountryCode
    {
        CountryCode = "country_code2",
        NationalNumber = "national_number6",
    },
    Type = FulfillmentType.PickupInStore,
    Address = new Address
    {
        CountryCode = "country_code6",
        AddressLine1 = "address_line_16",
        AddressLine2 = "address_line_26",
        AdminArea2 = "admin_area_20",
        AdminArea1 = "admin_area_12",
        PostalCode = "postal_code8",
    },
};
```

