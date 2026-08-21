
# Card Response with Billing Address

The payment card used to fund the payment. Card can be a credit or debit card.

## Structure

`CardResponseWithBillingAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The card holder's name as it appears on the card.<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `300` |
| `BillingAddress` | [`Address`](../../doc/models/address.md) | Optional | The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute). |
| `Expiry` | `string` | Optional | The year and month, in ISO-8601 `YYYY-MM` date format. See [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).<br><br>**Constraints**: *Minimum Length*: `7`, *Maximum Length*: `7`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])$` |
| `CurrencyCode` | `string` | Optional | The [three-character ISO-4217 currency code](https://developer.paypal.com/api/rest/reference/currency-codes/) that identifies the currency.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CardResponseWithBillingAddress cardResponseWithBillingAddress = new CardResponseWithBillingAddress
{
    Name = "name0",
    BillingAddress = new Address
    {
        CountryCode = "country_code8",
        AddressLine1 = "address_line_12",
        AddressLine2 = "address_line_28",
        AdminArea2 = "admin_area_28",
        AdminArea1 = "admin_area_14",
        PostalCode = "postal_code0",
    },
    Expiry = "expiry8",
    CurrencyCode = "currency_code4",
};
```

