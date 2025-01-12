import React, { useEffect } from "react";
import { useNavigate } from "react-router-dom";
import "../../styles/Register.css";

const RegistrationSuccessPage: React.FC = () => {
  const navigate = useNavigate();

  useEffect(() => {
    const timer = setTimeout(() => {
      navigate("/login");
    }, 5000); 
    return () => clearTimeout(timer);
  }, [navigate]);

  return (
    <div className="form-container">
      <h1 className="form-title">Registration Successful!</h1>
      <p>Welcome to StudyBuddy, the social network for students!</p>
      <p>You will be redirected to the login page shortly.</p>
    </div>
  );
};

export default RegistrationSuccessPage;
