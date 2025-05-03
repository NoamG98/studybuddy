using StudyBuddy.DTOs.Chat;
using StudyBuddy.Models;
using StudyBuddy.Repositories;

namespace StudyBuddy.Services
{
    public class ChatService : IChatService
    {
        private readonly IChatRepository _chatRepository;

        public ChatService(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        public async Task<ServiceResponse<ChatMessageResponse>> SendMessageAsync(SendMessageRequest request, Guid senderId)
        {
            var message = new ChatMessage
            {
                Id = Guid.NewGuid(),
                SenderId = senderId,
                ReceiverId = request.ReceiverId,
                Content = request.Content,
                SentAt = DateTime.UtcNow
            };

            await _chatRepository.AddAsync(message);
            await _chatRepository.SaveChangesAsync();

            return new ServiceResponse<ChatMessageResponse>
            {
                Data = new ChatMessageResponse
                {
                    Id = message.Id,
                    SenderId = message.SenderId,
                    ReceiverId = message.ReceiverId,
                    Content = message.Content,
                    SentAt = message.SentAt
                }
            };
        }

        public async Task<ServiceResponse<List<ChatMessageResponse>>> GetConversationAsync(Guid userId1, Guid userId2)
        {
   
            var messages = await _chatRepository.GetConversationAsync(userId1, userId2);

        
            var messageResponses = messages.Select(message => new ChatMessageResponse
            {
                Id = message.Id,
                SenderId = message.SenderId,
                ReceiverId = message.ReceiverId,
                Content = message.Content,
                SentAt = message.SentAt
            }).ToList();

            return new ServiceResponse<List<ChatMessageResponse>>
            {
                Data = messageResponses
            };
        }
    }
}