
# Transaction Information

The transaction information.

## Structure

`TransactionInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaypalAccountId` | `string` | Optional | The ID of the PayPal account of the counterparty.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `24`, *Pattern*: `^[a-zA-Z0-9]*$` |
| `TransactionId` | `string` | Optional | The PayPal-generated transaction ID.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `24`, *Pattern*: `^[a-zA-Z0-9]*$` |
| `PaypalReferenceId` | `string` | Optional | The PayPal-generated base ID. PayPal exclusive. Cannot be altered. Defined as a related, pre-existing transaction or event.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `24`, *Pattern*: `^[a-zA-Z0-9]*$` |
| `PaypalReferenceIdType` | [`PaypalReferenceIdType?`](../../doc/models/paypal-reference-id-type.md) | Optional | The PayPal reference ID type.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3`, *Pattern*: `^[a-zA-Z0-9]*$` |
| `TransactionEventCode` | `string` | Optional | A five-digit transaction event code that classifies the transaction type based on money movement and debit or credit. For example, T0001. See [Transaction event codes](/docs/integration/direct/transaction-search/transaction-event-codes/).<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `5`, *Pattern*: `^[a-zA-Z0-9]*$` |
| `TransactionInitiationDate` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `TransactionUpdatedDate` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `TransactionAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `FeeAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `DiscountAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `InsuranceAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `SalesTaxAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `ShippingAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `ShippingDiscountAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `ShippingTaxAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `OtherAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `TipAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `TransactionStatus` | `string` | Optional | A code that indicates the transaction status. Value is: Status code Description D PayPal or merchant rules denied the transaction. P The transaction is pending. The transaction was created but waits for another payment process to complete, such as an ACH transaction, before the status changes to S. S The transaction successfully completed without a denial and after any pending statuses. V A successful transaction was fully reversed and funds were refunded to the original sender.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1`, *Pattern*: `^[a-zA-Z0-9]*$` |
| `TransactionSubject` | `string` | Optional | The subject of payment. The payer passes this value to the payee. The payer controls this data through the interface through which he or she sends the data.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `256`, *Pattern*: `^[a-zA-Z0-9_'\-., ":;\!?]*$` |
| `TransactionNote` | `string` | Optional | A special note that the payer passes to the payee. Might contain special customer requests, such as shipping instructions.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `4000`, *Pattern*: `^[a-zA-Z0-9_'\-., ":;\!?]*$` |
| `PaymentTrackingId` | `string` | Optional | The payment tracking ID, which is a unique ID that partners specify to either get information about a payment or request a refund.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127`, *Pattern*: `^[a-zA-Z0-9]*$` |
| `BankReferenceId` | `string` | Optional | The bank reference ID. The bank provides this value for an ACH transaction.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127`, *Pattern*: `^[a-zA-Z0-9]*$` |
| `EndingBalance` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `AvailableBalance` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `InvoiceId` | `string` | Optional | The invoice ID that is sent by the merchant with the transaction. Note: If an invoice ID was sent with the capture request, the value is reported. Otherwise, the invoice ID of the authorizing transaction is reported.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127`, *Pattern*: `^[a-zA-Z0-9_'\-., ":;\!?]*$` |
| `CustomField` | `string` | Optional | The merchant-provided custom text. Note: Usually, this field includes the unique ID for payments made with MassPay type transaction.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127`, *Pattern*: `^[a-zA-Z0-9_'\-., ":;\!?]*$` |
| `ProtectionEligibility` | `string` | Optional | Indicates whether the transaction is eligible for protection. Value is: 01. Eligible. 02. Not eligible 03. Partially eligible.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2`, *Pattern*: `^[a-zA-Z0-9]*$` |
| `CreditTerm` | `string` | Optional | The credit term. The time span covered by the installment payments as expressed in the term length plus the length time unit code.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `25`, *Pattern*: `^[a-zA-Z0-9.]*$` |
| `CreditTransactionalFee` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `CreditPromotionalFee` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `AnnualPercentageRate` | `string` | Optional | The percentage, as a fixed-point, signed decimal number. For example, define a 19.99% interest rate as `19.99`.<br><br>**Constraints**: *Pattern*: `^((-?[0-9]+)\|(-?([0-9]+)?[.][0-9]+))$` |
| `PaymentMethodType` | `string` | Optional | The payment method that was used for a transaction. Value is PUI, installment, or mEFT. Note: Appears only for pay upon invoice (PUI), installment, and mEFT transactions. Merchants and partners in the EMEA region can use this attribute to note transactions that attract turn-over tax.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `20`, *Pattern*: `^[a-zA-Z0-9-]*$` |
| `InstrumentType` | `string` | Optional | A high-level classification of the type of financial instrument that was used to fund a payment. The pattern is not provided because the value is defined by an external party. E.g. PAYPAL, CREDIT_CARD, DEBIT_CARD, APPLE_PAY, BANK , VENMO ,Pay Upon Invoice, Pay Later  or Alternative Payment Methods (APM).<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64` |
| `InstrumentSubType` | `string` | Optional | A finer-grained classification of the financial instrument that was used to fund a payment. For example, `Visa card` or a `Mastercard` for a credit card, BANKCARD ,DISCOVER etc. The pattern is not provided because the value is defined by an external party.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64` |

## Example (as JSON)

```json
{
  "paypal_account_id": "paypal_account_id6",
  "transaction_id": "transaction_id2",
  "paypal_reference_id": "paypal_reference_id4",
  "paypal_reference_id_type": "ODR",
  "transaction_event_code": "transaction_event_code8"
}
```

