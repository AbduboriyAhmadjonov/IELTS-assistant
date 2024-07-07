using System;
using System.ComponentModel.DataAnnotations;

namespace IELTS_assistant.Models
{
    public class StudyMaterial
    {
        public int MaterialId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Content { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
    }
}
