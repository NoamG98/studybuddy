import { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import { toast } from "sonner";

import { Button } from "@/components/ui/button";
import { Card, CardContent, CardFooter } from "@/components/ui/card";
import { Avatar, AvatarFallback, AvatarImage } from "@/components/ui/avatar";
import { Textarea } from "@/components/ui/textarea";
import { Input } from "@/components/ui/input";

import userService from "@/services/api/userService";
import postService from "@/services/api/postService";

import { User } from "@/models/user";
import { Post, Comment } from "@/models/post";

import PostCard from "@/components/home/PostCard";
import useAuth from "@/contexts/useAuth";

export const CreatePostForm = () => {
  const [content, setContent] = useState("");
  const [imageUrl, setImageUrl] = useState("");
  const [isSubmitting, setIsSubmitting] = useState(false);
  const { user } = useAuth();

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    if (!content.trim() || !user) return;

    setIsSubmitting(true);
    try {
      const formData = new FormData();
      formData.append("content", content);
      formData.append("userId", user.id);
      if (imageUrl) formData.append("imageUrl", imageUrl);

      await postService.createPostWithImage(formData);
      toast.success("Post created successfully!");
      setContent("");
      setImageUrl("");
    } catch (error) {
      toast.error("Failed to create post");
      console.error("Post creation error:", error);
    } finally {
      setIsSubmitting(false);
    }
  };

  return (
    <Card className="mb-6">
      <form onSubmit={handleSubmit}>
        <CardContent className="pt-6">
          <div className="flex space-x-4">
            <Avatar>
              <AvatarImage src={user?.avatarUrl} />
              <AvatarFallback>
                {user?.firstName?.charAt(0) || "U"}
              </AvatarFallback>
            </Avatar>
            <div className="flex-1 space-y-3">
              <Textarea
                placeholder="Share your thoughts..."
                className="min-h-[120px] resize-none"
                value={content}
                onChange={(e) => setContent(e.target.value)}
              />
              <Input
                type="url"
                placeholder="Optional: Image URL"
                value={imageUrl}
                onChange={(e) => setImageUrl(e.target.value)}
              />
              {imageUrl && (
                <img
                  src={imageUrl}
                  alt="Preview"
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
        setPosts(fetched.map((p) => ({ ...p, comments: p.comments ?? [] })));
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
    setPosts((prev) =>
      prev.map((post) =>
        post.id === postId
          ? { ...post, comments: [...post.comments, comment] }
          : post
      )
    );
  };

  const handlePostLiked = (postId: string, liked: boolean) => {
    setPosts((prev) =>
      prev.map((post) =>
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
        posts.map((post) => (
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

// UserCard Component
export const UserCard = ({ user }: { user: User }) => {
  const [status, setStatus] = useState({
    isFriend: user.isFriend || false,
    hasSent: user.hasSentRequest || false,
    hasReceived: user.hasReceivedRequest || false,
  });

  const handleConnect = async () => {
    try {
      await userService.sendFriendRequest(user.id);
      setStatus((s) => ({ ...s, hasSent: true }));
      toast.success(
        `Friend request sent to ${user.firstName} ${user.lastName}`
      );
    } catch {
      toast.error("Failed to send friend request");
    }
  };

  const handleAccept = async () => {
    try {
      await userService.acceptFriendRequest("placeholder-id");
      setStatus({ isFriend: true, hasSent: false, hasReceived: false });
      toast.success(`You are now connected with ${user.firstName}`);
    } catch {
      toast.error("Failed to accept request");
    }
  };

  const handleDecline = async () => {
    try {
      await userService.rejectFriendRequest("placeholder-id");
      setStatus((s) => ({ ...s, hasReceived: false }));
      toast.info("Friend request declined");
    } catch {
      toast.error("Failed to decline request");
    }
  };

  const badgeClass = () => {
    switch (user.status) {
      case "student":
        return "bg-blue-100 text-blue-800";
      case "graduate":
        return "bg-emerald-100 text-emerald-800";
      case "employer":
        return "bg-amber-100 text-amber-800";
      default:
        return "bg-gray-100 text-gray-800";
    }
  };

  return (
    <Card className="overflow-hidden h-full">
      <CardContent className="p-6">
        <Avatar className="h-20 w-20 mb-3">
          <AvatarImage src={user.profileImage || user.avatarUrl} />
          <AvatarFallback className="text-lg">
            {user.firstName[0]}
            {user.lastName[0]}
          </AvatarFallback>
        </Avatar>
        <Link to={`/profile/${user.id}`} className="text-lg font-medium">
          {user.firstName} {user.lastName}
        </Link>
        {user.status && (
          <span
            className={`text-xs px-2 py-1 rounded-full mt-2 ${badgeClass()}`}
          >
            {user.status.charAt(0).toUpperCase() + user.status.slice(1)}
          </span>
        )}
      </CardContent>
      <CardFooter className="bg-secondary/50 p-4 flex justify-center">
        {status.isFriend ? (
          <Button variant="outline" disabled>
            Connected
          </Button>
        ) : status.hasSent ? (
          <Button variant="outline" disabled>
            Request Sent
          </Button>
        ) : status.hasReceived ? (
          <div className="flex space-x-2 w-full">
            <Button onClick={handleAccept} className="flex-1">
              Accept
            </Button>
            <Button variant="outline" onClick={handleDecline} className="flex-1">
              Decline
            </Button>
          </div>
        ) : (
          <Button onClick={handleConnect} className="w-full">
            Connect
          </Button>
        )}
      </CardFooter>
    </Card>
  );
};

// UserList Component
export const UserList = ({
  users,
  isLoading,
  error,
}: {
  users: User[];
  isLoading: boolean;
  error: Error | null;
}) => {
  if (isLoading) {
    return (
      <p className="text-center py-12 text-muted-foreground">
        Loading users...
      </p>
    );
  }
  if (error) {
    return (
      <p className="text-center py-12 text-destructive">
        Error: {error.message}
      </p>
    );
  }
  if (users.length === 0) {
    return <p className="text-center py-12">No users found</p>;
  }
  return (
    <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
      {users.map((u) => (
        <UserCard key={u.id} user={u} />
      ))}
    </div>
  );
};
