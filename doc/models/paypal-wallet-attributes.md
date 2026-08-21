
# Paypal Wallet Attributes

Additional attributes associated with the use of this PayPal Wallet.

## Structure

`PaypalWalletAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customer` | [`PaypalWalletCustomerRequest`](../../doc/models/paypal-wallet-customer-request.md) | Optional | - |
| `Vault` | [`PaypalWalletVaultInstruction`](../../doc/models/paypal-wallet-vault-instruction.md) | Optional | - |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

PaypalWalletAttributes paypalWalletAttributes = new PaypalWalletAttributes
{
    Customer = new PaypalWalletCustomerRequest
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
        MerchantCustomerId = "merchant_customer_id2",
    },
    Vault = new PaypalWalletVaultInstruction
    {
        UsageType = PaypalPaymentTokenUsageType.Merchant,
        StoreInVault = StoreInVaultInstruction.OnSuccess,
        Description = "description6",
        UsagePattern = UsagePattern.ThresholdPrepaid,
        CustomerType = PaypalPaymentTokenCustomerType.Consumer,
        PermitMultiplePaymentTokens = false,
    },
};
```

