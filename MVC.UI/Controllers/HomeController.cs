using DAL.Context;
using DAL.Entity;
using DAL.Tools;
using MVC.UI.Models.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Controllers
{
    public class HomeController : Controller
    {
        EcommerceContext db = DbTools.Context;
        // GET: Home
        public ActionResult Login()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserVM userVM)
        {
            if (ModelState.IsValid)
            {
                bool result=db.Users.Any(x=>x.UserName==userVM.UserName && x.Password==userVM.Password);
                if (result)
                {
                    User user = db.Users.Where(x => x.UserName == userVM.UserName && x.Password == userVM.Password).FirstOrDefault();
                    Session["login"]=user;
                    return View(user);
                }
                else
                {
                    TempData["error"] = "Kullanıcı bilgilerini hatalıdır";
                    return View(userVM);
                }

            }
            else
            {
                return View(userVM);
            }

        }
    }
}