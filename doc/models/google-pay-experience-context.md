
# Google Pay Experience Context

Customizes the payer experience during the approval process for the payment.

## Structure

`GooglePayExperienceContext`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReturnUrl` | `string` | Required | Describes the URL. |
| `CancelUrl` | `string` | Required | Describes the URL. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

GooglePayExperienceContext googlePayExperienceContext = new GooglePayExperienceContext
{
    ReturnUrl = "return_url6",
    CancelUrl = "cancel_url8",
};
```

