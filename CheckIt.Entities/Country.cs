//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheckIt.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Country
    {
        public Country()
        {
            this.Accounts = new HashSet<Account>();
        }
    
        public short CountryId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string Iso2 { get; set; }
        public string Iso3 { get; set; }
        public string NumCode { get; set; }
        public string UNMember { get; set; }
        public string CallingCode { get; set; }
        public string Cctld { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
    }
}