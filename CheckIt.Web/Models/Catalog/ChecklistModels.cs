using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckIt.Web.Models.Catalog
{
    public class ChecklistSummaryModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //public string ContentFragment { get; set; }
        //public string SectionsSummary { get; set; }
        public string CreatedBy { get; set; }

    }

    public class ChecklistEditionModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public List<SectionEditionModel> Sections { get; set; }

        public string Content { get; set; }
    }
}