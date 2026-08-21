
# Sepa Debit Request

An API resource denoting a request to securely store a SEPA Debit.

## Structure

`SepaDebitRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExperienceContext` | [`SepaDebitExperienceContext`](../../doc/models/sepa-debit-experience-context.md) | Optional | Customizes the payer experience during the approval process for the SEPA Debit payment. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

SepaDebitRequest sepaDebitRequest = new SepaDebitRequest
{
    ExperienceContext = new SepaDebitExperienceContext
    {
        ReturnUrl = "return_url4",
        CancelUrl = "cancel_url6",
        Locale = "locale6",
    },
};
```

