using System;
using System.Collections.Generic;

namespace CheckIt.Entities
{
    public partial class Folder : Entity
    {
        public Folder()
        {
            this.Status = FolderStatus.Unknown;
            this.SubFolders = new List<Folder>();
        }

        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual FolderStatus Status { get; set; }
        public virtual Guid Account_Id { get; set; }

        public virtual Account Account { get; set; }
        public virtual List<Folder> SubFolders { get; set; }
        public virtual Folder ParentFolder { get; set; }
        public virtual List<Checklist> Checklists { get; set; }
    }
}
