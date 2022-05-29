using DAL.Entity;
using MVC.UI.CustomFilter;
using Service.Conc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Areas.Admin.Controllers
{
    [AuthAdmin]
    public class CategoryController : Controller
    {
        CategoryService _crep = new CategoryService();
      
        // GET: Admin/Category
        public ActionResult CategoryList()
        {
            ViewBag.CategoryService = _crep;
           
            return View(_crep.GetList());
        }

        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            try
            {
                string result=_crep.Add(category);
                TempData["info"] = result;
                return RedirectToAction("CategoryList");

            }
            catch (Exception ex)
            {

                TempData["error"] = ex.Message;
            }
            return View();
        }
        public ActionResult UpdateCategory(Guid id)
        {
            try
            {
                Category updated = _crep.GetById(id);
                return View(updated);
            }
            catch (Exception ex)
            {

                TempData["error"]=ex.Message;
                return View();
            }
            
        }
            

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            try
            {
                string result=_crep.Update(category);
                TempData["info"] = result;
                return RedirectToAction("CategoryList");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
               
            }
            return View();
          
        }

        public ActionResult DeleteCategory(Guid id)
        {
            try
            {
                string result = _crep.Delete(id);
                TempData["info"]=result;
                return RedirectToAction("CategoryList");

            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View();
            }
        }
    }
}