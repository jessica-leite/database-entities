using Microsoft.EntityFrameworkCore;
using Source.Models;
using Source.Models.Mapping;

namespace Codenation.Challenge.Models
{
    public class CodenationContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Source.Models.Challenge> Challenges { get; set; }
        public DbSet<Acceleration> Accelerations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Codenation;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyMapping());
            modelBuilder.ApplyConfiguration(new ChallengeMapping());
            modelBuilder.ApplyConfiguration(new AccelerationMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new SubmissionMapping());
            modelBuilder.ApplyConfiguration(new CandidateMapping());
        }
    }
}