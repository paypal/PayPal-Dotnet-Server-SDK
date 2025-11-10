
# Captured Payment

A captured payment.

## Structure

`CapturedPayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | [`CaptureStatus?`](../../doc/models/capture-status.md) | Optional | The status of the captured payment. |
| `StatusDetails` | [`CaptureStatusDetails`](../../doc/models/capture-status-details.md) | Optional | The details of the captured payment status. |
| `Id` | `string` | Optional | The PayPal-generated ID for the captured payment. |
| `Amount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `InvoiceId` | `string` | Optional | The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives. |
| `CustomId` | `string` | Optional | The API caller-provided external ID. Used to reconcile API caller-initiated transactions with PayPal transactions. Appears in transaction and settlement reports.<br><br>**Constraints**: *Maximum Length*: `255` |
| `NetworkTransactionReference` | [`NetworkTransaction`](../../doc/models/network-transaction.md) | Optional | Reference values used by the card network to identify a transaction. |
| `SellerProtection` | [`SellerProtection`](../../doc/models/seller-protection.md) | Optional | The level of protection offered as defined by [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection). |
| `FinalCapture` | `bool?` | Optional | Indicates whether you can make additional captures against the authorized payment. Set to `true` if you do not intend to capture additional payments against the authorization. Set to `false` if you intend to capture additional payments against the authorization.<br><br>**Default**: `false` |
| `SellerReceivableBreakdown` | [`SellerReceivableBreakdown`](../../doc/models/seller-receivable-breakdown.md) | Optional | The detailed breakdown of the capture activity. This is not available for transactions that are in pending state. |
| `DisbursementMode` | [`DisbursementMode?`](../../doc/models/disbursement-mode.md) | Optional | The funds that are held on behalf of the merchant.<br><br>**Default**: `DisbursementMode.INSTANT`<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `16`, *Pattern*: `^[A-Z_]+$` |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional | An array of related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links). |
| `ProcessorResponse` | [`ProcessorResponse`](../../doc/models/processor-response.md) | Optional | The processor response information for payment requests, such as direct credit card transactions. |
| `CreateTime` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `UpdateTime` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `SupplementaryData` | [`PaymentSupplementaryData`](../../doc/models/payment-supplementary-data.md) | Optional | The supplementary data. |
| `Payee` | [`PayeeBase`](../../doc/models/payee-base.md) | Optional | The details for the merchant who receives the funds and fulfills the order. The merchant is also known as the payee. |

## Example (as JSON)

```json
{
  "final_capture": false,
  "disbursement_mode": "INSTANT",
  "status": "PARTIALLY_REFUNDED",
  "status_details": {
    "reason": "VERIFICATION_REQUIRED"
  },
  "id": "id4",
  "amount": {
    "currency_code": "currency_code6",
    "value": "value0"
  },
  "invoice_id": "invoice_id4"
}
```

