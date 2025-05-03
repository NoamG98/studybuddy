using StudyBuddy.Models;

namespace StudyBuddy.Services
{
    public interface IActivityService
    {
        Task<List<Activity>> GetAllActivitiesAsync();
        Task<Activity?> GetActivityByIdAsync(Guid id);
        Task<Activity> CreateActivityAsync(Activity activity);
        Task<bool> DeleteActivityAsync(Guid id);
    }
}