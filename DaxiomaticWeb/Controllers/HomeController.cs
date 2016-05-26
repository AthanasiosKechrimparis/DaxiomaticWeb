using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DaxiomaticWeb.Models;

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
        public ActionResult Login(EntityFrameWork.DaxLoginInfo daxLogin)
        {
            
            using (DaxiomaticWeb.EntityFrameWork.villadsenwp_dk_dbEntities myDB = new EntityFrameWork.villadsenwp_dk_dbEntities())
            {
                var usr = myDB.DaxLoginInfo.Where(u => u.Username == daxLogin.Username && u.Password == daxLogin.Password).FirstOrDefault();
                
                if (usr.UserLevel == 0)
                {
                    SessionData.SessionProp = usr.ID;
                    Session["UserName"] = usr.Username.ToString();
                    return RedirectToAction("StatisticsUserIndex","UserStatistics");
                }
                else if(usr.UserLevel == 1)
                {
                    SessionData.SessionProp = usr.ID;
                    Session["UserName"] = usr.Username.ToString();
                    return RedirectToAction("AdminStatisticIndex", "AdminStatistic");
                }
                else if (usr != null)
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