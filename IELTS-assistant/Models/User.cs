using System;
using System.Collections.Generic;

namespace IELTS_assistant.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string HashPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset UpdatedAt { get; set; }
        public ICollection<TestResult> TestResults { get; set; }
        public ICollection<ProgressTracking> ProgressTracking { get; set; }
        public ICollection<StudyMaterial> Materials { get; set; }
        public ICollection<Tests> Tests { get; set; }
    }
}
