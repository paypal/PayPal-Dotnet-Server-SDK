
# Payer Information

The payer information.

## Structure

`PayerInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `string` | Optional | The PayPal` customer account ID.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `13`, *Pattern*: `^[a-zA-Z0-9]*$` |
| `EmailAddress` | `string` | Optional | The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `254`, *Pattern*: `^.+@[^"\-].+$` |
| `PhoneNumber` | [`Phone`](../../doc/models/phone.md) | Optional | The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). |
| `AddressStatus` | `string` | Optional | The address status of the payer. Value is either: Y. Verified. N. Not verified.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1`, *Pattern*: `^[N\|Y]$` |
| `PayerStatus` | `string` | Optional | The status of the payer. Value is `Y` or `N`.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1`, *Pattern*: `^[N\|Y]$` |
| `PayerName` | [`PayerName`](../../doc/models/payer-name.md) | Optional | The name of the party. |
| `CountryCode` | `string` | Optional | The [two-character ISO 3166-1 code](/docs/integration/direct/rest/country-codes/) that identifies the country or region. Note: The country code for Great Britain is GB and not UK as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2`, *Pattern*: `^([A-Z]{2}\|C2)$` |
| `Address` | [`SimplePostalAddressCoarseGrained`](../../doc/models/simple-postal-address-coarse-grained.md) | Optional | A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone. |

## Example (as JSON)

```json
{
  "account_id": "account_id6",
  "email_address": "email_address2",
  "phone_number": {
    "country_code": "country_code2",
    "national_number": "national_number6",
    "extension_number": "extension_number8"
  },
  "address_status": "address_status2",
  "payer_status": "payer_status8"
}
```

