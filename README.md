# LINQ Extension Methods
This is a public repository on GitHub that serves as a central location for reusable LINQ extension methods. It aims to be a valuable resource for developers of all levels by providing a collection of well-documented and practical LINQ extensions with clear examples.

## Key Features:

- **Collection of LINQ Extensions:** The repository will house a variety of LINQ extension methods that address common data manipulation tasks.
- **Clear Documentation:** Each extension method will be accompanied by detailed documentation explaining its purpose, usage, and parameters.
- **Example Code:** Comprehensive code examples will showcase how to implement each extension method in real-world scenarios.

## Benefits:

- **Improved Code Readability:** Reusable LINQ extensions can improve code readability by encapsulating complex logic into concise methods.
- **Increased Developer Productivity:** Developers can save time by leveraging pre-written extensions instead of reinventing the wheel.
- **Enhanced Code Maintainability:** Easier maintenance as common functionalities are centralized and well-documented.
- **Knowledge Sharing:** The repository fosters knowledge sharing within the developer community by providing a platform for learning and exploring LINQ extensions.

## Development Environment and Dependencies

This demo project leverages the following technologies:

* **.NET Framework:** 8 (or later)
* **Programming Language:** C#
* **IDE:** Visual Studio 2022 Community (or later)
* **NuGet Package:** [Dumpify](https://www.nuget.org/packages/Dumpify) (for enhanced output visualization)

**Note:** While these demos are designed for the specified environment, you might be able to adapt them to similar .NET frameworks and IDEs.

### LINQ Extensions
**Filtering**
   - [ ] [Where](demos-linq-extensions/demos-linq-extensions/Extensions/Filtering/WhereDemo.cs)
   - [ ] [OfType](demos-linq-extensions/demos-linq-extensions/Extensions/Filtering/OfTypeDemo.cs)

**Aggregation**
   - [ ] [Aggregate](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/AggregationMethods/AggregateDemo.cs)
   - [ ] [Average](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/AggregationMethods/AverageDemo.cs)
   - [ ] [Count](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/AggregationMethods/CountDemo.cs)
   - [ ] [LongCount](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/AggregationMethods/LongCountDemo.cs)
   - [ ] [Max](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/AggregationMethods/MaxDemo.cs)
   - [ ] [MaxBy](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/AggregationMethods/MaxByDemo.cs)
   - [ ] [Min](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/AggregationMethods/MinDemo.cs)
   - [ ] [MinBy](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/AggregationMethods/MinByDemo.cs)
   - [ ] [Sum](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/AggregationMethods/SumDemo.cs)
   - [ ] [TryGetNonEnumerated](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/AggregationMethods/TryGetNonEnumeratedDemo.cs)

**Conversions**
  - [ ] [ToArray](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/ConversionMethods/ToArrayDemo.cs)
  - [ ] [ToDictionary](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/ConversionMethods/ToDictionaryDemo.cs)
  - [ ] [ToHashSet](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/ConversionMethods/ToHashSetDemo.cs)
  - [ ] [ToList](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/ConversionMethods/ToListDemo.cs)
  - [ ] [ToLookup](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/ConversionMethods/ToLookupDemo.cs)

**ElementOperators**
  - [ ] [DefaultIfEmpty](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/ElementOperators/DefaultIfEmptyDemo.cs)
  - [ ] [ElementAt](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/ElementOperators/ElementAtDemo.cs)
  - [ ] [ElementAtOrDefault](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/ElementOperators/ElementAtOrDefaultDemo.cs)
  - [ ] [First](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/ElementOperators/FirstDemo.cs)
  - [ ] [FirstOrDefault](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/ElementOperators/FirstOrDefaultDemo.cs)
  - [ ] [Last](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/ElementOperators/LastDemo.cs)
  - [ ] [LastOrDefault](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/ElementOperators/LastOrDefaultDemo.cs)
  - [ ] [Single](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/ElementOperators/SingleDemo.cs)
  - [ ] [SingleOrDefault](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/ElementOperators/SingleOrDefaultDemo.cs)

**Existance Or Quantity Checks**
  - [ ] [All](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Existance_Or_QuantityChecks/AllDemo.cs)
  - [ ] [Any](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Existance_Or_QuantityChecks/AnyDemo.cs)
  - [ ] [Contains](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Existance_Or_QuantityChecks/ContainsDemo.cs)

  **Generations**
  - [ ] [AsEnumerable](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/GenerationMethods/AsEnumerableDemo.cs)
  - [ ] [AsQueryable](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/GenerationMethods/AsQueryableDemo.cs)
  - [ ] [Empty](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/GenerationMethods/EmptyDemo.cs)
  - [ ] [Range](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/GenerationMethods/RangeDemo.cs)
  - [ ] [Repeat](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/GenerationMethods/RepeatDemo.cs)

  **Join or Group**
  - [ ] [Concat](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Join_and_GroupMethods/ConcatDemo.cs)
  - [ ] [GroupBy](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Join_and_GroupMethods/GroupByDemo.cs)
  - [ ] [GroupJoin](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Join_and_GroupMethods/GroupJoinDemo.cs)
  - [ ] [Join](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Join_and_GroupMethods/JoinDemo.cs)
  - [ ] [Zip](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Join_and_GroupMethods/ZipDemo.cs)

  **Parallel Linq Or PLINQ**
  - [ ] [AsOrdered](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Parallel%20Linq%20Methods/AsOrderedDemo.cs)
  - [ ] [AsParallel](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Parallel%20Linq%20Methods/AsParallelDemo.cs)
  - [ ] [WithDegreeOfParallelism](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Parallel%20Linq%20Methods/WithDegreeOfParallelismDemo.cs)
  - [ ] [WithExcecutionMode](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Parallel%20Linq%20Methods/WithExcecutionModeDemo.cs)
  - [ ] [WithMergeOptions](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Parallel%20Linq%20Methods/WithMergeOptionsDemo.cs)

  **Partitions**
  - [ ] [Skip](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Partitions/SkipDemo.cs)
  - [ ] [SkipLast](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Partitions/SkipLastDemo.cs)
  - [ ] [SkipWhile](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Partitions/SkipWhileDemo.cs)
  - [ ] [Take](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Partitions/TakeDemo.cs)
  - [ ] [TakeLast](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Partitions/TakeLastDemo.cs)
  - [ ] [TakeWhile](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Partitions/TakeWhileDemo.cs)

  **Projection**

  - [ ] [Cast](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Projection/CastDemo.cs)
  - [ ] [Chunck](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Projection/ChunckDemo.cs)
  - [ ] [Select](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Projection/SelectDemo.cs)
  - [ ] [SelectMany](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/Projection/SelectManyDemo.cs) 

  **Sequence Manipulation**
  - [ ] [Append](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SequenceManipulation/AppendDemo.cs)
  - [ ] [Prepend](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SequenceManipulation/PrependDemo.cs)

  **Set Operations**
  - [ ] [DistinctBy](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SetOperations/DistinctByDemo.cs)
  - [ ] [Distinct](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SetOperations/DistinctDemo.cs)
  - [ ] [ExceptBy](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SetOperations/ExceptByDemo.cs)
  - [ ] [Except](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SetOperations/ExceptDemo.cs)
  - [ ] [IntersectBy](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SetOperations/IntersectByDemo.cs)
  - [ ] [Intersect](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SetOperations/IntersectDemo.cs)
  - [ ] [SequenceEqual](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SetOperations/SequenceEqualDemo.cs)
  - [ ] [UnionBy](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SetOperations/UnionByDemo.cs)
  - [ ] [Union](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SetOperations/UnionDemo.cs)

 **Sort Operations**
  - [ ] [OrderBy](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SortMethods/OrderByDemo.cs)
  - [ ] [OrderByDescending](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SortMethods/OrderByDescendingDemo.cs)
  - [ ] [Order](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SortMethods/OrderDemo.cs)
  - [ ] [OrderDescending](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SortMethods/OrderDescendingDemo.cs)
  - [ ] [Reverse](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SortMethods/ReverseDemo.cs)
  - [ ] [ThenBy](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SortMethods/ThenByDemo.cs)
  - [ ] [ThenByDescending](https://github.com/nuthanm/linq-extensions/blob/main/demos-linq-extensions/demos-linq-extensions/Extensions/SortMethods/ThenByDescendingDemo.cs)
  
## References
[Amichai Mantinband - Youtube](https://www.youtube.com/watch?v=7-P6Mxl5elg&t=741s)

This repository can be a valuable asset for anyone working with C# and LINQ, from beginners seeking to understand the basics to experienced developers looking to expand their toolkit.
