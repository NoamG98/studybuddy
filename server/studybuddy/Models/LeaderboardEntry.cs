using StudyBuddy.Models;

public class LeaderboardEntry
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId { get; set; }
    public required User User { get; set; }
    public int Points { get; set; }
    public DateTime DateAchieved { get; set; } = DateTime.UtcNow;
}
