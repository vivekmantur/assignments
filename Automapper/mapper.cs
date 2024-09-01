using AutoMapper;
namespace AutoMapperDemo
{
    /// <summary>
    /// Configures AutoMapper with mappings between types.
    /// </summary>
    /// <typeparam name="T">Type parameter for the first generic type</typeparam>
    /// <typeparam name="U">Type parameter for the second generic type</typeparam>
    /// <typeparam name="R">Type parameter for the third generic type</typeparam>
    public class MapperConfig<T,U,R>
    {
        public static Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee<T,U,R>, PermenantEmployee<T,U,R>>();
            });
            var mapper = new Mapper(config);
            return mapper;
        }
    }
}