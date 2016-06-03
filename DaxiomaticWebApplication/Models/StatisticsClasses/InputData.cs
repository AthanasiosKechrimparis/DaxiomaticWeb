using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DaxiomaticWebApplication.Models.StatisticsClasses
{
    public class InputData
    {

        [Key]
        public int ID { get; set; }
        public int HappinessScore { get; set; }
        public DateTime DateAndTime { get; set; }
        public EmailData emailData { get; set; }
        public MeetingData meetingData { get; set; }
        /*List<PhoneData> phoneData { get; set; }
        List<TaskData> taskData { get; set; }*/

        public InputData(int HappinessScore)
        {
            this.HappinessScore = HappinessScore;
        }

        public InputData(DateTime DateAndTime)
        {
            this.DateAndTime = DateAndTime;
        }

        public InputData(int HappinessScore, DateTime DateAndTime, EmailData emailData, MeetingData meetingData
                        /*List<PhoneData> phoneData, List<TaskData> taskData*/)
        {
            this.HappinessScore = HappinessScore;
            this.DateAndTime = DateAndTime;
            this.emailData = emailData;
            this.meetingData = meetingData;
            /*this.phoneData = phoneData;
            this.taskData = taskData;*/
        }

    }
}