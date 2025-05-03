import { Button } from "@/components/ui/button";
import useAuth from "@/contexts/useAuth";
interface JobsHeaderProps {
  onPostJobClick: () => void;
}

export const JobsHeader = ({ onPostJobClick }: JobsHeaderProps) => {
  const { user, isAuthenticated } = useAuth();
  
  // Only allow employers to post jobs
  const canPostJob = isAuthenticated && user?.role === "Employer";
  
  return (
    <div className="flex justify-between items-center mb-8">
      <div>
        <h1 className="text-3xl font-bold mb-2">Jobs</h1>
        <p className="text-muted-foreground">
          Find entry-level and early-career opportunities
        </p>
      </div>
      
      {canPostJob && (
        <Button onClick={onPostJobClick}>Post a Job</Button>
      )}
    </div>
  );
};
