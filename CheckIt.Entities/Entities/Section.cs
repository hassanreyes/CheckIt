using CheckIt.Entities.Entities;
using System;
using System.Collections.Generic;

namespace CheckIt.Entities
{
    public partial class Section : Entity, IContentStringSettable
    {
        public Section()
        {
            this.Hints = 0;
            this.Items = new List<Item>();
            this.Keywords = new List<Keyword>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public long Hints { get; set; }
        public ItemStatus Status { get; set; }
        public Guid Checklist_Id { get; set; } 

        public virtual Checklist Checklist { get; set; }
        public virtual List<Item> Items { get; set; }
        public virtual List<Keyword> Keywords { get; set; }

        public void SetContentString(string content)
        {
            this.Name = content;
        }
    }
}
