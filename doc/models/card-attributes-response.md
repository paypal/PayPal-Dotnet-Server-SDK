
# Card Attributes Response

Additional attributes associated with the use of this card.

## Structure

`CardAttributesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Vault` | [`CardVaultResponse`](../../doc/models/card-vault-response.md) | Optional | The details about a saved Card payment source. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CardAttributesResponse cardAttributesResponse = new CardAttributesResponse
{
    Vault = new CardVaultResponse
    {
        Id = "id6",
        Status = VaultStatus.Approved,
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
    },
};
```

