import React, { useState } from "react";
import {
  Card,
  CardContent,
  CardFooter,
  CardHeader,
} from "@/components/ui/card";
import {
  Avatar,
  AvatarFallback,
  AvatarImage,
} from "@/components/ui/avatar";
import { Button } from "@/components/ui/button";
import { format } from "date-fns";
import { MoreVertical, Send } from "lucide-react";
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuItem,
  DropdownMenuTrigger,
} from "@/components/ui/dropdown-menu";
import {
  AlertDialog,
  AlertDialogAction,
  AlertDialogCancel,
  AlertDialogContent,
  AlertDialogFooter,
  AlertDialogHeader,
  AlertDialogTitle,
  AlertDialogTrigger,
} from "@/components/ui/alert-dialog";
import { Post, Comment } from "@/models/post";
import postService from "@/services/api/postService";
import likeService from "@/services/api/likeService";
import useAuth from "@/contexts/useAuth";
import { toast } from "sonner";
import { Input } from "@/components/ui/input";
import { Textarea } from "@/components/ui/textarea";

interface PostCardProps {
  post: Post & { comments: Comment[] };
  onUpdate?: () => void;
  onCommentAdded?: (postId: string, comment: Comment) => void;
  onPostLiked?: (postId: string, liked: boolean) => void;
}

const PostCard: React.FC<PostCardProps> = ({
  post,
  onUpdate,
  onCommentAdded,
  onPostLiked,
}) => {
  const [comment, setComment] = useState("");
  const [isCommenting, setIsCommenting] = useState(false);
  const [isLiking, setIsLiking] = useState(false);
  const [showComments, setShowComments] = useState(false);
  const [isEditing, setIsEditing] = useState(false);
  const [editContent, setEditContent] = useState(post.content);
  const [editImageUrl, setEditImageUrl] = useState(post.imageUrl || "");
  const [deleteDialogOpen, setDeleteDialogOpen] = useState(false);

  const { user, isAuthenticated } = useAuth();
  const canModify = isAuthenticated && user?.id === post.userId;

  const handleLike = async () => {
    if (!isAuthenticated) return toast.error("Please log in to like posts");
    setIsLiking(true);
    try {
      if (post.isLiked) {
        await likeService.unlikePost(post.id);
        onPostLiked?.(post.id, false);
      } else {
        await likeService.likePost(post.id);
        onPostLiked?.(post.id, true);
      }
    } catch {
      toast.error("Failed to process like");
    } finally {
      setIsLiking(false);
    }
  };

  const handleComment = async () => {
    if (!comment.trim()) return;
    if (!isAuthenticated) return toast.error("Please log in to comment");
    setIsCommenting(true);
    try {
      const newC = await postService.addComment(post.id, comment);
      setComment("");
      onCommentAdded?.(post.id, newC);
      toast.success("Comment added");
    } catch {
      toast.error("Failed to add comment");
    } finally {
      setIsCommenting(false);
    }
  };

  const handleEdit = () => {
    setEditContent(post.content);
    setEditImageUrl(post.imageUrl || "");
    setIsEditing(true);
  };

  const handleEditSubmit = async () => {
    if (!editContent.trim() && !editImageUrl) {
      return toast.error("Post content or image is required");
    }
    try {
      await postService.updatePost(post.id, {
        content: editContent,
        imageUrl: editImageUrl,
      });
      toast.success("Post updated");
      setIsEditing(false);
      onUpdate?.();
    } catch {
      toast.error("Failed to update post");
    }
  };

  const handleDeleteConfirmed = async () => {
    setDeleteDialogOpen(false);
    try {
      await postService.deletePost(post.id);
      toast.success("Post deleted");
      onUpdate?.();
    } catch {
      toast.error("Failed to delete post");
    }
  };

  const getInitials = (name?: string) =>
    name
      ? name
          .split(" ")
          .map(v => v[0])
          .join("")
          .toUpperCase()
          .substring(0, 2)
      : "";

  return (
    <Card className="relative mb-6 bg-white dark:bg-gray-800 border border-gray-200 dark:border-gray-700 rounded-lg max-w-2xl mx-auto">

      {canModify && !isEditing && (
        <div className="absolute top-2 right-2 z-10">
          <DropdownMenu>
            <DropdownMenuTrigger asChild>
              <Button variant="ghost" size="icon">
                <MoreVertical className="text-gray-500 dark:text-gray-400" />
              </Button>
            </DropdownMenuTrigger>
            <DropdownMenuContent align="end" className="bg-white dark:bg-gray-800">
              <DropdownMenuItem onSelect={handleEdit}>
                Edit
              </DropdownMenuItem>
              <AlertDialog open={deleteDialogOpen} onOpenChange={setDeleteDialogOpen}>
                <AlertDialogTrigger asChild>
                  <DropdownMenuItem onSelect={() => setDeleteDialogOpen(true)}>
                    Delete
                  </DropdownMenuItem>
                </AlertDialogTrigger>
                <AlertDialogContent>
                  <AlertDialogHeader>
                    <AlertDialogTitle>🗑️ Are you sure?</AlertDialogTitle>
                  </AlertDialogHeader>
                  <AlertDialogFooter>
                    <AlertDialogCancel>Cancel</AlertDialogCancel>
                    <AlertDialogAction onClick={handleDeleteConfirmed}>
                      Yes, delete it
                    </AlertDialogAction>
                  </AlertDialogFooter>
                </AlertDialogContent>
              </AlertDialog>
            </DropdownMenuContent>
          </DropdownMenu>
        </div>
      )}

      <CardHeader className="flex items-center space-x-3 px-4 py-2">
        <Avatar className="h-10 w-10">
          {post.authorAvatarUrl ? (
            <AvatarImage src={post.authorAvatarUrl} />
          ) : (
            <AvatarFallback>{getInitials(post.authorName)}</AvatarFallback>
          )}
        </Avatar>
        <div>
          <h3 className="font-semibold text-gray-900 dark:text-gray-100">
            {post.authorName}
          </h3>
          <p className="text-xs text-gray-500 dark:text-gray-400">
            {format(new Date(post.createdAt), "MMM dd 'at' HH:mm")}
          </p>
        </div>
      </CardHeader>

      {isEditing ? (
        <CardContent className="px-4 py-2 space-y-3">
          <Textarea
            value={editContent}
            onChange={e => setEditContent(e.target.value)}
            rows={3}
          />
          <Input
            placeholder="Image URL (optional)"
            value={editImageUrl}
            onChange={e => setEditImageUrl(e.target.value)}
          />
          <div className="flex justify-end space-x-2">
            <Button variant="outline" onClick={() => setIsEditing(false)}>
              Cancel
            </Button>
            <Button onClick={handleEditSubmit}>
              Save
            </Button>
          </div>
        </CardContent>
      ) : (
        <CardContent className="px-4 py-2">
          <p className="text-gray-800 dark:text-gray-200 whitespace-pre-wrap">{post.content}</p>
          {post.imageUrl && (
            <img
              src={post.imageUrl}
              alt="Post"
              className="mt-2 rounded-lg w-full object-cover"
            />
          )}
        </CardContent>
      )}

      <CardFooter className="flex flex-col space-y-3 px-4 pb-3 pt-0">
        {!isEditing && (
          <div className="text-sm text-gray-500 dark:text-gray-400">
            {post.likesCount} {post.likesCount === 1 ? "like" : "likes"} ·{" "}
            {post.comments.length} {post.comments.length === 1 ? "comment" : "comments"}
          </div>
        )}
        {!isEditing && (
          <div className="flex space-x-4 border-t border-gray-200 dark:border-gray-700 pt-2">
            <Button
              variant="ghost"
              size="sm"
              onClick={handleLike}
              disabled={isLiking}
              className="text-gray-600 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-700 rounded-md"
            >
              Like
            </Button>
            <Button
              variant="ghost"
              size="sm"
              onClick={() => setShowComments(v => !v)}
              className="text-gray-600 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-700 rounded-md"
            >
              Comment
            </Button>
            <Button
              variant="ghost"
              size="sm"
              className="text-gray-600 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-700 rounded-md"
            >
              Send
            </Button>
          </div>
        )}

        {!isEditing && showComments && (
          <div className="space-y-3 mt-2">
            {post.comments.map(c => (
              <div
                key={c.id}
                className="flex items-start space-x-2 p-2 bg-gray-50 dark:bg-gray-900 rounded-lg"
              >
                <Avatar className="h-8 w-8">
                  {c.authorAvatarUrl ? (
                    <AvatarImage src={c.authorAvatarUrl} />
                  ) : (
                    <AvatarFallback>{getInitials(c.authorName)}</AvatarFallback>
                  )}
                </Avatar>
                <div className="flex-1">
                  <div className="flex items-center justify-between">
                    <p className="text-sm font-medium text-gray-800 dark:text-gray-100">
                      {c.authorName}
                    </p>
                    <p className="text-xs text-gray-500 dark:text-gray-400">
                      {format(new Date(c.createdAt), "HH:mm")}
                    </p>
                  </div>
                  <p className="text-sm text-gray-700 dark:text-gray-300">
                    {c.content}
                  </p>
                </div>
              </div>
            ))}

            <div className="flex items-center space-x-2">
              <Avatar className="h-8 w-8">
                {user?.avatarUrl ? (
                  <AvatarImage src={user.avatarUrl} />
                ) : (
                  <AvatarFallback>
                    {user?.firstName?.[0]}{user?.lastName?.[0]}
                  </AvatarFallback>
                )}
              </Avatar>
              <Input
                value={comment}
                onChange={e => setComment(e.target.value)}
                placeholder={`Answer as ${user?.firstName} ${user?.lastName}`}
                disabled={isCommenting}
                className="flex-1 border-gray-300 dark:border-gray-600"
              />
              <Button
                size="icon"
                onClick={handleComment}
                disabled={!comment.trim() || isCommenting}
                className="text-blue-600 hover:bg-blue-50 dark:hover:bg-gray-700 rounded-full"
              >
                <Send className="h-5 w-5" />
              </Button>
            </div>
          </div>
        )}
      </CardFooter>
    </Card>
  );
};

export default PostCard;
