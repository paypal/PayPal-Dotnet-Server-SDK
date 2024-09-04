
# Card Payment Token

Full representation of a Card Payment Token including network token.

## Structure

`CardPaymentToken`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The card holder's name as it appears on the card.<br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `300`, *Pattern*: `^[A-Za-z ]+$` |
| `LastDigits` | `string` | Optional | The last digits of the payment card.<br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `4`, *Pattern*: `[0-9]{2,}` |
| `Brand` | [`CardBrand?`](../../doc/models/card-brand.md) | Optional | The card network or brand. Applies to credit, debit, gift, and payment cards.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[A-Z_]+$` |
| `Expiry` | `string` | Optional | The year and month, in ISO-8601 `YYYY-MM` date format. See [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).<br>**Constraints**: *Minimum Length*: `7`, *Maximum Length*: `7`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])$` |
| `BillingAddress` | [`AddressDetails`](../../doc/models/address-details.md) | Optional | Address request details. |
| `VerificationStatus` | `string` | Optional | Verification status of Card.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9A-Z_]+$` |
| `Verification` | [`CardVerificationDetails`](../../doc/models/card-verification-details.md) | Optional | Card Verification details including the authorization details and 3D SECURE details. |
| `NetworkTransactionReference` | [`NetworkTransactionReferenceEntity`](../../doc/models/network-transaction-reference-entity.md) | Optional | Previous network transaction reference including id in response. |
| `AuthenticationResult` | [`CardAuthenticationResponse`](../../doc/models/card-authentication-response.md) | Optional | Results of Authentication such as 3D Secure. |
| `BinDetails` | [`BinDetails`](../../doc/models/bin-details.md) | Optional | Bank Identification Number (BIN) details used to fund a payment. |
| `Type` | [`CardType?`](../../doc/models/card-type.md) | Optional | Type of card. i.e Credit, Debit and so on.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[A-Z_]+$` |
| `NetworkToken` | `JsonValue` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name2",
  "last_digits": "last_digits6",
  "brand": "STAR",
  "expiry": "expiry0",
  "billing_address": {
    "address_line_1": "address_line_12",
    "address_line_2": "address_line_28",
    "admin_area_2": "admin_area_28",
    "admin_area_1": "admin_area_14",
    "postal_code": "postal_code0",
    "country_code": "country_code8"
  }
}
```

