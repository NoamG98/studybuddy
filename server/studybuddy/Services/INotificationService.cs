using System;
using System.Threading.Tasks;

namespace StudyBuddy.Services
{
    public interface INotificationService
    {
        Task SendNotificationAsync(Guid userId, string content, string type, string? actionUrl = null);
    }
}