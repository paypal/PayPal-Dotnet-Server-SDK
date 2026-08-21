
# Blik Payment Request

Information needed to pay using BLIK.

## Structure

`BlikPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The full name representation like Mr J Smith.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `300` |
| `CountryCode` | `string` | Required | The [two-character ISO 3166-1 code](https://developer.paypal.com/api/rest/reference/country-codes/) that identifies the country or region. Note: The country code for Great Britain is GB and not UK as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2`, *Pattern*: `^([A-Z]{2}\|C2)$` |
| `Email` | `string` | Optional | The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `254`, *Pattern*: ``^(?:[A-Za-z0-9!#$%&'*+/=?^_`{\|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_`{\|}~-]+)*\|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]\|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\|\[(?:(?:25[0-5]\|2[0-4][0-9]\|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]\|2[0-4][0-9]\|[01]?[0-9][0-9]?\|[A-Za-z0-9-]*[A-Za-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]\|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])$`` |
| `ExperienceContext` | [`BlikExperienceContext`](../../doc/models/blik-experience-context.md) | Optional | Customizes the payer experience during the approval process for the BLIK payment. |
| `Level0` | [`BlikLevel0PaymentObject`](../../doc/models/blik-level-0-payment-object.md) | Optional | Information used to pay using BLIK level_0 flow. |
| `OneClick` | [`BlikOneClickPaymentRequest`](../../doc/models/blik-one-click-payment-request.md) | Optional | Information used to pay using BLIK one-click flow. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

BlikPaymentRequest blikPaymentRequest = new BlikPaymentRequest
{
    Name = "name6",
    CountryCode = "country_code6",
    Email = "email0",
    ExperienceContext = new BlikExperienceContext
    {
        BrandName = "brand_name2",
        Locale = "locale6",
        ShippingPreference = ExperienceContextShippingPreference.NoShipping,
        ReturnUrl = "return_url4",
        CancelUrl = "cancel_url6",
    },
    Level0 = new BlikLevel0PaymentObject
    {
        AuthCode = "auth_code8",
    },
    OneClick = new BlikOneClickPaymentRequest
    {
        ConsumerReference = "consumer_reference2",
        AuthCode = "auth_code0",
        AliasLabel = "alias_label6",
        AliasKey = "alias_key4",
    },
};
```

