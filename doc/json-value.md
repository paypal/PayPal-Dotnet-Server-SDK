
# JsonValue

Class to wrap any JSON value.

## Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `FromString(string value)` | Initializes JsonValue instance with string value. | `JsonValue` |
| `FromBoolean(bool? value)` | Initializes JsonValue instance with boolean value. | `JsonValue` |
| `FromInteger(int? value)` | Initializes JsonValue instance with integer value. | `JsonValue` |
| `FromDouble(double? value)` | Initializes JsonValue instance with double value. | `JsonValue` |
| `FromLong(long? value)` | Initializes JsonValue instance with long value. | `JsonValue` |
| `FromObject(object value)` | Initializes JsonValue instance with any object value. | `JsonValue` |
| `FromArray<T>(List<T> values)` | Initializes JsonValue instance with an array of the given type. | `JsonValue` |
| `GetStoredObject()` | Getter for the stored object. | `object` |
| `ToString()` | String representation of the stored JSON. | `string` |

