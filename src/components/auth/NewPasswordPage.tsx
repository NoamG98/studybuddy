import React, { useState } from "react";
import axios from "axios";
import { useSearchParams } from "react-router-dom";
import "../../styles/Register.css";

const NewPasswordPage: React.FC = () => {
  const [password, setPassword] = useState("");
  const [message, setMessage] = useState("");
  const [error, setError] = useState("");
  const [searchParams] = useSearchParams();

  const handleReset = async (e: React.FormEvent) => {
    e.preventDefault();
    const token = searchParams.get("token");
    const email = searchParams.get("email");
    try {
      const response = await axios.post("/api/Users/new-password", {
        token,
        email,
        newPassword: password,
      });
      setMessage(response.data.message);
      setError("");
    } catch (err: any) {
      setError(err.response?.data || "An error occurred.");
      setMessage("");
    }
  };

  return (
    <div>
      <h1>Set New Password</h1>
      <form onSubmit={handleReset}>
        <input
          type="password"
          placeholder="Enter new password"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
          required
        />
        <button type="submit">Reset Password</button>
      </form>
      {message && <p>{message}</p>}
      {error && <p>{error}</p>}
    </div>
  );
};

export default NewPasswordPage;
