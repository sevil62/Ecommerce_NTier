using Common;
using DAL.Entity;
using Service.Conc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        ProductService _prep=new ProductService();
        SubCategoryService _sbrep=new SubCategoryService();
        SupplierService _srep=new SupplierService();
        // GET: Admin/Product
        public ActionResult Index()
        {
            return View(_prep.GetList());
        }

        // GET: Admin/Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Product/Create
        public ActionResult Create()
        {
            ViewBag.SubCategories = _sbrep.GetDefault(x => x.Status == Core.Enum.Status.Active).ToList();
            ViewBag.Suppliers = _srep.GetDefault(x => x.Status == Core.Enum.Status.Active).ToList();
            return View();
        }

        // POST: Admin/Product/Create
        [HttpPost]
        public ActionResult Create(Product product, HttpPostedFileBase fileImage)
        {
            try
            {
                product.ProductImagePath = ImageUpLoad.UploadImage("~/Content/image/product/", fileImage);
                var result = _prep.Add(product);
                TempData["info"] = result;

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View();
            }
        }

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}