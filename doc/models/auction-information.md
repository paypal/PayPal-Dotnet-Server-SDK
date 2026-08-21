
# Auction Information

The auction information.

## Structure

`AuctionInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AuctionSite` | `string` | Optional | The name of the auction site.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `200`, *Pattern*: `^[a-zA-Z0-9_'\-., ":;\!?]*$` |
| `AuctionItemSite` | `string` | Optional | The auction site URL.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `4000`, *Pattern*: `^[a-zA-Z0-9_'\-., ":;\!?]*$` |
| `AuctionBuyerId` | `string` | Optional | The ID of the buyer who makes the purchase in the auction. This ID might be different from the payer ID provided for the payment.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `500`, *Pattern*: `^[a-zA-Z0-9_'\-., ":;\!?]*$` |
| `AuctionClosingDate` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

AuctionInformation auctionInformation = new AuctionInformation
{
    AuctionSite = "auction_site8",
    AuctionItemSite = "auction_item_site0",
    AuctionBuyerId = "auction_buyer_id2",
    AuctionClosingDate = "auction_closing_date8",
};
```

