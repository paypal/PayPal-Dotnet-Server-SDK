
# Blik One Click Payment Object

Information used to pay using BLIK one-click flow.

## Structure

`BlikOneClickPaymentObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ConsumerReference` | `string` | Optional | The merchant generated, unique reference serving as a primary identifier for accounts connected between Blik and a merchant.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `64`, *Pattern*: `^[ -~]{3,64}$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

BlikOneClickPaymentObject blikOneClickPaymentObject = new BlikOneClickPaymentObject
{
    ConsumerReference = "consumer_reference6",
};
```

