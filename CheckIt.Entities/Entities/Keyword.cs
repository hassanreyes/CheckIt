using System.Collections.Generic;

namespace CheckIt.Entities
{
    public partial class Keyword : Entity
    {
        public Keyword()
        {
            this.Language = "en";
            this.Hints = 0;
            this.Checklists = new List<Checklist>();
            this.Sections = new List<Section>();
            this.Items = new List<Item>();
            this.RelatedKeywords = new List<Keyword>();
            this.ReferencedKeywords = new List<Keyword>();
        }

        public virtual string Word { get; set; }
        public virtual string Language { get; set; }
        public virtual long Hints { get; set; }

        public virtual List<Checklist> Checklists { get; set; }
        public virtual List<Section> Sections { get; set; }
        public virtual List<Item> Items { get; set; }
        public virtual List<Keyword> RelatedKeywords { get; set; }
        public virtual List<Keyword> ReferencedKeywords { get; set; }
    }
}
