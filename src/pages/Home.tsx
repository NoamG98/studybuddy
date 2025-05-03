import { useState, useEffect, useCallback } from "react";
import Navbar from "@/components/layout/Navbar";
import { Footer } from "@/components/layout/Footer";
import { CreatePostForm } from "@/features/home";
import PostCard from "@/components/home/PostCard";
import { postService } from "@/services/api";
import friendRequestService from "@/services/api/friendRequestService";
import { FriendRequestDto } from "@/models/friendRequest";
import useAuth from "@/contexts/useAuth";
import { Post } from "@/models/post";
import { Card, CardContent } from "@/components/ui/card";
import { Button } from "@/components/ui/button";
import { startNotificationHub, subscribeNotifications } from "@/services/signalr/notificationHub";

const Home: React.FC = () => {
  const { user: currentUser } = useAuth();
  const currentUserId = currentUser?.id;

  const [posts, setPosts] = useState<Post[]>([]);
  const [isLoading, setIsLoading] = useState(true);

  // Fetch feed and sort newest first
  const fetchFeed = useCallback(async () => {
    setIsLoading(true);
    try {
      const allPosts = await postService.getPosts();
      const [sent, received] = await Promise.all([
        friendRequestService.getSentRequests(),
        friendRequestService.getReceivedRequests(),
      ]) as [FriendRequestDto[], FriendRequestDto[]];

      // collect accepted friends
      const acceptedSent = sent.filter(r => r.status === "accepted").map(r => r.toUserId);
      const acceptedReceived = received.filter(r => r.status === "accepted").map(r => r.fromUserId);

      const friendsSet = new Set<string>([
        ...acceptedSent,
        ...acceptedReceived,
        currentUserId ?? "",
      ]);

      // filter & sort
      const filtered = allPosts
        .filter(p => friendsSet.has(p.userId))
        .sort((a, b) => new Date(b.createdAt).getTime() - new Date(a.createdAt).getTime());

      setPosts(filtered);
    } catch (err) {
      console.error("Failed to load feed:", err);
    } finally {
      setIsLoading(false);
    }
  }, [currentUserId]);

  // on mount: load feed + start hub + re-fetch on any notification
  useEffect(() => {
    if (!currentUserId) return;
    fetchFeed();
    startNotificationHub()
      .then(() => subscribeNotifications(() => {
        fetchFeed();
      }))
      .catch(console.error);
  }, [currentUserId, fetchFeed]);

  return (
    <div className="page-container bg-background text-foreground">
      <Navbar isAuthenticated />

      <div className="flex-1 pt-20 bg-secondary/30">
        <div className="container mx-auto px-4 py-8 grid grid-cols-1 lg:grid-cols-3 gap-6">

          {/* Left Sidebar */}
          <aside className="hidden lg:block space-y-6">
            <Card className="bg-card text-card-foreground border border-border p-4">
              <CardContent className="space-y-2">
                <h2 className="font-semibold text-lg">Trending Groups</h2>
                {["React Devs","AI Enthusiasts","Math Wizards"].map(name => (
                  <div key={name} className="flex items-center space-x-2 text-sm">
                    <div className="h-6 w-6 bg-muted rounded-full" />
                    <span>{name}</span>
                  </div>
                ))}
              </CardContent>
            </Card>

            <Card className="bg-card text-card-foreground border border-border p-4">
              <CardContent className="space-y-2">
                <h2 className="font-semibold text-lg">Upcoming Events</h2>
                <ul className="text-sm space-y-1">
                  <li>📅 May 10: React Study Jam</li>
                  <li>📅 May 12: Resume Workshop</li>
                  <li>📅 May 15: AI Panel</li>
                </ul>
              </CardContent>
            </Card>

            <Card className="bg-card text-card-foreground border border-border p-4">
              <CardContent className="space-y-2">
                <h2 className="font-semibold text-lg">Quick Poll</h2>
                <p className="text-sm">Favorite study time?</p>
                <div className="flex flex-col text-sm space-y-1">
                  <button className="text-left hover:underline">☀️ Morning</button>
                  <button className="text-left hover:underline">🌞 Afternoon</button>
                  <button className="text-left hover:underline">🌙 Evening</button>
                </div>
              </CardContent>
            </Card>
          </aside>

          {/* Main Feed */}
          <main className="space-y-6">
            <CreatePostForm />

            {isLoading ? (
              <p>Loading feed…</p>
            ) : posts.length > 0 ? (
              posts.map(post => (
                <PostCard
                  key={post.id}
                  post={post}
                  onUpdate={fetchFeed}
                  onCommentAdded={(id, comment) => {
                    setPosts(prev =>
                      prev.map(p =>
                        p.id === id ? { ...p, comments: [...p.comments, comment] } : p
                      )
                    );
                  }}
                  onPostLiked={(id, liked) => {
                    setPosts(prev =>
                      prev.map(p =>
                        p.id === id
                          ? {
                              ...p,
                              isLiked: liked,
                              likesCount: liked ? p.likesCount + 1 : p.likesCount - 1,
                            }
                          : p
                      )
                    );
                  }}
                />
              ))
            ) : (
              <p className="text-center text-muted-foreground">
                No posts from your connections now.
              </p>
            )}
          </main>

          {/* Right Sidebar */}
          <aside className="hidden lg:block space-y-6">
            <Card className="bg-card text-card-foreground border border-border p-4">
              <CardContent className="space-y-2">
                <h2 className="font-semibold text-lg">Job Spotlight</h2>
                <div className="bg-muted p-2 rounded space-y-1">
                  <p className="text-sm font-medium">Frontend Engineer</p>
                  <p className="text-xs">Acme Corp • Remote</p>
                  <Button size="sm" variant="outline">Apply</Button>
                </div>
              </CardContent>
            </Card>

            <Card className="bg-card text-card-foreground border border-border p-4">
              <CardContent className="space-y-2">
                <h2 className="font-semibold text-lg">Tip of the Day</h2>
                <p className="text-sm italic">
                  “Use the Pomodoro Technique: 25-minute focus, 5-minute break.”
                </p>
              </CardContent>
            </Card>
          </aside>

        </div>
      </div>

      <Footer />
    </div>
  );
};

export default Home;