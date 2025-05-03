namespace StudyBuddy.DTOs.Auth
{
    public class RegisterRequest
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }

        public required string Role { get; set; } // Student / Graduate / Employer
        public required string Country { get; set; }
        public required string City { get; set; }

        public required string Gender { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public string? AvatarUrl { get; set; }
        public string? StudyField { get; set; } // Optional for Employer
    }
}
