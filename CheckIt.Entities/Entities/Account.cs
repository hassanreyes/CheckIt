using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CheckIt.Entities
{
    public partial class Account : Entity
    {
        public Account()
        {
            this.DefaultLanguage = "en";
            this.Folders = new List<Folder>();
            this.Favorites = new List<Favorite>();
        }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Ocupation { get; set; }
        public virtual string Industry { get; set; }
        public virtual AccountStatus Status { get; set; }
        public virtual string DefaultLanguage { get; set; }
        //public virtual string User_Id { get; set; }

        public virtual List<Folder> Folders { get; set; }
        public virtual List<Favorite> Favorites { get; set; }
        public virtual List<Share > Shares { get; set; }
        public virtual Country Country { get; set; }
        public virtual User User { get; set; }
    }
}
