import React, { useEffect, useState } from "react";
import axios from "axios";

interface UserData {
  firstName: string;
  lastName: string;
  education: string;
  status: string;
}

const About: React.FC<{ userId: string }> = ({ userId }) => {
  const [userData, setUserData] = useState<UserData | null>(null);

  useEffect(() => {
    const fetchUserData = async () => {
      try {
        const response = await axios.get(`http://localhost:5000/api/Users/${userId}`);
        setUserData(response.data);
      } catch (error) {
        console.error("Error fetching user data:", error);
      }
    };

    fetchUserData();
  }, [userId]);

  return (
    <div>
      <h2>About Me</h2>
      {userData ? (
        <>
          <p>
            <strong>Name:</strong> {userData.firstName} {userData.lastName}
          </p>
          <p>
            <strong>Education:</strong> {userData.education}
          </p>
          <p>
            <strong>Status:</strong> {userData.status}
          </p>
        </>
      ) : (
        <p>Loading...</p>
      )}
    </div>
  );
};

export default About;
