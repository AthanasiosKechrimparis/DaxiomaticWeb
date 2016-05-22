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

namespace DaxiomaticWeb.Controllers
{
    public class UserStatisticsController : Controller
    {
        // GET: Statistics
        public ActionResult StatiaticsUserIndex()
        {
            return View();
        }

        public ActionResult StatisticsDates()
        {
            return View();
        }
        EntityFrameWork.villadsenwp_dk_dbEntities myDB = new villadsenwp_dk_dbEntities();
        
        List<string> listOfString = new List<string>();
        List<string> lidt = new List<string>();

        List<int> listOFiNT = new List<int>();
        List<string> listto = new List<string>();
        int e = Session["ID"].ToString();


       [HttpGet]
        public ActionResult CompanyBarChart()
        {
            var Level = from b in myDB.DaxCompanyData
                   where b.ID == e
                        select b;

            foreach (var item in Level)
            {

                listOfString.Add(item.Name);
            }


            foreach (var item in listOFiNT)
            {
                listto.Add(item.ToString());
                listto.ToArray();
            }

            //Create bar chart
            var chart = new Chart(width: 300, height: 200)
            .AddSeries(chartType: "bar",
                            xValue: listto,
                            yValues: new[] {"500", "300 ", "700" })
                            .GetBytes("png");

            return File(chart, "image/bytes");
        }
        //Create bar chart
        //var chart = new Chart(width: 300, height: 200)
        //    .AddSeries(chartType: "bar",
        //                    xValue: listto,
        //                    yValues: new[] { ty, "500", "300 ", "700" })
        //                    .GetBytes("png");

        //    return File(chart, "image/bytes");
        }

        //public ActionResult CreatePie()
        //{
        //    //Create bar chart
        //    var chart = new Chart(width: 300, height: 200)
        //    .AddSeries(chartType: "pie",
        //                    xValue: new[] { date1, "50", "30 ", "70" },
        //                    yValues: new[] { "50", "70", "90", "110" })
        //                    .GetBytes("png");
        //    return File(chart, "image/bytes");
        //}

        //public ActionResult CreateLine()
        //{
        //    var Level = from b in _dateEF.Happiness
        //                select b;

        //    foreach (var item in Level)
        //    {

        //        listOFiNT.Add(item.HappinessLevel);
        //    }


        //    foreach (var item in listOFiNT)
        //    {
        //        listto.Add(item.ToString());
        //        listto.ToArray();
        //    }
        //    var Datesd = from n in _dateEF.ChartDates
        //                 select n;



        //    foreach (var item in Datesd)
        //    {

        //        listOfString.Add(item.Dates.ToShortDateString());
        //    }


        //    foreach (string item in listOfString)
        //    {
        //        lidt.Add(item);
        //        lidt.ToArray();
        //    }
        //    //Create bar chart
        //    var chart = new Chart(width: 600, height: 200)
        //    .AddSeries(chartType: "line",
        //                    xValue: lidt,
        //                    yValues: listto)
        //                    .GetBytes("png");
        //    return File(chart, "image/bytes");
        //}

        //public ActionResult Index()
        //{
        //    return View("Index");
        //}
    }
