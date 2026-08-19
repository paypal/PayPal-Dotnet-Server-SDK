
# App Switch Context

Merchant provided details of the native app or mobile web browser to facilitate buyer's app switch to the PayPal consumer app.

## Structure

`AppSwitchContext`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NativeApp` | [`NativeAppContext`](../../doc/models/native-app-context.md) | Optional | Merchant provided, buyer's native app preferences to app switch to the PayPal consumer app. |
| `MobileWeb` | [`MobileWebContext`](../../doc/models/mobile-web-context.md) | Optional | Buyer's mobile web browser context to app switch to the PayPal consumer app. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

AppSwitchContext appSwitchContext = new AppSwitchContext
{
    NativeApp = new NativeAppContext
    {
    },
    MobileWeb = new MobileWebContext
    {
        BuyerUserAgent = "buyer_user_agent8",
    },
};
```

