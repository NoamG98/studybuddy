import { useState, useEffect } from "react";
import Navbar from "@/components/layout/Navbar";
import { Footer } from "@/components/layout/Footer";
import { JobsHeader } from "@/components/jobs/JobsHeader";
import { JobsFilters } from "@/components/jobs/JobsFilters";
import { JobsList } from "@/components/jobs/JobsList";
import { CreateJobDialog } from "@/components/jobs/CreateJobDialog";
import { Button } from "@/components/ui/button";
import { jobService } from "@/services/api";
import useAuth from "@/contexts/useAuth";
import { toast } from "sonner";
import { Job, JobCreateDto } from "@/models/job";

const Jobs = () => {
  const [searchQuery, setSearchQuery] = useState("");
  const [selectedCountry, setSelectedCountry] = useState<string>("all");
  const [selectedRemoteOption, setSelectedRemoteOption] = useState<string>("all");
  const [dialogOpen, setDialogOpen] = useState(false);
  const [jobs, setJobs] = useState<Job[]>([]);
  const [isLoading, setIsLoading] = useState(true);
  const [error, setError] = useState<Error | null>(null);
  const { isAuthenticated } = useAuth();

  useEffect(() => {
    const fetchJobs = async () => {
      try {
        setIsLoading(true);
        setError(null);
        const fetched = await jobService.getJobs(
          searchQuery,
          selectedCountry,
          selectedRemoteOption
        );

        const formatted: Job[] = fetched.map((job: Partial<Job>) => ({
          id: job.id || "",
          title: job.title || "",
          company: job.company || { id: "", name: "", logo: "" },
          description: job.description || "",
          location: job.location || { city: "", country: "", remoteOption: "on-site" },
          salary: job.salary || { min: 0, max: 0, currency: "USD" },
          experienceLevel: job.experienceLevel || job.level || "Entry Level",
          level: job.level || job.experienceLevel || "Entry Level",
          tags: job.tags || [],
          requirements: job.requirements || "",
          type: job.type || "Full-time",
          postedBy: job.postedBy || "",
          isRemote: job.location?.remoteOption === "remote" || job.isRemote || false,
          contactEmail: job.contactEmail || "",
          companyLogo: job.companyLogo || "",
          postedAt: job.postedAt || new Date().toISOString(),
        }));

        setJobs(formatted);
      } catch (err) {
        console.error("Failed to fetch jobs:", err);
        setError(err instanceof Error ? err : new Error("Failed to load jobs"));
        toast.error("Failed to load jobs. Please try again.");
      } finally {
        setIsLoading(false);
      }
    };
    fetchJobs();
  }, [searchQuery, selectedCountry, selectedRemoteOption]);

  const handleJobPosted = async (data: {
    title?: string;
    company?: string;
    country?: string;
    city?: string;
    experienceLevel?: string;
    description?: string;
    agreeToTerms?: boolean;
    remoteOption?: string;
    salaryMin?: string;
    salaryMax?: string;
    currency?: string;
    tags?: string[];
  }) => {
    if (
      !data.title ||
      !data.company ||
      !data.country ||
      !data.city ||
      !data.experienceLevel ||
      !data.description
    ) {
      toast.error("Please fill in all required fields");
      return;
    }

    const jobData: JobCreateDto = {
      title: data.title,
      company: data.company,
      location: `${data.city}, ${data.country}`,
      description: data.description,
      level: data.experienceLevel,
      requirements: "",
      type: "Full-time",
      salary: `${data.salaryMin || 0}-${data.salaryMax || 0} ${data.currency || "USD"}`,
      contactEmail: "",
      companyLogo: "",
      isRemote: data.remoteOption === "remote",
    };

    try {
      await jobService.createJob(jobData);
      toast.success("Job posted successfully!");

      const refreshed = await jobService.getJobs(
        searchQuery,
        selectedCountry,
        selectedRemoteOption
      );
      setJobs(refreshed);
      setDialogOpen(false);
    } catch (err) {
      console.error("Failed to post job:", err);
      toast.error("Failed to post job. Please try again.");
    }
  };

  const handleResetFilters = () => {
    setSearchQuery("");
    setSelectedCountry("all");
    setSelectedRemoteOption("all");
  };

  return (
    <div className="min-h-screen flex flex-col bg-background text-foreground">
      <Navbar isAuthenticated={isAuthenticated} />
      <div className="flex-1 pt-16 bg-secondary/30">
        <div className="container mx-auto px-4 py-8">
          <JobsHeader onPostJobClick={() => setDialogOpen(true)} />
          <JobsFilters
            searchQuery={searchQuery}
            selectedCountry={selectedCountry}
            selectedRemoteOption={selectedRemoteOption}
            onSearchChange={setSearchQuery}
            onCountryChange={setSelectedCountry}
            onRemoteOptionChange={setSelectedRemoteOption}
          />
          <JobsList
            jobs={jobs}
            isLoading={isLoading}
            onResetFilters={handleResetFilters}
            error={error}
          />
        </div>
      </div>
      <CreateJobDialog
        open={dialogOpen}
        onOpenChange={setDialogOpen}
        onSubmit={handleJobPosted}
      />
      <Footer />
    </div>
  );
};

export default Jobs;
