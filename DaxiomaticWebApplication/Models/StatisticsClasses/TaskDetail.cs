using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DaxiomaticWebApplication.Models.StatisticsClasses
{
    public class TaskDetail
    {
        [Key]
        public int ID { get; set; }
        public string TaskType { get; set; }

        public TaskDetail(string TaskType)
        {
            this.TaskType = TaskType;
        }
    }
}