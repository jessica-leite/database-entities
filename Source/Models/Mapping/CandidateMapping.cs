using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Source.Models.Mapping
{
    public class CandidateMapping : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.ToTable(nameof(Candidate).ToLower());

            builder.HasKey(c => new { c.UserId, c.AccelerationId, c.CompanyId });

            builder.Property(c => c.Status)
                .IsRequired();

            builder.Property(c => c.CreatedAt)
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
