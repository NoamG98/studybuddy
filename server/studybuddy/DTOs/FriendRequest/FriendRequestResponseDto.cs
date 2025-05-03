namespace StudyBuddy.DTOs.FriendRequest
{
    public class FriendRequestResponseDto
    {
        public Guid Id { get; set; }
        public Guid FromUserId { get; set; }
        public Guid ToUserId { get; set; }
        public string Status { get; set; } = string.Empty; 
        public DateTime CreatedAt { get; set; }
    }
}
