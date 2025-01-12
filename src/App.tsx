import React, { useEffect, useState, createContext, useContext } from "react";
import { BrowserRouter as Router, Routes, Route, Navigate } from "react-router-dom";
import axios from "axios";
import LoginPage from "./pages/LoginPage.tsx";
import RegisterPage from "./pages/RegisterPage.tsx";
import HomePage from "./pages/HomePage.tsx";
import ResetPasswordPage from "./components/auth/ResetPasswordPage.tsx";
import NewPasswordPage from "./components/auth/NewPasswordPage.tsx";
import RegistrationSuccessPage from "./components/auth/RegistrationSuccessPage.tsx";


export const AuthContext = createContext<{
  user: any;
  setUser: React.Dispatch<any>;
}>({
  user: null,
  setUser: () => {},
});


const AuthProvider: React.FC<{ children: React.ReactNode }> = ({ children }) => {
  const [user, setUser] = useState(() => {
    const savedUser = sessionStorage.getItem("user");
    return savedUser ? JSON.parse(savedUser) : null;
  });

  useEffect(() => {
    const fetchUser = async () => {
      try {
        const response = await axios.get("http://localhost:5000/api/Users/current");
        setUser(response.data);
      } catch (err) {
        console.error("Failed to fetch user:", err);
        setUser(null);
      }
    };

    if (!user) fetchUser();
  }, [user]);

  return (
    <AuthContext.Provider value={{ user, setUser }}>
      {children}
    </AuthContext.Provider>
  );
};


export const useAuth = () => {
  const context = useContext(AuthContext);
  if (!context) {
    throw new Error("useAuth must be used within an AuthProvider");
  }
  return context;
};


const App: React.FC = () => {
  return (
    <AuthProvider>
      <Router>
        <Routes>
          <Route path="/" element={<PrivateRoute />}>
            <Route path="/" element={<HomePage />} />
          </Route>
          <Route path="/login" element={<LoginPage />} />
          <Route path="/register" element={<RegisterPage />} />
          <Route path="/reset-password" element={<ResetPasswordPage />} />
          <Route path="/new-password" element={<NewPasswordPage />} />
          <Route path="/registration-success" element={<RegistrationSuccessPage />} />
        </Routes>
      </Router>
    </AuthProvider>
  );
};


const PrivateRoute: React.FC<{ children?: React.ReactNode }> = ({ children }) => {
  const { user } = useAuth();
  return user ? <>{children}</> : <Navigate to="/login" replace />;
};

export default App;
