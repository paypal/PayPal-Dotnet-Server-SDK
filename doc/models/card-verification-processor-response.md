
# Card Verification Processor Response

The processor response information for payment requests, such as direct credit card transactions.

## Structure

`CardVerificationProcessorResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AvsCode` | [`AVSCode?`](../../doc/models/avs-code.md) | Optional | The address verification code for Visa, Discover, Mastercard, or American Express transactions. |
| `CvvCode` | [`CVVCode?`](../../doc/models/cvv-code.md) | Optional | The card verification value code for for Visa, Discover, Mastercard, or American Express. |

## Example (as JSON)

```json
{
  "avs_code": "E",
  "cvv_code": "All others"
}
```
