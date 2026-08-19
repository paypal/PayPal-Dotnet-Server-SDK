
# Capture Request

Captures either a portion or the full authorized amount of an authorized payment.

## Structure

`CaptureRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `InvoiceId` | `string` | Optional | The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.<br><br>**Constraints**: *Maximum Length*: `127` |
| `FinalCapture` | `bool?` | Optional | Indicates whether you can make additional captures against the authorized payment. Set to `true` if you do not intend to capture additional payments against the authorization. Set to `false` if you intend to capture additional payments against the authorization.<br><br>**Default**: `false` |
| `PaymentInstruction` | [`CapturePaymentInstruction`](../../doc/models/capture-payment-instruction.md) | Optional | Any additional payment instructions to be consider during payment processing. This processing instruction is applicable for Capturing an order or Authorizing an Order. |
| `NoteToPayer` | `string` | Optional | An informational note about this settlement. Appears in both the payer's transaction history and the emails that the payer receives.<br><br>**Constraints**: *Maximum Length*: `255` |
| `SoftDescriptor` | `string` | Optional | The payment descriptor on the payer's account statement.<br><br>**Constraints**: *Maximum Length*: `22` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

CaptureRequest captureRequest = new CaptureRequest
{
    Amount = new Money
    {
        CurrencyCode = "currency_code6",
        MValue = "value0",
    },
    InvoiceId = "invoice_id8",
    FinalCapture = false,
    PaymentInstruction = new CapturePaymentInstruction
    {
        PlatformFees = new List<PlatformFee>
        {
            new PlatformFee
            {
                Amount = new Money
                {
                    CurrencyCode = "currency_code6",
                    MValue = "value0",
                },
                Payee = new PayeeBase
                {
                    EmailAddress = "email_address4",
                    MerchantId = "merchant_id6",
                },
            },
            new PlatformFee
            {
                Amount = new Money
                {
                    CurrencyCode = "currency_code6",
                    MValue = "value0",
                },
                Payee = new PayeeBase
                {
                    EmailAddress = "email_address4",
                    MerchantId = "merchant_id6",
                },
            },
            new PlatformFee
            {
                Amount = new Money
                {
                    CurrencyCode = "currency_code6",
                    MValue = "value0",
                },
                Payee = new PayeeBase
                {
                    EmailAddress = "email_address4",
                    MerchantId = "merchant_id6",
                },
            },
        },
        DisbursementMode = DisbursementMode.Instant,
        PayeeReceivableFxRateId = "payee_receivable_fx_rate_id0",
    },
    NoteToPayer = "note_to_payer0",
};
```

