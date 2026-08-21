
# Paypal Wallet Attributes Response

Additional attributes associated with the use of a PayPal Wallet.

## Structure

`PaypalWalletAttributesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Vault` | [`PaypalWalletVaultResponse`](../../doc/models/paypal-wallet-vault-response.md) | Optional | The details about a saved PayPal Wallet payment source. |
| `CobrandedCards` | [`List<CobrandedCard>`](../../doc/models/cobranded-card.md) | Optional | An array of merchant cobranded cards used by buyer to complete an order. This array will be present if a merchant has onboarded their cobranded card with PayPal and provided corresponding label(s).<br><br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `25` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

PaypalWalletAttributesResponse paypalWalletAttributesResponse = new PaypalWalletAttributesResponse
{
    Vault = new PaypalWalletVaultResponse
    {
        Id = "id6",
        Status = PaypalWalletVaultStatus.Approved,
        Customer = new PaypalWalletCustomer
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
    CobrandedCards = new List<CobrandedCard>
    {
        new CobrandedCard
        {
            Labels = new List<string>
            {
                "labels4",
                "labels3",
            },
            Payee = new PayeeBase
            {
                EmailAddress = "email_address4",
                MerchantId = "merchant_id6",
            },
            Amount = new Money
            {
                CurrencyCode = "currency_code6",
                MValue = "value0",
            },
        },
        new CobrandedCard
        {
            Labels = new List<string>
            {
                "labels4",
                "labels3",
            },
            Payee = new PayeeBase
            {
                EmailAddress = "email_address4",
                MerchantId = "merchant_id6",
            },
            Amount = new Money
            {
                CurrencyCode = "currency_code6",
                MValue = "value0",
            },
        },
    },
};
```

