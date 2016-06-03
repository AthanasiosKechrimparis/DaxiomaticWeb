using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DaxiomaticWebPage.EntityFrameWork;
using DaxiomaticWebPage.Models;
using System.Web.Helpers;

namespace DaxiomaticWebPage.Controllers.Admin
{
    public class AdminStatisticsController : Controller
    {
        EntityFrameWork.villadsenwp_dk_dbEntities myDB = new villadsenwp_dk_dbEntities();
        int ID1;
        // GET: AdminStatistics
        [HttpGet]
        public ActionResult AdminIndex()
        {
            

            var returnUsers = from users in myDB.DaxLoginInfo
                              select users;

            foreach (var item in returnUsers)
            {
                listOfSelect.Add(new SelectListItem() { Value = item.Username, Text = item.ID.ToString() });
            }

            ViewBag.DropDownValues = new SelectList(listOfSelect, "Text", "Value");

            //foreach (var item in ViewBag.DropDownValues)
            //{
            //    TempData["ID"] = item.Text;
            //}
            
           
            return View();
        }



        List<SelectListItem> listOfSelect = new List<SelectListItem>();
        List<Models.Tables.CompanyData> listOfCompanyData = new List<Models.Tables.CompanyData>();
        List<Models.Tables.InputData> listOfInputData = new List<Models.Tables.InputData>();
        List<Models.Tables.TaskDetail> listOfTaskDetails = new List<Models.Tables.TaskDetail>();
        List<string> listToArrayCompanies = new List<string>();
        List<string> listToArrayHappiness = new List<string>();
        List<string> listToArrayTask = new List<string>();
        List<string> listOfTime = new List<string>();
        List<string> listOfDay = new List<string>();



        // Getting the Favorite Company
        [HttpGet]
        public ActionResult CompanyBarChart()
        {

            //string DDID = form["DropDownList"].ToString();
            //loginID.ID = int.Parse(DDID.ToString());
            
            foreach (var item in ViewBag.DropDownValues)
            {
               ID1 = int.Parse(item.Text.ToString());

            }
            //loginID.ID = int.Parse(TempData["ID"].ToString());
                // To get the Favorite companies
                var favoriteCompany = from b in myDB.DaxCompanyData
                                      where b.InputID == ID1
                                      select b.Name;

                foreach (var item in favoriteCompany)
                {
                    listOfCompanyData.Add(new Models.Tables.CompanyData(item));
                }
                foreach (var name in listOfCompanyData)
                {
                    listToArrayCompanies.Add(name.Name);
                    listToArrayCompanies.ToArray();
                }
                // To get the Happiness Score
                var happinessScoreEF = from b in myDB.DaxInputData
                                       where b.UserID == SessionData.SessionProp
                                       select b.HappinessScore;

                foreach (var item in happinessScoreEF)
                {
                    listOfInputData.Add(new Models.Tables.InputData(int.Parse(item.ToString())));
                }

                foreach (var happiness in listOfInputData)
                {
                    listToArrayHappiness.Add(happiness.HappinessScore.ToString());
                    listToArrayHappiness.ToArray();
                }
                //Create bar chart
                var chart = new Chart(width: 300, height: 200)
                    .AddTitle("Companies")
                .AddSeries(chartType: "Bar",
                                xValue: listToArrayCompanies,
                                yValues: listToArrayHappiness)
                                .GetBytes("png");

                
      
            return File(chart, "image/bytes");
        }

        //Favorite Task
        [HttpPost]
        public ActionResult TaskBarChart()
        {
            // To get the Type of Tasks
            var favoriteTask = from b in myDB.DaxTaskData
                               where b.InputID == SessionData.SessionProp
                               select b.DaxTaskDetail.TaskType;

            foreach (var item in favoriteTask)
            {
                listOfTaskDetails.Add(new Models.Tables.TaskDetail(item));
            }

            foreach (var tasktype in listOfTaskDetails)
            {
                listToArrayTask.Add(tasktype.TaskType);
                listToArrayTask.ToArray();
            }

            // To get the Happiness Score
            var happinessScoreEF = from b in myDB.DaxInputData
                                   where b.UserID == SessionData.SessionProp
                                   select b.HappinessScore;

            foreach (var item in happinessScoreEF)
            {
                listOfInputData.Add(new Models.Tables.InputData(int.Parse(item.ToString())));
            }

            foreach (var happiness in listOfInputData)
            {
                listToArrayHappiness.Add(happiness.HappinessScore.ToString());
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

        [HttpPost]
        public ActionResult TimeOfDayLineChart()
        {
            DateTime dateToTime;
            var timeData = (from b in myDB.DaxInputData
                            where b.UserID == SessionData.SessionProp
                            orderby b.DateAndTime descending
                            select b.DateAndTime).Distinct();

            foreach (var item in timeData)
            {
                listOfInputData.Add(new Models.Tables.InputData(DateTime.Parse(item.ToString())));
            }
            foreach (var item in listOfInputData)
            {
                dateToTime = DateTime.Parse(item.DateAndTime.ToString());
                listOfTime.Add(dateToTime.ToShortTimeString() + "\n" + dateToTime.ToShortDateString());
                listOfTime.ToArray();
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
            //Create LineChart
            var chart = new Chart(width: 600, height: 200)
            .AddSeries(chartType: "line",
                            xValue: listOfTime,
                            yValues: listToArrayHappiness)
                            .GetBytes("png");
            return File(chart, "image/bytes");
        }
        [HttpPost]
        public ActionResult DayToLineChart()
        {
            DateTime dateToTime;
            var timeData = (from b in myDB.DaxInputData
                            where b.UserID == SessionData.SessionProp
                            orderby b.DateAndTime descending
                            select b.DateAndTime).Distinct();

            foreach (var item in timeData)
            {
                listOfInputData.Add(new Models.Tables.InputData(DateTime.Parse(item.ToString())));
            }

            foreach (var item in listOfInputData)
            {
                dateToTime = DateTime.Parse(item.DateAndTime.ToString());
                listOfDay.Add(dateToTime.ToShortDateString() + "\n" + dateToTime.ToString(("dddd")));
                listOfDay.ToArray();
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
            //Create LineChart
            var chart = new Chart(width: 600, height: 200)
            .AddSeries(chartType: "line",
                            xValue: listOfDay,
                            yValues: listToArrayHappiness)
                            .GetBytes("png");
            return File(chart, "image/bytes");
        }
    }
}