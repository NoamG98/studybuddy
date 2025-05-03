import { useState, useEffect, useRef } from "react";
import { Button } from "@/components/ui/button";
import { Avatar, AvatarFallback, AvatarImage } from "@/components/ui/avatar";
import { Textarea } from "@/components/ui/textarea";
import { toast } from "sonner";
import { Card, CardContent, CardFooter } from "@/components/ui/card";
import postService from "@/services/api/postService";
import { Post, Comment } from "@/models/post";
import { User } from "@/models/user";
import PostCard from "@/components/home/PostCard";
import useAuth from "@/contexts/useAuth";

export const CreatePostForm = () => {
  const [content, setContent] = useState("");
  const [imageFile, setImageFile] = useState<File | null>(null);
  const [imagePreview, setImagePreview] = useState<string | null>(null);
  const [isSubmitting, setIsSubmitting] = useState(false);
  const fileInputRef = useRef<HTMLInputElement>(null);
  const { user } = useAuth();

  const handleImageChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const file = e.target.files?.[0];
    if (file) {
      setImageFile(file);
      setImagePreview(URL.createObjectURL(file));
    }
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    if (!content.trim() || !user) return;

    setIsSubmitting(true);
    try {
      const formData = new FormData();
      formData.append("content", content);
      formData.append("userId", user.id);
      if (imageFile) formData.append("image", imageFile);

      await postService.createPostWithImage(formData);
      toast.success("Post created successfully!");
      setContent("");
      setImageFile(null);
      setImagePreview(null);
    } catch (error) {
      toast.error("Failed to create post");
      console.error("Post creation error:", error);
    } finally {
      setIsSubmitting(false);
    }
  };

  return (
    <Card className="mb-6">
      <form onSubmit={handleSubmit} aria-label="Create post form">
        <CardContent className="pt-6">
          <div className="flex space-x-4">
            <Avatar>
              <AvatarImage src={user?.avatarUrl} />
              <AvatarFallback>{user?.firstName?.charAt(0) || "U"}</AvatarFallback>
            </Avatar>
            <div className="flex-1 space-y-3">
              <Textarea
                placeholder="Share your thoughts..."
                title="Post content"
                className="min-h-[120px] resize-none"
                value={content}
                onChange={(e) => setContent(e.target.value)}
              />
              <div className="flex items-center space-x-2">
                <Button
                  type="button"
                  variant="outline"
                  onClick={() => fileInputRef.current?.click()}
                >
                  ➕ Upload
                </Button>
                <input
                  type="file"
                  accept="image/*"
                  ref={fileInputRef}
                  onChange={handleImageChange}
                  className="hidden"
                  title="Upload image"
                />
              </div>
              {imagePreview && (
                <img
                  src={imagePreview}
                  alt="Selected preview"
                  className="max-h-48 rounded-md border"
                />
              )}
            </div>
          </div>
        </CardContent>
        <CardFooter className="flex justify-end border-t pt-4">
          <Button type="submit" disabled={!content.trim() || isSubmitting}>
            {isSubmitting ? "Posting..." : "Post"}
          </Button>
        </CardFooter>
      </form>
    </Card>
  );
};

export const Feed = () => {
  const [posts, setPosts] = useState<Post[]>([]);
  const [isLoading, setIsLoading] = useState(true);
  const [error, setError] = useState<Error | null>(null);

  useEffect(() => {
    const fetchPosts = async () => {
      try {
        setIsLoading(true);
        setError(null);
        const fetched = await postService.getPosts();
        setPosts(fetched.map(p => ({ ...p, comments: p.comments ?? [] })));
      } catch (err) {
        console.error("Failed to fetch posts:", err);
        setError(err instanceof Error ? err : new Error("Failed to load posts"));
      } finally {
        setIsLoading(false);
      }
    };

    fetchPosts();
  }, []);

  const handleCommentAdded = (postId: string, comment: Comment) => {
    setPosts(prev =>
      prev.map(post =>
        post.id === postId
          ? { ...post, comments: [...post.comments, comment] }
          : post
      )
    );
  };

  const handlePostLiked = (postId: string, liked: boolean) => {
    setPosts(prev =>
      prev.map(post =>
        post.id === postId
          ? {
              ...post,
              isLiked: liked,
              likesCount: liked ? post.likesCount + 1 : post.likesCount - 1,
            }
          : post
      )
    );
  };

  if (isLoading) {
    return (
      <div className="text-center py-8">
        <p className="text-muted-foreground">Loading posts...</p>
      </div>
    );
  }
  if (error) {
    return (
      <div className="text-center py-8">
        <p className="text-destructive">Error: {error.message}</p>
        <Button variant="outline" onClick={() => window.location.reload()}>
          Try Again
        </Button>
      </div>
    );
  }

  return (
    <div>
      <CreatePostForm />
      {posts.length > 0 ? (
        posts.map(post => (
          <PostCard
            key={post.id}
            post={post}
            onCommentAdded={handleCommentAdded}
            onPostLiked={handlePostLiked}
          />
        ))
      ) : (
        <div className="text-center py-8">
          <p className="text-muted-foreground">No posts yet.</p>
        </div>
      )}
    </div>
  );
};
