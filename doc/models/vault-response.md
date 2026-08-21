
# Vault Response

The details about a saved payment source.

## Structure

`VaultResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | The PayPal-generated ID for the saved payment source.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255` |
| `Status` | [`VaultStatus?`](../../doc/models/vault-status.md) | Optional | The vault status.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9A-Z_]+$` |
| `Customer` | [`VaultCustomer`](../../doc/models/vault-customer.md) | Optional | This object represents a merchant’s customer, allowing them to store contact details, and track all payments associated with the same customer. |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional, Read-only | An array of request-related HATEOAS links.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

VaultResponse vaultResponse = new VaultResponse
{
    Id = "id2",
    Status = VaultStatus.Vaulted,
    Customer = new VaultCustomer
    {
        Id = "id0",
        Name = new Name
        {
            GivenName = "given_name2",
            Surname = "surname8",
        },
    },
};
```

