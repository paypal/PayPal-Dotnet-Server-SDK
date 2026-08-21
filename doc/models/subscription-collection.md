
# Subscription Collection

The list of subscriptions.

## Structure

`SubscriptionCollection`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Subscriptions` | [`List<Subscription>`](../../doc/models/subscription.md) | Optional | An array of subscriptions.<br><br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `32767` |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional, Read-only | An array of request-related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links).<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

SubscriptionCollection subscriptionCollection = new SubscriptionCollection
{
    Subscriptions = new List<Subscription>
    {
        new Subscription
        {
            PlanId = "plan_id8",
            StartTime = "start_time0",
            Quantity = "quantity2",
            ShippingAmount = new Money
            {
                CurrencyCode = "currency_code0",
                MValue = "value6",
            },
        },
        new Subscription
        {
            PlanId = "plan_id8",
            StartTime = "start_time0",
            Quantity = "quantity2",
            ShippingAmount = new Money
            {
                CurrencyCode = "currency_code0",
                MValue = "value6",
            },
        },
    },
};
```

