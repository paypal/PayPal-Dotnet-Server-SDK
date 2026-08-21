
# Order Authorize Response Payment Source

The payment source used to fund the payment.

## Structure

`OrderAuthorizeResponsePaymentSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`CardResponse`](../../doc/models/card-response.md) | Optional | The payment card to use to fund a payment. Card can be a credit or debit card. |
| `Paypal` | [`PaypalWalletResponse`](../../doc/models/paypal-wallet-response.md) | Optional | The PayPal Wallet response. |
| `ApplePay` | [`ApplePayPaymentObject`](../../doc/models/apple-pay-payment-object.md) | Optional | Information needed to pay using ApplePay. |
| `GooglePay` | [`GooglePayWalletResponse`](../../doc/models/google-pay-wallet-response.md) | Optional | Google Pay Wallet payment data. |
| `Venmo` | [`VenmoWalletResponse`](../../doc/models/venmo-wallet-response.md) | Optional | Venmo wallet response. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

OrderAuthorizeResponsePaymentSource orderAuthorizeResponsePaymentSource = new OrderAuthorizeResponsePaymentSource
{
    Card = new CardResponse
    {
        Name = "name6",
        Brand = CardBrand.CbNationale,
        Type = CardType.Unknown,
    },
    Paypal = new PaypalWalletResponse
    {
        EmailAddress = "email_address0",
        AccountId = "account_id4",
        Name = new Name
        {
            GivenName = "given_name2",
            Surname = "surname8",
        },
        PhoneType = PhoneType.Fax,
    },
    ApplePay = new ApplePayPaymentObject
    {
        Id = "id0",
        Token = "token6",
        Name = "name0",
        EmailAddress = "email_address8",
        PhoneNumber = new PhoneNumber
        {
            NationalNumber = "national_number6",
        },
    },
    GooglePay = new GooglePayWalletResponse
    {
        Name = "name8",
        EmailAddress = "email_address6",
        PhoneNumber = new PhoneNumberWithCountryCode
        {
            CountryCode = "country_code2",
            NationalNumber = "national_number6",
        },
        Card = new GooglePayCardResponse
        {
            Name = "name6",
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
    Venmo = new VenmoWalletResponse
    {
        EmailAddress = "email_address4",
        AccountId = "account_id8",
        UserName = "user_name2",
        Name = new Name
        {
            GivenName = "given_name2",
            Surname = "surname8",
        },
        PhoneNumber = new PhoneNumber
        {
            NationalNumber = "national_number6",
        },
    },
};
```

