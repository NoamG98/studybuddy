using StudyBuddy.DTOs.FriendRequest;
using StudyBuddy.Models;
using StudyBuddy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyBuddy.Services
{
    public class FriendRequestService : IFriendRequestService
    {
        private readonly IFriendRequestRepository _repo;

        public FriendRequestService(IFriendRequestRepository repo)
        {
            _repo = repo;
        }

        public async Task<FriendRequestResponseDto> SendRequestAsync(FriendRequestCreateDto dto)
        {
            var entity = new FriendRequest
            {
                Id = Guid.NewGuid(),
                FromUserId = dto.FromUserId,
                ToUserId = dto.ToUserId,
                Status = FriendRequestStatus.Pending,
                CreatedAt = DateTime.UtcNow
            };
            await _repo.AddAsync(entity);
            await _repo.SaveChangesAsync();

            return new FriendRequestResponseDto
            {
                Id = entity.Id,
                FromUserId = entity.FromUserId,
                ToUserId = entity.ToUserId,
                Status = entity.Status.ToString(),
                CreatedAt = entity.CreatedAt
            };
        }

        public async Task<IEnumerable<FriendRequestResponseDto>> GetSentRequestsAsync(Guid userId)
        {
            var list = await _repo.GetSentAsync(userId);
            return list.Select(e => new FriendRequestResponseDto
            {
                Id = e.Id,
                FromUserId = e.FromUserId,
                ToUserId = e.ToUserId,
                Status = e.Status.ToString(),
                CreatedAt = e.CreatedAt
            });
        }

        public async Task<IEnumerable<FriendRequestResponseDto>> GetReceivedRequestsAsync(Guid userId)
        {
            var list = await _repo.GetReceivedAsync(userId);
            return list.Select(e => new FriendRequestResponseDto
            {
                Id = e.Id,
                FromUserId = e.FromUserId,
                ToUserId = e.ToUserId,
                Status = e.Status.ToString(),
                CreatedAt = e.CreatedAt
            });
        }

        public async Task<bool> AcceptRequestAsync(Guid requestId)
        {
            var e = await _repo.GetByIdAsync(requestId);
            if (e == null || e.Status != FriendRequestStatus.Pending) return false;
            e.Status = FriendRequestStatus.Accepted;
            await _repo.UpdateAsync(e);
            await _repo.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RejectRequestAsync(Guid requestId)
        {
            var e = await _repo.GetByIdAsync(requestId);
            if (e == null || e.Status != FriendRequestStatus.Pending) return false;
            e.Status = FriendRequestStatus.Rejected;
            await _repo.UpdateAsync(e);
            await _repo.SaveChangesAsync();
            return true;
        }

        // NEW: Return all accepted friend requests where user is either sender or receiver
        public async Task<IEnumerable<FriendRequestResponseDto>> GetFriendsAsync(Guid userId)
        {
            var sent = await _repo.GetSentAsync(userId);
            var received = await _repo.GetReceivedAsync(userId);
            var friends = sent.Concat(received)
                .Where(e => e.Status == FriendRequestStatus.Accepted)
                .Select(e => new FriendRequestResponseDto
                {
                    Id = e.Id,
                    FromUserId = e.FromUserId,
                    ToUserId = e.ToUserId,
                    Status = e.Status.ToString(),
                    CreatedAt = e.CreatedAt
                });

            return friends;
        }
    }
}