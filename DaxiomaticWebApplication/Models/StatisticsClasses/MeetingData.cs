using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DaxiomaticWebApplication.Models.StatisticsClasses
{
    public class MeetingData
    {
        public int External { get; set; }
        public int LengthMinutes { get; set; }

        public MeetingData(int External, int LengthMinutes)
        {
            this.External = External;
            this.LengthMinutes = LengthMinutes;
        }
    }
}