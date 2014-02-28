using System.Collections.Generic;

namespace CheckIt.Entities
{
    public partial class Area : Entity
    {
        public Area()
        {
            this.Categories = new List<Category>();
        }

        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        public virtual List<Category> Categories { get; set; }
    }
}
