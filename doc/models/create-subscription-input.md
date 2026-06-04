
# Create Subscription Input

Input structure for the method CreateSubscription

## Structure

`CreateSubscriptionInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `Prefer` | `string` | Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br><br>**Default**: `"return=minimal"` |
| `PaypalRequestId` | `string` | Optional | The server stores keys for 72 hours. |
| `PaypalClientMetadataId` | `string` | Optional | The PayPal Client Metadata Id(CMID) is used to provide device-specific information to PayPal's risk engine. This is crucial for transactions that require device-specific risk assessments. Merchants typically use the Paypal SDK that automatically submits the CMID or they use tools like Fraudnet JS for web or Magnes JS for mobile to generate the CMID on the frontend and then pass it to the API as part of the request headers.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36` |
| `Body` | [`CreateSubscriptionRequest`](../../doc/models/create-subscription-request.md) | Optional | - |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

CreateSubscriptionInput createSubscriptionInput = new CreateSubscriptionInput
{
    Prefer = "return=minimal",
    PaypalRequestId = "PayPal-Request-Id6",
    PaypalClientMetadataId = "PayPal-Client-Metadata-Id2",
    Body = new CreateSubscriptionRequest
    {
        PlanId = "plan_id8",
        StartTime = "start_time0",
        Quantity = "quantity2",
        ShippingAmount = new Money
        {
            CurrencyCode = "currency_code0",
            MValue = "value6",
        },
        Subscriber = new SubscriberRequest
        {
            EmailAddress = "email_address8",
            PayerId = "payer_id8",
            Name = new Name
            {
                GivenName = "given_name2",
                Surname = "surname8",
            },
            ShippingAddress = new ShippingDetails
            {
                Name = new ShippingName
                {
                    FullName = "full_name6",
                },
                EmailAddress = "email_address8",
                PhoneNumber = new PhoneNumberWithCountryCode
                {
                    CountryCode = "country_code2",
                    NationalNumber = "national_number6",
                },
                Type = FulfillmentType.PickupInStore,
                Options = new List<ShippingOption>
                {
                    new ShippingOption
                    {
                        Id = "id2",
                        Label = "label2",
                        Selected = false,
                        Type = ShippingType.Shipping,
                        Amount = new Money
                        {
                            CurrencyCode = "currency_code6",
                            MValue = "value0",
                        },
                    },
                },
            },
            PaymentSource = new SubscriptionPaymentSource
            {
                Card = new SubscriptionCardRequest
                {
                    Name = "name6",
                    Number = "number6",
                    Expiry = "expiry4",
                    SecurityCode = "security_code8",
                    Type = CardType.Unknown,
                },
            },
        },
        AutoRenewal = false,
    },
};
```

