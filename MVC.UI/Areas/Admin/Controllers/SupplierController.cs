using DAL.Entity;
using Service.Conc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Areas.Admin.Controllers
{
    public class SupplierController : Controller
    {
        SupplierService _srep=new SupplierService();
        // GET: Admin/Supplier
        public ActionResult SupplierList()
        {

            return View(_srep.GetList());
        }

        public ActionResult CreateSupplier()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSupplier(Supplier supplier)
        {
            _srep.Add(supplier);
            return RedirectToAction("SupplierList");
        }
        public ActionResult UpdateSupplier(int? id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateSupplier(Supplier supplier)
        {

            _srep.Update(supplier);
            return RedirectToAction("SupplierList");
        }

        public ActionResult DeleteSupplier(Guid id)
        {
            _srep.Delete(id);
            return RedirectToAction("SupplierList");
        }
    }
}
