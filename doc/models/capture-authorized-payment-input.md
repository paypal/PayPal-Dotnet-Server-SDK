
# Capture Authorized Payment Input

Input structure for the method CaptureAuthorizedPayment

## Structure

`CaptureAuthorizedPaymentInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AuthorizationId` | `string` | Required | The PayPal-generated ID for the authorized payment to capture. |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `PaypalMockResponse` | `string` | Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |
| `PaypalRequestId` | `string` | Optional | The server stores keys for 45 days. |
| `Prefer` | `string` | Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br><br>**Default**: `"return=minimal"` |
| `PaypalAuthAssertion` | `string` | Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion). Note:For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject. |
| `Body` | [`CaptureRequest`](../../doc/models/capture-request.md) | Optional | - |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

CaptureAuthorizedPaymentInput captureAuthorizedPaymentInput = new CaptureAuthorizedPaymentInput
{
    AuthorizationId = "authorization_id8",
    PaypalMockResponse = "PayPal-Mock-Response0",
    PaypalRequestId = "PayPal-Request-Id6",
    Prefer = "return=minimal",
    PaypalAuthAssertion = "PayPal-Auth-Assertion0",
    Body = new CaptureRequest
    {
        Amount = new Money
        {
            CurrencyCode = "currency_code6",
            MValue = "value0",
        },
        InvoiceId = "invoice_id6",
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
        NoteToPayer = "note_to_payer8",
    },
};
```

