export interface LoginRequest {
  email: string; 
  password: string;
}

export interface RegisterRequest {
  firstName: string;
  lastName: string;
  email: string;
  password: string;
  role: string;
  country: string;
  city: string;
  gender: string;
  dateOfBirth: string;
  avatarUrl?: string;
  studyField?: string;
}

export interface AuthResponse {
  token: string;
  refreshToken: string;
  role: string;
}
