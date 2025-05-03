
export interface User {
  id: string;
  firstName: string;
  lastName: string;
  email: string;
  role: string;
  country: string;
  city: string;
  gender: string;
  dateOfBirth: string;
  avatarUrl?: string;
  studyField?: string;
  createdAt: string;
  updatedAt: string;
  
  // Community feature properties
  status?: string;
  profileImage?: string;
  fieldOfStudy?: string;
  location?: {
    city?: string;
    country?: string;
  };
  isFriend?: boolean;
  hasSentRequest?: boolean;
  hasReceivedRequest?: boolean;
}

export interface UserProfileResponse {
  id: string;
  firstName: string;
  lastName: string;
  email: string;
  role: string;
  country: string;
  city: string;
  studyField?: string;
  avatarUrl?: string;
}
