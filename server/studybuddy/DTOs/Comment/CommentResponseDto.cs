namespace StudyBuddy.DTOs.Comment
{
    public class CommentResponseDto
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }

        public string AuthorName { get; set; } = string.Empty;
        public string? AuthorAvatarUrl { get; set; }

        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
