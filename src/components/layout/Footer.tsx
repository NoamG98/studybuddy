import { Link } from "react-router-dom";
import useAuth from "@/contexts/useAuth";

export const Footer = () => {
  const currentYear = new Date().getFullYear();
  const { isAuthenticated } = useAuth();

  return (
    <footer className="bg-secondary py-12 mt-24">
      <div className="container mx-auto px-4">
        <div className="grid grid-cols-1 md:grid-cols-4 gap-8">
          <div>
            <h3 className="font-bold text-lg mb-4">StudyBuddy</h3>
            <p className="text-muted-foreground">
              Connect with students, graduates, and employers in your field and region.
            </p>
          </div>

          {isAuthenticated && (
            <div>
              <h4 className="font-semibold mb-4">Platform</h4>
              <ul className="space-y-2">
                <li>
                  <Link to="/home" className="text-muted-foreground hover:text-primary transition-colors">
                    Home
                  </Link>
                </li>
                <li>
                  <Link to="/community" className="text-muted-foreground hover:text-primary transition-colors">
                    Community
                  </Link>
                </li>
                <li>
                  <Link to="/jobs" className="text-muted-foreground hover:text-primary transition-colors">
                    Jobs
                  </Link>
                </li>
              </ul>
            </div>
          )}

          <div>
            <h4 className="font-semibold mb-4">Support</h4>
            <ul className="space-y-2">
              <li>
                <Link to="/help" className="text-muted-foreground hover:text-primary transition-colors">
                  Help Center
                </Link>
              </li>
              <li>
                <Link to="/privacy" className="text-muted-foreground hover:text-primary transition-colors">
                  Privacy Policy
                </Link>
              </li>
              <li>
                <Link to="/terms" className="text-muted-foreground hover:text-primary transition-colors">
                  Terms of Service
                </Link>
              </li>
            </ul>
          </div>

          <div>
            <h4 className="font-semibold mb-4">Contact</h4>
            <ul className="space-y-2">
              <li className="text-muted-foreground">
                Email: support@studybuddy.com
              </li>
              <li className="text-muted-foreground">
                Phone: +1 (555) 123-4567
              </li>
            </ul>
          </div>
        </div>

        <div className="border-t border-border mt-8 pt-8 flex flex-col md:flex-row justify-between items-center">
          <p className="text-muted-foreground text-sm">
            © {currentYear} StudyBuddy. All rights reserved.
          </p>

          <div className="flex space-x-4 mt-4 md:mt-0">
            <select
              className="bg-transparent border border-border rounded-md text-sm p-1"
              aria-label="Select language"
              title="Language selector"
            >
              <option value="en">English</option>
              <option value="he">עברית</option>
              <option value="es">Español</option>
              <option value="ru">Русский</option>
              <option value="ar">العربية</option>
            </select>
          </div>
        </div>
      </div>
    </footer>
  );
};
