export const tokenService = {
    getToken: () => localStorage.getItem("authToken"),
  
    setToken: (token: string) => {
      localStorage.setItem("authToken", token);
    },
  
    removeToken: () => {
      localStorage.removeItem("authToken");
    },
  
    refreshToken: async (): Promise<string | null> => {
      try {
        const refreshToken = localStorage.getItem("refreshToken");
        if (!refreshToken) return null;
  
        const response = await fetch("/api/Auth/refresh-token", {
          method: "POST",
          headers: {
            "Content-Type": "application/json",
          },
          body: JSON.stringify({ refreshToken }),
        });
  
        if (!response.ok) throw new Error("Failed to refresh token");
  
        const data = await response.json();
        tokenService.setToken(data.token);
        return data.token;
      } catch (error) {
        console.error("Token refresh error:", error);
        tokenService.removeToken();
        return null;
      }
    },
  };