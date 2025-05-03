using Microsoft.EntityFrameworkCore;
using StudyBuddy.Data;
using StudyBuddy.Models;

namespace StudyBuddy.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly ApplicationDbContext _context;

        public ActivityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Activity>> GetAllActivitiesAsync()
        {
            return await _context.Activities.ToListAsync();
        }

        public async Task<Activity?> GetActivityByIdAsync(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }

        public async Task<Activity> CreateActivityAsync(Activity activity)
        {
            _context.Activities.Add(activity);
            await _context.SaveChangesAsync();
            return activity;
        }

        public async Task<bool> DeleteActivityAsync(Guid id)
        {
            var activity = await _context.Activities.FindAsync(id);
            if (activity == null)
                return false;

            _context.Activities.Remove(activity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}