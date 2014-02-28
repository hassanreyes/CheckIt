using System.Collections.Generic;

namespace CheckIt.Entities
{
    public partial class Category : Entity
    {
        public Category()
        {
            this.SubCategories = new List<Category>();
            this.Checklists = new List<Checklist>();
        }

        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        public virtual Area Area { get; set; }
        public virtual List<Category> SubCategories { get; set; }
        public virtual Category SuperCategory { get; set; }
        public virtual List<Checklist> Checklists { get; set; }
    }
}
