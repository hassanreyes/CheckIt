using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CheckIt.Web.Models.Catalog;

namespace CheckIt.Web.Models.MyChecklist
{
    public class MyChecklistEditionModel
    {
        public ChecklistEditionModel Checklist { get; set; }

        public CheckIt.Entities.Checklist.LineType LineType { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }
    }
}