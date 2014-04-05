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
using CheckIt.Web.Infras.Helpers;
using CheckIt.Web.Infras.Extensions;

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
            this.Session[Constants.SearchResultKey] = searchEntry;

            return Navigate(0);
        }

        public ActionResult Navigate(int ? page)
        {
            var value = this.Session[Constants.SearchResultKey];
            if (value == null || !(value is SearchEntryModel))
            {
                return RedirectToAction("Index");
            }

            SearchEntryModel model = value as SearchEntryModel;
            UserPreferences pref = System.Web.HttpContext.Current.Session.GetUserPreferences();
            page = page ?? 0;
            List<Guid> ids = new List<Guid>();
            ids.AddRange(model.Ids);
            model.CurrentPage = page.Value;

            IEnumerable<Checklist> chklst = this.CatalogService.Checklists.GetChecklists(ids
                                                .Skip(page.Value * pref.PageSize)
                                                .Take(pref.PageSize).ToArray());
            
            if (chklst != null)
            {
                model.Result = Mapper.Map<IEnumerable<Checklist>, IEnumerable<ChecklistSummaryModel>>(chklst);
            }

            return View("Search", model);
        }
	}
}