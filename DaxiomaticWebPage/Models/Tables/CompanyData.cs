using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DaxiomaticWebPage.Models.Tables
{
    public class CompanyData
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int InputID { get; set; }

        public CompanyData(string Name)
        {
            this.Name = Name;
        }
    }
}