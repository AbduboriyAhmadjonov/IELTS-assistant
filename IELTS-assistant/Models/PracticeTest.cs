using System.Collections.Generic;
using System;

namespace IELTS_assistant.Models
{
    public class PracticeTest
    {
        public int TestID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<TestResult> TestResults { get; set; }
        public ICollection<UserTest> UserTests { get; set; }
    }
}