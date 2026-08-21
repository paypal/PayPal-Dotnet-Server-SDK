
# Card Response Address

Address request details.

## Structure

`CardResponseAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AddressLine1` | `string` | Optional | The first line of the address, such as number and street, for example, `173 Drury Lane`. Needed for data entry, and Compliance and Risk checks. This field needs to pass the full address.<br><br>**Constraints**: *Maximum Length*: `300` |
| `AddressLine2` | `string` | Optional | The second line of the address, for example, a suite or apartment number.<br><br>**Constraints**: *Maximum Length*: `300` |
| `AdminArea2` | `string` | Optional | A city, town, or village. Smaller than `admin_area_level_1`.<br><br>**Constraints**: *Maximum Length*: `120` |
| `AdminArea1` | `string` | Optional | The highest-level sub-division in a country, which is usually a province, state, or ISO-3166-2 subdivision. This data is formatted for postal delivery, for example, `CA` and not `California`. Value, by country, is: UK. A county. US. A state. Canada. A province. Japan. A prefecture. Switzerland. A *kanton*.<br><br>**Constraints**: *Maximum Length*: `300` |
| `PostalCode` | `string` | Optional | The postal code, which is the ZIP code or equivalent. Typically required for countries with a postal code or an equivalent. See [postal code](https://en.wikipedia.org/wiki/Postal_code).<br><br>**Constraints**: *Maximum Length*: `60` |
| `CountryCode` | `string` | Required | The [2-character ISO 3166-1 code](https://developer.paypal.com/api/rest/reference/country-codes/) that identifies the country or region. Note: The country code for Great Britain is GB and not UK as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2`, *Pattern*: `^([A-Z]{2}\|C2)$` |
| `Id` | `string` | Optional | The resource ID of the address.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36`, *Pattern*: `^[0-9A-Za-z-_]+$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CardResponseAddress cardResponseAddress = new CardResponseAddress
{
    CountryCode = "country_code2",
    AddressLine1 = "address_line_18",
    AddressLine2 = "address_line_22",
    AdminArea2 = "admin_area_26",
    AdminArea1 = "admin_area_18",
    PostalCode = "postal_code4",
};
```

