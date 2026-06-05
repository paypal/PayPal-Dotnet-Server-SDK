
# Void Payment Input

Input structure for the method VoidPayment

## Structure

`VoidPaymentInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AuthorizationId` | `string` | Required | The PayPal-generated ID for the authorized payment to void. |
| `PaypalMockResponse` | `string` | Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |
| `PaypalAuthAssertion` | `string` | Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion). Note:For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject. |
| `PaypalRequestId` | `string` | Optional | The server stores keys for 45 days. |
| `Prefer` | `string` | Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br><br>**Default**: `"return=minimal"` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

VoidPaymentInput voidPaymentInput = new VoidPaymentInput
{
    AuthorizationId = "authorization_id8",
    PaypalMockResponse = "PayPal-Mock-Response0",
    PaypalAuthAssertion = "PayPal-Auth-Assertion0",
    PaypalRequestId = "PayPal-Request-Id6",
    Prefer = "return=minimal",
};
```

