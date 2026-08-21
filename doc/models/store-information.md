
# Store Information

The store information.

## Structure

`StoreInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StoreId` | `string` | Optional | The ID of a store for a merchant in the system of record.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `100`, *Pattern*: `^[a-zA-Z0-9]*$` |
| `TerminalId` | `string` | Optional | The terminal ID for the checkout stand in a merchant store.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `60`, *Pattern*: `^[a-zA-Z0-9]*$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

StoreInformation storeInformation = new StoreInformation
{
    StoreId = "store_id8",
    TerminalId = "terminal_id2",
};
```

