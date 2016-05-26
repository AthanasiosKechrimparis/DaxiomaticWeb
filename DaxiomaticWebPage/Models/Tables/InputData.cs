using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DaxiomaticWebPage.Models.Tables
{
    public class InputData
    {
        [Key]
        public int ID { get; set; }
        public int HappinessScore { get; set; }
        public DateTime DateAndTime { get; set; }

        public InputData(int HappinessScore, DateTime DateAndTime)
        {
            this.HappinessScore = HappinessScore;
            this.DateAndTime = DateAndTime;
        }

    }
}