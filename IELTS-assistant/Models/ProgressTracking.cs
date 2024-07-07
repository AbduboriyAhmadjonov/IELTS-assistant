using System;
using System.ComponentModel.DataAnnotations;

namespace IELTS_assistant.Models
{
    public class ProgressTracking
    {
        public int ProgressID { get; set; }
        public Guid UserID { get; set; }
        public User User { get; set; }
        public string Section { get; set; }
        public decimal Progress { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
