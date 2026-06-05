# Transaction Search

Use the `/transactions` resource to list transactions and the `/balances` resource to list balances.

```csharp
TransactionSearchController transactionSearchController = client.TransactionSearchController;
```

## Class Name

`TransactionSearchController`

## Methods

* [Search Transactions](../../doc/controllers/transaction-search.md#search-transactions)
* [Search Balances](../../doc/controllers/transaction-search.md#search-balances)


# Search Transactions

Lists transactions. Specify one or more query parameters to filter the transaction that appear in the response. Notes: If you specify one or more optional query parameters, the ending_balance response field is empty. It takes a maximum of three hours for executed transactions to appear in the list transactions call. This call lists transaction for the previous three years.

```csharp
SearchTransactionsAsync(
    Models.SearchTransactionsInput input)
```

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.SearchTransactionsInput`](../../doc/models/search-transactions-input.md) | Required | Input structure for the method SearchTransactions |

## Response Type

**200**: A successful request returns the HTTP `200 OK` status code and a JSON response body that lists transactions .

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SearchResponse](../../doc/models/search-response.md).

## Example Usage

```csharp
SearchTransactionsInput searchTransactionsInput = new SearchTransactionsInput
{
    StartDate = "start_date6",
    EndDate = "end_date0",
    Fields = "transaction_info",
    BalanceAffectingRecordsOnly = "Y",
    PageSize = 100,
    Page = 1,
};

try
{
    ApiResponse<SearchResponse> result = await transactionSearchController.SearchTransactionsAsync(searchTransactionsInput);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is SearchErrorException)
    {
       // TODO: Handle SearchErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | The error response. | [`SearchErrorException`](../../doc/models/search-error-exception.md) |


# Search Balances

List all balances. Specify date time to list balances for that time that appear in the response. Notes: It takes a maximum of three hours for balances to appear in the list balances call. This call lists balances upto the previous three years.

```csharp
SearchBalancesAsync(
    Models.SearchBalancesInput input)
```

## Authentication

This endpoint requires [Oauth2](../../doc/auth/oauth-2-client-credentials-grant.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.SearchBalancesInput`](../../doc/models/search-balances-input.md) | Required | Input structure for the method SearchBalances |

## Response Type

**200**: A successful request returns the HTTP `200 OK` status code and a JSON response body that lists balances .

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.BalancesResponse](../../doc/models/balances-response.md).

## Example Usage

```csharp
SearchBalancesInput searchBalancesInput = new SearchBalancesInput
{
};

try
{
    ApiResponse<BalancesResponse> result = await transactionSearchController.SearchBalancesAsync(searchBalancesInput);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is DefaultErrorException)
    {
       // TODO: Handle DefaultErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request is not well-formed, is syntactically incorrect, or violates schema. | [`DefaultErrorException`](../../doc/models/default-error-exception.md) |
| 403 | Authorization failed due to insufficient permissions. | [`DefaultErrorException`](../../doc/models/default-error-exception.md) |
| 500 | An internal server error occurred. | [`DefaultErrorException`](../../doc/models/default-error-exception.md) |
| Default | The error response. | [`DefaultErrorException`](../../doc/models/default-error-exception.md) |

