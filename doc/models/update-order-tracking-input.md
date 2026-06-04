
# Update Order Tracking Input

Input structure for the method UpdateOrderTracking

## Structure

`UpdateOrderTrackingInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The ID of the order that the tracking information is associated with.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36`, *Pattern*: `^[A-Z0-9]+$` |
| `TrackerId` | `string` | Required | The order tracking ID.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36`, *Pattern*: `^[A-Z0-9]+$` |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `PaypalAuthAssertion` | `string` | Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see PayPal-Auth-Assertion. |
| `Body` | [`List<Patch>`](../../doc/models/patch.md) | Optional | **Constraints**: *Minimum Items*: `0`, *Maximum Items*: `32767` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using PaypalServerSdk.Standard.Utilities;
using System.Collections.Generic;

UpdateOrderTrackingInput updateOrderTrackingInput = new UpdateOrderTrackingInput
{
    Id = "id0",
    TrackerId = "tracker_id2",
    PaypalAuthAssertion = "PayPal-Auth-Assertion0",
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

