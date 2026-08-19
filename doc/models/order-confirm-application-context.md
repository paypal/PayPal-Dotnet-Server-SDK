
# Order Confirm Application Context

Customizes the payer confirmation experience.

## Structure

`OrderConfirmApplicationContext`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BrandName` | `string` | Optional | Label to present to your payer as part of the PayPal hosted web experience.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127` |
| `Locale` | `string` | Optional | The [language tag](https://tools.ietf.org/html/bcp47#section-2) for the language in which to localize the error-related strings, such as messages, issues, and suggested actions. The tag is made up of the [ISO 639-2 language code](https://www.loc.gov/standards/iso639-2/php/code_list.php), the optional [ISO-15924 script tag](https://www.unicode.org/iso15924/codelists.html), and the [ISO-3166 alpha-2 country code](https://developer.paypal.com/api/rest/reference/country-codes/) or [M49 region code](https://unstats.un.org/unsd/methodology/m49/).<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `10`, *Pattern*: `^[a-z]{2}(?:-[A-Z][a-z]{3})?(?:-(?:[A-Z]{2}\|[0-9]{3}))?$` |
| `ReturnUrl` | `string` | Optional | The URL where the customer is redirected after the customer approves the payment.<br><br>**Constraints**: *Minimum Length*: `10`, *Maximum Length*: `4000` |
| `CancelUrl` | `string` | Optional | The URL where the customer is redirected after the customer cancels the payment.<br><br>**Constraints**: *Minimum Length*: `10`, *Maximum Length*: `4000` |
| `StoredPaymentSource` | [`StoredPaymentSource`](../../doc/models/stored-payment-source.md) | Optional | Provides additional details to process a payment using a `payment_source` that has been stored or is intended to be stored (also referred to as stored_credential or card-on-file). Parameter compatibility: `payment_type=ONE_TIME` is compatible only with `payment_initiator=CUSTOMER`. `usage=FIRST` is compatible only with `payment_initiator=CUSTOMER`. `previous_transaction_reference` or `previous_network_transaction_reference` is compatible only with `payment_initiator=MERCHANT`. Only one of the parameters - `previous_transaction_reference` and `previous_network_transaction_reference` - can be present in the request. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

OrderConfirmApplicationContext orderConfirmApplicationContext = new OrderConfirmApplicationContext
{
    BrandName = "brand_name4",
    Locale = "locale8",
    ReturnUrl = "return_url6",
    CancelUrl = "cancel_url8",
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
};
```

