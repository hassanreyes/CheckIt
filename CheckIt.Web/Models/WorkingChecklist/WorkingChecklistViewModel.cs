using CheckIt.Entities;
using CheckIt.Web.Infras.Helpers;
using CheckIt.Web.Infras.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheckIt.Web.Infras.Extensions;

namespace CheckIt.Web.Models.WorkingChecklist
{
    public class WorkingChecklistViewModel
    {
        Checklist _checklist;

        public string Title 
        { 
            get { return _checklist.Title; }
            set { _checklist.Title = value; } 
        }

        public List<Section> Sections 
        {
            get { return _checklist.Sections; }
            set { _checklist.Sections = value; } 
        }

        public WorkingChecklistViewModel(Checklist checklist)
        {
            _checklist = checklist;
        }

        public static WorkingChecklistViewModel Current
        {
            get
            {
                var value = HttpContext.Current.Session[Constants.WorkingChecklist];
                if (value == null)
                {
                    CheckItUserManager userManager = DependencyResolver.Current.GetService<CheckItUserManager>();

                    Checklist chklist = new Checklist();
                    chklist.User = HttpContext.Current.Session.GetSessionUser();
                    chklist.Title = "My Checklist";
                    WorkingChecklistViewModel workingChecklist = new WorkingChecklistViewModel(chklist);
                    HttpContext.Current.Session.Add(Constants.WorkingChecklist, workingChecklist);
                }

                return (WorkingChecklistViewModel)HttpContext.Current.Session[Constants.WorkingChecklist];
            }
        }
    }
}