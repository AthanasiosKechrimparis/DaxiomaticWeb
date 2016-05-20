using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DaxiomaticWeb.Models
{
    public class UserAccount
    {
        [Required(ErrorMessage = "UserName is required!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "PassWord is required!")]
        [StringLength(20, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
    }
}