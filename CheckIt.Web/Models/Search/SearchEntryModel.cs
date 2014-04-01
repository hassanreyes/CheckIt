using CheckIt.Entities;
using CheckIt.Web.Models.Catalog;
using System;
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

        public int PagingSize { get; set; }

        public int CurrentPage { get; set; }

        public Guid[] Ids { get; set; }

        public IEnumerable<ChecklistSummaryModel> Result { get; set; }

    }
}