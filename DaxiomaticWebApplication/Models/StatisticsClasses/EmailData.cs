using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DaxiomaticWebApplication.Models.StatisticsClasses
{
    public class EmailData
    {
        [Key]
        public int AmountSend { get; set; }
        public int AmountReceived { get; set; }

        public EmailData(int AmountSend, int AmountReceived)
        {
            this.AmountSend = AmountSend;
            this.AmountReceived = AmountReceived;
        }
    }
}