using CheckIt.Entities;
using CheckIt.Web.Infras.Controllers;
using CheckIt.Web.Models.WorkingChecklist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckIt.Web.Controllers.WorkingChecklist
{
    public class WorkingChecklistController : BaseController
    {
        //
        // GET: /WorkingChecklist/
        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult Edit()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Edit(WorkingChecklistViewModel model)
        {
            return RedirectToAction("Index");
        }

        public ActionResult AddSection(Section section)
        {
            return RedirectToAction("Index");
        }

        public ActionResult AddItem(Item item)
        {
            return RedirectToAction("Index");
        }
	}
}