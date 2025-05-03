
export interface Job {
  id: string;
  title: string;
  company: {
    id: string;
    name: string;
    logo?: string;
  };
  location: {
    country: string;
    city: string;
    remoteOption?: "remote" | "hybrid" | "on-site";
  };
  experienceLevel: string;
  salary?: {
    min: number;
    max: number;
    currency: string;
  };
  tags: string[];
  postedAt: string;
  description: string;
  requirements: string;
  type: string;
  level: string;
  postedBy: string;
  deadline?: string;
  isRemote: boolean;
  contactEmail: string;
  companyLogo?: string;
}

export interface JobCreateDto {
  title: string;
  company: string;
  location: string;
  description: string;
  requirements: string;
  salary: string;
  type: string;
  level: string;
  deadline?: string;
  isRemote: boolean;
  contactEmail: string;
  companyLogo?: string;
}

export interface JobApplicationDto {
  id: string;
  jobId: string;
  userId: string;
  userName: string;
  userEmail: string;
  resumeUrl?: string;
  coverLetter?: string;
  status: string;
  appliedAt: string;
}
