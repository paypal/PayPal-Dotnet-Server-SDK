
# Payment Source Response

The payment source used to fund the payment.

## Structure

`PaymentSourceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`CardResponse`](../../doc/models/card-response.md) | Optional | The payment card to use to fund a payment. Card can be a credit or debit card. |
| `Paypal` | [`PaypalWalletResponse`](../../doc/models/paypal-wallet-response.md) | Optional | The PayPal Wallet response. |
| `Bancontact` | [`BancontactPaymentObject`](../../doc/models/bancontact-payment-object.md) | Optional | Information used to pay Bancontact. |
| `Blik` | [`BlikPaymentObject`](../../doc/models/blik-payment-object.md) | Optional | Information used to pay using BLIK. |
| `Eps` | [`EpsPaymentObject`](../../doc/models/eps-payment-object.md) | Optional | Information used to pay using eps. |
| `Giropay` | [`GiropayPaymentObject`](../../doc/models/giropay-payment-object.md) | Optional | Information needed to pay using giropay. |
| `Ideal` | [`IdealPaymentObject`](../../doc/models/ideal-payment-object.md) | Optional | Information used to pay using iDEAL. |
| `Mybank` | [`MybankPaymentObject`](../../doc/models/mybank-payment-object.md) | Optional | Information used to pay using MyBank. |
| `P24` | [`P24PaymentObject`](../../doc/models/p24-payment-object.md) | Optional | Information used to pay using P24(Przelewy24). |
| `Sofort` | [`SofortPaymentObject`](../../doc/models/sofort-payment-object.md) | Optional | Information used to pay using Sofort. |
| `Trustly` | [`TrustlyPaymentObject`](../../doc/models/trustly-payment-object.md) | Optional | Information needed to pay using Trustly. |
| `ApplePay` | [`ApplePayPaymentObject`](../../doc/models/apple-pay-payment-object.md) | Optional | Information needed to pay using ApplePay. |
| `GooglePay` | [`GooglePayWalletResponse`](../../doc/models/google-pay-wallet-response.md) | Optional | Google Pay Wallet payment data. |
| `Venmo` | [`VenmoWalletResponse`](../../doc/models/venmo-wallet-response.md) | Optional | Venmo wallet response. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

PaymentSourceResponse paymentSourceResponse = new PaymentSourceResponse
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
    Bancontact = new BancontactPaymentObject
    {
        Name = "name0",
        CountryCode = "country_code0",
        Bic = "bic2",
        IbanLastChars = "iban_last_chars8",
        CardLastDigits = "card_last_digits4",
    },
    Blik = new BlikPaymentObject
    {
        Name = "name2",
        CountryCode = "country_code2",
        Email = "email4",
        OneClick = new BlikOneClickPaymentObject
        {
            ConsumerReference = "consumer_reference2",
        },
    },
    Eps = new EpsPaymentObject
    {
        Name = "name6",
        CountryCode = "country_code6",
        Bic = "bic8",
    },
};
```

