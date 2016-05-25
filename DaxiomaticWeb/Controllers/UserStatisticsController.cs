using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using System.Web.Helpers;
using DaxiomaticWeb.EntityFrameWork;
using System.Data.Entity;
using DaxiomaticWeb.Models;

namespace DaxiomaticWeb.Controllers
{
    public class UserStatisticsController : Controller
    {
        
        // GET: Statistics
        public ActionResult StatisticsUserIndex()
        {
            return View();
        }

        public ActionResult StatisticsDates()
        {
            return View();
        }
        EntityFrameWork.villadsenwp_dk_dbEntities myDB = new villadsenwp_dk_dbEntities();
        
        //List<string> listOfCompanies = new List<string>();
        List<string> listOfWeight = new List<string>();
        List<string> listToArrayCompanies = new List<string>();
        List<string> listToArrayHappiness = new List<string>();
        List<string> listToArrayTask = new List<string>();

            

        // Getting the Favorite Company
        [HttpGet]
        public ActionResult CompanyBarChart()
        {
            // To get the Favorite companies
            var favoriteCompany = from b in myDB.DaxCompanyData
                                  where b.InputID == SessionData.SessionProp
                                  select b;

            foreach (var item in favoriteCompany)
            {
                listToArrayCompanies.Add(item.Name);
                listToArrayCompanies.ToArray();
            }
            // To get the Happiness Score
            var happinessScoreEF = from b in myDB.DaxInputData
                                   where b.UserID == SessionData.SessionProp
                                   select b;

            foreach (var item in happinessScoreEF)
            {
                listToArrayHappiness.Add(item.HappinessScore.ToString());
                listToArrayHappiness.ToArray();
            }
            //Create bar chart
            var chart = new Chart(width: 300, height: 200)
            .AddSeries(chartType: "bar",
                            xValue: listToArrayCompanies,
                            yValues: listToArrayHappiness)
                            .GetBytes("png");

            return File(chart, "image/bytes");
        }

        // Getting the Favorite Tasks
        [HttpGet]
        public ActionResult TaskBarChart()
        {
            // To get the Type of Tasks
            var favoriteCompany = from b in myDB.DaxTaskData
                                  where b.InputID == SessionData.SessionProp
                                  select b;

            foreach (var item in favoriteCompany)
            {
                listToArrayTask.Add(item.DaxTaskDetail.TaskType);
                listToArrayTask.ToArray();
            }
            // To get the Happiness Score
            var happinessScoreEF = from b in myDB.DaxInputData
                                   where b.UserID == SessionData.SessionProp
                                   select b;

            foreach (var item in happinessScoreEF)
            {
                listToArrayHappiness.Add(item.HappinessScore.ToString());
                listToArrayHappiness.ToArray();
            }
            //Create bar chart
            var chart = new Chart(width: 300, height: 200)
            .AddSeries(chartType: "bar",
                            xValue: listToArrayTask,
                            yValues: listToArrayHappiness)
                            .GetBytes("png");

            return File(chart, "image/bytes");
        }
        [HttpGet]
        public ActionResult ReturnInput()
        {
            var InputData = from a in myDB.DaxInputData
                            where a.UserID == SessionData.SessionProp
                            select a;
            return View();
        }
     
    }
}
