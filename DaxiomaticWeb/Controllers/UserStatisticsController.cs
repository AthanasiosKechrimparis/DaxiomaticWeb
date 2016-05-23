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
        Models.SessionData session = new Models.SessionData();
        List<string> listOfCompanies = new List<string>();
        List<string> listOfWeight = new List<string>();
        List<string> listToArrayCompanies = new List<string>();
        List<string> listToArrayWeight = new List<string>();

        int SessionData;

        // Getting the Favorite Company
        [HttpGet]
        public ActionResult CompanyBarChart()
        {
            SessionData = session.SessionProp;
            // To get the Favorite companies
            var favoriteCompany = from b in myDB.DaxCompanyData
                                  where b.ID == SessionData
                                  select b;

            foreach (var item in favoriteCompany)
            {
                listOfCompanies.Add(item.Name);
                listToArrayCompanies.ToArray();
            }
            // To get the Happiness Score
            var happinessScoreEF = from b in myDB.DaxInputData
                                   where b.ID == SessionData
                                   select b;

            foreach (var item in happinessScoreEF)
            {
                listOfWeight.Add(item.HappinessScore.ToString());
                listToArrayWeight.ToArray();
            }
            //Create bar chart
            var chart = new Chart(width: 300, height: 200)
            .AddSeries(chartType: "bar",
                            xValue: listToArrayCompanies,
                            yValues: listToArrayWeight)
                            .GetBytes("png");

            return File(chart, "image/bytes");
        }

        // Getting the Favorite Tasks
        [HttpGet]
        public ActionResult TaskBarChart()
        {
            SessionData = session.SessionProp;
            // To get the Type of Tasks
            var favoriteCompany = from b in myDB.DaxTaskData
                                  where b.InputID == SessionData
                                  select b;

            foreach (var item in favoriteCompany)
            {
                listOfCompanies.Add(item.DaxTaskDetail.TaskType);
                listToArrayCompanies.ToArray();
            }
            // To get the Happiness Score
            var happinessScoreEF = from b in myDB.DaxInputData
                                   where b.ID == SessionData
                                   select b;

            foreach (var item in happinessScoreEF)
            {
                listOfWeight.Add(item.HappinessScore.ToString());
                listToArrayWeight.ToArray();
            }
            //Create bar chart
            var chart = new Chart(width: 300, height: 200)
            .AddSeries(chartType: "bar",
                            xValue: listToArrayCompanies,
                            yValues: listToArrayWeight)
                            .GetBytes("png");

            return File(chart, "image/bytes");
        }
    }
}
