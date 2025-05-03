
export interface ActivityDto {
  id: string;
  userId: string;
  type: string;
  action: string;
  targetId: string;
  targetType: string;
  createdAt: string;
  details?: string;
}
