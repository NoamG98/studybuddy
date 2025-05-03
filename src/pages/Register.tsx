
import { Link } from "react-router-dom";
import { RegisterForm } from "@/components/auth/RegisterForm";
import Navbar from "@/components/layout/Navbar";
import { Footer } from "@/components/layout/Footer";

const Register = () => {
  return (
    <div className="min-h-screen flex flex-col bg-background text-foreground">
      <Navbar />
      
      <div className="flex-1 flex items-center justify-center px-4 py-12">
        <div className="w-full max-w-2xl">
          <div className="text-center mb-8">
            <Link to="/" className="inline-block">
              <h1 className="text-3xl font-bold text-studybuddy-700 dark:text-studybuddy-400">
                StudyBuddy
              </h1>
            </Link>
            <h2 className="text-2xl font-bold mt-6 mb-2 text-foreground">Create your account</h2>
            <p className="text-muted-foreground">
              Connect with peers, mentors, and employers in your field
            </p>
          </div>
          
          <div className="bg-card text-card-foreground border border-border rounded-lg shadow-sm p-6">
            <RegisterForm />
          </div>
        </div>
      </div>
      
      <Footer />
    </div>
  );
};

export default Register;
