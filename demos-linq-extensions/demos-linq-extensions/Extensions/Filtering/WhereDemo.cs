using demos_linq_extensions.Helpers;
using demos_linq_extensions.Models;

namespace demos_linq_extensions.Extensions.Filtering
{
    internal class WhereDemo
    {
        public IEnumerable<int> GetIfnumberIsGreaterThan10()
        {
            return DataSetupForLinqExtensionMethods.RandomNumbers()
                .Where(n => n > 10);
        }

        public IEnumerable<int> GetEvenNumbers()
        {
            return DataSetupForLinqExtensionMethods.RandomNumbers()
                .Where(n => (n % 2 == 0));
        }

        public IEnumerable<int> GetOddNumbers()
        {
            return DataSetupForLinqExtensionMethods.RandomNumbers()
                .Where(n => (n % 2 != 0));
        }

        public IEnumerable<string> GetCountriesWithoutWhere()
        {
            return DataSetupForLinqExtensionMethods.Countries();
        }

        public IEnumerable<string> GetCountriesWhereStartsWith_I_Letter()
        {
            return DataSetupForLinqExtensionMethods.Countries()
                .Where(c =>
                {
                    return c.StartsWith("I");
                });
        }

        public IEnumerable<Employee> GetEmployeesWithOutWhereClause()
        {
            return DataSetupForLinqExtensionMethods.EmployeeData();
        }

        public IEnumerable<Employee> GetEmployeeDataBasedOutWithId()
        {
            return DataSetupForLinqExtensionMethods.EmployeeData()
                .Where(e => e.Id == 1);
        }

        public IEnumerable<Employee> ReturnNothing()
        {
            return DataSetupForLinqExtensionMethods.EmployeeData()
                .Where(e => e.FullName is null);
        }

        public IEnumerable<Employee> ReturnEmployeeDataBasedOutWithName()
        {
            return DataSetupForLinqExtensionMethods.EmployeeData()
                .Where(e => e.FirstName == "Ramya");
        }
    }
}
