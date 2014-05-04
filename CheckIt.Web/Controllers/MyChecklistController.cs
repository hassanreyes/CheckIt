using CheckIt.Entities;
using CheckIt.Web.Infras.Services;
using CheckIt.Web.Infras.Extensions;
using System;
using System.Web.Mvc;
using CheckIt.Domain;

namespace CheckIt.Web.Controllers
{
    public class MyChecklistController : Controller
    {
        public ICatalogService CatalogService { get; protected set; }

        public IAccountService AccountService { get; protected set; }

        public MyChecklistController(ICatalogService catService, IAccountService accService)
        {
            this.CatalogService = catService;
            this.AccountService = accService;
        }

        //
        // GET: /MyChecklist/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(string id, string content)
        {
            User user = System.Web.HttpContext.Current.Session.GetSessionUser();
            Category cat = null;

            if(String.IsNullOrWhiteSpace(id))
            {
                cat = this.CatalogService.Categories.GetByName(CheckItContext.AnonymousUserName);
                Checklist chklst = this.CatalogService.SaveChecklist(content, cat, user);
                if (chklst != null)
                {
                    return Json(chklst.Id.ToString());
                }
                ModelState.AddModelError("", "The given Checklist could not be saved");
            }
            else
            {
                //Remove
                //this.CatalogService.Checklists.SaveChecklist()

                return Json(id);
            }
            
            return Json(id);
        }
	}
}