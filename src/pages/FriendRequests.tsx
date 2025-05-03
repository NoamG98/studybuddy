import React, { useState, useEffect, useCallback } from "react";
import { Link, useNavigate } from "react-router-dom";
import Navbar from "@/components/layout/Navbar";
import { Footer } from "@/components/layout/Footer";
import { Avatar, AvatarFallback, AvatarImage } from "@/components/ui/avatar";
import { Button } from "@/components/ui/button";
import { Card, CardContent, CardFooter } from "@/components/ui/card";
import { toast } from "sonner";
import useAuth from "@/contexts/useAuth";
import friendRequestService from "@/services/api/friendRequestService";
import { FriendRequestDto } from "@/models/friendRequest";
import { userService } from "@/services/api/userService";
import { queryClient } from "@/lib/queryClient";

interface EnrichedRequest {
  request: FriendRequestDto;
  fromUser: { firstName: string; lastName: string; avatarUrl?: string };
}

const FriendRequests: React.FC = () => {
  const { user } = useAuth();
  const navigate = useNavigate();
  const [requests, setRequests] = useState<EnrichedRequest[]>([]);
  const [isLoading, setIsLoading] = useState(true);

  const fetchRequests = useCallback(async () => {
    if (!user) return;
    setIsLoading(true);
    try {
      const rec = await friendRequestService.getReceivedRequests();
      // show only truly pending
      const pending = rec.filter(r => r.status.toLowerCase() === "pending");
      const enriched = await Promise.all(
        pending.map(async r => {
          const u = await userService.getUserById(r.fromUserId);
          return { request: r, fromUser: u };
        })
      );
      setRequests(enriched);
    } catch (err) {
      console.error(err);
      toast.error("Error loading friend requests");
    } finally {
      setIsLoading(false);
    }
  }, [user]);

  useEffect(() => {
    fetchRequests();
  }, [fetchRequests]);

  const handleAccept = async (reqId: string) => {
    try {
      await friendRequestService.acceptRequest(reqId);
      toast.success("Request accepted");
      // remove from local list
      setRequests(prev => prev.filter(r => r.request.id !== reqId));
      // invalidate posts feed so Home will refetch
      queryClient.invalidateQueries({ queryKey: ["posts"] });
      // send them back to feed
      navigate("/home");
    } catch {
      toast.error("Failed to accept request");
    }
  };

  const handleReject = async (reqId: string) => {
    try {
      await friendRequestService.rejectRequest(reqId);
      toast.success("Request rejected");
      setRequests(prev => prev.filter(r => r.request.id !== reqId));
    } catch {
      toast.error("Failed to reject request");
    }
  };

  return (
    <div className="min-h-screen flex flex-col bg-background text-foreground">
      <Navbar isAuthenticated />
      <div className="flex-1 pt-16 bg-secondary/30">
        <div className="container mx-auto px-4 py-8 space-y-6">
          <h1 className="text-2xl font-bold text-foreground">
            Incoming Friend Requests
          </h1>
          {isLoading ? (
            <p className="text-foreground">Loading requests…</p>
          ) : requests.length === 0 ? (
            <p className="text-muted-foreground">
              No new friend requests.
            </p>
          ) : (
            requests.map(({ request, fromUser }) => (
              <Card
                key={request.id}
                className="flex items-center p-4 bg-card text-foreground"
              >
                <Avatar className="h-12 w-12 mr-4">
                  {fromUser.avatarUrl ? (
                    <AvatarImage src={fromUser.avatarUrl} />
                  ) : (
                    <AvatarFallback>
                      {fromUser.firstName[0]}
                      {fromUser.lastName[0]}
                    </AvatarFallback>
                  )}
                </Avatar>
                <div className="flex-1">
                  <p className="font-medium text-foreground">
                    {fromUser.firstName} {fromUser.lastName}
                  </p>
                  <p className="text-sm text-muted-foreground">
                    Sent on{" "}
                    {new Date(request.createdAt).toLocaleString("he-IL", {
                      dateStyle: "short",
                      timeStyle: "short",
                    })}
                  </p>
                </div>
                <CardFooter className="space-x-2 bg-card">
                  <Button onClick={() => handleAccept(request.id)}>
                    Accept
                  </Button>
                  <Button
                    variant="destructive"
                    onClick={() => handleReject(request.id)}
                  >
                    Reject
                  </Button>
                </CardFooter>
              </Card>
            ))
          )}
        </div>
      </div>
      <Footer />
    </div>
  );
};

export default FriendRequests;