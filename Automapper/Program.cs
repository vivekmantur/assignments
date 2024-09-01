using System;
namespace AutoMapperDemo
{
    class Program
    {
        public static void Main()
        {
            Employee<string, int, bool> emp = new Employee<string, int, bool>
            {
                Name = "James",
                Salary = 2,
                Address = "London",
                Department = "IT",
               
            };
            var mapper = MapperConfig<string,int,bool>.InitializeAutomapper();
            var empDTO1 = mapper.Map<PermenantEmployee<string,int,bool>>(emp);
            var empDTO2 = mapper.Map<Employee<string,int,bool>, PermenantEmployee<string,int,bool>>(emp);
            Console.WriteLine("Name: " + empDTO1.Name + ", Salary: " + empDTO1.Sal + ", Address: " + empDTO1.Address + ", Department: " + empDTO1.Department+ "  Passport: "+empDTO1.Passport);
            Console.ReadLine();
        }
    }
}