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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.CreateBillingPlanInput`](../../doc/models/create-billing-plan-input.md) | Required | Input structure for the method CreateBillingPlan |

## Response Type

**200**: A successful request returns the HTTP `200 OK` status code and a JSON response body that shows billing plan details.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListBillingPlansInput`](../../doc/models/list-billing-plans-input.md) | Required | Input structure for the method ListBillingPlans |

## Response Type

**200**: A successful request returns the HTTP `200 OK` status code and a JSON response body that lists billing plans.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID of the plan. |

## Response Type

**200**: A successful request returns the HTTP `200 OK` status code and a JSON response body that shows plan details.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.PatchBillingPlanInput`](../../doc/models/patch-billing-plan-input.md) | Required | Input structure for the method PatchBillingPlan |

## Response Type

**204**: A successful request returns the HTTP `204 No Content` status code with no JSON response body.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID of the plan. |

## Response Type

**204**: A successful request returns the HTTP `204 No Content` status code with no JSON response body.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | The ID of the plan. |

## Response Type

**204**: A successful request returns the HTTP `204 No Content` status code with no JSON response body.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.UpdateBillingPlanPricingSchemesInput`](../../doc/models/update-billing-plan-pricing-schemes-input.md) | Required | Input structure for the method UpdateBillingPlanPricingSchemes |

## Response Type

**204**: A successful request returns the HTTP `204 No Content` status code with no JSON response body.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.CreateSubscriptionInput`](../../doc/models/create-subscription-input.md) | Required | Input structure for the method CreateSubscription |

## Response Type

**200**: A successful request returns the HTTP `200 OK` status code and a JSON response body that shows subscription details.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListSubscriptionsInput`](../../doc/models/list-subscriptions-input.md) | Required | Input structure for the method ListSubscriptions |

## Response Type

**200**: A successful request returns the HTTP `200 OK` status code and a JSON response body that lists the subscriptions.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.GetSubscriptionInput`](../../doc/models/get-subscription-input.md) | Required | Input structure for the method GetSubscription |

## Response Type

**200**: A successful request returns the HTTP `200 OK` status code and a JSON response body that shows subscription details.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.PatchSubscriptionInput`](../../doc/models/patch-subscription-input.md) | Required | Input structure for the method PatchSubscription |

## Response Type

**204**: A successful request returns the HTTP `204 No Content` status code with no JSON response body.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ReviseSubscriptionInput`](../../doc/models/revise-subscription-input.md) | Required | Input structure for the method ReviseSubscription |

## Response Type

**200**: A successful request returns the HTTP `200 OK` status code and a JSON response body that shows subscription details.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.SuspendSubscriptionInput`](../../doc/models/suspend-subscription-input.md) | Required | Input structure for the method SuspendSubscription |

## Response Type

**204**: A successful request returns the HTTP `204 No Content` status code with no JSON response body.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.CancelSubscriptionInput`](../../doc/models/cancel-subscription-input.md) | Required | Input structure for the method CancelSubscription |

## Response Type

**204**: A successful request returns the HTTP `204 No Content` status code with no JSON response body.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ActivateSubscriptionInput`](../../doc/models/activate-subscription-input.md) | Required | Input structure for the method ActivateSubscription |

## Response Type

**204**: A successful request returns the HTTP `204 No Content` status code with no JSON response body.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.CaptureSubscriptionInput`](../../doc/models/capture-subscription-input.md) | Required | Input structure for the method CaptureSubscription |

## Response Type

**200**: A successful request returns the HTTP `200 OK` status code and a JSON response body that shows subscription details.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListSubscriptionTransactionsInput`](../../doc/models/list-subscription-transactions-input.md) | Required | Input structure for the method ListSubscriptionTransactions |

## Response Type

**200**: A successful request returns the HTTP `200 OK` status code and a JSON response body that shows subscription details.

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
    Console.WriteLine(e.Message);
    if (e is SubscriptionErrorException)
    {
       // TODO: Handle SubscriptionErrorException exception here
    }
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

