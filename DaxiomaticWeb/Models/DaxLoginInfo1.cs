using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DaxiomaticWeb.Models
{
    public class DaxLoginInfo1
    {
        public int ID { get; set; }
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        public Nullable<int> UserLevel { get; set; }
    }
}