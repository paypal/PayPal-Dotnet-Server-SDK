
# ApiResponse

Represents the result of an API call, including response metadata and the returned data of type `T`.

## Properties

| Name | Type | Description |
|  --- | --- | --- |
| `StatusCode` | `int` | Returns the response status code. |
| `Headers` | `Dictionary<string, string>` | Returns the response headers. |
| `Data` | `T` | Returns the response data. |

## Example Usage

```csharp
try
{
    ApiResponse<ExampleType> response = await client.ExampleController.GetExampleType(body);
    Console.WriteLine($"Success! Result: {response.Data}");
    Console.WriteLine($"Status Code: {response.StatusCode}");
}
catch (ApiException e)
{
    Console.WriteLine($"Error: {e.Message}");
    Console.WriteLine($"Result: {e.HttpContext.Response.Body}");
    Console.WriteLine($"Status Code: {e.ResponseCode}");
}
```

