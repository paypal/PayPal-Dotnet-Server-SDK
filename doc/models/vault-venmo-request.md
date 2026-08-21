
# Vault Venmo Request

A resource representing a request to vault Venmo.

## Structure

`VaultVenmoRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | The description displayed to the consumer on the approval flow for a digital wallet, as well as on the merchant view of the payment token management experience. exp: PayPal.com.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `128`, *Pattern*: `^.*$` |
| `UsagePattern` | [`UsagePattern?`](../../doc/models/usage-pattern.md) | Optional | Expected business/charge model for the billing agreement.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `30`, *Pattern*: `^[0-9A-Z_]+$` |
| `Shipping` | [`VaultedDigitalWalletShippingDetails`](../../doc/models/vaulted-digital-wallet-shipping-details.md) | Optional | The shipping details. |
| `PermitMultiplePaymentTokens` | `bool?` | Optional | Create multiple payment tokens for the same payer, merchant/platform combination. Use this when the customer has not logged in at merchant/platform. The payment token thus generated, can then also be used to create the customer account at merchant/platform. Use this also when multiple payment tokens are required for the same payer, different customer at merchant/platform. This helps to identify customers distinctly even though they may share the same PayPal account. This only applies to PayPal payment source.<br><br>**Default**: `false` |
| `UsageType` | [`PaypalPaymentTokenUsageType?`](../../doc/models/paypal-payment-token-usage-type.md) | Optional | The usage type associated with a digital wallet payment token.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9A-Z_]+$` |
| `CustomerType` | [`PaypalPaymentTokenCustomerType?`](../../doc/models/paypal-payment-token-customer-type.md) | Optional | The customer type associated with a digital wallet payment token. This is to indicate whether the customer acting on the merchant / platform is either a business or a consumer.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9A-Z_]+$` |
| `ExperienceContext` | [`VenmoExperienceContext`](../../doc/models/venmo-experience-context.md) | Optional | A resource representing an experience context of vault a venmo account. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

VaultVenmoRequest vaultVenmoRequest = new VaultVenmoRequest
{
    Description = "description2",
    UsagePattern = UsagePattern.UnscheduledPrepaid,
    Shipping = new VaultedDigitalWalletShippingDetails
    {
        Name = new ShippingName
        {
            FullName = "full_name6",
        },
        EmailAddress = "email_address2",
        PhoneNumber = new PhoneNumberWithCountryCode
        {
            CountryCode = "country_code2",
            NationalNumber = "national_number6",
        },
        Type = FulfillmentType.Shipping,
        Address = new Address
        {
            CountryCode = "country_code6",
            AddressLine1 = "address_line_16",
            AddressLine2 = "address_line_26",
            AdminArea2 = "admin_area_20",
            AdminArea1 = "admin_area_12",
            PostalCode = "postal_code8",
        },
    },
    PermitMultiplePaymentTokens = false,
    UsageType = PaypalPaymentTokenUsageType.Merchant,
};
```

