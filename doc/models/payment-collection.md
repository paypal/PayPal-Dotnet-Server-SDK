
# Payment Collection

The collection of payments, or transactions, for a purchase unit in an order. For example, authorized payments, captured payments, and refunds.

## Structure

`PaymentCollection`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Authorizations` | [`List<AuthorizationWithAdditionalData>`](../../doc/models/authorization-with-additional-data.md) | Optional | An array of authorized payments for a purchase unit. A purchase unit can have zero or more authorized payments. |
| `Captures` | [`List<OrdersCapture>`](../../doc/models/orders-capture.md) | Optional | An array of captured payments for a purchase unit. A purchase unit can have zero or more captured payments. |
| `Refunds` | [`List<Refund>`](../../doc/models/refund.md) | Optional | An array of refunds for a purchase unit. A purchase unit can have zero or more refunds. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

PaymentCollection paymentCollection = new PaymentCollection
{
    Authorizations = new List<AuthorizationWithAdditionalData>
    {
        new AuthorizationWithAdditionalData
        {
            StatusDetails = new AuthorizationStatusDetails
            {
                Reason = AuthorizationIncompleteReason.PendingReview,
            },
            Amount = new Money
            {
                CurrencyCode = "currency_code6",
                MValue = "value0",
            },
        },
    },
    Captures = new List<OrdersCapture>
    {
        new OrdersCapture
        {
            StatusDetails = new CaptureStatusDetails
            {
                Reason = CaptureIncompleteReason.VerificationRequired,
            },
            Amount = new Money
            {
                CurrencyCode = "currency_code6",
                MValue = "value0",
            },
        },
        new OrdersCapture
        {
            StatusDetails = new CaptureStatusDetails
            {
                Reason = CaptureIncompleteReason.VerificationRequired,
            },
            Amount = new Money
            {
                CurrencyCode = "currency_code6",
                MValue = "value0",
            },
        },
        new OrdersCapture
        {
            StatusDetails = new CaptureStatusDetails
            {
                Reason = CaptureIncompleteReason.VerificationRequired,
            },
            Amount = new Money
            {
                CurrencyCode = "currency_code6",
                MValue = "value0",
            },
        },
    },
    Refunds = new List<Refund>
    {
        new Refund
        {
            StatusDetails = new RefundStatusDetails
            {
                Reason = RefundIncompleteReason.Echeck,
            },
            Amount = new Money
            {
                CurrencyCode = "currency_code6",
                MValue = "value0",
            },
        },
    },
};
```

