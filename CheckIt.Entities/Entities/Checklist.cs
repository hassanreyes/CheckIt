using CheckIt.Entities.Entities;
using System;
using System.Collections.Generic;

namespace CheckIt.Entities
{
    public partial class Checklist : Entity, IContentStringSettable
    {
        public Checklist()
        {
            this.Hints = 0;
            this.Rating = 0;
            this.Language = "en";
            this.Sections = new List<Section>();
            this.Sections.Add(new Section { Name = "General" });
            this.Keywords = new List<Keyword>();
        }

        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string Content { get; set; }
        public virtual string Reference1 { get; set; }
        public virtual string Reference2 { get; set; }
        public virtual long Hints { get; set; }
        public virtual short Rating { get; set; }
        public virtual string Language { get; set; }
        public virtual ItemStatus Status { get; set; }
        public virtual Guid Category_Id { get; set; }

        public virtual List<Section> Sections { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Keyword> Keywords { get; set; }
        public virtual User User { get; set; }
        public virtual Folder Folder { get; set; }

        public void SetContentString(string content)
        {
            if(!String.IsNullOrWhiteSpace(content))
            {
                string[] lines = content.Split(new string[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
                this.Title = lines[0];
                if(lines.Length > 1)
                {
                    string[] description = new string[lines.Length - 1];
                    Array.Copy(lines, 1, description, 0, description.Length);
                    this.Description = String.Join("", description);
                }
            }
            
        }
    }
}
