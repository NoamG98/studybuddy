
export interface MentorshipDto {
  id: string;
  mentorId: string;
  mentorName?: string;
  menteeId: string;
  menteeName?: string;
  status: string;
  createdAt: string;
  updatedAt: string;
}

export interface MentorDto {
  id: string;
  userId: string;
  userName?: string;
  userAvatar?: string;
  field: string;
  experience: number;
  description: string;
}
