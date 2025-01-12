import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";
import "../styles/Register.css";

const LoginPage: React.FC = () => {
  const [email, setEmail] = useState<string>("");
  const [password, setPassword] = useState<string>("");
  const [error, setError] = useState<string | null>(null);
  const navigate = useNavigate();

  const handleLogin = async (e: React.FormEvent) => {
    e.preventDefault();
    try {
      const response = await axios.post(
        "http://localhost:5000/api/Users/login",
        { email, password }
      );

      const user = response.data.user;
      sessionStorage.setItem("user", JSON.stringify(user));

      navigate("/"); 
    } catch (err: any) {
      console.error("Login failed:", err);
      setError(
        err.response?.data?.message || "Login failed. Please try again."
      );
    }
  };

  return (
    <div className="form-container">
      <h2>Login</h2>
      {error && <p className="error-message">{error}</p>}
      <form onSubmit={handleLogin}>
        <div className="form-group">
          <label htmlFor="email">Email:</label>
          <input
            id="email"
            type="email"
            placeholder="Enter your email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            required
            autoComplete="email"
          />
        </div>
        <div className="form-group">
          <label htmlFor="password">Password:</label>
          <input
            id="password"
            type="password"
            placeholder="Enter your password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            required
            autoComplete="current-password"
          />
        </div>
        <button type="submit" className="btn-submit">
          Login
        </button>
      </form>
      <div className="form-footer">
        <p>
          Don't have an account? <a href="/register">Register</a>
        </p>
        <p>
          <a href="/reset-password">Forgot your password?</a>
        </p>
      </div>
    </div>
  );
};

export default LoginPage;
