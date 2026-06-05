
# Create Setup Token Input

Input structure for the method CreateSetupToken

## Structure

`CreateSetupTokenInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `Body` | [`SetupTokenRequest`](../../doc/models/setup-token-request.md) | Required | Setup Token creation with a instrument type optional financial instrument details and customer_id. |
| `PaypalRequestId` | `string` | Optional | The server stores keys for 3 hours.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `108`, *Pattern*: `^.*$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CreateSetupTokenInput createSetupTokenInput = new CreateSetupTokenInput
{
    Body = new SetupTokenRequest
    {
        PaymentSource = new SetupTokenRequestPaymentSource
        {
            Card = new SetupTokenRequestCard
            {
                Name = "name6",
                Number = "number6",
                Expiry = "expiry4",
                SecurityCode = "security_code8",
                Brand = CardBrand.CbNationale,
            },
            Paypal = new VaultPaypalWalletRequest
            {
                Description = "description2",
                UsagePattern = UsagePattern.ThresholdPrepaid,
                Shipping = new VaultedDigitalWalletShippingDetails
                {
                    Name = new ShippingName
                    {
                        FullName = "full_name6",
                    },
                    EmailAddress = "email_address2",
                    PhoneNumber = new PhoneNumberWithCountryCode
                    {
                        CountryCode = "country_code2",
                        NationalNumber = "national_number6",
                    },
                    Type = FulfillmentType.Shipping,
                    Address = new Address
                    {
                        CountryCode = "country_code6",
                        AddressLine1 = "address_line_16",
                        AddressLine2 = "address_line_26",
                        AdminArea2 = "admin_area_20",
                        AdminArea1 = "admin_area_12",
                        PostalCode = "postal_code8",
                    },
                },
                PermitMultiplePaymentTokens = false,
                UsageType = PaypalPaymentTokenUsageType.Merchant,
            },
            Venmo = new VaultVenmoRequest
            {
                Description = "description6",
                UsagePattern = UsagePattern.UnscheduledPrepaid,
                Shipping = new VaultedDigitalWalletShippingDetails
                {
                    Name = new ShippingName
                    {
                        FullName = "full_name6",
                    },
                    EmailAddress = "email_address2",
                    PhoneNumber = new PhoneNumberWithCountryCode
                    {
                        CountryCode = "country_code2",
                        NationalNumber = "national_number6",
                    },
                    Type = FulfillmentType.Shipping,
                    Address = new Address
                    {
                        CountryCode = "country_code6",
                        AddressLine1 = "address_line_16",
                        AddressLine2 = "address_line_26",
                        AdminArea2 = "admin_area_20",
                        AdminArea1 = "admin_area_12",
                        PostalCode = "postal_code8",
                    },
                },
                PermitMultiplePaymentTokens = false,
                UsageType = PaypalPaymentTokenUsageType.Merchant,
            },
            ApplePay = new VaultApplePayRequest
            {
                Token = "token6",
                Card = new ApplePayRequestCard
                {
                    Type = CardType.Unknown,
                    Brand = CardBrand.CbNationale,
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
            },
            Token = new VaultTokenRequest
            {
                Id = "id6",
                Type = VaultTokenRequestType.SetupToken,
            },
        },
        Customer = new Customer
        {
            Id = "id0",
            MerchantCustomerId = "merchant_customer_id2",
        },
    },
    PaypalRequestId = "PayPal-Request-Id6",
};
```

