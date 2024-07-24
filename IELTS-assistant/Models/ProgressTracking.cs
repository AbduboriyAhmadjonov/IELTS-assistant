using System;
using System.ComponentModel.DataAnnotations;

namespace IELTS_assistant.Models
{
    public class ProgressTracking
    {
        public int ProgressTrackingID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public string Section { get; set; }
        public decimal Progress { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
