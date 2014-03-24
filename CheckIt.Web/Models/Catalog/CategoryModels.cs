using System.Collections.Generic;

namespace CheckIt.Web.Models.Catalog
{
    public class CategoryModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<string> Route { get; set; }

        public AreaModel Area { get; set; }

        public CategoryModel SuperCategory { get; set; }

        public List<CategoryModel> SubCategories { get; set; }

        public IEnumerable<ChecklistSummaryModel> Checklists { get; set; }
    }
}