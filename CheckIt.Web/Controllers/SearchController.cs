using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheckIt.Web.Models.Search;
using CheckIt.Entities;

namespace CheckIt.Web.Controllers
{
    public class SearchController : Controller
    {
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

            searchEntry.Result = new List<Checklist>();
            searchEntry.Result.Add(new Entities.Checklist()
                {
                    Id = Guid.NewGuid(),
                    Title = "Demo 1",
                    Description = "Este es solo una demostracion"
                });

            searchEntry.Result.Add(new Entities.Checklist()
            {
                Id = Guid.NewGuid(),
                Title = "Demo 2",
                Description = "Este tambien es solo una demostracion"
            });

            return View(searchEntry);
        }
	}
}