using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models.Mapping
{
    public class CandidateMapping : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.ToTable(nameof(Candidate).ToLower());

            builder.HasKey(c => new { c.UserId, c.AccelerationId, c.CompanyId });

            builder.Property(c => c.UserId)
                .HasColumnName("user_id");

            builder.Property(c => c.AccelerationId)
                .HasColumnName("acceleration_id");

            builder.Property(c => c.CompanyId)
                .HasColumnName("company_id");

            builder.Property(c => c.Status)
                .HasColumnName("status")
                .IsRequired();

            builder.Property(c => c.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired();


            builder.HasOne(c => c.User)
                .WithMany(u => u.Candidates);

            builder.HasOne(c => c.Acceleration)
                .WithMany(a => a.Candidates);

            builder.HasOne(c => c.Company)
                .WithMany(c => c.Candidates);
        }
    }
}
