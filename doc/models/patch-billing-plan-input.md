
# Patch Billing Plan Input

Input structure for the method PatchBillingPlan

## Structure

`PatchBillingPlanInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The ID of the plan. |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `Body` | [`List<Patch>`](../../doc/models/patch.md) | Optional | - |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using PaypalServerSdk.Standard.Utilities;
using System.Collections.Generic;

PatchBillingPlanInput patchBillingPlanInput = new PatchBillingPlanInput
{
    Id = "id0",
    Body = new List<Patch>
    {
        new Patch
        {
            Op = PatchOp.Add,
            Path = "path0",
            MValue = ApiHelper.JsonDeserialize<JsonValue>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            From = "from6",
        },
    },
};
```

