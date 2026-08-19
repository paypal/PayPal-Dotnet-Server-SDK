
# Bank Request

A Resource representing a request to vault a Bank used for ACH Debit.

## Structure

`BankRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AchDebit` | `JsonValue` | Optional | A Resource representing a request to vault a ACH Debit. |
| `SepaDebit` | [`SepaDebitRequest`](../../doc/models/sepa-debit-request.md) | Optional | An API resource denoting a request to securely store a SEPA Debit. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using PaypalServerSdk.Standard.Utilities;

BankRequest bankRequest = new BankRequest
{
    AchDebit = ApiHelper.JsonDeserialize<JsonValue>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    SepaDebit = new SepaDebitRequest
    {
        ExperienceContext = new SepaDebitExperienceContext
        {
            ReturnUrl = "return_url4",
            CancelUrl = "cancel_url6",
            Locale = "locale6",
        },
    },
};
```

