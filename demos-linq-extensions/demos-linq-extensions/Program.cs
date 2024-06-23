// See https://aka.ms/new-console-template for more information
using demos_linq_extensions.Extensions.Filtering;
using Dumpify;

Console.WriteLine("Welcome to the LINQ Extensions World!!!");
Console.WriteLine("---------------------------------------");

#region WhereExtension
var whereDemo = new WhereDemo();
whereDemo.GetIfnumberIsGreaterThan10().Dump("Get numbers where > 10");
// Output:
/*
┌──────────────────────────────┐
│ WhereEnumerableIterator<int> │
├──────────────────────────────┤
│ 11                           │
│ 12                           │
│ 13                           │
│ 14                           │
│ 15                           │
│ 16                           │
│ 17                           │
│ 18                           │
│ 19                           │
└──────────────────────────────┘
     Get numbers where > 10
 */
whereDemo.GetEvenNumbers().Dump("Only Even Numbers within 20");
// Output:
/*
┌──────────────────────────────┐
│ WhereEnumerableIterator<int> │
├──────────────────────────────┤
│ 0                            │
│ 2                            │
│ 4                            │
│ 6                            │
│ 8                            │
│ 10                           │
│ 12                           │
│ 14                           │
│ 16                           │
│ 18                           │
└──────────────────────────────┘
  Only Even Numbers within 20
 */
whereDemo.GetOddNumbers().Dump("Only Odd Numbers within 20");
// Output:
/* 
┌──────────────────────────────┐
│ WhereEnumerableIterator<int> │
├──────────────────────────────┤
│ 1                            │
│ 3                            │
│ 5                            │
│ 7                            │
│ 9                            │
│ 11                           │
│ 13                           │
│ 15                           │
│ 17                           │
│ 19                           │
└──────────────────────────────┘
   Only Odd Numbers within 20
 */

whereDemo.GetCountriesWithoutWhere().Dump("All Defined countries list");
// Output:
/*
 ┌────────────────────────────┐
│ <>z__ReadOnlyArray<string> │
├────────────────────────────┤
│ "India"                    │
│ "France"                   │
│ "Australia"                │
│ "Ireland"                  │
│ "Japan"                    │
│ "FinLand"                  │
└────────────────────────────┘
  All Defined countries list
 */
whereDemo.GetCountriesWhereStartsWith_I_Letter().Dump("Only Countries with I starting letter");
// Output:
/*
 ┌─────────────────────────────────┐
│ WhereEnumerableIterator<string> │
├─────────────────────────────────┤
│ "India"                         │
│ "Ireland"                       │
└─────────────────────────────────┘
  Only Countries with I starting
              letter
 */

whereDemo.ReturnNothing().Dump("No result due to data is not there");
// Output:
/*
┌───────────────────────────────────┐
│ WhereEnumerableIterator<Employee> │
└───────────────────────────────────┘
 No result due to data is not there
 */
whereDemo.ReturnEmployeeDataBasedOutWithName().Dump("Filtered based out FirstName");
// Output:
/*

┌───────────────────────────────────┐
│ WhereEnumerableIterator<Employee> │
├───────────────────────────────────┤
│        Employee                   │
│ ┌───────────┬─────────┐           │
│ │ Name      │ Value   │           │
│ ├───────────┼─────────┤           │
│ │ Id        │ 2       │           │
│ │ FullName  │ ""      │           │
│ │ FirstName │ "Ramya" │           │
│ │ LastName  │ "Sree"  │           │
│ └───────────┴─────────┘           │
└───────────────────────────────────┘
    Filtered based out FirstName
 */
whereDemo.GetEmployeesWithOutWhereClause().Dump("Get all employee data");
// Output:
/*
┌───────────────────────────────┐
│ <>z__ReadOnlyArray<Employee>  │
├───────────────────────────────┤
│           Employee            │
│ ┌───────────┬───────────────┐ │
│ │ Name      │ Value         │ │
│ ├───────────┼───────────────┤ │
│ │ Id        │ 1             │ │
│ │ FullName  │ ""            │ │
│ │ FirstName │ "Nuthan"      │ │
│ │ LastName  │ "Murarysetty" │ │
│ └───────────┴───────────────┘ │
│        Employee               │
│ ┌───────────┬─────────┐       │
│ │ Name      │ Value   │       │
│ ├───────────┼─────────┤       │
│ │ Id        │ 2       │       │
│ │ FullName  │ ""      │       │
│ │ FirstName │ "Ramya" │       │
│ │ LastName  │ "Sree"  │       │
│ └───────────┴─────────┘       │
└───────────────────────────────┘
      Get all employee data
 */

whereDemo.GetEmployeeDataBasedOutWithId().Dump("Get employee data based out with Id");
// Output:
/*
┌───────────────────────────────────┐
│ WhereEnumerableIterator<Employee> │
├───────────────────────────────────┤
│           Employee                │
│ ┌───────────┬───────────────┐     │
│ │ Name      │ Value         │     │
│ ├───────────┼───────────────┤     │
│ │ Id        │ 1             │     │
│ │ FullName  │ ""            │     │
│ │ FirstName │ "Nuthan"      │     │
│ │ LastName  │ "Murarysetty" │     │
│ └───────────┴───────────────┘     │
└───────────────────────────────────┘
 Get employee data based out with Id
 */

#endregion

Console.WriteLine("Bye!!!");
