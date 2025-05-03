import { Post, Comment } from "@/models/post";
import api from "../api";

export const postService = {
  getPosts: async (): Promise<Post[]> => {
    const { data } = await api.get<Post[]>("/api/Posts");
    return data;
  },

  getPostsByField: async (field: string): Promise<Post[]> => {
    const { data } = await api.get<Post[]>(`/api/Posts/field/${encodeURIComponent(field)}`);
    return data;
  },

  getPost: async (id: string): Promise<Post> => {
    const { data } = await api.get<Post>(`/api/Posts/${id}`);
    return data;
  },

  createPostWithImage: async (formData: FormData): Promise<Post> => {
    const { data } = await api.post<Post>("/api/Posts", formData, {
      headers: { "Content-Type": "multipart/form-data" },
    });
    return data;
  },

  updatePost: async (id: string, postData: Partial<Post> & { imageUrl?: string }): Promise<Post> => {
    const { data } = await api.put<Post>(`/api/Posts/${id}`, postData);
    return data;
  },

  deletePost: async (id: string): Promise<void> => {
    await api.delete(`/api/Posts/${id}`);
  },

  addComment: async (postId: string, content: string): Promise<Comment> => {
    const { data } = await api.post<Comment>(`/api/Posts/${postId}/comments`, { content });
    return data;
  },

  likePost: async (postId: string): Promise<void> => {
    await api.post(`/api/Posts/${postId}/like`);
  },

  unlikePost: async (postId: string): Promise<void> => {
    await api.delete(`/api/Posts/${postId}/like`);
  },
};

export default postService;
