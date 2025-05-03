using StudyBuddy.DTOs.Post;
using StudyBuddy.DTOs.Comment;
using StudyBuddy.Models;
using StudyBuddy.Repositories;
using Microsoft.AspNetCore.SignalR;
using StudyBuddy.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyBuddy.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _repo;
        private readonly ILikeService _likeService;
        private readonly ICommentRepository _commentRepo;
        private readonly IHubContext<NotificationHub> _hubContext;

        public PostService(
            IPostRepository repo,
            ILikeService likeService,
            ICommentRepository commentRepo,
            IHubContext<NotificationHub> hubContext)
        {
            _repo = repo;
            _likeService = likeService;
            _commentRepo = commentRepo;
            _hubContext = hubContext;
        }

        public async Task<List<PostResponseDto>> GetAllAsync(Guid? currentUserId)
        {
            var posts = await _repo.GetAllWithIncludesAsync();

            return posts
                .OrderByDescending(p => p.CreatedAt)
                .Select(p => new PostResponseDto
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    AuthorName = p.User.FirstName + " " + p.User.LastName,
                    AuthorAvatarUrl = p.User.AvatarUrl,
                    Content = p.Content,
                    ImageUrl = p.ImageUrl,
                    CreatedAt = p.CreatedAt,
                    LikesCount = p.Likes.Count,
                    IsLiked = currentUserId.HasValue && p.Likes.Any(l => l.UserId == currentUserId.Value),
                    Comments = p.Comments
                        .OrderBy(c => c.CreatedAt)
                        .Select(c => new CommentResponseDto
                        {
                            Id = c.Id,
                            PostId = c.PostId,
                            UserId = c.UserId,
                            AuthorName = c.User.FirstName + " " + c.User.LastName,
                            AuthorAvatarUrl = c.User.AvatarUrl,
                            Content = c.Content,
                            CreatedAt = c.CreatedAt
                        })
                        .ToList()
                }).ToList();
        }

        public async Task<PostResponseDto?> GetByIdAsync(Guid id, Guid? currentUserId)
        {
            var p = await _repo.GetByIdWithIncludesAsync(id);
            if (p == null) return null;

            return new PostResponseDto
            {
                Id = p.Id,
                UserId = p.UserId,
                AuthorName = p.User.FirstName + " " + p.User.LastName,
                AuthorAvatarUrl = p.User.AvatarUrl,
                Content = p.Content,
                ImageUrl = p.ImageUrl,
                CreatedAt = p.CreatedAt,
                LikesCount = p.Likes.Count,
                IsLiked = currentUserId.HasValue && p.Likes.Any(l => l.UserId == currentUserId.Value),
                Comments = p.Comments
                    .OrderBy(c => c.CreatedAt)
                    .Select(c => new CommentResponseDto
                    {
                        Id = c.Id,
                        PostId = c.PostId,
                        UserId = c.UserId,
                        AuthorName = c.User.FirstName + " " + c.User.LastName,
                        AuthorAvatarUrl = c.User.AvatarUrl,
                        Content = c.Content,
                        CreatedAt = c.CreatedAt
                    })
                    .ToList()
            };
        }

        public async Task<PostResponseDto> CreateAsync(PostCreateDto dto)
        {
            var post = new Post
            {
                Content = dto.Content,
                UserId = dto.UserId,
                ImageUrl = dto.ImageUrl,
                CreatedAt = DateTime.UtcNow,
                User = default!
            };

            await _repo.AddAsync(post);
            await _repo.SaveChangesAsync();

            var postDto = new PostResponseDto
            {
                Id = post.Id,
                UserId = post.UserId,
                AuthorName = post.User?.FirstName + " " + post.User?.LastName,
                AuthorAvatarUrl = post.User?.AvatarUrl,
                Content = post.Content,
                ImageUrl = post.ImageUrl,
                CreatedAt = post.CreatedAt,
                LikesCount = 0,
                IsLiked = false,
                Comments = new List<CommentResponseDto>()
            };

            await _hubContext.Clients.All.SendAsync("PostCreated", postDto);

            return postDto;
        }

        public async Task<PostResponseDto?> UpdateAsync(Guid id, PostUpdateDto dto)
        {
            var existing = await _repo.GetByIdWithIncludesAsync(id);
            if (existing == null) return null;

            existing.Content = dto.Content;
            existing.ImageUrl = dto.ImageUrl;
            await _repo.UpdateAsync(existing);
            await _repo.SaveChangesAsync();

            return new PostResponseDto
            {
                Id = existing.Id,
                UserId = existing.UserId,
                AuthorName = existing.User.FirstName + " " + existing.User.LastName,
                AuthorAvatarUrl = existing.User.AvatarUrl,
                Content = existing.Content,
                ImageUrl = existing.ImageUrl,
                CreatedAt = existing.CreatedAt,
                LikesCount = await _likeService.GetLikeCountAsync(existing.Id),
                IsLiked = false,
                Comments = new List<CommentResponseDto>()
            };
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var existing = await _repo.GetByIdAsync(id);
            if (existing == null) return false;

            await _repo.DeleteAsync(existing);
            await _repo.SaveChangesAsync();
            return true;
        }

        public Task<bool> AddLikeAsync(Guid userId, Guid postId)
            => _likeService.AddLikeAsync(userId, postId);

        public Task RemoveLikeAsync(Guid userId, Guid postId)
            => _likeService.RemoveLikeAsync(userId, postId);

        public async Task<CommentResponseDto> AddCommentAsync(CommentCreateDto dto)
        {
            var comment = new Comment
            {
                Id = Guid.NewGuid(),
                PostId = dto.PostId,
                UserId = dto.UserId,
                Content = dto.Content,
                CreatedAt = DateTime.UtcNow,
                Post = default!,
                User = default!
            };

            await _commentRepo.AddAsync(comment);
            await _commentRepo.SaveChangesAsync();

            var commentDto = new CommentResponseDto
            {
                Id = comment.Id,
                PostId = comment.PostId,
                UserId = comment.UserId,
                AuthorName = comment.User?.FirstName + " " + comment.User?.LastName,
                AuthorAvatarUrl = comment.User?.AvatarUrl,
                Content = comment.Content,
                CreatedAt = comment.CreatedAt
            };

            await _hubContext.Clients.All.SendAsync("CommentAdded", commentDto);

            return commentDto;
        }

        public async Task<List<CommentResponseDto>> GetCommentsAsync(Guid postId)
        {
            var list = await _commentRepo.GetByPostIdAsync(postId);
            return list
                .OrderBy(c => c.CreatedAt)
                .Select(c => new CommentResponseDto
                {
                    Id = c.Id,
                    PostId = c.PostId,
                    UserId = c.UserId,
                    AuthorName = c.User.FirstName + " " + c.User.LastName,
                    AuthorAvatarUrl = c.User.AvatarUrl,
                    Content = c.Content,
                    CreatedAt = c.CreatedAt
                })
                .ToList();
        }
    }
}
