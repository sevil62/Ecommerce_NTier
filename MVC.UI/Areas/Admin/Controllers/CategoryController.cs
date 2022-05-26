using DAL.Entity;
using MVC.UI.Areas.Admin.Models;
using Service.Conc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService _crep = new CategoryService();
      
        // GET: Admin/Category
        public ActionResult CategoryList()
        {
          //_crep.ProductCount(c.CategoryName);
           
            return View(_crep.GetList());
        }

        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            _crep.Add(category);
            return RedirectToAction("CategoryList");
        }
        public ActionResult UpdateCategory(int? id)
        {
            return View();
        }
            

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {

            _crep.Update(category);
            return RedirectToAction("CategoryList");
        }

        public ActionResult DeleteCategory(Guid id)
        {
            _crep.Delete(id);
            return RedirectToAction("CategoryList");
        }
    }
}