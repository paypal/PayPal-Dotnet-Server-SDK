
# Card Vault Response

The details about a saved Card payment source.

## Structure

`CardVaultResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | The PayPal-generated ID for the saved payment source.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255` |
| `Status` | [`VaultStatus?`](../../doc/models/vault-status.md) | Optional | The vault status.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9A-Z_]+$` |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional, Read-only | An array of request-related HATEOAS links.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |
| `Customer` | [`CardCustomerInformation`](../../doc/models/card-customer-information.md) | Optional | The details about a customer in PayPal's system of record. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CardVaultResponse cardVaultResponse = new CardVaultResponse
{
    Id = "id0",
    Status = VaultStatus.Vaulted,
    Customer = new CardCustomerInformation
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
};
```

