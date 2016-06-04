using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DaxiomaticWebApplication.Controllers.User
{
    public class UserImpactsController : Controller
    {
        private const string Connection = @"Data Source=villadsenwp_dk_db;Initial Catalog=villadsenwp_dk_db;Integrated Security=SSPI";
        // GET: UserImpacts
        //public ActionResult Index()
        //{
        //    SqlConnection Conn = new SqlConnection(Connection);
        //    listOfRealEstate = new List<Classes.RealEstate>();
        //    try
        //    {
        //        Conn.Open();
        //        SqlCommand cmd = new SqlCommand("ReturnRealEstate1", Conn);

        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        while (rdr.HasRows && rdr.Read())
        //        {
        //            Classes.RealEstate real = new Classes.RealEstate(rdr["Regional"].ToString(),
        //                                                 rdr["Municipality"].ToString(),
        //                                                 rdr["Place"].ToString(),
        //                                                 int.Parse(rdr["PostCode"].ToString()),
        //                                                 rdr["RealAddress"].ToString(),
        //                                                 int.Parse(rdr["Number"].ToString()),
        //                                                 rdr["O_T"].ToString(),
        //                                                 rdr["PropertyKind"].ToString(),
        //                                                 int.Parse(rdr["NumberBuildingRegistration"].ToString()),
        //                                                 DateTime.Parse(rdr["DateOfConstruction"].ToString()),
        //                                                 DateTime.Parse(rdr["DateOfRegistration"].ToString()),
        //                                                 double.Parse(rdr["PriceZone"].ToString()),
        //                                                 rdr["PlanningService"].ToString(),
        //                                                 rdr["KindOFArbitrariness"].ToString());

        //            listOfRealEstate.Add(real);
        //        }
        //    }
        //    catch (SqlException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        Conn.Close();
        //        Conn.Dispose();
        //    }

        //    return View(listOfRealEstate);
        //}
    }
}