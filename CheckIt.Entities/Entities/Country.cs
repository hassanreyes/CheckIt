using System.Collections.Generic;

namespace CheckIt.Entities
{
    public partial class Country : Entity
    {
        public Country()
        {
            this.Accounts = new List<Account>();
        }

        //public virtual short CountryId { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }
        public virtual string LongName { get; set; }
        public virtual string Iso2 { get; set; }
        public virtual string Iso3 { get; set; }
        public virtual string NumCode { get; set; }
        public virtual string UNMember { get; set; }
        public virtual string CallingCode { get; set; }
        public virtual string Cctld { get; set; }

        public virtual List<Account> Accounts { get; set; }
    }
}
