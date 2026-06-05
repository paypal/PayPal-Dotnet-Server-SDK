
# Create Order Input

Input structure for the method CreateOrder

## Structure

`CreateOrderInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `Body` | [`OrderRequest`](../../doc/models/order-request.md) | Required | - |
| `PaypalMockResponse` | `string` | Optional | PayPal's REST API uses a request header to invoke negative testing in the sandbox. This header configures the sandbox into a negative testing state for transactions that include the merchant. |
| `PaypalRequestId` | `string` | Optional | The server stores keys for 6 hours. The API callers can request the times to up to 72 hours by speaking to their Account Manager. It is mandatory for all single-step create order calls (E.g. Create Order Request with payment source information like Card, PayPal.vault_id, PayPal.billing_agreement_id, etc).<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `108` |
| `PaypalPartnerAttributionId` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36` |
| `PaypalClientMetadataId` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36` |
| `Prefer` | `string` | Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br><br>**Default**: `"return=minimal"`<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `25`, *Pattern*: `^[a-zA-Z=,-]*$` |
| `PaypalAuthAssertion` | `string` | Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see PayPal-Auth-Assertion. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

CreateOrderInput createOrderInput = new CreateOrderInput
{
    Body = new OrderRequest
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
    },
    PaypalMockResponse = "PayPal-Mock-Response0",
    PaypalRequestId = "PayPal-Request-Id6",
    PaypalPartnerAttributionId = "PayPal-Partner-Attribution-Id2",
    PaypalClientMetadataId = "PayPal-Client-Metadata-Id2",
    Prefer = "return=minimal",
    PaypalAuthAssertion = "PayPal-Auth-Assertion0",
};
```

