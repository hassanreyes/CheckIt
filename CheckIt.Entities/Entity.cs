using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckIt.Entities
{
    public class Entity
    {
        public virtual Guid Id
        {
            get;
            set;
        }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual bool IsTransient()
        {
            return this.Id == Guid.Empty;
        }
    }
}
