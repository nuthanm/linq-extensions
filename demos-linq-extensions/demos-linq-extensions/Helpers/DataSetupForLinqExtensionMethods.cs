using demos_linq_extensions.Models;

namespace demos_linq_extensions.Helpers
{
    internal static class DataSetupForLinqExtensionMethods
    {
        public static IEnumerable<int> RandomNumbers()
        {
            return Enumerable.Range(0, 20);
        }

        public static IEnumerable<string> Countries()
        {
            return ["India", "France", "Australia", "Ireland", "Japan", "FinLand"];
        }

        public static IEnumerable<Employee> EmployeeData()
        {
            return [
                    new Employee (){
                        Id = 1,
                        FirstName ="Nuthan",
                        LastName ="Murarysetty",
                    },
                    new Employee (){
                        Id = 2,
                        FirstName ="Ramya",
                        LastName ="Sree",
                    },
                ];
        }
    }


}
