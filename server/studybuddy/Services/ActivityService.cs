using StudyBuddy.Models;
using StudyBuddy.Repositories;

namespace StudyBuddy.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public async Task<List<Activity>> GetAllActivitiesAsync()
        {
            return await _activityRepository.GetAllActivitiesAsync();
        }

        public async Task<Activity?> GetActivityByIdAsync(Guid id)
        {
            return await _activityRepository.GetActivityByIdAsync(id);
        }

        public async Task<Activity> CreateActivityAsync(Activity activity)
        {
            return await _activityRepository.CreateActivityAsync(activity);
        }

        public async Task<bool> DeleteActivityAsync(Guid id)
        {
            return await _activityRepository.DeleteActivityAsync(id);
        }
    }
}