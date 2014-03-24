using AutoMapper;
using CheckIt.Entities;
using CheckIt.Web.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckIt.Web.Mapping
{
    public class CategoryMapperProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<List<CategoryModel>, List<Category>>();
            Mapper.CreateMap<IEnumerable<CategoryModel>, IEnumerable<Category>>();
            Mapper.CreateMap<Category, CategoryModel>()
                        .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                        .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                        .ForMember(x => x.Area, y => y.MapFrom(z => z.Area))
                        .ForMember(x => x.SuperCategory, y => y.MapFrom(z => z.SuperCategory))
                        .ForMember(x => x.SubCategories, y => y.MapFrom(z => z.SubCategories))
                        .ForMember(x => x.Checklists, y => y.MapFrom(z => z.Checklists));
        }
    }
}