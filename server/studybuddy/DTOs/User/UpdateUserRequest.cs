using System;

namespace StudyBuddy.DTOs.User
{
    public class UpdateUserRequest
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        public required string Email { get; set; }
        public string? Password { get; set; }

        public required string Country { get; set; }
        public required string City { get; set; }

        public string? StudyField { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public string? AvatarUrl { get; set; }
    }
}
