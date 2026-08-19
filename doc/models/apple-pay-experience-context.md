
# Apple Pay Experience Context

Customizes the payer experience during the approval process for the payment.

## Structure

`ApplePayExperienceContext`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReturnUrl` | `string` | Required | Describes the URL. |
| `CancelUrl` | `string` | Required | Describes the URL. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

ApplePayExperienceContext applePayExperienceContext = new ApplePayExperienceContext
{
    ReturnUrl = "return_url4",
    CancelUrl = "cancel_url6",
};
```

