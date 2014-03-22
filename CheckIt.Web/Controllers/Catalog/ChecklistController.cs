using CheckIt.Entities;
using CheckIt.Web.Infras.Controllers;
using CheckIt.Web.Infras.Helpers;
using CheckIt.Web.Infras.Security;
using CheckIt.Web.Infras.Services;
using CheckIt.Web.Infras.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace CheckIt.Web.Controllers.Catalog
{
    public class ChecklistController : BaseController
    {
        public ICatalogService CatalogService { get; protected set; }

        public ChecklistController(ICatalogService catService)
        {
            this.CatalogService = catService;
        }

        //
        // GET: /Checklist/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(Checklist chklst)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult  Upload(HttpPostedFileBase file)
        {
            if(file != null && file.ContentLength > 0)
            {
                StreamReader reader = new StreamReader(file.InputStream);
                string content = reader.ReadToEnd();
                
                User user = System.Web.HttpContext.Current.Session.GetSessionUser();

                Checklist chklst = this.CatalogService.SaveChecklist(content, user);
                if (chklst != null)
                {
                    RedirectToAction("Edit", chklst);
                }

                ModelState.AddModelError("", "The given Checklist could not be saved");
            }

            return RedirectToAction("Upload");
        }
	}
}