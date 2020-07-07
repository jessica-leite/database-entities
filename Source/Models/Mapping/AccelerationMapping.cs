using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models.Mapping
{
    public class AccelerationMapping : IEntityTypeConfiguration<Acceleration>
    {
        public void Configure(EntityTypeBuilder<Acceleration> builder)
        {
            builder.ToTable(nameof(Acceleration).ToLower());

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .HasColumnName("id");

            builder.Property(a => a.Name)
                .HasColumnName("name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(a => a.Slug)
                .HasColumnName("slug")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired();

            builder.Property(a => a.ChallengeId)
                .HasColumnName("challenge_id");

            builder.HasOne(a => a.Challenge)
                .WithMany(c => c.Accelerations);
        }
    }
}
