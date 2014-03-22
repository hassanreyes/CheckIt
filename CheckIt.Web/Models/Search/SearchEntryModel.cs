using CheckIt.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CheckIt.Web.Models.Search
{
    public class SearchEntryModel
    {
        [Required]
        [DisplayName("Search Keyword(s)")]
        public string QueryText { get; set; }

        public IList<Checklist> Result { get; set; }

    }
}