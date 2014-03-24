using AutoMapper;
using CheckIt.Entities;
using CheckIt.Web.Infras.Services;
using CheckIt.Web.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CheckIt.Web.Controllers
{
    public class AreaController : Controller
    {
        public ICatalogService CatalogService { get; protected set; }

        public AreaController(ICatalogService catService)
        {
            this.CatalogService = catService;
        }

        //
        // GET: /Area/
        public ActionResult Index()
        {
            IEnumerable<Area> areas = this.CatalogService.Areas.GetAreas();

            IEnumerable<AreaModel> models = Mapper.Map<IEnumerable<Area>, IEnumerable<AreaModel>>(areas);

            return View(models);
        }

        public ActionResult Show(string id)
        {
            Area area = this.CatalogService.Areas.GetById(Guid.Parse(id));

            //This must be call in order to load related area categories
            this.CatalogService.Categories.GetCategories(area);

            AreaModel model = Mapper.Map<Area, AreaModel>(area);

            return View(model);
        }
	}
}