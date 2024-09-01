namespace AutoMapperDemo
{
    /// <summary>
    /// Employee class acts as domain class 
    /// </summary>
    /// <typeparam name="T">Type parameter for the first generic type of Employee</typeparam>
    /// <typeparam name="U">Type parameter for the second generic type of Employee</typeparam>
    /// <typeparam name="R">Type parameter for the third generic type of Employee</typeparam>
    public class Employee<T,U,R>
    {
        public T Name { get; set; }
        public U Salary { get; set; }
        public T Address { get; set; }
        public T Department { get; set; }

        //public R Passport { get; set; }
    }
}
