namespace StudyBuddy.DTOs.Post
{
    public class PostCreateDto
    {
        public Guid UserId { get; set; }
        public string Content { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
    }
}