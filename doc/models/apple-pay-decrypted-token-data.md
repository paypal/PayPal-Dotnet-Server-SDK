
# Apple Pay Decrypted Token Data

Information about the Payment data obtained by decrypting Apple Pay token.

## Structure

`ApplePayDecryptedTokenData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `TokenizedCard` | [`ApplePayTokenizedCard`](../../doc/models/apple-pay-tokenized-card.md) | Required | The payment card to use to fund a payment. Can be a credit or debit card. |
| `DeviceManufacturerId` | `string` | Optional | Apple Pay Hex-encoded device manufacturer identifier. The pattern is defined by an external party and supports Unicode.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2000`, *Pattern*: `^.*$` |
| `PaymentDataType` | [`ApplePayPaymentDataType?`](../../doc/models/apple-pay-payment-data-type.md) | Optional | Indicates the type of payment data passed, in case of Non China the payment data is 3DSECURE and for China it is EMV.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `16`, *Pattern*: `^[0-9A-Z_]+$` |
| `PaymentData` | [`ApplePayPaymentData`](../../doc/models/apple-pay-payment-data.md) | Optional | Information about the decrypted apple pay payment data for the token like cryptogram, eci indicator. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

ApplePayDecryptedTokenData applePayDecryptedTokenData = new ApplePayDecryptedTokenData
{
    TokenizedCard = new ApplePayTokenizedCard
    {
        Name = "name4",
        Number = "number2",
        Expiry = "expiry2",
        Type = CardType.Unknown,
    },
    TransactionAmount = new Money
    {
        CurrencyCode = "currency_code6",
        MValue = "value2",
    },
    DeviceManufacturerId = "device_manufacturer_id8",
    PaymentDataType = ApplePayPaymentDataType.Enum3Dsecure,
    PaymentData = new ApplePayPaymentData
    {
        Cryptogram = "cryptogram6",
        EciIndicator = "eci_indicator0",
        EmvData = "emv_data0",
        Pin = "pin4",
    },
};
```

