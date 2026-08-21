
# Setup Token Request

Setup Token Request where the `source` defines the type of instrument to be stored.

## Structure

`SetupTokenRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customer` | [`Customer`](../../doc/models/customer.md) | Optional | This object defines a customer in your system. Use it to manage customer profiles, save payment methods and contact details. |
| `PaymentSource` | [`SetupTokenRequestPaymentSource`](../../doc/models/setup-token-request-payment-source.md) | Required | The payment method to vault with the instrument details. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

SetupTokenRequest setupTokenRequest = new SetupTokenRequest
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
};
```

