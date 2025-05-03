using StudyBuddy.DTOs.FriendRequest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyBuddy.Services
{
    public interface IFriendRequestService
    {
        Task<FriendRequestResponseDto> SendRequestAsync(FriendRequestCreateDto dto);
        Task<IEnumerable<FriendRequestResponseDto>> GetSentRequestsAsync(Guid userId);
        Task<IEnumerable<FriendRequestResponseDto>> GetReceivedRequestsAsync(Guid userId);
        Task<bool> AcceptRequestAsync(Guid requestId);
        Task<bool> RejectRequestAsync(Guid requestId);
        Task<IEnumerable<FriendRequestResponseDto>> GetFriendsAsync(Guid userId);
    }
}