using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models.Mapping
{
    public class SubmissionMapping : IEntityTypeConfiguration<Submission>
    {
        public void Configure(EntityTypeBuilder<Submission> builder)
        {
            builder.ToTable(nameof(Submission).ToLower());

            builder.HasKey(s => new { s.UserId, s.ChallengeId });

            builder.Property(s => s.UserId)
                .HasColumnName("user_id");

            builder.Property(s => s.ChallengeId)
                .HasColumnName("challenge_id");

            builder.Property(s => s.Score)
                .HasColumnName("score")
                .IsRequired();

            builder.Property(s => s.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired();


            builder.HasOne(s => s.User)
                .WithMany(u => u.Submissions);

            builder.HasOne(s => s.Challenge)
                .WithMany(c => c.Submissions);
        }
    }
}
