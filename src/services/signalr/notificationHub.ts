import { HubConnectionBuilder, HubConnection } from "@microsoft/signalr";
import { toast } from "sonner";
import { queryClient } from "@/lib/queryClient";
import { v4 as uuidv4 } from "uuid";

export interface Notification {
  id: string;
  message: string;
  type: "post" | "comment" | "friend_request";
  postId?: string;
  commentId?: string;
  requestId?: string;
}

let connection: HubConnection | null = null;
const listeners: ((notif: Notification) => void)[] = [];

/** Subscribe to incoming notifications */
export const subscribeNotifications = (cb: (notif: Notification) => void) => {
  listeners.push(cb);
};

/** Start SignalR hub and wire up server events */
export const startNotificationHub = async () => {
  if (connection || !localStorage.getItem("authToken")) return;

  connection = new HubConnectionBuilder()
    .withUrl(`${import.meta.env.VITE_API_URL}/hubs/notifications`, {
      accessTokenFactory: () => localStorage.getItem("authToken") || "",
    })
    .withAutomaticReconnect()
    .build();

  const push = (notif: Notification) => {
    toast(notif.message);
    listeners.forEach(cb => cb(notif));
  };


  connection.on("PostCreated", (created: { id: string }) => {
    const notif: Notification = {
      id: uuidv4(),
      message: "📢 New post added",
      type: "post",
      postId: created.id,
    };
    push(notif);
    queryClient.invalidateQueries({ queryKey: ["posts"] });
  });

  connection.on("CommentAdded", (comment: { postId: string; id: string }) => {
    const notif: Notification = {
      id: uuidv4(),
      message: "💬 New comment added",
      type: "comment",
      postId: comment.postId,
      commentId: comment.id,
    };
    push(notif);
    queryClient.invalidateQueries({ queryKey: ["posts"] });
  });
  // When a friend request arrives, include its requestId
  connection.on("FriendRequestReceived", (requestId: string, fromUserName: string) => {
    const notif: Notification = {
      id: uuidv4(),
      message: `🔔 ${fromUserName} sent you a friend request`,
      type: "friend_request",
      requestId,
    };
    push(notif);
  });

  try {
    await connection.start();
    console.log("✅ Connected to SignalR hub");
  } catch (err) {
    console.error("❌ Error connecting to SignalR hub:", err);
  }
};


export const stopNotificationHub = async () => {
  if (connection && connection.state === "Connected") {
    await connection.stop();
    console.log("🔌 Disconnected from SignalR hub");
  }
  connection = null;
};
