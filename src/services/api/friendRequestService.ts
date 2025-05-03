import { FriendRequestDto } from "@/models/friendRequest";

const authFetch = (input: RequestInfo, init: RequestInit = {}) => {
  const token = localStorage.getItem("authToken");
  const headers = {
    "Content-Type": "application/json",
    ...(init.headers || {}),
    ...(token ? { Authorization: `Bearer ${token}` } : {}),
  };
  return fetch(input, { ...init, headers });
};

const getSentRequests = async (): Promise<FriendRequestDto[]> => {
  const res = await authFetch("/api/FriendRequests/sent", { method: "GET" });
  if (!res.ok) throw new Error("Failed to fetch sent friend requests");
  return res.json();
};

const getReceivedRequests = async (): Promise<FriendRequestDto[]> => {
  const res = await authFetch("/api/FriendRequests/received", { method: "GET" });
  if (!res.ok) throw new Error("Failed to fetch received friend requests");
  return res.json();
};

const sendFriendRequest = async (toUserId: string): Promise<FriendRequestDto> => {
  const res = await authFetch("/api/FriendRequests", {
    method: "POST",
    body: JSON.stringify({ toUserId }),
  });
  if (!res.ok) {
    const text = await res.text();
    throw new Error(`Failed to send friend request: ${text}`);
  }
  return res.json();
};

const acceptRequest = async (requestId: string): Promise<void> => {
  const res = await authFetch(`/api/FriendRequests/${requestId}/accept`, {
    method: "PUT",
  });
  if (!res.ok) {
    const text = await res.text();
    throw new Error(`Failed to accept friend request: ${text}`);
  }
};

const rejectRequest = async (requestId: string): Promise<void> => {
  const res = await authFetch(`/api/FriendRequests/${requestId}/reject`, {
    method: "PUT",
  });
  if (!res.ok) {
    const text = await res.text();
    throw new Error(`Failed to reject friend request: ${text}`);
  }
};

const friendRequestService = {
  getSentRequests,
  getReceivedRequests,
  sendFriendRequest,
  acceptRequest,
  rejectRequest,
};

export default friendRequestService;