using System.ComponentModel.DataAnnotations;

namespace AutoMapperDemo
{
    /// <summary>
    /// The second class where object mapping is needed
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    /// <typeparam name="R"></typeparam>
    public class PermenantEmployee<T,U,R>
    {
        public T Name { get; set; }
        public U Salary { get; set; }
        public T Address { get; set; }
        public T Department { get; set; }

        public R Passport { get; set; }
    }
}
