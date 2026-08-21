
# Apple Pay Attributes Response

Additional attributes associated with the use of Apple Pay.

## Structure

`ApplePayAttributesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Vault` | [`VaultResponse`](../../doc/models/vault-response.md) | Optional | The details about a saved payment source. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

ApplePayAttributesResponse applePayAttributesResponse = new ApplePayAttributesResponse
{
    Vault = new VaultResponse
    {
        Id = "id6",
        Status = VaultStatus.Approved,
        Customer = new VaultCustomer
        {
            Id = "id0",
            Name = new Name
            {
                GivenName = "given_name2",
                Surname = "surname8",
            },
        },
    },
};
```

