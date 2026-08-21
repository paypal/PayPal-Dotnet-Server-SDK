
# Shipping Information

The shipping information.

## Structure

`ShippingInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The recipient's name.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9_'\-., ":;\!?]*$` |
| `Method` | `string` | Optional | The shipping method that is associated with this order.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9_'\-., ":;\!?]*$` |
| `Address` | [`SimplePostalAddressCoarseGrained`](../../doc/models/simple-postal-address-coarse-grained.md) | Optional | A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone. |
| `SecondaryShippingAddress` | [`SimplePostalAddressCoarseGrained`](../../doc/models/simple-postal-address-coarse-grained.md) | Optional | A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

ShippingInformation shippingInformation = new ShippingInformation
{
    Name = "name2",
    Method = "method4",
    Address = new SimplePostalAddressCoarseGrained
    {
        Line1 = "line18",
        City = "city6",
        CountryCode = "country_code6",
        Line2 = "line20",
        State = "state2",
        PostalCode = "postal_code8",
    },
    SecondaryShippingAddress = new SimplePostalAddressCoarseGrained
    {
        Line1 = "line16",
        City = "city4",
        CountryCode = "country_code4",
        Line2 = "line28",
        State = "state0",
        PostalCode = "postal_code6",
    },
};
```

