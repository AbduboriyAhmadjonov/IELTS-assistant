using System;

namespace IELTS_assistant.Models
{
    public class Tests
    {
        public int TestId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public Enum Type { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
