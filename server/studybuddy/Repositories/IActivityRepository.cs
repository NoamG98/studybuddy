using StudyBuddy.Models;

namespace StudyBuddy.Repositories
{
    public interface IActivityRepository
    {
        Task<List<Activity>> GetAllActivitiesAsync();
        Task<Activity?> GetActivityByIdAsync(Guid id);
        Task<Activity> CreateActivityAsync(Activity activity);
        Task<bool> DeleteActivityAsync(Guid id);
    }
}