import React, { useEffect, useState } from "react";
import axios from "axios";
import About from "./About.tsx";
import Gallery from "./Gallery.tsx";
import ProfileTabs from "./ProfileTabs.tsx";


interface Friend {
  id: number;
  name: string;
}

const FriendSection: React.FC = () => {
  const [friends, setFriends] = useState<Friend[]>([]);
  const [activeTab, setActiveTab] = useState<string>("about");

  useEffect(() => {
    const fetchFriends = async () => {
      try {
        const response = await axios.get<Friend[]>("http://localhost:7206/api/Friends");
        setFriends(response.data);
      } catch (error) {
        console.error("Error fetching friends:", error);
      }
    };
    fetchFriends();
  }, []);

  return (
    <div className="friend-section">
      <ProfileTabs activeTab={activeTab} setActiveTab={setActiveTab} />
      {activeTab === "about" && <About userId="currentUserId" />}
      {activeTab === "friends" && (
        <div className="friends-list">
          {friends.map((friend) => (
            <div key={friend.id}>{friend.name}</div>
          ))}
        </div>
      )}
      {activeTab === "gallery" && <Gallery />}
    </div>
  );
};

export default FriendSection;
