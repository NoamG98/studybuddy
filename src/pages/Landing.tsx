import { Link, useNavigate } from "react-router-dom";
import { useEffect } from "react";
import { Button } from "@/components/ui/button";
import Navbar from "@/components/layout/Navbar";
import { Footer } from "@/components/layout/Footer";
import { motion } from "framer-motion";
import useAuth from "@/contexts/useAuth";

const Landing = () => {
  const { isAuthenticated } = useAuth();
  const navigate = useNavigate();

  useEffect(() => {
    if (isAuthenticated) {
      navigate("/home");
    }
  }, [isAuthenticated, navigate]);

  return (
    <div className="min-h-screen flex flex-col bg-background text-foreground">
      <Navbar />

      {/* Hero Section */}
      <section className="pt-32 pb-20 md:pt-40 md:pb-28 px-4">
        <div className="container mx-auto text-center">
          <motion.h1
            className="text-4xl md:text-5xl lg:text-6xl font-bold mb-6 bg-gradient-to-r from-studybuddy-700 to-blue-600 bg-clip-text text-transparent"
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ duration: 0.6 }}
          >
            Connect. Learn. Grow.
          </motion.h1>
          <motion.p
            className="text-xl md:text-2xl text-muted-foreground mb-12 max-w-3xl mx-auto"
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ duration: 0.6, delay: 0.2 }}
          >
            StudyBuddy brings together students, graduates, and employers in your field and region for meaningful academic and career connections.
          </motion.p>

          {!isAuthenticated && (
            <motion.div
              className="flex flex-col sm:flex-row justify-center gap-4"
              initial={{ opacity: 0, y: 20 }}
              animate={{ opacity: 1, y: 0 }}
              transition={{ duration: 0.6, delay: 0.4 }}
            >
              <Link to="/register">
                <Button size="lg" className="px-8 py-6 text-lg">
                  Get Started
                </Button>
              </Link>
              <Link to="/login">
                <Button size="lg" variant="outline" className="px-8 py-6 text-lg">
                  Log In
                </Button>
              </Link>
            </motion.div>
          )}
        </div>
      </section>

      {/* Features Section */}
      <section className="py-20 px-4 bg-muted text-foreground">
        <div className="container mx-auto">
          <h2 className="text-3xl font-bold text-center mb-16">Connect With Your Academic Community</h2>
          <div className="grid grid-cols-1 md:grid-cols-3 gap-12">
            <div className="flex flex-col items-center text-center">
              <div className="h-16 w-16 rounded-full bg-accent text-accent-foreground flex items-center justify-center mb-6">
                <svg className="h-8 w-8" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M17 20h5v-2a3 3 0 00-5.356-1.857M17 20H7m10 0v-2c0-.656-.126-1.283-.356-1.857M7 20H2v-2a3 3 0 015.356-1.857M7 20v-2c0-.656.126-1.283.356-1.857m0 0a5.002 5.002 0 019.288 0M15 7a3 3 0 11-6 0 3 3 0 016 0zm6 3a2 2 0 11-4 0 2 2 0 014 0zM7 10a2 2 0 11-4 0 2 2 0 014 0z" />
                </svg>
              </div>
              <h3 className="text-xl font-semibold mb-3">Connect with Peers</h3>
              <p className="text-muted-foreground">Find and connect with students and professionals in your field and location.</p>
            </div>

            <div className="flex flex-col items-center text-center">
              <div className="h-16 w-16 rounded-full bg-accent text-accent-foreground flex items-center justify-center mb-6">
                <svg className="h-8 w-8" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M12 6.253v13m0-13C10.832 5.477 9.246 5 7.5 5S4.168 5.477 3 6.253v13C4.168 18.477 5.754 18 7.5 18s3.332.477 4.5 1.253m0-13C13.168 5.477 14.754 5 16.5 5c1.747 0 3.332.477 4.5 1.253v13C19.832 18.477 18.247 18 16.5 18c-1.746 0-3.332.477-4.5 1.253" />
                </svg>
              </div>
              <h3 className="text-xl font-semibold mb-3">Share Knowledge</h3>
              <p className="text-muted-foreground">Exchange ideas, ask questions, and learn from each other's experiences.</p>
            </div>

            <div className="flex flex-col items-center text-center">
              <div className="h-16 w-16 rounded-full bg-accent text-accent-foreground flex items-center justify-center mb-6">
                <svg className="h-8 w-8" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M21 13.255A23.931 23.931 0 0112 15c-3.183 0-6.22-.62-9-1.745M16 6V4a2 2 0 00-2-2h-4a2 2 0 00-2 2v2m4 6h.01M5 20h14a2 2 0 002-2V8a2 2 0 00-2-2H5a2 2 0 00-2 2v10a2 2 0 002 2z" />
                </svg>
              </div>
              <h3 className="text-xl font-semibold mb-3">Find Opportunities</h3>
              <p className="text-muted-foreground">Discover job openings specifically targeted at recent graduates and early-career positions.</p>
            </div>
          </div>
        </div>
      </section>

      {/* How It Works Section */}
      <section className="py-20 px-4">
        <div className="container mx-auto">
          <h2 className="text-3xl font-bold text-center mb-16">How StudyBuddy Works</h2>
          <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-8">
            <div className="flex flex-col items-center text-center">
              <div className="h-12 w-12 rounded-full bg-studybuddy-600 text-white flex items-center justify-center mb-6 text-xl font-bold">1</div>
              <h3 className="text-xl font-semibold mb-3">Create Your Profile</h3>
              <p className="text-muted-foreground">Sign up and share your academic background, interests, and goals.</p>
            </div>
            <div className="flex flex-col items-center text-center">
              <div className="h-12 w-12 rounded-full bg-studybuddy-600 text-white flex items-center justify-center mb-6 text-xl font-bold">2</div>
              <h3 className="text-xl font-semibold mb-3">Connect with Others</h3>
              <p className="text-muted-foreground">Find and connect with others in your field and location.</p>
            </div>
            <div className="flex flex-col items-center text-center">
              <div className="h-12 w-12 rounded-full bg-studybuddy-600 text-white flex items-center justify-center mb-6 text-xl font-bold">3</div>
              <h3 className="text-xl font-semibold mb-3">Share and Learn</h3>
              <p className="text-muted-foreground">Post updates, ask questions, and engage with your network.</p>
            </div>
            <div className="flex flex-col items-center text-center">
              <div className="h-12 w-12 rounded-full bg-studybuddy-600 text-white flex items-center justify-center mb-6 text-xl font-bold">4</div>
              <h3 className="text-xl font-semibold mb-3">Grow Your Career</h3>
              <p className="text-muted-foreground">Discover and apply for job opportunities tailored for your level of experience.</p>
            </div>
          </div>
        </div>
      </section>

      {/* CTA Section */}
      <section className="py-20 px-4 bg-studybuddy-700 text-white">
        <div className="container mx-auto text-center">
          <h2 className="text-3xl font-bold mb-6">Ready to Connect with Your Academic Network?</h2>
          <p className="text-xl mb-12 max-w-2xl mx-auto">Join thousands of students, graduates, and employers already building meaningful connections.</p>
          <Link to="/register">
            <Button size="lg" variant="secondary" className="px-8 py-6 text-lg">
              Join StudyBuddy Now
            </Button>
          </Link>
        </div>
      </section>

      <Footer />
    </div>
  );
};

export default Landing;