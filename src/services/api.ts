import axios, { AxiosError } from "axios";

const api = axios.create({
  baseURL: import.meta.env.DEV
    ? "https://localhost:5001"
    : import.meta.env.VITE_API_BASE_URL,
});

let isRefreshing = false;
let failedQueue: { resolve: (value?: unknown) => void; reject: (error: unknown) => void }[] = [];

const processQueue = (error: unknown, token: string | null = null) => {
  failedQueue.forEach((prom) => {
    if (error) {
      prom.reject(error);
    } else {
      prom.resolve(token);
    }
  });
  failedQueue = [];
};

api.interceptors.request.use(
  (config) => {
    const token = localStorage.getItem("authToken");
    if (token && config.headers) {
      config.headers.Authorization = `Bearer ${token}`;
    }
    return config;
  },
  (error) => Promise.reject(error)
);

api.interceptors.response.use(
  (response) => response,
  async (error: AxiosError) => {
    const originalRequest = error.config as {
      _retry?: boolean;
      url: string;
      headers: { Authorization?: string };
    };

    if (
      error.response?.status === 401 &&
      !originalRequest._retry &&
      !originalRequest.url.includes("/api/Auth/refresh")
    ) {
      originalRequest._retry = true;

      if (isRefreshing) {
        return new Promise((resolve, reject) => {
          failedQueue.push({ resolve, reject });
        })
          .then((token) => {
            originalRequest.headers.Authorization = `Bearer ${token}`;
            return api(originalRequest);
          })
          .catch((err) => Promise.reject(err));
      }

      isRefreshing = true;
      const refreshToken = localStorage.getItem("refreshToken");

      try {
        const { data } = await axios.post(
          `${import.meta.env.VITE_API_URL}/api/Auth/refresh`,
          { refreshToken },
          { headers: { "Content-Type": "application/json" } }
        );

        const { token, refreshToken: newRefreshToken } = data;

        localStorage.setItem("authToken", token);
        localStorage.setItem("refreshToken", newRefreshToken);

        api.defaults.headers.common.Authorization = `Bearer ${token}`;
        originalRequest.headers.Authorization = `Bearer ${token}`;

        processQueue(null, token);
        return api(originalRequest);
      } catch (err) {
        processQueue(err, null);
        localStorage.removeItem("authToken");
        localStorage.removeItem("refreshToken");
        localStorage.removeItem("userData");
        window.location.href = "/login";
        return Promise.reject(err);
      } finally {
        isRefreshing = false;
      }
    }

    return Promise.reject(error);
  }
);

// Export all the individual service modules:
export { default as authService } from "./api/authService";
export { default as userService } from "./api/userService";
export { default as jobService } from "./api/jobService";
export { default as countryService } from "./api/countryService";
export { default as studyFieldService } from "./api/studyFieldService";
export { default as postService } from "./api/postService";
export { default as likeService } from "./api/likeService";

export default api;
