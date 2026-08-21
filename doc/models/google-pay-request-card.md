
# Google Pay Request Card

The payment card used to fund a Google Pay payment. Can be a credit or debit card.

## Structure

`GooglePayRequestCard`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The card holder's name as it appears on the card.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `300`, *Pattern*: `^.{1,300}$` |
| `Type` | [`CardType?`](../../doc/models/card-type.md) | Optional | Type of card. i.e Credit, Debit and so on.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[A-Z_]+$` |
| `Brand` | [`CardBrand?`](../../doc/models/card-brand.md) | Optional | The card network or brand. Applies to credit, debit, gift, and payment cards.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[A-Z_]+$` |
| `BillingAddress` | [`Address`](../../doc/models/address.md) | Optional | The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute). |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

GooglePayRequestCard googlePayRequestCard = new GooglePayRequestCard
{
    Name = "name2",
    Type = CardType.Store,
    Brand = CardBrand.Star,
    BillingAddress = new Address
    {
        CountryCode = "country_code8",
        AddressLine1 = "address_line_12",
        AddressLine2 = "address_line_28",
        AdminArea2 = "admin_area_28",
        AdminArea1 = "admin_area_14",
        PostalCode = "postal_code0",
    },
};
```

