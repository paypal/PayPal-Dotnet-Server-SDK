
# Capture Subscription Request

The charge amount from the subscriber.

## Structure

`CaptureSubscriptionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Note` | `string` | Required | The reason or note for the subscription charge.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `128`, *Pattern*: `^.*$` |
| `CaptureType` | [`CaptureType`](../../doc/models/capture-type.md) | Required | The type of capture.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `24`, *Pattern*: `^[A-Z_]+$` |
| `Amount` | [`Money`](../../doc/models/money.md) | Required | The currency and amount for a financial transaction, such as a balance or payment due. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CaptureSubscriptionRequest captureSubscriptionRequest = new CaptureSubscriptionRequest
{
    Note = "note2",
    CaptureType = CaptureType.OutstandingBalance,
    Amount = new Money
    {
        CurrencyCode = "currency_code6",
        MValue = "value0",
    },
};
```

