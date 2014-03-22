using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckIt.Web.Models.Catalog
{
    public class SectionEditionModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<ItemEditionModel> Items { get; set; }

    }
}