import React from "react";
import Layout from "../components/layout/Layout.tsx";
import Feed from "../components/feed/Feed.tsx";

const HomePage: React.FC = () => {
  return (
    <Layout>
      <div>
        <h1>Welcome to the HomePage</h1>
        <Feed />
      </div>
    </Layout>
  );
};

export default HomePage;
