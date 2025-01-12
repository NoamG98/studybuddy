import React, { useState } from "react";
import "../styles/Profile.css";
import About from "../components/profile/About.tsx";
import Gallery from "../components/profile/Gallery.tsx";
import ProfileTimeline from "../components/profile/ProfileTimeline.tsx";
import API from "../utils/API.ts";

const ProfilePage: React.FC = () => {
  const [profilePicture, setProfilePicture] = useState<string>(
    "https://via.placeholder.com/100"
  );
  const [newProfilePicture, setNewProfilePicture] = useState<File | null>(null);
  const [statusMessage, setStatusMessage] = useState<string | null>(null);

  const handleFileChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    if (event.target.files && event.target.files[0]) {
      setNewProfilePicture(event.target.files[0]);
    }
  };

  const handleUpload = async () => {
    if (!newProfilePicture) {
      setStatusMessage("Please select a file first.");
      return;
    }

    const url = URL.createObjectURL(newProfilePicture);
    try {
      const response = await API.post("/Users/updateProfilePicture", {
        email: "user@example.com", 
        profilePictureUrl: url,
      });

      if (response.status === 200) {
        setProfilePicture(url);
        setStatusMessage("Profile picture updated successfully!");
      } else {
        throw new Error("Failed to update profile picture.");
      }
    } catch (err) {
      setStatusMessage("Failed to upload profile picture. Please try again.");
      console.error(err);
    }
  };

  return (
    <div className="profile-container">
      {/* Profile Header */}
      <div className="profile-header">
        <div className="profile-avatar">
          <label htmlFor="profilePictureUpload">Upload Profile Picture:</label>
          <img src={profilePicture} alt="Profile" />
          <input
            type="file"
            id="profilePictureUpload"
            onChange={handleFileChange}
            title="Choose a profile picture to upload"
          />
          <button onClick={handleUpload}>Upload</button>
          {statusMessage && <p className="status-message">{statusMessage}</p>}
        </div>
        <div className="profile-info">
          <h2>Your Name</h2>
          <p>Your Status or Bio Here</p>
        </div>
      </div>

      {/* Profile Tabs */}
      <div className="profile-tabs">
        <button>Timeline</button>
        <button>About</button>
        <button>Gallery</button>
      </div>

      {/* Profile Content */}
      <div className="profile-content">
        <About userId="1" />
        <Gallery />
        <ProfileTimeline />
      </div>
    </div>
  );
};

export default ProfilePage;
