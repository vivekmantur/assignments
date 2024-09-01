using System;
namespace AutoMapperDemo
{
    /// <summary>
    /// Acts a main class to perform auto mapper functionality
    /// </summary>
    class Program
    {
        public static void Main()
        {
            Employee<string, int, bool> employeeone = new Employee<string, int, bool>
            {
                Name = "James",
                Salary = 2,
                Address = "London",
                Department = "IT",
               
            };
            var mapper = MapperConfig<string,int,bool>.InitializeAutomapper();
            var employeeobject = mapper.Map<PermenantEmployee<string,int,bool>>(employeeone);
            var permanentemployeeobject = mapper.Map<Employee<string,int,bool>, PermenantEmployee<string,int,bool>>(employeeone);
            Console.WriteLine("Name: " + permanentemployeeobject.Name + ", Salary: " + permanentemployeeobject.Sal + ", Address: " + permanentemployeeobject.Address + ", Department: " + permanentemployeeobject.Department+ "  Passport: "+permanentemployeeobject.Passport);
            Console.ReadLine();
        }
    }
}
