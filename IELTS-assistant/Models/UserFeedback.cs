using System;

namespace IELTS_assistant.Models
{
    public class UserFeedback
    {
        public int FeedbackId { get; set; }
        public int UserId { get; set; }
        public string Feedback { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
