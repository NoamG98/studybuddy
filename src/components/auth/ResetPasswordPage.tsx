import React, { useState } from "react";
import axios from "axios";

const ResetPasswordPage: React.FC = () => {
  const [email, setEmail] = useState("");
  const [message, setMessage] = useState("");
  const [error, setError] = useState("");

  const handleResetPassword = async (e: React.FormEvent) => {
    e.preventDefault();
    try {
      await axios.post("/api/Users/reset-password", { email });
      setMessage("Reset link sent to your email.");
      setError("");
    } catch (err) {
      setError("Failed to send reset link. Please try again.");
      setMessage("");
    }
  };

  return (
    <div className="form-container">
      <h1 className="form-title">Reset Password</h1>
      <form onSubmit={handleResetPassword}>
        <div className="form-group">
          <label htmlFor="email">Enter your email:</label>
          <input
            type="email"
            id="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            required
          />
        </div>
        <button className="form-button" type="submit">
          Send Reset Link
        </button>
      </form>
      {message && <p className="success-message">{message}</p>}
      {error && <p className="error-message">{error}</p>}
    </div>
  );
};

export default ResetPasswordPage;
