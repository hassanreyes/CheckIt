using System;
using System.Collections.Generic;

namespace CheckIt.Entities
{
    public abstract partial class Item : Entity
    {
        public Item()
        {
            this.Hints = 0;
            this.Keywords = new List<Keyword>();
            this.Answers = new List<Answer>();
        }

        public virtual string Content { get; set; }
        public virtual string Description { get; set; }
        public virtual string Reference1 { get; set; }
        public virtual string Reference2 { get; set; }
        public virtual long Hints { get; set; }
        public virtual ItemStatus Status { get; set; }
        //public virtual ItemType Type { get; set; }
        public virtual Guid Section_Id { get; set; }

        public virtual Section Section { get; set; }
        public virtual List<Keyword> Keywords { get; set; }
        public virtual List<Answer> Answers { get; set; }
    }
}
