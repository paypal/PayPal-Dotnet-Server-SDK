
# Confirm Order Request

Payer confirms the intent to pay for the Order using the provided payment source.

## Structure

`ConfirmOrderRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentSource` | [`PaymentSource`](../../doc/models/payment-source.md) | Required | The payment source definition. |
| `ProcessingInstruction` | [`ProcessingInstruction?`](../../doc/models/processing-instruction.md) | Optional | The instruction to process an order. |
| `ApplicationContext` | [`OrderConfirmApplicationContext`](../../doc/models/order-confirm-application-context.md) | Optional | Customizes the payer confirmation experience. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

ConfirmOrderRequest confirmOrderRequest = new ConfirmOrderRequest
{
    PaymentSource = new PaymentSource
    {
        Card = new CardRequest
        {
            Name = "name6",
            Number = "number6",
            Expiry = "expiry4",
            SecurityCode = "security_code8",
            BillingAddress = new Address
            {
                CountryCode = "country_code8",
                AddressLine1 = "address_line_12",
                AddressLine2 = "address_line_28",
                AdminArea2 = "admin_area_28",
                AdminArea1 = "admin_area_14",
                PostalCode = "postal_code0",
            },
        },
        Token = new Token
        {
            Id = "id6",
            Type = TokenType.BillingAgreement,
        },
        Paypal = new PaypalWallet
        {
            VaultId = "vault_id0",
            EmailAddress = "email_address0",
            Name = new Name
            {
                GivenName = "given_name2",
                Surname = "surname8",
            },
            Phone = new PhoneWithType
            {
                PhoneNumber = new PhoneNumber
                {
                    NationalNumber = "national_number6",
                },
                PhoneType = PhoneType.Other,
            },
            BirthDate = "birth_date8",
        },
        Bancontact = new BancontactPaymentRequest
        {
            Name = "name0",
            CountryCode = "country_code0",
            ExperienceContext = new ExperienceContext
            {
                BrandName = "brand_name2",
                Locale = "locale6",
                ShippingPreference = ExperienceContextShippingPreference.NoShipping,
                ReturnUrl = "return_url4",
                CancelUrl = "cancel_url6",
            },
        },
        Blik = new BlikPaymentRequest
        {
            Name = "name2",
            CountryCode = "country_code2",
            Email = "email4",
            ExperienceContext = new BlikExperienceContext
            {
                BrandName = "brand_name2",
                Locale = "locale6",
                ShippingPreference = ExperienceContextShippingPreference.NoShipping,
                ReturnUrl = "return_url4",
                CancelUrl = "cancel_url6",
            },
            Level0 = new BlikLevel0PaymentObject
            {
                AuthCode = "auth_code8",
            },
            OneClick = new BlikOneClickPaymentRequest
            {
                ConsumerReference = "consumer_reference2",
                AuthCode = "auth_code0",
                AliasLabel = "alias_label6",
                AliasKey = "alias_key4",
            },
        },
    },
    ProcessingInstruction = ProcessingInstruction.OrderCompleteOnPaymentApproval,
    ApplicationContext = new OrderConfirmApplicationContext
    {
        BrandName = "brand_name8",
        Locale = "locale2",
        ReturnUrl = "return_url0",
        CancelUrl = "cancel_url2",
        StoredPaymentSource = new StoredPaymentSource
        {
            PaymentInitiator = PaymentInitiator.Customer,
            PaymentType = StoredPaymentSourcePaymentType.Recurring,
            Usage = StoredPaymentSourceUsageType.First,
            PreviousNetworkTransactionReference = new NetworkTransaction
            {
                Id = "id6",
                Date = "date2",
                Network = CardBrand.Confidis,
                AcquirerReferenceNumber = "acquirer_reference_number8",
            },
        },
    },
};
```

