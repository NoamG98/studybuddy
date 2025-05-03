
import { Button } from "@/components/ui/button";
import { Card, CardContent, CardFooter } from "@/components/ui/card";
import { Badge } from "@/components/ui/badge";
import { Avatar, AvatarFallback, AvatarImage } from "@/components/ui/avatar";
import { Link } from "react-router-dom";
import { useState } from "react";
import { toast } from "sonner";
import { Job } from "@/models/job"; 

export const JobCard = ({ job }: { job: Job }) => {
  const [isApplying, setIsApplying] = useState(false);
  const [hasApplied, setHasApplied] = useState(false);

  const handleApply = () => {
    setIsApplying(true);
    
    // Simulate API call
    setTimeout(() => {
      toast.success(`Application submitted for ${job.title}`);
      setIsApplying(false);
      setHasApplied(true);
    }, 1500);
  };

  const formatDate = (dateString: string) => {
    const date = new Date(dateString);
    const now = new Date();
    const diffTime = Math.abs(now.getTime() - date.getTime());
    const diffDays = Math.floor(diffTime / (1000 * 60 * 60 * 24));
    
    if (diffDays === 0) {
      return "Today";
    } else if (diffDays === 1) {
      return "Yesterday";
    } else {
      return `${diffDays} days ago`;
    }
  };

  const formatSalary = (salary?: Job["salary"]) => {
    if (!salary) return "Salary not specified";
    
    return `${salary.currency} ${salary.min.toLocaleString()} - ${salary.max.toLocaleString()}`;
  };

  return (
    <Card className="overflow-hidden h-full">
      <CardContent className="p-6">
        <div className="flex justify-between items-start mb-4">
          <div className="flex items-center space-x-4">
            <Avatar className="h-12 w-12">
              <AvatarImage src={job.company.logo} />
              <AvatarFallback className="text-sm">
                {job.company.name.charAt(0)}
              </AvatarFallback>
            </Avatar>
            
            <div>
              <h3 className="font-semibold text-lg">{job.title}</h3>
              <Link
                to={`/company/${job.company.id}`}
                className="text-muted-foreground hover:underline"
              >
                {job.company.name}
              </Link>
            </div>
          </div>
          
          <span className="text-xs text-muted-foreground">
            {formatDate(job.postedAt)}
          </span>
        </div>
        
        <div className="space-y-3">
          <div className="flex items-center space-x-1">
            <span className="text-muted-foreground text-sm">Location:</span>
            <span className="text-sm">
              {job.location.city}, {job.location.country}
              {job.location.remoteOption && ` (${job.location.remoteOption})`}
            </span>
          </div>
          
          <div className="flex items-center space-x-1">
            <span className="text-muted-foreground text-sm">Experience:</span>
            <span className="text-sm">{job.experienceLevel}</span>
          </div>
          
          <div className="flex items-center space-x-1">
            <span className="text-muted-foreground text-sm">Salary:</span>
            <span className="text-sm">{formatSalary(job.salary)}</span>
          </div>
          
          <p className="text-sm line-clamp-3 mt-2">{job.description}</p>
          
          <div className="flex flex-wrap gap-2 mt-3">
            {job.tags.map((tag, index) => (
              <Badge key={index} variant="outline">
                {tag}
              </Badge>
            ))}
          </div>
        </div>
      </CardContent>
      
      <CardFooter className="bg-secondary/50 p-4">
        <div className="w-full flex justify-between items-center">
          <Link
            to={`/jobs/${job.id}`}
            className="text-primary hover:underline text-sm"
          >
            View Details
          </Link>
          
          <Button 
            onClick={handleApply} 
            disabled={isApplying || hasApplied}
            size="sm"
          >
            {isApplying ? "Applying..." : hasApplied ? "Applied" : "Quick Apply"}
          </Button>
        </div>
      </CardFooter>
    </Card>
  );
};
