
# Get Order Input

Input structure for the method GetOrder

## Structure

`GetOrderInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The ID of the order for which to show details.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36`, *Pattern*: `^[A-Z0-9]+$` |
| `PaypalMockResponse` | `string` | Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |
| `PaypalAuthAssertion` | `string` | Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see PayPal-Auth-Assertion. |
| `Fields` | `string` | Optional | A comma-separated list of fields that should be returned for the order. Valid filter field is `payment_source`.<br><br>**Constraints**: *Pattern*: `^[a-z_]*$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

GetOrderInput getOrderInput = new GetOrderInput
{
    Id = "id0",
    PaypalMockResponse = "PayPal-Mock-Response0",
    PaypalAuthAssertion = "PayPal-Auth-Assertion0",
    Fields = "fields8",
};
```

