import { User } from "@/models/user";
import api from "../api";
import { FriendRequestDto } from "@/models/friendRequest";
  export const userService = {
    getUsers: async (
      query?: string,
      country?: string,
      field?: string
    ): Promise<User[]> => {
      const params = new URLSearchParams();
      if (query) params.append("query", query);
      if (country && country !== "all") params.append("country", country);
      if (field && field !== "all") params.append("field", field);
      const queryString = params.toString() ? `?${params.toString()}` : "";
      const { data } = await api.get<User[]>(`/api/Users/search${queryString}`);
      return data;
    },
  
    getCurrentUser: async (): Promise<User> => {
      const { data } = await api.get<User>("/api/Users/me");
      localStorage.setItem("userData", JSON.stringify(data));
      return data;
    },
  
    getUserById: async (id: string): Promise<User> => {
      const { data } = await api.get<User>(`/api/Users/${id}`);
      return data;
    },
  
    updateUser: async (
      id: string,
      profileData: Partial<User> & { password?: string }
    ): Promise<User> => {
      const { data } = await api.put<User>(`/api/Users/${id}`, profileData);
      const stored = JSON.parse(localStorage.getItem("userData") || "{}");
      if (stored.id === id) {
        localStorage.setItem("userData", JSON.stringify(data));
      }
      return data;
    },

  sendFriendRequest: async (userId: string): Promise<void> => {
    await api.post(`/api/Users/${userId}/friend-request`);
  },

  getFriendRequests: async (): Promise<FriendRequestDto[]> => {
    const { data } = await api.get<FriendRequestDto[]>("/api/Users/friend-request");
    return data;
  },

  acceptFriendRequest: async (requestId: string): Promise<void> => {
    await api.put(`/api/Users/friend-request/${requestId}/accept`);
  },

  rejectFriendRequest: async (requestId: string): Promise<void> => {
    await api.put(`/api/Users/friend-request/${requestId}/reject`);
  },
};

export default userService;
