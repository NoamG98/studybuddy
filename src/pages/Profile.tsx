import { useState, useEffect, ChangeEvent } from "react";
import { useParams, Link } from "react-router-dom";
import { Avatar, AvatarFallback, AvatarImage } from "@/components/ui/avatar";
import Navbar from "@/components/layout/Navbar";
import { Footer } from "@/components/layout/Footer";
import { Button } from "@/components/ui/button";
import { Tabs, TabsContent, TabsList, TabsTrigger } from "@/components/ui/tabs";
import { Card, CardContent } from "@/components/ui/card";
import { Badge } from "@/components/ui/badge";
import { Input } from "@/components/ui/input";
import useAuth from "@/contexts/useAuth";
import { userService, postService } from "@/services/api";
import friendRequestService from "@/services/api/friendRequestService";
import { User } from "@/models/user";
import { Post } from "@/models/post";
import PostCard from "@/components/home/PostCard";
import { toast } from "sonner";
import { queryClient } from "@/lib/queryClient";

type RequestState =
  | { status: "none" }
  | { status: "sent"; requestId: string }
  | { status: "received"; requestId: string }
  | { status: "friends"; requestId: string };

const Profile: React.FC = () => {
  const [activeTab, setActiveTab] = useState<"posts" | "friends">("posts");
  const [profileUser, setProfileUser] = useState<User | null>(null);
  const [posts, setPosts] = useState<Post[]>([]);
  const [isLoading, setIsLoading] = useState(true);
  const [editMode, setEditMode] = useState(false);

  const { user: currentUser } = useAuth();
  const { id } = useParams<{ id: string }>();
  const targetUserId = id ?? currentUser?.id ?? "";

  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [email, setEmail] = useState("");
  const [avatarUrl, setAvatarUrl] = useState("");
  const [password, setPassword] = useState("");

  const [requestState, setRequestState] = useState<RequestState>({ status: "none" });
  const [loadingRequest, setLoadingRequest] = useState(false);
  const [saving, setSaving] = useState(false);

  const handleTabChange = (value: string) => setActiveTab(value as "posts" | "friends");

  // load profile, posts, and friend-request state
  useEffect(() => {
    const load = async () => {
      try {
        setIsLoading(true);
        const u = await userService.getUserById(targetUserId);
        setProfileUser(u);
        setFirstName(u.firstName);
        setLastName(u.lastName);
        setEmail(u.email);
        setAvatarUrl(u.avatarUrl ?? "");

        const all = await postService.getPosts();
        setPosts(all.filter((p) => p.userId === targetUserId));

        if (currentUser && targetUserId !== currentUser.id) {
          const [sent, rec] = await Promise.all([
            friendRequestService.getSentRequests(),
            friendRequestService.getReceivedRequests(),
          ]);
          const s = sent.find((r) => r.toUserId === targetUserId);
          if (s) {
            setRequestState({
              status: s.status === "accepted" ? "friends" : "sent",
              requestId: s.id,
            });
            return;
          }
          const r = rec.find((r) => r.fromUserId === targetUserId);
          if (r) {
            setRequestState({
              status: r.status === "accepted" ? "friends" : "received",
              requestId: r.id,
            });
            return;
          }
        }
      } catch (error) {
        console.error(error);
        toast.error("Failed to load profile");
      } finally {
        setIsLoading(false);
      }
    };

    if (targetUserId) load();
  }, [targetUserId, currentUser]);

  // friend-request handlers
  const handleSend = async () => {
    setLoadingRequest(true);
    try {
      const newReq = await friendRequestService.sendFriendRequest(targetUserId);
      setRequestState({ status: "sent", requestId: newReq.id });
      toast.success("Friend request sent");
    } catch {
      toast.error("Failed to send request");
    } finally {
      setLoadingRequest(false);
    }
  };

  const handleAccept = async () => {
    if (requestState.status !== "received") return;
    setLoadingRequest(true);
    try {
      await friendRequestService.acceptRequest(requestState.requestId);
      setRequestState({ status: "friends", requestId: requestState.requestId });
      toast.success("Friend request accepted");
    } catch {
      toast.error("Failed to accept request");
    } finally {
      setLoadingRequest(false);
    }
  };

  const handleReject = async () => {
    if (requestState.status === "received" || requestState.status === "sent") {
      setLoadingRequest(true);
      try {
        await friendRequestService.rejectRequest(requestState.requestId);
        setRequestState({ status: "none" });
        toast.success("Friend request cancelled");
      } catch {
        toast.error("Failed to cancel request");
      } finally {
        setLoadingRequest(false);
      }
    }
  };

  const handleUnfriend = async () => {
    if (requestState.status !== "friends") return;
    setLoadingRequest(true);
    try {
      await friendRequestService.rejectRequest(requestState.requestId);
      setRequestState({ status: "none" });
      toast.success("Unfriended");
    } catch {
      toast.error("Failed to unfriend");
    } finally {
      setLoadingRequest(false);
    }
  };

  // avatar preview
  const onAvatarChange = (e: ChangeEvent<HTMLInputElement>) => {
    const file = e.target.files?.[0];
    if (!file) return;
    const reader = new FileReader();
    reader.onload = () => setAvatarUrl(reader.result as string);
    reader.readAsDataURL(file);
  };

  // save profile edits (send full DTO including all required properties)
  const onSave = async () => {
    if (!profileUser) return;
    setSaving(true);
    try {
      // build a full payload that the backend expects
      await userService.updateUser(profileUser.id, {
        // edited fields:
        firstName,
        lastName,
        email,
        password: password || undefined,
        avatarUrl,
        // carry forward the rest of the existing DTO:
        dateOfBirth: profileUser.dateOfBirth,
        gender: profileUser.gender,
        studyField: profileUser.studyField,
        country: profileUser.country,
        city: profileUser.city,
        role: profileUser.role,
      });
      toast.success("Profile updated");
      queryClient.invalidateQueries({ queryKey: ["user", profileUser.id] });
      setEditMode(false);
    } catch (error: unknown) {
      console.error(error);
      if (error instanceof Error) {
        toast.error(error.message);
      } else {
        toast.error("Failed to save profile");
      }
    } finally {
      setSaving(false);
    }
  };

  if (isLoading) {
    return (
      <div className="min-h-screen flex flex-col bg-background text-foreground">
        <Navbar isAuthenticated />
        <div className="flex-1 pt-16 bg-secondary/30 flex items-center justify-center">
          <p>Loading...</p>
        </div>
        <Footer />
      </div>
    );
  }

  if (!profileUser) {
    return (
      <div className="min-h-screen flex flex-col bg-background text-foreground">
        <Navbar isAuthenticated />
        <div className="flex-1 pt-16 bg-secondary/30 flex items-center justify-center">
          <div className="text-center">
            <h2 className="text-2xl font-bold mb-2">User Not Found</h2>
            <Link to="/community">
              <Button>Back to Community</Button>
            </Link>
          </div>
        </div>
        <Footer />
      </div>
    );
  }

  const isOwn = profileUser.id === currentUser?.id;

  return (
    <div className="min-h-screen flex flex-col bg-background text-foreground">
      <Navbar isAuthenticated />

      <div className="flex-1 pt-16 bg-secondary/30">
        <div className="w-full h-60 bg-secondary" />
        <div className="container mx-auto px-4 pt-20 pb-10">
          {/* header */}
          <div className="flex justify-between items-center mb-8">
            <div className="flex items-center space-x-4">
              <Avatar className="h-24 w-24">
                {avatarUrl ? <AvatarImage src={avatarUrl} /> : <AvatarFallback>{firstName[0]}{lastName[0]}</AvatarFallback>}
              </Avatar>
              <div>
                <h1 className="text-3xl font-bold">{firstName} {lastName}</h1>
                <Badge className="capitalize">{profileUser.role}</Badge>
              </div>
            </div>
            {isOwn ? (
              <Button variant={editMode ? "destructive" : "outline"} onClick={() => setEditMode(!editMode)}>
                {editMode ? "Cancel" : "Edit Profile"}
              </Button>
            ) : (
              <ActionButtons
                state={requestState}
                onSend={handleSend}
                onAccept={handleAccept}
                onReject={handleReject}
                onUnfriend={handleUnfriend}
                loading={loadingRequest}
              />
            )}
          </div>

          {/* edit form */}
          {editMode && (
            <Card className="mb-8 bg-card text-card-foreground border border-border">
              <CardContent className="flex flex-col md:flex-row gap-6 p-6">
                {/* avatar upload */}
                <div className="md:w-1/3 flex flex-col items-center space-y-4">
                  <div className="relative">
                    <Avatar className="h-32 w-32 ring-2 ring-primary">
                      {avatarUrl ? <AvatarImage src={avatarUrl} /> : <AvatarFallback className="text-2xl">{firstName[0]}{lastName[0]}</AvatarFallback>}
                    </Avatar>
                    <label htmlFor="avatarInput" className="absolute bottom-0 right-0 bg-primary text-white p-1 rounded-full cursor-pointer hover:bg-primary/90">
                      ✎
                    </label>
                  </div>
                  <input id="avatarInput" type="file" accept="image/*" className="hidden" onChange={onAvatarChange} />
                </div>
                {/* text fields */}
                <div className="md:w-2/3 grid grid-cols-1 gap-4">
                  <Input placeholder="First Name" value={firstName} onChange={(e) => setFirstName(e.target.value)} />
                  <Input placeholder="Last Name" value={lastName} onChange={(e) => setLastName(e.target.value)} />
                  <Input type="email" placeholder="Email" value={email} onChange={(e) => setEmail(e.target.value)} />
                  <Input type="password" placeholder="New Password" value={password} onChange={(e) => setPassword(e.target.value)} />
                  <div className="flex justify-end">
                    <Button onClick={onSave} disabled={saving}>{saving ? "Saving…" : "Save Changes"}</Button>
                  </div>
                </div>
              </CardContent>
            </Card>
          )}

          {/* info cards & tabs */}
          <div className="grid grid-cols-1 md:grid-cols-3 gap-6">
            <div className="space-y-6">
              <Card className="bg-card text-card-foreground border border-border">
                <CardContent>
                  <h2 className="text-xl font-semibold mb-2">About</h2>
                  <p><strong>Email:</strong> {profileUser.email}</p>
                  <p><strong>Location:</strong> {profileUser.city}, {profileUser.country}</p>
                </CardContent>
              </Card>
              <Card className="bg-card text-card-foreground border border-border">
                <CardContent>
                  <h2 className="text-xl font-semibold mb-2">Education</h2>
                  <p>{profileUser.studyField || "Not specified"}</p>
                </CardContent>
              </Card>
            </div>
            <div className="md:col-span-2">
              <Tabs value={activeTab} onValueChange={handleTabChange}>
                <TabsList className="mb-6">
                  <TabsTrigger value="posts">Posts</TabsTrigger>
                  <TabsTrigger value="friends">Friends</TabsTrigger>
                </TabsList>
                <TabsContent value="posts" className="space-y-6">
                  {posts.length > 0 ? posts.map((p) => <PostCard key={p.id} post={p} />) : <p className="text-center text-muted-foreground">No posts yet.</p>}
                </TabsContent>
                <TabsContent value="friends">
                  <p className="text-center text-muted-foreground">No connections yet.</p>
                </TabsContent>
              </Tabs>
            </div>
          </div>
        </div>
      </div>
      <Footer />
    </div>
  );
};

// extract action buttons
const ActionButtons = ({
  state,
  onSend,
  onAccept,
  onReject,
  onUnfriend,
  loading,
}: {
  state: RequestState;
  onSend: () => void;
  onAccept: () => void;
  onReject: () => void;
  onUnfriend: () => void;
  loading: boolean;
}) => {
  return (
    <div className="space-x-2">
      {state.status === "none" && <Button onClick={onSend} disabled={loading}>Connect</Button>}
      {state.status === "sent" && <Button variant="destructive" onClick={onReject} disabled={loading}>Cancel Request</Button>}
      {state.status === "received" && (
        <>
          <Button onClick={onAccept} disabled={loading}>Accept</Button>
          <Button variant="destructive" onClick={onReject} disabled={loading}>Reject</Button>
        </>
      )}
      {state.status === "friends" && <Button variant="destructive" onClick={onUnfriend} disabled={loading}>Unfriend</Button>}
    </div>
  );
};

export default Profile;