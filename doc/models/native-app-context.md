
# Native App Context

Merchant provided, buyer's native app preferences to app switch to the PayPal consumer app.

## Structure

`NativeAppContext`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OsType` | [`OsType?`](../../doc/models/os-type.md) | Optional, Read-only | Operating System type of the device that the buyer is using.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `7`, *Pattern*: `^[A-Z_]+$` |
| `OsVersion` | `string` | Optional, Read-only | Operating System version of the device that the buyer is using.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^.*$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

NativeAppContext nativeAppContext = new NativeAppContext
{
};
```

