using System;

namespace IELTS_assistant.Models
{
    public class Tests
    {
        public int TestsId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Type { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
