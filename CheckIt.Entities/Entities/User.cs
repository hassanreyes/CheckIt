using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CheckIt.Entities
{
    public partial class User : IdentityUser
    {
        public User()
        {
            this.Checklists = new List<Checklist>();
            this.Answers = new List<Answer>();
            this.IsTemporal = true;
        }

        //public virtual string UserName { get; set; }
        public virtual string DisplayName { get; set; }
        //public virtual string Password { get; set; }
        public virtual string Email { get; set; }        
        public bool IsTemporal { get; set; }
        public virtual List<Checklist> Checklists { get; set; }
        public virtual Account Account { get; set; }
        public virtual List<Answer> Answers { get; set; }
        public virtual List<Share> SharedWithMe { get; set; }
    }
}
