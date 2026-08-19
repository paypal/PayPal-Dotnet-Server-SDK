
# Checkout Option

A checkout option as a name-and-value pair.

## Structure

`CheckoutOption`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutOptionName` | `string` | Optional | The checkout option name, such as `color` or `texture`.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `200`, *Pattern*: `^[a-zA-Z0-9_'\-., ":;\!?]*$` |
| `CheckoutOptionValue` | `string` | Optional | The checkout option value. For example, the checkout option `color` might be `blue` or `red` while the checkout option `texture` might be `smooth` or `rippled`.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `200`, *Pattern*: `^[a-zA-Z0-9_'\-., ":;\!?]*$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CheckoutOption checkoutOption = new CheckoutOption
{
    CheckoutOptionName = "checkout_option_name4",
    CheckoutOptionValue = "checkout_option_value8",
};
```

