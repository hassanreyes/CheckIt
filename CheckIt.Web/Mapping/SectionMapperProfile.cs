using AutoMapper;
using CheckIt.Entities;
using CheckIt.Web.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckIt.Web.Mapping
{
    public class SectionMapperProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<List<ItemEditionModel>, List<Item>>();
            Mapper.CreateMap<Section, SectionEditionModel>()
                        .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                        .ForMember(x => x.Description, y => y.MapFrom(z => z.Description))
                        .ForMember(x => x.Items, y => y.MapFrom(z => z.Items));
        }
    }
}