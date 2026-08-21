
# Card Experience Context

Customizes the payer experience during the 3DS Approval for payment.

## Structure

`CardExperienceContext`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReturnUrl` | `string` | Optional | Describes the URL. |
| `CancelUrl` | `string` | Optional | Describes the URL. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CardExperienceContext cardExperienceContext = new CardExperienceContext
{
    ReturnUrl = "return_url0",
    CancelUrl = "cancel_url2",
};
```

