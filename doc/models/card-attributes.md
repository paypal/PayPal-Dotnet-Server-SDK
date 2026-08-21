
# Card Attributes

Additional attributes associated with the use of this card.

## Structure

`CardAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customer` | [`CardCustomerInformation`](../../doc/models/card-customer-information.md) | Optional | The details about a customer in PayPal's system of record. |
| `Vault` | [`VaultInstructionBase`](../../doc/models/vault-instruction-base.md) | Optional | Basic vault instruction specification that can be extended by specific payment sources that supports vaulting. |
| `Verification` | [`CardVerification`](../../doc/models/card-verification.md) | Optional | The API caller can opt in to verify the card through PayPal offered verification services (e.g. Smart Dollar Auth, 3DS). |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CardAttributes cardAttributes = new CardAttributes
{
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
    Vault = new VaultInstructionBase
    {
        StoreInVault = StoreInVaultInstruction.OnSuccess,
    },
    Verification = new CardVerification
    {
        Method = OrdersCardVerificationMethod.Enum3DSecure,
    },
};
```

