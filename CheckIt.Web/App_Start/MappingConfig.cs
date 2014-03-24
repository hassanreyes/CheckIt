using AutoMapper;
using CheckIt.Web.Mapping;

namespace CheckIt.Web
{
    public class MappingConfig
    {
        public static void Configure()
        {
            Mapper.AddProfile(new AreaMapperProfile());
            Mapper.AddProfile(new CategoryMapperProfile());
            Mapper.AddProfile(new ChecklistMapperProfile());
            Mapper.AddProfile(new SectionMapperProfile());
            Mapper.AddProfile(new ItemMapperProfile());
            
        }
    }
}