export interface Comment {
  id: string;
  postId: string;
  userId: string;
  authorName: string;
  authorAvatarUrl?: string;
  content: string;
  createdAt: string;
}

export interface Post {
  id: string;
  userId: string;
  authorName: string;
  authorAvatarUrl?: string;
  content: string;
  createdAt: string;
  likesCount: number;
  isLiked: boolean;
  comments: Comment[];
  imageUrl?: string; 
}
