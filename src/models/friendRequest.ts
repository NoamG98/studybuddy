export interface FriendRequestDto {
  id: string;
  fromUserId: string;
  toUserId: string;
  createdAt: string;

  status: "pending" | "accepted" | "rejected";
}
