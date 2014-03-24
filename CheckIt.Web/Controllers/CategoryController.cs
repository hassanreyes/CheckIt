using AutoMapper;
using CheckIt.Entities;
using CheckIt.Web.Infras.Services;
using CheckIt.Web.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CheckIt.Web.Controllers
{
    public class CategoryController : Controller
    {
        public ICatalogService CatalogService { get; protected set; }

        public IAccountService AccountService { get; protected set; }

        public CategoryController(ICatalogService catService, IAccountService accService)
        {
            this.CatalogService = catService;
            this.AccountService = accService;
        }

        //
        // GET: /Category/
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// List the main categories
        /// </summary>
        /// <returns></returns>
        public ActionResult Show(string id)
        {
            Category category = this.CatalogService.Categories.GetById(Guid.Parse(id));
            this.CatalogService.Checklists.GetChecklists(category);
            CategoryModel model = Mapper.Map<Category, CategoryModel>(category);

            List<Tuple<string, string>> route = new List<Tuple<string,string>>();

            while (category.SuperCategory != null)
            {
                route.Add(Tuple.Create<string, string>(category.SuperCategory.Id.ToString(), category.SuperCategory.Name));
                category = category.SuperCategory;
            }

            if (!this.ViewData.ContainsKey("Route"))
                this.ViewData.Add("Route", route);
            else
                this.ViewData["Route"] = route;

            return View(model);
        }
	}
}