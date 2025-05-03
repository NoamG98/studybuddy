using Microsoft.EntityFrameworkCore;
using StudyBuddy.Models;

namespace StudyBuddy.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        // Added FriendRequests DbSet
        public DbSet<FriendRequest> FriendRequests { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<Mentorship> Mentorships { get; set; }
        public DbSet<JobRecommendation> JobRecommendations { get; set; }
        public DbSet<LeaderboardEntry> LeaderboardEntries { get; set; }
        public DbSet<Mentor> Mentors { get; set; }

        public DbSet<StudyField> StudyFields { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Friendship
            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.User)
                .WithMany(u => u.Friends)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.Friend)
                .WithMany()
                .HasForeignKey(f => f.FriendId)
                .OnDelete(DeleteBehavior.Restrict);

            // ChatMessage
            modelBuilder.Entity<ChatMessage>()
                .HasOne(m => m.Sender)
                .WithMany()
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChatMessage>()
                .HasOne(m => m.Receiver)
                .WithMany()
                .HasForeignKey(m => m.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            // Like: Cascade when Post is deleted, Restrict when User is deleted
            modelBuilder.Entity<Like>()
                .HasOne(l => l.Post)
                .WithMany(p => p.Likes)
                .HasForeignKey(l => l.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Like>()
                .HasOne(l => l.User)
                .WithMany(u => u.Likes)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Comment: Cascade when Post is deleted, Restrict when User is deleted
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Post)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Notification
            modelBuilder.Entity<Notification>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notifications)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Post
            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Activity
            modelBuilder.Entity<Activity>()
                .HasOne(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // LeaderboardEntry
            modelBuilder.Entity<LeaderboardEntry>()
                .HasOne(l => l.User)
                .WithMany()
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Mentor
            modelBuilder.Entity<Mentor>()
                .HasOne(m => m.User)
                .WithMany()
                .HasForeignKey(m => m.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Mentorship>()
                .HasOne(m => m.Mentor)
                .WithMany()
                .HasForeignKey(m => m.MentorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Mentorship>()
                .HasOne(m => m.Mentee)
                .WithMany()
                .HasForeignKey(m => m.MenteeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Community)
                .WithMany(c => c.Members)
                .HasForeignKey(u => u.CommunityId)
                .OnDelete(DeleteBehavior.SetNull);

            // FriendRequest: Restrict deletes on both sides
            modelBuilder.Entity<FriendRequest>()
                .HasOne(fr => fr.FromUser)
                .WithMany()
                .HasForeignKey(fr => fr.FromUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FriendRequest>()
                .HasOne(fr => fr.ToUser)
                .WithMany()
                .HasForeignKey(fr => fr.ToUserId)
                .OnDelete(DeleteBehavior.Restrict);

            DbSeeder.Seed(modelBuilder);
        }
    }
}
