import React, { useState, useEffect } from "react";
import axios from "axios";

interface Activity {
  id: number;
  description: string;
}

const ActivityFeeds: React.FC = () => {
  const [activities, setActivities] = useState<Activity[]>([]);

  useEffect(() => {
    const fetchActivities = async () => {
      try {
        const response = await axios.get("http://localhost:5000/api/Activities");
        setActivities(response.data);
      } catch (error) {
        console.error("Error fetching activities:", error);
      }
    };

    fetchActivities();
  }, []);

  return (
    <div>
      <h2>Recent Activities</h2>
      <ul>
        {activities.map((activity) => (
          <li key={activity.id}>{activity.description}</li>
        ))}
      </ul>
    </div>
  );
};

export default ActivityFeeds;
