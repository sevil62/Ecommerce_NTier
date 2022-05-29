using DAL.Entity;
using MVC.UI.Models;
using Service.Conc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Controllers
{
    public class ProductController : Controller
    {
        ProductService _prep=new ProductService();
        // GET: Product
        public ActionResult Index()
        {
            return View(_prep.GetDefault(x=>x.SubCategoryId!=null).ToList());
        }
        public ActionResult AddToCart(Guid id)
        {
            try
            {
                Product product = _prep.GetById(id);
                Cart c = null;
                if (Session["scart"] == null)
                {
                    c = new Cart();
                }
                else
                {
                    c = Session["scart"] as Cart;
                }

                CartItem ci = new CartItem();
                ci.Id = Convert.ToInt32(product.ID);
                ci.ProductName = product.ProductName;
                ci.Price = product.UnitPrice;
                c.AddItem(ci);
                Session["scart"] = c;
                return RedirectToAction("Index");
            }
            catch (System.Exception)
            {
                TempData["error"] = $"{id} karşılık gelen bir ürün bulunamadı!";
                return View();

            }
        }
            public ActionResult MyCart()
            {
                if (Session["scart"] != null)
                {
                    return View();
                }
                else
                {
                    TempData["error"] = "sepetinizde ürün bulunmamaktadır!";
                    return RedirectToAction("Index");
                }

            }
        public ActionResult CompleteCart(Guid id)
        {
            Cart cart = Session["scart"] as Cart;
            foreach (var item in cart.myCart)
            {
                Product product =_prep.GetById(id);
                product.UnitsInStock -= Convert.ToInt16(item.Quantity);
                _prep.Update(product);
                
                ViewBag.OrderNumber = "156565";
                Session.Remove("scart");

            }
            return View();
        }


    }
}