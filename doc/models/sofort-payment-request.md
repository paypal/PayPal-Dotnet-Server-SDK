
# Sofort Payment Request

Information needed to pay using Sofort.

## Structure

`SofortPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The full name representation like Mr J Smith.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `300` |
| `CountryCode` | `string` | Required | The [two-character ISO 3166-1 code](https://developer.paypal.com/api/rest/reference/country-codes/) that identifies the country or region. Note: The country code for Great Britain is GB and not UK as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2`, *Pattern*: `^([A-Z]{2}\|C2)$` |
| `ExperienceContext` | [`ExperienceContext`](../../doc/models/experience-context.md) | Optional | Customizes the payer experience during the approval process for the payment. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

SofortPaymentRequest sofortPaymentRequest = new SofortPaymentRequest
{
    Name = "name8",
    CountryCode = "country_code8",
    ExperienceContext = new ExperienceContext
    {
        BrandName = "brand_name2",
        Locale = "locale6",
        ShippingPreference = ExperienceContextShippingPreference.NoShipping,
        ReturnUrl = "return_url4",
        CancelUrl = "cancel_url6",
    },
};
```

