import { useState, useEffect } from "react";
import Navbar from "@/components/layout/Navbar";
import { Footer } from "@/components/layout/Footer";
import { CreatePostForm } from "@/features/home";
import PostCard from "@/components/home/PostCard";
import postService from "@/services/api/postService";
import { Post } from "@/models/post";
import useAuth from "@/contexts/useAuth";
import { User } from "@/models/user";
import userService from "@/services/api/userService";
import { Input } from "@/components/ui/input";
import { Button } from "@/components/ui/button";
import {
  Select,
  SelectContent,
  SelectItem,
  SelectTrigger,
  SelectValue,
} from "@/components/ui/select";

const Community: React.FC = () => {
  const { user: currentUser } = useAuth();
  const [searchQuery, setSearchQuery] = useState("");
  const [selectedCountry, setSelectedCountry] = useState<string>("all");
  const [selectedField, setSelectedField] = useState<string>("all");
  const [users, setUsers] = useState<User[]>([]);
  const [isLoadingUsers, setIsLoadingUsers] = useState(true);
  const [usersError, setUsersError] = useState<Error | null>(null);

  const [posts, setPosts] = useState<Post[]>([]);
  const [isLoadingPosts, setIsLoadingPosts] = useState(false);
  const [postsError, setPostsError] = useState<Error | null>(null);

  // Fetch all posts once
  useEffect(() => {
    const fetchPosts = async () => {
      try {
        setIsLoadingPosts(true);
        setPostsError(null);
        const list = await postService.getPosts();
        setPosts(list);
      } catch (err) {
        console.error(err);
        setPostsError(err instanceof Error ? err : new Error("Failed to load posts"));
      } finally {
        setIsLoadingPosts(false);
      }
    };
    fetchPosts();
  }, []);

  // Fetch users on filter change
  useEffect(() => {
    const fetchUsers = async () => {
      try {
        setIsLoadingUsers(true);
        setUsersError(null);
        const list = await userService.getUsers(
          searchQuery,
          selectedCountry,
          selectedField
        );
        setUsers(list);
      } catch (err) {
        console.error(err);
        setUsersError(err instanceof Error ? err : new Error("Failed to load users"));
      } finally {
        setIsLoadingUsers(false);
      }
    };
    fetchUsers();
  }, [searchQuery, selectedCountry, selectedField]);

  return (
    <div className="min-h-screen flex flex-col bg-background text-foreground">
      <Navbar isAuthenticated />
      <div className="flex-1 pt-16 bg-secondary/30">
        <div className="container mx-auto px-4 py-8 space-y-8">
          <h1 className="text-3xl font-bold text-foreground">Community</h1>

          {/* Create post */}
          <div className="bg-card p-4 rounded-md shadow-sm">
            <CreatePostForm />
          </div>

          {/* Posts feed */}
          <section className="space-y-4">
            {isLoadingPosts ? (
              <p className="text-foreground">Loading posts…</p>
            ) : postsError ? (
              <p className="text-destructive">Error: {postsError.message}</p>
            ) : (
              posts.map((p) => (
                <PostCard
                  key={p.id}
                  post={{ ...p, comments: p.comments ?? [] }}
                />
              ))
            )}
          </section>

          {/* Filters */}
          <div className="grid grid-cols-1 md:grid-cols-3 gap-4">
            <Input
              placeholder="Search by name, field, or location…"
              value={searchQuery}
              onChange={(e) => setSearchQuery(e.target.value)}
              className="bg-input text-foreground"
            />
            <Select
              value={selectedCountry}
              onValueChange={setSelectedCountry}
            >
              <SelectTrigger className="bg-input text-foreground">
                <SelectValue placeholder="All Countries" />
              </SelectTrigger>
              <SelectContent className="bg-card text-foreground">
                <SelectItem value="all">All Countries</SelectItem>
                {/* TODO: map real countries */}
              </SelectContent>
            </Select>
            <Select
              value={selectedField}
              onValueChange={setSelectedField}
            >
              <SelectTrigger className="bg-input text-foreground">
                <SelectValue placeholder="All Fields" />
              </SelectTrigger>
              <SelectContent className="bg-card text-foreground">
                <SelectItem value="all">All Fields</SelectItem>
                {/* TODO: map real fields */}
              </SelectContent>
            </Select>
          </div>

          {/* Users list */}
          <section>
            {isLoadingUsers ? (
              <p className="text-foreground">Loading users…</p>
            ) : usersError ? (
              <p className="text-destructive">Error: {usersError.message}</p>
            ) : users.length > 0 ? (
              <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 gap-6">
                {users.map((u) => (
                  <div
                    key={u.id}
                    className="bg-card p-4 rounded-md shadow-sm flex items-center space-x-4"
                  >
                    <div className="flex-1">
                      <p className="font-medium text-foreground">
                        {u.firstName} {u.lastName}
                      </p>
                      <p className="text-sm text-muted-foreground">
                        {u.city}, {u.country}
                      </p>
                    </div>
                    <Button size="sm">View</Button>
                  </div>
                ))}
              </div>
            ) : (
              <p className="text-foreground">No users found</p>
            )}
          </section>
        </div>
      </div>
      <Footer />
    </div>
  );
};

export default Community;
