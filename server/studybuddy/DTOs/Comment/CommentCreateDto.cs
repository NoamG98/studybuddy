using System;

namespace StudyBuddy.DTOs.Comment
{
    public class CommentCreateDto
    {
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
