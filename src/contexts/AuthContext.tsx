import React, {
  createContext,
  useState,
  useEffect,
  ReactNode,
} from "react";
import { authService } from "@/services/api/authService";
import { userService } from "@/services/api/userService";
import { User } from "@/models/user";
import { LoginRequest, RegisterRequest } from "@/models/auth";
import { toast } from "sonner";
import { stopNotificationHub } from "@/services/signalr/notificationHub";

interface AuthContextType {
  user: User | null;
  isLoading: boolean;
  isAuthenticated: boolean;
  login: (credentials: LoginRequest) => Promise<void>;
  register: (userData: RegisterRequest) => Promise<void>;
  logout: () => Promise<void>;
}

const AuthContext = createContext<AuthContextType | undefined>(undefined);

export const AuthProvider: React.FC<{ children: ReactNode }> = ({ children }) => {
  const [user, setUser] = useState<User | null>(null);
  const [isLoading, setIsLoading] = useState(true);
  const [isAuthenticated, setIsAuthenticated] = useState(false);

  useEffect(() => {
    const checkAuthStatus = async () => {
      try {
        setIsLoading(true);

        if (authService.isAuthenticated()) {
          const storedUser = localStorage.getItem("userData");
          if (storedUser) {
            setUser(JSON.parse(storedUser));
            setIsAuthenticated(true);
          }

          try {
            const userData = await userService.getCurrentUser();
            setUser(userData);
            setIsAuthenticated(true);
          } catch (error) {
            console.error("Failed to get current user data:", error);
            if (!storedUser) {
              setUser(null);
              setIsAuthenticated(false);
              localStorage.removeItem("authToken");
              localStorage.removeItem("userRole");
              localStorage.removeItem("userData");
            }
          }
        } else {
          setUser(null);
          setIsAuthenticated(false);
          localStorage.removeItem("userData");
        }
      } catch (error) {
        console.error("Authentication check failed:", error);
        setUser(null);
        setIsAuthenticated(false);
        localStorage.removeItem("authToken");
        localStorage.removeItem("userRole");
        localStorage.removeItem("userData");
      } finally {
        setIsLoading(false);
      }
    };

    checkAuthStatus();
  }, []);

  const login = async (credentials: LoginRequest) => {
    try {
      setIsLoading(true);
      await authService.login(credentials);
      const userData = await userService.getCurrentUser();
      setUser(userData);
      setIsAuthenticated(true);
      toast.success("Successfully logged in!");
    } catch (error) {
      const err = error as Error;
      toast.error(err.message || "Login failed");
      throw error;
    } finally {
      setIsLoading(false);
    }
  };

  const register = async (userData: RegisterRequest) => {
    try {
      setIsLoading(true);
      await authService.register(userData);
      toast.success("Registration successful! Please log in.");
    } catch (error) {
      const err = error as Error;
      toast.error(err.message || "Registration failed");
      throw error;
    } finally {
      setIsLoading(false);
    }
  };

  const logout = async () => {
    try {
      setIsLoading(true);
      await stopNotificationHub(); 
      authService.logout();
      localStorage.removeItem("authToken");
      localStorage.removeItem("userRole");
      localStorage.removeItem("userData");
      setUser(null);
      setIsAuthenticated(false);
      toast.success("Successfully logged out");

      window.location.href = "/login";
    } catch (error) {
      const err = error as Error;
      toast.error(err.message || "Logout failed");
      throw error;
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <AuthContext.Provider
      value={{
        user,
        isLoading,
        isAuthenticated,
        login,
        register,
        logout,
      }}
    >
      {children}
    </AuthContext.Provider>
  );
};

export { AuthContext };
