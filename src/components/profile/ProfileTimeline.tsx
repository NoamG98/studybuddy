import React, { useEffect, useState } from "react";
import axios from "axios";
import Post from "../posts/Post.tsx";
import "../../styles/Layout.css";

interface PostData {
  id: number;
  author: string;
  content: string;
  createdAt: string;
  profilePicture: string;
}

const ProfileTimeline: React.FC = () => {
  const [posts, setPosts] = useState<PostData[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchPosts = async () => {
      try {
        const response = await axios.get<PostData[]>("/api/UserPosts");
        setPosts(response.data);
        setLoading(false);
      } catch (err) {
        console.error("Error fetching timeline posts:", err);
        setError("Failed to fetch timeline posts.");
        setLoading(false);
      }
    };

    fetchPosts();
  }, []);

  return (
    <div className="profile-timeline">
      <h2 className="timeline-title">Timeline</h2>
      {loading && <p>Loading timeline...</p>}
      {error && <p className="error">{error}</p>}
      {!loading && !error && posts.length === 0 && <p>No posts available.</p>}
      <div className="timeline-posts">
        {!loading &&
          !error &&
          posts.map((post) => (
            <Post
              key={post.id}
              author={post.author}
              content={post.content}
              time={new Date(post.createdAt).toLocaleString()}
              profilePicture={post.profilePicture}
            />
          ))}
      </div>
    </div>
  );
};

export default ProfileTimeline;
