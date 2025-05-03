
import { JobCard } from "@/components/jobs/JobCard";
import { Button } from "@/components/ui/button";
import { Job } from "@/models/job"; 
import { useState, useEffect } from "react";

interface JobsListProps {
  jobs: Job[];
  isLoading: boolean;
  onResetFilters: () => void;
  error?: Error | null;
}

export const JobsList = ({ 
  jobs, 
  isLoading, 
  onResetFilters,
  error
}: JobsListProps) => {
  const [showError, setShowError] = useState<boolean>(false);
  
  useEffect(() => {
    if (error) {
      setShowError(true);
    } else {
      setShowError(false);
    }
  }, [error]);

  if (isLoading) {
    return (
      <div className="text-center py-12">
        <p className="text-xl font-medium mb-2">Loading jobs...</p>
      </div>
    );
  }
  
  if (showError) {
    return (
      <div className="text-center py-12">
        <h3 className="text-xl font-medium mb-2 text-red-500">Error loading jobs</h3>
        <p className="text-muted-foreground mb-4">
          {error?.message || "Something went wrong. Please try again."}
        </p>
        <Button 
          variant="outline" 
          className="mt-4"
          onClick={() => setShowError(false)}
        >
          Dismiss
        </Button>
      </div>
    );
  }

  if (jobs.length === 0) {
    return (
      <div className="text-center py-12">
        <h3 className="text-xl font-medium mb-2">No jobs found</h3>
        <p className="text-muted-foreground">
          Try adjusting your search or filters
        </p>
        <Button 
          variant="outline" 
          className="mt-4"
          onClick={onResetFilters}
        >
          Reset Filters
        </Button>
      </div>
    );
  }

  return (
    <div className="grid grid-cols-1 lg:grid-cols-2 gap-6">
      {jobs.map((job) => (
        <JobCard key={job.id} job={job} />
      ))}
    </div>
  );
};
