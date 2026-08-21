
# Search Response

The search response information.

## Structure

`SearchResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionDetails` | [`List<TransactionDetails>`](../../doc/models/transaction-details.md) | Optional | An array of transaction detail objects.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2147483647` |
| `AccountNumber` | `string` | Optional | The merchant account number.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[a-zA-Z0-9]*$` |
| `StartDate` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `EndDate` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `LastRefreshedDatetime` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `Page` | `int?` | Optional | A zero-relative index of transactions.<br><br>**Constraints**: `>= 0`, `<= 2147483647` |
| `TotalItems` | `int?` | Optional | The total number of transactions as an integer beginning with the specified `page` in the full result and not just in this response.<br><br>**Constraints**: `>= 0`, `<= 2147483647` |
| `TotalPages` | `int?` | Optional | The total number of pages, as an `integer`, when the `total_items` is divided into pages of the specified `page_size`.<br><br>**Constraints**: `>= 0`, `<= 2147483647` |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional, Read-only | An array of request-related [HATEOAS links](https://developer.paypal.com/api/rest/responses/#hateoas-links).<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `32767` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

SearchResponse searchResponse = new SearchResponse
{
    TransactionDetails = new List<TransactionDetails>
    {
        new TransactionDetails
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
        },
        new TransactionDetails
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
        },
    },
    AccountNumber = "account_number4",
    StartDate = "start_date0",
    EndDate = "end_date6",
    LastRefreshedDatetime = "last_refreshed_datetime8",
};
```

