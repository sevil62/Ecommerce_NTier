using Core;
using DAL.Context;
using DAL.Entity;
using DAL.Tools;
using MVC.UI.Models.VMClasses;
using Service.Conc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService _crep;
        EcommerceContext db = DbTools.Context;

        public CategoryController()
        {
            _crep = new CategoryService();
        }

        // GET: Category
        public ActionResult ListCategories()
        {
            CategoryVM cvm = new CategoryVM
            {
                Categories = _crep.GetList()
            };

            return View(cvm);
        }
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddCategory(Category category)
        {
            _crep.Add(category);
            return RedirectToAction("ListCategories");
        }

        public ActionResult UpdateCategory(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            _crep.Update(category);
            return RedirectToAction("ListCategories");
        }

        public ActionResult DeleteCategory(int id)
        {
            _crep.Delete(Guid.Empty);
            return RedirectToAction("ListCategories");
        }
    }
}