
# EPS Payment Object

Information used to pay using eps.

## Structure

`EPSPaymentObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The full name representation like Mr J Smith.<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `300` |
| `CountryCode` | `string` | Optional | The [two-character ISO 3166-1 code](/api/rest/reference/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2`, *Pattern*: `^([A-Z]{2}\|C2)$` |
| `Bic` | `string` | Optional | The business identification code (BIC). In payments systems, a BIC is used to identify a specific business, most commonly a bank.<br>**Constraints**: *Minimum Length*: `8`, *Maximum Length*: `11`, *Pattern*: `^[A-Z-a-z0-9]{4}[A-Z-a-z]{2}[A-Z-a-z0-9]{2}([A-Z-a-z0-9]{3})?$` |

## Example (as JSON)

```json
{
  "name": "name6",
  "country_code": "country_code6",
  "bic": "bic8"
}
```
