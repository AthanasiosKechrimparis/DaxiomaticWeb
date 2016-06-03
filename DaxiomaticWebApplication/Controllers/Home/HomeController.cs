using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DaxiomaticWebApplication.Models;


namespace DaxiomaticWebApplication.Controllers.Home
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
        public ActionResult Login(Models.LoginClasses.LoginInfo daxLogin)
        {

            using (EntityFrameWork.villadsenwp_dk_dbEntities myDB = new EntityFrameWork.villadsenwp_dk_dbEntities())
            {
                var usr = myDB.DaxLoginInfo.Where(u => u.Username == daxLogin.UserName && u.Password == daxLogin.PassWord).FirstOrDefault();
                
                if (usr.UserLevel == 0)
                {
                    SessionData.SessionProp = usr.ID;
                    Session["ID"] = usr.ID;
                    Session["UserName"] = usr.Username.ToString();
                    return RedirectToAction("StatisticsUserIndex", "UserStatistics");
                }
                else if (usr.UserLevel == 1)
                {
                    SessionData.SessionProp = usr.ID;
                    Session["UserName"] = usr.Username.ToString();
                    return RedirectToAction("AdminStatisticIndex", "AdminStatistic");
                }
                else if (usr == null)
                {
                   // ModelState.AddModelError("", "UserName or PassWord is not valid");
                    return Content("UserName or PassWord is not valid");
                }
            }
            return View();
        }
    }
}