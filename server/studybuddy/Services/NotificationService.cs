using Microsoft.AspNetCore.SignalR;
using StudyBuddy.Data;
using StudyBuddy.Hubs;
using StudyBuddy.Models;
using System;
using System.Threading.Tasks;

namespace StudyBuddy.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IHubContext<NotificationHub> _hubContext;
        private readonly ApplicationDbContext _context;

        public NotificationService(IHubContext<NotificationHub> hubContext, ApplicationDbContext context)
        {
            _hubContext = hubContext;
            _context = context;
        }

        public async Task SendNotificationAsync(Guid userId, string content, string type, string? actionUrl = null)
        {
            var notification = new Notification
            {
                UserId = userId,
                Content = content,
                Type = type,
                ActionUrl = actionUrl ?? string.Empty, 
                CreatedAt = DateTime.UtcNow,
                IsRead = false
            };

            _context.Notifications.Add(notification);
            await _context.SaveChangesAsync();

            await _hubContext.Clients.Group(userId.ToString())
                .SendAsync("ReceiveNotification", new
                {
                    id = notification.Id,
                    content = notification.Content,
                    type = notification.Type,
                    actionUrl = notification.ActionUrl,
                    createdAt = notification.CreatedAt,
                    isRead = notification.IsRead
                });
        }
    }
}
