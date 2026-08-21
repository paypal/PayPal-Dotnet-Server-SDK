
# Plan Collection

The list of plans with details.

## Structure

`PlanCollection`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Plans` | [`List<BillingPlan>`](../../doc/models/billing-plan.md) | Optional | An array of plans.<br><br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `32767` |
| `TotalItems` | `int?` | Optional | The total number of items.<br><br>**Constraints**: `>= 0`, `<= 500000000` |
| `TotalPages` | `int?` | Optional | The total number of pages.<br><br>**Constraints**: `>= 0`, `<= 100000000` |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional, Read-only | An array of request-related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links).<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

PlanCollection planCollection = new PlanCollection
{
    Plans = new List<BillingPlan>
    {
        new BillingPlan
        {
            ProductId = "product_id0",
            Name = "name4",
            Status = SubscriptionPlanStatus.Inactive,
            Description = "description4",
        },
        new BillingPlan
        {
            ProductId = "product_id0",
            Name = "name4",
            Status = SubscriptionPlanStatus.Inactive,
            Description = "description4",
        },
        new BillingPlan
        {
            ProductId = "product_id0",
            Name = "name4",
            Status = SubscriptionPlanStatus.Inactive,
            Description = "description4",
        },
    },
    TotalItems = 244,
    TotalPages = 24,
};
```

