using IELTS_assistant.Models;
using Microsoft.EntityFrameworkCore;

namespace IELTS_assistant.Data
{
    public interface IELTSAssistantContext : DbContext
    {
        public IELTSAssistantContext(DbContextOptions<IELTSAssistantContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<StudyMaterial> StudyMaterials { get; set; }
        public DbSet<PracticeTest> PracticeTests { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
        public DbSet<ProgressTracking> ProgressTrackings { get; set; }
        public DbSet<UserMaterial> UserMaterials { get; set; }
        public DbSet<UserTest> UserTests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMaterial>()
                .HasKey(um => new { um.UserID, um.MaterialID });
            modelBuilder.Entity<UserMaterial>()
                .HasOne(um => um.User)
                .WithMany(u => u.UserMaterial)
                .HasForeignKey(um => um.UserID);
            modelBuilder.Entity<UserMaterial>()
                .HasOne(um => um.StudyMaterial)
                .WithMany(sm => sm.UserMaterial)
                .HasForeignKey(um => um.MaterialID);

            modelBuilder.Entity<UserTest>()
                .HasKey(ut => new { ut.UserID, ut.TestID });
            modelBuilder.Entity<UserTest>()
                .HasOne(ut => ut.User)
                .WithMany(u => u.UserTest)
                .HasForeignKey(ut => ut.UserID);
            modelBuilder.Entity<UserTest>()
                .HasOne(ut => ut.PracticeTest)
                .WithMany(pt => pt.UserTests)
                .HasForeignKey(ut => ut.TestID);
        }
    }
}
