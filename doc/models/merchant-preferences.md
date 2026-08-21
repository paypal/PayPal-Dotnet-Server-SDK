
# Merchant Preferences

The merchant preferences for a subscription.

## Structure

`MerchantPreferences`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReturnUrl` | `string` | Optional | The URL where the customer is redirected after the customer approves the payment.<br><br>**Constraints**: *Minimum Length*: `10`, *Maximum Length*: `4000` |
| `CancelUrl` | `string` | Optional | The URL where the customer is redirected after the customer cancels the payment.<br><br>**Constraints**: *Minimum Length*: `10`, *Maximum Length*: `4000` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

MerchantPreferences merchantPreferences = new MerchantPreferences
{
    ReturnUrl = "return_url8",
    CancelUrl = "cancel_url0",
};
```

