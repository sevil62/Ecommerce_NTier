using DAL.Entity;
using Service.Conc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Areas.Admin.Controllers
{
    public class SubCategoryController : Controller
    {
        SubCategoryService _screp=new SubCategoryService();
        // GET: Admin/SubCategory
        public ActionResult SubCategoryList()
        {
            return View(_screp.GetList());
        }

        public ActionResult CreateSubCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSubCategory(SubCategory subCategory)
        {
            _screp.Add(subCategory);
            return RedirectToAction("SubCategoryList");
        }
        public ActionResult UpdateSubCategory(int? id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult UpdateSubCategory(SubCategory subCategory)
        {

            _screp.Update(subCategory);
            return RedirectToAction("SubCategoryList");
        }

        public ActionResult DeleteSubCategory(Guid id)
        {
            _screp.Delete(id);
            return RedirectToAction("SubCategoryList");
        }
    }
}