
# Get Authorized Payment Input

Input structure for the method GetAuthorizedPayment

## Structure

`GetAuthorizedPaymentInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AuthorizationId` | `string` | Required | The ID of the authorized payment for which to show details. |
| `PaypalMockResponse` | `string` | Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |
| `PaypalAuthAssertion` | `string` | Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see [PayPal-Auth-Assertion](/docs/api/reference/api-requests/#paypal-auth-assertion). Note:For three party transactions in which a partner is managing the API calls on behalf of a merchant, the partner must identify the merchant using either a PayPal-Auth-Assertion header or an access token with target_subject. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

GetAuthorizedPaymentInput getAuthorizedPaymentInput = new GetAuthorizedPaymentInput
{
    AuthorizationId = "authorization_id8",
    PaypalMockResponse = "PayPal-Mock-Response0",
    PaypalAuthAssertion = "PayPal-Auth-Assertion0",
};
```

