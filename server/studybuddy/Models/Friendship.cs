using System;

namespace StudyBuddy.Models
{
    public class Friendship
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public required User User { get; set; }
        public Guid FriendId { get; set; }
        public required User Friend { get; set; }
    }
}