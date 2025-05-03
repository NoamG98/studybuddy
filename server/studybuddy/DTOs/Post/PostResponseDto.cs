using StudyBuddy.DTOs.Comment;

namespace StudyBuddy.DTOs.Post
{
    public class PostResponseDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        public string AuthorName { get; set; } = string.Empty;
        public string? AuthorAvatarUrl { get; set; }

        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        public int LikesCount { get; set; }
        public bool IsLiked { get; set; }

        public string? ImageUrl { get; set; } 

        public List<CommentResponseDto> Comments { get; set; } = new();
    }
}
