using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyBuddy.Models
{
    public enum FriendRequestStatus
    {
        Pending,
        Accepted,
        Rejected
    }

    public class FriendRequest
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid FromUserId { get; set; }
        [ForeignKey(nameof(FromUserId))]
        public User FromUser { get; set; } = default!;

        [Required]
        public Guid ToUserId { get; set; }
        [ForeignKey(nameof(ToUserId))]
        public User ToUser { get; set; } = default!;

        [Required]
        public FriendRequestStatus Status { get; set; } = FriendRequestStatus.Pending;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
