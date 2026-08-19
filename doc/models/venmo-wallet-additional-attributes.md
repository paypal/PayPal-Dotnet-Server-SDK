
# Venmo Wallet Additional Attributes

Additional attributes associated with the use of this Venmo Wallet.

## Structure

`VenmoWalletAdditionalAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customer` | [`VenmoWalletCustomerInformation`](../../doc/models/venmo-wallet-customer-information.md) | Optional | The details about a customer in PayPal's system of record. |
| `Vault` | [`VenmoWalletVaultAttributes`](../../doc/models/venmo-wallet-vault-attributes.md) | Optional | Resource consolidating common request and response attirbutes for vaulting Venmo Wallet. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

VenmoWalletAdditionalAttributes venmoWalletAdditionalAttributes = new VenmoWalletAdditionalAttributes
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
};
```

