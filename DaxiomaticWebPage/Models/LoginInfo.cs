using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DaxiomaticWebPage.Models
{
    public class LoginInfo
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        //public int UserLevel { get; set; }
    }
}