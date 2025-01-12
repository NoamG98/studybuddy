import React from "react";
import ReactDOM from "react-dom/client";
import Layout from "./components/layout/Layout.tsx";
import Feed from "./components/feed/Feed.tsx";
import { AuthProvider } from "./context/AuthContext.tsx";

const root = ReactDOM.createRoot(
  document.getElementById("root") as HTMLElement
);

root.render(
  <React.StrictMode>
    <AuthProvider>
      <Layout>
        <Feed />
      </Layout>
    </AuthProvider>
  </React.StrictMode>
);
