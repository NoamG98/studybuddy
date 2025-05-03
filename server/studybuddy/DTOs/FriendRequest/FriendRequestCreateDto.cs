using System;

namespace StudyBuddy.DTOs.FriendRequest
{
    public class FriendRequestCreateDto
    {
        public Guid FromUserId { get; set; }
        public Guid ToUserId { get; set; }
    }
}
