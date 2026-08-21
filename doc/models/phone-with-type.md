
# Phone with Type

The phone information.

## Structure

`PhoneWithType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PhoneType` | [`PhoneType?`](../../doc/models/phone-type.md) | Optional | The phone type. |
| `PhoneNumber` | [`PhoneNumber`](../../doc/models/phone-number.md) | Required | The phone number in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

PhoneWithType phoneWithType = new PhoneWithType
{
    PhoneNumber = new PhoneNumber
    {
        NationalNumber = "national_number6",
    },
    PhoneType = PhoneType.Fax,
};
```

