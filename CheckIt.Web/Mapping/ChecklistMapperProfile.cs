using AutoMapper;
using CheckIt.Entities;
using CheckIt.Web.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckIt.Web.Mapping
{
    public class ChecklistMapperProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<List<SectionEditionModel>, List<Section>>();
            Mapper.CreateMap<Checklist, ChecklistEditionModel>()
                        .ForMember(x => x.Title, y => y.MapFrom(z => z.Title))
                        .ForMember(x => x.Description, y => y.MapFrom(z => z.Description))
                        .ForMember(x => x.Content, y => y.MapFrom(z => z.Content))
                        .ForMember(x => x.Sections, y => y.MapFrom(z => z.Sections));

            Mapper.CreateMap<IEnumerable<ChecklistSummaryModel>, IEnumerable<Checklist>>();
            Mapper.CreateMap<Checklist, ChecklistSummaryModel>()
                        .ForMember(x => x.Title, y => y.MapFrom(z => z.Title))
                        .ForMember(x => x.Description, y => y.MapFrom(z => z.Description))
                        .ForMember(x => x.CreatedBy, y => y.MapFrom(z => z.CreatedBy));
        }
    }
}