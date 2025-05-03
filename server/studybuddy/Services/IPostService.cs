using StudyBuddy.DTOs.Post;
using StudyBuddy.DTOs.Comment;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyBuddy.Services
{
    public interface IPostService
    {
        Task<List<PostResponseDto>> GetAllAsync(Guid? currentUserId);
        Task<PostResponseDto?> GetByIdAsync(Guid id, Guid? currentUserId);
        Task<PostResponseDto> CreateAsync(PostCreateDto dto);
        Task<PostResponseDto?> UpdateAsync(Guid id, PostUpdateDto dto);
        Task<bool> DeleteAsync(Guid id);

        Task<bool> AddLikeAsync(Guid userId, Guid postId);
        Task RemoveLikeAsync(Guid userId, Guid postId);

        Task<CommentResponseDto> AddCommentAsync(CommentCreateDto dto);
        Task<List<CommentResponseDto>> GetCommentsAsync(Guid postId);
    }
}
