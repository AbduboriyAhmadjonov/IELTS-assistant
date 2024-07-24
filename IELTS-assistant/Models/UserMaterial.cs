using System;

namespace IELTS_assistant.Models
{
    public class UserMaterial
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int MaterialID { get; set; }
        public StudyMaterial StudyMaterial { get; set; }
    }
}
