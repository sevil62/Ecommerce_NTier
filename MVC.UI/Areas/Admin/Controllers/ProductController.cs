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
        // GET: Admin/Product
        public ActionResult ProductList()
        {
            return View(_prep.GetList());
        }

        public ActionResult CreateProducrt()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            _prep.Add(product);
            return RedirectToAction("ProductList");
        }
        public ActionResult UpdateProduct(int? id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {

            _prep.Update(product);
            return RedirectToAction("ProductList");
        }

        public ActionResult DeleteCategory(Guid id)
        {
            _prep.Delete(id);
            return RedirectToAction("ProductList");
        }
    }
}