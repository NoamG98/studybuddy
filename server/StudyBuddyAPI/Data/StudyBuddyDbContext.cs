using Microsoft.EntityFrameworkCore;
using StudyBuddyAPI.Models;

namespace StudyBuddyAPI.Data
{
    public class StudyBuddyDbContext : DbContext
    {
        public StudyBuddyDbContext(DbContextOptions<StudyBuddyDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<StudyField> StudyFields { get; set; }
        public DbSet<UserStudyField> UserStudyFields { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Message> Messages { get; set; } // Added Messages
        public DbSet<GroupMessage> GroupMessages { get; set; } // Added Group Messages

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Email);

            modelBuilder.Entity<UserStudyField>()
                .HasKey(usf => new { usf.UserEmail, usf.StudyFieldId });

            modelBuilder.Entity<UserStudyField>()
                .HasOne(usf => usf.User)
                .WithMany(u => u.UserStudyFields)
                .HasForeignKey(usf => usf.UserEmail);

            modelBuilder.Entity<UserStudyField>()
                .HasOne(usf => usf.StudyField)
                .WithMany(sf => sf.UserStudyFields)
                .HasForeignKey(usf => usf.StudyFieldId);

            modelBuilder.Entity<Like>()
                .HasOne(l => l.User)
                .WithMany(u => u.Likes)
                .HasForeignKey(l => l.UserEmail)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Like>()
                .HasOne(l => l.Post)
                .WithMany(p => p.Likes)
                .HasForeignKey(l => l.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany()
                .HasForeignKey(m => m.SenderEmail)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany()
                .HasForeignKey(m => m.ReceiverEmail)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GroupMessage>()
                .HasOne(gm => gm.Group)
                .WithMany()
                .HasForeignKey(gm => gm.GroupId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<GroupMessage>()
                .HasOne(gm => gm.Sender)
                .WithMany()
                .HasForeignKey(gm => gm.SenderEmail)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
