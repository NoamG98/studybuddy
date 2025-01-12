import React, { useEffect, useState } from "react";
import Post from "../posts/Post.tsx";
import API from "../../utils/API.ts";

const Feed: React.FC = () => {
  const [posts, setPosts] = useState([]);
  const [loading, setLoading] = useState(true);
  const [newPostContent, setNewPostContent] = useState("");

  const fetchPosts = async () => {
    try {
      const response = await API.get("/posts");
      setPosts(response.data);
    } catch (err) {
      console.error("Failed to fetch posts:", err);
    } finally {
      setLoading(false);
    }
  };

  useEffect(() => {
    fetchPosts();
  }, []);

  const handleAddPost = async () => {
    if (!newPostContent.trim()) {
      alert("Post content cannot be empty!");
      return;
    }

    try {
      const response = await API.post("/post", {
        content: newPostContent,
        userEmail: localStorage.getItem("userEmail") || "",
      });
      setPosts([response.data, ...posts]);
      setNewPostContent("");
    } catch (err: any) {
      console.error("Failed to add post:", err.response?.data || err.message);
      alert(err.response?.data?.message || "Failed to add post. Please try again.");
    }
  };

  const handleLike = async (postId: number) => {
    try {
        await API.post(`/posts/${postId}/like`);
        setPosts((prevPosts) =>
            prevPosts.map((post) =>
                post.id === postId ? { ...post, likes: post.likes + 1 } : post
            )
        );
    } catch (err: any) {
        console.error("Failed to like post:", err.response?.data || err.message);
        alert(err.response?.data?.message || "Failed to like the post. Please try again.");
    }
};


  return (
    <div className="feed-container">
      <div className="create-post">
        <textarea
          value={newPostContent}
          onChange={(e) => setNewPostContent(e.target.value)}
          placeholder="What's on your mind?"
        />
        <button onClick={handleAddPost}>Post</button>
      </div>
      {loading ? (
        <p>Loading posts...</p>
      ) : posts.length > 0 ? (
        posts.map((post) => (
          <Post
            key={post.id}
            id={post.id}
            author={post.author}
            content={post.content}
            time={new Date(post.createdAt).toLocaleString()}
            profilePicture={post.profilePicture || "https://via.placeholder.com/40"}
            likes={post.likes || 0}
            onLike={() => handleLike(post.id)}
          />
        ))
      ) : (
        <p>No posts available.</p>
      )}
    </div>
  );
};

export default Feed;
