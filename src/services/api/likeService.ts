// src/services/api/likeService.ts
import api from '../api';

export const likeService = {
  likePost: (postId: string) =>
    api.post(`/api/Posts/${postId}/like`, {}), 
  unlikePost: (postId: string) =>
    api.delete(`/api/Posts/${postId}/like`),
  getUserLikes: (userId: string) =>
    api.get<string[]>(`/api/Users/${userId}/likes`),
};

export default likeService;
