using StudyBuddy.Models;

public class Like
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid PostId { get; set; }
    public required Post Post { get; set; }

    public Guid UserId { get; set; }
    public required User User { get; set; }
}
