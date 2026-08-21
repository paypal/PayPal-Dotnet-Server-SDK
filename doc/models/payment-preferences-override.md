
# Payment Preferences Override

The payment preferences to override at subscription level.

## Structure

`PaymentPreferencesOverride`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AutoBillOutstanding` | `bool?` | Optional | Indicates whether to automatically bill the outstanding amount in the next billing cycle. |
| `SetupFee` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `SetupFeeFailureAction` | [`SetupFeeFailureAction?`](../../doc/models/setup-fee-failure-action.md) | Optional | The action to take on the subscription if the initial payment for the setup fails.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `24`, *Pattern*: `^[A-Z_]+$` |
| `PaymentFailureThreshold` | `int?` | Optional | The maximum number of payment failures before a subscription is suspended. For example, if `payment_failure_threshold` is `2`, the subscription automatically updates to the `SUSPEND` state if two consecutive payments fail.<br><br>**Constraints**: `>= 0`, `<= 999` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

PaymentPreferencesOverride paymentPreferencesOverride = new PaymentPreferencesOverride
{
    AutoBillOutstanding = false,
    SetupFee = new Money
    {
        CurrencyCode = "currency_code8",
        MValue = "value4",
    },
    SetupFeeFailureAction = SetupFeeFailureAction.Continue,
    PaymentFailureThreshold = 148,
};
```

