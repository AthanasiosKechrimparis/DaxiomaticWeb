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
        public EmailData emailData { get; set; }
        public MeetingData meetingData { get; set; }
        public PhoneData phoneData { get; set; }
        public TaskData taskData { get; set; }

        public InputData(int HappinessScore)
        {
            this.HappinessScore = HappinessScore;
        }

        public InputData(DateTime DateAndTime)
        {
            this.DateAndTime = DateAndTime;
        }

        public InputData(int HappinessScore, DateTime DateAndTime,EmailData emailData, MeetingData meetingData
                       /* PhoneData phoneData, TaskData taskData*/)
        {
            this.HappinessScore = HappinessScore;
            this.DateAndTime = DateAndTime;
            this.emailData = emailData;
            this.meetingData = meetingData;
           /* this.phoneData = phoneData;
            this.taskData = taskData;*/
        }
       
    }
}