# Subscriptions

Use the `/subscriptions` resource to create, update, retrieve, and cancel subscriptions and their associated plans.

```csharp
SubscriptionsController subscriptionsController = client.SubscriptionsController;
```

## Class Name

`SubscriptionsController`

## Methods

* [Create Billing Plan](../../doc/controllers/subscriptions.md#create-billing-plan)
* [List Billing Plans](../../doc/controllers/subscriptions.md#list-billing-plans)
* [Get Billing Plan](../../doc/controllers/subscriptions.md#get-billing-plan)
* [Patch Billing Plan](../../doc/controllers/subscriptions.md#patch-billing-plan)
* [Activate Billing Plan](../../doc/controllers/subscriptions.md#activate-billing-plan)
* [Deactivate Billing Plan](../../doc/controllers/subscriptions.md#deactivate-billing-plan)
* [Update Billing Plan Pricing Schemes](../../doc/controllers/subscriptions.md#update-billing-plan-pricing-schemes)
* [Create Subscription](../../doc/controllers/subscriptions.md#create-subscription)
* [List Subscriptions](../../doc/controllers/subscriptions.md#list-subscriptions)
* [Get Subscription](../../doc/controllers/subscriptions.md#get-subscription)
* [Patch Subscription](../../doc/controllers/subscriptions.md#patch-subscription)
* [Revise Subscription](../../doc/controllers/subscriptions.md#revise-subscription)
* [Suspend Subscription](../../doc/controllers/subscriptions.md#suspend-subscription)
* [Cancel Subscription](../../doc/controllers/subscriptions.md#cancel-subscription)
* [Activate Subscription](../../doc/controllers/subscriptions.md#activate-subscription)
* [Capture Subscription](../../doc/controllers/subscriptions.md#capture-subscription)
* [List Subscription Transactions](../../doc/controllers/subscriptions.md#list-subscription-transactions)


# Create Billing Plan

Creates a plan that defines pricing and billing cycle details for subscriptions.

```csharp
CreateBillingPlanAsync(
    Models.CreateBillingPlanInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `prefer` | `string` | Header, Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br><br>**Default**: `"return=minimal"` |
| `paypalRequestId` | `string` | Header, Optional | The server stores keys for 72 hours. |
| `body` | [`PlanRequest`](../../doc/models/plan-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.BillingPlan](../../doc/models/billing-plan.md).

## Example Usage

```csharp
CreateBillingPlanInput createBillingPlanInput = new CreateBillingPlanInput
{
    Prefer = "return=minimal",
    Body = new PlanRequest
    {
        ProductId = "product_id2",
        Name = "name6",
        BillingCycles = new List<SubscriptionBillingCycle>
        {
            new SubscriptionBillingCycle
            {
                Frequency = new Frequency
                {
                    IntervalUnit = IntervalUnit.Day,
                    IntervalCount = 1,
                },
                TenureType = TenureType.Regular,
                Sequence = 8,
                TotalCycles = 1,
            },
        },
        PaymentPreferences = new PaymentPreferences
        {
            AutoBillOutstanding = true,
            SetupFeeFailureAction = SetupFeeFailureAction.Cancel,
            PaymentFailureThreshold = 0,
        },
        Status = PlanRequestStatus.Active,
        QuantitySupported = false,
    },
};

try
{
    ApiResponse<BillingPlan> result = await subscriptionsController.CreateBillingPlanAsync(createBillingPlanInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. Request is not well-formed, syntactically incorrect, or violates schema. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# List Billing Plans

Lists billing plans.

```csharp
ListBillingPlansAsync(
    Models.ListBillingPlansInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `prefer` | `string` | Header, Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, name, description and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br><br>**Default**: `"return=minimal"` |
| `productId` | `string` | Query, Optional | Filters the response by a Product ID.<br><br>**Constraints**: *Minimum Length*: `6`, *Maximum Length*: `50` |
| `pageSize` | `int?` | Query, Optional | The number of items to return in the response.<br><br>**Default**: `10`<br><br>**Constraints**: `>= 1`, `<= 20` |
| `page` | `int?` | Query, Optional | A non-zero integer which is the start index of the entire list of items to return in the response. The combination of `page=1` and `page_size=20` returns the first 20 items. The combination of `page=2` and `page_size=20` returns the next 20 items.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1`, `<= 100000` |
| `totalRequired` | `bool?` | Query, Optional | Indicates whether to show the total count in the response.<br><br>**Default**: `false` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PlanCollection](../../doc/models/plan-collection.md).

## Example Usage

```csharp
ListBillingPlansInput listBillingPlansInput = new ListBillingPlansInput
{
    Prefer = "return=minimal",
    PageSize = 10,
    Page = 1,
    TotalRequired = false,
};

try
{
    ApiResponse<PlanCollection> result = await subscriptionsController.ListBillingPlansAsync(listBillingPlansInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Request is not well-formed, syntactically incorrect, or violates schema. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 404 | The specified resource does not exist. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# Get Billing Plan

Shows details for a plan, by ID.

```csharp
GetBillingPlanAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID of the plan. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.BillingPlan](../../doc/models/billing-plan.md).

## Example Usage

```csharp
string id = "id0";
try
{
    ApiResponse<BillingPlan> result = await subscriptionsController.GetBillingPlanAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 404 | The specified resource does not exist. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# Patch Billing Plan

Updates a plan with the `CREATED` or `ACTIVE` status. For an `INACTIVE` plan, you can make only status updates. You can patch these attributes and objects: Attribute or object Operations description replace payment_preferences.auto_bill_outstanding replace taxes.percentage replace payment_preferences.payment_failure_threshold replace payment_preferences.setup_fee replace payment_preferences.setup_fee_failure_action replace name replace

```csharp
PatchBillingPlanAsync(
    Models.PatchBillingPlanInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID of the plan. |
| `body` | [`List<Patch>`](../../doc/models/patch.md) | Body, Optional | - |

## Response Type

`Task`

## Example Usage

```csharp
PatchBillingPlanInput patchBillingPlanInput = new PatchBillingPlanInput
{
    Id = "id0",
    Body = new List<Patch>
    {
        new Patch
        {
            Op = PatchOp.Add,
        },
    },
};

try
{
    await subscriptionsController.PatchBillingPlanAsync(patchBillingPlanInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Request is not well-formed, syntactically incorrect, or violates schema. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 404 | The specified resource does not exist. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# Activate Billing Plan

Activates a plan, by ID.

```csharp
ActivateBillingPlanAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID of the plan. |

## Response Type

`Task`

## Example Usage

```csharp
string id = "id0";
try
{
    await subscriptionsController.ActivateBillingPlanAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 404 | The specified resource does not exist. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# Deactivate Billing Plan

Deactivates a plan, by ID.

```csharp
DeactivateBillingPlanAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID of the plan. |

## Response Type

`Task`

## Example Usage

```csharp
string id = "id0";
try
{
    await subscriptionsController.DeactivateBillingPlanAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 404 | The specified resource does not exist. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# Update Billing Plan Pricing Schemes

Updates pricing for a plan. For example, you can update a regular billing cycle from $5 per month to $7 per month.

```csharp
UpdateBillingPlanPricingSchemesAsync(
    Models.UpdateBillingPlanPricingSchemesInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID for the plan. |
| `body` | [`UpdatePricingSchemesRequest`](../../doc/models/update-pricing-schemes-request.md) | Body, Optional | - |

## Response Type

`Task`

## Example Usage

```csharp
UpdateBillingPlanPricingSchemesInput updateBillingPlanPricingSchemesInput = new UpdateBillingPlanPricingSchemesInput
{
    Id = "id0",
    Body = new UpdatePricingSchemesRequest
    {
        PricingSchemes = new List<UpdatePricingScheme>
        {
            new UpdatePricingScheme
            {
                BillingCycleSequence = 34,
                PricingScheme = new SubscriptionPricingScheme
                {
                },
            },
        },
    },
};

try
{
    await subscriptionsController.UpdateBillingPlanPricingSchemesAsync(updateBillingPlanPricingSchemesInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. Request is not well-formed, syntactically incorrect, or violates schema. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 404 | The specified resource does not exist. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# Create Subscription

Creates a subscription.

```csharp
CreateSubscriptionAsync(
    Models.CreateSubscriptionInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `prefer` | `string` | Header, Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br><br>**Default**: `"return=minimal"` |
| `paypalRequestId` | `string` | Header, Optional | The server stores keys for 72 hours. |
| `paypalClientMetadataId` | `string` | Header, Optional | The PayPal Client Metadata Id(CMID) is used to provide device-specific information to PayPal's risk engine. This is crucial for transactions that require device-specific risk assessments. Merchants typically use the Paypal SDK that automatically submits the CMID or they use tools like Fraudnet JS for web or Magnes JS for mobile to generate the CMID on the frontend and then pass it to the API as part of the request headers.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36` |
| `body` | [`CreateSubscriptionRequest`](../../doc/models/create-subscription-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Subscription](../../doc/models/subscription.md).

## Example Usage

```csharp
CreateSubscriptionInput createSubscriptionInput = new CreateSubscriptionInput
{
    Prefer = "return=minimal",
    Body = new CreateSubscriptionRequest
    {
        PlanId = "plan_id8",
        AutoRenewal = false,
    },
};

try
{
    ApiResponse<Subscription> result = await subscriptionsController.CreateSubscriptionAsync(createSubscriptionInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. Request is not well-formed, syntactically incorrect, or violates schema. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# List Subscriptions

List all subscriptions for merchant account.

```csharp
ListSubscriptionsAsync(
    Models.ListSubscriptionsInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planIds` | `string` | Query, Optional | Filters the response by list of plan IDs. Filter supports upto 70 plan IDs. URLs should not exceed a length of 2000 characters. |
| `statuses` | `string` | Query, Optional | Filters the response by list of subscription statuses.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `70`, *Pattern*: `^[A-Z_,]+$` |
| `createdAfter` | `string` | Query, Optional | Filters the response by subscription creation start time for a range of subscriptions.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `createdBefore` | `string` | Query, Optional | Filters the response by subscription creation end time for a range of subscriptions.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `statusUpdatedBefore` | `string` | Query, Optional | Filters the response by status update start time for a range of subscriptions.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `statusUpdatedAfter` | `string` | Query, Optional | Filters the response by status update end time for a range of subscriptions.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `filter` | `string` | Query, Optional | Filter the response using complex expressions that could use comparison operators like ge, gt, le, lt and logical operators such as 'and' and 'or'.<br><br>**Constraints**: *Minimum Length*: `0`, *Maximum Length*: `100` |
| `pageSize` | `int?` | Query, Optional | The number of items to return in the response.<br><br>**Default**: `10`<br><br>**Constraints**: `>= 1`, `<= 20` |
| `page` | `int?` | Query, Optional | A non-zero integer which is the start index of the entire list of items to return in the response. The combination of `page=1` and `page_size=20` returns the first 20 items. The combination of `page=2` and `page_size=20` returns the next 20 items.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1`, `<= 10000000` |
| `customerIds` | `List<string>` | Query, Optional | Filters the response by comma separated vault customer IDs (FSS subscriptions only).<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, *Minimum Length*: `1`, *Maximum Length*: `22`, *Pattern*: `^[0-9a-zA-Z_-]+$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SubscriptionCollection](../../doc/models/subscription-collection.md).

## Example Usage

```csharp
ListSubscriptionsInput listSubscriptionsInput = new ListSubscriptionsInput
{
    PageSize = 10,
    Page = 1,
};

try
{
    ApiResponse<SubscriptionCollection> result = await subscriptionsController.ListSubscriptionsAsync(listSubscriptionsInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Request is not well-formed, syntactically incorrect, or violates schema. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# Get Subscription

Shows details for a subscription, by ID.

```csharp
GetSubscriptionAsync(
    Models.GetSubscriptionInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID of the subscription. |
| `fields` | `string` | Query, Optional | List of fields that are to be returned in the response. Possible value for fields are last_failed_payment and plan.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `100` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Subscription](../../doc/models/subscription.md).

## Example Usage

```csharp
GetSubscriptionInput getSubscriptionInput = new GetSubscriptionInput
{
    Id = "id0",
};

try
{
    ApiResponse<Subscription> result = await subscriptionsController.GetSubscriptionAsync(getSubscriptionInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 404 | The specified resource does not exist. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# Patch Subscription

Updates a subscription which could be in ACTIVE or SUSPENDED status. You can override plan level default attributes by providing customised values for plan path in the patch request. You cannot update attributes that have already completed (Example - trial cycles can’t be updated if completed). Once overridden, changes to plan resource will not impact subscription. Any price update will not impact billing cycles within next 10 days (Applicable only for subscriptions funded by PayPal account). Following are the fields eligible for patch. Attribute or object Operations billing_info.outstanding_balance replace custom_id add,replace plan.billing_cycles[@sequence==n]. pricing_scheme.fixed_price add,replace plan.billing_cycles[@sequence==n]. pricing_scheme.tiers replace plan.billing_cycles[@sequence==n]. total_cycles replace plan.payment_preferences. auto_bill_outstanding replace plan.payment_preferences. payment_failure_threshold replace plan.taxes.inclusive add,replace plan.taxes.percentage add,replace shipping_amount add,replace start_time replace subscriber.shipping_address add,replace subscriber.payment_source (for subscriptions funded by card payments) replace

```csharp
PatchSubscriptionAsync(
    Models.PatchSubscriptionInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID for the subscription. |
| `body` | [`List<Patch>`](../../doc/models/patch.md) | Body, Optional | - |

## Response Type

`Task`

## Example Usage

```csharp
PatchSubscriptionInput patchSubscriptionInput = new PatchSubscriptionInput
{
    Id = "id0",
    Body = new List<Patch>
    {
        new Patch
        {
            Op = PatchOp.Add,
        },
    },
};

try
{
    await subscriptionsController.PatchSubscriptionAsync(patchSubscriptionInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Request is not well-formed, syntactically incorrect, or violates schema. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 404 | The specified resource does not exist. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# Revise Subscription

Updates the quantity of the product or service in a subscription. You can also use this method to switch the plan and update the `shipping_amount`, `shipping_address` values for the subscription. This type of update requires the buyer's consent.

```csharp
ReviseSubscriptionAsync(
    Models.ReviseSubscriptionInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID of the subscription. |
| `body` | [`ModifySubscriptionRequest`](../../doc/models/modify-subscription-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ModifySubscriptionResponse](../../doc/models/modify-subscription-response.md).

## Example Usage

```csharp
ReviseSubscriptionInput reviseSubscriptionInput = new ReviseSubscriptionInput
{
    Id = "id0",
};

try
{
    ApiResponse<ModifySubscriptionResponse> result = await subscriptionsController.ReviseSubscriptionAsync(reviseSubscriptionInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. Request is not well-formed, syntactically incorrect, or violates schema. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 404 | The specified resource does not exist. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# Suspend Subscription

Suspends the subscription.

```csharp
SuspendSubscriptionAsync(
    Models.SuspendSubscriptionInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID of the subscription. |
| `body` | [`SuspendSubscription`](../../doc/models/suspend-subscription.md) | Body, Optional | - |

## Response Type

`Task`

## Example Usage

```csharp
SuspendSubscriptionInput suspendSubscriptionInput = new SuspendSubscriptionInput
{
    Id = "id0",
};

try
{
    await subscriptionsController.SuspendSubscriptionAsync(suspendSubscriptionInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. Request is not well-formed, syntactically incorrect, or violates schema. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 404 | The specified resource does not exist. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# Cancel Subscription

Cancels the subscription.

```csharp
CancelSubscriptionAsync(
    Models.CancelSubscriptionInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID of the subscription. |
| `body` | [`CancelSubscriptionRequest`](../../doc/models/cancel-subscription-request.md) | Body, Optional | - |

## Response Type

`Task`

## Example Usage

```csharp
CancelSubscriptionInput cancelSubscriptionInput = new CancelSubscriptionInput
{
    Id = "id0",
};

try
{
    await subscriptionsController.CancelSubscriptionAsync(cancelSubscriptionInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. Request is not well-formed, syntactically incorrect, or violates schema. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 404 | The specified resource does not exist. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# Activate Subscription

Activates the subscription.

```csharp
ActivateSubscriptionAsync(
    Models.ActivateSubscriptionInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID of the subscription. |
| `body` | [`ActivateSubscriptionRequest`](../../doc/models/activate-subscription-request.md) | Body, Optional | - |

## Response Type

`Task`

## Example Usage

```csharp
ActivateSubscriptionInput activateSubscriptionInput = new ActivateSubscriptionInput
{
    Id = "id0",
};

try
{
    await subscriptionsController.ActivateSubscriptionAsync(activateSubscriptionInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. Request is not well-formed, syntactically incorrect, or violates schema. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 404 | The specified resource does not exist. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# Capture Subscription

Captures an authorized payment from the subscriber on the subscription.

```csharp
CaptureSubscriptionAsync(
    Models.CaptureSubscriptionInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID of the subscription. |
| `paypalRequestId` | `string` | Header, Optional | The server stores keys for 72 hours. |
| `body` | [`CaptureSubscriptionRequest`](../../doc/models/capture-subscription-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SubscriptionTransactionDetails](../../doc/models/subscription-transaction-details.md).

## Example Usage

```csharp
CaptureSubscriptionInput captureSubscriptionInput = new CaptureSubscriptionInput
{
    Id = "id0",
};

try
{
    ApiResponse<SubscriptionTransactionDetails> result = await subscriptionsController.CaptureSubscriptionAsync(captureSubscriptionInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. Request is not well-formed, syntactically incorrect, or violates schema. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 404 | The specified resource does not exist. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 422 | The requested action could not be performed, semantically incorrect, or failed business validation. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |


# List Subscription Transactions

Lists transactions for a subscription.

```csharp
ListSubscriptionTransactionsAsync(
    Models.ListSubscriptionTransactionsInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID of the subscription. |
| `startTime` | `string` | Query, Required | The start time of the range of transactions to list.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `endTime` | `string` | Query, Required | The end time of the range of transactions to list.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TransactionsList](../../doc/models/transactions-list.md).

## Example Usage

```csharp
ListSubscriptionTransactionsInput listSubscriptionTransactionsInput = new ListSubscriptionTransactionsInput
{
    Id = "id0",
    StartTime = "start_time6",
    EndTime = "end_time2",
};

try
{
    ApiResponse<TransactionsList> result = await subscriptionsController.ListSubscriptionTransactionsAsync(listSubscriptionTransactionsInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request. Request is not well-formed, syntactically incorrect, or violates schema. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 401 | Authentication failed due to missing authorization header, or invalid authentication credentials. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 404 | The specified resource does not exist. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| 500 | An internal server error has occurred. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |
| Default | The error response. | [`SubscriptionErrorException`](../../doc/models/subscription-error-exception.md) |

