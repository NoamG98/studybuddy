import React from "react";
import { useAuth } from "../../context/AuthContext.tsx";
import { Search, Notifications, Message, Home } from "@mui/icons-material";
import Feed from "../feed/Feed.tsx";
import "../../styles/Layout.css";

const Layout: React.FC = () => {
  const { user, loading } = useAuth();

  return (
    <div className="layout">
      <div className="navbar">
        <div className="navbar-left">
          <span className="navbar-logo">StudyBuddy</span>
          <div className="navbar-search">
            <Search />
            <input
              type="text"
              placeholder="Search"
              onChange={(e) => console.log(e.target.value)}
            />
          </div>
        </div>
        <div className="navbar-right">
          <Home className="navbar-icon" />
          <Notifications className="navbar-icon" onClick={() => alert("Notifications clicked!")} />
          <Message className="navbar-icon" onClick={() => alert("Messages clicked!")} />
          <img
            src={loading ? "https://via.placeholder.com/40" : user?.profilePicture || "https://via.placeholder.com/40"}
            alt="Profile"
            className="navbar-profile-pic"
          />
        </div>
      </div>
      <div className="main-content">
        <Feed />
      </div>
    </div>
  );
};

export default Layout;
