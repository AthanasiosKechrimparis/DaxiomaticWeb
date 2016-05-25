using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DaxiomaticWeb.Models
{
    public class SessionData
    {
        public static int SessionProp
        {
            get
            {
                if (HttpContext.Current.Session["UserID"] == null)
                    return -1;
                else
                {
                    return (int)HttpContext.Current.Session["UserID"];
                }
            }
            set
            {
                HttpContext.Current.Session["UserID"] = value;
            }
        }
    }
}