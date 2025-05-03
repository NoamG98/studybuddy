using StudyBuddy.Models;

namespace StudyBuddy.Repositories
{
    public interface IChatRepository
    {
        Task AddAsync(ChatMessage message);
        Task SaveChangesAsync();
        Task<List<ChatMessage>> GetConversationAsync(Guid userId1, Guid userId2);
    }
}
