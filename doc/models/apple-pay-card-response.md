
# Apple Pay Card Response

The Card from Apple Pay Wallet used to fund the payment.

## Structure

`ApplePayCardResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The card holder's name as it appears on the card.<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `300` |
| `LastDigits` | `string` | Optional | The last digits of the payment card.<br><br>**Constraints**: *Pattern*: `[0-9]{2,}` |
| `Brand` | [`CardBrand?`](../../doc/models/card-brand.md) | Optional | The card network or brand. Applies to credit, debit, gift, and payment cards.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[A-Z_]+$` |
| `AvailableNetworks` | [`List<CardBrand>`](../../doc/models/card-brand.md) | Optional | Array of brands or networks associated with the card.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `256`, *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[A-Z_]+$` |
| `Type` | [`CardType?`](../../doc/models/card-type.md) | Optional | Type of card. i.e Credit, Debit and so on.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[A-Z_]+$` |
| `AuthenticationResult` | [`AuthenticationResponse`](../../doc/models/authentication-response.md) | Optional | Results of Authentication such as 3D Secure. |
| `Attributes` | [`CardAttributesResponse`](../../doc/models/card-attributes-response.md) | Optional | Additional attributes associated with the use of this card. |
| `FromRequest` | [`CardFromRequest`](../../doc/models/card-from-request.md) | Optional | Representation of card details as received in the request. |
| `Expiry` | `string` | Optional | The year and month, in ISO-8601 `YYYY-MM` date format. See [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).<br><br>**Constraints**: *Minimum Length*: `7`, *Maximum Length*: `7`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])$` |
| `BinDetails` | [`BinDetails`](../../doc/models/bin-details.md) | Optional | Bank Identification Number (BIN) details used to fund a payment. |
| `StoredCredential` | [`CardStoredCredential`](../../doc/models/card-stored-credential.md) | Optional | Provides additional details to process a payment using a `card` that has been stored or is intended to be stored (also referred to as stored_credential or card-on-file). Parameter compatibility: `payment_type=ONE_TIME` is compatible only with `payment_initiator=CUSTOMER`. `usage=FIRST` is compatible only with `payment_initiator=CUSTOMER`. `previous_transaction_reference` or `previous_network_transaction_reference` is compatible only with `payment_initiator=MERCHANT`. Only one of the parameters - `previous_transaction_reference` and `previous_network_transaction_reference` - can be present in the request. |
| `BillingAddress` | [`Address`](../../doc/models/address.md) | Optional | The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute). |
| `CountryCode` | `string` | Optional | The [two-character ISO 3166-1 code](/api/rest/reference/country-codes/) that identifies the country or region. Note: The country code for Great Britain is GB and not UK as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2`, *Pattern*: `^([A-Z]{2}\|C2)$` |

## Example (as JSON)

```json
{
  "name": "name4",
  "last_digits": "last_digits8",
  "brand": "HIPER",
  "available_networks": [
    "RUPAY"
  ],
  "type": "DEBIT"
}
```

