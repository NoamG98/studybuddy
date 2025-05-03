using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StudyBuddy.DTOs.Chat;

namespace StudyBuddy.Services
{
    public interface IChatService
    {
        Task<ServiceResponse<ChatMessageResponse>> SendMessageAsync(SendMessageRequest request, Guid senderId);

   
        Task<ServiceResponse<List<ChatMessageResponse>>> GetConversationAsync(Guid userId1, Guid userId2);
    }
}
