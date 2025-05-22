
# ApiResponse

Represents the result of an API call, including response metadata and the returned data of type `T`.

## Properties

| Name | Description | Type |
|  --- | --- | --- |
| `StatusCode` | Returns the response status code. | `int` |
| `Data` | Returns the response data. | `T` |
| `Headers` | Returns the response headers. | `Dictionary<string, string>` |

## Usage Example

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

