﻿using System;

namespace IELTS_assistant.Models
{
    public class TestResult
    {
        public int ResultId { get; set; }
        public User UserId { get; set; }
        public User User { get; set; }
        public int TestID { get; set; }
        public Tests Test { get; set; }
        public decimal Score { get; set; }
        public DateTimeOffset DateTaken { get; set;}
    }
}
