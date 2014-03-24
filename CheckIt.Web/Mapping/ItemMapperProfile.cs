using AutoMapper;
using CheckIt.Entities;
using CheckIt.Web.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckIt.Web.Mapping
{
    public class ItemMapperProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Item, ItemEditionModel>()
                        .ForMember(x => x.Content, y => y.MapFrom(z => z.Content));
        }
    }
}