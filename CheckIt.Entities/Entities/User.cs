using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CheckIt.Entities
{
    public partial class User : Entity
    {
        public User()
        {
            this.Checklists = new List<Checklist>();
            this.Answers = new List<Answer>();
        }

        public virtual string DisplayName { get; set; }
        public virtual string Password { get; set; }
        public virtual string Email { get; set; }
        public int Role { get; set; }
        public virtual List<Checklist> Checklists { get; set; }
        public virtual Account Account { get; set; }
        public virtual List<Answer> Answers { get; set; }
    }
}
