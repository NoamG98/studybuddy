import React, { useEffect, useState } from "react";
import axios from "axios";

interface FriendRequest {
  id: number;
  senderName: string;
}

const FriendRequests: React.FC = () => {
  const [requests, setRequests] = useState<FriendRequest[]>([]);

  useEffect(() => {
    const fetchRequests = async () => {
      try {
        const response = await axios.get("http://localhost:5000/api/FriendRequests");
        setRequests(response.data);
      } catch (error) {
        console.error("Error fetching friend requests:", error);
      }
    };

    fetchRequests();
  }, []);

  return (
    <div>
      <h2>Friend Requests</h2>
      <ul>
        {requests.map((req) => (
          <li key={req.id}>
            {req.senderName}
            <button>Accept</button>
            <button>Decline</button>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default FriendRequests;
