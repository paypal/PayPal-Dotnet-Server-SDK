
# List Subscription Transactions Input

Input structure for the method ListSubscriptionTransactions

## Structure

`ListSubscriptionTransactionsInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The ID of the subscription. |
| `StartTime` | `string` | Required | The start time of the range of transactions to list.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `EndTime` | `string` | Required | The end time of the range of transactions to list.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

ListSubscriptionTransactionsInput listSubscriptionTransactionsInput = new ListSubscriptionTransactionsInput
{
    Id = "id0",
    StartTime = "start_time6",
    EndTime = "end_time2",
};
```

