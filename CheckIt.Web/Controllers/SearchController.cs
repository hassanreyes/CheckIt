using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheckIt.Web.Models.Search;
using CheckIt.Entities;
using CheckIt.Web.Infras.Services;
using CheckIt.Web.Models.Catalog;
using AutoMapper;

namespace CheckIt.Web.Controllers
{
    public class SearchController : Controller
    {
        public ICatalogService CatalogService { get; set; }

        public SearchController(ICatalogService catService)
        {
            this.CatalogService = catService;
        }

        //
        // GET: /Search/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(SearchEntryModel searchEntry)
        {
            if (String.IsNullOrWhiteSpace(searchEntry.QueryText))
                return RedirectToAction("Index");

            searchEntry.Ids = this.CatalogService.SearchChecklsitContent(searchEntry.QueryText);

            IEnumerable<Checklist> chklst = this.CatalogService.Checklists.GetChecklists(searchEntry.Ids);
            IEnumerable<ChecklistSummaryModel> result = null;

            if(chklst != null)
            {
                result = Mapper.Map<IEnumerable<Checklist>, IEnumerable<ChecklistSummaryModel>>(chklst);
            }

            if (result != null)
                searchEntry.Result = result;
            else
                searchEntry.Result = new List<ChecklistSummaryModel>();

            return View(searchEntry);
        }
	}
}