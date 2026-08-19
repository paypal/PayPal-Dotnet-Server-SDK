
# Venmo Wallet Request

Information needed to pay using Venmo.

## Structure

`VenmoWalletRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `VaultId` | `string` | Optional | The PayPal-generated ID for the vaulted payment source. This ID should be stored on the merchant's server so the saved payment source can be used for future transactions.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9a-zA-Z_-]+$` |
| `EmailAddress` | `string` | Optional | The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `254`, *Pattern*: ``(?:[a-zA-Z0-9!#$%&'*+/=?^_`{\|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{\|}~-]+)*\|(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]\|\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\|\[(?:(?:(2(5[0-5]\|[0-4][0-9])\|1[0-9][0-9]\|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]\|[0-4][0-9])\|1[0-9][0-9]\|[1-9]?[0-9])\|[a-zA-Z0-9-]*[a-zA-Z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]\|\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])`` |
| `ExperienceContext` | [`VenmoWalletExperienceContext`](../../doc/models/venmo-wallet-experience-context.md) | Optional | Customizes the buyer experience during the approval process for payment with Venmo. Note: Partners and Marketplaces might configure shipping_preference during partner account setup, which overrides the request values. |
| `Attributes` | [`VenmoWalletAdditionalAttributes`](../../doc/models/venmo-wallet-additional-attributes.md) | Optional | Additional attributes associated with the use of this Venmo Wallet. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

VenmoWalletRequest venmoWalletRequest = new VenmoWalletRequest
{
    VaultId = "vault_id8",
    EmailAddress = "email_address8",
    ExperienceContext = new VenmoWalletExperienceContext
    {
        BrandName = "brand_name2",
        ShippingPreference = VenmoWalletExperienceContextShippingPreference.NoShipping,
        OrderUpdateCallbackConfig = new CallbackConfiguration
        {
            CallbackEvents = new List<CallbackEvents>
            {
                CallbackEvents.ShippingOptions,
                CallbackEvents.ShippingAddress,
                CallbackEvents.ShippingOptions,
            },
            CallbackUrl = "callback_url6",
        },
        UserAction = VenmoWalletExperienceContextUserAction.Continue,
    },
    Attributes = new VenmoWalletAdditionalAttributes
    {
        Customer = new VenmoWalletCustomerInformation
        {
            Id = "id0",
            EmailAddress = "email_address2",
            Phone = new PhoneWithType
            {
                PhoneNumber = new PhoneNumber
                {
                    NationalNumber = "national_number6",
                },
                PhoneType = PhoneType.Other,
            },
            Name = new Name
            {
                GivenName = "given_name2",
                Surname = "surname8",
            },
        },
        Vault = new VenmoWalletVaultAttributes
        {
            StoreInVault = StoreInVaultInstruction.OnSuccess,
            UsageType = VenmoPaymentTokenUsageType.Merchant,
            Description = "description6",
            UsagePattern = VenmoPaymentTokenUsagePattern.ThresholdPrepaid,
            CustomerType = VenmoPaymentTokenCustomerType.Consumer,
            PermitMultiplePaymentTokens = false,
        },
    },
};
```

