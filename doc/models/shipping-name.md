
# Shipping Name

The name of the party.

## Structure

`ShippingName`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FullName` | `string` | Optional | When the party is a person, the party's full name.<br><br>**Constraints**: *Maximum Length*: `300` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

ShippingName shippingName = new ShippingName
{
    FullName = "full_name8",
};
```

