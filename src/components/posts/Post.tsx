import React from "react";
import "../../styles/Layout.css";

interface PostProps {
  id: number;
  author: string;
  content: string;
  time: string;
  profilePicture: string;
  likes: number;
  onLike: () => void;
}

const Post: React.FC<PostProps> = ({
  author,
  content,
  time,
  profilePicture,
  likes,
  onLike,
}) => {
  return (
    <div className="post">
      <div className="post-header">
        <img src={profilePicture} alt="Profile" className="post-profile-pic" />
        <div className="post-info">
          <h3 className="post-author">{author}</h3>
          <p className="post-time">{time}</p>
        </div>
      </div>
      <div className="post-content">
        <p>{content}</p>
      </div>
      <div className="post-actions">
        <button className="post-action" onClick={onLike}>
          Like ({likes})
        </button>
        <button className="post-action">Comment</button>
        <button className="post-action">Share</button>
      </div>
    </div>
  );
};

export default Post;
