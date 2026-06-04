
# Get Refund Input

Input structure for the method GetRefund

## Structure

`GetRefundInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RefundId` | `string` | Required | The PayPal-generated ID for the refund for which to show details. |
| `PaypalMockResponse` | `string` | Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |
| `PaypalAuthAssertion` | `string` | Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion). Note:For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

GetRefundInput getRefundInput = new GetRefundInput
{
    RefundId = "refund_id4",
    PaypalMockResponse = "PayPal-Mock-Response0",
    PaypalAuthAssertion = "PayPal-Auth-Assertion0",
};
```

