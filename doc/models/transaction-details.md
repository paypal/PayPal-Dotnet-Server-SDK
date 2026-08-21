
# Transaction Details

The transaction details.

## Structure

`TransactionDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionInfo` | [`TransactionInformation`](../../doc/models/transaction-information.md) | Optional | The transaction information. |
| `PayerInfo` | [`PayerInformation`](../../doc/models/payer-information.md) | Optional | The payer information. |
| `ShippingInfo` | [`ShippingInformation`](../../doc/models/shipping-information.md) | Optional | The shipping information. |
| `CartInfo` | [`CartInformation`](../../doc/models/cart-information.md) | Optional | The cart information. |
| `StoreInfo` | [`StoreInformation`](../../doc/models/store-information.md) | Optional | The store information. |
| `AuctionInfo` | [`AuctionInformation`](../../doc/models/auction-information.md) | Optional | The auction information. |
| `IncentiveInfo` | [`IncentiveInformation`](../../doc/models/incentive-information.md) | Optional | The incentive details. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

TransactionDetails transactionDetails = new TransactionDetails
{
    TransactionInfo = new TransactionInformation
    {
        PaypalAccountId = "paypal_account_id4",
        PaypalReferenceId = "paypal_reference_id2",
        PaypalReferenceIdType = PaypalReferenceIdType.Odr,
        TransactionEventCode = "transaction_event_code6",
    },
    PayerInfo = new PayerInformation
    {
        AccountId = "account_id2",
        EmailAddress = "email_address2",
        PhoneNumber = new Phone
        {
            CountryCode = "country_code2",
            NationalNumber = "national_number6",
            ExtensionNumber = "extension_number8",
        },
        AddressStatus = "address_status2",
        PayerStatus = "payer_status2",
    },
    ShippingInfo = new ShippingInformation
    {
        Name = "name0",
        Method = "method4",
        Address = new SimplePostalAddressCoarseGrained
        {
            Line1 = "line18",
            City = "city6",
            CountryCode = "country_code6",
            Line2 = "line20",
            State = "state2",
            PostalCode = "postal_code8",
        },
        SecondaryShippingAddress = new SimplePostalAddressCoarseGrained
        {
            Line1 = "line16",
            City = "city4",
            CountryCode = "country_code4",
            Line2 = "line28",
            State = "state0",
            PostalCode = "postal_code6",
        },
    },
    CartInfo = new CartInformation
    {
        ItemDetails = new List<ItemDetails>
        {
            new ItemDetails
            {
                ItemCode = "item_code0",
                ItemName = "item_name8",
                ItemDescription = "item_description4",
                ItemOptions = "item_options2",
                ItemQuantity = "item_quantity2",
            },
            new ItemDetails
            {
                ItemCode = "item_code0",
                ItemName = "item_name8",
                ItemDescription = "item_description4",
                ItemOptions = "item_options2",
                ItemQuantity = "item_quantity2",
            },
        },
        TaxInclusive = false,
        PaypalInvoiceId = "paypal_invoice_id6",
    },
    StoreInfo = new StoreInformation
    {
        StoreId = "store_id2",
        TerminalId = "terminal_id6",
    },
};
```

