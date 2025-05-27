
# Paypal Wallet Experience Context

Customizes the payer experience during the approval process for payment with PayPal. Note: Partners and Marketplaces might configure brand_name and shipping_preference during partner account setup, which overrides the request values.

## Structure

`PaypalWalletExperienceContext`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BrandName` | `string` | Optional | The label that overrides the business name in the PayPal account on the PayPal site. The pattern is defined by an external party and supports Unicode.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127`, *Pattern*: `^.*$` |
| `Locale` | `string` | Optional | The [language tag](https://tools.ietf.org/html/bcp47#section-2) for the language in which to localize the error-related strings, such as messages, issues, and suggested actions. The tag is made up of the [ISO 639-2 language code](https://www.loc.gov/standards/iso639-2/php/code_list.php), the optional [ISO-15924 script tag](https://www.unicode.org/iso15924/codelists.html), and the [ISO-3166 alpha-2 country code](/api/rest/reference/country-codes/) or [M49 region code](https://unstats.un.org/unsd/methodology/m49/).<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `10`, *Pattern*: `^[a-z]{2}(?:-[A-Z][a-z]{3})?(?:-(?:[A-Z]{2}\|[0-9]{3}))?$` |
| `ShippingPreference` | [`PaypalWalletContextShippingPreference?`](../../doc/models/paypal-wallet-context-shipping-preference.md) | Optional | The location from which the shipping address is derived.<br><br>**Default**: `PaypalWalletContextShippingPreference.GET_FROM_FILE`<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `24`, *Pattern*: `^[A-Z_]+$` |
| `ContactPreference` | [`PaypalWalletContactPreference?`](../../doc/models/paypal-wallet-contact-preference.md) | Optional | The preference to display the contact information (buyer’s shipping email & phone number) on PayPal's checkout for easy merchant-buyer communication.<br><br>**Default**: `PaypalWalletContactPreference.NO_CONTACT_INFO`<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `24`, *Pattern*: `^[A-Z_]+$` |
| `ReturnUrl` | `string` | Optional | Describes the URL. |
| `CancelUrl` | `string` | Optional | Describes the URL. |
| `LandingPage` | [`PaypalExperienceLandingPage?`](../../doc/models/paypal-experience-landing-page.md) | Optional | The type of landing page to show on the PayPal site for customer checkout.<br><br>**Default**: `PaypalExperienceLandingPage.NO_PREFERENCE`<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `13`, *Pattern*: `^[0-9A-Z_]+$` |
| `UserAction` | [`PaypalExperienceUserAction?`](../../doc/models/paypal-experience-user-action.md) | Optional | Configures a Continue or Pay Now checkout flow.<br><br>**Default**: `PaypalExperienceUserAction.CONTINUE`<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `8`, *Pattern*: `^[0-9A-Z_]+$` |
| `PaymentMethodPreference` | [`PayeePaymentMethodPreference?`](../../doc/models/payee-payment-method-preference.md) | Optional | The merchant-preferred payment methods.<br><br>**Default**: `PayeePaymentMethodPreference.UNRESTRICTED`<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9A-Z_]+$` |
| `OrderUpdateCallbackConfig` | [`CallbackConfiguration`](../../doc/models/callback-configuration.md) | Optional | CallBack Configuration that the merchant can provide to PayPal/Venmo. |

## Example (as JSON)

```json
{
  "shipping_preference": "GET_FROM_FILE",
  "contact_preference": "NO_CONTACT_INFO",
  "landing_page": "NO_PREFERENCE",
  "user_action": "CONTINUE",
  "payment_method_preference": "UNRESTRICTED",
  "brand_name": "brand_name6",
  "locale": "locale0",
  "return_url": "return_url8"
}
```

