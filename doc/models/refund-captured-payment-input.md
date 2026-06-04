
# Refund Captured Payment Input

Input structure for the method RefundCapturedPayment

## Structure

`RefundCapturedPaymentInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CaptureId` | `string` | Required | The PayPal-generated ID for the captured payment to refund. |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `PaypalMockResponse` | `string` | Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |
| `PaypalRequestId` | `string` | Optional | The server stores keys for 45 days. |
| `Prefer` | `string` | Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br><br>**Default**: `"return=minimal"` |
| `PaypalAuthAssertion` | `string` | Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion). Note:For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject. |
| `Body` | [`RefundRequest`](../../doc/models/refund-request.md) | Optional | - |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

RefundCapturedPaymentInput refundCapturedPaymentInput = new RefundCapturedPaymentInput
{
    CaptureId = "capture_id2",
    PaypalMockResponse = "PayPal-Mock-Response0",
    PaypalRequestId = "PayPal-Request-Id6",
    Prefer = "return=minimal",
    PaypalAuthAssertion = "PayPal-Auth-Assertion0",
    Body = new RefundRequest
    {
        Amount = new Money
        {
            CurrencyCode = "currency_code6",
            MValue = "value0",
        },
        CustomId = "custom_id4",
        InvoiceId = "invoice_id6",
        NoteToPayer = "note_to_payer8",
        PaymentInstruction = new RefundPaymentInstruction
        {
            PlatformFees = new List<RefundPlatformFee>
            {
                new RefundPlatformFee
                {
                    Amount = new Money
                    {
                        CurrencyCode = "currency_code6",
                        MValue = "value0",
                    },
                },
                new RefundPlatformFee
                {
                    Amount = new Money
                    {
                        CurrencyCode = "currency_code6",
                        MValue = "value0",
                    },
                },
                new RefundPlatformFee
                {
                    Amount = new Money
                    {
                        CurrencyCode = "currency_code6",
                        MValue = "value0",
                    },
                },
            },
        },
    },
};
```

