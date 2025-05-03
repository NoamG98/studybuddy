import { LoginRequest, RegisterRequest, AuthResponse } from "@/models/auth";
import api from "../api";

export const authService = {
  login: async (credentials: LoginRequest): Promise<AuthResponse> => {
    const { data } = await api.post<AuthResponse>("/api/Auth/login", credentials);

   
    localStorage.setItem("authToken", data.token);
    localStorage.setItem("refreshToken", data.refreshToken);
    localStorage.setItem("userRole", data.role);

    return data;
  },

  register: async (userData: RegisterRequest): Promise<AuthResponse> => {
    const { data } = await api.post<AuthResponse>("/api/Auth/register", userData);
    return data;
  },

  logout: (): void => {
    localStorage.removeItem("authToken");
    localStorage.removeItem("refreshToken");
    localStorage.removeItem("userRole");
    localStorage.removeItem("userData");
  },

  isAuthenticated: (): boolean => {
    return !!localStorage.getItem("authToken");
  },
};

export default authService;
