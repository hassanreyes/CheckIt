using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckIt.Web.Models.Catalog
{
    public class AreaModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<CategoryModel> Categories { get; set; }
    }
}