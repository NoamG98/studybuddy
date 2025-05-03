import { Link } from "react-router-dom";
import { LoginForm } from "@/components/auth/LoginForm";
import Navbar from "@/components/layout/Navbar";
import { Footer } from "@/components/layout/Footer";

const Login = () => {
  return (
    <div className="min-h-screen flex flex-col bg-background text-foreground">
      <Navbar />
      
      <div className="flex-1 flex items-center justify-center px-4 py-16">
        <div className="w-full max-w-md">
          <div className="text-center mb-8">
            <Link to="/" className="inline-block">
              <h1 className="text-3xl font-bold text-studybuddy-700 dark:text-studybuddy-400">
                StudyBuddy
              </h1>
            </Link>
            <h2 className="text-2xl font-bold mt-6 mb-2 text-foreground">Welcome back</h2>
            <p className="text-muted-foreground">
              Log in to continue to your account
            </p>
          </div>
          
          <div className="bg-card text-card-foreground border border-border rounded-lg shadow-sm p-6">
            <LoginForm />
          </div>
        </div>
      </div>
      
      <Footer />
    </div>
  );
};

export default Login;
