
# Apple Pay Attributes

Additional attributes associated with apple pay.

## Structure

`ApplePayAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customer` | [`CustomerInformation`](../../doc/models/customer-information.md) | Optional | This object represents a merchant’s customer, allowing them to store contact details, and track all payments associated with the same customer. |
| `Vault` | [`VaultInstruction`](../../doc/models/vault-instruction.md) | Optional | Base vaulting specification. The object can be extended for specific use cases within each payment_source that supports vaulting. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

ApplePayAttributes applePayAttributes = new ApplePayAttributes
{
    Customer = new CustomerInformation
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
    Vault = new VaultInstruction
    {
        StoreInVault = StoreInVaultInstruction.OnSuccess,
    },
};
```

