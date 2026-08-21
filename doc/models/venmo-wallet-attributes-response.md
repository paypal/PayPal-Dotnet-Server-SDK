
# Venmo Wallet Attributes Response

Additional attributes associated with the use of a Venmo Wallet.

## Structure

`VenmoWalletAttributesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Vault` | [`VenmoVaultResponse`](../../doc/models/venmo-vault-response.md) | Optional | The details about a saved venmo payment source. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

VenmoWalletAttributesResponse venmoWalletAttributesResponse = new VenmoWalletAttributesResponse
{
    Vault = new VenmoVaultResponse
    {
        Id = "id6",
        Status = VenmoVaultResponseStatus.Approved,
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
    },
};
```

