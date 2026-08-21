
# Order Request

The order request details.

## Structure

`OrderRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Intent` | [`CheckoutPaymentIntent`](../../doc/models/checkout-payment-intent.md) | Required | The intent to either capture payment immediately or authorize a payment for an order after order creation. |
| `ProcessingInstruction` | [`ProcessingInstruction?`](../../doc/models/processing-instruction.md) | Optional | The instruction to process an order. |
| `Payer` | [`Payer`](../../doc/models/payer.md) | Optional | DEPRECATED. The customer is also known as the payer. The Payer object was intended to only be used with the `payment_source.paypal` object. In order to make this design more clear, the details in the `payer` object are now available under `payment_source.paypal`. Please use `payment_source.paypal`. |
| `PurchaseUnits` | [`List<PurchaseUnitRequest>`](../../doc/models/purchase-unit-request.md) | Required | An array of purchase units. Each purchase unit establishes a contract between a payer and the payee. Each purchase unit represents either a full or partial order that the payer intends to purchase from the payee.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |
| `PaymentSource` | [`PaymentSource`](../../doc/models/payment-source.md) | Optional | The payment source definition. |
| `ApplicationContext` | [`OrderApplicationContext`](../../doc/models/order-application-context.md) | Optional | Customizes the payer experience during the approval process for the payment with PayPal. Note: Partners and Marketplaces might configure brand_name and shipping_preference during partner account setup, which overrides the request values. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

OrderRequest orderRequest = new OrderRequest
{
    Intent = CheckoutPaymentIntent.Capture,
    PurchaseUnits = new List<PurchaseUnitRequest>
    {
        new PurchaseUnitRequest
        {
            Amount = new AmountWithBreakdown
            {
                CurrencyCode = "currency_code6",
                MValue = "value0",
                Breakdown = new AmountBreakdown
                {
                    ItemTotal = new Money
                    {
                        CurrencyCode = "currency_code0",
                        MValue = "value6",
                    },
                    Shipping = new Money
                    {
                        CurrencyCode = "currency_code0",
                        MValue = "value6",
                    },
                    Handling = new Money
                    {
                        CurrencyCode = "currency_code2",
                        MValue = "value8",
                    },
                    TaxTotal = new Money
                    {
                        CurrencyCode = "currency_code4",
                        MValue = "value0",
                    },
                    Insurance = new Money
                    {
                        CurrencyCode = "currency_code2",
                        MValue = "value8",
                    },
                },
            },
            ReferenceId = "reference_id4",
            Payee = new PayeeBase
            {
                EmailAddress = "email_address4",
                MerchantId = "merchant_id6",
            },
            PaymentInstruction = new PaymentInstruction
            {
                PlatformFees = new List<PlatformFee>
                {
                    new PlatformFee
                    {
                        Amount = new Money
                        {
                            CurrencyCode = "currency_code6",
                            MValue = "value0",
                        },
                        Payee = new PayeeBase
                        {
                            EmailAddress = "email_address4",
                            MerchantId = "merchant_id6",
                        },
                    },
                    new PlatformFee
                    {
                        Amount = new Money
                        {
                            CurrencyCode = "currency_code6",
                            MValue = "value0",
                        },
                        Payee = new PayeeBase
                        {
                            EmailAddress = "email_address4",
                            MerchantId = "merchant_id6",
                        },
                    },
                    new PlatformFee
                    {
                        Amount = new Money
                        {
                            CurrencyCode = "currency_code6",
                            MValue = "value0",
                        },
                        Payee = new PayeeBase
                        {
                            EmailAddress = "email_address4",
                            MerchantId = "merchant_id6",
                        },
                    },
                },
                DisbursementMode = DisbursementMode.Instant,
                PayeePricingTierId = "payee_pricing_tier_id2",
                PayeeReceivableFxRateId = "payee_receivable_fx_rate_id0",
            },
            Description = "description6",
            CustomId = "custom_id4",
        },
    },
    ProcessingInstruction = ProcessingInstruction.OrderCompleteOnPaymentApproval,
    Payer = new Payer
    {
        EmailAddress = "email_address6",
        PayerId = "payer_id6",
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
        BirthDate = "birth_date4",
    },
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
    ApplicationContext = new OrderApplicationContext
    {
        BrandName = "brand_name8",
        Locale = "locale2",
        LandingPage = OrderApplicationContextLandingPage.Billing,
        ShippingPreference = OrderApplicationContextShippingPreference.SetProvidedAddress,
        UserAction = OrderApplicationContextUserAction.Continue,
    },
};
```

