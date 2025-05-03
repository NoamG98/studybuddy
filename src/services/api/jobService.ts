import { Job, JobCreateDto, JobApplicationDto } from "@/models/job";
import api from "../api";

export const jobService = {
  getJobs: async (
    query?: string,
    country?: string,
    remoteOption?: string
  ): Promise<Job[]> => {
    let url = "/api/Jobs?";
    if (query) url += `query=${encodeURIComponent(query)}&`;
    if (country) url += `country=${encodeURIComponent(country)}&`;
    if (remoteOption) url += `remoteOption=${encodeURIComponent(remoteOption)}&`;
    const { data } = await api.get<Job[]>(url);
    return data;
  },
  getJob: async (id: string): Promise<Job> => {
    const { data } = await api.get<Job>(`/api/Jobs/${id}`);
    return data;
  },
  createJob: async (jobData: JobCreateDto): Promise<Job> => {
    const { data } = await api.post<Job>("/api/Jobs", jobData);
    return data;
  },
  applyForJob: async (
    jobId: string,
    applicationData: Omit<JobApplicationDto, "jobId" | "id" | "status" | "appliedAt">
  ): Promise<JobApplicationDto> => {
    const { data } = await api.post<JobApplicationDto>(
      `/api/Jobs/${jobId}/applications`,
      applicationData
    );
    return data;
  },
  getJobApplications: async (jobId: string): Promise<JobApplicationDto[]> => {
    const { data } = await api.get<JobApplicationDto[]>(`/api/Jobs/${jobId}/applications`);
    return data;
  },
};

export default jobService;
