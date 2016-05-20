using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DaxiomaticWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        // This is a get method for Login
        public ActionResult Login()
        {
            return View();
        }

        // This is a post Method for Login
        [HttpPost]
        public ActionResult Login(DaxLoginInfo daxLogin)
        {
            using (DaxiomaticWeb.villadsenwp_dk_dbEntities myDB = new villadsenwp_dk_dbEntities())
            {
                var usr = myDB.DaxLoginInfo.Where(u => u.Username == daxLogin.Username && u.Password == daxLogin.Password).FirstOrDefault();
                
                if (usr != null)
                {
                    Session["ID"] = usr.ID.ToString();
                    Session["UserName"] = usr.Username.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "UserName or PassWord is not valid");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}