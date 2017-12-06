## C# Linq Extensions ##

Here is an Linq extension which returns your custom error message in cause of an exception.
Implemented: First, Last, Single

## Available for:
- .NET Standard 2.0
- .NET Standard 1.5
- .NET Standard 1.3
- .NET 4.6.1
- .NET 4.5

## Example:
```csharp
	List<string> newList = new List<string> {"1234", "987654"};
	newList.SingleOrDefault(x => x == "searchString", "custom error message e.g. search string not in list");
```

## Licence:
http://choosealicense.com/licenses/bsd-2-clause/
