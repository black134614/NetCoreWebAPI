using AutoMapper;

namespace API.Helpers.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new Ef_To_Dto_MappingProfile());
                cfg.AddProfile(new Ef_To_Dto_MappingProfile());
            });
        }
    }
}