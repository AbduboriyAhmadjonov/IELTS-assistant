using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IELTS_assistant.Models
{
    public class TestQuestions
    {
        public int QuestionId { get; set; }
        public Tests TestId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
