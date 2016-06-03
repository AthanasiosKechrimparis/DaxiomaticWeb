using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DaxiomaticWebPage.Models.Tables
{
    public class EmailData
    {
        [Key]
        public int AmountSend { get; set; }
        public int AmountReceived { get; set; }

        //public EmailData()
        //{

        //}

        public EmailData(int AmountSend, int AmountReceived)
        {
            this.AmountSend = AmountSend;
            this.AmountReceived = AmountReceived;
        }
    }
}