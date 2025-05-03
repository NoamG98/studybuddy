namespace StudyBuddy.DTOs.Leaderboard
{
    public class LeaderboardEntryResponse
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public int Points { get; set; }
    }
}
