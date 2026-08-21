
# Setup Token Request Payment Source

The payment method to vault with the instrument details.

## Structure

`SetupTokenRequestPaymentSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`SetupTokenRequestCard`](../../doc/models/setup-token-request-card.md) | Optional | A Resource representing a request to vault a Card. |
| `Paypal` | [`VaultPaypalWalletRequest`](../../doc/models/vault-paypal-wallet-request.md) | Optional | A resource representing a request to vault PayPal Wallet. |
| `Venmo` | [`VaultVenmoRequest`](../../doc/models/vault-venmo-request.md) | Optional | A resource representing a request to vault Venmo. |
| `ApplePay` | [`VaultApplePayRequest`](../../doc/models/vault-apple-pay-request.md) | Optional | A resource representing a request to vault Apple Pay. |
| `Token` | [`VaultTokenRequest`](../../doc/models/vault-token-request.md) | Optional | The Tokenized Payment Source representing a Request to Vault a Token. |
| `Bank` | [`BankRequest`](../../doc/models/bank-request.md) | Optional | A Resource representing a request to vault a Bank used for ACH Debit. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

SetupTokenRequestPaymentSource setupTokenRequestPaymentSource = new SetupTokenRequestPaymentSource
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
};
```

