
# Subscription Billing Information

The billing details for the subscription. If the subscription was or is active, these fields are populated.

## Structure

`SubscriptionBillingInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OutstandingBalance` | [`Money`](../../doc/models/money.md) | Required | The currency and amount for a financial transaction, such as a balance or payment due. |
| `CycleExecutions` | [`List<CycleExecution>`](../../doc/models/cycle-execution.md) | Optional, Read-only | The trial and regular billing executions.<br><br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `3` |
| `LastPayment` | [`LastPaymentDetails`](../../doc/models/last-payment-details.md) | Optional | The details for the last payment. |
| `NextBillingTime` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `FinalPaymentTime` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `FailedPaymentsCount` | `int` | Required, Read-only | The number of consecutive payment failures. Resets to `0` after a successful payment. If this reaches the `payment_failure_threshold` value, the subscription updates to the `SUSPENDED` state.<br><br>**Constraints**: `>= 0`, `<= 999` |
| `LastFailedPayment` | [`FailedPaymentDetails`](../../doc/models/failed-payment-details.md) | Optional | The details for the failed payment of the subscription. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

SubscriptionBillingInformation subscriptionBillingInformation = new SubscriptionBillingInformation
{
    OutstandingBalance = new Money
    {
        CurrencyCode = "currency_code8",
        MValue = "value4",
    },
    FailedPaymentsCount = 0,
    LastPayment = new LastPaymentDetails
    {
        Amount = new Money
        {
            CurrencyCode = "currency_code6",
            MValue = "value0",
        },
        Time = "time2",
    },
    NextBillingTime = "next_billing_time2",
    FinalPaymentTime = "final_payment_time6",
    LastFailedPayment = new FailedPaymentDetails
    {
        Amount = new Money
        {
            CurrencyCode = "currency_code6",
            MValue = "value0",
        },
        Time = "time4",
        NextPaymentRetryTime = "next_payment_retry_time6",
    },
};
```

