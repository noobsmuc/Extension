## C# Linq + String Extensions ##

Here is an Linq extension which returns your custom error message in cause of an exception.
Linq Implemented: First, Last, Single, MinOrDefault, MaxOrDefault, AverageOrDefault
String Implemented: Left, Right
Stopwatch: ToFormatedString

For funny reason you can use Highlander instead of Single :)

## Available for:
- .NET 8.0
- .NET 6.0
- .NET Standard 2.0
- .NET 4.8

## Example Linq:
```csharp
	List<string> newList = new List<string> {"1234", "987654"};
	newList.SingleOrDefault(x => x == "searchString", "custom error message e.g. search string mot in list");
```

```csharp
	List<int> newList = new List<int> {1234, 987654};
	newList.Select(x => x).MinOrDefault();
```

```csharp
	var dataList = new List<decimal>() { 15.2M, 18.6M, 55.23M };
	var result = dataList.Select(x => x).MaxOrDefault();
```

```csharp
    var dataList = new List<decimal>() { 15.2M, 18.6M, 55.23M };
    var result = dataList.Select(x => x).AverageOrDefault();
```

## Example String:
```csharp
	string testString = "anyTestText";
	var result = testString.Left(4);
	// result == "anyT"
```

```csharp
	string testString = "anyTestText";
	var result = testString.Right(4);
	// result == "Text"
```

```csharp
	string testString = "Add Additional String";
	var result = testString.ReplaceExactWord("Add", "Insert");
	// result == "Insert Additional String"
```

## Example Stopwatch:
```csharp
	var result = m_Stopwatch.ToFormatedString("g")
	// result == "0:00:01,5"
```

```csharp
	var result = m_Stopwatch.ToFormatedString(@"mm\:ss\.ff")
	// result == "00:01.50"
```

## Example DateTime:
```csharp
	DateTime result = new DateTime(2019, 1, 22).WeekBeginn();
	// result == new DateTime(2018, 12, 31)
```

```csharp
	int result = new DateTime(2016, 2, 22).DaysInMonth()
	// result == 29
```

## Licence:
http://choosealicense.com/licenses/bsd-2-clause/
