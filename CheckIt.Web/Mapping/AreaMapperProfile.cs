using AutoMapper;
using CheckIt.Entities;
using CheckIt.Web.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckIt.Web.Mapping
{
    public class AreaMapperProfile : Profile
    {
        protected override void Configure()
        {
            //Mapper.CreateMap<IEnumerable<Area>, IEnumerable<AreaModel>>();
            Mapper.CreateMap<Area, AreaModel>()
                        .ForMember(x => x.Id, y => y.MapFrom(z => z.Id.ToString()))
                        .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                        .ForMember(x => x.Categories, y => y.MapFrom(z => z.Categories));
        }
    }
}