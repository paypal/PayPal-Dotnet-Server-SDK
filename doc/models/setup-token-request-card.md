
# Setup Token Request Card

A Resource representing a request to vault a Card.

## Structure

`SetupTokenRequestCard`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The card holder's name as it appears on the card.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `300`, *Pattern*: `^.{1,300}$` |
| `Number` | `string` | Optional | The primary account number (PAN) for the payment card.<br><br>**Constraints**: *Minimum Length*: `13`, *Maximum Length*: `19`, *Pattern*: `^[0-9]{13,19}$` |
| `Expiry` | `string` | Optional | The year and month, in ISO-8601 `YYYY-MM` date format. See [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).<br><br>**Constraints**: *Minimum Length*: `7`, *Maximum Length*: `7`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])$` |
| `SecurityCode` | `string` | Optional | The three- or four-digit security code of the card. Also known as the CVV, CVC, CVN, CVE, or CID. This parameter cannot be present in the request when `payment_initiator=MERCHANT`.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `4`, *Pattern*: `^[0-9]{3,4}$` |
| `Brand` | [`CardBrand?`](../../doc/models/card-brand.md) | Optional | The card network or brand. Applies to credit, debit, gift, and payment cards.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[A-Z_]+$` |
| `BillingAddress` | [`Address`](../../doc/models/address.md) | Optional | The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute). |
| `VerificationMethod` | [`VaultCardVerificationMethod?`](../../doc/models/vault-card-verification-method.md) | Optional | The verification method of the card.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9A-Z_]+$` |
| `ExperienceContext` | [`SetupTokenCardExperienceContext`](../../doc/models/setup-token-card-experience-context.md) | Optional | Customizes the Vault creation flow experience for your customers. |

## Example (as JSON)

```json
{
  "name": "name2",
  "number": "number0",
  "expiry": "expiry0",
  "security_code": "security_code4",
  "brand": "DINERS"
}
```

